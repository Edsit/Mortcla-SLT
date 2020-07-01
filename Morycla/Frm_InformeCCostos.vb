Imports C_Entidad
Imports C_Negocio
Public Class Frm_InformeCCostos
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes
    Dim objCe_P As New Ce_Alm_Productos
    Dim objCe_E As New Ce_Alm_Entradas
    Dim objCe_S As New Ce_Alm_Salidas

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Frm_InformeCCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbAño.Text = Now.Year
        TbMes.Text = Now.Month
    End Sub

    Private Sub ListarInicial()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_L.Mes = Val(TbMes.Text.Trim)
            objCe_L.Año = Val(TbAño.Text.Trim)
            ds = objCn_L.ValorInicialCentroCostos(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(2, i).Value = FormatCurrency(ds.Tables(0).Rows(i).Item(2))
                    i = i + 1
                Loop Until i = c
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarEntradas()
        Dim r As Integer = Dgv.Rows.Count
        If r > 0 Then
            Dim i As Integer = 0
            Do
                If IsDBNull(Dgv.Item(0, i).Value) = False Then
                    Dgv.Item(3, i).Value = FormatCurrency(VerEntrada(Dgv.Item(0, i).Value))
                End If
                i = i + 1
            Loop Until i = r
        End If
    End Sub

    Private Function VerEntrada(x) As Integer
        Dim ds As New DataSet
        Try
            objCe_E.Mes = Val(TbMes.Text.Trim)
            objCe_E.Año = Val(TbAño.Text.Trim)
            objCe_P.CCostos = Val(x)
            ds = objCn_L.ValorEntradasCentroCostos(objCe_E, objCe_P)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
        Finally
        End Try
    End Function

    Private Sub ListarSalidas()
        Dim r As Integer = Dgv.Rows.Count
        If r > 0 Then
            Dim i As Integer = 0
            Do
                If IsDBNull(Dgv.Item(0, i).Value) = False Then
                    Dgv.Item(4, i).Value = FormatCurrency(VerSalidas(Dgv.Item(0, i).Value))
                End If
                i = i + 1
            Loop Until i = r
        End If
    End Sub

    Private Function VerSalidas(x) As Integer
        Dim ds As New DataSet
        Try
            objCe_S.Mes = Val(TbMes.Text.Trim)
            objCe_S.Año = Val(TbAño.Text.Trim)
            objCe_P.CCostos = Val(x)
            ds = objCn_L.ValorsALIDASCentroCostos(objCe_S, objCe_P)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
        Finally
        End Try
    End Function

    Private Sub Saldo()
        Dim r As Integer = Dgv.Rows.Count
        If r > 0 Then
            Dim i As Integer = 0
            Do
                If IsDBNull(Dgv.Item(0, i).Value) = False Then
                    Dgv.Item(5, i).Value = FormatCurrency((CDbl(Dgv.Item(2, i).Value) + CDbl(Dgv.Item(3, i).Value)) - CDbl(Dgv.Item(4, i).Value))
                End If
                i = i + 1
            Loop Until i = r
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListarInicial()
        ListarEntradas()
        ListarSalidas()
        Saldo()
    End Sub
End Class