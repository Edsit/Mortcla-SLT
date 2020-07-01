Imports C_Entidad
Imports C_Negocio
Public Class FrmSeeLote
    Dim objCe_L As New Ce_Alm_Lotes
    Dim objCn_L As New Cn_Alm_Lotes

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

    Private Sub FrmSeeLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        SeeLotes()
    End Sub

    Private Sub SeeLotes()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_L.Prod = Val(LbConsProd.Text.Trim)
            ds = objCn_L.SeeLotes(objCe_L)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(11)
                    Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(12)
                    Dgv.Item(3, i).Value = ds.Tables(0).Rows(i).Item(13)
                    Dgv.Item(4, i).Value = ds.Tables(0).Rows(i).Item(14)
                    Dgv.Item(5, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(6, i).Value = ds.Tables(0).Rows(i).Item(2)
                    Dgv.Item(7, i).Value = ds.Tables(0).Rows(i).Item(3)
                    Dgv.Item(8, i).Value = ds.Tables(0).Rows(i).Item(4)
                    Dgv.Item(9, i).Value = ds.Tables(0).Rows(i).Item(5)
                    Dgv.Item(10, i).Value = ds.Tables(0).Rows(i).Item(6)
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
            MsgBox("Mostrando Lotes:" & ex.Message)
        End Try
    End Sub
End Class