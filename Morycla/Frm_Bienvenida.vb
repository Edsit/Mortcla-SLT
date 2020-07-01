Public Class Frm_Bienvenida
    Private Sub Frm_Bienvenida_Load(sender As Object, e As EventArgs) Handles Me.Load
        LbUsuario.Text = NomFunc
        Me.Opacity = 0
        CircularProgressBar1.Value = 0
        CircularProgressBar1.Minimum = 0
        CircularProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.01
            CircularProgressBar1.Value = CircularProgressBar1.Value + 1
            CircularProgressBar1.Text = CircularProgressBar1.Value.ToString
            If CircularProgressBar1.Value = 100 Then
                Timer1.Stop()
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()

            Me.Close()
        End If
    End Sub
End Class