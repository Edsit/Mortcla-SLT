Imports C_Entidad
Imports C_Negocio
Public Class FrmDep
    Dim Op As String = ""
    Dim objCe_D As New Ce_Dep
    Dim objCn_D As New Cn_Dep

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
        TbCodigo.Enabled = True
        TbDep.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbCodigo.Enabled = False
        TbDep.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCodigo.Text = ""
        TbCons.Text = ""
        TbDep.Text = ""
        CbEstado.Text = ""
    End Sub

    Private Sub ListarDep()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_D.Listar_Dep
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

    Private Sub FrmDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        ListarDep()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        TbCodigo.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbCodigo.Focus()
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
        If TbCodigo.Text.Trim = "" Then
            MsgBox("Debe indicar el código Dane del departamento", MsgBoxStyle.Critical)
            TbCodigo.Focus()
            Exit Sub
        End If
        If TbDep.Text.Trim = "" Then
            MsgBox("Debe indicar el departamento", MsgBoxStyle.Critical)
            TbDep.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del departamento", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea registrar el departamento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_D.Cod = UCase(TbCodigo.Text.Trim)
                objCe_D.Dep = UCase(TbDep.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_D.Estado = 1 : Else : objCe_D.Estado = 0 : End If
                objCn_D.Nuevo_Dep(objCe_D)
                ListarDep()
                Botones1()
                Inhabilitar()
                Limpiar()
                Op = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Actualizar()
        If TbCodigo.Text.Trim = "" Then
            MsgBox("Debe indicar el código Dane del departamento", MsgBoxStyle.Critical)
            TbCodigo.Focus()
            Exit Sub
        End If
        If TbDep.Text.Trim = "" Then
            MsgBox("Debe indicar el departamento", MsgBoxStyle.Critical)
            TbDep.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del departamento", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el departamento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_D.Cons = Val(TbCons.Text.Trim)
                objCe_D.Cod = UCase(TbCodigo.Text.Trim)
                objCe_D.Dep = UCase(TbDep.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_D.Estado = 1 : Else : objCe_D.Estado = 0 : End If
                objCn_D.Editar_Dep(objCe_D)
                ListarDep()
                Botones1()
                Inhabilitar()
                Limpiar()
                Op = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Op = ""
        Inhabilitar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el departamento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_D.Cons = Val(TbCons.Text.Trim)
                objCn_D.Eliminar_Dep(objCe_D)
                ListarDep()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        TbCodigo.Text = Dgv.Item(1, i).Value
        TbDep.Text = Dgv.Item(2, i).Value
        CbEstado.Text = Dgv.Item(3, i).Value
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class