Imports C_Entidad
Imports C_Negocio
Public Class Frm_AlmacenFunc
    Dim Op As String = ""
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_F As New Ce_Funcionarios
    Dim objCn_F As New Cn_Funcionarios
    Dim objCe_AF As New Ce_AlmacenFunc
    Dim objCn_AF As New Cn_AlmacenFunc

    Private Sub Botones1()
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
    End Sub

    Private Sub Botones2()
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
    End Sub

    Private Sub Habilitar()
        CbFunc.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        CbFunc.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        CbAlamcen.Text = ""
        CbEstado.Text = ""
        CbFunc.Text = ""
    End Sub

    Private Sub ListarAlmacenesActivos()
        Dim ds As New DataSet
        CbAlamcen.DataSource = Nothing
        Try
            ds = objCn_A.ListarAlmacenesActivos()
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlamcen.DataSource = ds.Tables(0)
                CbAlamcen.DisplayMember = "ALMACEN"
                CbAlamcen.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarFuncioanrios()
        Dim ds As New DataSet
        CbFunc.DataSource = Nothing
        Try
            ds = objCn_F.ListarFuncinariosActivos()
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

    Private Sub ListarAlmacenesFunc()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_AF.Almacen = Val(CbAlamcen.SelectedValue.ToString)
            ds = objCn_AF.ListarAlmacenFunc(objCe_AF)
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

    Private Sub Frm_AlmacenFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarAlmacenesActivos()
        ListarFuncioanrios()
        Botones1()
        Limpiar()
        Inhabilitar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Op = "N"
        Botones2()
        Limpiar()
        Habilitar()
        CbAlamcen.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Op = "A"
        Botones2()
        Habilitar()
        CbAlamcen.Focus()
    End Sub

    Sub Nuevo()
        If Val(CbAlamcen.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un almacén válido", MsgBoxStyle.Critical)
            CbAlamcen.Focus()
            Exit Sub
        End If
        If Val(CbFunc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un funcionario válido", MsgBoxStyle.Critical)
            CbFunc.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nuevo Almacén")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea autorizar el almacén?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_AF.Almacen = Val(CbAlamcen.SelectedValue.ToString)
                objCe_AF.Func = Val(CbFunc.SelectedValue.ToString)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_AF.Estado = 1 : Else : objCe_AF.Estado = 0 : End If
                objCn_AF.NuevoAlmacenFunc(objCe_AF)
                Botones1()
                Limpiar()
                Inhabilitar()
                ListarAlmacenesFunc()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub Actualizar()
        If Val(CbAlamcen.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un almacén válido", MsgBoxStyle.Critical)
            CbAlamcen.Focus()
            Exit Sub
        End If
        If Val(CbFunc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un funcionario válido", MsgBoxStyle.Critical)
            CbFunc.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nuevo Almacén")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar la autorización del funcionario sobre el almacén?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_AF.Cons = Val(TbCons.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_AF.Estado = 1 : Else : objCe_AF.Estado = 0 : End If
                objCn_AF.ModificarAlmacenFunc(objCe_AF)
                Botones1()
                Limpiar()
                Inhabilitar()
                ListarAlmacenesFunc()
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
        Limpiar()
        Botones1()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        CbFunc.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub

    Private Sub CbAlamcen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAlamcen.SelectedIndexChanged
        ListarAlmacenesFunc()
    End Sub

    Private Sub CbAlamcen_Click(sender As Object, e As EventArgs) Handles CbAlamcen.Click
        ListarAlmacenesFunc()
    End Sub
End Class