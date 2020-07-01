Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_Entradas
    Dim Ap As Integer
    Dim objCn_MesEstado As New Cn_MesEstado
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCn_S As New Cn_Alm_Semaforo
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_Sa As New Ce_Alm_Salidas
    Dim objCn_Sa As New Cn_Alm_Salidas

    Private Sub Frm_Alm_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        LbLab.Text = "" : LbLote.Text = "" : LbSaldo.Text = "" : LbConsLote.Text = "" : LbObs.Text = ""
        If DE = 1 Then
            TbEntrada.Text = FrmEntradas.TbCons.Text.Trim
        End If
        LoadMesActivo()
        LoadSemaforo()
        DtFecha.Value = Now.Date
    End Sub

    Private Sub BtnBuscarMed_Click(sender As Object, e As EventArgs) Handles BtnBuscarMed.Click
        BProd = 2
        Frm_Alm_BuscarProd.CbTProd.Enabled = False
        Frm_Alm_BuscarProd.RadioButton1.Enabled = False
        Frm_Alm_BuscarProd.RadioButton2.Checked = True
        Tp = UCase(LbTipoProd.Text)
        Frm_Alm_BuscarProd.ShowDialog()
        ListarLotesProd()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
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

    Private Sub CrearLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearLoteToolStripMenuItem.Click
        Frm_Alm_Lote.LbAlmacen.Text = LbAlmacen.Text
        Frm_Alm_Lote.LbNombreAlmacen.Text = LbNombreAlmacen.Text
        Frm_Alm_Lote.LbEntrada.Text = LbEntrada.Text
        Frm_Alm_Lote.ShowDialog()
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
            objCe_L.Almacen = Val(LbAlmacen.Text)
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

                    If IsDBNull(ds.Tables(0).Rows(i).Item(8)) = False Then
                        Dgv.Item(19, i).Value = ds.Tables(0).Rows(i).Item(8)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(9)) = False Then
                        Dgv.Item(20, i).Value = ds.Tables(0).Rows(i).Item(9)
                    End If
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

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim M As Integer = DtFecha.Value.Month
        Dim A As Integer = DtFecha.Value.Year
        If Val(TbConsMes.Text.Trim) <> M Or Val(TbAño.Text.Trim) <> A Then
            MsgBox("La fecha no pertenece al periodo activo", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Val(LbConsLote.Text.Trim) = 0 Then
            MsgBox("Debe Seleccione un lote valido", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Val(TbCantidad.Text.Trim) < 1 Then
            MsgBox("La cantidad no puede ser cero (0)", MsgBoxStyle.Critical)
            TbCantidad.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea regitrar la entrada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RegistrarEntrada()
            If Val(TbEntrada.Text.Trim) > 0 Then
                'RegistrarEntradaDetalle()
            End If
        End If
        LbLab.Text = "" : LbLote.Text = "" : LbSaldo.Text = "" : LbConsLote.Text = "" : LbObs.Text = ""
        ListarLotesProd()
    End Sub

    Private Sub RegistrarEntrada()
        If CheckBox1.Checked = True Then
            Ap = 1
        Else
            Ap = 0
        End If
        Try
            objCe_E.Fecha = DtFecha.Value.Date
            objCe_E.Mes = Val(TbConsMes.Text.Trim)
            objCe_E.Año = Val(TbAño.Text.Trim)
            objCe_E.Prod = Val(TbCons.Text.Trim)
            objCe_E.Lote = Val(LbConsLote.Text.Trim)
            objCe_E.Cant = Val(TbCantidad.Text.Trim)
            objCe_E.Unitario = CDbl(TbValor.Text.Trim)
            objCe_E.TProd = Val(LbTProd.Text.Trim)
            objCe_E.Entrada = Val(TbEntrada.Text.Trim)
            objCe_E.Almacen = Val(LbAlmacen.Text.Trim)
            objCe_E.Aprovechamiento = Ap
            objCn_E.NuevoEntrada(objCe_E)
        Catch ex As Exception
        End Try
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
        On Error Resume Next
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
        LbObs.Text = Dgv.Item(18, i).Value
        TbValor.Text = Dgv.Item(16, i).Value
        TbCantidad.Focus()
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

    Private Sub ModificarLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarLoteToolStripMenuItem.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        Frm_Alm_EditLotes.LbAlmacen.Text = LbAlmacen.Text
        Frm_Alm_EditLotes.LbNombreAlmacen.Text = LbNombreAlmacen.Text

        Frm_Alm_EditLotes.LbCons.Text = Dgv.Item(0, i).Value
        Frm_Alm_EditLotes.TbCUM.Text = Dgv.Item(1, i).Value
        Frm_Alm_EditLotes.Laborat.Text = Dgv.Item(2, i).Value
        Frm_Alm_EditLotes.TbLote.Text = Dgv.Item(3, i).Value
        Frm_Alm_EditLotes.TbInvima.Text = Dgv.Item(4, i).Value
        Dim F As String = Mid(Dgv.Item(5, i).Value, 4, 2) & Mid(Dgv.Item(5, i).Value, 7, 4)
        Frm_Alm_EditLotes.TbVence.Text = F
        Frm_Alm_EditLotes.TbCant.Text = Dgv.Item(6, i).Value
        Frm_Alm_EditLotes.TbUnitario.Text = Dgv.Item(7, i).Value

        Frm_Alm_EditLotes.TbSerial.Text = Dgv.Item(19, i).Value
        Frm_Alm_EditLotes.TbUtil.Text = Dgv.Item(20, i).Value

        Frm_Alm_EditLotes.TbObs.Text = Dgv.Item(18, i).Value
        Frm_Alm_EditLotes.ShowDialog()
        ListarLotesProd()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class