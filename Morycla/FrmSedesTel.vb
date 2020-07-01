Imports C_Entidad
Imports C_Negocio
Public Class FrmSedesTel
    Dim Op As String = ""
    Dim objCe_St As New Ce_SedesTel
    Dim objCn_St As New Cn_SedesTel

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
        TbTel.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbTel.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbTel.Text = ""
        CbEstado.Text = "Seleccione..."
        LbCons.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Habilitar()
        Limpiar()
        Op = "N"
        TbTel.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbTel.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Habilitar()
        Limpiar()
        Op = ""
        TbTel.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Modificar()
        End If
    End Sub

    Private Sub Nuevo()
        If TbTel.Text.Trim = "" Then
            MsgBox("Debe indicar el teléfono", MsgBoxStyle.Critical)
            TbTel.Focus()
            Exit Sub
        End If

        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteSeTel(TbTel.Text.Trim, LbConsSede.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea registrar el teléfono", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_St.Sede = Val(LbConsSede.Text.Trim)
                    objCe_St.Tel = UCase(TbTel.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then
                        objCe_St.Estado = 1
                    Else
                        objCe_St.Estado = 0
                    End If
                    objCn_St.NuevoSedeTel(objCe_St)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarSedesTel()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe un registro con el mismo teléfono")
        End If
    End Sub

    Private Sub Modificar()
        If TbTel.Text.Trim = "" Then
            MsgBox("Debe indicar el teléfono", MsgBoxStyle.Critical)
            TbTel.Focus()
            Exit Sub
        End If

        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el teléfono", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_St.Cons = Val(LbCons.Text.Trim)
                objCe_St.Tel = UCase(TbTel.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then
                    objCe_St.Estado = 1
                Else
                    objCe_St.Estado = 0
                End If
                objCn_St.ModificarSedeTel(objCe_St)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarSedesTel()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Function ExisteSeTel(x, y) As Boolean
        Dim ds As New DataSet
        Try
            objCe_St.Tel = UCase(x)
            objCe_St.Sede = Val(LbConsSede.Text.Trim)
            ds = objCn_St.ExisteSede(objCe_St)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item(0) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el teléfono", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_St.Cons = Val(LbCons.Text.Trim)
                objCn_St.EliminarSedeTel(objCe_St)
                ListarSedesTel()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ListarSedesTel()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_St.Sede = Val(LbConsSede.Text.Trim)
            ds = objCn_St.ListaSedesTel(objCe_St)
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

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        TbTel.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub
    Private Sub FrmSedesTel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarSedesTel()
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub
End Class