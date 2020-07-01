Imports C_Entidad
Imports C_Negocio
Public Class FrmBajas
    Dim Rojo, Amarillo As Integer
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas
    Dim objCe_Baja As New Ce_Alm_Baja

    Dim ObjCn_MesEstado As New Cn_MesEstado
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCn_Sem As New Cn_Alm_Semaforo
    Dim objCn_E As New Cn_Alm_Entradas
    Dim objCn_S As New Cn_Alm_Salidas
    Dim objCn_TipoSalidas As New Cn_Alm_TipoSalida
    Dim objCn_Baja As New Cn_Alm_Bajas
    'Dim objCn_Empresa As New Cn_Empresa
    Private Sub FrmBajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSemaforo()
        LoadMesActivo()
        LoadMedLotes()
    End Sub

    Sub LoadMesActivo()
        Dim ds As New DataSet
        Try
            ds = ObjCn_MesEstado.LoadMesActivo()
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
            ds = objCn_Sem.ListarSemaforo
            If ds.Tables(0).Rows.Count > 0 Then
                Rojo = ds.Tables(0).Rows(0).Item("Rojo")
                Amarillo = ds.Tables(0).Rows(0).Item("Amarillo")
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Sub LoadMedLotes()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            ds = objCn_L.LoadMedLotesVence(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Dim i1 As Integer = 0
                Do
                    If Vencido(ds.Tables(0).Rows(i).Item(3)) = True Then
                        Dgv.Rows.Add()
                        Dgv.Item(0, i1).Value = ds.Tables(0).Rows(i).Item(0)
                        Dgv.Item(1, i1).Value = ds.Tables(0).Rows(i).Item(1)
                        Dgv.Item(2, i1).Value = ds.Tables(0).Rows(i).Item(2)
                        Dgv.Item(3, i1).Value = Format(ds.Tables(0).Rows(i).Item(3), "MMM/yyyy")
                        Dgv.Item(4, i1).Value = ds.Tables(0).Rows(i).Item(4)
                        Dgv.Item(5, i1).Value = ds.Tables(0).Rows(i).Item(5)
                        Dgv.Item(6, i1).Value = FormatCurrency(ds.Tables(0).Rows(i).Item(6))
                        Dgv.Item(7, i1).Value = Val(Dgv.Item(5, i1).Value) * CDbl(Dgv.Item(6, i1).Value)
                        Dgv.Item(8, i1).Value = ds.Tables(0).Rows(i).Item(7)
                        i1 = i1 + 1
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
            End If
        End Try
    End Sub

    Private Function Vencido(x) As Boolean
        Dim numero As Integer, i As Integer, Cont As Integer
        Dim FECHAD, FECHITA As String
        i = 0 : Cont = 0
        Dim Cf As String, DA As String

        DA = Now.Day
        FECHAD = x
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
            Return False
        End If
        If numero >= (Rojo) And numero <= (Amarillo - 1) Then
            Return False
        End If
        If numero > (Amarillo - 1) Then
            Return False
        End If
        If numero < 0 Then
            Return True
        End If
    End Function

    Sub LoadEntradas()
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do

                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(Dgv.Item(0, i).Value)
                    ds = objCn_E.ListarEntradas(objCe_E)

                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            Dgv.Item(8, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            Dgv.Item(8, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            Dgv.Item(9, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            Dgv.Item(9, i).Value = 0
                        End If
                        Dgv.Item(10, i).Value = Val(Dgv.Item(8, i).Value) * CDbl(Dgv.Item(9, i).Value)
                        Dgv.Item(10, i).Value = Dgv.Item(10, i).Value
                    Else
                        Dgv.Item(8, i).Value = 0
                        Dgv.Item(9, i).Value = Dgv.Item(6, i).Value
                        Dgv.Item(10, i).Value = (0)
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
                    objCe_S.Lote = Val(Dgv.Item(0, i).Value)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            Dgv.Item(11, i).Value = ds.Tables(0).Rows(0).Item(0)
                        End If
                        If Dgv.Item(6, i).Value = 0 Then
                            Dgv.Item(12, i).Value = Dgv.Item(9, i).Value
                        Else
                            If Dgv.Item(9, i).Value = 0 Then
                                Dgv.Item(12, i).Value = Dgv.Item(6, i).Value
                            Else
                                Dgv.Item(12, i).Value = (Dgv.Item(6, i).Value + Dgv.Item(11, i).Value) / 2
                            End If
                        End If
                        'If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                        '    Dgv.Item(13, i).Value = ds.Tables(0).Rows(0).Item(1)
                        'End If
                        Dgv.Item(13, i).Value = Val(Dgv.Item(11, i).Value) * CDbl(Dgv.Item(12, i).Value)
                    Else
                        Dgv.Item(11, i).Value = 0
                        Dgv.Item(12, i).Value = Dgv.Item(9, i).Value
                        Dgv.Item(13, i).Value = (0)
                    End If
                Catch ex As Exception
                Finally
                    ds.Dispose()
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        GuardarBaja()
    End Sub

    Sub SaldoTotal()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Dgv.Item(14, i).Value = Val(Dgv.Item(5, i).Value) + Val(Dgv.Item(8, i).Value) - Val(Dgv.Item(11, i).Value)
                Dgv.Item(15, i).Value = Dgv.Item(12, i).Value
                Dgv.Item(15, i).Value = FormatCurrency(Dgv.Item(15, i).Value)
                Dgv.Item(16, i).Value = Val(Dgv.Item(14, i).Value) * CDbl(Dgv.Item(15, i).Value)
                Dgv.Item(16, i).Value = FormatCurrency(Dgv.Item(16, i).Value)
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Sub GuardarBaja()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                If Dgv.Item(17, i).Value = True And Val(Dgv.Item(14, i).Value) > 0 Then
                    Try ' Acta de baja
                        objCe_Baja.Fecha = Now.Date
                        objCe_Baja.Lote = Dgv.Item(0, i).Value
                        objCe_Baja.Cant = Val(Dgv.Item(14, i).Value)
                        objCe_Baja.Unitario = CDbl(Dgv.Item(15, i).Value)
                        objCe_Baja.Mes = Val(TbConsMes.Text.Trim)
                        objCe_Baja.Año = Val(TbAño.Text.Trim)
                        objCn_Baja.NuevaBaja(objCe_Baja)
                    Catch ex As Exception
                        MsgBox("A ocurrido un error el proceso se detendrá", MsgBoxStyle.Critical)
                        Exit Sub
                    End Try

                    Try ' salida
                        objCe_S.Fecha = Now.Date
                        objCe_S.Mes = Val(TbConsMes.Text)
                        objCe_S.Año = Val(TbAño.Text)
                        objCe_S.Prod = Val(Dgv.Item(18, i).Value)
                        objCe_S.Lote = Dgv.Item(0, i).Value
                        objCe_S.Cant = Val(Dgv.Item(14, i).Value)
                        objCe_S.Unitario = CDbl(Dgv.Item(15, i).Value)
                        objCe_S.TipoSalida = 5
                        objCe_S.Destino = 0
                        objCn_S.NuevaSalida(objCe_S)
                    Catch ex As Exception
                        MsgBox("A ocurrido un error el proceso se detendrá", MsgBoxStyle.Critical)
                        Exit Sub
                    End Try
                End If
                i = i + 1
            Loop Until i = c
            LoadMedLotes()
            MsgBox("Proceso Terminado...", MsgBoxStyle.Information)
        End If
    End Sub
End Class