Imports C_Entidad
Imports C_Negocio
Public Class FrmProveedores
    Dim Op As String = ""
    Dim objCe_P As New Ce_Proveedores
    Dim objCn_P As New Cn_Proveedores
    Dim objCn_T As New Cn_Tdoc

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
        CbTdoc.Enabled = True
        CbEstado.Enabled = True
        TbDoc.Enabled = True
        TbNombre.Enabled = True
        TbDir.Enabled = True
        TbTel.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        CbTdoc.Enabled = False
        CbEstado.Enabled = False
        TbDoc.Enabled = False
        TbNombre.Enabled = False
        TbDir.Enabled = False
        TbTel.Enabled = False
    End Sub

    Private Sub Limpiar()
        CbTdoc.Text = ""
        CbEstado.Text = ""
        TbCons.Text = ""
        TbDir.Text = ""
        TbDoc.Text = ""
        TbNombre.Text = ""
        TbTel.Text = ""
    End Sub

    Sub ListarTdocActivos()
        Dim ds As New DataSet
        CbTdoc.DataSource = Nothing
        CbTdoc.Items.Clear()
        Try
            ds = objCn_T.ListarTdocActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTdoc.DataSource = ds.Tables(0)
                CbTdoc.DisplayMember = "Tipo"
                CbTdoc.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Sub ListarProveedores()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_P.ListarProveedores
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.DataSource = ds.Tables(0)
            End If
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTdocActivos()
        ListarProveedores()
        Botones1()
        Limpiar()
        Inhabilitar()
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        CbTdoc.Text = Dgv.Item(1, i).Value
        TbDoc.Text = Dgv.Item(2, i).Value
        TbNombre.Text = Dgv.Item(3, i).Value
        TbDir.Text = Dgv.Item(4, i).Value
        TbTel.Text = Dgv.Item(5, i).Value
        CbEstado.Text = Dgv.Item(6, i).Value
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Habilitar()
        Limpiar()
        Op = "N"
        CbTdoc.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "N"
        CbTdoc.Focus()
    End Sub

    Private Function ExisteProveedor(X, Y) As Boolean
        Dim ds As New DataSet
        Try
            objCe_P.Nombre = X
            objCe_P.Doc = Y
            ds = objCn_P.ExisteProveedor(objCe_P)
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
        Finally
            ds.Dispose()
        End Try
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Private Sub Nuevo()
        If Val(CbTdoc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el tipo de documento", MsgBoxStyle.Critical)
            CbTdoc.Focus()
            Exit Sub
        End If
        If TbDoc.Text.Trim = "" Then
            MsgBox("Debe indicar el documento", MsgBoxStyle.Critical)
            TbDoc.Focus()
            Exit Sub
        End If
        If TbNombre.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre", MsgBoxStyle.Critical)
            TbNombre.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nueva Sede")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteProveedor(UCase(TbNombre.Text.Trim), UCase(TbDoc.Text.Trim)) = False Then
            If MsgBox("Confirma que desea registrar el proveedor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_P.Tdoc = Val(CbTdoc.SelectedValue.ToString)
                    objCe_P.Doc = UCase(TbDoc.Text.Trim)
                    objCe_P.Nombre = UCase(TbNombre.Text.Trim)
                    objCe_P.Dir = UCase(TbDir.Text.Trim)
                    objCe_P.Tel = UCase(TbTel.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_P.Estado = 1 : Else : objCe_P.Estado = 0 : End If
                    objCn_P.NuevoProveedor(objCe_P)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarProveedores()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe un proveedor con el mismo nombre y/o numero de documento", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If Val(CbTdoc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el tipo de documento", MsgBoxStyle.Critical)
            CbTdoc.Focus()
            Exit Sub
        End If
        If TbDoc.Text.Trim = "" Then
            MsgBox("Debe indicar el documento", MsgBoxStyle.Critical)
            TbDoc.Focus()
            Exit Sub
        End If
        If TbNombre.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre", MsgBoxStyle.Critical)
            TbNombre.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nueva Sede")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el proveedor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.Cons = Val(TbCons.Text.Trim)
                objCe_P.Tdoc = Val(CbTdoc.SelectedValue.ToString)
                objCe_P.Doc = UCase(TbDoc.Text.Trim)
                objCe_P.Nombre = UCase(TbNombre.Text.Trim)
                objCe_P.Dir = UCase(TbDir.Text.Trim)
                objCe_P.Tel = UCase(TbTel.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_P.Estado = 1 : Else : objCe_P.Estado = 0 : End If
                objCn_P.ModificarProveedor(objCe_P)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarProveedores()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el proveedor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.Cons = Val(TbCons.Text.Trim)
                objCn_P.EliminarProveedor(objCe_P)
                Limpiar()
                ListarProveedores()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class