Imports C_Entidad
Imports C_Negocio
Public Class Frm_Ajustes_Prod
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
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Frm_Ajustes.CbTProd.Enabled = True
        Frm_Ajustes.CbAlmacen.Enabled = True
        Frm_Ajustes.Button1.Enabled = True
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

    Private Sub Frm_Ajustes_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbIni.Text = ""
        LbEntradas.Text = ""
        LbSalidas.Text = ""
        LbSaldo.Text = ""
        LbLote.Text = ""
        LbConsLote.Text = ""
        LoadMesActivo()
        LbTProd.Text = Val(Frm_Ajustes.CbTProd.SelectedValue.ToString)
        LbTipoProd.Text = UCase(Frm_Ajustes.CbTProd.Text.Trim)
    End Sub

    Private Sub BtnBuscarMed_Click(sender As Object, e As EventArgs) Handles BtnBuscarMed.Click
        BProd = 5
        Frm_Alm_BuscarProd.CbTProd.Enabled = False
        Frm_Alm_BuscarProd.RadioButton1.Enabled = False
        Frm_Alm_BuscarProd.RadioButton2.Checked = True
        Tp = UCase(LbTipoProd.Text)
        Frm_Alm_BuscarProd.ShowDialog()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        LbIni.Text = ""
        LbEntradas.Text = ""
        LbSalidas.Text = ""
        LbSaldo.Text = ""
        LbLote.Text = ""
        LbConsLote.Text = ""
        RadioButton1.BackColor = Color.Green
        RadioButton1.ForeColor = Color.White
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.ForeColor = Color.Black
        If RadioButton1.Checked = True Then
            ListarEntradas()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        LbIni.Text = ""
        LbEntradas.Text = ""
        LbSalidas.Text = ""
        LbSaldo.Text = ""
        LbLote.Text = ""
        LbConsLote.Text = ""
        RadioButton2.BackColor = Color.Green
        RadioButton2.ForeColor = Color.White
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.ForeColor = Color.Black
        If RadioButton2.Checked = True Then
            ListarSalidas()
        End If
    End Sub

    Private Sub ListarEntradas()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_E.Mes = Val(TbConsMes.Text.Trim)
            objCe_E.Año = Val(TbAño.Text.Trim)
            objCe_E.Prod = Val(TbCons.Text.Trim)
            objCe_E.TProd = Val(LbTProd.Text.Trim)
            objCe_E.Almacen = Val(LbAlmacen.Text.Trim)
            ds = objCn_E.LsitarEntradasAjustes(objCe_E)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
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
                    i = i + 1
                Loop Until i = c
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarSalidas()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_Sa.Mes = Val(TbConsMes.Text.Trim)
            objCe_Sa.Año = Val(TbAño.Text.Trim)
            objCe_Sa.Prod = Val(TbCons.Text.Trim)
            objCe_Sa.TProd = Val(LbTProd.Text.Trim)
            objCe_Sa.Almacen = Val(LbAlmacen.Text.Trim)
            ds = objCn_Sa.LsitarsALIDASAjustes(objCe_Sa)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                    Dgv.Item(4, i).Value = ""
                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(4)
                    Dgv.Item(6, i).Value = ds.Tables(0).Rows(i).Item(5)
                    i = i + 1
                Loop Until i = c
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub VerCantIni()
        Dim ds As New DataSet
        Try
            objCe_L.Cons = Val(LbConsLote.Text.Trim)
            ds = objCn_L.VerIniLote(objCe_L)
            If ds.Tables(0).Rows.Count > 0 Then
                LbIni.Text = ds.Tables(0).Rows(0).Item(0)
            Else
                LbIni.Text = 0
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub VerCantEntrada()
        Dim ds As New DataSet
        Try
            objCe_E.Lote = Val(LbConsLote.Text.Trim)
            ds = objCn_E.VerSumEntradasLote(objCe_E)
            If ds.Tables(0).Rows.Count > 0 Then
                LbEntradas.Text = ds.Tables(0).Rows(0).Item(0)
            Else
                LbEntradas.Text = 0
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub VerCantSalidas()
        Dim ds As New DataSet
        Try
            objCe_Sa.Lote = Val(LbConsLote.Text.Trim)
            ds = objCn_Sa.VerSumaSalidas(objCe_Sa)
            If ds.Tables(0).Rows.Count > 0 Then
                LbSalidas.Text = ds.Tables(0).Rows(0).Item(0)
            Else
                LbSalidas.Text = 0
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub VerCantidadesLote()
        VerCantIni()
        VerCantEntrada()
        VerCantSalidas()
        LbSaldo.Text = (Val(LbIni.Text) + Val(LbEntradas.Text)) - Val(LbSalidas.Text)
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        LbIni.Text = ""
        LbEntradas.Text = ""
        LbSalidas.Text = ""
        LbSaldo.Text = ""
        LbLote.Text = ""
        LbConsLote.Text = ""
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        LbConsLote.Text = Dgv.Item(2, i).Value
        LbLote.Text = Dgv.Item(3, i).Value
        VerCantidadesLote()
        TbCant.Text = Dgv.Item(5, i).Value
        TbUnitario.Text = Dgv.Item(6, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ModificarEntrada()
            ListarEntradas()
        End If
        If RadioButton2.Checked = True Then
            ModificarSalida()
            ListarSalidas()
        End If
    End Sub

    Private Sub ModificarEntrada()
        If Val(TbCant.Text.Trim) = 0 Then
            MsgBox("Debe indicar la Cantidad", MsgBoxStyle.Critical)
            TbCant.Focus()
            Exit Sub
        End If
        If CDbl(TbUnitario.Text.Trim) = 0 Then
            MsgBox("Debe indicar el valor unitario", MsgBoxStyle.Critical)
            TbUnitario.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea realizar el ajuste de la entrada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_E.Cons = Val(LbCons.Text.Trim)
                objCe_E.Cant = Val(TbCant.Text.Trim)
                objCe_E.Unitario = CDbl(TbUnitario.Text)
                objCn_E.AjustarEntrada(objCe_E)
                VerCantidadesLote()
                TbCant.Text = ""
                TbUnitario.Text = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ModificarSalida()
        If Val(TbCant.Text.Trim) = 0 Then
            MsgBox("Debe indicar la Cantidad", MsgBoxStyle.Critical)
            TbCant.Focus()
            Exit Sub
        End If
        If CDbl(TbUnitario.Text.Trim) = 0 Then
            MsgBox("Debe indicar el valor unitario", MsgBoxStyle.Critical)
            TbUnitario.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea realizar el ajuste de la Salida?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Sa.Cons = Val(LbCons.Text.Trim)
                objCe_Sa.Cant = Val(TbCant.Text.Trim)
                objCe_Sa.Unitario = CDbl(TbUnitario.Text)
                objCn_Sa.AjustarSalida(objCe_Sa)
                VerCantidadesLote()
                TbCant.Text = ""
                TbUnitario.Text = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If RadioButton1.Checked = True Then
            EliminarEntrada()
            ListarEntradas()
        End If
        If RadioButton2.Checked = True Then
            EliminarSalida()
            ListarSalidas()
        End If
        LbIni.Text = ""
        LbEntradas.Text = ""
        LbSalidas.Text = ""
        LbSaldo.Text = ""
        LbLote.Text = ""
        LbConsLote.Text = ""
    End Sub

    Private Sub EliminarEntrada()
        If MsgBox("¿Confirma que desea eliminar la entrada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_E.Cons = Val(LbCons.Text.Trim)
                objCn_E.EliminarEntrada(objCe_E)
                VerCantidadesLote()
                TbCant.Text = ""
                TbUnitario.Text = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub EliminarSalida()
        If MsgBox("¿Confirma que desea eliminar la Salida?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Sa.Cons = Val(LbCons.Text.Trim)
                objCn_Sa.EliminarSalida(objCe_Sa)
                VerCantidadesLote()
                TbCant.Text = ""
                TbUnitario.Text = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class