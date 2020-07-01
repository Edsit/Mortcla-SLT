Imports C_Entidad
Imports C_Negocio
Public Class FrmSalidas
    Dim objCe_Tp As New Ce_Alm_TipoProd
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmSalidas_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListarTProd()
        ListarAlmacenes()
    End Sub

    Private Sub ListarTProd()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Frm_Alm_Salidas.TopLevel = False
        Frm_Alm_Salidas.FormBorderStyle = FormBorderStyle.None
        Frm_Alm_Salidas.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Alm_Salidas)
        PanelContenedor.Tag = Frm_Alm_Salidas
        Frm_Alm_Salidas.BringToFront()
        Frm_Alm_Salidas.LbAlmacen.Text = Val(CbAlmacen.SelectedValue.ToString)
        Frm_Alm_Salidas.LbNombreAlmacen.Text = CbAlmacen.Text
        Frm_Alm_Salidas.LbTipoProd.Text = CbTProd.Text
        Sal = 1
        Frm_Alm_Salidas.Show()
        CbTProd.Enabled = False
        CbAlmacen.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub ListarAlmacenes()
        Dim ds As New DataSet
        CbAlmacen.DataSource = Nothing
        CbAlmacen.Items.Clear()
        Try
            objCe_AF.Func = Val(ConsFunc)
            ds = objCn_A.ListarAlmacenesActivosFunc(objCe_AF)
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlmacen.DataSource = ds.Tables(0)
                CbAlmacen.DisplayMember = "Nombre"
                CbAlmacen.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub
End Class