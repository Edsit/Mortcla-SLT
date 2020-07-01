Imports C_Entidad
Imports C_Negocio
Public Class Frm_BuscarEntradaAdmin
    Dim objCe_E As New Ce_Entradas
    Dim objCn_E As New Cn_ENtradas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Frm_BuscarEntradaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEntradas()
    End Sub

    Private Sub ListarEntradas()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_E.Almacen = Val(LbConsAlmacen.Text.Trim)
            ds = objCn_E.EntradasSedeAdmin(objCe_E)
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        FrmEntradasSedeAdmin.TbEntrada.Text = Dgv.Item(0, i).Value
        Me.Dispose()
        Me.Close()
    End Sub
End Class