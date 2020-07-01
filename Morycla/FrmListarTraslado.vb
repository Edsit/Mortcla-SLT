Imports C_Entidad
Imports C_Negocio
Public Class FrmListarTraslado
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
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

    Private Sub FrmListarTraslado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        LbTipo.Text = ""
        LbEstado.Text = ""
        ListarAlmacenes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tras = 2
        Frm_BuscarTraslados.ShowDialog()
        ListarProductos()
    End Sub

    Private Sub ListarProductos()
        On Error Resume Next
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        objCe_S.Traslado = Val(TbTraslado.Text.Trim)
        ds = objCn_S.ListarSalidasTraslado(objCe_S)
        Dim c As Integer = ds.Tables(0).Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            Do
                Dgv.Rows.Add()
                Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                Dgv.Item(4, i).Value = ds.Tables(0).Rows(i).Item(4)
                Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(5)
                Dgv.Item(6, i).Value = ds.Tables(0).Rows(i).Item(6)
                Dgv.Item(7, i).Value = ds.Tables(0).Rows(i).Item(7)
                Dgv.Item(8, i).Value = ds.Tables(0).Rows(i).Item(8)
                Dgv.Item(9, i).Value = ds.Tables(0).Rows(i).Item(9)
                Dgv.Item(10, i).Value = ds.Tables(0).Rows(i).Item(10)
                Dgv.Item(11, i).Value = ds.Tables(0).Rows(i).Item(11)
                Dgv.Item(12, i).Value = ds.Tables(0).Rows(i).Item(12)
                Dgv.Item(13, i).Value = ds.Tables(0).Rows(i).Item(13)
                Dgv.Item(14, i).Value = ds.Tables(0).Rows(i).Item(14)
                i = i + 1
            Loop Until i = c
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
        ds.Dispose()
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
End Class