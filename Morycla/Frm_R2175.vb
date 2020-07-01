Imports C_Entidad
Imports C_Negocio
Public Class Frm_R2175
    Dim CT2, CT3, CT4, CT5, CT6, CT7, CT As Integer
    Dim objce_Te As New Ce_T_Error
    Dim objCe_T2 As New Ce_T2
    Dim objCe_T3 As New Ce_T3
    Dim objCe_T4 As New Ce_T4
    Dim objCe_T5 As New Ce_T5
    Dim objCe_T6 As New Ce_T6
    Dim objCe_T7 As New Ce_T7

    Dim objCn_S As New Cn_Sedes
    Dim objCn_Te As New Cn_T_Error
    Dim objCn_T2 As New Cn_T2
    Dim objCn_T3 As New Cn_T3
    Dim objCn_T4 As New Cn_T4
    Dim objCn_T5 As New Cn_T5
    Dim objCn_T6 As New Cn_T6
    Dim objCn_T7 As New Cn_T7

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarSedes()
        Dim ds As New DataSet
        CbSede.DataSource = Nothing
        Try
            ds = objCn_S.LoadSedesActivas
            If ds.Tables(0).Rows.Count > 0 Then
                CbSede.DataSource = ds.Tables(0)
                CbSede.DisplayMember = "Sede"
                CbSede.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub BtnLeerArchivo_Click(sender As Object, e As EventArgs) Handles BtnLeerArchivo.Click
        ProgressBar1.Text = ""
        ProgressBar2.Text = ""
        ProgressBar1.TextVisible = True
        ProgressBar2.TextVisible = True
        BtnSubir.Enabled = False
        BtnPlano.Enabled = False
        Dim Arch As String
        DgvT2.Rows.Clear()
        DgvT3.Rows.Clear()
        DgvT4.Rows.Clear()
        DgvT5.Rows.Clear()
        DgvT6.Rows.Clear()
        DgvT7.Rows.Clear()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 6
        OpenFileDialog1.ShowDialog()
        Arch = OpenFileDialog1.FileName
        Frm_Message.Show()
        Frm_Message.Label1.Text = "Leyendo Registros..."
        Timer1.Start()
        TabControl1.SelectedTab = TabPage1
        ProgressBar2.ResetText()
        ProgressBar2.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "Procesando Tipo 2"
        Call Excel_FlexGrid(Arch, DgvT2, Val(Tb2.Text) + 1, 13, "2")
        FormatosTipo2()
        Application.DoEvents()
        TabControl1.SelectedTab = TabPage2
        ProgressBar2.Value = 0
        ProgressBar2.ResetText()
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "Procesando Tipo 3"
        Call Excel_FlexGrid(Arch, DgvT3, Val(Tb3.Text) + 1, 21, "3")
        FormatosTipo3()
        Application.DoEvents()
        TabControl1.SelectedTab = TabPage3
        ProgressBar2.ResetText()
        ProgressBar2.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "Procesando Tipo 4"
        Call Excel_FlexGrid(Arch, DgvT4, Val(Tb4.Text) + 1, 18, "4")
        FormatosTipo4()
        Application.DoEvents()
        TabControl1.SelectedTab = TabPage4
        ProgressBar2.ResetText()
        ProgressBar2.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "Procesando Tipo 5"
        Call Excel_FlexGrid(Arch, DgvT5, Val(Tb5.Text) + 1, 18, "5")
        FormatosTipo5()
        Application.DoEvents()
        TabControl1.SelectedTab = TabPage5
        ProgressBar2.ResetText()
        ProgressBar2.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "Procesando Tipo 6"
        Call Excel_FlexGrid(Arch, DgvT6, Val(Tb6.Text) + 1, 27, "6")
        FormatosTipo6()
        Application.DoEvents()
        TabControl1.SelectedTab = TabPage6
        ProgressBar2.ResetText()
        ProgressBar2.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "Procesando Tipo 7"
        Call Excel_FlexGrid(Arch, DgvT7, Val(Tb7.Text) + 1, 22, "7")
        FormatosTipo7()
        Timer1.Stop()
        Frm_Message.Hide()
    End Sub

    Private Sub Frm_R2175_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbTotal.Text = ""
        LbTotal.Visible = False
        BtnSubir.Enabled = False
        BtnPlano.Enabled = False
        ProgressBar1.Text = ""
        ProgressBar2.Text = ""
        ProgressBar1.Visible = True
        ProgressBar2.Visible = True
        ListarSedes()
        DgvT2.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvT3.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvT4.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvT5.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvT6.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvT7.Font = New Font("Arial", 8, FontStyle.Regular)
    End Sub

    Private Sub Excel_FlexGrid(sPath As String, FlexGrid As DataGridView, Filas As Integer, Columnas As Integer, Optional sSheetName As String = vbNullString)
        Frm_Message.BringToFront()
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        ' -- Comproba si existe l archivo
        If Len(Dir(sPath)) = 0 Then
            MsgBox("No se ha encontrado el archivo: " & sPath, vbCritical)
            Exit Sub
        End If
        'Me.MousePointer = vbHourglass
        ' -- crea rnueva instancia de Excel
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open(sPath)
        ' -- referencia la Hoja, por defecto la hoja activa
        If sSheetName = vbNullString Then
            oSheet = oBook.ActiveSheet
        Else
            oSheet = oBook.Sheets(sSheetName)
        End If
        With FlexGrid
            .ColumnCount = Columnas
            Dim i1 As Integer = 0
            Dim N1 As Integer = 0
            ProgressBar2.Minimum = 1
            ProgressBar2.Maximum = Filas
            Do
                N1 = 0
                .Rows.Add()
                Do
                    .Item(N1, .Rows.Count - 1).Value = oSheet.cells(i1 + 1, N1 + 1).Value
                    N1 = N1 + 1
                Loop Until N1 = Columnas
                i1 = i1 + 1
                ProgressBar2.Text = "Procesando el registro " & i1 - 1 & " de " & Filas - 1
                ProgressBar2.Value = ProgressBar2.Value + 1
                Application.DoEvents()
            Loop Until i1 = Filas
        End With
        oBook.Close
        oExcel.Quit
        'Call Descargar
        Exit Sub
    End Sub

    Private Sub AutosizaSI()
        DgvT2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvT3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvT4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvT5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvT6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvT7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub AutosizaNO()
        DgvT2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DgvT3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DgvT4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DgvT5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DgvT6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DgvT7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
    End Sub

    Private Sub FormatosTipo2()
        On Error Resume Next
        Dim c As Integer = DgvT2.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                'DgvT3.Item(14, i).Value = FormatNumber(DgvT3.Item(14, i).Value, -1)
                If Trim(DgvT2.Item(4, i).Value) <> "" Then
                    DgvT2.Item(4, i).Value = Format(CDate(DgvT2.Item(4, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT2.Item(12, i).Value) <> "" Then
                    DgvT2.Item(12, i).Value = Format(CDate(DgvT2.Item(12, i).Value), "yyyy-MM-dd")
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub FormatosTipo3()
        On Error Resume Next
        Dim c As Integer = DgvT3.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                'DgvT3.Item(14, i).Value = FormatNumber(DgvT3.Item(14, i).Value, -1)
                If Trim(DgvT3.Item(4, i).Value) <> "" Then
                    DgvT3.Item(4, i).Value = Format(CDate(DgvT3.Item(4, i).Value), "yyyy-MM-dd")
                End If
                DgvT3.Item(14, i).Value = Format(DgvT3.Item(14, i).Value, "#0.000")
                If Trim(DgvT3.Item(11, i).Value) <> "" Then
                    DgvT3.Item(11, i).Value = Format(CDate(DgvT3.Item(11, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT3.Item(16, i).Value) <> "" Then
                    DgvT3.Item(16, i).Value = Format(CDate(DgvT3.Item(16, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT3.Item(17, i).Value) <> "" Then
                    DgvT3.Item(17, i).Value = Format(CDate(DgvT3.Item(17, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT3.Item(18, i).Value) <> "" Then
                    DgvT3.Item(18, i).Value = Format(CDate(DgvT3.Item(18, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT3.Item(19, i).Value) <> "" Then
                    DgvT3.Item(19, i).Value = Format(CDate(DgvT3.Item(19, i).Value), "yyyy-MM-dd")
                End If
                DgvT3.Item(20, i).Value = Format(DgvT3.Item(20, i).Value, "#0.0")
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub FormatosTipo4()
        On Error Resume Next
        Dim c As Integer = DgvT4.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                If Trim(DgvT4.Item(4, i).Value) <> "" Then
                    DgvT4.Item(4, i).Value = Format(CDate(DgvT4.Item(4, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT4.Item(11, i).Value) <> "" Then
                    DgvT4.Item(11, i).Value = Format(CDate(DgvT4.Item(11, i).Value), "yyyy-MM-dd")
                End If
                DgvT4.Item(14, i).Value = Format(DgvT4.Item(14, i).Value, "#0.000")
                If Trim(DgvT4.Item(16, i).Value) <> "" Then
                    DgvT4.Item(16, i).Value = Format(CDate(DgvT4.Item(16, i).Value), "yyyy-MM-dd")
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub FormatosTipo5()
        On Error Resume Next
        Dim c As Integer = DgvT5.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                If Trim(DgvT5.Item(4, i).Value) <> "" Then
                    DgvT5.Item(4, i).Value = Format(CDate(DgvT5.Item(4, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT5.Item(11, i).Value) <> "" Then
                    DgvT5.Item(11, i).Value = Format(CDate(DgvT5.Item(11, i).Value), "yyyy-MM-dd")
                End If
                DgvT5.Item(14, i).Value = Format(DgvT5.Item(14, i).Value, "#0.000")
                If Trim(DgvT5.Item(16, i).Value) <> "" Then
                    DgvT5.Item(16, i).Value = Format(CDate(DgvT5.Item(16, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT5.Item(17, i).Value) <> "" Then
                    DgvT5.Item(17, i).Value = Format(DgvT5.Item(17, i).Value, "#0.0")
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub FormatosTipo6()
        On Error Resume Next
        Dim c As Integer = DgvT6.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                If Trim(DgvT6.Item(8, i).Value) <> "" Then
                    DgvT6.Item(8, i).Value = Format(CDate(DgvT6.Item(8, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(11, i).Value) <> "" Then
                    DgvT6.Item(11, i).Value = Format(CDate(DgvT6.Item(11, i).Value), "yyyy-MM-dd")
                End If

                If Trim(DgvT6.Item(14, i).Value) <> "" Then
                    DgvT6.Item(14, i).Value = Format(CDate(DgvT6.Item(14, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(15, i).Value) <> "" Then
                    DgvT6.Item(15, i).Value = Format(CDate(DgvT6.Item(15, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(16, i).Value) <> "" Then
                    DgvT6.Item(16, i).Value = Format(CDate(DgvT6.Item(16, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(17, i).Value) <> "" Then
                    DgvT6.Item(17, i).Value = Format(CDate(DgvT6.Item(17, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(19, i).Value) <> "" Then
                    DgvT6.Item(19, i).Value = Format(CDate(DgvT6.Item(19, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(21, i).Value) <> "" Then
                    DgvT6.Item(21, i).Value = Format(CDate(DgvT6.Item(21, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(22, i).Value) <> "" Then
                    DgvT6.Item(22, i).Value = Format(CDate(DgvT6.Item(22, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(24, i).Value) <> "" Then
                    DgvT6.Item(24, i).Value = Format(CDate(DgvT6.Item(24, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT6.Item(25, i).Value) <> "" Then
                    DgvT6.Item(25, i).Value = Format(DgvT6.Item(25, i).Value, "#0.0")
                End If
                If Trim(DgvT6.Item(26, i).Value) <> "" Then
                    DgvT6.Item(26, i).Value = Format(CDate(DgvT6.Item(26, i).Value), "yyyy-MM-dd")
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub FormatosTipo7()
        On Error Resume Next
        Dim c As Integer = DgvT7.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                If Trim(DgvT7.Item(9, i).Value) <> "" Then
                    DgvT7.Item(9, i).Value = Format(CDate(DgvT7.Item(9, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT7.Item(13, i).Value) <> "" Then
                    DgvT7.Item(13, i).Value = Format(CDate(DgvT7.Item(13, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT7.Item(16, i).Value) <> "" Then
                    DgvT7.Item(16, i).Value = Format(CDate(DgvT7.Item(16, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT7.Item(18, i).Value) <> "" Then
                    DgvT7.Item(18, i).Value = Format(CDate(DgvT7.Item(18, i).Value), "yyyy-MM-dd")
                End If
                If Trim(DgvT7.Item(21, i).Value) <> "" Then
                    DgvT7.Item(21, i).Value = Format(CDate(DgvT7.Item(21, i).Value), "yyyy-MM-dd")
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Validar_T2()
        Dim c As Integer = DgvT2.Rows.Count
        If c > 0 Then
            Dim i As Integer = 1

            Do
                'TIPO DE REGISTRO
                If DgvT2.Item(0, i).Value <> "2" Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 1
                    objce_Te.Detalle = "El tipo deberia ser 2 y aparece " & DgvT2.Item(0, i).Value
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(1).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(1).Style.ForeColor = Color.White
                End If
                'TIPO DE IDENTIFICACION
                If DgvT2.Item(2, i).Value <> "RC" And DgvT2.Item(2, i).Value <> "NV" Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 2
                    objce_Te.Detalle = "El tipo de documento deberia ser RC ó NV y aparece " & DgvT2.Item(2, i).Value
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(2).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(2).Style.ForeColor = Color.White
                End If
                'NUMERO DE DOCUMENTO
                If Trim(DgvT2.Item(3, i).Value) = "" Or Len(Trim(DgvT2.Item(3, i).Value)) > 18 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 3
                    objce_Te.Detalle = "El número de documento debe tener entre 1 y 17 digitos"
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(3).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(3).Style.ForeColor = Color.White
                End If
                'FECHA DE NACIMIENTO
                If Trim(DgvT2.Item(4, i).Value) = "" Or IsDate(DgvT2.Item(4, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 4
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(4).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(4).Style.ForeColor = Color.White
                End If
                'SEXO
                If DgvT2.Item(5, i).Value <> "H" And DgvT2.Item(5, i).Value <> "M" And DgvT2.Item(5, i).Value <> "I" Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 5
                    objce_Te.Detalle = "El sexo debería ser H,M,I pero aparece " & DgvT2.Item(5, i).Value
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(5).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(5).Style.ForeColor = Color.White
                End If
                'ETNIA
                If Val(DgvT2.Item(6, i).Value) <= 1 And Val(DgvT2.Item(6, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 6
                    objce_Te.Detalle = "La pertencia etnica debe ser un número entre 1 y 6, pero aparece " & DgvT2.Item(6, i).Value
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(6).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If
                'PRIMER APELLIDO
                If Len(Trim(DgvT2.Item(7, i).Value)) < 1 And Len(DgvT2.Item(7, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 7
                    objce_Te.Detalle = "El primer apellido debe tener entre 1 y 60 carácteres"
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(7).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(7).Style.ForeColor = Color.White
                End If
                'SEGUNDO APELLIDO
                If Len(DgvT2.Item(8, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 8
                    objce_Te.Detalle = "El segundo apellido debe tener máximo 60 carácteres"
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(8).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(8).Style.ForeColor = Color.White
                End If
                'PRIMER NOMBRE
                If Len(Trim(DgvT2.Item(9, i).Value)) < 1 And Len(DgvT2.Item(9, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 9
                    objce_Te.Detalle = "El primer nombre debe tener entre 1 y 60 carácteres"
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(9).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(9).Style.ForeColor = Color.White
                End If
                'SEGUNDO NOMBRE
                If Len(DgvT2.Item(10, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 10
                    objce_Te.Detalle = "El segundo nombre debe tener máximo 60 carácteres"
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(10).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(10).Style.ForeColor = Color.White
                End If
                'TAMIZAJE NEONATAL TSH
                If Len(DgvT2.Item(11, i).Value) <> 1 And Len(DgvT2.Item(11, i).Value) <> 2 Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 11
                    objce_Te.Detalle = "El tamizaje para TSH neonatal debe ser 1:SI 2:NO pero aparece " & DgvT2.Item(11, i).Value
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(11).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(11).Style.ForeColor = Color.White
                End If
                'FECHA TAMIZAJE NEONATAL TSH
                If Len(Trim(DgvT2.Item(12, i).Value)) > 0 And IsDate(DgvT2.Item(12, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 2"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT2.Item(12, i).Value
                    CT2 = CT2 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT2.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT2.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Validar_T3()
        Dim Años As Integer = 0
        Dim FN, FA As Date
        Dim F1 As String = ""
        Dim c As Integer = DgvT3.Rows.Count
        If c > 0 Then
            Dim i As Integer = 1

            Do
                Años = 0
                'TIPO DE REGISTRO
                If DgvT3.Item(0, i).Value <> "3" Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 1
                    objce_Te.Detalle = "El tipo deberia ser 3 y aparece " & DgvT3.Item(0, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(1).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(1).Style.ForeColor = Color.White
                End If
                'TIPO DE IDENTIFICACION
                If DgvT3.Item(2, i).Value <> "RC" And DgvT3.Item(2, i).Value <> "PA" Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 2
                    objce_Te.Detalle = "El tipo de documento deberia ser RC ó PA y aparece " & DgvT3.Item(2, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(2).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(2).Style.ForeColor = Color.White
                End If
                'NUMERO DE DOCUMENTO
                If Trim(DgvT3.Item(3, i).Value) = "" Or Len(Trim(DgvT3.Item(3, i).Value)) > 18 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 3
                    objce_Te.Detalle = "El número de documento debe tener entre 1 y 17 digitos"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(3).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(3).Style.ForeColor = Color.White
                End If
                'FECHA DE NACIMIENTO
                If Trim(DgvT3.Item(4, i).Value) = "" Or IsDate(DgvT3.Item(4, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 4
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(4).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(4).Style.ForeColor = Color.White
                End If
                'SEXO
                If DgvT3.Item(5, i).Value <> "H" And DgvT3.Item(5, i).Value <> "M" And DgvT3.Item(5, i).Value <> "I" Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 5
                    objce_Te.Detalle = "El sexo debería ser H,M,I pero aparece " & DgvT3.Item(5, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(5).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(5).Style.ForeColor = Color.White
                End If
                'ETNIA
                If Val(DgvT3.Item(6, i).Value) <= 1 And Val(DgvT3.Item(6, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 6
                    objce_Te.Detalle = "La pertencia etnica debe ser un número entre 1 y 6, pero aparece " & DgvT3.Item(6, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(6).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If
                'PRIMER APELLIDO
                If Len(Trim(DgvT3.Item(7, i).Value)) < 1 And Len(DgvT3.Item(7, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 7
                    objce_Te.Detalle = "El primer apellido debe tener entre 1 y 60 carácteres"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(7).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(7).Style.ForeColor = Color.White
                End If
                'SEGUNDO APELLIDO
                If Len(DgvT3.Item(8, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 8
                    objce_Te.Detalle = "El segundo apellido debe tener máximo 60 carácteres"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(8).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(8).Style.ForeColor = Color.White
                End If
                'PRIMER NOMBRE
                If Len(Trim(DgvT3.Item(9, i).Value)) < 1 And Len(DgvT3.Item(9, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 9
                    objce_Te.Detalle = "El primer nombre debe tener entre 1 y 60 carácteres"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(9).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(9).Style.ForeColor = Color.White
                End If
                'SEGUNDO NOMBRE
                If Len(DgvT3.Item(10, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 10
                    objce_Te.Detalle = "El segundo nombre debe tener máximo 60 carácteres"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(10).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(10).Style.ForeColor = Color.White
                End If
                'FECHA DE ATENCION
                If Len(Trim(DgvT3.Item(11, i).Value)) > 0 And IsDate(DgvT3.Item(11, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 11
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT3.Item(11, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(11).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(11).Style.ForeColor = Color.White
                End If
                'FINALIDAD DE LA CONSULTA
                If DgvT3.Item(12, i).Value <> "04" Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser 04 pero aparece " & DgvT3.Item(12, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If

                If Len(DgvT3.Item(12, i).Value) <> 2 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser de 2 caracteres"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                'CODIGO DE CONSULTA
                If DgvT3.Item(13, i).Value <> "890201" And DgvT3.Item(13, i).Value <> "890205" And DgvT3.Item(13, i).Value <> "890301" And DgvT3.Item(13, i).Value <> "890305" Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 13
                    objce_Te.Detalle = "Debe ser 890201, 890301,890205,890305 pero aparece " & DgvT3.Item(13, i).Value
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(13).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(13).Style.ForeColor = Color.White
                End If
                'PESO EN KILOGRAMOS
                If EsDecimal(DgvT3.Item(14, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe ser un número decimal"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT3.Item(14, i).Value)) < 1 And Len(DgvT3.Item(14, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe tener 6 caracteres, 2 enteros y 3 decimales, incluir el punto decimal"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                'TALLA EN CENTIMETROS
                If Val(DgvT3.Item(15, i).Value) < 1 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "Debe ser un número entero mayor a cero"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT3.Item(15, i).Value)) > 3 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "La talla no puede tener mas de 3 digitos"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                'FECHA SUMINISTRO SULFATO FERROSO
                If Len(Trim(DgvT3.Item(16, i).Value)) > 0 And IsDate(DgvT3.Item(16, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 16
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(16).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(16).Style.ForeColor = Color.White
                End If
                'FECHA SUMINISTRO VITAMINA A
                If Len(Trim(DgvT3.Item(17, i).Value)) > 0 And IsDate(DgvT3.Item(17, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 17
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(17).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(17).Style.ForeColor = Color.White
                End If
                'FECHA SUMINISTRO MICRONUTRIENTES EN POLVO
                F1 = Len(Trim(DgvT3.Item(18, i).Value))
                If Len(Trim(DgvT3.Item(18, i).Value)) > 0 And IsDate(DgvT3.Item(18, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 18
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(18).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(18).Style.ForeColor = Color.White
                End If
                'FECHA TOMA HEMOGLOBINA
                If Len(Trim(DgvT3.Item(19, i).Value)) > 0 And IsDate(DgvT3.Item(19, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 19
                    objce_Te.Detalle = "Debe indicar una fecha válida"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(19).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(19).Style.ForeColor = Color.White
                End If
                'RESULTADO HEMOGLOBINA
                If Len(Trim(DgvT3.Item(20, i).Value)) > 0 And Len(Trim(DgvT3.Item(20, i).Value)) <> 4 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = 20
                    objce_Te.Detalle = "En gr-dl con 2 enteros y 1 decimal. Incluir el punto decimal (.) Valor mayor de cero."
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).Cells(20).Style.BackColor = Color.Red
                    DgvT3.Rows(i).Cells(20).Style.ForeColor = Color.White
                End If
                FN = CDate(DgvT3.Item(4, i).Value)
                FA = CDate(DgvT3.Item(11, i).Value)
                Años = CalcularEdad(FN.Day, FN.Month, FN.Year, FA.Day, FA.Month, FA.Year)
                If Años > 5 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = ""
                    objce_Te.Detalle = "LA EDAD DEBE ESTAR ENTRE 0 Y 5 AÑOS"
                    CT3 = CT3 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT3.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    DgvT3.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Validar_T4()
        Dim Años As Integer = 0
        Dim FN, FA As Date
        Dim c As Integer = DgvT4.Rows.Count
        If c > 0 Then
            Dim i As Integer = 1

            Do
                'TIPO DE REGISTRO
                If DgvT4.Item(0, i).Value <> "4" Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 1
                    objce_Te.Detalle = "El tipo deberia ser 4 y aparece " & DgvT4.Item(0, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(1).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(1).Style.ForeColor = Color.White
                End If
                'TIPO DE IDENTIFICACION
                If DgvT4.Item(2, i).Value <> "RC" And DgvT4.Item(2, i).Value <> "PA" And DgvT4.Item(2, i).Value <> "TI" Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 2
                    objce_Te.Detalle = "El tipo de documento deberia ser RC,TI ó PA y aparece " & DgvT4.Item(2, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(2).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(2).Style.ForeColor = Color.White
                End If
                'NUMERO DE DOCUMENTO
                If Trim(DgvT4.Item(3, i).Value) = "" Or Len(Trim(DgvT4.Item(3, i).Value)) > 18 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 3
                    objce_Te.Detalle = "El número de documento debe tener entre 1 y 17 digitos"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(3).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(3).Style.ForeColor = Color.White
                End If
                'FECHA DE NACIMIENTO
                If Trim(DgvT4.Item(4, i).Value) = "" Or IsDate(DgvT4.Item(4, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 4
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(4).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(4).Style.ForeColor = Color.White
                End If
                'SEXO
                If DgvT4.Item(5, i).Value <> "H" And DgvT4.Item(5, i).Value <> "M" Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 5
                    objce_Te.Detalle = "El sexo debería ser H,M pero aparece " & DgvT4.Item(5, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(5).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(5).Style.ForeColor = Color.White
                End If
                'ETNIA
                If Val(DgvT4.Item(6, i).Value) <= 1 And Val(DgvT4.Item(6, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 6
                    objce_Te.Detalle = "La pertencia etnica debe ser un número entre 1 y 6, pero aparece " & DgvT4.Item(6, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(6).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If
                'PRIMER APELLIDO
                If Len(Trim(DgvT4.Item(7, i).Value)) < 1 And Len(DgvT4.Item(7, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 7
                    objce_Te.Detalle = "El primer apellido debe tener entre 1 y 60 carácteres"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(7).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(7).Style.ForeColor = Color.White
                End If
                'SEGUNDO APELLIDO
                If Len(Trim(DgvT4.Item(8, i).Value)) > 60 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 8
                    objce_Te.Detalle = "El segundo apellido debe tener máximo 60 carácteres"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(8).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(8).Style.ForeColor = Color.White
                End If
                'PRIMER NOMBRE
                If Len(Trim(DgvT4.Item(9, i).Value)) < 1 And Len(DgvT4.Item(9, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 9
                    objce_Te.Detalle = "El primer nombre debe tener entre 1 y 60 carácteres"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(9).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(9).Style.ForeColor = Color.White
                End If
                'SEGUNDO NOMBRE
                If Len(Trim(DgvT4.Item(10, i).Value)) > 60 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 10
                    objce_Te.Detalle = "El segundo nombre debe tener máximo 60 carácteres"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(10).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(10).Style.ForeColor = Color.White
                End If
                'FECHA DE ATENCION
                If Len(Trim(DgvT4.Item(11, i).Value)) > 0 And IsDate(DgvT4.Item(11, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 11
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT4.Item(11, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(11).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(11).Style.ForeColor = Color.White
                End If
                'FINALIDAD DE LA CONSULTA
                If DgvT4.Item(12, i).Value <> "04" Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser 04 pero aparece " & DgvT4.Item(12, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT4.Item(12, i).Value)) <> 2 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser de 2 caracteres"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                'CODIGO DE CONSULTA
                If DgvT4.Item(13, i).Value <> "890201" And DgvT4.Item(13, i).Value <> "890205" And DgvT4.Item(13, i).Value <> "890301" And DgvT4.Item(13, i).Value <> "890305" Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 13
                    objce_Te.Detalle = "Debe ser 890201, 890301,890205,890305 pero aparece " & DgvT4.Item(13, i).Value
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(13).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(13).Style.ForeColor = Color.White
                End If
                'PESO EN KILOGRAMOS
                If EsDecimal(DgvT4.Item(14, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe ser un número decimal"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT4.Item(14, i).Value)) < 1 And Len(Trim(DgvT4.Item(14, i).Value)) > 6 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe tener 6 caracteres, 2 enteros y 3 decimales, incluir el punto decimal"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                'TALLA EN CENTIMETROS
                If Val(DgvT4.Item(15, i).Value) < 1 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "Debe ser un número entero mayor a cero"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT4.Item(15, i).Value)) > 3 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "La talla no puede tener mas de 3 digitos"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                'FECHA TOMA HEMOGLOBINA
                If Len(Trim(DgvT4.Item(16, i).Value)) > 0 And IsDate(DgvT4.Item(16, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 16
                    objce_Te.Detalle = "Debe indicar la fecha de la toma de la hemoglobina, o indicar una fecha válida"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(16).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(16).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT4.Item(17, i).Value)) > 0 And Len(Trim(DgvT4.Item(17, i).Value)) <> 4 Then
                    objce_Te.Tipo = "Tipo 4"
                    objce_Te.Fila = i
                    objce_Te.Col = 17
                    objce_Te.Detalle = "En gr-dl con 2 enteros y 1 decimal. Incluir el punto decimal (.) Valor mayor de cero."
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).Cells(17).Style.BackColor = Color.Red
                    DgvT4.Rows(i).Cells(17).Style.ForeColor = Color.White
                End If
                FN = CDate(DgvT3.Item(4, i).Value)
                FA = CDate(DgvT3.Item(11, i).Value)
                Años = CalcularEdad(FN.Day, FN.Month, FN.Year, FA.Day, FA.Month, FA.Year)
                If Años < 6 And Años > 11 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = ""
                    objce_Te.Detalle = "LA EDAD DEBE ESTAR ENTRE 6 Y 11 AÑOS"
                    CT4 = CT4 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT4.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    DgvT4.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Validar_T5()
        Dim Años As Integer = 0
        Dim FN, FA As Date
        Dim c As Integer = DgvT5.Rows.Count
        If c > 0 Then
            Dim i As Integer = 1

            Do
                'TIPO DE REGISTRO
                If DgvT5.Item(0, i).Value <> "5" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 1
                    objce_Te.Detalle = "El tipo deberia ser 5 y aparece " & DgvT5.Item(0, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(1).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(1).Style.ForeColor = Color.White
                End If
                'TIPO DE IDENTIFICACION
                If DgvT5.Item(2, i).Value <> "RC" And DgvT5.Item(2, i).Value <> "PA" And DgvT5.Item(2, i).Value <> "TI" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 2
                    objce_Te.Detalle = "El tipo de documento deberia ser RC,TI ó PA y aparece " & DgvT5.Item(2, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(2).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(2).Style.ForeColor = Color.White
                End If
                'NUMERO DE DOCUMENTO
                If Trim(DgvT5.Item(3, i).Value) = "" Or Len(Trim(DgvT5.Item(3, i).Value)) > 18 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 3
                    objce_Te.Detalle = "El número de documento debe tener entre 1 y 17 digitos"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(3).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(3).Style.ForeColor = Color.White
                End If
                'FECHA DE NACIMIENTO
                If Trim(DgvT5.Item(4, i).Value) = "" Or IsDate(DgvT5.Item(4, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 4
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(4).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(4).Style.ForeColor = Color.White
                End If
                'SEXO
                If DgvT5.Item(5, i).Value <> "H" And DgvT5.Item(5, i).Value <> "M" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 5
                    objce_Te.Detalle = "El sexo debería ser H,M pero aparece " & DgvT5.Item(5, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(5).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(5).Style.ForeColor = Color.White
                End If
                'ETNIA
                If Val(DgvT5.Item(6, i).Value) <= 1 And Val(DgvT5.Item(6, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 6
                    objce_Te.Detalle = "La pertencia etnica debe ser un número entre 1 y 6, pero aparece " & DgvT5.Item(6, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(6).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If
                'PRIMER APELLIDO
                If Len(Trim(DgvT5.Item(7, i).Value)) < 1 And Len(DgvT5.Item(7, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 7
                    objce_Te.Detalle = "El primer apellido debe tener entre 1 y 60 carácteres"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(7).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(7).Style.ForeColor = Color.White
                End If
                'SEGUNDO APELLIDO
                If Len(Trim(DgvT5.Item(8, i).Value)) > 60 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 8
                    objce_Te.Detalle = "El segundo apellido debe tener máximo 60 carácteres"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(8).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(8).Style.ForeColor = Color.White
                End If
                'PRIMER NOMBRE
                If Len(Trim(DgvT5.Item(9, i).Value)) < 1 And Len(DgvT5.Item(9, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 9
                    objce_Te.Detalle = "El primer nombre debe tener entre 1 y 60 carácteres"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(9).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(9).Style.ForeColor = Color.White
                End If
                'SEGUNDO NOMBRE
                If Len(Trim(DgvT5.Item(10, i).Value)) > 60 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 10
                    objce_Te.Detalle = "El segundo nombre debe tener máximo 60 carácteres"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(10).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(10).Style.ForeColor = Color.White
                End If
                'FECHA DE ATENCION
                If Len(Trim(DgvT5.Item(11, i).Value)) > 0 And IsDate(DgvT5.Item(11, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 11
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT5.Item(11, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(11).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(11).Style.ForeColor = Color.White
                End If
                'FINALIDAD DE LA CONSULTA
                If DgvT5.Item(12, i).Value <> "05" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser 04 pero aparece " & DgvT5.Item(12, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                If Len(DgvT5.Item(12, i).Value) <> 2 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser de 2 caracteres"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(13).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(13).Style.ForeColor = Color.White
                End If
                'CODIGO DE CONSULTA
                If DgvT5.Item(13, i).Value <> "890201" And DgvT5.Item(13, i).Value <> "890205" And DgvT5.Item(13, i).Value <> "890301" And DgvT5.Item(13, i).Value <> "890305" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 13
                    objce_Te.Detalle = "Debe ser 890201, 890301,890205,890305 pero aparece " & DgvT5.Item(13, i).Value
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(13).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(13).Style.ForeColor = Color.White
                End If
                'PESO EN KILOGRAMOS
                If EsDecimal(DgvT5.Item(14, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe ser un número decimal"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT5.Item(14, i).Value)) < 1 And Len(Trim(DgvT5.Item(14, i).Value)) > 6 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe tener 6 caracteres, 2 enteros y 3 decimales, incluir el punto decimal"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                'TALLA EN CENTIMETROS
                If Val(DgvT5.Item(15, i).Value) < 1 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "Debe ser un número entero mayor a cero"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT5.Item(15, i).Value)) > 3 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "La talla no puede tener mas de 3 digitos"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                'FECHA TOMA HEMOGLOBINA
                If Len(Trim(DgvT5.Item(16, i).Value)) > 0 And IsDate(DgvT5.Item(16, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 16
                    objce_Te.Detalle = "Debe indicar una fecha válida"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(16).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(16).Style.ForeColor = Color.White
                End If
                'RESULTADO HEMOGLOBINA
                If Len(Trim(DgvT5.Item(17, i).Value)) > 0 And Len(Trim(DgvT5.Item(17, i).Value)) <> 4 Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 17
                    objce_Te.Detalle = "En gr-dl con 2 enteros y 1 decimal. Incluir el punto decimal (.) Valor mayor de cero."
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).Cells(17).Style.BackColor = Color.Red
                    DgvT5.Rows(i).Cells(17).Style.ForeColor = Color.White
                End If
                FN = CDate(DgvT3.Item(4, i).Value)
                FA = CDate(DgvT3.Item(11, i).Value)
                Años = CalcularEdad(FN.Day, FN.Month, FN.Year, FA.Day, FA.Month, FA.Year)
                If Años < 12 And Años > 17 Then
                    objce_Te.Tipo = "Tipo 3"
                    objce_Te.Fila = i
                    objce_Te.Col = ""
                    objce_Te.Detalle = "LA EDAD DEBE ESTAR ENTRE 6 Y 11 AÑOS"
                    CT5 = CT5 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT5.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    DgvT5.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Validar_T6()
        Dim c As Integer = DgvT6.Rows.Count
        If c > 0 Then
            Dim i As Integer = 1

            Do
                'TIPO DE REGISTRO
                If DgvT6.Item(0, i).Value <> "6" Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 1
                    objce_Te.Detalle = "El tipo deberia ser 6 y aparece " & DgvT6.Item(0, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(1).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(1).Style.ForeColor = Color.White
                End If
                'TIPO DE IDENTIFICACION
                If DgvT6.Item(2, i).Value <> "RC" And DgvT6.Item(2, i).Value <> "PA" And DgvT6.Item(2, i).Value <> "TI" And DgvT6.Item(2, i).Value <> "CE" And DgvT6.Item(2, i).Value <> "CC" Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 2
                    objce_Te.Detalle = "El tipo de documento deberia ser RC,TI,CE,CC ó PA y aparece " & DgvT6.Item(2, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(2).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(2).Style.ForeColor = Color.White
                End If
                'NUMERO DE DOCUMENTO
                If Trim(DgvT6.Item(3, i).Value) = "" Or Len(Trim(DgvT6.Item(3, i).Value)) > 18 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 3
                    objce_Te.Detalle = "El número de documento debe tener entre 1 y 17 digitos"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(3).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(3).Style.ForeColor = Color.White
                End If
                'PRIMER APELLIDO
                If Len(Trim(DgvT6.Item(4, i).Value)) < 1 And Len(DgvT6.Item(4, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 4
                    objce_Te.Detalle = "El primer apellido debe tener entre 1 y 60 carácteres"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(4).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(4).Style.ForeColor = Color.White
                End If
                'SEGUNDO APELLIDO
                If Len(Trim(DgvT6.Item(5, i).Value)) > 60 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 5
                    objce_Te.Detalle = "El segundo apellido debe tener máximo 60 carácteres"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(5).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(5).Style.ForeColor = Color.White
                End If
                'PRIMER NOMBRE
                If Len(Trim(DgvT6.Item(6, i).Value)) < 1 And Len(DgvT6.Item(6, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 6
                    objce_Te.Detalle = "El primer nombre debe tener entre 1 y 60 carácteres"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(6).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If
                'SEGUNDO NOMBRE
                If Len(Trim(DgvT6.Item(7, i).Value)) > 60 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 7
                    objce_Te.Detalle = "El segundo nombre debe tener máximo 60 carácteres"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(7).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(7).Style.ForeColor = Color.White
                End If
                'FECHA DE NACIMIENTO
                If Trim(DgvT6.Item(8, i).Value) = "" Or IsDate(DgvT6.Item(8, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 8
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(8).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(8).Style.ForeColor = Color.White
                End If
                'EDAD GESTACIONAL
                If Len(Trim(DgvT6.Item(9, i).Value)) > 2 Or IsNumeric(DgvT6.Item(9, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 9
                    objce_Te.Detalle = "Debe ser un valor numerico ente 1 y 2 digitos"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(9).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(9).Style.ForeColor = Color.White
                End If
                'ETNIA
                If Val(DgvT6.Item(10, i).Value) <= 1 And Val(DgvT6.Item(10, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 10
                    objce_Te.Detalle = "La pertencia etnica debe ser un número entre 1 y 6, pero aparece " & DgvT6.Item(10, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(10).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(10).Style.ForeColor = Color.White
                End If
                'FECHA DE ATENCION
                If Len(Trim(DgvT6.Item(11, i).Value)) > 0 And IsDate(DgvT6.Item(11, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 11
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(11, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(11).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(11).Style.ForeColor = Color.White
                End If
                'FINALIDAD DE LA CONSULTA
                If DgvT6.Item(12, i).Value <> "06" Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser 04 pero aparece " & DgvT6.Item(12, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                If Len(Trim(DgvT6.Item(12, i).Value)) <> 2 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 12
                    objce_Te.Detalle = "Debe ser de 2 caracteres"
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(12).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(12).Style.ForeColor = Color.White
                End If
                'CODIGO DE CONSULTA
                If DgvT6.Item(13, i).Value <> "890201" And DgvT6.Item(13, i).Value <> "890203" And DgvT6.Item(13, i).Value <> "890301" And DgvT6.Item(13, i).Value <> "890305" And DgvT6.Item(13, i).Value <> "890303" And DgvT6.Item(13, i).Value <> "890206" And DgvT6.Item(13, i).Value <> "890306" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 13
                    objce_Te.Detalle = "Debe ser 890201, 890301,890203,890303,890305,890206,890306 pero aparece " & DgvT6.Item(13, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(13).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(13).Style.ForeColor = Color.White
                End If
                'FECHA 
                If Len(Trim(DgvT6.Item(14, i).Value)) > 0 And IsDate(DgvT6.Item(14, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 14
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(14, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(14).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(14).Style.ForeColor = Color.White
                End If
                'FECHA
                If Len(Trim(DgvT6.Item(15, i).Value)) > 0 And IsDate(DgvT6.Item(15, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(15, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                'FECHA
                If Len(Trim(DgvT6.Item(16, i).Value)) > 0 And IsDate(DgvT6.Item(16, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 16
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(16, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(16).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(16).Style.ForeColor = Color.White
                End If
                'FECHA 
                If Len(Trim(DgvT6.Item(17, i).Value)) > 0 And IsDate(DgvT6.Item(17, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 17
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(17, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(17).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(17).Style.ForeColor = Color.White
                End If
                If Trim(DgvT6.Item(18, i).Value) <> "" Then
                    If DgvT6.Item(18, i).Value <> 1 And DgvT6.Item(18, i).Value <> 2 Then
                        objce_Te.Tipo = "Tipo 6"
                        objce_Te.Fila = i
                        objce_Te.Col = 18
                        objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT6.Item(18, i).Value
                        CT6 = CT6 + 1
                        objCn_Te.NuevoError(objce_Te)
                        DgvT6.Rows(i).Cells(18).Style.BackColor = Color.Red
                        DgvT6.Rows(i).Cells(18).Style.ForeColor = Color.White
                    End If
                End If
                'FECHA TOMA SEROLOGIA 
                If Len(Trim(DgvT6.Item(19, i).Value)) > 0 And IsDate(DgvT6.Item(19, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 19
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(19, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(19).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(19).Style.ForeColor = Color.White
                End If
                'RESULTADO SEROLOGIA
                If Trim(DgvT6.Item(20, i).Value) <> "" Then
                    If DgvT6.Item(20, i).Value <> 1 And DgvT6.Item(20, i).Value <> 2 Then
                        objce_Te.Tipo = "Tipo 6"
                        objce_Te.Fila = i
                        objce_Te.Col = 20
                        objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT6.Item(20, i).Value
                        CT6 = CT6 + 1
                        objCn_Te.NuevoError(objce_Te)
                        DgvT6.Rows(i).Cells(20).Style.BackColor = Color.Red
                        DgvT6.Rows(i).Cells(20).Style.ForeColor = Color.White
                    End If
                End If
                'FECHA
                If Len(Trim(DgvT6.Item(21, i).Value)) > 0 And IsDate(DgvT6.Item(21, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 21
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(21, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(21).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(21).Style.ForeColor = Color.White
                End If
                'FECHA
                If Len(Trim(DgvT6.Item(22, i).Value)) > 0 And IsDate(DgvT6.Item(22, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 22
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(22, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(22).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(22).Style.ForeColor = Color.White
                End If
                'RESULTADO VIH
                If Trim(DgvT6.Item(23, i).Value) <> "" Then
                    If DgvT6.Item(23, i).Value <> 1 And DgvT6.Item(23, i).Value <> 2 Then
                        objce_Te.Tipo = "Tipo 6"
                        objce_Te.Fila = i
                        objce_Te.Col = 23
                        objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT6.Item(23, i).Value
                        CT6 = CT6 + 1
                        objCn_Te.NuevoError(objce_Te)
                        DgvT6.Rows(i).Cells(23).Style.BackColor = Color.Red
                        DgvT6.Rows(i).Cells(23).Style.ForeColor = Color.White
                    End If
                End If
                'FECHA TOMA HEMOGLOBINA
                If Len(Trim(DgvT6.Item(24, i).Value)) > 0 And IsDate(DgvT6.Item(24, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 24
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(24, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(24).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(24).Style.ForeColor = Color.White
                End If
                'RESULTADO HEMOGLOBINA
                If Len(Trim(DgvT6.Item(25, i).Value)) > 0 And Len(Trim(DgvT6.Item(25, i).Value)) <> 4 Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 25
                    objce_Te.Detalle = "En gr-dl con 2 enteros y 1 decimal. Incluir el punto decimal (.) Valor mayor de cero."
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(25).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(25).Style.ForeColor = Color.White
                End If
                'FECHA CPNSEGERIA LACTANCIA MATERNA
                If Len(Trim(DgvT6.Item(26, i).Value)) > 0 And IsDate(DgvT6.Item(26, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 6"
                    objce_Te.Fila = i
                    objce_Te.Col = 26
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT6.Item(26, i).Value
                    CT6 = CT6 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT6.Rows(i).Cells(26).Style.BackColor = Color.Red
                    DgvT6.Rows(i).Cells(26).Style.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnSubir_Click(sender As Object, e As EventArgs) Handles BtnSubir.Click
        If CT > 0 Then
            MsgBox("Debe Solucionar los errores primero", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Frm_Message.Show()
            Timer1.Start()
            Subir_T2()
            Subir_T3()
            Subir_T4()
            Subir_T5()
            Subir_T6()
            Subir_T7()
            Timer1.Stop()
            Frm_Message.Close()
            BtnPlano.Enabled = True
        End If
    End Sub

    Private Sub Validar_T7()
        Dim c As Integer = DgvT7.Rows.Count
        If c > 0 Then
            Dim i As Integer = 1

            Do
                'TIPO DE REGISTRO
                If DgvT7.Item(0, i).Value <> "7" Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 1
                    objce_Te.Detalle = "El tipo deberia ser 7 y aparece " & DgvT7.Item(0, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(1).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(1).Style.ForeColor = Color.White
                End If
                'TIPO DE IDENTIFICACION
                If DgvT7.Item(2, i).Value <> "RC" And DgvT7.Item(2, i).Value <> "PA" And DgvT7.Item(2, i).Value <> "TI" And DgvT7.Item(2, i).Value <> "CE" And DgvT7.Item(2, i).Value <> "CC" Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 2
                    objce_Te.Detalle = "El tipo de documento deberia ser RC,TI,CE,CC ó PA y aparece " & DgvT7.Item(2, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(2).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(2).Style.ForeColor = Color.White
                End If
                'NUMERO DE DOCUMENTO
                If Trim(DgvT7.Item(3, i).Value) = "" Or Len(Trim(DgvT7.Item(3, i).Value)) > 18 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 3
                    objce_Te.Detalle = "El número de documento debe tener entre 1 y 17 digitos"
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(3).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(3).Style.ForeColor = Color.White
                End If
                'PRIMER APELLIDO
                If Len(Trim(DgvT7.Item(4, i).Value)) < 1 And Len(DgvT7.Item(4, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 4
                    objce_Te.Detalle = "El primer apellido debe tener entre 1 y 60 carácteres"
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(4).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(4).Style.ForeColor = Color.White
                End If
                'SEGUNDO APELLIDO
                If Len(DgvT7.Item(5, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 5
                    objce_Te.Detalle = "El segundo apellido debe tener máximo 60 carácteres"
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(5).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(5).Style.ForeColor = Color.White
                End If
                'PRIMER NOMBRE
                If Len(Trim(DgvT7.Item(6, i).Value)) < 1 And Len(DgvT7.Item(6, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 6
                    objce_Te.Detalle = "El primer nombre debe tener entre 1 y 60 carácteres"
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(6).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(6).Style.ForeColor = Color.White
                End If
                'SEGUNDO NOMBRE
                If Len(DgvT7.Item(7, i).Value) > 60 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 7
                    objce_Te.Detalle = "El segundo nombre debe tener máximo 60 carácteres"
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(7).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(7).Style.ForeColor = Color.White
                End If
                'ETNIA
                If Val(DgvT7.Item(8, i).Value) <= 1 And Val(DgvT7.Item(8, i).Value) > 6 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 8
                    objce_Te.Detalle = "La pertencia etnica debe ser un número entre 1 y 6, pero aparece " & DgvT7.Item(8, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(8).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(8).Style.ForeColor = Color.White
                End If
                'FECHA DE ATENCION PARTO
                If Trim(DgvT7.Item(9, i).Value) = "" Or IsDate(DgvT7.Item(9, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 9
                    objce_Te.Detalle = "Debe ser una fecha válida"
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(9).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(9).Style.ForeColor = Color.White
                End If
                'FINALIDAD DE LA CONSULTA
                If DgvT7.Item(10, i).Value <> "01" Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 10
                    objce_Te.Detalle = "Debe ser 04 pero aparece " & DgvT7.Item(10, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(10).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(10).Style.ForeColor = Color.White
                End If
                'CODIGO DE CONSULTA
                If DgvT7.Item(11, i).Value <> "735300" And DgvT7.Item(11, i).Value <> "735910" And DgvT7.Item(11, i).Value <> "740100" Then
                    objce_Te.Tipo = "Tipo 5"
                    objce_Te.Fila = i
                    objce_Te.Col = 11
                    objce_Te.Detalle = "Debe ser 735300,735910,740100 pero aparece " & DgvT7.Item(13, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(11).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(11).Style.ForeColor = Color.White
                End If
                'TOMA DE PRUEBA RAPIDA PARA SIFILIS
                If Trim(DgvT7.Item(12, i).Value) <> "" Then
                    If DgvT7.Item(12, i).Value <> 1 And DgvT7.Item(12, i).Value <> 2 Then
                        objce_Te.Tipo = "Tipo 7"
                        objce_Te.Fila = i
                        objce_Te.Col = 12
                        objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT7.Item(12, i).Value
                        CT7 = CT7 + 1
                        objCn_Te.NuevoError(objce_Te)
                        DgvT7.Rows(i).Cells(12).Style.BackColor = Color.Red
                        DgvT7.Rows(i).Cells(12).Style.ForeColor = Color.White
                    End If
                End If
                'FECHA TOMA RAPIDA PARA SIFILIS
                If Len(Trim(DgvT7.Item(13, i).Value)) > 0 And IsDate(DgvT7.Item(13, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 13
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT7.Item(13, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(13).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(13).Style.ForeColor = Color.White
                End If
                'RESULTADA SEROLOGIA
                If Trim(DgvT7.Item(14, i).Value) <> "" Then
                    If DgvT7.Item(14, i).Value <> 1 And DgvT7.Item(14, i).Value <> 2 Then
                        objce_Te.Tipo = "Tipo 7"
                        objce_Te.Fila = i
                        objce_Te.Col = 14
                        objce_Te.Detalle = "Debe ser un valor entre 1:REACTIVA 2:NO REACTIVA, pero aparece " & DgvT7.Item(14, i).Value
                        CT7 = CT7 + 1
                        objCn_Te.NuevoError(objce_Te)
                        DgvT7.Rows(i).Cells(14).Style.BackColor = Color.Red
                        DgvT7.Rows(i).Cells(14).Style.ForeColor = Color.White
                    End If
                End If
                'ASESORIA PARA VIH
                If DgvT7.Item(15, i).Value <> 1 And DgvT7.Item(15, i).Value <> 2 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 15
                    objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT7.Item(15, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(15).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(15).Style.ForeColor = Color.White
                End If
                'FECHA ASESORIA PRE TEST VIH 
                If Len(Trim(DgvT7.Item(16, i).Value)) > 0 And IsDate(DgvT7.Item(16, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 16
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT7.Item(16, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(16).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(16).Style.ForeColor = Color.White
                End If
                'TOMA DE PRUEBA RAPIDA VIH
                If DgvT7.Item(17, i).Value <> 1 And DgvT7.Item(17, i).Value <> 2 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 17
                    objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT7.Item(17, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(17).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(17).Style.ForeColor = Color.White
                End If
                'FECHA TOMA PRUEBA RAPIDA VIH
                If Len(Trim(DgvT7.Item(18, i).Value)) > 0 And IsDate(DgvT7.Item(18, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 18
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT7.Item(18, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(18).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(18).Style.ForeColor = Color.White
                End If
                'RESULTADO PRUABA RAPIDA VIH
                If Trim(DgvT7.Item(19, i).Value) <> "" Then
                    If DgvT7.Item(19, i).Value <> 1 And DgvT7.Item(19, i).Value <> 2 Then
                        objce_Te.Tipo = "Tipo 7"
                        objce_Te.Fila = i
                        objce_Te.Col = 19
                        objce_Te.Detalle = "Debe ser un valor entre 1:POSITIVO 2:NEGATIVA, pero aparece " & DgvT7.Item(19, i).Value
                        CT7 = CT7 + 1
                        objCn_Te.NuevoError(objce_Te)
                        DgvT7.Rows(i).Cells(19).Style.BackColor = Color.Red
                        DgvT7.Rows(i).Cells(19).Style.ForeColor = Color.White
                    End If
                End If
                If DgvT7.Item(20, i).Value <> 1 And DgvT7.Item(20, i).Value <> 2 Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 20
                    objce_Te.Detalle = "Debe ser un valor entre 1:SI 2:NO, pero aparece " & DgvT7.Item(20, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(20).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(20).Style.ForeColor = Color.White
                End If
                'FECHA
                If Len(Trim(DgvT7.Item(21, i).Value)) > 0 And IsDate(DgvT7.Item(21, i).Value) = False Then
                    objce_Te.Tipo = "Tipo 7"
                    objce_Te.Fila = i
                    objce_Te.Col = 21
                    objce_Te.Detalle = "Debe ser una fecha válida pero aparece " & DgvT7.Item(21, i).Value
                    CT7 = CT7 + 1
                    objCn_Te.NuevoError(objce_Te)
                    DgvT7.Rows(i).Cells(21).Style.BackColor = Color.Red
                    DgvT7.Rows(i).Cells(21).Style.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        CT = 0
        CT2 = 0
        CT3 = 0
        CT4 = 0
        CT5 = 0
        CT6 = 0
        CT7 = 0
        If DgvT2.Rows.Count > 0 Then
            Frm_Message.Show()
            Frm_Message.Label1.Text = "Validando..."
            'FormatosTipo2()
            'FormatosTipo3()
            'FormatosTipo4()
            'FormatosTipo5()
            'FormatosTipo6()
            'FormatosTipo7()

            Validar_T2()
            Validar_T3()
            Validar_T4()
            Validar_T5()
            Validar_T6()
            Validar_T7()
            Timer1.Stop()
            CT = CT2 + CT3 + CT4 + CT5 + CT6 + CT7
            If CT < 1 Then
                BtnSubir.Enabled = True
                LbTotal.Visible = False
            Else
                BtnSubir.Enabled = False
                LbTotal.Visible = True
                LbTotal.Text = "Se encontraron " & CT & " errores"
            End If
            Frm_Message.Hide()
        End If
    End Sub

    Private Function EsDecimal(variable) As Boolean
        Dim L As Integer = Len(variable)
        Dim C As String = ""
        Dim R As Integer = 0
        If L > 0 Then
            Dim i As Integer = 1
            Do
                C = Mid(variable, i, 1)
                If C = "," Or C = "." Then
                    R = R + 1
                End If
                i = i + 1
            Loop Until i = L
        End If
        If R > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            AutosizaSI()
        Else
            AutosizaNO()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Frm_Message.BringToFront()
    End Sub

    Private Sub LbTotal_Click(sender As Object, e As EventArgs) Handles LbTotal.Click
        If CT > 0 Then
            Frm_2175_Errores.Lb2.Text = "Errores Registro Tipo 2: " & CT2
            Frm_2175_Errores.Lb3.Text = "Errores Registro Tipo 3: " & CT3
            Frm_2175_Errores.Lb4.Text = "Errores Registro Tipo 4: " & CT4
            Frm_2175_Errores.Lb5.Text = "Errores Registro Tipo 5: " & CT5
            Frm_2175_Errores.Lb6.Text = "Errores Registro Tipo 6: " & CT6
            Frm_2175_Errores.Lb7.Text = "Errores Registro Tipo 7: " & CT7
            Frm_2175_Errores.LbTotal.Text = "TOTAL ERRORES:: " & CT
            Frm_2175_Errores.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvT2.ColumnCount
            worksheet.Cells(1, i) = Me.DgvT2.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvT2.Rows.Count - 1
            For j As Integer = 0 To Me.DgvT2.Columns.Count - 1
                If Me.DgvT2.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvT2.Rows(I).Cells(j).Value.ToString()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvT3.ColumnCount
            worksheet.Cells(1, i) = Me.DgvT3.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvT3.Rows.Count - 1
            For j As Integer = 0 To Me.DgvT3.Columns.Count - 1
                If Me.DgvT3.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvT3.Rows(I).Cells(j).Value.ToString()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvT4.ColumnCount
            worksheet.Cells(1, i) = Me.DgvT4.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvT4.Rows.Count - 1
            For j As Integer = 0 To Me.DgvT4.Columns.Count - 1
                If Me.DgvT4.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvT4.Rows(I).Cells(j).Value.ToString()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvT5.ColumnCount
            worksheet.Cells(1, i) = Me.DgvT5.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvT5.Rows.Count - 1
            For j As Integer = 0 To Me.DgvT5.Columns.Count - 1
                If Me.DgvT5.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvT5.Rows(I).Cells(j).Value.ToString()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvT6.ColumnCount
            worksheet.Cells(1, i) = Me.DgvT6.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvT6.Rows.Count - 1
            For j As Integer = 0 To Me.DgvT6.Columns.Count - 1
                If Me.DgvT6.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvT6.Rows(I).Cells(j).Value.ToString()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'ACA SE AGREGAN LAS CABECERAS DE NUESTRO DATAGRID

        For i As Integer = 1 To DgvT7.ColumnCount
            worksheet.Cells(1, i) = Me.DgvT7.Columns(i - 1).HeaderText
        Next
        'ACA SE INGRESA EL DETALLE RECORRA LA TABLA CELDA POR CELDA
        For I As Integer = 0 To Me.DgvT7.Rows.Count - 1
            For j As Integer = 0 To Me.DgvT7.Columns.Count - 1
                If Me.DgvT7.Rows(I).Cells(j).Value Is Nothing Then
                    worksheet.Cells(I + 2, j + 1) = "0"
                Else
                    worksheet.Cells(I + 2, j + 1) = Me.DgvT7.Rows(I).Cells(j).Value.ToString()
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

    Private Sub Subir_T2()
        Dim c As Integer = DgvT2.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                Try
                    objCe_T2.C0 = DgvT2.Item(0, i).Value
                    objCe_T2.C1 = DgvT2.Item(1, i).Value
                    objCe_T2.C2 = DgvT2.Item(2, i).Value
                    objCe_T2.C3 = DgvT2.Item(3, i).Value
                    objCe_T2.C4 = DgvT2.Item(4, i).Value
                    objCe_T2.C5 = DgvT2.Item(5, i).Value
                    objCe_T2.C6 = DgvT2.Item(6, i).Value
                    objCe_T2.C7 = DgvT2.Item(7, i).Value
                    objCe_T2.C8 = DgvT2.Item(8, i).Value
                    objCe_T2.C9 = DgvT2.Item(9, i).Value
                    objCe_T2.C10 = DgvT2.Item(10, i).Value
                    objCe_T2.C11 = DgvT2.Item(11, i).Value
                    objCe_T2.C12 = DgvT2.Item(12, i).Value
                    objCe_T2.Sede = Val(CbSede.SelectedValue.ToString)
                    objCn_T2.NuevoT2(objCe_T2)
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Subir_T3()
        Dim c As Integer = DgvT3.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                Try
                    objCe_T3.C0 = DgvT3.Item(0, i).Value
                    objCe_T3.C1 = DgvT3.Item(1, i).Value
                    objCe_T3.C2 = DgvT3.Item(2, i).Value
                    objCe_T3.C3 = DgvT3.Item(3, i).Value
                    objCe_T3.C4 = DgvT3.Item(4, i).Value
                    objCe_T3.C5 = DgvT3.Item(5, i).Value
                    objCe_T3.C6 = DgvT3.Item(6, i).Value
                    objCe_T3.C7 = DgvT3.Item(7, i).Value
                    objCe_T3.C8 = DgvT3.Item(8, i).Value
                    objCe_T3.C9 = DgvT3.Item(9, i).Value
                    objCe_T3.C10 = DgvT3.Item(10, i).Value
                    objCe_T3.C11 = DgvT3.Item(11, i).Value
                    objCe_T3.C12 = DgvT3.Item(12, i).Value
                    objCe_T3.C13 = DgvT3.Item(13, i).Value
                    objCe_T3.C14 = DgvT3.Item(14, i).Value
                    objCe_T3.C15 = DgvT3.Item(15, i).Value
                    objCe_T3.C16 = DgvT3.Item(16, i).Value
                    objCe_T3.C17 = DgvT3.Item(17, i).Value
                    objCe_T3.C18 = DgvT3.Item(18, i).Value
                    objCe_T3.C19 = DgvT3.Item(19, i).Value
                    objCe_T3.C20 = DgvT3.Item(20, i).Value
                    objCe_T3.Sede = Val(CbSede.SelectedValue.ToString)
                    objCn_T3.NuevoT3(objCe_T3)
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Subir_T4()
        Dim c As Integer = DgvT4.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                Try
                    objCe_T4.C0 = DgvT4.Item(0, i).Value
                    objCe_T4.C1 = DgvT4.Item(1, i).Value
                    objCe_T4.C2 = DgvT4.Item(2, i).Value
                    objCe_T4.C3 = DgvT4.Item(3, i).Value
                    objCe_T4.C4 = DgvT4.Item(4, i).Value
                    objCe_T4.C5 = DgvT4.Item(5, i).Value
                    objCe_T4.C6 = DgvT4.Item(6, i).Value
                    objCe_T4.C7 = DgvT4.Item(7, i).Value
                    objCe_T4.C8 = DgvT4.Item(8, i).Value
                    objCe_T4.C9 = DgvT4.Item(9, i).Value
                    objCe_T4.C10 = DgvT4.Item(10, i).Value
                    objCe_T4.C11 = DgvT4.Item(11, i).Value
                    objCe_T4.C12 = DgvT4.Item(12, i).Value
                    objCe_T4.C13 = DgvT4.Item(13, i).Value
                    objCe_T4.C14 = DgvT4.Item(14, i).Value
                    objCe_T4.C15 = DgvT4.Item(15, i).Value
                    objCe_T4.C16 = DgvT4.Item(16, i).Value
                    objCe_T4.C17 = DgvT4.Item(17, i).Value
                    objCe_T4.Sede = Val(CbSede.SelectedValue.ToString)
                    objCn_T4.NuevoT4(objCe_T4)
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Subir_T5()
        Dim c As Integer = DgvT5.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                Try
                    objCe_T5.C0 = DgvT5.Item(0, i).Value
                    objCe_T5.C1 = DgvT5.Item(1, i).Value
                    objCe_T5.C2 = DgvT5.Item(2, i).Value
                    objCe_T5.C3 = DgvT5.Item(3, i).Value
                    objCe_T5.C4 = DgvT5.Item(4, i).Value
                    objCe_T5.C5 = DgvT5.Item(5, i).Value
                    objCe_T5.C6 = DgvT5.Item(6, i).Value
                    objCe_T5.C7 = DgvT5.Item(7, i).Value
                    objCe_T5.C8 = DgvT5.Item(8, i).Value
                    objCe_T5.C9 = DgvT5.Item(9, i).Value
                    objCe_T5.C10 = DgvT5.Item(10, i).Value
                    objCe_T5.C11 = DgvT5.Item(11, i).Value
                    objCe_T5.C12 = DgvT5.Item(12, i).Value
                    objCe_T5.C13 = DgvT5.Item(13, i).Value
                    objCe_T5.C14 = DgvT5.Item(14, i).Value
                    objCe_T5.C15 = DgvT5.Item(15, i).Value
                    objCe_T5.C16 = DgvT5.Item(16, i).Value
                    objCe_T5.C17 = DgvT5.Item(17, i).Value
                    objCe_T5.Sede = Val(CbSede.SelectedValue.ToString)
                    objCn_T5.NuevoT5(objCe_T5)
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Subir_T6()
        Dim c As Integer = DgvT6.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                Try
                    objCe_T6.C0 = DgvT6.Item(0, i).Value
                    objCe_T6.C1 = DgvT6.Item(1, i).Value
                    objCe_T6.C2 = DgvT6.Item(2, i).Value
                    objCe_T6.C3 = DgvT6.Item(3, i).Value
                    objCe_T6.C4 = DgvT6.Item(4, i).Value
                    objCe_T6.C5 = DgvT6.Item(5, i).Value
                    objCe_T6.C6 = DgvT6.Item(6, i).Value
                    objCe_T6.C7 = DgvT6.Item(7, i).Value
                    objCe_T6.C8 = DgvT6.Item(8, i).Value
                    objCe_T6.C9 = DgvT6.Item(9, i).Value
                    objCe_T6.C10 = DgvT6.Item(10, i).Value
                    objCe_T6.C11 = DgvT6.Item(11, i).Value
                    objCe_T6.C12 = DgvT6.Item(12, i).Value
                    objCe_T6.C13 = DgvT6.Item(13, i).Value
                    objCe_T6.C14 = DgvT6.Item(14, i).Value
                    objCe_T6.C15 = DgvT6.Item(15, i).Value
                    objCe_T6.C16 = DgvT6.Item(16, i).Value
                    objCe_T6.C17 = DgvT6.Item(17, i).Value
                    objCe_T6.C18 = DgvT6.Item(18, i).Value
                    objCe_T6.C19 = DgvT6.Item(19, i).Value
                    objCe_T6.C20 = DgvT6.Item(20, i).Value
                    objCe_T6.C21 = DgvT6.Item(21, i).Value
                    objCe_T6.C22 = DgvT6.Item(22, i).Value
                    objCe_T6.C23 = DgvT6.Item(23, i).Value
                    objCe_T6.C24 = DgvT6.Item(24, i).Value
                    objCe_T6.C25 = DgvT6.Item(25, i).Value
                    objCe_T6.C26 = DgvT6.Item(26, i).Value
                    objCe_T6.Sede = Val(CbSede.SelectedValue.ToString)
                    objCn_T6.NuevoT6(objCe_T6)
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Subir_T7()
        Dim c As Integer = DgvT7.Rows.Count
        If c > 1 Then
            Dim i As Integer = 1
            Do
                Try
                    objCe_T7.C0 = DgvT7.Item(0, i).Value
                    objCe_T7.C1 = DgvT7.Item(1, i).Value
                    objCe_T7.C2 = DgvT7.Item(2, i).Value
                    objCe_T7.C3 = DgvT7.Item(3, i).Value
                    objCe_T7.C4 = DgvT7.Item(4, i).Value
                    objCe_T7.C5 = DgvT7.Item(5, i).Value
                    objCe_T7.C6 = DgvT7.Item(6, i).Value
                    objCe_T7.C7 = DgvT7.Item(7, i).Value
                    objCe_T7.C8 = DgvT7.Item(8, i).Value
                    objCe_T7.C9 = DgvT7.Item(9, i).Value
                    objCe_T7.C10 = DgvT7.Item(10, i).Value
                    objCe_T7.C11 = DgvT7.Item(11, i).Value
                    objCe_T7.C12 = DgvT7.Item(12, i).Value
                    objCe_T7.C13 = DgvT7.Item(13, i).Value
                    objCe_T7.C14 = DgvT7.Item(14, i).Value
                    objCe_T7.C15 = DgvT7.Item(15, i).Value
                    objCe_T7.C16 = DgvT7.Item(16, i).Value
                    objCe_T7.C17 = DgvT7.Item(17, i).Value
                    objCe_T7.C18 = DgvT7.Item(18, i).Value
                    objCe_T7.C19 = DgvT7.Item(19, i).Value
                    objCe_T7.C20 = DgvT7.Item(20, i).Value
                    objCe_T7.C21 = DgvT7.Item(21, i).Value
                    objCe_T7.Sede = Val(CbSede.SelectedValue.ToString)
                    objCn_T7.Nuevo_T7(objCe_T7)
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub
End Class