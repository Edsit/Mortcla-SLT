Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmAlmacen_Recepcion_Tecnica
    Dim Resp, Cargo As String
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc
    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCn_Pr As New Cn_Proveedores
    Dim objCe_E As New Ce_Entradas
    Dim objCn_E As New Cn_ENtradas
    Dim objCe_C As New Ce_Consecutivos
    Dim objCn_C As New Cn_Consecutivos
    Dim objCe_Ae As New Ce_Alm_Entradas
    Dim objCn_Ae As New Cn_Alm_Entradas
    Private Sub FrmAlmacen_Recepcion_Tecnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarAlmacenes()
    End Sub

    Private Sub VerResponsable()
        Dim ds As New DataSet
        Resp = "" : Cargo = ""
        Try
            objCe_A.Cons = Val(CbAlmacenes.SelectedValue.ToString)
            ds = objCn_A.VerResponsable(objCe_A)
            If ds.Tables(0).Rows.Count > 0 Then
                Resp = ds.Tables(0).Rows(0).Item(0)
                Cargo = ds.Tables(0).Rows(0).Item(1)
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

    Private Sub ListarEntradasCons()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_Ae.Entrada = Val(TbCons.Text.Trim)
            ds = objCn_Ae.ListarEntradasCons(objCe_Ae)
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BEntrada = 2
        Frm_BuscarEntrada.ShowDialog()
        ListarEntradasCons()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        If CheckBox1.Checked = True Then
            Dim c = Dgv.Rows.Count
            Dim numero As Integer = 0
            Dim temp As String = ""
            If c > 0 Then
                VerdatosDestino()
                Dim m_Excel As New Excel.Application
                'm_Excel.Cursor = Excel.XlMousePointer.xlWait
                m_Excel.Visible = True
                Dim Ruta As String = Application.StartupPath & "\Plantillas\Formato_Entrada.xlsx"
                Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
                Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("Formato de entrada")
                With objHojaExcel
                    .Visible = Excel.XlSheetVisibility.xlSheetVisible
                    .Activate()
                    Dim i As Integer = 0
                    Dim f As Integer = 12
                    Dim Tot As Double = 0
                    Do

                        .Cells(f, 1) = i + 1
                        .Cells(f, 2) = Dgv.Item(8, i).Value
                        .Cells(f, 3) = Dgv.Item(0, i).Value
                        If IsDBNull(Dgv.Item(1, i).Value) = False Then
                            .Cells(f, 3) = Dgv.Item(0, i).Value & " " & Dgv.Item(2, i).Value
                        End If
                        .Cells(f, 4) = Dgv.Item(1, i).Value
                        .Cells(f, 5) = Dgv.Item(3, i).Value
                        .Cells(f, 6) = Dgv.Item(4, i).Value
                        .Cells(f, 7) = Dgv.Item(6, i).Value
                        .Cells(f, 8) = Dgv.Item(5, i).Value
                        .Cells(f, 9) = Dgv.Item(9, i).Value
                        .Cells(f, 10) = CDbl(Dgv.Item(8, i).Value) * CDbl(Dgv.Item(9, i).Value)
                        Tot = Tot + (CDbl(Dgv.Item(8, i).Value) * CDbl(Dgv.Item(9, i).Value))
                        f = f + 1
                        i = i + 1
                    Loop Until i = c

                    .Range(.Cells(f, 1), .Cells(f, 9)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True
                    .Cells(f, 1) = "VR.TOTAL"
                    .Cells(f, 10) = Tot
                    f = f + 1
                    .Cells(f, 1) = "OBSERVACIONES: "
                    .Range(.Cells(f, 1), .Cells(f, 10)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    f = f + 1
                    .Cells(f, 1) = "ENTREGA:"
                    .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True
                    m_Excel.Rows(f).RowHeight = 40

                    .Cells(f, 4) = "SUPERVISA:"
                    .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True
                    m_Excel.Rows(f).RowHeight = 40

                    .Cells(f, 7) = "RECIBE:"
                    .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True
                    m_Excel.Rows(f).RowHeight = 40

                    f = f + 1
                    .Cells(f, 1) = LbResponsable.Text.Trim   'REPONSABLE ALMACEN ORIGEN
                    .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    .Cells(f, 4) = "" ' NOMBRE DEL SUPERVISOR
                    .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    .Cells(f, 7) = ""  'Representante Legal
                    .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True
                    f = f + 1
                    .Cells(f, 1) = LbCargo.Text.Trim  'CARGO REPONSABLE ALMACEN ORIGEN
                    .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    .Cells(f, 4) = "SUPERVISOR"
                    .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    .Cells(f, 7) = "REPRESENTANTE LEGAL"  'CARGO REPONSABLE ALMACEN DESTINO
                    .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True
                    f = f + 1
                    .Cells(f, 1) = "ESE MORENO Y CLAVIJO"
                    .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    .Cells(f, 4) = "ESE MORENO Y CLAVIJO"
                    .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True

                    .Cells(f, 7) = "ESE MORENO Y CLAVIJO"
                    .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                    m_Excel.Selection.Merge()
                    m_Excel.Selection.Font.Bold = True


                    .Range(.Cells(11, 1), .Cells(f, 10)).Borders.LineStyle = 1

                    .Range("J7").Value = TbCons.Text  '& NUMERO DE SALIDA
                    .Range("A8").Value = "CENTRO ASISTENCIAL: " & UCase(LbSede.Text.Trim)
                    .Range("E7").Value = "FECHA: " & TbFecha.Text
                    .Range("H8").Value = TbSoporte.Text.Trim
                    f = f + 1
                End With
            End If
        Else
            Dim c = Dgv.Rows.Count
            Dim numero As Integer = 0
            Dim temp As String = ""
            VerResponsable()
            If c > 0 Then

                Dim m_Excel As New Excel.Application
                'm_Excel.Cursor = Excel.XlMousePointer.xlWait
                m_Excel.Visible = True
                Dim Ruta As String = Application.StartupPath & "\Plantillas\RecepcionTecnica.xlsx"
                Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
                Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("formato")
                With objHojaExcel
                    .Visible = Excel.XlSheetVisibility.xlSheetVisible
                    .Activate()
                    Dim i As Integer = 0
                    Dim f As Integer = 8
                    Do
                        numero = 0 : temp = ""
                        .Cells(f, 1) = Dgv.Item(0, i).Value
                        .Cells(f, 2) = Dgv.Item(1, i).Value
                        .Cells(f, 3) = Dgv.Item(2, i).Value
                        .Cells(f, 4) = Dgv.Item(3, i).Value
                        .Cells(f, 5) = Dgv.Item(4, i).Value
                        '---------Cargar el Semaforo--------------------------------
                        temp = Dgv.Item(6, i).Value
                        ' If strColumna = "F" Then
                        numero = DateDiff(DateInterval.Month, Now, CDate(temp))
                        numero = numero + 1
                        If numero > 0 And numero <= Rojo Then
                            .Range(.Cells(f, 7), .Cells(f, 7)).Select()
                            m_Excel.Selection.Interior.color = Color.Red
                            m_Excel.Selection.Font.Color = Color.White
                        End If
                        If numero >= (Rojo + 1) And numero <= Amarillo Then
                            .Range(.Cells(f, 7), .Cells(f, 7)).Select()
                            m_Excel.Selection.Interior.color = Color.Yellow
                            m_Excel.Selection.Font.Color = Color.Black
                        End If
                        If numero > Amarillo Then
                            .Range(.Cells(f, 7), .Cells(f, 7)).Select()
                            m_Excel.Selection.Interior.color = Color.Green
                            m_Excel.Selection.Font.Color = Color.White
                        End If
                        If numero <= 0 Then
                            .Range(.Cells(f, 7), .Cells(f, 7)).Select()
                            m_Excel.Selection.Interior.color = Color.White
                            m_Excel.Selection.Font.Color = Color.Black
                        End If
                        '------------------------------------------------------------
                        .Cells(f, 6) = Dgv.Item(5, i).Value
                        .Cells(f, 7) = Dgv.Item(6, i).Value
                        .Cells(f, 8) = (Dgv.Item(7, i).Value)

                        .Cells(f, 9) = Val(Dgv.Item(8, i).Value)
                        .Cells(f, 10) = CDbl(Dgv.Item(9, i).Value)
                        .Cells(f, 11) = CDbl(Dgv.Item(8, i).Value) * CDbl(Dgv.Item(9, i).Value)
                        f = f + 1
                        i = i + 1
                    Loop Until i = c
                    .Range("A5").Value = Cargo & ": " & Resp
                    .Range("B4").Value = FrmModulos.LbSede.Text
                    .Range("A4").Value = "FECHA: " & TbFecha.Text
                    .Cells(f, 1) = "OBSERVACIONES:"
                    .Range(.Cells(f, 1), .Cells(f, 11)).Select()
                    m_Excel.Selection.Merge()
                    ' m_Excel.Selection.Font.Bold = True
                    f = f + 1
                    .Cells(f, 1) = "NOMBRE: " & Resp
                    .Range(.Cells(f, 1), .Cells(f, 2)).Select()
                    m_Excel.Selection.Merge()
                    ' m_Excel.Selection.Font.Bold = True
                    .Cells(f, 3) = "FIRMA"
                    .Range(.Cells(f, 3), .Cells(f, 6)).Select()
                    m_Excel.Selection.Merge()
                    ' m_Excel.Selection.Font.Bold = True
                    .Cells(f, 7) = "CARGO: " & "AUXILIAR DE FARMACIA"
                    .Range(.Cells(f, 7), .Cells(f, 11)).Select()
                    m_Excel.Selection.Merge()
                    'm_Excel.Selection.Font.Bold = True
                    m_Excel.Rows(f).RowHeight = 40

                    .Range(.Cells(8, 1), .Cells(f, 11)).Borders.LineStyle = 1
                End With
            End If
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub VerdatosDestino()
        Dim ds As New DataSet
        LbResponsable.Text = ""
        LbSede.Text = ""
        LbCargo.Text = ""
        Try
            objCe_A.Cons = Val(CbAlmacenes.SelectedValue.ToString)
            ds = objCn_A.VerDatosTraslado(objCe_A)
            If ds.Tables(0).Rows.Count > 0 Then
                LbSede.Text = ds.Tables(0).Rows(0).Item(0)
                LbResponsable.Text = ds.Tables(0).Rows(0).Item(1)
                LbCargo.Text = ds.Tables(0).Rows(0).Item(2)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub
End Class