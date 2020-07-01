Imports C_Entidad
Imports C_Negocio
Public Class FrmSedesDir
    Dim Op As String = ""
    Dim objCe_Sd As New Ce_SedesDir
    Dim objCn_Sd As New Cn_SedesDir

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
        TbDir.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbDir.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbDir.Text = ""
        CbEstado.Text = "Seleccione..."
        LbCons.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmSedesDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarSedesDir()
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Habilitar()
        Limpiar()
        Op = "N"
        TbDir.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbDir.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Habilitar()
        Limpiar()
        Op = ""
        TbDir.Focus()
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
        If TbDir.Text.Trim = "" Then
            MsgBox("Debe indicar la dirección", MsgBoxStyle.Critical)
            TbDir.Focus()
            Exit Sub
        End If

        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteSedir(TbDir.Text.Trim, LbConsSede.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea registrar la dirección", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_Sd.Sede = Val(LbConsSede.Text.Trim)
                    objCe_Sd.Dir = UCase(TbDir.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then
                        objCe_Sd.Estado = 1
                    Else
                        objCe_Sd.Estado = 0
                    End If
                    objCn_Sd.NuevoSedeDir(objCe_Sd)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarSedesDir()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe un registro con la misma dirección")
        End If
    End Sub

    Private Sub Modificar()
        If TbDir.Text.Trim = "" Then
            MsgBox("Debe indicar la dirección", MsgBoxStyle.Critical)
            TbDir.Focus()
            Exit Sub
        End If

        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar la dirección", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Sd.Cons = Val(LbCons.Text.Trim)
                objCe_Sd.Dir = UCase(TbDir.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then
                    objCe_Sd.Estado = 1
                Else
                    objCe_Sd.Estado = 0
                End If
                objCn_Sd.ModificarSedeDir(objCe_Sd)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarSedesDir()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Function ExisteSedir(x, y) As Boolean
        Dim ds As New DataSet
        Try
            objCe_Sd.Dir = UCase(x)
            objCe_Sd.Sede = Val(LbConsSede.Text.Trim)
            ds = objCn_Sd.ExisteSede(objCe_Sd)
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
        If MsgBox("¿Confirma que desea eliminar la dirección", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Sd.Cons = Val(LbCons.Text.Trim)
                objCn_Sd.EliminarSedeDir(objCe_Sd)
                ListarSedesDir()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ListarSedesDir()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_Sd.Sede = Val(LbConsSede.Text.Trim)
            ds = objCn_Sd.ListaSedesDir(objCe_Sd)
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
        TbDir.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub

End Class