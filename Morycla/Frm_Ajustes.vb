Imports C_Entidad
Imports C_Negocio
Public Class Frm_Ajustes
    Dim objCe_Tp As New Ce_Alm_TipoProd
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
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
        Frm_Ajustes_Prod.TopLevel = False
        Frm_Ajustes_Prod.FormBorderStyle = FormBorderStyle.None
        Frm_Ajustes_Prod.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Ajustes_Prod)
        PanelContenedor.Tag = Frm_Ajustes_Prod
        Frm_Ajustes_Prod.BringToFront()
        Frm_Ajustes_Prod.LbAlmacen.Text = Val(CbAlmacen.SelectedValue.ToString)
        Frm_Ajustes_Prod.LbNombreAlmacen.Text = CbAlmacen.Text
        Frm_Ajustes_Prod.Label1.Text = "AJUSTES DE " & CbTProd.Text.Trim
        Frm_Ajustes_Prod.Show()
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

    Private Sub Frm_Ajustes_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListarAlmacenes()
        ListarTProd()
    End Sub
End Class