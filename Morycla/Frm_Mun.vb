Imports C_Entidad
Imports C_Negocio
Public Class Frm_Mun
    Dim Op As String = ""
    Dim objCe_M As New Ce_Mun
    Dim objCn_M As New Cn_Mun
    Dim objCe_D As New Ce_Dep
    Dim objCn_D As New Cn_Dep

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
        TbCodigo.Enabled = True
        CbDep.Enabled = True
        CbEstado.Enabled = True
        TbMun.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbCodigo.Enabled = False
        CbEstado.Enabled = False
        TbMun.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCodigo.Text = ""
        TbCons.Text = ""
        CbEstado.Text = ""
        TbMun.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarDep()
        Dim ds As New DataSet
        CbDep.DataSource = Nothing
        CbDep.Items.Clear()
        Try
            ds = objCn_D.Listar_Dep_Activos()
            If ds.Tables(0).Rows.Count > 0 Then
                CbDep.DataSource = ds.Tables(0)
                CbDep.DisplayMember = "Dep"
                CbDep.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarMun()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_M.CodDep = Val(CbDep.SelectedValue.ToString)
            ds = objCn_M.ListarMun(objCe_M)
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

    Private Sub Frm_Mun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarDep()
        ListarMun()
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Habilitar()
        Limpiar()
        Op = "N"
        CbDep.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        CbDep.Focus()
    End Sub

    Sub Nuevo()
        If Val(CbDep.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un departamento valido", MsgBoxStyle.Critical)
            CbDep.Focus()
            Exit Sub
        End If
        If TbCodigo.Text.Trim = "" Then
            MsgBox("Debe indicar el codigo Dane del municipio", MsgBoxStyle.Critical)
            TbCodigo.Focus()
            Exit Sub
        End If
        If TbMun.Text.Trim = "" Then
            MsgBox("Debe indicar el municipio", MsgBoxStyle.Critical)
            TbMun.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Municipios")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea registrar el municipio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_M.CodDep = Val(CbDep.SelectedValue.ToString)
                objCe_M.Cod = UCase(TbCodigo.Text.Trim)
                objCe_M.Mun = UCase(TbMun.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_M.Estado = 1 : Else : objCe_M.Estado = 0 : End If
                objCn_M.NuevoMun(objCe_M)
                ListarMun()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub Modificar()
        If Val(CbDep.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un departamento valido", MsgBoxStyle.Critical)
            CbDep.Focus()
            Exit Sub
        End If
        If TbCodigo.Text.Trim = "" Then
            MsgBox("Debe indicar el codigo Dane del municipio", MsgBoxStyle.Critical)
            TbCodigo.Focus()
            Exit Sub
        End If
        If TbMun.Text.Trim = "" Then
            MsgBox("Debe indicar el municipio", MsgBoxStyle.Critical)
            TbMun.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Municipios")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el municipio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_M.Cons = Val(TbCons.Text.Trim)
                objCe_M.CodDep = Val(CbDep.SelectedValue.ToString)
                objCe_M.Cod = UCase(TbCodigo.Text.Trim)
                objCe_M.Mun = UCase(TbMun.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_M.Estado = 1 : Else : objCe_M.Estado = 0 : End If
                objCn_M.NuevoMun(objCe_M)
                ListarMun()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Modificar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el municipio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_M.Cons = Val(TbCons.Text.Trim)
                objCn_M.NuevoMun(objCe_M)
                ListarMun()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        TbCodigo.Text = Dgv.Item(1, 0).Value
        TbMun.Text = Dgv.Item(2, i).Value
        CbEstado.Text = Dgv.Item(3, 0).Value
    End Sub

    Private Sub CbDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDep.SelectedIndexChanged
        ListarMun()
    End Sub

    Private Sub CbDep_Click(sender As Object, e As EventArgs) Handles CbDep.Click
        ListarMun()
    End Sub
End Class