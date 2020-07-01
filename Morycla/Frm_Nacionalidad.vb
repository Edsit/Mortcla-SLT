Imports C_Entidad
Imports C_Negocio
Public Class Frm_Nacionalidad
    Dim Op As String = ""
    Dim objCe_N As New Ce_Nacionalidad
    Dim objCn_N As New Cn_Nacionalidad

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
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Habilitar()
        TbNacionalidad.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbNacionalidad.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        LbCons.Text = ""
        TbNacionalidad.Text = ""
        CbEstado.Text = ""
    End Sub

    Private Sub Listar_Nacionalidad()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_N.Listar_Nacionalidad
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

    Private Sub Frm_Nacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Nacionalidad()
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        TbNacionalidad.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        TbNacionalidad.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "M"
        TbNacionalidad.Focus()
    End Sub

    Private Sub Nuevo()
        If TbNacionalidad.Text.Trim = "" Then
            MsgBox("Debe ingresar la nacionalidad", MsgBoxStyle.Critical)
            TbNacionalidad.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea registrar la nacionalidad?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_N.Nacionalidad = UCase(TbNacionalidad.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_N.Estado = 1 : Else : objCe_N.Estado = 0 : End If
                objCn_N.Nueva_Nacionalidad(objCe_N)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                Listar_Nacionalidad()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Modificar()
        If TbNacionalidad.Text.Trim = "" Then
            MsgBox("Debe ingresar la nacionalidad", MsgBoxStyle.Critical)
            TbNacionalidad.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar la nacionalidad?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_N.Cons = Val(LbCons.Text.Trim)
                objCe_N.Nacionalidad = UCase(TbNacionalidad.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_N.Estado = 1 : Else : objCe_N.Estado = 0 : End If
                objCn_N.Modificar_Nacionalidad(objCe_N)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                Listar_Nacionalidad()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "M" Then
            Modificar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Op = ""
        Inhabilitar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar la nacionalidad?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_N.Cons = Val(LbCons.Text.Trim)
                objCn_N.Eliminar_Nacionalidad(objCe_N)
                Limpiar()
                Listar_Nacionalidad()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class