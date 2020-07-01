﻿Imports C_Entidad
Imports C_Negocio
Public Class FrmCcostos
    Dim Op As String = ""
    Dim objCe_Tp As New Ce_CCostos
    Dim objCn_Tp As New Cn_CCostos

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
        TbCentro.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbCentro.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbCentro.Text = ""
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
        TbCentro.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbCentro.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Function ExisteTipoProd(x) As Boolean
        Dim ds As New DataSet
        Try
            objCe_Tp.CCosto = UCase(x)
            ds = objCn_Tp.ExisteCCosto(objCe_Tp)
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
        If TbCentro.Text.Trim = "" Then
            MsgBox("Debe ingresar el centro de costo", MsgBoxStyle.Critical)
            TbCentro.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado de tipo", MsgBoxStyle.Critical, "Tipo Producto")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteTipoProd(TbCentro.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea registrar el centro de costo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_Tp.CCosto = UCase(TbCentro.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_Tp.Estado = 1 : Else : objCe_Tp.Estado = 0 : End If
                    objCn_Tp.NuevoCCosto(objCe_Tp)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarTipoProd()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe el centro de costo registrado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If TbCentro.Text.Trim = "" Then
            MsgBox("Debe ingresar el centro de costo", MsgBoxStyle.Critical)
            TbCentro.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del tipo", MsgBoxStyle.Critical, "Tipo Producto")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el centro de costo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Tp.Cons = Val(TbCons.Text.Trim)
                objCe_Tp.CCosto = UCase(TbCentro.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_Tp.Estado = 1 : Else : objCe_Tp.Estado = 0 : End If
                objCn_Tp.ModificarCCosto(objCe_Tp)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarTipoProd()
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
        If MsgBox("¿Confirma que desea eliminar el centro de costo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Tp.Cons = Val(TbCons.Text.Trim)
                objCn_Tp.EliminarCCosto(objCe_Tp)
                ListarTipoProd()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Function ListarTipoProd()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_Tp.ListarCCosto()
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
        TbCentro.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub
    Private Sub FrmCcostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarTipoProd()
    End Sub
End Class