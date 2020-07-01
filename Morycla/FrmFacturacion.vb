Public Class FrmFacturacion
    Private FormularioActivo As Form = Nothing
    Private Sub FrmFacturacion_MarginChanged(sender As Object, e As EventArgs) Handles Me.MarginChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub R3280ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R3280ToolStripMenuItem.Click
        AbrirFormularioHijo(FrmRipsValidR3280)
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

    Private Sub AsignaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónToolStripMenuItem.Click
        AbrirFormularioHijo(Frm_Citas)
    End Sub

    Private Sub SolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudToolStripMenuItem.Click
        AbrirFormularioHijo(Frm_Citas_Solicitud)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AbrirFormularioHijo(Frm_Usuarios)
    End Sub
End Class