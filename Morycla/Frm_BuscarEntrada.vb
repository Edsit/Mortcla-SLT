Imports C_Entidad
Imports C_Negocio
Public Class Frm_BuscarEntrada
    Dim objCe_E As New Ce_Entradas
    Dim objCn_E As New Cn_ENtradas
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_Rf As New Ce_RFecha

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Frm_BuscarEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        CheckBox1.Checked = False
        DtDesde.Enabled = False
        DtHasta.Enabled = False
        BtnFiltrar.Enabled = False
        ListarTipoProd()
        DtDesde.Value = Now.Date
        DtHasta.Value = Now.Date
    End Sub

    Private Sub ListarTodasEntradas()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_E.ListarEntradas
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

    Private Sub ListarTipoEntradas()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_E.TProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_E.ListarEntradasTipo(objCe_E)
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
        ListarTodasEntradas()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        ListarTipoEntradas()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DtDesde.Enabled = True
            DtHasta.Enabled = True
            BtnFiltrar.Enabled = True
        Else
            DtDesde.Enabled = False
            DtHasta.Enabled = False
            BtnFiltrar.Enabled = False
        End If
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        If RadioButton1.Checked = True Then
            ListarTodosFecha()
        End If
        If RadioButton2.Checked = True Then
            ListarTipoFecha()
        End If
    End Sub

    Private Sub ListarTodosFecha()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_Rf.Desde = DtDesde.Value.Date
            objCe_Rf.Hasta = DtHasta.Value.Date
            ds = objCn_E.ListarEntradasTodosFecha(objCe_Rf)
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

    Private Sub ListarTipoFecha()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_E.TProd = Val(CbTProd.SelectedValue.ToString)
            objCe_Rf.Desde = DtDesde.Value.Date
            objCe_Rf.Hasta = DtHasta.Value.Date
            ds = objCn_E.ListarEntradasTipoFecha(objCe_E, objCe_Rf)
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
        If BEntrada = 1 Then
            FrmEntradas.TbCons.Text = Dgv.Item(0, i).Value
            FrmEntradas.DtFecha.Text = Dgv.Item(1, i).Value
            FrmEntradas.CbProvedores.Text = Dgv.Item(2, i).Value
            FrmEntradas.CbTProd.Text = Dgv.Item(3, i).Value
            FrmEntradas.CbAlmacenes.Text = Dgv.Item(5, i).Value
            FrmEntradas.TbSoporte.Text = Dgv.Item(6, i).Value
            FrmEntradas.TbPedido.Text = Dgv.Item(7, i).Value
        ElseIf BEntrada = 2
            FrmAlmacen_Recepcion_Tecnica.TbCons.Text = Dgv.Item(0, i).Value
            FrmAlmacen_Recepcion_Tecnica.TbFecha.Text = Dgv.Item(1, i).Value
            FrmAlmacen_Recepcion_Tecnica.CbTProd.Text = Dgv.Item(3, i).Value
            FrmAlmacen_Recepcion_Tecnica.CbAlmacenes.Text = Dgv.Item(5, i).Value
            FrmAlmacen_Recepcion_Tecnica.TbSoporte.Text = Dgv.Item(6, i).Value
        End If

        FrmEntradas.TbCons.Text = Dgv.Item(0, i).Value
        FrmEntradas.DtFecha.Text = Dgv.Item(1, i).Value
        FrmEntradas.CbProvedores.Text = Dgv.Item(2, i).Value
        FrmEntradas.CbTProd.Text = Dgv.Item(3, i).Value
        FrmEntradas.CbAlmacenes.Text = Dgv.Item(5, i).Value
        FrmEntradas.TbSoporte.Text = Dgv.Item(6, i).Value
        FrmEntradas.TbPedido.Text = Dgv.Item(7, i).Value
        Me.Dispose()
        Me.Close()
    End Sub
End Class