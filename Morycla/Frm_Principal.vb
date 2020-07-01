Imports DevComponents.DotNetBar.OfficeForm
Imports DevComponents.Schedule.Model
Public Class Frm_Principal
    Dim Modulos As Boolean = True
    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        OcultarModulos()
        CerrarSesión()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If Modulos = True Then
            MostrarModulos()
            Modulos = False
        Else
            OcultarModulos()
            Modulos = True
        End If
    End Sub

    Private Sub MostrarModulos()
        BtnEmpresa.Visible = True
        BtnAlmacen.Visible = True
        BtnFacturacion.Visible = True
        BtnSistemas.Visible = True
    End Sub

    Private Sub OcultarModulos()
        BtnEmpresa.Visible = False
        BtnAlmacen.Visible = False
        BtnFacturacion.Visible = False
        BtnSistemas.Visible = False
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        FrmEmpresa.TopLevel = False
        FrmEmpresa.FormBorderStyle = FormBorderStyle.None
        FrmEmpresa.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmEmpresa)
        PanelContenedor.Tag = FrmEmpresa
        FrmEmpresa.BringToFront()
        FrmEmpresa.Show()
    End Sub

    Private Sub BtnAlmacen_Click(sender As Object, e As EventArgs) Handles BtnAlmacen.Click
        FrmAlmacen.TopLevel = False
        FrmAlmacen.FormBorderStyle = FormBorderStyle.None
        FrmAlmacen.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmAlmacen)
        PanelContenedor.Tag = FrmAlmacen
        FrmAlmacen.BringToFront()
        FrmAlmacen.Show()
    End Sub

    Private Sub CerrarSesión()
        PanelContenedor.Enabled = False
        PanelMenu.Enabled = False
        BtnSeguridad.Enabled = False
        BtnSesión.Text = "Iniciar Sesión"
        BtnSeguridad.Enabled = False
    End Sub

    Private Sub IniciarSesion()
        FrmLogin.ShowDialog()
        '  LabelItem4.Visible = True
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

    Private Sub BtnFacturacion_Click(sender As Object, e As EventArgs) Handles BtnFacturacion.Click
        FrmFacturacion.TopLevel = False
        FrmFacturacion.FormBorderStyle = FormBorderStyle.None
        FrmFacturacion.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmFacturacion)
        PanelContenedor.Tag = FrmFacturacion
        FrmFacturacion.BringToFront()
        FrmFacturacion.Show()
    End Sub

    Private Sub BtnSistemas_Click(sender As Object, e As EventArgs) Handles BtnSistemas.Click
        FrmSistema.TopLevel = False
        FrmSistema.FormBorderStyle = FormBorderStyle.None
        FrmSistema.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmSistema)
        PanelContenedor.Tag = FrmSistema
        FrmSistema.BringToFront()
        FrmSistema.Show()
    End Sub

    Private Sub BtnSeguridad_Click(sender As Object, e As EventArgs) Handles BtnSeguridad.Click
        FrmCambiarPwd.ShowDialog()
    End Sub
End Class