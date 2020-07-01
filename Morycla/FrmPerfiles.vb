Imports C_Entidad
Imports C_Negocio
Public Class FrmPerfiles
    Dim Op As String = ""
    Dim objCe_P As New Ce_Perfiles
    Dim objCn_P As New Cn_Perfiles

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
        TbPeril.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbPeril.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbPeril.Text = ""
        CbEstado.Text = "Seleccione..."
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        TbPeril.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbPeril.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Private Sub Nuevo()
        If TbPeril.Text.Trim = "" Then
            MsgBox("Debe ingresar el perfil", MsgBoxStyle.Critical)
            TbPeril.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Perfiles")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea registrar el perfil?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.Perfil = UCase(TbPeril.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_P.Estado = 1 : Else : objCe_P.Estado = 0 : End If
                objCn_P.NuevoPerfil(objCe_P)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarPerfiles()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Actualizar()
        If TbPeril.Text.Trim = "" Then
            MsgBox("Debe ingresar el perfil", MsgBoxStyle.Critical)
            TbPeril.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Perfiles")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el perfil") Then
            Try
                objCe_P.Cons = Val(TbCons.Text.Trim)
                objCe_P.Perfil = UCase(TbPeril.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_P.Estado = 1 : Else : objCe_P.Estado = 0 : End If
                objCn_P.ModificarPerfil(objCe_P)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarPerfiles()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el perfil?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.Cons = Val(TbCons.Text.Trim)
                objCn_P.EliminarPerfil(objCe_P)
                ListarPerfiles()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Function ListarPerfiles()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_P.ListarPerfiles()
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Function

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        TbPeril.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub

    Private Sub FrmPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarPerfiles()
    End Sub
End Class