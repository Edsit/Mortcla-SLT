Imports C_Entidad
Imports C_Negocio
Public Class Frm_Barrios
    Dim Op As String = ""
    Dim objCe_M As New Ce_Mun
    Dim objCe_B As New Ce_Barrio

    Dim objCn_D As New Cn_Dep
    Dim objCn_M As New Cn_Mun
    Dim objCn_B As New Cn_Barrios

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
        TbBarrio.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbBarrio.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbBarrio.Text = ""
        CbEstado.Text = ""
    End Sub

    Private Sub ListarDepActivos()
        Dim ds As New DataSet
        CbDep.DataSource = Nothing
        CbDep.Items.Clear()
        Try
            ds = objCn_D.Listar_Dep_Activos
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

    Private Sub ListarMunActivos()
        Dim ds As New DataSet
        CbMun.DataSource = Nothing
        CbMun.Items.Clear()
        Try
            objCe_M.CodDep = Val(CbDep.SelectedValue.ToString)
            ds = objCn_M.ListarMunActivos(objCe_M)
            If ds.Tables(0).Rows.Count > 0 Then
                CbMun.DataSource = ds.Tables(0)
                CbMun.DisplayMember = "Mun"
                CbMun.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarBarrios()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_B.CodMun = Val(CbMun.SelectedValue.ToString)
            objCe_B.Zona = UCase(Mid(CbZona.Text.Trim, 1, 1))
            ds = objCn_B.Listar_Barrios(objCe_B)
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Frm_Barrios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarDepActivos()
        ListarMunActivos()
        Botones1()
        Limpiar()
        Inhabilitar()
        If Ba = 1 Then
            CbDep.Text = Frm_Usuarios.CbDep.Text
            CbMun.Text = Frm_Usuarios.CbMun.Text
            CbZona.Text = Frm_Usuarios.CbZona.Text
            ListarBarrios()
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Op = "N"
        Habilitar()
        TbBarrio.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Op = "M"
        Habilitar()
        TbBarrio.Focus()
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        TbBarrio.Text = Dgv.Item(1, i).Value
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Op = ""
        Botones1()
        Limpiar()
        Inhabilitar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "M" Then
            Modificar()
        End If
    End Sub

    Private Sub Nuevo()
        If Val(CbDep.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el departamento", MsgBoxStyle.Critical)
            CbDep.Focus()
            Exit Sub
        End If
        If Val(CbMun.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el municipio", MsgBoxStyle.Critical)
            CbMun.Focus()
            Exit Sub
        End If
        If CbZona.Text.Trim = "URBANA" And CbZona.Text.Trim = "RURAL" Then
            MsgBox("Debe seleccionar una zona valida", MsgBoxStyle.Critical)
            CbZona.Focus()
            Exit Sub
        End If
        If TbBarrio.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre del barrio", MsgBoxStyle.Critical)
            TbBarrio.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Municipios")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea registrar el barrio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_B.CodMun = Val(CbMun.SelectedValue.ToString)
                objCe_B.Barrio = UCase(TbBarrio.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_B.Estado = 1 : Else : objCe_B.Estado = 0 : End If
                objCn_B.Nuevo_Barrio(objCe_B)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarBarrios()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Modificar()
        If Val(CbDep.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el departamento", MsgBoxStyle.Critical)
            CbDep.Focus()
            Exit Sub
        End If
        If Val(CbMun.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el municipio", MsgBoxStyle.Critical)
            CbMun.Focus()
            Exit Sub
        End If
        If CbZona.Text.Trim = "URBANA" And CbZona.Text.Trim = "RURAL" Then
            MsgBox("Debe seleccionar una zona valida", MsgBoxStyle.Critical)
            CbZona.Focus()
            Exit Sub
        End If
        If TbBarrio.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre del barrio", MsgBoxStyle.Critical)
            TbBarrio.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Municipios")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el barrio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_B.Cons = Val(LbCons.Text.Trim)
                objCe_B.CodMun = Val(CbMun.SelectedValue.ToString)
                objCe_B.Barrio = UCase(TbBarrio.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_B.Estado = 1 : Else : objCe_B.Estado = 0 : End If
                objCn_B.Modificar_Barrio(objCe_B)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarBarrios()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el barrio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_B.Cons = Val(LbCons.Text.Trim)
                objCn_B.Eliminiar_Barrio(objCe_B)
                Limpiar()
                ListarBarrios()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbZona.SelectedIndexChanged
        ListarBarrios()
    End Sub

    Private Sub CbZona_Click(sender As Object, e As EventArgs) Handles CbZona.Click
        ListarBarrios()
    End Sub
End Class