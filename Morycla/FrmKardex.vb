Imports C_Entidad
Imports C_Negocio
Public Class FrmKardex
    Dim objCe_Tp As New Ce_Alm_TipoProd
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmKardex_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CbTProd.Text = "MEDICAMENTO" Then
            Frm_Alm_KardexMed.TopLevel = False
            Frm_Alm_KardexMed.FormBorderStyle = FormBorderStyle.None
            Frm_Alm_KardexMed.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(Frm_Alm_KardexMed)
            PanelContenedor.Tag = Frm_Alm_KardexMed
            Frm_Alm_KardexMed.BringToFront()
            Frm_Alm_KardexMed.Show()
            CbTProd.Enabled = False
            Button1.Enabled = False
        Else
            Frm_Alm_KardexMq.TopLevel = False
            Frm_Alm_KardexMq.FormBorderStyle = FormBorderStyle.None
            Frm_Alm_KardexMq.Dock = DockStyle.Fill
            PanelContenedor.Controls.Add(Frm_Alm_KardexMq)
            PanelContenedor.Tag = Frm_Alm_KardexMq
            Frm_Alm_KardexMq.BringToFront()
            Frm_Alm_KardexMq.Show()
            CbTProd.Enabled = False
            Button1.Enabled = False
        End If
    End Sub
End Class