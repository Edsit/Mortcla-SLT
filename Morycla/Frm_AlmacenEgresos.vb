Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_AlmacenEgresos
    Dim Cargo, Resp As String
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCn_Ts As New Cn_Alm_TipoSalida
    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCn_P As New Cn_Alm_Productos
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCe_Rf As New Ce_RFecha

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
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

    Private Sub ListarTipoSalida()
        Dim ds As New DataSet
        CbTipo.DataSource = Nothing
        CbTipo.Items.Clear()
        Try
            ds = objCn_Ts.ListarTipoSalidaActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTipo.DataSource = ds.Tables(0)
                CbTipo.DisplayMember = "Tipo"
                CbTipo.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Frm_AlmacenEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        LoadMesActivo()
        ListarTipoProd()
        ListarTipoSalida()
        RadioButton1.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DtDesde.Enabled = False
        DtHasta.Enabled = False
        TbBMes.Enabled = False
        TbBAño.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DtDesde.Enabled = True
        DtHasta.Enabled = True
        TbBMes.Enabled = False
        TbBAño.Enabled = False
        DtDesde.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DtDesde.Enabled = False
        DtHasta.Enabled = False
        TbBMes.Enabled = True
        TbBAño.Enabled = True
        TbBAño.Text = Now.Date.Year
        TbBMes.Focus()
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        If RadioButton1.Checked = True Then
            LoadEgresosMesActivo()
        End If
        If RadioButton2.Checked = True Then
            LoadEgresosFecha()
        End If
        If RadioButton3.Checked = True Then
            LoadEgresosMes()
        End If
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Sub LoadEgresosMesActivo()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_S.Mes = Val(TbConsMes.Text)
            objCe_S.Año = Val(TbAño.Text)
            objCe_S.TProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_S.EgresosMesActivo(objCe_S)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv.Item(6, i).Value = FormatCurrency(ds.Tables(0).Rows(i).Item(3))
                    Dgv.Item(7, i).Value = Val(Dgv.Item(5, i).Value) * CDbl(Dgv.Item(6, i).Value)

                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            LoadDatosProd()
            LoadDatosLotes()
        End Try
    End Sub

    Sub LoadEgresosMes()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_S.Mes = Val(TbBMes.Text)
            objCe_S.Año = Val(TbBAño.Text)
            objCe_S.TProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_S.EgresosMesActivo(objCe_S)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv.Item(6, i).Value = FormatCurrency(ds.Tables(0).Rows(i).Item(3))
                    Dgv.Item(7, i).Value = Val(Dgv.Item(5, i).Value) * CDbl(Dgv.Item(6, i).Value)

                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            LoadDatosProd()
            LoadDatosLotes()
        End Try
    End Sub

    Sub LoadEgresosFecha()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_Rf.Desde = DtDesde.Value.Date
            objCe_Rf.Hasta = DtHasta.Value.Date
            objCe_S.TProd = Val(CbTProd.SelectedValue.ToString)
            ds = objCn_S.EgresosFecha(objCe_S, objCe_Rf)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv.Item(6, i).Value = FormatCurrency(ds.Tables(0).Rows(i).Item(3))
                    Dgv.Item(7, i).Value = Val(Dgv.Item(5, i).Value) * CDbl(Dgv.Item(6, i).Value)

                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            LoadDatosProd()
            LoadDatosLotes()
        End Try
    End Sub

    Sub LoadDatosProd()
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_P.Cons = Val(Dgv.Item(3, i).Value)
                    ds = objCn_P.LoadDatosProd(objCe_P)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dgv.Item(3, i).Value = ds.Tables(0).Rows(0).Item(1) & " " & ds.Tables(0).Rows(0).Item(4) & " " & ds.Tables(0).Rows(0).Item(2)
                        Dgv.Item(4, i).Value = ds.Tables(0).Rows(0).Item(5)
                    End If
                Catch ex As Exception

                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadDatosLotes()
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_L.Cons = Val(Dgv.Item(0, i).Value)
                    ds = objCn_L.ListarDatosLotes(objCe_L)
                    If ds.Tables(0).Rows.Count > 0 Then

                        Dgv.Item(0, i).Value = ds.Tables(0).Rows(0).Item(4)
                        Dgv.Item(1, i).Value = ds.Tables(0).Rows(0).Item(5)
                        Dgv.Item(2, i).Value = Format(ds.Tables(0).Rows(0).Item(6), "MM/yyyy")
                        If IsDBNull(ds.Tables(0).Rows(0).Item(11)) = False Then
                            Dgv.Item(8, i).Value = ds.Tables(0).Rows(0).Item(11)
                        End If
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim c = Dgv.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        If c > 0 Then
            Dim m_Excel As New Excel.Application
            'm_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim Ruta As String = Application.StartupPath & "\Plantillas\FormatoEgresos.xlsx"
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("Medicamentos")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 16
                Dim Tot As Double = 0
                Do

                    .Cells(f, 2) = Dgv.Item(0, i).Value
                    .Cells(f, 3) = Dgv.Item(1, i).Value
                    .Cells(f, 4) = Dgv.Item(2, i).Value
                    .Cells(f, 5) = Dgv.Item(3, i).Value
                    .Cells(f, 6) = Dgv.Item(4, i).Value
                    .Cells(f, 7) = Dgv.Item(5, i).Value
                    .Cells(f, 8) = CDbl(Dgv.Item(6, i).Value)
                    .Cells(f, 9) = CDbl(Dgv.Item(7, i).Value)
                    If IsDBNull((Dgv.Item(8, i).Value)) = False Then
                        .Cells(f, 10) = Dgv.Item(8, i).Value
                    End If

                    Tot = Tot + CDbl(Dgv.Item(7, i).Value)
                    f = f + 1
                    i = i + 1
                Loop Until i = c

                .Range(.Cells(f, 2), .Cells(f, 8)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                .Cells(f, 2) = "TOTAL"

                .Cells(f, 9) = Tot
                f = f + 1
                .Cells(f, 2) = "OBSERVACIONES:"
                .Range(.Cells(f, 2), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 2) = "FIRMAS DE APROBACION"
                .Range(.Cells(f, 2), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Range(.Cells(16, 2), .Cells(f, 9)).Borders.LineStyle = 1

                .Range("C6").Value = DtDesde.Value.Date & " AL " & DtHasta.Value.Date
                .Range("F6").Value = "Municipio: " '& Mun
                .Range("B7").Value = FrmModulos.LbSede.Text
                .Range("B13").Value = "TIPO DE INSUMO: MEDICAMENTOS (" & UCase(CbTipo.Text) & ")"
                .Range("D10").Value = "KARDEX DE MEDICAMENTOS " & Format(DtDesde.Value.Date, "MMM/yyyy")

                f = f + 1

                Dim FI As String = "B" & f

                .Cells(f, 2) = "ELABORÓ"
                .Range(.Cells(f, 2), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 5) = "ALMACEN"
                .Range(.Cells(f, 5), .Cells(f, 7)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 8) = "DIRECTOR/COORDINADOR DE SEDE"
                .Range(.Cells(f, 8), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 2) = "NOMBRE: " '& FrmModulos.LbFuncionario.Text
                .Range(.Cells(f, 2), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 7) = "NOMBRE: " & 'Almacenista
                .Range(.Cells(f, 5), .Cells(f, 7)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 8) = "NOMBRE: " &' Director
                .Range(.Cells(f, 8), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 2) = "Proceso/Subproceso: FARMACIA"
                .Range(.Cells(f, 2), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 5) = "Proceso/Subproceso: ALMACEN"
                .Range(.Cells(f, 5), .Cells(f, 7)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 8) = ""
                .Range(.Cells(f, 8), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 2) = "FIRMA"
                .Range(.Cells(f, 2), .Cells(f, 4)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 5) = "FIRMA"
                .Range(.Cells(f, 5), .Cells(f, 7)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 8) = "FIRMA"
                .Range(.Cells(f, 8), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                'm_Excel.Rows(f).RowHeight = 40

                Dim CI As String = "I" & f
                Dim C2 As String = "G" & f
                Dim C3 As String = "D" & f

                .Range(FI & ":" & C2).BorderAround()
                .Range(FI & ":" & C3).BorderAround()
                .Range(FI & ":" & CI).BorderAround()

                '.Range(.Cells(1, 1),
                '       .Cells(f, f)).Borders.LineStyle = 1
            End With
        End If
    End Sub
End Class