Imports C_Entidad
Imports C_Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmEntradas
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
        TbSoporte.Enabled = True
        DtFecha.Enabled = True
        CbAlmacenes.Enabled = True
        CbProvedores.Enabled = True
        CbTProd.Enabled = True
        BtnAlmacen.Enabled = True
        BtnAddProductos.Enabled = False
        BtnBuscar.Enabled = False
        BtnExportar.Enabled = False
        BtnProveedores.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbSoporte.Enabled = False
        DtFecha.Enabled = False
        CbAlmacenes.Enabled = False
        CbProvedores.Enabled = False
        CbTProd.Enabled = False
        BtnAlmacen.Enabled = False
        BtnAddProductos.Enabled = True
        BtnBuscar.Enabled = True
        BtnExportar.Enabled = True
        BtnProveedores.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbSoporte.Text = ""
        CbProvedores.Text = ""
        CbAlmacenes.Text = ""
        CbTProd.Text = ""
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

    Private Sub ListarProveedoresActivos()
        Dim ds As New DataSet
        CbProvedores.DataSource = Nothing
        CbProvedores.Items.Clear()
        Try
            ds = objCn_Pr.ListarProveedoresActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbProvedores.DataSource = ds.Tables(0)
                CbProvedores.DisplayMember = "Nombre"
                CbProvedores.ValueMember = "Cons"
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

    Private Sub FrmEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        ListarTipoProd()
        ListarAlmacenes()
        LoadMesActivo()
        ListarProveedoresActivos()
        Botones1()
        Limpiar()
        Inhabilitar()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        FrmProveedores.ShowDialog()
        ListarProveedoresActivos
    End Sub

    Private Sub BtnAddProductos_Click(sender As Object, e As EventArgs) Handles BtnAddProductos.Click
        If CbAlmacenes.Text.Trim = "" Then
            MsgBox("Seleccione un almacen válido", MsgBoxStyle.Critical)
            CbAlmacenes.Focus()
            Exit Sub
        End If

        Frm_Alm_Entradas.LbTProd.Text = Val(CbTProd.SelectedValue.ToString)
        Frm_Alm_Entradas.LbTipoProd.Text = UCase(CbTProd.Text)
        Frm_Alm_Entradas.Label1.Text = "ENTRADA DE " & CbTProd.Text.Trim

        If Val(CbAlmacenes.SelectedValue.ToString) = 0 Then
            MsgBox("Seleccione el almacen", MsgBoxStyle.Critical)
            CbAlmacenes.Enabled = True
            CbAlmacenes.Focus()
            Exit Sub
        End If
        Frm_Alm_Entradas.LbAlmacen.Text = Val(CbAlmacenes.SelectedValue.ToString)
        Frm_Alm_Entradas.LbNombreAlmacen.Text = CbAlmacenes.Text
        Frm_Alm_Entradas.LbEntrada.Text = TbCons.Text.Trim
        DE = 1
        Frm_Alm_Entradas.ShowDialog()
        ListarEntradasCons()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        DtFecha.Value = Now
        TbSoporte.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Val(CbProvedores.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el proveedor", MsgBoxStyle.Critical)
            CbProvedores.Focus()
            Exit Sub
        End If
        If Val(CbTProd.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el tipo de producto", MsgBoxStyle.Critical)
            CbTProd.Focus()
            Exit Sub
        End If
        If Val(CbAlmacenes.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar el almacén", MsgBoxStyle.Critical)
            CbAlmacenes.Focus()
            Exit Sub
        End If
        If TbSoporte.Text.Trim = "" Then

            If MsgBox("¿Confirma que desea regitrar la entrada sin registrar el soporte?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                TbSoporte.Focus()
                Exit Sub
            End If
        End If
        If MsgBox("¿Confirma que desea registrar la entreda?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_E.Cons = VerConsEntreda() + 1
                TbCons.Text = objCe_E.Cons
                objCe_E.Fecha = DtFecha.Value.Date
                objCe_E.Func = Val(ConsFunc)
                objCe_E.Pedido = Val(TbPedido.Text.Trim)
                objCe_E.Proveedor = Val(CbProvedores.SelectedValue.ToString)
                objCe_E.TProd = Val(CbTProd.SelectedValue.ToString)
                objCe_E.Almacen = Val(CbAlmacenes.SelectedValue.ToString)
                objCe_E.Soporte = UCase(TbSoporte.Text.Trim)
                objCn_E.NuevaEntrada(objCe_E)
                ActualizarConsEntrada()
                Botones1()
                'Limpiar()
                Inhabilitar()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnAlmacen_Click(sender As Object, e As EventArgs) Handles BtnAlmacen.Click
        FrmAlmacenes.ShowDialog()
        ListarAlmacenes()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BEntrada = 1
        Frm_BuscarEntrada.ShowDialog()
        CbAlmacenes.Enabled = True
        ListarEntradasCons()
    End Sub

    Private Function VerConsEntreda() As Integer
        Dim ds As New DataSet
        Try
            ds = objCn_C.VerConsEntradas
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Function

    Private Sub ActualizarConsEntrada()
        Try
            objCe_C.Entradas = Val(TbCons.Text.Trim)
            objCn_C.ActualizarConsEntradas(objCe_C)
        Catch ex As Exception
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

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim c = Dgv.Rows.Count
        Dim numero As Integer = 0
        Dim temp As String = ""
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
                .Range("A5").Value = "AUXILIAR: " '& AuxFarmacia
                .Range("B4").Value = FrmModulos.LbSede.Text
                .Range("A4").Value = "FECHA: " & Format(DtFecha.Value.Date, "dd/MM/yyyy")
                .Cells(f, 1) = "OBSERVACIONES:"
                .Range(.Cells(f, 1), .Cells(f, 11)).Select()
                m_Excel.Selection.Merge()
                ' m_Excel.Selection.Font.Bold = True
                f = f + 1
                .Cells(f, 1) = "NOMBRE: " '& AuxFarmacia
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
    End Sub

    Private Sub TbCons_OnValueChanged(sender As Object, e As EventArgs) Handles TbCons.OnValueChanged

    End Sub
End Class