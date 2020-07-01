Imports C_Entidad
Imports C_Negocio
Public Class FrmEntradasSedeAdmin
    Dim objCn_A As New Cn_Almacenes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarAlamcenes()
        Dim ds As New DataSet
        CbAlmacen.DataSource = Nothing
        Try
            ds = objCn_A.ListarAlmacenesActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlmacen.DataSource = ds.Tables(0)
                CbAlmacen.DisplayMember = "Almacen"
                CbAlmacen.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            Frm_BuscarEntradaAdmin.LbConsAlmacen.Text = Val(CbAlmacen.SelectedValue.ToString)
            Frm_BuscarEntradaAdmin.LbAlmacen.Text = UCase(CbAlmacen.Text.Trim)
            Frm_BuscarEntradaAdmin.ShowDialog()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FrmEntradasSedeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarAlamcenes()
    End Sub
End Class