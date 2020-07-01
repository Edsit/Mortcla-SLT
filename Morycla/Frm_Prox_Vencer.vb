Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_Prox_Vencer
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCn_P As New Cn_Alm_Productos
    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCn_Sem As New Cn_Alm_Semaforo

    Private Sub Frm_Prox_Vencer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvMed.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvMed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        LoadMesActivo()
        ListarAlmacenes()
        ListarTipoProd()
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

    Private Sub ListarAlmacenes()
        Dim ds As New DataSet
        CbAlmacenes.DataSource = Nothing
        CbAlmacenes.Items.Clear()
        Try
            objCe_AF.Func = Val(ConsFunc)
            ds = objCn_A.ListarAlmacenesActivosFunc(objCe_AF)
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlmacenes.DataSource = ds.Tables(0)
                CbAlmacenes.DisplayMember = "Nombre"
                CbAlmacenes.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
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
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            objCe_L.Almacen = Val(CbAlmacenes.SelectedValue.ToString)
            ds = objCn_L.ListarLotesMedKardex(objCe_L, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Dim i1 As Integer = 0
                DgvMed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Do
                    If Semaforizar(ds.Tables(0).Rows(i).Item(5)) = True Then
                        DgvMed.Rows.Add()
                        DgvMed.Item(0, i1).Value = ds.Tables(0).Rows(i).Item(9)
                        DgvMed.Item(1, i1).Value = ds.Tables(0).Rows(i).Item(2)
                        DgvMed.Item(2, i1).Value = ds.Tables(0).Rows(i).Item(3)
                        DgvMed.Item(3, i1).Value = ds.Tables(0).Rows(i).Item(4)
                        DgvMed.Item(4, i1).Value = Format(ds.Tables(0).Rows(i).Item(5), "MMM-yyyy")
                        DgvMed.Item(5, i1).Value = ds.Tables(0).Rows(i).Item(6)
                        DgvMed.Item(6, i1).Value = ds.Tables(0).Rows(i).Item(0)
                        i1 = i1 + 1
                    End If
                    i = i + 1
                Loop Until i = c
                DgvMed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If DgvMed.Rows.Count > 0 Then
                LoadEntradas()
                LoadSalidas()
                LoadDatosMed()
            End If
        End Try
    End Sub

    Sub LoadDatosMed()
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim ds As New DataSet
            Dim i As Integer = 0
            Do
                objCe_P.Cons = Val(DgvMed.Item(0, i).Value)
                ds = objCn_P.LitarProductosCons(objCe_P)
                If ds.Tables(0).Rows.Count > 0 Then
                    If CbTProd.Text.Trim = "MEDICAMENTOS" Then
                        DgvMed.Item(0, i).Value = ds.Tables(0).Rows(0).Item("Descripcion") & " " & ds.Tables(0).Rows(0).Item("Forma") & " " & ds.Tables(0).Rows(0).Item("Concentracion")
                    Else
                        DgvMed.Item(0, i).Value = ds.Tables(0).Rows(0).Item("Descripcion") '& " " & ds.Tables(0).Rows(0).Item("Forma") & " " & ds.Tables(0).Rows(0).Item("Concentracion")
                    End If

                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadEntradas()
        Dim ds As DataSet
        Dim Cant As Integer = 0
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Cant = 0
                Try
                    ds = New DataSet
                    objCe_L.Mes = Val(TbConsMes.Text.Trim)
                    objCe_L.Año = Val(TbAño.Text.Trim)
                    objCe_E.Lote = Val(DgvMed.Item(6, i).Value)
                    ds = objCn_E.ContarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Cant = ds.Tables(0).Rows(0).Item(0)
                    Else
                        Cant = 0
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                DgvMed.Item(5, i).Value = Val(DgvMed.Item(5, i).Value) + Cant
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadSalidas()
        Dim ds As DataSet
        Dim Cant As Integer = 0
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Cant = 0
                Try
                    ds = New DataSet
                    objCe_S.Mes = Val(TbConsMes.Text.Trim)
                    objCe_S.Año = Val(TbAño.Text.Trim)
                    objCe_S.Lote = Val(DgvMed.Item(6, i).Value)
                    ds = objCn_S.ContarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Cant = ds.Tables(0).Rows(0).Item(0)
                    Else
                        Cant = 0
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                DgvMed.Item(5, i).Value = Val(DgvMed.Item(5, i).Value) - Cant
                i = i + 1
            Loop Until i = c
        End If
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

    Function Semaforizar(x) As Boolean
        Dim numero As Integer, i As Integer
        Dim FECHAD, FECHITA As String
        i = 0
        Dim Cf As String, DA As String
        LoadSemaforo()
        Do
            DA = Now.Day
            FECHAD = x
            If Len(Trim(FECHAD)) = 9 Then
                FECHITA = "0" & FECHAD
            Else
                FECHITA = FECHAD
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
                Return True
            Else
                Return False
            End If
            i = i + 1
        Loop Until i = DgvMed.RowCount
    End Function

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        DgvMed.DataSource = Nothing
        LoadMedLotesKardex()
        EliminarFilasEnCero()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c = DgvMed.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        Dim m_Excel As New Excel.Application
        'm_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim Ruta As String = Application.StartupPath & "\Plantillas\FormatoProxVencer.xlsx"
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
        If c > 0 Then
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("MEDICAMENTOS")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible

                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 7
                Dim Tot As Double = 0
                Do

                    .Range(.Cells(f, 1), .Cells(f, 2)).Select()
                    m_Excel.Selection.Merge()
                    .Cells(f, 1) = DgvMed.Item(0, i).Value
                    .Cells(f, 3) = DgvMed.Item(1, i).Value
                    .Cells(f, 4) = DgvMed.Item(2, i).Value
                    .Cells(f, 5) = DgvMed.Item(3, i).Value
                    .Cells(f, 6) = CDate(DgvMed.Item(4, i).Value)
                    .Cells(f, 7) = DgvMed.Item(5, i).Value
                    f = f + 1
                    i = i + 1
                Loop Until i = c
                f = f - 1
                .Range(.Cells(7, 1), .Cells(f, 7)).Borders.LineStyle = 1
                .Range("A4").Value = "Fecha: " & Now.Date
                .Range("C4").Value = "Sede: " & FrmModulos.LbSede.Text
                .Range("A5").Value = "Responsable del S. Farmaceutico: " '& AuxFarmacia
            End With
        End If
    End Sub

    Sub EliminarFilasEnCero()
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            For Each Fila As DataGridViewRow In DgvMed.Rows
                If Fila.Cells(5).Value = 0 Then
                    DgvMed.Rows.Remove(Fila)
                End If
            Next
        End If
    End Sub
End Class