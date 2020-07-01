Imports C_Entidad
Imports C_Negocio
Public Class Frm_Aseguradoras
    Dim Op As String = ""
    Dim objCe_E As New Ce_Eps
    Dim objCn_E As New Cn_Eps

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
        TbDir.Enabled = True
        TbNit.Enabled = True
        TbNombre.Enabled = True
        TbTel.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbDir.Enabled = False
        TbNit.Enabled = False
        TbNombre.Enabled = False
        TbTel.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        LbCons.Text = ""
        TbCodigo.Text = ""
        TbDir.Text = ""
        TbNit.Text = ""
        TbNombre.Text = ""
        TbTel.Text = ""
        CbEstado.Text = ""
    End Sub

    Private Sub ListarEps()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_E.ListarEps
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Frm_Aseguradoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        ListarEps()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        TbNit.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "N"
        TbNit.Focus()
    End Sub

    Private Sub Nuevo()
        If TbNit.Text.Trim = "" Then
            MsgBox("Dene ingresar el Nit", MsgBoxStyle.Critical)
            TbNit.Focus()
            Exit Sub
        End If
        If TbCodigo.Text.Trim = "" Then
            MsgBox("Dene ingresar el código", MsgBoxStyle.Critical)
            TbCodigo.Focus()
            Exit Sub
        End If
        If TbNombre.Text.Trim = "" Then
            MsgBox("Dene ingresar el nombre", MsgBoxStyle.Critical)
            TbNombre.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea registrar la Aseguradora (EPS)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_E.Nit = UCase(TbNit.Text.Trim)
                objCe_E.Codigo = UCase(TbCodigo.Text.Trim)
                objCe_E.Nombre = UCase(TbNombre.Text.Trim)
                objCe_E.Dir = UCase(TbDir.Text.Trim)
                objCe_E.Tel = UCase(TbTel.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_E.Estado = 1 : Else : objCe_E.Estado = 0 : End If
                objCn_E.NuevoEps(objCe_E)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarEps()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Modificar()
        If TbNit.Text.Trim = "" Then
            MsgBox("Dene ingresar el Nit", MsgBoxStyle.Critical)
            TbNit.Focus()
            Exit Sub
        End If
        If TbCodigo.Text.Trim = "" Then
            MsgBox("Dene ingresar el código", MsgBoxStyle.Critical)
            TbCodigo.Focus()
            Exit Sub
        End If
        If TbNombre.Text.Trim = "" Then
            MsgBox("Dene ingresar el nombre", MsgBoxStyle.Critical)
            TbNombre.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar la Aseguradora (EPS)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_E.Cons = Val(LbCons.Text.Trim)
                objCe_E.Nit = UCase(TbNit.Text.Trim)
                objCe_E.Codigo = UCase(TbCodigo.Text.Trim)
                objCe_E.Nombre = UCase(TbNombre.Text.Trim)
                objCe_E.Dir = UCase(TbDir.Text.Trim)
                objCe_E.Tel = UCase(TbTel.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_E.Estado = 1 : Else : objCe_E.Estado = 0 : End If
                objCn_E.ModificarEps(objCe_E)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarEps()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "M" Then
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
        If MsgBox("¿Confirma que desea eliminar la Aseguradora (EPS)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_E.Cons = Val(LbCons.Text.Trim)
                objCn_E.EliminarEps(objCe_E)
                ListarEps()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        TbNit.Text = Dgv.Item(1, i).Value
        TbCodigo.Text = Dgv.Item(2, i).Value
        TbNombre.Text = Dgv.Item(3, i).Value
        TbDir.Text = Dgv.Item(4, i).Value
        TbTel.Text = Dgv.Item(5, i).Value
        CbEstado.Text = Dgv.Item(6, i).Value
    End Sub
End Class