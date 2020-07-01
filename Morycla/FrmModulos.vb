Public Class FrmModulos
    Private FormularioActivo As Form = Nothing
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub FrmModulos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        LbSede.Text = "" : LbFuncionario.Text = "" : LbCargo.Text = ""

        PanelModulos.Visible = True
        CerrarSesión()
    End Sub

    Private Sub BtnModulos_Click(sender As Object, e As EventArgs) Handles BtnModulos.Click
        If PanelModulos.Visible = True Then
            PanelModulos.Visible = False
        Else
            PanelModulos.Visible = True
        End If
    End Sub

    Private Sub AbrirFormularioHijo(FormularioHijo As Form)
        On Error Resume Next
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Dispose()
            FormularioActivo.Close()
        End If
        FormularioActivo = FormularioHijo
        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FormularioHijo)
        PanelContenedor.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()
    End Sub

    Private Sub BtnFacturacion_Click(sender As Object, e As EventArgs) Handles BtnFacturacion.Click
        AbrirFormularioHijo(FrmFacturacion)
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        AbrirFormularioHijo(FrmEmpresa)
    End Sub

    Private Sub BtnAlmacen_Click(sender As Object, e As EventArgs) Handles BtnAlmacen.Click
        AbrirFormularioHijo(FrmAlmacen)
    End Sub

    Private Sub CerrarSesión()
        PanelModulo.Enabled = False
        PanelModulos.Enabled = False
        BtnSeguridad.Enabled = False
        PanelContenedor.Enabled = False
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Dispose()
            FormularioActivo.Close()
        End If
        BtnSesión.Text = "Iniciar Sesión"
        LabelItem4.Visible = True
    End Sub

    Private Sub IniciarSesion()
        'PanelModulo.Enabled = True
        'PanelModulos.Enabled = True
        'BtnSeguridad.Enabled = True
        'PanelContenedor.Enabled = True
        FrmLogin.ShowDialog()
        BtnSesión.Text = "Cerrar Sesión"
        LabelItem4.Visible = True
    End Sub

    Private Sub BtnSesión_Click(sender As Object, e As EventArgs) Handles BtnSesión.Click
        If BtnSesión.Text = "Cerrar Sesión" Then
            Accion = "CERRAR SESION"
            RegistrarAuditoria()
            CerrarSesión()
        Else
            IniciarSesion()
        End If
    End Sub

    Private Sub BtnSeguridad_Click(sender As Object, e As EventArgs) Handles BtnSeguridad.Click
        FrmCambiarPwd.ShowDialog()
    End Sub

    Private Sub BtnSistema_Click(sender As Object, e As EventArgs) Handles BtnSistema.Click
        AbrirFormularioHijo(FrmSistema)
    End Sub

    Private Sub BtnAsistencial_Click(sender As Object, e As EventArgs) Handles BtnAsistencial.Click
        AbrirFormularioHijo(Frm_Asistenciales)
    End Sub

    Private Sub BtnInformes_Click(sender As Object, e As EventArgs) Handles BtnInformes.Click
        AbrirFormularioHijo(FrmInformes)
    End Sub
End Class