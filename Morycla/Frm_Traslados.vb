Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Frm_Traslados
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCe_AF As New Ce_AlmacenFunc
    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCe_C As New Ce_Consecutivos
    Dim objCn_C As New Cn_Consecutivos
    Dim objCe_T As New Ce_Traslados
    Dim objCn_T As New Cn_Traslados
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas

    Private Sub Botones1()
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = False
        BtnExportar.Enabled = True
    End Sub

    Private Sub Botones2()
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        BtnExportar.Enabled = False
    End Sub

    Private Sub Habilitar()
        DtFecha.Enabled = True
        CbAlmOrigen.Enabled = True
        CbAlmDestino.Enabled = True
        CbTProd.Enabled = True
        BtnExportar.Enabled = False
    End Sub

    Private Sub Inhabilitar()
        DtFecha.Enabled = False
        CbAlmOrigen.Enabled = False
        CbAlmDestino.Enabled = False
        CbTProd.Enabled = False
        BtnExportar.Enabled = True
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        CbAlmDestino.Text = ""
        CbAlmOrigen.Text = ""
        DtFecha.Value = Now
        CbTProd.Text = ""
        LbResponsable.Text = ""
        LbSede.Text = ""
        LbCargo.Text = ""
        LbCarg.Text = ""
        LbResp.Text = ""
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

    Private Sub ListarAlmacenesOrigen()
        Dim ds As New DataSet
        CbAlmOrigen.DataSource = Nothing
        CbAlmOrigen.Items.Clear()
        Try
            objCe_AF.Func = Val(ConsFunc)
            ds = objCn_A.ListarAlmacenesActivosFunc(objCe_AF)
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlmOrigen.DataSource = ds.Tables(0)
                CbAlmOrigen.DisplayMember = "Nombre"
                CbAlmOrigen.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarAlmacenesDestino()
        Dim ds As New DataSet
        CbAlmDestino.DataSource = Nothing
        CbAlmDestino.Items.Clear()
        Try
            objCe_AF.Func = Val(ConsFunc)
            ds = objCn_A.ListarAlmacenesActivos()
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlmDestino.DataSource = ds.Tables(0)
                CbAlmDestino.DisplayMember = "ALMACEN"
                CbAlmDestino.ValueMember = "Cons"
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

    Private Sub Frm_Traslados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        DtFecha.Value = Now
        LbResponsable.Text = ""
        LbSede.Text = ""
        LbCargo.Text = ""
        ListarAlmacenesDestino()
        ListarAlmacenesOrigen()
        ListarTipoProd()
        LoadMesActivo()
        Botones1()
        Inhabilitar()
        Limpiar()
    End Sub

    Private Sub BtnAddProductos_Click(sender As Object, e As EventArgs) Handles BtnAddProductos.Click
        If Val(TbCons.Text.Trim) < 0 Or TbCons.Text.Trim = "" Then
            MsgBox("Debe seleccionar el traslado", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If UCase(CbAlmOrigen.Text.Trim) = UCase(CbAlmDestino.Text.Trim) Or Val(CbAlmOrigen.SelectedValue.ToString) = Val(CbAlmDestino.SelectedValue.ToString()) Then
            MsgBox("El almacán de destino debe ser diferente al almacén de origen", MsgBoxStyle.Critical)
            CbAlmDestino.Focus()
            Exit Sub
        End If
        Frm_Alm_Salidas.LbAlmacen.Text = Val(CbAlmOrigen.SelectedValue.ToString)
        Frm_Alm_Salidas.LbNombreAlmacen.Text = UCase(CbAlmOrigen.Text.Trim)
        Frm_Alm_Salidas.LbTProd.Text = Val(CbTProd.SelectedValue.ToString)
        Frm_Alm_Salidas.LbTipoProd.Text = UCase(CbTProd.Text.Trim)
        Frm_Alm_Salidas.LbTraslado.Text = Val(TbCons.Text.Trim)
        Sal = 2
        Frm_Alm_Salidas.ShowDialog()
        ListarTraslado()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Val(CbAlmOrigen.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar un almacén origen válido", MsgBoxStyle.Critical)
            CbAlmOrigen.Focus()
            Exit Sub
        End If
        If Val(CbAlmDestino.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar un almacén destino válido", MsgBoxStyle.Critical)
            CbAlmDestino.Focus()
            Exit Sub
        End If
        If IsDBNull(CbTProd.SelectedValue.ToString) = True Then
            MsgBox("Debe seleccionar un tipo de producto válido", MsgBoxStyle.Critical)
            CbTProd.Focus()
            Exit Sub
        End If
        If Val(CbTProd.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar un tipo de producto válido", MsgBoxStyle.Critical)
            CbTProd.Focus()
            Exit Sub
        End If
        VerConsecutivo()
        Try
            objCe_T.Cons = Val(TbCons.Text.Trim)
            objCe_T.Fecha = DtFecha.Value.Date
            objCe_T.Alm_Origen = Val(CbAlmOrigen.SelectedValue.ToString)
            objCe_T.Alm_Destino = Val(CbAlmDestino.SelectedValue.ToString)
            objCe_T.Obs = UCase(TbObs.Text.Trim)
            objCe_T.TipoProd = Val(CbTProd.SelectedValue.ToString)
            objCn_T.NuevoTraslado(objCe_T)
            ActualizarConsecutivo()
            TbEstado.Text = "REGISTRADO"
            Botones1()
            Inhabilitar()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub VerConsecutivo()
        Dim ds As New DataSet
        Try
            ds = objCn_C.VerConsTraslados
            If ds.Tables(0).Rows.Count > 0 Then
                TbCons.Text = ds.Tables(0).Rows(0).Item(0) + 1
            Else
                TbCons.Text = 1
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ActualizarConsecutivo()
        Try
            objCe_C.Traslados = Val(TbCons.Text.Trim)
            objCn_C.ActualizarConsTraslados(objCe_C)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Tras = 1
        Frm_BuscarTraslados.ShowDialog()
        ListarTraslado()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        If Val(CbTProd.SelectedValue.ToString) > 2 Then
            ExportarAlmacen()
        Else
            ExportarFarmacia()
        End If
    End Sub

    Private Sub ExportarAlmacen()
        Dim c = Dgv.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        If c > 0 Then
            VerdatosOrigen()
            VerdatosDestino()
            Dim m_Excel As New Excel.Application
            'm_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim Ruta As String = Application.StartupPath & "\Plantillas\Formato_Salida.xlsx"
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("Formato de entrada y salida")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 11
                Dim Tot As Double = 0
                Do

                    .Cells(f, 1) = i + 1
                    .Cells(f, 2) = Dgv.Item(10, i).Value
                    .Cells(f, 3) = Dgv.Item(1, i).Value
                    If IsDBNull(Dgv.Item(2, i).Value) = False Then
                        .Cells(f, 3) = Dgv.Item(1, i).Value & " " & Dgv.Item(2, i).Value
                    End If
                    .Cells(f, 4) = Dgv.Item(3, i).Value
                    .Cells(f, 5) = Dgv.Item(6, i).Value
                    .Cells(f, 6) = Dgv.Item(8, i).Value
                    .Cells(f, 7) = Dgv.Item(9, i).Value
                    .Cells(f, 8) = Dgv.Item(7, i).Value
                    .Cells(f, 9) = Dgv.Item(11, i).Value
                    .Cells(f, 10) = CDbl(Dgv.Item(10, i).Value) * CDbl(Dgv.Item(11, i).Value)
                    Tot = Tot + (CDbl(Dgv.Item(10, i).Value) * CDbl(Dgv.Item(11, i).Value))
                    f = f + 1
                    i = i + 1
                Loop Until i = c

                .Range(.Cells(f, 1), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                .Cells(f, 1) = "VR.TOTAL"
                .Cells(f, 10) = Tot
                f = f + 1
                .Cells(f, 1) = "OBSERVACIONES: " & UCase(TbObs.Text.Trim)
                .Range(.Cells(f, 1), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 1) = "ENTREGA:"
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                m_Excel.Rows(f).RowHeight = 40

                .Cells(f, 4) = ""
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
                .Cells(f, 1) = UCase(LbResp.Text.Trim)  'REPONSABLE ALMACEN ORIGEN
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 4) = ""
                .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 7) = "NOMBRE QUIEN RECIBE: " & UCase(LbResponsable.Text.Trim) 'REPONSABLE ALMACEN DESTINO
                .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                f = f + 1
                .Cells(f, 1) = LbCarg.Text.Trim  'CARGO REPONSABLE ALMACEN ORIGEN
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 4) = ""
                .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 7) = LbCargo.Text.Trim  'CARGO REPONSABLE ALMACEN DESTINO
                .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                f = f + 1
                .Cells(f, 1) = "ESE MORENO Y CLAVIJO"
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 4) = ""
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
                .Range("E7").Value = "FECHA: " & DtFecha.Value.Date
                f = f + 1
            End With
        End If
    End Sub

    Private Sub ExportarFarmacia()
        Dim c = Dgv.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
        If c > 0 Then
            VerdatosOrigen()
            VerdatosDestino()
            Dim m_Excel As New Excel.Application
            'm_Excel.Cursor = Excel.XlMousePointer.xlWait
            m_Excel.Visible = True
            Dim Ruta As String = Application.StartupPath & "\Plantillas\FORMATO_SALIDA_FARMACIA.xlsx"
            Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Open(Ruta)
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets("Formato de entrada")
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                Dim i As Integer = 0
                Dim f As Integer = 10
                Dim Tot As Double = 0
                Do

                    .Cells(f, 1) = i + 1
                    '.Cells(f, 2) = Dgv.Item(10, i).Value

                    .Cells(f, 2) = Dgv.Item(1, i).Value
                    If IsDBNull(Dgv.Item(2, i).Value) = False Then
                        .Cells(f, 2) = Dgv.Item(1, i).Value & " " & Dgv.Item(2, i).Value
                    End If
                    .Cells(f, 3) = Dgv.Item(3, i).Value
                    .Cells(f, 4) = Dgv.Item(6, i).Value
                    .Cells(f, 5) = Dgv.Item(8, i).Value
                    .Cells(f, 6) = Dgv.Item(9, i).Value
                    .Cells(f, 7) = Dgv.Item(7, i).Value
                    .Cells(f, 8) = Dgv.Item(10, i).Value
                    .Cells(f, 9) = Dgv.Item(11, i).Value
                    .Cells(f, 10) = CDbl(Dgv.Item(10, i).Value) * CDbl(Dgv.Item(11, i).Value)
                    Tot = Tot + (CDbl(Dgv.Item(10, i).Value) * CDbl(Dgv.Item(11, i).Value))
                    f = f + 1
                    i = i + 1
                Loop Until i = c

                .Range(.Cells(f, 1), .Cells(f, 9)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                .Cells(f, 1) = "VR.TOTAL"
                .Cells(f, 10) = Tot
                f = f + 1
                .Cells(f, 1) = "OBSERVACIONES: " & UCase(TbObs.Text.Trim)
                .Range(.Cells(f, 1), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                f = f + 1
                .Cells(f, 1) = "ENTREGA:"
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                m_Excel.Rows(f).RowHeight = 40

                .Cells(f, 4) = ""
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
                .Cells(f, 1) = UCase(LbResp.Text.Trim)  'REPONSABLE ALMACEN ORIGEN
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 4) = ""
                .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 7) = "NOMBRE QUIEN RECIBE: " & UCase(LbResponsable.Text.Trim) 'REPONSABLE ALMACEN DESTINO
                .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                f = f + 1
                .Cells(f, 1) = LbCarg.Text.Trim  'CARGO REPONSABLE ALMACEN ORIGEN
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 4) = ""
                .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 7) = LbCargo.Text.Trim  'CARGO REPONSABLE ALMACEN DESTINO
                .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True
                f = f + 1
                .Cells(f, 1) = "ESE MORENO Y CLAVIJO"
                .Range(.Cells(f, 1), .Cells(f, 3)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 4) = ""
                .Range(.Cells(f, 4), .Cells(f, 6)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True

                .Cells(f, 7) = "ESE MORENO Y CLAVIJO"
                .Range(.Cells(f, 7), .Cells(f, 10)).Select()
                m_Excel.Selection.Merge()
                m_Excel.Selection.Font.Bold = True


                .Range(.Cells(11, 1), .Cells(f, 10)).Borders.LineStyle = 1

                .Range("J6").Value = TbCons.Text  '& NUMERO DE SALIDA
                .Range("A7").Value = "INSTITUCION: " & UCase(LbSede.Text.Trim)
                .Range("D6").Value = "FECHA: " & DtFecha.Value.Date
                f = f + 1
            End With
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Botones2()
        Limpiar()
        Inhabilitar()
    End Sub

    Private Sub ListarTraslado()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_S.Traslado = Val(TbCons.Text.Trim)
            ds = objCn_S.ListarSalidasTraslado(objCe_S)
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

    Private Sub VerdatosDestino()
        Dim ds As New DataSet
        LbResponsable.Text = ""
        LbSede.Text = ""
        LbCargo.Text = ""
        Try
            objCe_A.Cons = Val(CbAlmDestino.SelectedValue.ToString)
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

    Private Sub VerdatosOrigen()
        Dim ds As New DataSet
        LbResponsable.Text = ""
        LbSede.Text = ""
        LbCargo.Text = ""
        Try
            objCe_A.Cons = Val(CbAlmOrigen.SelectedValue.ToString)
            ds = objCn_A.VerDatosTraslado(objCe_A)
            If ds.Tables(0).Rows.Count > 0 Then
                'LbSede.Text = ds.Tables(0).Rows(0).Item(0)
                LbResp.Text = ds.Tables(0).Rows(0).Item(1)
                LbCarg.Text = ds.Tables(0).Rows(0).Item(2)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub
End Class