Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_Alm_KardexMed
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
    Private Sub Frm_Alm_KardexMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvMed.Font = New Font("Arial", 8, FontStyle.Regular)
        LoadMesActivo()
        RadioButton1.Checked = True
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        FrmKardex.CbTProd.Enabled = True
        FrmKardex.Button1.Enabled = True
        Me.Dispose()
        Me.Close()
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

    Sub LoadMedLotesKardex()
        Dim ds As New DataSet
        Try
            DgvMed.Rows.Clear()
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            objCe_P.TipoProd = Val(FrmKardex.CbTProd.SelectedValue.ToString)
            objCe_L.Almacen = Val(FrmKardex.CbAlmacen.SelectedValue.ToString)
            ds = objCn_L.ListarLotesMedKardex(objCe_L, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    DgvMed.Rows.Add()
                    DgvMed.Item(0, i).Value = ds.Tables(0).Rows(i).Item("Cons")
                    DgvMed.Item(1, i).Value = ds.Tables(0).Rows(i).Item("Cum")
                    DgvMed.Item(3, i).Value = ds.Tables(0).Rows(i).Item("Prod")
                    DgvMed.Item(8, i).Value = ds.Tables(0).Rows(i).Item("Lab")
                    DgvMed.Item(9, i).Value = ds.Tables(0).Rows(i).Item("Lote")
                    DgvMed.Item(10, i).Value = ds.Tables(0).Rows(i).Item("Invima")
                    DgvMed.Item(11, i).Value = Format(ds.Tables(0).Rows(i).Item("Vence"), "dd/MM/yyyy")
                    DgvMed.Item(12, i).Value = ds.Tables(0).Rows(i).Item("Ini")
                    DgvMed.Item(13, i).Value = (ds.Tables(0).Rows(i).Item("Unitario"))
                    DgvMed.Item(14, i).Value = (ds.Tables(0).Rows(i).Item("Total"))
                    If IsDBNull(ds.Tables(0).Rows(i).Item("Obs")) = False Then
                        DgvMed.Item(25, i).Value = ds.Tables(0).Rows(i).Item("Obs")
                    End If
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If DgvMed.Rows.Count > 0 Then
                LoadEntradas()
                LoadSalidas()
                SaldoTotal()
                Semaforizar()
                ColorMed()
                LoadDatosMed()
            End If
        End Try
    End Sub

    Sub LoadMedLotesKardexMes()
        Dim ds As New DataSet
        Try
            DgvMed.Rows.Clear()
            objCe_L.Mes = Val(TbBMes.Text.Trim)
            objCe_L.Año = Val(TbBAño.Text.Trim)
            objCe_P.TipoProd = Val(FrmKardex.CbTProd.SelectedValue.ToString)
            objCe_L.Almacen = Val(FrmKardex.CbAlmacen.SelectedValue.ToString)
            ds = objCn_L.ListarLotesMedKardex(objCe_L, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    DgvMed.Rows.Add()
                    DgvMed.Item(0, i).Value = ds.Tables(0).Rows(i).Item("Cons")
                    DgvMed.Item(1, i).Value = ds.Tables(0).Rows(i).Item("Cum")
                    DgvMed.Item(3, i).Value = ds.Tables(0).Rows(i).Item("Prod")
                    DgvMed.Item(8, i).Value = ds.Tables(0).Rows(i).Item("Lab")
                    DgvMed.Item(9, i).Value = ds.Tables(0).Rows(i).Item("Lote")
                    DgvMed.Item(10, i).Value = ds.Tables(0).Rows(i).Item("Invima")
                    DgvMed.Item(11, i).Value = Format(ds.Tables(0).Rows(i).Item("Vence"), "dd/MM/yyyy")
                    DgvMed.Item(12, i).Value = ds.Tables(0).Rows(i).Item("Ini")
                    DgvMed.Item(13, i).Value = (ds.Tables(0).Rows(i).Item("Unitario"))
                    DgvMed.Item(14, i).Value = (ds.Tables(0).Rows(i).Item("Total"))
                    If IsDBNull(ds.Tables(0).Rows(i).Item("Obs")) = False Then
                        DgvMed.Item(25, i).Value = ds.Tables(0).Rows(i).Item("Obs")
                    End If
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If DgvMed.Rows.Count > 0 Then
                LoadEntradas()
                LoadSalidas()
                SaldoTotal()
                Semaforizar()
                ColorMed()
                LoadDatosMed()
            End If
        End Try
    End Sub

    Sub LoadEntradas()
        Dim ds As DataSet
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(DgvMed.Item(0, i).Value)
                    objCe_E.Mes = Val(TbConsMes.Text.Trim)
                    objCe_E.Año = Val(TbAño.Text.Trim)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMed.Item(15, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMed.Item(15, i).Value = 0
                        End If
                        If IsDBNull((ds.Tables(0).Rows(0).Item(1))) = False Then
                            DgvMed.Item(16, i).Value = (ds.Tables(0).Rows(0).Item(1))
                        Else
                            DgvMed.Item(16, i).Value = 0
                        End If
                        DgvMed.Item(17, i).Value = Val(DgvMed.Item(15, i).Value) * Val(DgvMed.Item(16, i).Value)
                        DgvMed.Item(17, i).Value = (DgvMed.Item(17, i).Value)
                    Else
                        DgvMed.Item(15, i).Value = 0
                        DgvMed.Item(16, i).Value = DgvMed.Item(13, i).Value
                        DgvMed.Item(17, i).Value = (0)
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadSalidas()
        Dim ds As DataSet
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_S.Lote = Val(DgvMed.Item(0, i).Value)
                    objCe_S.Mes = Val(TbConsMes.Text.Trim)
                    objCe_S.Año = Val(TbAño.Text.Trim)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMed.Item(18, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMed.Item(18, i).Value = 0
                        End If

                        If DgvMed.Item(13, i).Value = 0 Then
                            DgvMed.Item(19, i).Value = DgvMed.Item(16, i).Value
                        Else
                            If DgvMed.Item(16, i).Value = 0 Then
                                DgvMed.Item(19, i).Value = DgvMed.Item(13, i).Value
                            Else
                                DgvMed.Item(19, i).Value = (DgvMed.Item(13, i).Value + DgvMed.Item(16, i).Value) / 2
                            End If
                        End If
                        DgvMed.Item(20, i).Value = Val(DgvMed.Item(18, i).Value) * Val(DgvMed.Item(19, i).Value)
                        DgvMed.Item(20, i).Value = (DgvMed.Item(20, i).Value)
                    Else
                        DgvMed.Item(18, i).Value = 0
                        DgvMed.Item(19, i).Value = DgvMed.Item(13, i).Value
                        DgvMed.Item(20, i).Value = (0)
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub SaldoTotal()
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                DgvMed.Item(21, i).Value = Val(DgvMed.Item(12, i).Value) + Val(DgvMed.Item(15, i).Value) - Val(DgvMed.Item(18, i).Value)
                DgvMed.Item(22, i).Value = DgvMed.Item(19, i).Value
                DgvMed.Item(22, i).Value = (DgvMed.Item(22, i).Value)
                If Val(DgvMed.Item(21, i).Value) > 0 Then
                    If (DgvMed.Item(16, i).Value = 0) And (DgvMed.Item(19, i).Value = 0) Then
                        DgvMed.Item(22, i).Value = DgvMed.Item(13, i).Value
                    End If
                End If
                DgvMed.Item(23, i).Value = Val(DgvMed.Item(21, i).Value) * Val(DgvMed.Item(22, i).Value)
                DgvMed.Item(23, i).Value = (DgvMed.Item(23, i).Value)
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub Semaforizar()
        Dim numero As Integer, i As Integer, Cont As Integer
        Dim FECHAD, FECHITA As String
        i = 0 : Cont = 0
        Dim Cf As String, DA As String
        LoadSemaforo()
        Do
            DA = Now.Day
            FECHAD = DgvMed.Item(11, i).Value
            If Len(Trim(FECHAD)) = 9 Then
                FECHITA = "0" & FECHAD
            Else
                FECHITA = FECHAD
            End If
            If Len(DA) = 1 Then
                DA = "0" & DA
            End If
            Cf = (DA & "-" & Mid(FECHITA, 4, 7))
            If Mid(Cf, 4, 2) = "02" Then
                If Val(DA) > 28 Then
                    DA = "28"
                    Cf = DA & "-" & Mid(FECHITA, 4, 7)
                End If
            ElseIf Mid(Cf, 4, 2) = "04" Or Mid(Cf, 4, 2) = "06" Or Mid(Cf, 4, 2) = "09" Or Mid(Cf, 4, 2) = "11" Then
                If Val(DA) > 30 Then
                    DA = "30"
                    Cf = DA & "-" & Mid(FECHITA, 4, 7)
                End If
            Else
                Cf = DA & "-" & Mid(FECHITA, 4, 7)
            End If

            numero = DateDiff(DateInterval.Month, Now, CDate(Cf))
            numero = numero
            If numero >= 0 And numero <= (Rojo - 1) Then
                DgvMed.Rows(i).Cells(11).Style.BackColor = Color.Red
                DgvMed.Rows(i).Cells(11).Style.ForeColor = Color.White
            End If
            If numero >= (Rojo) And numero <= (Amarillo - 1) Then
                DgvMed.Rows(i).Cells(11).Style.BackColor = Color.Yellow
                DgvMed.Rows(i).Cells(11).Style.ForeColor = Color.Black
            End If
            If numero > (Amarillo - 1) Then
                DgvMed.Rows(i).Cells(11).Style.BackColor = Color.Green
                DgvMed.Rows(i).Cells(11).Style.ForeColor = Color.White
            End If
            If numero < 0 Then
                DgvMed.Rows(i).Cells(11).Style.BackColor = Color.White
                DgvMed.Rows(i).Cells(11).Style.ForeColor = Color.Black
                Cont = Cont + 1
            End If
            i = i + 1
        Loop Until i = DgvMed.RowCount
        'If Cont > 0 Then
        '    LbMensajeMed.Text = "Hay " & Cont & " registro(s) con productos vencidos"
        '    LbMensajeMed.ForeColor = Color.Maroon
        'End If
    End Sub

    Private Sub ColorMed()
        Dim i As Integer
        i = 0
        Do
            DgvMed.Rows(i).Cells(12).Style.BackColor = Color.LightBlue
            DgvMed.Rows(i).Cells(13).Style.BackColor = Color.LightBlue
            DgvMed.Rows(i).Cells(14).Style.BackColor = Color.LightBlue

            DgvMed.Rows(i).Cells(15).Style.BackColor = Color.LightSalmon
            DgvMed.Rows(i).Cells(16).Style.BackColor = Color.LightSalmon
            DgvMed.Rows(i).Cells(17).Style.BackColor = Color.LightSalmon

            DgvMed.Rows(i).Cells(18).Style.BackColor = Color.LightGreen
            DgvMed.Rows(i).Cells(19).Style.BackColor = Color.LightGreen
            DgvMed.Rows(i).Cells(20).Style.BackColor = Color.LightGreen

            DgvMed.Rows(i).Cells(21).Style.BackColor = Color.LightGray
            DgvMed.Rows(i).Cells(22).Style.BackColor = Color.LightGray
            DgvMed.Rows(i).Cells(23).Style.BackColor = Color.LightGray
            i = i + 1
        Loop Until i = DgvMed.RowCount
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

    Sub LoadDatosMed()
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim ds As New DataSet
            Dim i As Integer = 0
            Do
                objCe_P.Cons = Val(DgvMed.Item(3, i).Value)
                ds = objCn_P.LoadDatosProdMedKardex(objCe_P)
                If ds.Tables(0).Rows.Count > 0 Then
                    DgvMed.Item(2, i).Value = ds.Tables(0).Rows(0).Item("Atc")
                    DgvMed.Item(3, i).Value = ds.Tables(0).Rows(0).Item("Descripcion")
                    DgvMed.Item(6, i).Value = ds.Tables(0).Rows(0).Item("Concentracion")
                    DgvMed.Item(4, i).Value = ds.Tables(0).Rows(0).Item("Presentacion")
                    DgvMed.Item(5, i).Value = ds.Tables(0).Rows(0).Item("Forma")
                    DgvMed.Item(7, i).Value = ds.Tables(0).Rows(0).Item("Unidad")
                    DgvMed.Item(24, i).Value = ds.Tables(0).Rows(0).Item("Tipo")
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        DgvMed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        If FrmKardex.CbTProd.Text = "MEDICAMENTO" Then
            LoadMedLotesKardex()
        End If
        If RadioButton3.Checked = True Then
            LoadMedLotesKardexMes()
        End If
        DgvMed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim c = DgvMed.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        If c > 0 Then
            Dim m_Excel As New Excel.Application
            'm_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim Ruta As String = Application.StartupPath & "\Plantillas\Kardex.xlsx"
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("MEDICAMENTOS")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 7
                Dim Tipo As String = ""
                Dim c1 As Integer = 0
                Dim TotIni As Double = 0
                Dim TotEntrada As Double = 0
                Dim TotSalidas As Double = 0
                Dim TotSaldo As Double = 0

                Dim TIni As Double = 0
                Dim TEntrada As Double = 0
                Dim TSalidas As Double = 0
                Dim TSaldo As Double = 0

                Do
                    numero = 0 : temp = ""
                    If Tipo <> DgvMed.Item(24, i).Value Then
                        If c1 > 0 Then
                            .Range(.Cells(f, 3), .Cells(f, 13)).Select()
                            m_Excel.Selection.Merge()
                            m_Excel.Selection.Font.Bold = True
                            .Cells(f, 3) = "TOTAL " & Tipo
                            .Cells(f, 16) = TotIni
                            .Cells(f, 19) = TotEntrada
                            .Cells(f, 22) = TotSalidas
                            .Cells(f, 25) = TotSaldo
                            TotIni = 0 : TotEntrada = 0 : TotSalidas = 0 : TotSaldo = 0
                            f = f + 1
                        End If

                        Tipo = DgvMed.Item(24, i).Value
                        .Cells(f, 3) = Tipo
                        .Range(.Cells(f, 3), .Cells(f, 25)).Select()
                        m_Excel.Selection.Merge()
                        m_Excel.Selection.Font.Bold = True
                        m_Excel.Selection.Font.size = 16
                        If Tipo = "MEDICAMENTOS DE CONTROL" Then
                            m_Excel.Selection.Interior.color = Color.DarkViolet
                        Else
                            m_Excel.Selection.Interior.color = Color.Orange
                        End If
                        c1 = c1 + 1
                        i = i - 1
                    Else
                        If CheckBox1.Checked = True Then
                            .Range(.Cells(f, 14), .Cells(f, 14)).Select()
                            m_Excel.Selection.Interior.color = Color.LightBlue
                            .Range(.Cells(f, 15), .Cells(f, 15)).Select()
                            m_Excel.Selection.Interior.color = Color.LightBlue
                            .Range(.Cells(f, 16), .Cells(f, 16)).Select()
                            m_Excel.Selection.Interior.color = Color.LightBlue

                            .Range(.Cells(f, 17), .Cells(f, 17)).Select()
                            m_Excel.Selection.Interior.color = Color.LightSalmon
                            .Range(.Cells(f, 18), .Cells(f, 18)).Select()
                            m_Excel.Selection.Interior.color = Color.LightSalmon
                            .Range(.Cells(f, 19), .Cells(f, 19)).Select()
                            m_Excel.Selection.Interior.color = Color.LightSalmon

                            .Range(.Cells(f, 20), .Cells(f, 20)).Select()
                            m_Excel.Selection.Interior.color = Color.LightGreen
                            .Range(.Cells(f, 21), .Cells(f, 21)).Select()
                            m_Excel.Selection.Interior.color = Color.LightGreen
                            .Range(.Cells(f, 22), .Cells(f, 22)).Select()
                            m_Excel.Selection.Interior.color = Color.LightGreen

                            .Range(.Cells(f, 23), .Cells(f, 23)).Select()
                            m_Excel.Selection.Interior.color = Color.LightGray
                            .Range(.Cells(f, 24), .Cells(f, 24)).Select()
                            m_Excel.Selection.Interior.color = Color.LightGray
                            .Range(.Cells(f, 25), .Cells(f, 25)).Select()
                            m_Excel.Selection.Interior.color = Color.LightGray
                        End If

                        .Cells(f, 1) = "."
                        .Cells(f, 2) = "."
                        .Cells(f, 3) = DgvMed.Item(1, i).Value
                        .Cells(f, 4) = DgvMed.Item(2, i).Value
                        .Cells(f, 5) = DgvMed.Item(3, i).Value
                        .Cells(f, 6) = DgvMed.Item(4, i).Value
                        .Cells(f, 7) = DgvMed.Item(5, i).Value
                        .Cells(f, 8) = DgvMed.Item(6, i).Value
                        .Cells(f, 9) = DgvMed.Item(7, i).Value
                        .Cells(f, 10) = DgvMed.Item(8, i).Value
                        .Cells(f, 11) = DgvMed.Item(9, i).Value
                        .Cells(f, 12) = DgvMed.Item(10, i).Value
                        Dim fe As Date = DgvMed.Item(11, i).Value
                        .Cells(f, 13) = fe
                        .Cells(f, 14) = DgvMed.Item(12, i).Value
                        .Cells(f, 15) = (DgvMed.Item(13, i).Value)
                        .Cells(f, 16) = (DgvMed.Item(14, i).Value)
                        If i < c Then
                            TotIni = TotIni + (DgvMed.Item(14, i).Value)
                            TIni = TIni + (DgvMed.Item(14, i).Value)
                        End If
                        .Cells(f, 17) = DgvMed.Item(15, i).Value
                        .Cells(f, 18) = (DgvMed.Item(16, i).Value)
                        .Cells(f, 19) = (DgvMed.Item(17, i).Value)
                        If i < c Then
                            TotEntrada = TotEntrada + (DgvMed.Item(17, i).Value)
                            TEntrada = TEntrada + (DgvMed.Item(17, i).Value)
                        End If
                        .Cells(f, 20) = DgvMed.Item(18, i).Value
                        .Cells(f, 21) = (DgvMed.Item(19, i).Value)
                        .Cells(f, 22) = (DgvMed.Item(20, i).Value)
                        If i < c Then
                            TotSalidas = TotSalidas + (DgvMed.Item(20, i).Value)
                            TSalidas = TSalidas + (DgvMed.Item(20, i).Value)
                        End If

                        .Cells(f, 23) = DgvMed.Item(21, i).Value
                        .Cells(f, 24) = (DgvMed.Item(22, i).Value)
                        .Cells(f, 25) = (DgvMed.Item(23, i).Value)
                        .Cells(f, 26) = DgvMed.Item(25, i).Value
                        If i < c Then
                            TotSaldo = TotSaldo + (DgvMed.Item(23, i).Value)
                            TSaldo = TSaldo + (DgvMed.Item(23, i).Value)
                        End If

                        '.Cells(f, 27) = DgvMed.Item(24, i).Value
                        '---------Cargar el Semaforo--------------------------------
                        ' temp = "01/" & DgvMed.Item(11, i).Value
                        temp = DgvMed.Item(11, i).Value
                        ' If strColumna = "F" Then
                        numero = DateDiff(DateInterval.Month, Now, CDate(temp))
                            numero = numero + 1
                            If numero > 0 And numero <= Rojo Then
                                .Range(.Cells(f, 13), .Cells(f, 13)).Select()
                                m_Excel.Selection.Interior.color = Color.Red
                            End If
                            If numero >= (Rojo + 1) And numero <= Amarillo Then
                                .Range(.Cells(f, 13), .Cells(f, 13)).Select()
                                m_Excel.Selection.Interior.color = Color.Yellow
                            End If
                            If numero > Amarillo Then
                                .Range(.Cells(f, 13), .Cells(f, 13)).Select()
                                m_Excel.Selection.Interior.color = Color.Green
                            End If
                            If numero <= 0 Then
                                .Range(.Cells(f, 13), .Cells(f, 13)).Select()
                                m_Excel.Selection.Interior.color = Color.White
                            End If
                            '------------------------------------------------------------
                        End If

                        f = f + 1
                    i = i + 1
                Loop Until i = c

                .Range(.Cells(f, 3), .Cells(f, 13)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                .Cells(f, 3) = "TOTAL " & Tipo
                .Cells(f, 16) = TotIni
                .Cells(f, 19) = TotEntrada
                .Cells(f, 22) = TotSalidas
                .Cells(f, 25) = TotSaldo
                f = f + 1
                .Range(.Cells(f, 3), .Cells(f, 13)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                .Cells(f, 3) = "TOTAL"
                .Cells(f, 16) = TIni
                .Cells(f, 19) = TEntrada
                .Cells(f, 22) = TSalidas
                .Cells(f, 25) = TSaldo

                f = f + 1
                .Cells(f, 3) = "FIRMA DEL DIRECTOR O COORDINADOR: " '& Director
                .Range(.Cells(f, 3), .Cells(f, 12)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                m_Excel.Rows(f).RowHeight = 40

                .Cells(f, 13) = "FIRMA DEL AUXILIAR DE FARMACIA: " ' & AuxFarmacia
                .Range(.Cells(f, 13), .Cells(f, 25)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True


                .Range(.Cells(7, 3), .Cells(f, 25)).Borders.LineStyle = 1


                .Range("C4").Value = "HOSPITAL/CENTRO DE SALUD: " & UCase(FrmModulos.LbSede.Text)
                .Range("K4").Value = "AUXILIAR DE FARMACIA: " '& UCase(AuxFarmacia)
                .Range("T4").Value = UCase(TbMes.Text)
                .Range("X4").Value = UCase(TbAño.Text)
            End With
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TbBMes.Enabled = False
        TbBAño.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TbBMes.Enabled = True
        TbBAño.Enabled = True
        TbBAño.Text = Now.Date.Year
        TbBMes.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvMed.ColumnCount
            worksheet.Cells(1, i) = Me.DgvMed.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvMed.Rows.Count - 1
            For j As Integer = 0 To Me.DgvMed.Columns.Count - 1
                If Me.DgvMed.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvMed.Rows(I).Cells(j).Value.ToString()
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