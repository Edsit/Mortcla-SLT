Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_Alm_KardexMq
    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCn_Sem As New Cn_Alm_Semaforo
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCn_P As New Cn_Alm_Productos

    Dim objCe_Rf As New Ce_RFecha
    Private Sub Frm_Alm_KardexMq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvMq.Font = New Font("Arial", 8, FontStyle.Regular)
        Label1.Text = "KARDEX DE " & FrmKardex.CbTProd.Text
        RadioButton1.Checked = True
        LoadMesActivo()
    End Sub

    Sub LoadMesActivo()
        Dim ds As New DataSet
        Try
            ds = ObjCn_MesEstado.LoadMesActivo
            If ds.Tables(0).Rows.Count > 0 Then
                TbConsMes.Text = ds.Tables(0).Rows(0).Item(0)
                TbMes.Text = ds.Tables(0).Rows(0).Item(1)
                TbAño.Text = ds.Tables(0).Rows(0).Item(2)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Sub LoadMqLotesKardex()
        Dim ds As New DataSet
        Try
            DgvMq.Rows.Clear()
            If RadioButton1.Checked = True Then
                objCe_L.Mes = Val(TbConsMes.Text.Trim)
                objCe_L.Año = Val(TbAño.Text.Trim)
            ElseIf RadioButton3.Checked = True
                objCe_L.Mes = Val(TbBMes.Text.Trim)
                objCe_L.Año = Val(TbBAño.Text.Trim)
            End If

            objCe_P.TipoProd = Val(FrmKardex.CbTProd.SelectedValue.ToString)
            objCe_L.Almacen = Val(FrmKardex.CbAlmacen.SelectedValue.ToString)
            ds = objCn_L.ListarLotesMQKardex(objCe_L, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    DgvMq.Rows.Add()
                    DgvMq.Item(0, i).Value = ds.Tables(0).Rows(i).Item("Cons")
                    DgvMq.Item(1, i).Value = ds.Tables(0).Rows(i).Item("Serial")
                    'DgvMq.Item(1, i).Value = "N/A"
                    DgvMq.Item(2, i).Value = ds.Tables(0).Rows(i).Item("Descripcion")
                    DgvMq.Item(3, i).Value = ds.Tables(0).Rows(i).Item("UNIDAD")
                    DgvMq.Item(4, i).Value = ds.Tables(0).Rows(i).Item("Lab")
                    DgvMq.Item(5, i).Value = ds.Tables(0).Rows(i).Item("Lote")
                    DgvMq.Item(6, i).Value = ds.Tables(0).Rows(i).Item("Invima")
                    DgvMq.Item(7, i).Value = Format(ds.Tables(0).Rows(i).Item("Vence"), "dd/MM/yyyy")
                    DgvMq.Item(8, i).Value = ds.Tables(0).Rows(i).Item("VUtil")
                    DgvMq.Item(9, i).Value = ds.Tables(0).Rows(i).Item("Riesgo")
                    DgvMq.Item(10, i).Value = ds.Tables(0).Rows(i).Item("Ini")
                    DgvMq.Item(11, i).Value = (ds.Tables(0).Rows(i).Item("Unitario"))
                    DgvMq.Item(12, i).Value = (ds.Tables(0).Rows(i).Item("Total"))
                    If IsDBNull(ds.Tables(0).Rows(i).Item("Obs")) = False Then
                        DgvMq.Item(23, i).Value = ds.Tables(0).Rows(i).Item("Obs")
                    End If
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If DgvMq.Rows.Count > 0 Then
                LoadEntradasMQ
                LoadSalidasMq()
                SaldoTotalMq()
                SemaforizarMq()
                ColorMedMq()
            End If
        End Try
    End Sub

    Sub LoadEntradasMq()
        Dim ds As DataSet
        Dim c As Integer = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(DgvMq.Item(0, i).Value)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMq.Item(13, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMq.Item(13, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            DgvMq.Item(14, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            DgvMq.Item(14, i).Value = 0
                        End If
                        DgvMq.Item(15, i).Value = Val(DgvMq.Item(13, i).Value) * CDbl(DgvMq.Item(14, i).Value)
                        DgvMq.Item(15, i).Value = (DgvMq.Item(15, i).Value)
                        Else
                            DgvMq.Item(13, i).Value = 0
                        DgvMq.Item(14, i).Value = DgvMq.Item(11, i).Value
                        DgvMq.Item(15, i).Value = (0)
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadSalidasMq()
        Dim ds As DataSet
        Dim c As Integer = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_S.Lote = Val(DgvMq.Item(0, i).Value)
                    objCe_S.Mes = Val(TbConsMes.Text.Trim)
                    objCe_S.Año = Val(TbAño.Text.Trim)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMq.Item(16, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMq.Item(16, i).Value = 0
                        End If


                        If DgvMq.Item(11, i).Value = 0 Then
                            DgvMq.Item(17, i).Value = DgvMq.Item(14, i).Value
                        Else
                            If DgvMq.Item(14, i).Value = 0 Then
                                DgvMq.Item(17, i).Value = DgvMq.Item(11, i).Value
                            Else
                                DgvMq.Item(17, i).Value = (DgvMq.Item(11, i).Value + DgvMq.Item(14, i).Value) / 2
                            End If
                        End If
                        DgvMq.Item(18, i).Value = Val(DgvMq.Item(16, i).Value) * CDbl(DgvMq.Item(17, i).Value)
                        DgvMq.Item(18, i).Value = (DgvMq.Item(18, i).Value)
                    Else
                        DgvMq.Item(16, i).Value = 0
                        DgvMq.Item(17, i).Value = DgvMq.Item(11, i).Value
                        DgvMq.Item(18, i).Value = (0)
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub SaldoTotalMq()
        Dim c As Integer = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                DgvMq.Item(19, i).Value = Val(DgvMq.Item(10, i).Value) + Val(DgvMq.Item(13, i).Value) - Val(DgvMq.Item(16, i).Value)
                DgvMq.Item(20, i).Value = DgvMq.Item(17, i).Value
                DgvMq.Item(20, i).Value = (DgvMq.Item(20, i).Value)
                DgvMq.Item(21, i).Value = Val(DgvMq.Item(19, i).Value) * CDbl(DgvMq.Item(20, i).Value)
                DgvMq.Item(21, i).Value = (DgvMq.Item(21, i).Value)
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub SemaforizarMq()
        Dim numero As Integer, i As Integer, Cont As Integer
        Dim FECHAD, FECHITA As String
        i = 0 : Cont = 0
        Dim Cf As String, DA As String
        LoadSemaforo()
        Do
            DA = Now.Day
            FECHAD = DgvMq.Item(7, i).Value
            If Len(Trim(FECHAD)) = 9 Then
                FECHITA = "0" & FECHAD
            Else
                FECHITA = FECHAD
            End If
            If Len(DA) = 1 Then
                DA = "0" & DA
            End If
            Cf = DA & "/" & Mid(FECHITA, 4, 7)
            If Mid(Cf, 4, 2) = "02" Then
                If Val(DA) > 28 Then
                    DA = "28"
                    Cf = DA & "/" & Mid(FECHITA, 4, 7)
                End If
            ElseIf Mid(Cf, 4, 2) = "04" Or Mid(Cf, 4, 2) = "06" Or Mid(Cf, 4, 2) = "09" Or Mid(Cf, 4, 2) = "11" Then
                If Val(DA) > 30 Then
                    DA = "30"
                    Cf = DA & "/" & Mid(FECHITA, 4, 7)
                End If
            Else
                Cf = DA & "/" & Mid(FECHITA, 4, 7)
            End If

            numero = DateDiff(DateInterval.Month, Now, CDate(Cf))
            numero = numero
            If numero >= 0 And numero <= (Rojo - 1) Then
                DgvMq.Rows(i).Cells(7).Style.BackColor = Color.Red
                DgvMq.Rows(i).Cells(7).Style.ForeColor = Color.White
            End If
            If numero >= (Rojo) And numero <= (Amarillo - 1) Then
                DgvMq.Rows(i).Cells(7).Style.BackColor = Color.Yellow
                DgvMq.Rows(i).Cells(7).Style.ForeColor = Color.Black
            End If
            If numero > (Amarillo - 1) Then
                DgvMq.Rows(i).Cells(7).Style.BackColor = Color.Green
                DgvMq.Rows(i).Cells(7).Style.ForeColor = Color.White
            End If
            If numero < 0 Then
                DgvMq.Rows(i).Cells(7).Style.BackColor = Color.White
                DgvMq.Rows(i).Cells(7).Style.ForeColor = Color.Black
                Cont = Cont + 1
            End If
            i = i + 1
        Loop Until i = DgvMq.RowCount
        'If Cont > 0 Then
        '    LbMensajeMed.Text = "Hay " & Cont & " registro(s) con productos vencidos"
        '    LbMensajeMed.ForeColor = Color.Maroon
        'End If
    End Sub

    Private Sub ColorMedMq()
        Dim i As Integer
        i = 0
        Do
            DgvMq.Rows(i).Cells(10).Style.BackColor = Color.LightBlue
            DgvMq.Rows(i).Cells(11).Style.BackColor = Color.LightBlue
            DgvMq.Rows(i).Cells(12).Style.BackColor = Color.LightBlue

            DgvMq.Rows(i).Cells(13).Style.BackColor = Color.LightSalmon
            DgvMq.Rows(i).Cells(14).Style.BackColor = Color.LightSalmon
            DgvMq.Rows(i).Cells(15).Style.BackColor = Color.LightSalmon

            DgvMq.Rows(i).Cells(16).Style.BackColor = Color.LightGreen
            DgvMq.Rows(i).Cells(17).Style.BackColor = Color.LightGreen
            DgvMq.Rows(i).Cells(18).Style.BackColor = Color.LightGreen

            DgvMq.Rows(i).Cells(19).Style.BackColor = Color.LightGray
            DgvMq.Rows(i).Cells(20).Style.BackColor = Color.LightGray
            DgvMq.Rows(i).Cells(21).Style.BackColor = Color.LightGray
            i = i + 1
        Loop Until i = DgvMq.RowCount
    End Sub

    Sub LoadSemaforo()
        Dim ds As New DataSet
        Try
            ds = objCn_Sem.ListarSemaforo
            If ds.Tables(0).Rows.Count > 0 Then
                Rojo = ds.Tables(0).Rows(0).Item("Rojo")
                Amarillo = ds.Tables(0).Rows(0).Item("Amarillo")
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        LoadMqLotesKardex()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        FrmKardex.CbTProd.Enabled = True
        FrmKardex.Button1.Enabled = True
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim c = DgvMq.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        If c > 0 Then
            Dim m_Excel As New Excel.Application
            'm_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim Ruta As String = Application.StartupPath & "\Plantillas\Kardex1.xlsx"
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("KARDEX")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 7
                Dim TIni As Double = 0
                Dim TEnt As Double = 0
                Dim TSal As Double = 0
                Dim TSald As Double = 0
                Do
                    If CheckBox1.Checked = True Then
                        .Range(.Cells(f, 11), .Cells(f, 11)).Select()
                        m_Excel.Selection.Interior.color = Color.LightBlue
                        .Range(.Cells(f, 12), .Cells(f, 12)).Select()
                        m_Excel.Selection.Interior.color = Color.LightBlue
                        .Range(.Cells(f, 13), .Cells(f, 13)).Select()
                        m_Excel.Selection.Interior.color = Color.LightBlue

                        .Range(.Cells(f, 14), .Cells(f, 14)).Select()
                        m_Excel.Selection.Interior.color = Color.LightSalmon
                        .Range(.Cells(f, 15), .Cells(f, 15)).Select()
                        m_Excel.Selection.Interior.color = Color.LightSalmon
                        .Range(.Cells(f, 16), .Cells(f, 16)).Select()
                        m_Excel.Selection.Interior.color = Color.LightSalmon

                        .Range(.Cells(f, 17), .Cells(f, 17)).Select()
                        m_Excel.Selection.Interior.color = Color.LightGreen
                        .Range(.Cells(f, 18), .Cells(f, 18)).Select()
                        m_Excel.Selection.Interior.color = Color.LightGreen
                        .Range(.Cells(f, 19), .Cells(f, 19)).Select()
                        m_Excel.Selection.Interior.color = Color.LightGreen

                        .Range(.Cells(f, 20), .Cells(f, 20)).Select()
                        m_Excel.Selection.Interior.color = Color.LightGray
                        .Range(.Cells(f, 21), .Cells(f, 21)).Select()
                        m_Excel.Selection.Interior.color = Color.LightGray
                        .Range(.Cells(f, 22), .Cells(f, 22)).Select()
                        m_Excel.Selection.Interior.color = Color.LightGray
                    End If
                    numero = 0 : temp = ""
                    .Cells(f, 1) = DgvMq.Item(1, i).Value
                    .Cells(f, 2) = DgvMq.Item(2, i).Value
                    .Cells(f, 3) = DgvMq.Item(3, i).Value
                    .Cells(f, 4) = DgvMq.Item(4, i).Value
                    .Cells(f, 5) = DgvMq.Item(5, i).Value
                    .Cells(f, 6) = DgvMq.Item(1, i).Value
                    .Cells(f, 7) = DgvMq.Item(6, i).Value
                    Dim fe As Date = DgvMq.Item(7, i).Value
                    .Cells(f, 8) = fe
                    .Cells(f, 9) = DgvMq.Item(8, i).Value
                    .Cells(f, 10) = DgvMq.Item(9, i).Value

                    .Cells(f, 11) = DgvMq.Item(10, i).Value
                    .Cells(f, 12) = (DgvMq.Item(11, i).Value)
                    .Cells(f, 13) = (DgvMq.Item(12, i).Value)
                    TIni = TIni + (DgvMq.Item(12, i).Value)

                    .Cells(f, 14) = DgvMq.Item(13, i).Value
                    .Cells(f, 15) = (DgvMq.Item(14, i).Value)
                    .Cells(f, 16) = (DgvMq.Item(15, i).Value)
                    TEnt = TEnt + (DgvMq.Item(15, i).Value)

                    .Cells(f, 17) = DgvMq.Item(16, i).Value
                    .Cells(f, 18) = (DgvMq.Item(17, i).Value)
                    .Cells(f, 19) = (DgvMq.Item(18, i).Value)
                    TSal = TSal + (DgvMq.Item(18, i).Value)

                    .Cells(f, 20) = DgvMq.Item(19, i).Value
                    .Cells(f, 21) = (DgvMq.Item(20, i).Value)
                    .Cells(f, 22) = (DgvMq.Item(21, i).Value)
                    .Cells(f, 23) = (DgvMq.Item(22, i).Value)
                    TSald = TSald + (DgvMq.Item(21, i).Value)
                    '---------Cargar el Semaforo--------------------------------
                    ' temp = "01/" & DgvMq.Item(11, i).Value
                    temp = DgvMq.Item(7, i).Value
                    ' If strColumna = "F" Then
                    numero = DateDiff(DateInterval.Month, Now, CDate(temp))
                    numero = numero + 1
                    If numero > 0 And numero <= Rojo Then
                        .Range(.Cells(f, 8), .Cells(f, 8)).Select()
                        m_Excel.Selection.Interior.color = Color.Red
                    End If
                    If numero >= (Rojo + 1) And numero <= Amarillo Then
                        .Range(.Cells(f, 8), .Cells(f, 8)).Select()
                        m_Excel.Selection.Interior.color = Color.Yellow
                    End If
                    If numero > Amarillo Then
                        .Range(.Cells(f, 8), .Cells(f, 8)).Select()
                        m_Excel.Selection.Interior.color = Color.Green
                    End If
                    If numero <= 0 Then
                        .Range(.Cells(f, 8), .Cells(f, 8)).Select()
                        m_Excel.Selection.Interior.color = Color.White
                    End If
                    f = f + 1
                    i = i + 1
                Loop Until i = c
                '.Range("B4").Value = "FECHA DE CORTE: " & Now.Date
                .Cells(f, 13) = TIni
                .Cells(f, 16) = TEnt
                .Cells(f, 19) = TSal
                .Cells(f, 22) = TSald

                .Cells(f, 1) = "TOTALES"
                .Range(.Cells(f, 1), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                f = f + 1
                .Cells(f, 2) = "FIRMA DIRECTOR/COORDINADOR: " ' & Director
                .Range(.Cells(f, 2), .Cells(f, 6)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                m_Excel.Rows(f).RowHeight = 40

                .Cells(f, 7) = "NOMBRE Y FIRMA: " ' & AuxFarmacia
                .Range(.Cells(f, 7), .Cells(f, 14)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 15) = "NOMBRE Y FIRMA: " ' & AuxFarmacia
                .Range(.Cells(f, 15), .Cells(f, 22)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Range(.Cells(7, 2), .Cells(f, 22)).Borders.LineStyle = 1


                .Range("C4").Value = UCase(FrmModulos.LbSede.Text)
                .Range("K4").Value = 'UCase(AuxFarmacia)
                .Range("R4").Value = UCase(TbMes.Text)
                .Range("U4").Value = UCase(TbAño.Text)


            End With
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TbBMes.Enabled = True
        TbBAño.Enabled = True
        TbBAño.Text = Now.Year
        TbBMes.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TbBMes.Enabled = False
        TbBAño.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvMq.ColumnCount
            worksheet.Cells(1, i) = Me.DgvMq.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvMq.Rows.Count - 1
            For j As Integer = 0 To Me.DgvMq.Columns.Count - 1
                If Me.DgvMq.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvMq.Rows(I).Cells(j).Value.ToString()
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