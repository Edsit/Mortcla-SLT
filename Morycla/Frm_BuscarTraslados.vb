Imports C_Entidad
Imports C_Negocio
Public Class Frm_BuscarTraslados
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_T As New Ce_Traslados
    Dim objCn_T As New Cn_Traslados

    Dim Tp As Integer = 0

    Private Sub ListarTipoProd()
        Dim ds As New DataSet
        CbTProd.DataSource = Nothing
        CbTProd.Items.Clear()
        Try
            ds = objCn_Tp.ListarTipoProdActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTProd.DataSource = ds.Tables(0)
                CbTProd.DisplayMember = "Tipo"
                CbTProd.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Frm_BuscarTraslados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        ListarTipoProd()
        CbTProd.Enabled = False
        RadioButton1.Checked = True
        Tp = 1
        ListarTraslados()
    End Sub

    Private Sub ListarTraslados()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            If Tp = 1 Then
                ds = objCn_T.ListarTraslados
            ElseIf Tp = 2 Then
                objCe_T.TipoProd = Val(CbTProd.SelectedValue.ToString)
                ds = objCn_T.ListarTrasladosTProd(objCe_T)
            End If
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        CbTProd.Enabled = False
        CbTProd.Text = ""
        Tp = 1
        ListarTraslados()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        CbTProd.Enabled = True
        CbTProd.Focus()
        Tp = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListarTraslados()
    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        If Tras = 1 Then
            Frm_Traslados.TbCons.Text = Dgv.Item(0, i).Value
            Frm_Traslados.DtFecha.Value = Dgv.Item(1, i).Value
            Frm_Traslados.CbAlmOrigen.Text = Dgv.Item(2, i).Value
            Frm_Traslados.CbAlmDestino.Text = Dgv.Item(3, i).Value
            Frm_Traslados.CbTProd.Text = Dgv.Item(4, i).Value
            Frm_Traslados.TbObs.Text = Dgv.Item(5, i).Value
            Frm_Traslados.TbEstado.Text = Dgv.Item(6, i).Value
        ElseIf Tras = 2 Then
            FrmListarTraslado.TbTraslado.Text = Dgv.Item(0, i).Value
            FrmListarTraslado.LbTipo.Text = Dgv.Item(4, i).Value
            FrmListarTraslado.LbEstado.Text = Dgv.Item(6, i).Value
        End If
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class