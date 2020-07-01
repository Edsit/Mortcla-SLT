Imports C_Entidad
Imports C_Negocio
Public Class Frm_Usuario_Buscar
    Dim objCe_U As New Ce_Usuarios
    Dim objCn_U As New Cn_Usuarios

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

   Private Sub TbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If RadioButton1.Checked = True Then
                BuscarUsuariosDoc()
            ElseIf RadioButton2.Checked = True
                BuscarUsuariosNombre()
            ElseIf RadioButton3.Checked = True
                BuscarUsuariosApellido()
            End If
        End If
    End Sub

    Private Sub BuscarUsuariosDoc()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_U.Doc = UCase(TbBuscar.Text.Trim)
            ds = objCn_U.BuscarUsuarioDoc(objCe_U)
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

    Private Sub BuscarUsuariosNombre()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_U.Nombre1 = UCase(TbBuscar.Text.Trim)
            objCe_U.Nombre2 = UCase(TbBuscar.Text.Trim)
            ds = objCn_U.BuscarUsuarioDoc(objCe_U)
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

    Private Sub BuscarUsuariosApellido()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_U.Nombre1 = UCase(TbBuscar.Text.Trim)
            objCe_U.Nombre2 = UCase(TbBuscar.Text.Trim)
            ds = objCn_U.BuscarUsuarioDoc(objCe_U)
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

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        If Bu = 1 Then
            Frm_Usuarios.LbCons.Text = Dgv.Item(0, i).Value
        ElseIf Bu = 2

        End If
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Frm_Usuario_Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        RadioButton1.Checked = True
        BuscarUsuariosDoc()
        TbBuscar.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TbBuscar.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TbBuscar.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TbBuscar.Focus()
    End Sub
End Class