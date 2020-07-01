Public Class Frm_Asistenciales
    Private Sub TriageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TriageToolStripMenuItem.Click

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Frm_Usuarios.TopLevel = False
        Frm_Usuarios.FormBorderStyle = FormBorderStyle.None
        Frm_Usuarios.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Usuarios)
        PanelContenedor.Tag = Frm_Usuarios
        Frm_Usuarios.BringToFront()
        Frm_Usuarios.Show()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class