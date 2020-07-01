Imports C_Entidad
Imports C_Negocio
Public Class FrmAlmacenes
    Dim Op As String = ""
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCn_S As New Cn_Sedes
    Dim objCe_F As New Ce_Funcionarios
    Dim objCn_F As New Cn_Funcionarios

    Private Sub Botones1()
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub

    Private Sub Botones2()
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Habilitar()
        TbNombre.Enabled = True
        CbFunc.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbNombre.Enabled = False
        CbFunc.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbNombre.Text = ""
        CbEstado.Text = ""
        CbFunc.Text = ""
        CbSede.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarSedes()
        Dim ds As New DataSet
        CbSede.DataSource = Nothing
        CbSede.Items.Clear()
        Try
            ds = objCn_S.LoadSedesActivas
            If ds.Tables(0).Rows.Count > 0 Then
                CbSede.DataSource = ds.Tables(0)
                CbSede.DisplayMember = "Sede"
                CbSede.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarFuncinarios()
        Dim ds As New DataSet
        CbFunc.DataSource = Nothing
        CbFunc.Items.Clear()
        Try
            objCe_F.Sede = Val(CbSede.SelectedValue.ToString)
            ds = objCn_F.ListarFuncinarioSede(objCe_F)
            If ds.Tables(0).Rows.Count > 0 Then
                CbFunc.DataSource = ds.Tables(0)
                CbFunc.DisplayMember = "Nombre"
                CbFunc.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub FrmAlmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarSedes()
        Botones1()
        Limpiar()
        Inhabilitar()
        ListarAlmacenes()
    End Sub

    Private Sub CbSede_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSede.SelectedIndexChanged
        ListarFuncinarios()
    End Sub

    Private Sub CbSede_Click(sender As Object, e As EventArgs) Handles CbSede.Click
        ListarFuncinarios()
    End Sub

    Private Sub ListarAlmacenes()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_A.ListarAlmacenes
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        CbSede.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        CbSede.Focus()
    End Sub

    Private Function ExisteAlmacen(X) As Boolean
        Dim ds As New DataSet
        Try
            objCe_A.Nombre = UCase(TbNombre.Text.Trim)
            ds = objCn_A.ExisteAlmacen(X)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item(0) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub Nuevo()
        If Val(CbSede.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar la sede", MsgBoxStyle.Critical)
            CbSede.Focus()
            Exit Sub
        End If

        If Val(CbFunc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el funcionario responsable", MsgBoxStyle.Critical)
            CbFunc.Focus()
            Exit Sub
        End If

        If TbNombre.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre del almacén", MsgBoxStyle.Critical)
            TbNombre.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nuevo Almacén")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteAlmacen(UCase(TbNombre.Text.Trim)) = False Then
            If MsgBox("¿Confirma que desea registrar el almacén", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_A.Sede = Val(CbSede.SelectedValue.ToString)
                    objCe_A.Responsable = Val(CbFunc.SelectedValue.ToString)
                    objCe_A.Nombre = UCase(TbNombre.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_A.Estado = 1 : Else : objCe_A.Estado = 0 : End If
                    objCn_A.NuevoAlmacen(objCe_A)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarAlmacenes()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe un almacén registrado con el mismo nombre", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If Val(CbSede.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar la sede", MsgBoxStyle.Critical)
            CbSede.Focus()
            Exit Sub
        End If

        If Val(CbFunc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el funcionario responsable", MsgBoxStyle.Critical)
            CbFunc.Focus()
            Exit Sub
        End If

        If TbNombre.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre del almacén", MsgBoxStyle.Critical)
            TbNombre.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nuevo Almacén")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el almacén", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_A.Cons = Val(TbCons.Text.Trim)
                objCe_A.Sede = Val(CbSede.SelectedValue.ToString)
                objCe_A.Responsable = Val(CbFunc.SelectedValue.ToString)
                objCe_A.Nombre = UCase(TbNombre.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_A.Estado = 1 : Else : objCe_A.Estado = 0 : End If
                objCn_A.ModificarAlmacen(objCe_A)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarAlmacenes()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Op = ""
        Inhabilitar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el almacén", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_A.Cons = Val(TbCons.Text.Trim)
                objCn_A.EliminarAlmacen(objCe_A)
                Limpiar()
                ListarAlmacenes()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        CbSede.Text = Dgv.Item(1, i).Value
        CbFunc.Text = Dgv.Item(3, i).Value
        TbNombre.Text = Dgv.Item(2, i).Value
        CbEstado.Text = Dgv.Item(4, i).Value
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class