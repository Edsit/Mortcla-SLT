Public Class FrmInformes
    Private FormularioActivo As Form = Nothing
    Private Sub Res2175ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Res2175ToolStripMenuItem.Click
        AbrirFormularioHijo(Frm_R2175)
    End Sub

    Private Sub AbrirFormularioHijo(FormularioHijo As Form)
        On Error Resume Next
        FormularioActivo = FormularioHijo
        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FormularioHijo)
        PanelContenedor.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()
    End Sub
End Class