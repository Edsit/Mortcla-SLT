Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_Salidas
    Dim objCn_MesEstado As New Cn_MesEstado
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCn_S As New Cn_Alm_Semaforo
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_Sa As New Ce_Alm_Salidas
    Dim objCn_Sa As New Cn_Alm_Salidas
    Dim objCn_Ts As New Cn_Alm_TipoSalida
    Dim objCn_Se As New Cn_Sedes
    Dim objCe_A As New Ce_Almacenes
    Dim objCn_A As New Cn_Almacenes
    Dim objCn_Ar As New Cn_Areas

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        FrmSalidas.CbTProd.Enabled = True
        FrmSalidas.CbAlmacen.Enabled = True
        FrmSalidas.Button1.Enabled = True
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarAreasActivas()
        Dim ds As New DataSet
        CbArea.DataSource = Nothing
        CbArea.Items.Clear()
        Try
            ds = objCn_Ar.ListarAreasActivas
            If ds.Tables(0).Rows.Count > 0 Then
                CbArea.DataSource = ds.Tables(0)
                CbArea.DisplayMember = "AREA"
                CbArea.ValueMember = "CONS"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Frm_Alm_Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        LbLab.Text = "" : LbLote.Text = "" : LbSaldo.Text = "" : LbConsLote.Text = ""
        LIstarTipoSalida()
        ListarSedesRotacion()
        LoadMesActivo()
        LoadSemaforo()
        ListarAreasActivas()
        If Sal = 1 Then
            LbTProd.Text = Val(FrmSalidas.CbTProd.SelectedValue.ToString)
            LbTipoProd.Text = UCase(FrmSalidas.CbTProd.Text.Trim)
            Label1.Text = "SALIDA DE " & LbTipoProd.Text
            CbTipo.Text = "DISPENSADO"
        ElseIf Sal = 2 Then
            LbTProd.Text = Val(Frm_Traslados.CbTProd.SelectedValue.ToString)
            LbTipoProd.Text = UCase(Frm_Traslados.CbTProd.Text.Trim)
            Label1.Text = "TRASLADO DE " & LbTipoProd.Text
            CbTipo.Enabled = False
            CbTipo.Text = ""
        End If
        DtFecha.Value = Now.Date
        CbDestino.Text = "" : CbDestino.Enabled = False
        CbAlmacen.Text = "" : CbAlmacen.Enabled = False
    End Sub

    Sub LoadMesActivo()
        Dim ds As New DataSet
        Try
            ds = objCn_MesEstado.LoadMesActivo
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

    Private Sub BtnBuscarMed_Click(sender As Object, e As EventArgs) Handles BtnBuscarMed.Click
        BProd = 3
        Frm_Alm_BuscarProd.CbTProd.Enabled = False
        Frm_Alm_BuscarProd.RadioButton1.Enabled = False
        Frm_Alm_BuscarProd.RadioButton2.Checked = True
        Tp = UCase(LbTipoProd.Text)
        Frm_Alm_BuscarProd.ShowDialog()
        ListarLotesProd()
    End Sub

    Private Sub ListarLotesProd()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Dgv.Rows.Clear()
        Try
            objCe_L.Prod = Val(TbCons.Text.Trim)
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            objCe_L.Almacen = Val(LbAlmacen.Text.Trim)
            ds = objCn_L.ListarLotesProd(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    If IsDBNull(ds.Tables(0).Rows(i).Item(0)) = False Then
                        Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(1)) = False Then
                        Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(2)) = False Then
                        Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(3)) = False Then
                        Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(4)) = False Then
                        Dgv.Item(4, i).Value = ds.Tables(0).Rows(i).Item(4)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(5)) = False Then
                        Dgv.Item(5, i).Value = Format(ds.Tables(0).Rows(i).Item(5), "dd/MM/yyyy")
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(6)) = False Then
                        Dgv.Item(6, i).Value = ds.Tables(0).Rows(i).Item(6)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(7)) = False Then
                        Dgv.Item(7, i).Value = ds.Tables(0).Rows(i).Item(7)
                    End If
                    Dgv.Item(8, i).Value = Val(ds.Tables(0).Rows(i).Item(7)) * Val(ds.Tables(0).Rows(i).Item(6))

                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If Dgv.Rows.Count > 0 Then
                LoadEntradas()
                LoadSalidas()
                SaldoTotal()
                Semaforizar()
                ColorMed()
            End If
        End Try
    End Sub

    Sub LoadSemaforo()
        Dim ds As New DataSet
        Try
            ds = objCn_S.ListarSemaforo
            If ds.Tables(0).Rows.Count > 0 Then
                Rojo = ds.Tables(0).Rows(0).Item("Rojo")
                Amarillo = ds.Tables(0).Rows(0).Item("Amarillo")
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Sub Semaforizar()
        Dim numero As Integer, i As Integer, Cont As Integer
        Dim FECHAD, FECHITA As String
        i = 0 : Cont = 0
        Dim Cf As String, DA As String
        LoadSemaforo()
        Do
            DA = Now.Day
            FECHAD = Dgv.Item(5, i).Value
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
                Dgv.Rows(i).Cells(5).Style.BackColor = Color.Red
                Dgv.Rows(i).Cells(5).Style.ForeColor = Color.White
            End If
            If numero >= (Rojo) And numero <= (Amarillo - 1) Then
                Dgv.Rows(i).Cells(5).Style.BackColor = Color.Yellow
                Dgv.Rows(i).Cells(5).Style.ForeColor = Color.Black
            End If
            If numero > (Amarillo - 1) Then
                Dgv.Rows(i).Cells(5).Style.BackColor = Color.Green
                Dgv.Rows(i).Cells(5).Style.ForeColor = Color.White
            End If
            If numero < 0 Then
                Dgv.Rows(i).Cells(5).Style.BackColor = Color.White
                Dgv.Rows(i).Cells(5).Style.ForeColor = Color.Black
                Cont = Cont + 1
            End If
            i = i + 1
        Loop Until i = Dgv.RowCount
        'If Cont > 0 Then
        '    LbMensajeMed.Text = "Hay " & Cont & " registro(s) con productos vencidos"
        '    LbMensajeMed.ForeColor = Color.Maroon
        'End If
    End Sub

    Sub LoadEntradas()
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(Dgv.Item(0, i).Value)
                    'objCe_E.Mes = Val(TbConsMes.Text.Trim)
                    'objCe_E.Año = Val(TbAño.Text.Trim)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            Dgv.Item(9, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            Dgv.Item(9, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            Dgv.Item(10, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            Dgv.Item(10, i).Value = 0
                        End If
                        Dgv.Item(11, i).Value = Val(Dgv.Item(9, i).Value) * CDbl(Dgv.Item(10, i).Value)
                        Dgv.Item(11, i).Value = Dgv.Item(11, i).Value
                    Else
                        Dgv.Item(9, i).Value = 0
                        Dgv.Item(10, i).Value = Dgv.Item(7, i).Value
                        Dgv.Item(11, i).Value = (0)
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
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_Sa.Lote = Val(Dgv.Item(0, i).Value)
                    ds = objCn_Sa.ListarSalidas(objCe_Sa)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            Dgv.Item(12, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            Dgv.Item(12, i).Value = 0
                        End If

                        If Dgv.Item(7, i).Value = 0 Then
                            Dgv.Item(13, i).Value = Dgv.Item(10, i).Value
                        Else
                            If Dgv.Item(10, i).Value = 0 Then
                                Dgv.Item(13, i).Value = Dgv.Item(7, i).Value
                            Else
                                Dgv.Item(13, i).Value = (Dgv.Item(7, i).Value + Dgv.Item(10, i).Value) / 2
                            End If
                        End If

                        'If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                        '    Dgv.Item(13, i).Value = ds.Tables(0).Rows(0).Item(1)
                        'End If

                        Dgv.Item(14, i).Value = Val(Dgv.Item(12, i).Value) * CDbl(Dgv.Item(13, i).Value)
                        Dgv.Item(14, i).Value = Dgv.Item(14, i).Value
                    Else
                        Dgv.Item(12, i).Value = 0
                        Dgv.Item(13, i).Value = Dgv.Item(10, i).Value
                        Dgv.Item(14, i).Value = (0)
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
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Dgv.Item(15, i).Value = Val(Dgv.Item(6, i).Value) + Val(Dgv.Item(9, i).Value) - Val(Dgv.Item(12, i).Value)
                Dgv.Item(16, i).Value = Dgv.Item(13, i).Value
                Dgv.Item(16, i).Value = (Dgv.Item(16, i).Value)
                Dgv.Item(17, i).Value = Val(Dgv.Item(15, i).Value) * CDbl(Dgv.Item(16, i).Value)
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub ColorMed()
        Dim i As Integer
        i = 0
        Do
            Dgv.Rows(i).Cells(6).Style.BackColor = Color.LightBlue
            Dgv.Rows(i).Cells(7).Style.BackColor = Color.LightBlue
            Dgv.Rows(i).Cells(8).Style.BackColor = Color.LightBlue

            Dgv.Rows(i).Cells(9).Style.BackColor = Color.LightSalmon
            Dgv.Rows(i).Cells(10).Style.BackColor = Color.LightSalmon
            Dgv.Rows(i).Cells(11).Style.BackColor = Color.LightSalmon

            Dgv.Rows(i).Cells(12).Style.BackColor = Color.LightGreen
            Dgv.Rows(i).Cells(13).Style.BackColor = Color.LightGreen
            Dgv.Rows(i).Cells(14).Style.BackColor = Color.LightGreen

            Dgv.Rows(i).Cells(15).Style.BackColor = Color.LightGray
            Dgv.Rows(i).Cells(16).Style.BackColor = Color.LightGray
            Dgv.Rows(i).Cells(17).Style.BackColor = Color.LightGray
            i = i + 1
        Loop Until i = Dgv.RowCount
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbConsLote.Text = Val(Dgv.Item(0, i).Value)
        LbLab.Text = Dgv.Item(2, i).Value
        LbLote.Text = Dgv.Item(3, i).Value
        LbSaldo.Text = Dgv.Item(15, i).Value
        TbValor.Text = Dgv.Item(16, i).Value
        TbCantidad.Focus()
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim M As Integer = DtFecha.Value.Month
        Dim A As Integer = DtFecha.Value.Year
        If Val(TbConsMes.Text.Trim) <> M Or Val(TbAño.Text.Trim) <> A Then
            MsgBox("La fecha no pertenece al periodo activo", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If CbTipo.Text = "ROTACION" Then
            If CbDestino.Text.Trim = "" Then
                MsgBox("Debe seleccionar el destino", MsgBoxStyle.Critical)
                CbDestino.Focus()
                Exit Sub
                Exit Sub
            End If
            If CbAlmacen.Text.Trim = "" Then
                MsgBox("Debe seleccionar el Almacén", MsgBoxStyle.Critical)
                CbAlmacen.Focus()
                Exit Sub
            End If
        End If
        If Val(TbCantidad.Text.Trim) < 1 Then
            MsgBox("La cantidad no puede ser cero (0)", MsgBoxStyle.Critical)
            TbCantidad.Focus()
            Exit Sub
        End If

        If Val(TbCantidad.Text.Trim) > Val(LbSaldo.Text.Trim) Then
            MsgBox("La cantidad supera las existencias", MsgBoxStyle.Critical)
            TbCantidad.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea regitrar la salida?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RegistrarSalida()
        End If
        LbLab.Text = "" : LbLote.Text = "" : LbSaldo.Text = "" : LbConsLote.Text = ""
        ListarLotesProd()
    End Sub

    Private Sub RegistrarSalida()
        Try
            objCe_Sa.Fecha = DtFecha.Value.Date
            objCe_Sa.Mes = Val(TbConsMes.Text.Trim)
            objCe_Sa.Año = Val(TbAño.Text.Trim)
            objCe_Sa.Prod = Val(TbCons.Text.Trim)
            objCe_Sa.Lote = Val(LbConsLote.Text.Trim)
            objCe_Sa.Cant = Val(TbCantidad.Text.Trim)
            objCe_Sa.Unitario = CDbl(TbValor.Text.Trim)
            objCe_Sa.TProd = Val(LbTProd.Text.Trim)
            objCe_Sa.TipoSalida = Val(CbTipo.SelectedValue.ToString)
            If CbTipo.Text = "ROTACION" Then
                objCe_Sa.Destino = Val(CbDestino.SelectedValue.ToString)
                objCe_Sa.Almacen = Val(CbAlmacen.SelectedValue.ToString)
            End If
            objCe_Sa.Almacen = Val(LbAlmacen.Text)
            If CbArea.Enabled = True Then
                objCe_Sa.Area = Val(CbArea.SelectedValue.ToString)
            End If
            If Val(LbTraslado.Text.Trim) > 0 Then
                objCe_Sa.Traslado = Val(LbTraslado.Text.Trim)
            End If
            objCn_Sa.NuevaSalida(objCe_Sa)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LIstarTipoSalida()
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

    Private Sub TbCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCantidad.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TbValor.Focus()
        End If
    End Sub

    Private Sub TbValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbValor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub ListarSedesRotacion()
        Dim ds As New DataSet
        CbDestino.DataSource = Nothing
        CbDestino.Items.Clear()
        CbAlmacen.DataSource = Nothing
        CbAlmacen.Items.Clear()
        Try
            ds = objCn_Se.ListarSedesRotacion
            If ds.Tables(0).Rows.Count > 0 Then
                CbDestino.DataSource = ds.Tables(0)
                CbDestino.DisplayMember = "Sede"
                CbDestino.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarAlmacenes()
        Dim ds As New DataSet
        CbAlmacen.DataSource = Nothing
        CbAlmacen.Items.Clear()
        Try
            objCe_A.Sede = Val(CbDestino.SelectedValue.ToString)
            ds = objCn_A.ListarAlmacenesRotacion(objCe_A)
            If ds.Tables(0).Rows.Count > 0 Then
                CbAlmacen.DataSource = ds.Tables(0)
                CbAlmacen.DisplayMember = "Nombre"
                CbAlmacen.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged
        If CbTipo.Text = "ROTACION" Or CbTipo.Text = "DESPACHO" Then
            CbDestino.Enabled = True
            CbAlmacen.Enabled = True
            CbArea.Enabled = False
        ElseIf CbTipo.Text = "CONSUMO"
            CbArea.Enabled = True
            CbDestino.Text = "" : CbDestino.Enabled = False
            CbAlmacen.Text = "" : CbAlmacen.Enabled = False
        Else
            CbDestino.Text = "" : CbDestino.Enabled = False
            CbAlmacen.Text = "" : CbAlmacen.Enabled = False
            CbArea.Text = "" : CbArea.Enabled = False
        End If
    End Sub

    Private Sub CbTipo_Click(sender As Object, e As EventArgs) Handles CbTipo.Click
        If CbTipo.Text = "ROTACION" Then
            CbDestino.Enabled = True
            CbAlmacen.Enabled = True
        Else
            CbDestino.Text = "" : CbDestino.Enabled = False
            CbAlmacen.Text = "" : CbAlmacen.Enabled = False
        End If
    End Sub

    Private Sub CbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDestino.SelectedIndexChanged
        ListarAlmacenes()
    End Sub

    Private Sub CbDestino_Click(sender As Object, e As EventArgs) Handles CbDestino.Click
        ListarAlmacenes()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class