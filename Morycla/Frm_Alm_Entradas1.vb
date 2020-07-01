Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_Entradas1
    Dim objCn_MesEstado As New Cn_MesEstado
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCn_S As New Cn_Alm_Semaforo
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_Sa As New Ce_Alm_Salidas
    Dim objCn_Sa As New Cn_Alm_Salidas

    Private Sub BtnBuscarProd_MouseLeave(sender As Object, e As EventArgs) Handles BtnBuscarProd.MouseLeave
        BtnBuscarProd.ForeColor = Color.ForestGreen
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles BtnCerrar.MouseHover
        BtnCerrar.ForeColor = Color.White
    End Sub

    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        LbMensajeMed.Text = ""
        LbConsLote.Text = ""
        LbLote.Text = ""
        LbSaldo.Text = ""
        DgvE.Rows.Clear()
        DgvS.Rows.Clear()
        BProd = 6
        Frm_Alm_BuscarProd.CbTProd.Enabled = False
        Frm_Alm_BuscarProd.RadioButton1.Enabled = False
        Frm_Alm_BuscarProd.RadioButton2.Checked = True
        Tp = UCase(LbTipoProd.Text)
        Frm_Alm_BuscarProd.ShowDialog()
        ListarLotesProd()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscarProd.MouseHover
        BtnBuscarProd.ForeColor = Color.White
    End Sub

    Private Sub Frm_Alm_Entradas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvE.Font = New Font("Arial", 8, FontStyle.Regular)
        DgvS.Font = New Font("Arial", 8, FontStyle.Regular)
        LbProd.Text = ""
        LbConsProd.Text = ""
        LbConsLote.Text = ""
        LbLote.Text = ""
        LbSaldo.Text = ""
        LbMensajeMed.Text = ""
        If DE = 1 Then
            LbEntrada.Text = FrmEntradas.TbCons.Text.Trim
        End If
        LoadMesActivo()
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

    Private Sub ListarLotesProd()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Dgv.Rows.Clear()
        Try
            objCe_L.Prod = Val(LbConsProd.Text.Trim)
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            objCe_L.Almacen = Val(LbAlmacen.Text)
            ds = objCn_L.ListarLotesProd(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
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

                'LoadSalidas()
                'SaldoTotal()
                Semaforizar()
                'ColorMed()
            End If
        End Try
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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
        If Cont > 0 Then
            LbMensajeMed.Text = "Hay " & Cont & " registro(s) con productos vencidos"
            LbMensajeMed.ForeColor = Color.Maroon
        End If
    End Sub

    Sub LoadEntradas()
        Dim ds As DataSet
        DgvE.Rows.Clear()
        Try
            ds = New DataSet
            objCe_E.Lote = Val(LbConsLote.Text.Trim)
            ds = objCn_E.ListarEntradas(objCe_E)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    DgvE.Rows.Add()
                    DgvE.Item(0, i).Value = ds.Tables(0).Rows(i).Item(2)
                    DgvE.Item(1, i).Value = ds.Tables(0).Rows(i).Item(3)
                    DgvE.Item(2, i).Value = ds.Tables(0).Rows(i).Item(0)
                    DgvE.Item(3, i).Value = ds.Tables(0).Rows(i).Item(1)
                    DgvE.Item(4, i).Value = CDbl(DgvE.Item(2, i).Value) * CDbl(DgvE.Item(3, i).Value)
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try

    End Sub

    Sub LoadSalidas()
        Dim ds As DataSet
        DgvS.Rows.Clear()
        Try
            ds = New DataSet
            objCe_Sa.Lote = Val(LbConsLote.Text.Trim)
            ds = objCn_Sa.ListarSalidas(objCe_Sa)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    DgvS.Rows.Add()
                    DgvS.Item(0, i).Value = ds.Tables(0).Rows(i).Item(2)
                    DgvS.Item(1, i).Value = ds.Tables(0).Rows(i).Item(3)
                    DgvS.Item(2, i).Value = ds.Tables(0).Rows(i).Item(0)
                    DgvS.Item(3, i).Value = ds.Tables(0).Rows(i).Item(1)
                    DgvS.Item(4, i).Value = CDbl(DgvS.Item(2, i).Value) * CDbl(DgvS.Item(3, i).Value)
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try

    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbConsLote.Text = Dgv.Item(0, i).Value
        LbLote.Text = Dgv.Item(3, i).Value
        LoadEntradas()
        LoadSalidas()
        TbUnitario.Text = Dgv.Item(7, i).Value
        TbCant.Focus()
    End Sub

    Private Sub BuscarLoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarLoteToolStripMenuItem.Click
        FrmSeeLote.LbConsProd.Text = LbConsProd.Text
        FrmSeeLote.LbProd.Text = LbProd.Text
        FrmSeeLote.ShowDialog()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class