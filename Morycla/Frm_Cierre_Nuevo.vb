Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_Cierre_Nuevo
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCn_P As New Cn_Alm_Productos
    Dim objCe_Me As New Ce_MesEstado
    Dim objCn_Me As New Cn_MesEstado

    Sub LoadMesActivo()
        Dim ds As New DataSet
        Try
            ds = objCn_Me.LoadMesActivo
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

    Private Sub Frm_Cierre_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        LoadMesActivo()
        TbNuevoAño.Text = Now.Year
        If Now.Year = Val(TbAño.Text.Trim) Then
            TbNuevoConsMes.Text = (TbConsMes.Text.Trim) + 1
        Else
            TbNuevoConsMes.Text = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarLotesNuevoCierre()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            ds = objCn_L.ListarLotesNuevoCierre(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                ProgressBar1.Maximum = c + 1
                Dim i As Integer = 0
                ProgressBar1.Minimum = i
                ProgressBar1.Value = 1
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
                    Dgv.Item(15, i).Value = ds.Tables(0).Rows(i).Item(15)
                    i = i + 1
                    LbProgreso.Text = "Procesando Lotes " & i & " de " & c
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    Application.DoEvents()
                Loop Until i = c
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
            MsgBox("Error al listar los lotes existentes" & ex.Message)
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarEntradasNuevoCierre()
        Dim ds As DataSet
        Dim Entrada As Integer = 0
        Dim Unitario As Double = 0
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            ProgressBar1.Minimum = i
            ProgressBar1.Maximum = c + 1
            ProgressBar1.Value = 1
            Do
                Entrada = 0
                Unitario = 0
                Try
                    objCe_E.Lote = Dgv.Item(0, i).Value
                    ds = New DataSet
                    ds = objCn_E.ListarEntradaNuevoCierre(objCe_E)
                    Dim c1 As Integer = ds.Tables(0).Rows.Count
                    If c1 > 0 Then
                        Dim i1 As Integer = 0
                        Do
                            If IsDBNull(ds.Tables(0).Rows(i1).Item(6)) = False Then
                                Entrada = Entrada + ds.Tables(0).Rows(i1).Item(6)
                            End If
                            If IsDBNull(ds.Tables(0).Rows(i1).Item(7)) = False Then
                                Unitario = Unitario + ds.Tables(0).Rows(i1).Item(7)
                            End If
                            i1 = i1 + 1
                            Application.DoEvents()
                        Loop Until i1 = c1
                        Dgv.Item(16, i).Value = Entrada
                        Dgv.Item(17, i).Value = Unitario
                    Else
                        Dgv.Item(16, i).Value = 0
                        Dgv.Item(17, i).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox("Error al listar las estradas del lote " & Dgv.Item(0, i).Value)
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
                LbProgreso.Text = "Procesando Entradas " & i & " de " & c
                ProgressBar1.Value = ProgressBar1.Value + 1
                Application.DoEvents()
            Loop Until i = c
        End If
    End Sub

    Private Sub ListarSalidasNuevoCierre()
        Dim ds As DataSet
        Dim Salidas As Integer = 0
        Dim Unitario As Double = 0
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            ProgressBar1.Minimum = i
            ProgressBar1.Maximum = c + 1
            ProgressBar1.Value = 1
            Do
                Salidas = 0
                Unitario = 0
                Try
                    objCe_S.Lote = Dgv.Item(0, i).Value
                    ds = New DataSet
                    ds = objCn_S.ListarSalidasNuevoCierre(objCe_S)
                    Dim c1 As Integer = ds.Tables(0).Rows.Count
                    If c1 > 0 Then
                        Dim i1 As Integer = 0
                        Do
                            If IsDBNull(ds.Tables(0).Rows(i1).Item(6)) = False Then
                                Salidas = Salidas + ds.Tables(0).Rows(i1).Item(6)
                                'If IsDBNull(ds.Tables(0).Rows(i1).Item(7)) = False Then
                                '    Unitario = Unitario + CDbl(ds.Tables(0).Rows(i1).Item(7))
                                'Else
                                '    Unitario = Unitario + 0
                                'End If



                            End If
                            i1 = i1 + 1
                            Application.DoEvents()
                        Loop Until i1 = c1
                        Dgv.Item(18, i).Value = Salidas
                        If Val(Dgv.Item(17, i).Value) > 0 Then
                            Dgv.Item(19, i).Value = Dgv.Item(17, i).Value
                        ElseIf Val(Dgv.Item(8, i).Value) > 0 Then
                            Dgv.Item(19, i).Value = Dgv.Item(8, i).Value
                        Else
                            Dgv.Item(19, i).Value = 0
                        End If
                        'Dgv.Item(19, i).Value = Unitario / c1
                    Else
                        Dgv.Item(18, i).Value = 0
                        'Dgv.Item(19, i).Value = 0
                        If Val(Dgv.Item(17, i).Value) > 0 Then
                            Dgv.Item(19, i).Value = Dgv.Item(17, i).Value
                        ElseIf Val(Dgv.Item(8, i).Value) > 0 Then
                            Dgv.Item(19, i).Value = Dgv.Item(8, i).Value
                        Else
                            Dgv.Item(19, i).Value = 0
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Error al listar las salidas del lote " & Dgv.Item(0, i).Value)
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
                Application.DoEvents()
                LbProgreso.Text = "Procesando Salidas " & i & " de " & c
                ProgressBar1.Value = ProgressBar1.Value + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Totalizar()
        Dim c As Integer = Dgv.Rows.Count
        Dim Saldo As Integer = 0
        Dim Unitario As Double = 0
        If c > 0 Then
            Dim i As Integer = 0
            ProgressBar1.Minimum = i
            ProgressBar1.Maximum = c + 1
            ProgressBar1.Value = 0
            Do
                Dgv.Item(20, i).Value = (Val(Dgv.Item(7, i).Value) + Val(Dgv.Item(16, i).Value)) - Val(Dgv.Item(18, i).Value)
                Dgv.Item(21, i).Value = Dgv.Item(19, i).Value
                i = i + 1
                LbProgreso.Text = "Procesando Saldos " & i & " de " & c
                ProgressBar1.Value = ProgressBar1.Value + 1
                Application.DoEvents()
            Loop Until i = c
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListarLotesNuevoCierre()
        ListarEntradasNuevoCierre()
        ListarSalidasNuevoCierre()
        Totalizar()
        MsgBox("Los datos Actuales se han cargado", MsgBoxStyle.Information)
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

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        If Val(TbConsMes.Text.Trim) = Val(TbNuevoConsMes.Text.Trim) And TbAño.Text.Trim = TbNuevoAño.Text.Trim Then
            MsgBox("El nuevo periodo no puede ser igual al periodo activo", MsgBoxStyle.Critical)
            TbNuevoConsMes.Focus()
            Exit Sub
        End If

        If Val(TbNuevoConsMes.Text.Trim) < Val(TbConsMes.Text.Trim) And Val(TbNuevoAño.Text.Trim) = Val(TbAño.Text.Trim) Or Val(TbNuevoAño.Text.Trim) < Val(TbAño.Text.Trim) Then
            MsgBox("Error en el nuevo periodo", MsgBoxStyle.Critical)
            TbNuevoConsMes.Focus()
            Exit Sub
        End If
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            ProgressBar1.Minimum = i
            ProgressBar1.Maximum = c + 1
            ProgressBar1.Value = 1
            Do
                If Val(Dgv.Item(20, i).Value) > 0 Then
                    Try
                        If IsDBNull(Val(Dgv.Item(1, i).Value)) = False Then
                            objCe_L.Prod = Val(Dgv.Item(1, i).Value)
                        End If
                        If IsDBNull(Dgv.Item(2, i).Value) = False Then
                            objCe_L.Cum = Dgv.Item(2, i).Value
                        End If
                        If IsDBNull(Val(Dgv.Item(3, i).Value)) = False Then
                            objCe_L.Lab = Val(Dgv.Item(3, i).Value)
                        End If
                        If IsDBNull(Dgv.Item(4, i).Value) = False Then
                            objCe_L.Lote = Dgv.Item(4, i).Value
                        End If
                        If IsDBNull(Dgv.Item(5, i).Value) = False Then
                            objCe_L.Invima = Dgv.Item(5, i).Value
                        End If
                        If IsDBNull(Dgv.Item(6, i).Value) = False Then
                            objCe_L.Vence = Dgv.Item(6, i).Value
                        End If
                        If IsDBNull(Val(Dgv.Item(20, i).Value)) = False Then
                            objCe_L.Ini = Val(Dgv.Item(20, i).Value)
                        End If
                        If IsDBNull(Dgv.Item(21, i).Value) = False Then
                            objCe_L.Unitario = CDbl(Dgv.Item(21, i).Value)
                        End If
                        If IsDBNull(Dgv.Item(9, i).Value) = False Then
                            objCe_L.Serial = Dgv.Item(9, i).Value
                        End If
                        If IsDBNull(Dgv.Item(10, i).Value) = False Then
                            objCe_L.VUtil = Dgv.Item(10, i).Value
                        End If
                        If IsDBNull(Dgv.Item(11, i).Value) = False Then
                            objCe_L.Obs = Dgv.Item(11, i).Value
                        End If
                        If IsDBNull(Val(Dgv.Item(12, i).Value)) = False Then
                            objCe_L.Mes = Val(TbNuevoConsMes.Text.Trim)
                        End If
                        If IsDBNull(Val(Dgv.Item(13, i).Value)) = False Then
                            objCe_L.Año = Val(TbNuevoAño.Text.Trim)
                        End If
                        If IsDBNull(Val(Dgv.Item(14, i).Value)) = False Then
                            objCe_L.Entrada = Val(Dgv.Item(14, i).Value)
                        End If
                        If IsDBNull(Val(Dgv.Item(15, i).Value)) = False Then
                            objCe_L.Almacen = Val(Dgv.Item(15, i).Value)
                        End If
                        objCn_L.NuevoLote(objCe_L)
                    Catch ex As Exception
                        MsgBox("Error al registrar el lote " & Dgv.Item(0, i).Value & " Almacen: " & Dgv.Item(15, i).Value)
                    End Try
                End If
                i = i + 1
                LbProgreso.Text = "Procesando Lote " & i & " de " & c
                ProgressBar1.Value = ProgressBar1.Value + 1
                Application.DoEvents()
            Loop Until i = c
        End If
        CerrarMesActual()
        NuevoMesActivo()
    End Sub

    Private Sub CerrarMesActual()
        Try
            objCe_Me.Mes = Val(TbConsMes.Text.Trim)
            objCe_Me.Año = Val(TbAño.Text.Trim)
            objCn_Me.EditMesActivo(objCe_Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NuevoMesActivo()
        Try
            objCe_Me.Mes = Val(TbNuevoConsMes.Text.Trim)
            objCe_Me.Año = Val(TbNuevoAño.Text.Trim)
            objCe_Me.Estado = "ACTIVO"
            objCn_Me.NuevoMesActivo(objCe_Me)
        Catch ex As Exception
        End Try
    End Sub
End Class