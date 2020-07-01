Imports C_Entidad
Imports C_Negocio
Public Class FrmCierre
    Dim ContA As Integer = 0
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

    Private Sub FrmCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbProgres.Text = ""
        LoadMesActivo()
        LoadMedLotesKardex()
        LoadMqLotesKardex()
    End Sub

    Sub LoadNumMes()
        If CbMes.Text = "ENERO" Then
            TbConsMes1.Text = "01"
        ElseIf CbMes.Text = "FEBRERO" Then
            TbConsMes1.Text = "02"
        ElseIf CbMes.Text = "MARZO" Then
            TbConsMes1.Text = "03"
        ElseIf CbMes.Text = "ABRIL" Then
            TbConsMes1.Text = "04"
        ElseIf CbMes.Text = "MAYO" Then
            TbConsMes1.Text = "05"
        ElseIf CbMes.Text = "JUNIO" Then
            TbConsMes1.Text = "06"
        ElseIf CbMes.Text = "JULIO" Then
            TbConsMes1.Text = "07"
        ElseIf CbMes.Text = "AGOSTO" Then
            TbConsMes1.Text = "08"
        ElseIf CbMes.Text = "SEPTIEMBRE" Then
            TbConsMes1.Text = "09"
        ElseIf CbMes.Text = "OCTUBRE" Then
            TbConsMes1.Text = "10"
        ElseIf CbMes.Text = "NOVIEMBRE" Then
            TbConsMes1.Text = "11"
        ElseIf CbMes.Text = "DICIEMBRE" Then
            TbConsMes1.Text = "12"
        End If
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

    Sub LoadMedLotesKardex()
        Dim ds As New DataSet
        LbAvance.Text = ""
        Try
            DgvMed.Rows.Clear()
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            objCe_P.TipoProd = 1
            ds = objCn_L.ListarLotesMedKardexCierre(objCe_L, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                LbAvance.Text = "Procesados " & ContA & " de " & c
                Dim i As Integer = 0
                Do
                    DgvMed.Rows.Add()
                    DgvMed.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    DgvMed.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    DgvMed.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    DgvMed.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                    DgvMed.Item(4, i).Value = ds.Tables(0).Rows(i).Item(4)
                    DgvMed.Item(5, i).Value = ds.Tables(0).Rows(i).Item(5)
                    DgvMed.Item(6, i).Value = Format(ds.Tables(0).Rows(i).Item(6), "dd/MM/yyyy")
                    DgvMed.Item(7, i).Value = ds.Tables(0).Rows(i).Item(7)
                    DgvMed.Item(8, i).Value = ds.Tables(0).Rows(i).Item(8)
                    DgvMed.Item(9, i).Value = ds.Tables(0).Rows(i).Item(9)
                    If IsDBNull(ds.Tables(0).Rows(i).Item(10)) = False Then
                        DgvMed.Item(19, i).Value = ds.Tables(0).Rows(i).Item(10)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(11)) = False Then
                        DgvMed.Item(20, i).Value = ds.Tables(0).Rows(i).Item(11)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(12)) = False Then
                        DgvMed.Item(21, i).Value = ds.Tables(0).Rows(i).Item(12)
                    End If
                    i = i + 1
                    My.Application.DoEvents()
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If DgvMed.Rows.Count > 0 Then
                LoadEntradas()
                LoadSalidas()
                SaldoTotal()
            End If
        End Try
    End Sub

    Sub LoadEntradas()
        Dim ds As DataSet
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(DgvMed.Item(0, i).Value)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMed.Item(10, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMed.Item(10, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            DgvMed.Item(11, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            If CDbl(DgvMed.Item(8, i).Value > 0) Then
                                DgvMed.Item(11, i).Value = DgvMed.Item(8, i).Value
                            Else
                                DgvMed.Item(11, i).Value = 0
                            End If
                        End If
                        DgvMed.Item(12, i).Value = CDbl(DgvMed.Item(10, i).Value) * CDbl(DgvMed.Item(11, i).Value)
                    Else
                        DgvMed.Item(10, i).Value = 0
                        DgvMed.Item(11, i).Value = DgvMed.Item(8, i).Value
                        DgvMed.Item(12, i).Value = (0)
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

    Sub LoadSalidas()
        Dim ds As DataSet
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_S.Lote = Val(DgvMed.Item(0, i).Value)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMed.Item(13, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMed.Item(13, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            DgvMed.Item(14, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            If CDbl(DgvMed.Item(11, i).Value) > 0 Then
                                DgvMed.Item(14, i).Value = DgvMed.Item(11, i).Value
                            ElseIf CDbl(DgvMed.Item(8, i).Value) > 0 Then
                                DgvMed.Item(14, i).Value = DgvMed.Item(8, i).Value
                            Else
                                DgvMed.Item(14, i).Value = 0
                            End If
                        End If
                        DgvMed.Item(15, i).Value = CDbl(DgvMed.Item(13, i).Value) * CDbl(DgvMed.Item(14, i).Value)
                    Else
                        DgvMed.Item(13, i).Value = 0
                        DgvMed.Item(14, i).Value = DgvMed.Item(8, i).Value
                        DgvMed.Item(15, i).Value = (0)
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

    Sub SaldoTotal()
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                DgvMed.Item(16, i).Value = Val(DgvMed.Item(7, i).Value) + Val(DgvMed.Item(10, i).Value) - Val(DgvMed.Item(13, i).Value)
                DgvMed.Item(17, i).Value = DgvMed.Item(14, i).Value
                DgvMed.Item(18, i).Value = CDbl(DgvMed.Item(16, i).Value) * CDbl(DgvMed.Item(17, i).Value)
                i = i + 1
                My.Application.DoEvents()
            Loop Until i = c
        End If
    End Sub


    Sub LoadMqLotesKardex()
        Dim ds As New DataSet
        Try
            DgvMq.Rows.Clear()
            objCe_L.Mes = Val(TbConsMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            ds = objCn_L.ListarLotesMQKardexCierre(objCe_L, objCe_P)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    DgvMq.Rows.Add()
                    DgvMq.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    DgvMq.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    DgvMq.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    DgvMq.Item(3, i).Value = ds.Tables(0).Rows(i).Item(3)
                    DgvMq.Item(4, i).Value = ds.Tables(0).Rows(i).Item(4)
                    DgvMq.Item(5, i).Value = ds.Tables(0).Rows(i).Item(5)
                    DgvMq.Item(6, i).Value = Format(ds.Tables(0).Rows(i).Item(6), "dd/MM/yyyy")
                    DgvMq.Item(7, i).Value = ds.Tables(0).Rows(i).Item(7)
                    DgvMq.Item(8, i).Value = ds.Tables(0).Rows(i).Item(8)
                    DgvMq.Item(9, i).Value = ds.Tables(0).Rows(i).Item(9)
                    DgvMq.Item(10, i).Value = ds.Tables(0).Rows(i).Item(10)
                    If IsDBNull(ds.Tables(0).Rows(i).Item(11)) = False Then
                        DgvMq.Item(20, i).Value = ds.Tables(0).Rows(i).Item(11)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(12)) = False Then
                        DgvMq.Item(21, i).Value = ds.Tables(0).Rows(i).Item(12)
                    End If
                    If IsDBNull(ds.Tables(0).Rows(i).Item(13)) = False Then
                        DgvMq.Item(22, i).Value = ds.Tables(0).Rows(i).Item(13)
                    End If
                    i = i + 1
                    My.Application.DoEvents()
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
            If DgvMq.Rows.Count > 0 Then
                LoadEntradasMq()
                LoadSalidasMq()
                SaldoTotalMq()
            End If
        End Try
    End Sub


    Sub LoadEntradasMq()
        Dim ds As DataSet
        Dim c As Integer = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_E.Lote = Val(DgvMq.Item(0, i).Value)
                    ds = objCn_E.ListarEntradas(objCe_E)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMq.Item(11, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMq.Item(11, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            DgvMq.Item(12, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            If CDbl(DgvMq.Item(9, i).Value) > 0 Then
                                DgvMq.Item(12, i).Value = DgvMq.Item(9, i).Value
                            Else
                                DgvMq.Item(12, i).Value = 0
                            End If
                        End If
                        DgvMq.Item(13, i).Value = Val(DgvMq.Item(11, i).Value) * CDbl(DgvMq.Item(12, i).Value)
                    Else
                        DgvMq.Item(11, i).Value = 0
                        DgvMq.Item(12, i).Value = DgvMq.Item(8, i).Value
                        DgvMq.Item(13, i).Value = (0)
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

    Sub LoadSalidasMq()
        Dim ds As DataSet
        Dim c As Integer = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Try
                    ds = New DataSet
                    objCe_S.Lote = Val(DgvMq.Item(0, i).Value)
                    ds = objCn_S.ListarSalidas(objCe_S)
                    If ds.Tables(0).Rows.Count > 0 Then
                        If IsDBNull(ds.Tables(0).Rows(0).Item(0)) = False Then
                            DgvMq.Item(14, i).Value = ds.Tables(0).Rows(0).Item(0)
                        Else
                            DgvMq.Item(14, i).Value = 0
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                            DgvMq.Item(15, i).Value = ds.Tables(0).Rows(0).Item(1)
                        Else
                            If CDbl(DgvMq.Item(12, i).Value) > 0 Then
                                DgvMq.Item(15, i).Value = DgvMq.Item(12, i).Value
                            ElseIf CDbl(DgvMq.Item(9, i).Value) > 0 Then
                                DgvMq.Item(15, i).Value = DgvMq.Item(9, i).Value
                            Else
                                DgvMq.Item(15, i).Value = 0
                            End If
                        End If
                        DgvMq.Item(16, i).Value = CDbl(DgvMq.Item(14, i).Value) * CDbl(DgvMq.Item(15, i).Value)
                    Else
                        DgvMq.Item(14, i).Value = 0
                        DgvMq.Item(15, i).Value = DgvMq.Item(8, i).Value
                        DgvMq.Item(16, i).Value = (0)
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

    Sub SaldoTotalMq()
        Dim c As Integer = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                DgvMq.Item(17, i).Value = CDbl(DgvMq.Item(8, i).Value) + CDbl(DgvMq.Item(11, i).Value) - CDbl(DgvMq.Item(14, i).Value)
                DgvMq.Item(18, i).Value = DgvMq.Item(15, i).Value
                DgvMq.Item(19, i).Value = CDbl(DgvMq.Item(17, i).Value) * CDbl(DgvMq.Item(18, i).Value)
                i = i + 1
                My.Application.DoEvents()
            Loop Until i = c
        End If
    End Sub

    Private Sub BtnCerrarMes_Click(sender As Object, e As EventArgs) Handles BtnCerrarMes.Click
        If Val(TbConsMes.Text.Trim) = Val(TbConsMes1.Text.Trim) And Val(TbAño.Text.Trim) = Val(TbAño1.Text.Trim) Then
            MsgBox("El nuevo mes activo no puede ser igual al mes activo", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Realizó copia de seguridad?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            MsgBox("Debe realizar una copia de seguridad antes del cierre", MsgBoxStyle.Information)
            Exit Sub
        End If
        LbProgres.Text = ""
        LbProgres.Visible = True
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = DgvMed.Rows.Count
        'CERRAR MEDICAMENTOS
        Dim c As Integer = DgvMed.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            LbProgres.Text = "Procesando 1 de 2"
            Do
                If Val(DgvMed.Item(16, i).Value) > 0 Then
                    Try
                        objCe_L.Prod = Val(DgvMed.Item(1, i).Value)
                        objCe_L.Lab = Val(DgvMed.Item(3, i).Value)
                        objCe_L.Lote = DgvMed.Item(4, i).Value
                        objCe_L.Invima = DgvMed.Item(5, i).Value
                        objCe_L.Cum = DgvMed.Item(2, i).Value
                        objCe_L.Vence = DgvMed.Item(6, i).Value
                        objCe_L.Ini = DgvMed.Item(16, i).Value
                        objCe_L.Unitario = DgvMed.Item(17, i).Value
                        objCe_L.Obs = DgvMed.Item(19, i).Value
                        objCe_L.Mes = Val(TbConsMes1.Text.Trim)
                        objCe_L.Año = Val(TbAño1.Text.Trim)
                        objCe_L.Entrada = Val(DgvMed.Item(20, i).Value)
                        objCe_L.Almacen = Val(DgvMed.Item(21, i).Value)
                        objCn_L.NuevoLote(objCe_L)
                    Catch ex As Exception
                        MsgBox("Nuevo Lote Med: " & ex.Message)
                    End Try
                End If
                My.Application.DoEvents()
                i = i + 1
                ProgressBar1.Value = i
            Loop Until i = c
        End If
        'CERRAR LOS OTROS LOTES
        c = DgvMq.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            LbProgres.Text = "Procesando 2 de 2"
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = DgvMq.Rows.Count
            Do
                If Val(DgvMq.Item(17, i).Value) > 0 Then
                    Try
                        objCe_L.Prod = Val(DgvMq.Item(1, i).Value)
                        objCe_L.Serial = Val(DgvMq.Item(2, i).Value)
                        objCe_L.Lab = DgvMq.Item(3, i).Value
                        objCe_L.Lote = DgvMq.Item(4, i).Value
                        objCe_L.Invima = DgvMq.Item(5, i).Value
                        objCe_L.Vence = DgvMq.Item(6, i).Value
                        objCe_L.VUtil = DgvMq.Item(7, i).Value
                        objCe_L.Ini = DgvMq.Item(17, i).Value
                        objCe_L.Unitario = DgvMq.Item(18, i).Value
                        objCe_L.Obs = DgvMq.Item(20, i).Value
                        objCe_L.Mes = Val(TbConsMes1.Text.Trim)
                        objCe_L.Año = Val(TbAño1.Text.Trim)
                        objCe_L.Entrada = DgvMq.Item(21, i).Value
                        objCe_L.Almacen = DgvMq.Item(22, i).Value
                        objCn_L.NuevoLote(objCe_L)
                    Catch ex As Exception
                        MsgBox("Nuevo Lote Mq: " & ex.Message)
                    End Try
                End If
                i = i + 1
                My.Application.DoEvents()
                ProgressBar1.Value = i
            Loop Until i = c
        End If
        Try
            objCe_MesEstado.Mes = Val(TbConsMes.Text.Trim)
            objCe_MesEstado.Año = Val(TbAño.Text.Trim)
            ObjCn_MesEstado.EditMesActivo(objCe_MesEstado)
        Catch ex As Exception
            MsgBox("Editar Mes Activo: " & ex.Message)
        End Try
        Try
            objCe_MesEstado.Mes = Val(TbConsMes1.Text.Trim)
            objCe_MesEstado.Año = Val(TbAño1.Text.Trim)
            objCe_MesEstado.Estado = "ACTIVO"
            ObjCn_MesEstado.NuevoMesActivo(objCe_MesEstado)
        Catch ex As Exception
            MsgBox("Nuevo Mes Activo: " & ex.Message)
        End Try
        LbProgres.Visible = False
        LbProgres.Text = ""
        ProgressBar1.Visible = False
        MsgBox("El cierre se ha realizado satisfactoriamente", MsgBoxStyle.Information)
        MsgBox("Proceso terminado, debe reiniciar la aplicación para actualziar los cambios", MsgBoxStyle.Information)
    End Sub

    Private Sub CbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMes.SelectedIndexChanged
        LoadNumMes()
    End Sub

    Private Sub CbMes_Click(sender As Object, e As EventArgs) Handles CbMes.Click
        LoadNumMes()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        FrmRescatarLotes.ShowDialog()
    End Sub
End Class