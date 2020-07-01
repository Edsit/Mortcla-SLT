Imports C_Entidad
Imports C_Negocio
Public Class FrmArregloLotesAbril
    Dim Cons, Lab As Integer
    Dim Cum, Lote, Invima As String

    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub LoadLotes()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_L.Mes = 4
            objCe_L.Año = 2020
            ds = objCn_L.VerLotesArreglar(objCe_L)
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VerLoteBueno()
        MsgBox("Proceso terminado...", MsgBoxStyle.Information)
        LoadLotes()
    End Sub

    Private Sub FrmArregloLotesAbril_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLotes()

    End Sub

    Private Sub VerLoteBueno()
        Dim ds As DataSet
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                Cons = 0
                Cum = ""
                Lab = 0
                Lote = ""
                Invima = ""
                Try
                    objCe_L.Prod = Val(Dgv.Item(1, i).Value)
                    objCe_L.Lote = (Dgv.Item(5, i).Value)
                    ds = New DataSet
                    ds = objCn_L.VerLotesBuenoArreglar(objCe_L)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Cons = Val(Dgv.Item(0, i).Value)
                        If IsDBNull(ds.Tables(0).Rows(0).Item(2)) = False Then
                            Cum = ds.Tables(0).Rows(0).Item(2)
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(3)) = False Then
                            Lab = ds.Tables(0).Rows(0).Item(3)
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(4)) = False Then
                            Lote = ds.Tables(0).Rows(0).Item(4)
                        End If
                        If IsDBNull(ds.Tables(0).Rows(0).Item(5)) = False Then
                            Invima = ds.Tables(0).Rows(0).Item(5)
                        End If
                        ActualziarLote()
                    End If
                Catch ex As Exception
                End Try
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub ActualziarLote()
        Try
            objCe_L.Cons = Cons
            objCe_L.Cum = Cum
            objCe_L.Lab = Lab
            objCe_L.Lote = Lote
            objCe_L.Invima = Invima
            objCn_L.ActualziarLoteMalosAbril(objCe_L)
        Catch ex As Exception
        End Try
    End Sub

End Class