Imports C_Entidad
Imports C_Negocio
Public Class FrmCargos
    Dim Op As String = ""
    Dim objCe_C As New Ce_Cargos
    Dim objCn_C As New Cn_Cargos

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
        TbcARGO.Enabled = True
        CbAsistencial.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbcARGO.Enabled = False
        CbAsistencial.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbcARGO.Text = ""
        CbAsistencial.Text = ""
        CbEstado.Text = ""
    End Sub

    Private Sub FrmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarCargos
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Sub ListarCargos()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_C.ListarCargos
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = "A"
        TbcARGO.Focus()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        TbcARGO.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Sub Nuevo()
        If TbcARGO.Text.Trim = "" Then
            MsgBox("Debe ingresar el cargo", MsgBoxStyle.Critical)
            TbcARGO.Focus()
            Exit Sub
        End If
        If CbAsistencial.Text.Trim = "" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Cargo")
            CbAsistencial.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Cargo")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea registrar el cargo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_C.Cargo = UCase(TbcARGO.Text.Trim)
                objCe_C.Asistencial = UCase(CbAsistencial.Text)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_C.Estado = 1 : Else : objCe_C.Estado = 0 : End If
                objCn_C.NuevoCargo(objCe_C)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarCargos()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub Actualizar()
        If TbcARGO.Text.Trim = "" Then
            MsgBox("Debe ingresar el cargo", MsgBoxStyle.Critical)
            TbcARGO.Focus()
            Exit Sub
        End If
        If CbAsistencial.Text.Trim = "" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Cargo")
            CbAsistencial.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Cargo")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el cargo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_C.Cons = Val(TbCons.Text.Trim)
                objCe_C.Cargo = UCase(TbcARGO.Text.Trim)
                objCe_C.Asistencial = UCase(CbAsistencial.Text)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_C.Estado = 1 : Else : objCe_C.Estado = 0 : End If
                objCn_C.ModificarCargo(objCe_C)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarCargos()
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
        If MsgBox("¿Confirma que desea eliminar el cargo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_C.Cons = Val(TbCons.Text.Trim)
                objCn_C.EliminarCargo(objCe_C)
                Limpiar()
                ListarCargos()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class