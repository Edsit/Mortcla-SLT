Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_Laboratorios
    Dim Op As String = ""
    Dim objCe_L As New Ce_Alm_Laboratorios
    Dim objCn_L As New Cn_Alm_Laboratorio

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
        TbLab.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbLab.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbLab.Text = ""
        CbEstado.Text = "Seleccione..."
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub Frm_Alm_Laboratorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarLab()
    End Sub

    Private Sub ListarLab()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_L.ListarLab
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Op = "N"
        Habilitar()
        TbLab.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Op = "A"
        Habilitar()
        TbLab.Focus()
    End Sub

    Private Function ExisteLab(X) As Boolean
        Dim ds As New DataSet
        Try
            objCe_L.Lab = UCase(X)
            ds = objCn_L.ExisteLab(objCe_L)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item(0) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Function

    Private Sub Nuevo()
        If TbLab.Text.Trim = "" Then
            MsgBox("Debe ingresar el laboratorio", MsgBoxStyle.Critical)
            TbLab.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Nuevo Laboratorio")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteLab(TbLab.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea regitrar el laboratorio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_L.Lab = UCase(TbLab.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_L.Estado = 1 : Else : objCe_L.Estado = 0 : End If
                    objCn_L.NuevoLab(objCe_L)
                    Accion = "REGISTRO DE LABORATORIO: " & UCase(TbLab.Text)
                    RegistrarAuditoria()
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarLab()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("El laboratorio ya existe", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If TbLab.Text.Trim = "" Then
            MsgBox("Debe ingresar el laboratorio", MsgBoxStyle.Critical)
            TbLab.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Modificar Laboratorio")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el laboratorio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_L.Cons = Val(TbCons.Text.Trim)
                objCe_L.Lab = UCase(TbLab.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_L.Estado = 1 : Else : objCe_L.Estado = 0 : End If
                objCn_L.ModificarLab(objCe_L)
                Accion = "MODIFICACION LABORATORIO CONS: " & TbCons.Text
                RegistrarAuditoria()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarLab()
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
        If MsgBox("¿Confirma que desea eliminar el laboratorio?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_L.Cons = Val(TbCons.Text.Trim)
                objCn_L.EliminarLab(objCe_L)
                Accion = "ELIMINACION LABORATORIO CONS: " & TbCons.Text & " - " & UCase(TbLab.Text)
                RegistrarAuditoria()
                Limpiar()
                ListarLab()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        TbCons.Text = Dgv.Item(0, i).Value
        TbLab.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub
End Class