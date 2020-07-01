Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_Stop_Areas
    Dim Op As String = ""
    Dim objCe_S As New Ce_Alm_Stop_Areas
    Dim objCn_S As New Cn_Alm_Stop_Areas

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
        TbStop.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbStop.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbStop.Text = ""
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
        TbStop.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbStop.Focus()
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
            objCe_S.Stop1 = UCase(x)
            ds = objCn_S.ExisteStopArea(objCe_S)
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
        If TbStop.Text.Trim = "" Then
            MsgBox("Debe ingresar el stop", MsgBoxStyle.Critical)
            TbStop.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del stop", MsgBoxStyle.Critical, "Stop de Area")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteTipoProd(TbStop.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea registrar el stop?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_S.Stop1 = UCase(TbStop.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_S.Estado = 1 : Else : objCe_S.Estado = 0 : End If
                    objCn_S.NuevoStopArea(objCe_S)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarStop()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe el stop registrado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If TbStop.Text.Trim = "" Then
            MsgBox("Debe ingresar el stop", MsgBoxStyle.Critical)
            TbStop.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el stop", MsgBoxStyle.Critical, "Stop de Área")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el stop?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_S.Cons = Val(TbCons.Text.Trim)
                objCe_S.Stop1 = UCase(TbStop.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_S.Estado = 1 : Else : objCe_S.Estado = 0 : End If
                objCn_S.ModificarStopArea(objCe_S)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarStop()
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

    Function ListarStop()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_S.ListarStopArea()
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
        TbStop.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub
    Private Sub Frm_Alm_Stop_Areas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarStop()
    End Sub
End Class