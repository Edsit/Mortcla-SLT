Imports C_Entidad
Imports C_Negocio
Public Class Frm_Areas
    Dim Op As String = ""
    Dim objCe_A As New Ce_Areas
    Dim objCn_A As New Cn_Areas

    Private Sub Botones1()
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = True
    End Sub

    Private Sub Botones2()
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Habilitar()
        TbArea.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbArea.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbArea.Text = ""
        CbEstado.Text = ""
    End Sub

    Private Sub Frm_Areas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Inhabilitar()
        Limpiar()
        ListarAreas()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Op = "N"
        Botones2()
        Limpiar()
        Habilitar()
        TbArea.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Op = "A"
        Botones2()
        Habilitar()
        TbArea.Focus()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        TbArea.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub

    Private Sub Nuevo()
        If TbArea.Text.Trim = "" Then
            MsgBox("Debe ingresar el área", MsgBoxStyle.Critical)
            TbArea.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea registrar el área?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_A.Area = UCase(TbArea.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_A.Estado = 1 : Else : objCe_A.Estado = 0 : End If
                objCn_A.NuevArea(objCe_A)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarAreas()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Actualizar()
        If TbArea.Text.Trim = "" Then
            MsgBox("Debe ingresar el área", MsgBoxStyle.Critical)
            TbArea.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el área?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_A.Cons = Val(TbCons.Text.Trim)
                objCe_A.Area = UCase(TbArea.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_A.Estado = 1 : Else : objCe_A.Estado = 0 : End If
                objCn_A.EditarArea(objCe_A)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarAreas()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el área?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_A.Cons = Val(TbCons.Text.Trim)
                objCn_A.EliminarArea(objCe_A)
                Limpiar()
                ListarAreas()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ListarAreas()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_A.ListarAreas
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class