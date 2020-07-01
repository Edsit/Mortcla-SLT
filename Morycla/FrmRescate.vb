Imports C_Entidad
Imports C_Negocio
Public Class FrmRescate
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas

    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCn_S As New Cn_Alm_Salidas

    Dim objCn_MesEstado As New Cn_MesEstado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Sub LoadMesActivo()
        Dim ds As New DataSet
        Try
            ds = objCn_MesEstado.LoadMesActivo
            If ds.Tables(0).Rows.Count > 0 Then
                TbMesA.Text = ds.Tables(0).Rows(0).Item(0)
                TbMes.Text = ds.Tables(0).Rows(0).Item(1)
                TbAñoA.Text = ds.Tables(0).Rows(0).Item(2)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub LoadLotesActuales()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_L.Año = Val(TbAñoA.Text.Trim)
            objCe_L.Mes = Val(TbMesA.Text.Trim)
            ds = objCn_L.SeeLoteRescate(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    If IsDBNull(ds.Tables(0).Rows(i).Item(3)) = False Then
                        Dgv.Item(2, i).Value = Dgv.Item(2, i).Value & " " & ds.Tables(0).Rows(i).Item(3)
                    End If
                    Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(4)
                    Dgv.Item(4, i).Value = ds.Tables(0).Rows(i).Item(5)

                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(6)
                    Dgv.Item(6, i).Value = ds.Tables(0).Rows(i).Item(7)
                    Dgv.Item(7, i).Value = ds.Tables(0).Rows(i).Item(8)
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try

    End Sub

    Private Sub ListarLoteAnterior()
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                ds = New DataSet
                Try
                    objCe_L.Mes = Val(TbMesB.Text.Trim)
                    objCe_L.Año = Val(TbAñoB.Text.Trim)
                    objCe_L.Lab = Dgv.Item(3, i).Value
                    objCe_L.Prod = Dgv.Item(1, i).Value
                    objCe_L.Lote = Dgv.Item(7, i).Value
                    ds = objCn_L.RescateLoteAnt(objCe_L)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dgv.Item(8, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Dgv.Item(9, i).Value = ds.Tables(0).Rows(0).Item(1)
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub ListarEntradasAnt()
        Dim ds As New DataSet
        Dim c As Integer = Dgv.Rows.Count
        Dim Suma As Double = 0
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Suma = 0
                objCe_E.Lote = Dgv.Item(8, i).Value
                objCe_E.Mes = Val(TbMesB.Text.Trim)
                objCe_E.Año = Val(TbAñoB.Text.Trim)
                ds = objCn_E.Entradasrescate(objCe_E)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim i1 As Integer = 0
                    Do
                        Suma = Suma + Val(ds.Tables(0).Rows(i1).Item(0))
                        i1 = i1 + 1
                    Loop Until i1 = ds.Tables(0).Rows.Count
                Else
                    Suma = 0
                End If
                Dgv.Item(10, i).Value = Suma
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub ListarSalidasAnt()
        Dim ds As New DataSet
        Dim c As Integer = Dgv.Rows.Count
        Dim Suma As Double = 0
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Suma = 0
                objCe_S.Lote = Dgv.Item(8, i).Value
                objCe_S.Mes = Val(TbMesB.Text.Trim)
                objCe_S.Año = Val(TbAñoB.Text.Trim)
                ds = objCn_S.SalidasRescate(objCe_S)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim i1 As Integer = 0
                    Do
                        Suma = Suma + Val(ds.Tables(0).Rows(i1).Item(0))
                        i1 = i1 + 1
                    Loop Until i1 = ds.Tables(0).Rows.Count
                Else
                    Suma = 0
                End If
                Dgv.Item(11, i).Value = Suma
                Dgv.Item(12, i).Value = (Val(Dgv.Item(9, i).Value) + Val(Dgv.Item(10, i).Value)) - Val(Dgv.Item(11, i).Value)
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub FrmRescate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        LoadMesActivo()
        LoadLotesActuales()
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        ListarLoteAnterior()
        ListarEntradasAnt()
        ListarSalidasAnt()
        DiferenciarCantidad()
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        MsgBox("Proceso Terminado", MsgBoxStyle.Information)
    End Sub

    Private Sub DiferenciarCantidad()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                If Dgv.Item(4, i).Value <> Dgv.Item(12, i).Value Then
                    Dgv.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    Dgv.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Actualizar()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                If Dgv.Item(4, i).Value <> Dgv.Item(12, i).Value Then
                    Try
                        objCe_L.Cons = Dgv.Item(0, i).Value
                        objCe_L.Ini = Dgv.Item(12, i).Value
                        objCn_L.ModificarCantIniLote(objCe_L)
                        Dgv.Item(13, i).Value = "SI"
                    Catch ex As Exception
                    End Try
                End If
                i = i + 1
            Loop Until i = c
        End If
        MsgBox("Proceso Terminado...", MsgBoxStyle.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Confirma que desea actualziar los lotes??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Actualizar()
        End If
    End Sub
End Class