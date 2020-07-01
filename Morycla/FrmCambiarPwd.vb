Imports C_Entidad
Imports C_Negocio
Public Class FrmCambiarPwd
    Dim PwdNueva As String
    Dim objCe_F As New Ce_Funcionarios
    Dim objCn_F As New Cn_Funcionarios

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Login()
        Dim ds As New DataSet
        Try
            objCe_F.Doc = DocuFunc
            ds = objCn_F.Login(objCe_F)
            If ds.Tables(0).Rows.Count > 0 Then
                LbPwd.Text = ds.Tables(0).Rows(0).Item(7)
            Else
                BtnCambiar.Enabled = False
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub FrmCambiarPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login()
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        Texto = TbActual.Text
        Cript()
        PwdNueva = Texto
        If LbPwd.Text <> PwdNueva Then
            MsgBox("La contraseña actual no coincide", MsgBoxStyle.Critical)
            TbActual.Text = ""
            TbActual.Focus()
            Exit Sub
        End If

        If TbNueva.Text <> TbConformar.Text Then
            MsgBox("La contraseña nueva no coincide con la de confirmación", MsgBoxStyle.Critical)
            TbNueva.Text = "" : TbConformar.Text = ""
            TbNueva.Focus()
            Exit Sub
        End If

        Try
            objCe_F.Cons = Val(ConsFunc)
            Texto = TbNueva.Text
            Cript()
            objCe_F.Pwd = Texto
            objCn_F.CambiarPwd(objCe_F)
            TbActual.Text = "" : TbNueva.Text = "" : TbConformar.Text = ""
        Catch ex As Exception
        End Try
    End Sub
End Class