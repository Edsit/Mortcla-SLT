Imports C_Entidad
Imports C_Negocio
Public Class FrmInventarioMovimientos
    Dim objCe_A As New Ce_Almacenes
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas

    Dim objCn_A As New Cn_Almacenes
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCn_S As New Cn_Alm_Salidas

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarAlmacenesActivoss()
        Dim ds As New DataSet
        CbAlmacen.DataSource = Nothing
        Try
            objCe_A.Sede = SedeFuncCons
            ds = objCn_A.ListarAlmacenesActivosSede(objCe_A)
            If ds.Tables(0).Rows.Count Then
                CbAlmacen.DataSource = ds.Tables(0)
                CbAlmacen.DisplayMember = "Almacen"
                CbAlmacen.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarTipoProd()
        Dim ds As New DataSet
        CbTProd.DataSource = Nothing
        Try
            ds = objCn_Tp.ListarTipoProdActivos
            If ds.Tables(0).Rows.Count Then
                CbTProd.DataSource = ds.Tables(0)
                CbTProd.DisplayMember = "Tipo"
                CbTProd.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub CbMes_Click(sender As Object, e As EventArgs) Handles CbMes.Click
        CodigoMes()
    End Sub

    Private Sub CbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMes.SelectedIndexChanged
        CodigoMes()
    End Sub

    Private Sub CodigoMes()
        Select Case CbMes.Text
            Case "ENERO"
                TbCodMes.Text = 1
            Case "FEBRERO"
                TbCodMes.Text = 2
            Case "MARZO"
                TbCodMes.Text = 3
            Case "ABRIL"
                TbCodMes.Text = 4
            Case "MAYO"
                TbCodMes.Text = 5
            Case "JUNIO"
                TbCodMes.Text = 6
            Case "JULIO"
                TbCodMes.Text = 7
            Case "AGOSTO"
                TbCodMes.Text = 8
            Case "SEPTIEMBRE"
                TbCodMes.Text = 9
            Case "OCTUBRE"
                TbCodMes.Text = 10
            Case "NOVIEMBRE"
                TbCodMes.Text = 11
            Case "DICIEMBRE"
                TbCodMes.Text = 12
        End Select
    End Sub

    Private Sub FrmInventarioMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        ListarAlmacenesActivoss()
        ListarTipoProd()
        TbAño.Text = Now.Year
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        LbValIni.Text = ""
        LbValEnt.Text = ""
        LbValSal.Text = ""
        LbValTotal.Text = ""
        Try
            objCe_L.Mes = Val(TbCodMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            objCe_L.Almacen = Val(CbAlmacen.SelectedValue.ToString)
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_L.ListarLotesInventMovimientos(objCe_L, objCe_P)
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
                    LbValIni.Text = Val(LbValIni.Text.Trim) + (Val(Dgv.Item(6, i).Value) * Val(Dgv.Item(7, i).Value))
                    i = i + 1
                    Application.DoEvents()
                Loop Until i = c
                LbValIni.Text = FormatCurrency(LbValIni.Text)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
        ListarEntradas()
        ListarSalidas()
        TotalizarSaldos()
        If LbValIni.Text = "" Then
            LbValIni.Text = 0
        End If
        If LbValEnt.Text = "" Then
            LbValEnt.Text = 0
        End If
        If LbValSal.Text = "" Then
            LbValSal.Text = 0
        End If
        LbValTotal.Text = (CDbl(LbValIni.Text) + CDbl(LbValEnt.Text)) - CDbl(LbValSal.Text)
        LbValTotal.Text = FormatCurrency(LbValTotal.Text)
        MsgBox("Proceso Terminado...")
    End Sub

    Private Sub ListarEntradas()
        Dim cant As Integer = 0
        Dim unit As Double = 0
        LbValEnt.Text = ""
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                unit = 0
                objCe_E.Lote = Val(Dgv.Item(0, i).Value)
                ds = objCn_E.ListarEntradaNuevoCierre(objCe_E)
                Dim c1 As Integer = ds.Tables(0).Rows.Count
                If c1 > 0 Then
                    Dim i1 As Integer = 0
                    Do
                        cant = cant + ds.Tables(0).Rows(i1).Item(6)
                        If ds.Tables(0).Rows(i1).Item(7) > unit Then
                            unit = ds.Tables(0).Rows(i1).Item(7)
                        End If
                        i1 = i1 + 1
                        Application.DoEvents()
                    Loop Until i1 = c1
                    Dgv.Item(8, i).Value = cant
                    Dgv.Item(9, i).Value = unit
                Else
                    Dgv.Item(8, i).Value = 0
                    Dgv.Item(9, i).Value = 0
                End If
                i = i + 1
                LbValEnt.Text = Val(LbValEnt.Text.Trim) + (cant * unit)
                LbValEnt.Text = FormatCurrency(LbValEnt.Text)
                Application.DoEvents()
            Loop Until i = c
        End If
    End Sub

    Private Sub ListarSalidas()
        Dim cant As Integer = 0
        LbValSal.Text = ""
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                objCe_S.Lote = Val(Dgv.Item(0, i).Value)
                ds = objCn_S.ListarSalidasNuevoCierre(objCe_S)
                Dim c1 As Integer = ds.Tables(0).Rows.Count
                If c1 > 0 Then
                    Dim i1 As Integer = 0
                    Do
                        cant = cant + ds.Tables(0).Rows(i1).Item(6)
                        i1 = i1 + 1
                        Application.DoEvents()
                    Loop Until i1 = c1
                    Dgv.Item(10, i).Value = cant
                    Dgv.Item(11, i).Value = 0
                Else
                    Dgv.Item(10, i).Value = 0
                End If

                If Val(Dgv.Item(9, i).Value) > 0 And Val(Dgv.Item(7, i).Value) = 0 Then
                    Dgv.Item(11, i).Value = Dgv.Item(9, i).Value
                ElseIf Val(Dgv.Item(7, i).Value) > 0 And Val(Dgv.Item(9, i).Value) = 0 Then
                    Dgv.Item(11, i).Value = Dgv.Item(7, i).Value
                Else
                    Dgv.Item(11, i).Value = (Val(Dgv.Item(7, i).Value) + Val(Dgv.Item(9, i).Value)) / 2
                End If
                i = i + 1
                Application.DoEvents()
            Loop Until i = c
        End If
        TotalizarSalidas()
    End Sub

    Private Sub TotalizarSalidas()
        Dim Salidas As Double = 0
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Salidas = Salidas + (Val(Dgv.Item(10, i).Value) * Val(Dgv.Item(11, i).Value))
                i = i + 1
            Loop Until i = c
        End If
        LbValSal.Text = Salidas
        LbValSal.Text = FormatCurrency(LbValSal.Text)
    End Sub

    Private Sub TotalizarSaldos()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Dgv.Item(12, i).Value = (Val(Dgv.Item(6, i).Value) + Val(Dgv.Item(8, i).Value)) - Val(Dgv.Item(10, i).Value)
                Dgv.Item(13, i).Value = Dgv.Item(11, i).Value
                i = i + 1
            Loop Until i = c
        End If
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