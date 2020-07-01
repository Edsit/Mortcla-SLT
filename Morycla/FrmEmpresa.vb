Public Class FrmEmpresa
    Private FormularioActivo As Form = Nothing
    Private Sub SedesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SedesToolStripMenuItem.Click
        AbrirFormularioHijo(FrmSedes)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        AbrirFormularioHijo(FrmFuncionarios)
    End Sub
End Class