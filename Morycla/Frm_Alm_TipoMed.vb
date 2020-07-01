﻿Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_TipoMed
    Dim Op As String = ""
    Dim objCe_Tm As New Ce_Alm_TipoMed
    Dim objCn_Tm As New Cn_Alm_TipoMed

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
        TbTipo.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbTipo.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbTipo.Text = ""
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
        TbTipo.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbTipo.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Function ExisteTipoMed(x) As Boolean
        Dim ds As New DataSet
        Try
            objCe_Tm.Tipo = UCase(x)
            ds = objCn_Tm.ExisteTipoMed(objCe_Tm)
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

        End Try
    End Function

    Private Sub Nuevo()
        If TbTipo.Text.Trim = "" Then
            MsgBox("Debe ingresar el tipo de medicamento", MsgBoxStyle.Critical)
            TbTipo.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Tipo Medicamento")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteTipoMed(TbTipo.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea registrar el tipo de medicamento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_Tm.Tipo = UCase(TbTipo.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_Tm.Estado = 1 : Else : objCe_Tm.Estado = 0 : End If
                    objCn_Tm.NuevoTipoMed(objCe_Tm)
                    Accion = "REGISTRO DE TIPO MEDICAMENTO: " & UCase(TbTipo.Text)
                    RegistrarAuditoria()
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarTipoMed()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe el tipo de medicamento registrado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If TbTipo.Text.Trim = "" Then
            MsgBox("Debe ingresar el tipo de medicamento", MsgBoxStyle.Critical)
            TbTipo.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del tipo", MsgBoxStyle.Critical, "Tipo Medicamento")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el tipo de medicamento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Tm.Cons = Val(TbCons.Text.Trim)
                objCe_Tm.Tipo = UCase(TbTipo.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_Tm.Estado = 1 : Else : objCe_Tm.Estado = 0 : End If
                objCn_Tm.ModificarTipoMed(objCe_Tm)
                Accion = "MODIFICACION DE TIPO MEDICAMENTO CONS: " & TbCons.Text
                RegistrarAuditoria()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarTipoMed()
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
        If MsgBox("¿Confirma que desea eliminar el tipo de medicamento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Tm.Cons = Val(TbCons.Text.Trim)
                objCn_Tm.EliminarTipoMed(objCe_Tm)
                Accion = "ELIMINACION DE TIPO MEDICAMENTO CONS: " & TbCons.Text & " - " & UCase(TbTipo.Text)
                RegistrarAuditoria()
                ListarTipoMed()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Function ListarTipoMed()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_Tm.ListarTipoMed
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
        TbTipo.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub
    Private Sub Frm_Alm_TipoMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarTipoMed()
    End Sub
End Class