Public Class FrmFuncionarioBuscarDoc
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        DocFun = UCase(TbDoc.Text.Trim)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TbDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbDoc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            BtnAceptar.PerformClick()
        End If
    End Sub

    Private Sub FrmFuncionarioBuscarDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbDoc.Focus()
    End Sub
End Class