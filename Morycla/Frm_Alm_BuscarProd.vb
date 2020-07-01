Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_BuscarProd
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCn_P As New Cn_Alm_Productos
    Dim objCn_Tp As New Cn_Alm_TipoProd

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
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

    Private Sub Frm_Alm_BuscarProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 9, FontStyle.Regular)
        ListarTipoProd()
        CbTProd.Text = Tp
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RadioButton1.Checked Then
            BuscarTodosProductos()
        Else
            BuscarTipoProducto()
        End If
    End Sub

    Private Sub BuscarTodosProductos()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_P.ListarTodosProductos
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

    Private Sub BuscarTipoProducto()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_P.ListarTipoProductos(objCe_P)
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

    Private Sub FiltrarTodosDescrip()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_P.Descripcion = UCase(TbDescrip.Text.Trim)
            ds = objCn_P.FiltrarTodosProductosDescrip(objCe_P)
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

    Private Sub FiltrarTiposDescrip()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            objCe_P.Descripcion = UCase(TbDescrip.Text.Trim)
            ds = objCn_P.FiltrarTipoProductosDescrip(objCe_P)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            FiltrarTodosDescrip()
        Else
            FiltrarTiposDescrip()
        End If
    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        If BProd = 1 Then
            Frm_Alm_Productos.CbTProd.Text = CbTProd.Text.Trim
            Frm_Alm_Productos.TbCons.Text = Dgv.Item(0, i).Value
        ElseIf BProd = 2
            If Frm_Alm_Entradas.LbTProd.Text <> 1 Then
                Frm_Alm_Entradas.TbCons.Text = Dgv.Item(0, i).Value
                Frm_Alm_Entradas.TbAtc.Text = "N/A"
                Frm_Alm_Entradas.TbDescripcion.Text = Dgv.Item(1, i).Value
                Frm_Alm_Entradas.TbConcentracion.Text = "N/A"
                Frm_Alm_Entradas.TbPresentacion.Text = Dgv.Item(2, i).Value
                Frm_Alm_Entradas.TbForma.Text = "N/A"
                Frm_Alm_Entradas.TbUnidad.Text = Dgv.Item(3, i).Value
                Frm_Alm_Entradas.TbTipo.Text = Dgv.Item(7, i).Value
            Else
                Frm_Alm_Entradas.TbCons.Text = Dgv.Item(0, i).Value
                Frm_Alm_Entradas.TbAtc.Text = Dgv.Item(1, i).Value
                Frm_Alm_Entradas.TbDescripcion.Text = Dgv.Item(2, i).Value
                Frm_Alm_Entradas.TbConcentracion.Text = Dgv.Item(3, i).Value
                Frm_Alm_Entradas.TbPresentacion.Text = Dgv.Item(4, i).Value
                Frm_Alm_Entradas.TbForma.Text = Dgv.Item(5, i).Value
                Frm_Alm_Entradas.TbUnidad.Text = Dgv.Item(6, i).Value
                Frm_Alm_Entradas.TbTipo.Text = Dgv.Item(9, i).Value
            End If
        ElseIf BProd = 3
            If Frm_Alm_Salidas.LbTProd.Text <> 1 Then
                Frm_Alm_Salidas.TbCons.Text = Dgv.Item(0, i).Value
                Frm_Alm_Salidas.TbAtc.Text = "N/A"
                Frm_Alm_Salidas.TbDescripcion.Text = Dgv.Item(1, i).Value
                Frm_Alm_Salidas.TbConcentracion.Text = "N/A"
                Frm_Alm_Salidas.TbPresentacion.Text = Dgv.Item(2, i).Value
                Frm_Alm_Salidas.TbForma.Text = "N/A"
                Frm_Alm_Salidas.TbUnidad.Text = Dgv.Item(3, i).Value
                Frm_Alm_Salidas.TbTipo.Text = Dgv.Item(7, i).Value
            Else
                Frm_Alm_Salidas.TbCons.Text = Dgv.Item(0, i).Value
                Frm_Alm_Salidas.TbAtc.Text = Dgv.Item(1, i).Value
                Frm_Alm_Salidas.TbDescripcion.Text = Dgv.Item(2, i).Value
                Frm_Alm_Salidas.TbConcentracion.Text = Dgv.Item(3, i).Value
                Frm_Alm_Salidas.TbPresentacion.Text = Dgv.Item(4, i).Value
                Frm_Alm_Salidas.TbForma.Text = Dgv.Item(5, i).Value
                Frm_Alm_Salidas.TbUnidad.Text = Dgv.Item(6, i).Value
                Frm_Alm_Salidas.TbTipo.Text = Dgv.Item(9, i).Value
            End If

        ElseIf BProd = 4
            FrmSalidasStop.TbCons.Text = Dgv.Item(0, i).Value
            FrmSalidasStop.TbAtc.Text = Dgv.Item(1, i).Value
            FrmSalidasStop.TbDescripcion.Text = Dgv.Item(2, i).Value
            FrmSalidasStop.TbConcentracion.Text = Dgv.Item(3, i).Value
            FrmSalidasStop.TbPresentacion.Text = Dgv.Item(4, i).Value
            FrmSalidasStop.TbForma.Text = Dgv.Item(5, i).Value
            FrmSalidasStop.TbUnidad.Text = Dgv.Item(6, i).Value
            FrmSalidasStop.TbTipo.Text = Dgv.Item(9, i).Value
        ElseIf BProd = 5
            If Frm_Ajustes_Prod.LbTProd.Text <> 1 Then
                Frm_Ajustes_Prod.TbCons.Text = Dgv.Item(0, i).Value
                Frm_Ajustes_Prod.TbAtc.Text = "N/A"
                Frm_Ajustes_Prod.TbDescripcion.Text = Dgv.Item(1, i).Value
                Frm_Ajustes_Prod.TbConcentracion.Text = "N/A"
                Frm_Ajustes_Prod.TbPresentacion.Text = Dgv.Item(2, i).Value
                Frm_Ajustes_Prod.TbForma.Text = "N/A"
                Frm_Ajustes_Prod.TbUnidad.Text = Dgv.Item(3, i).Value
                Frm_Ajustes_Prod.TbTipo.Text = Dgv.Item(7, i).Value
            Else
                Frm_Ajustes_Prod.TbCons.Text = Dgv.Item(0, i).Value
                Frm_Ajustes_Prod.TbAtc.Text = Dgv.Item(1, i).Value
                Frm_Ajustes_Prod.TbDescripcion.Text = Dgv.Item(2, i).Value
                Frm_Ajustes_Prod.TbConcentracion.Text = Dgv.Item(3, i).Value
                Frm_Ajustes_Prod.TbPresentacion.Text = Dgv.Item(4, i).Value
                Frm_Ajustes_Prod.TbForma.Text = Dgv.Item(5, i).Value
                Frm_Ajustes_Prod.TbUnidad.Text = Dgv.Item(6, i).Value
                Frm_Ajustes_Prod.TbTipo.Text = Dgv.Item(9, i).Value
            End If
        ElseIf BProd = 6
            If Frm_Alm_Entradas1.LbTProd.Text <> 1 Then
                Frm_Alm_Entradas1.LbConsProd.Text = Dgv.Item(0, i).Value
                Frm_Alm_Entradas1.LbProd.Text = Dgv.Item(1, i).Value & " " & Dgv.Item(2, i).Value & " " & Dgv.Item(3, i).Value

            Else
                Frm_Alm_Entradas1.LbConsProd.Text = Dgv.Item(0, i).Value
                Frm_Alm_Entradas1.LbProd.Text = Dgv.Item(2, i).Value & " " & Dgv.Item(3, i).Value & " " & Dgv.Item(4, i).Value
                ' Frm_Alm_Entradas1.TbUnidad.Text = Dgv.Item(6, i).Value
            End If
        End If
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To Dgv.ColumnCount
            worksheet.Cells(1, i) = Me.Dgv.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.Dgv.Rows.Count - 1
            For j As Integer = 0 To Me.Dgv.Columns.Count - 1
                If Me.Dgv.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.Dgv.Rows(I).Cells(j).Value.ToString()
                End If

            Next
        Next
        'ACA LE DAMOS FORMATO A NUESTRO EXCEL
        worksheet.Rows.Item(1).Font.Bold = 1
        worksheet.Rows.Item(1).HorizontalAlignment = 3
        worksheet.Columns.AutoFit()
        worksheet.Columns.HorizontalAlignment = 2

        app.Visible = True
        app = Nothing
        workbook = Nothing
        worksheet = Nothing
        FileClose(1)
        GC.Collect()
    End Sub

    Private Sub TbDescrip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbDescrip.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class