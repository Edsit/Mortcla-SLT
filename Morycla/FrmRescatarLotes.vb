Imports C_Entidad
Imports C_Negocio
Public Class FrmRescatarLotes
    Dim objCe_MesEstado As New Ce_MesEstado
    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCn_Sem As New Cn_Alm_Semaforo
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCn_P As New Cn_Alm_Productos

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

    Private Sub ListarLotesMesActivo()
        Dim ds As New DataSet
        Dgv1.Rows.Clear()
        Try
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            ds = objCn_L.SeeLotesRescate(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv1.Rows.Add()
                    Dgv1.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv1.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv1.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv1.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                    Dgv1.Item(4, i).Value = ds.Tables(0).Rows(i).Item(4)
                    Dgv1.Item(5, i).Value = ds.Tables(0).Rows(i).Item(5)
                    Dgv1.Item(6, i).Value = ds.Tables(0).Rows(i).Item(6)
                    Dgv1.Item(7, i).Value = ds.Tables(0).Rows(i).Item(7)
                    Dgv1.Item(8, i).Value = ds.Tables(0).Rows(i).Item(8)
                    Dgv1.Item(9, i).Value = ds.Tables(0).Rows(i).Item(9)
                    Dgv1.Item(10, i).Value = ds.Tables(0).Rows(i).Item(10)
                    Dgv1.Item(11, i).Value = ds.Tables(0).Rows(i).Item(11)
                    Dgv1.Item(12, i).Value = ds.Tables(0).Rows(i).Item(12)
                    Dgv1.Item(13, i).Value = ds.Tables(0).Rows(i).Item(13)
                    Dgv1.Item(14, i).Value = ds.Tables(0).Rows(i).Item(14)
                    Dgv1.Item(15, i).Value = ds.Tables(0).Rows(i).Item(15)
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            LbDgv1.Text = Dgv1.Rows.Count
        End Try
    End Sub

    Sub LoadEntradas1()
        Dim ds As DataSet
        Dim c As Integer = Dgv1.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(Dgv1.Item(0, i).Value)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dgv1.Item(16, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Dgv1.Item(17, i).Value = FormatCurrency(ds.Tables(0).Rows(0).Item(1))
                    Else
                        Dgv1.Item(16, i).Value = 0
                        Dgv1.Item(17, i).Value = Dgv1.Item(8, i).Value

                    End If
                    My.Application.DoEvents()
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadSalidas1()
        Dim ds As DataSet
        Dim c As Integer = Dgv1.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_S.Lote = Val(Dgv1.Item(0, i).Value)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dgv1.Item(18, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Dgv1.Item(19, i).Value = ds.Tables(0).Rows(0).Item(1)
                    Else
                        Dgv1.Item(18, i).Value = 0
                        Dgv1.Item(19, i).Value = Dgv1.Item(11, i).Value
                    End If
                    My.Application.DoEvents()
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub SaldoTotal1()
        On Error Resume Next
        Dim c As Integer = Dgv1.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Dgv1.Item(20, i).Value = Val(Dgv1.Item(7, i).Value) + Val(Dgv1.Item(16, i).Value) - Val(Dgv1.Item(18, i).Value)
                Dgv1.Item(21, i).Value = Dgv1.Item(19, i).Value
                i = i + 1
                My.Application.DoEvents()
            Loop Until i = c
        End If
    End Sub

    Private Sub FrmRescatarLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbDgv1.Text = "" : LbDgv2.Text = "" : LbDgv3.Text = ""
        LoadMesActivo()
        ListarLotesMesActivo()
        LoadEntradas1()
        LoadSalidas1()
        SaldoTotal1()
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dgv3.Rows.Clear()
        LbDgv3.Text = ""
        ListarLotes2()
        LoadEntradas2()
        LoadSalidas2()
        SaldoTotal2()
        ValidarLotes()
    End Sub

    Private Sub BtnSeleccionar_MouseHover(sender As Object, e As EventArgs) Handles BtnSeleccionar.MouseHover
        BtnSeleccionar.ForeColor = Color.White
    End Sub

    Private Sub BtnSeleccionar_MouseLeave(sender As Object, e As EventArgs) Handles BtnSeleccionar.MouseLeave
        BtnSeleccionar.ForeColor = Color.Black
    End Sub

    Private Sub ListarLotes2()
        Dim ds As New DataSet
        Dgv2.Rows.Clear()
        Try
            objCe_L.Mes = Val(TbConsMesSel.Text.Trim)
            objCe_L.Año = Val(TbAñoSel.Text.Trim)
            ds = objCn_L.SeeLotesRescate(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv2.Rows.Add()
                    Dgv2.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv2.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv2.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv2.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                    Dgv2.Item(4, i).Value = ds.Tables(0).Rows(i).Item(4)
                    Dgv2.Item(5, i).Value = ds.Tables(0).Rows(i).Item(5)
                    Dgv2.Item(6, i).Value = ds.Tables(0).Rows(i).Item(6)
                    Dgv2.Item(7, i).Value = ds.Tables(0).Rows(i).Item(7)
                    Dgv2.Item(8, i).Value = ds.Tables(0).Rows(i).Item(8)
                    Dgv2.Item(9, i).Value = ds.Tables(0).Rows(i).Item(9)
                    Dgv2.Item(10, i).Value = ds.Tables(0).Rows(i).Item(10)
                    Dgv2.Item(11, i).Value = ds.Tables(0).Rows(i).Item(11)
                    Dgv2.Item(12, i).Value = ds.Tables(0).Rows(i).Item(12)
                    Dgv2.Item(13, i).Value = ds.Tables(0).Rows(i).Item(13)
                    Dgv2.Item(14, i).Value = ds.Tables(0).Rows(i).Item(14)
                    Dgv2.Item(15, i).Value = ds.Tables(0).Rows(i).Item(15)

                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            LbDgv2.Text = Dgv2.Rows.Count
        End Try
    End Sub

    Sub LoadEntradas2()
        Dim ds As DataSet
        Dim c As Integer = Dgv2.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(Dgv2.Item(0, i).Value)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dgv2.Item(16, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Dgv2.Item(17, i).Value = (ds.Tables(0).Rows(0).Item(1))
                    Else
                        Dgv2.Item(16, i).Value = 0
                        Dgv2.Item(17, i).Value = Dgv2.Item(8, i).Value

                    End If
                    My.Application.DoEvents()
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub LoadSalidas2()
        Dim ds As DataSet
        Dim c As Integer = Dgv2.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_S.Lote = Val(Dgv2.Item(0, i).Value)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dgv2.Item(18, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Dgv2.Item(19, i).Value = ds.Tables(0).Rows(0).Item(1)
                    Else
                        Dgv2.Item(18, i).Value = 0
                        Dgv2.Item(19, i).Value = Dgv2.Item(8, i).Value
                    End If
                    My.Application.DoEvents()
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Sub SaldoTotal2()
        On Error Resume Next
        Dim c As Integer = Dgv2.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Dgv2.Item(20, i).Value = (Val(Dgv2.Item(7, i).Value) + Val(Dgv2.Item(16, i).Value)) - Val(Dgv2.Item(18, i).Value)
                Dgv2.Item(21, i).Value = Dgv2.Item(19, i).Value
                i = i + 1
                My.Application.DoEvents()
            Loop Until i = c
        End If
    End Sub

    Private Sub ValidarLotes()
        Dgv3.Rows.Clear()
        Dim c As Integer = Dgv2.Rows.Count
        Dim c1 As Integer = 0
        Dim i1 As Integer = 0
        Dim existe As Boolean
        If c > 0 Then
            Dim i As Integer = 0
            Do
                existe = False
                c1 = Dgv1.Rows.Count
                If c1 > 0 Then
                    i1 = 0
                    Do
                        If (Dgv2.Item(1, i).Value = Dgv1.Item(1, i1).Value) And (Dgv2.Item(3, i).Value = Dgv1.Item(3, i1).Value) And (Dgv2.Item(4, i).Value = Dgv1.Item(4, i1).Value) Then
                            existe = True
                        End If
                        i1 = i1 + 1
                    Loop Until i1 = c1
                Else
                    existe = False
                End If
                If existe = False Then
                    'Funcion para pasar el lote a dgv3
                    If Dgv2.Item(20, i).Value > 0 Then
                        PasarLote(i)
                    End If
                End If
                i = i + 1
            Loop Until i = c
        End If
        LbDgv3.Text = Dgv3.Rows.Count
    End Sub

    Private Function PasarLote(x As Integer)
        Dgv3.Rows.Add()
        Dgv3.Item(0, Dgv3.Rows.Count - 1).Value = Dgv2.Item(0, x).Value
        Dgv3.Item(1, Dgv3.Rows.Count - 1).Value = Dgv2.Item(1, x).Value
        Dgv3.Item(2, Dgv3.Rows.Count - 1).Value = Dgv2.Item(2, x).Value
        Dgv3.Item(3, Dgv3.Rows.Count - 1).Value = Dgv2.Item(3, x).Value
        Dgv3.Item(4, Dgv3.Rows.Count - 1).Value = Dgv2.Item(4, x).Value
        Dgv3.Item(5, Dgv3.Rows.Count - 1).Value = Dgv2.Item(5, x).Value
        Dgv3.Item(6, Dgv3.Rows.Count - 1).Value = Dgv2.Item(6, x).Value
        Dgv3.Item(7, Dgv3.Rows.Count - 1).Value = Dgv2.Item(20, x).Value

        Dgv3.Item(8, Dgv3.Rows.Count - 1).Value = Dgv2.Item(21, x).Value

        If Val(Dgv2.Item(21, x).Value) = 0 Then
            Dgv3.Item(8, Dgv3.Rows.Count - 1).Value = Dgv2.Item(19, x).Value
        End If

        If Val(Dgv2.Item(19, x).Value) = 0 Then
            Dgv3.Item(8, Dgv3.Rows.Count - 1).Value = Dgv2.Item(17, x).Value
        End If

        If Val(Dgv2.Item(17, x).Value) = 0 Then
            Dgv3.Item(8, Dgv3.Rows.Count - 1).Value = Dgv2.Item(8, x).Value
        End If

        Dgv3.Item(9, Dgv3.Rows.Count - 1).Value = Dgv2.Item(9, x).Value
        Dgv3.Item(10, Dgv3.Rows.Count - 1).Value = Dgv2.Item(10, x).Value
        Dgv3.Item(11, Dgv3.Rows.Count - 1).Value = Dgv2.Item(11, x).Value
        Dgv3.Item(12, Dgv3.Rows.Count - 1).Value = Dgv2.Item(12, x).Value
        Dgv3.Item(13, Dgv3.Rows.Count - 1).Value = Dgv2.Item(13, x).Value
        Dgv3.Item(14, Dgv3.Rows.Count - 1).Value = Dgv2.Item(14, x).Value
        Dgv3.Item(15, Dgv3.Rows.Count - 1).Value = Dgv2.Item(15, x).Value
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Confirma que desea reestablecer los lotes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim c As Integer = Dgv3.Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Try
                        objCe_L.Prod = Val(Dgv3.Item(1, i).Value)
                        objCe_L.Lab = Val(Dgv3.Item(3, i).Value)
                        If IsDBNull(UCase(Dgv3.Item(4, i).Value)) = False Then
                            objCe_L.Lote = UCase(Dgv3.Item(4, i).Value)
                        End If
                        If IsDBNull(UCase(Dgv3.Item(5, i).Value)) = False Then
                            objCe_L.Invima = UCase(Dgv3.Item(5, i).Value)
                        End If
                        If IsDBNull(UCase(Dgv3.Item(2, i).Value)) = False Then
                            objCe_L.Cum = UCase(Dgv3.Item(2, i).Value)
                        End If

                        objCe_L.Vence = CDate(Dgv3.Item(6, i).Value)

                        If IsDBNull(UCase(Dgv3.Item(9, i).Value)) = False Then
                            objCe_L.Serial = UCase(Dgv3.Item(9, i).Value)
                        End If
                        If IsDBNull(UCase(Dgv3.Item(10, i).Value)) = False Then
                            objCe_L.VUtil = UCase(Dgv3.Item(10, i).Value)
                        End If

                        objCe_L.Ini = Val(Dgv3.Item(7, i).Value)
                        objCe_L.Unitario = CDbl(Dgv3.Item(8, i).Value)
                        objCe_L.Mes = Val(TbConsMes.Text.Trim)
                        objCe_L.Año = Val(TbAño.Text.Trim)
                        objCe_L.Entrada = Val(Dgv3.Item(14, i).Value)

                        If IsDBNull((Dgv3.Item(11, i).Value)) = False Then
                            objCe_L.Obs = (Dgv3.Item(11, i).Value)
                        End If

                        objCe_L.Almacen = Val(Dgv3.Item(15, i).Value)
                        objCn_L.NuevoLote(objCe_L)
                    Catch ex As Exception
                    End Try
                    i = i + 1
                Loop Until i = c
                MsgBox("Proceso Terminado", MsgBoxStyle.Information)
                BtnSeleccionar.PerformClick()
            End If
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
    End Sub
End Class