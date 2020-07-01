Imports C_Entidad
Imports C_Negocio
Public Class Frm_AddEnfoqueUsuario
    Dim Op As String = ""
    Dim objCe_E As New Cn_Enfoques

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarEnfopquesActivos()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCe_E.ListarEnfoquesActivos
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Frm_AddEnfoqueUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarEnfopquesActivos()
    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        On Error Resume Next
        If Dgv.Rows.Count > 0 Then
            Dim i As Integer = Dgv.CurrentRow.Index
            If Ya_existe(Dgv.Item(1, i).Value) = False Then
                Frm_Usuarios.Dgv.Rows.Add()
                Frm_Usuarios.Dgv.Item(1, Frm_Usuarios.Dgv.Rows.Count - 1).Value = Dgv.Item(0, i).Value
                Frm_Usuarios.Dgv.Item(2, Frm_Usuarios.Dgv.Rows.Count - 1).Value = Dgv.Item(1, i).Value
                Me.Dispose()
                Me.Close()
            Else
                MsgBox("El enfoque ya ha sido agregado", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Function Ya_existe(x) As Boolean
        Dim c As Integer = Frm_Usuarios.Dgv.Rows.Count
        Dim i As Integer = 0
        Dim ya As Boolean = False
        Do
            If UCase(Frm_Usuarios.Dgv.Item(2, i).Value) = UCase(x) Then
                ya = True
            End If
            i = i + 1
        Loop Until i = c
        Return ya
    End Function
End Class