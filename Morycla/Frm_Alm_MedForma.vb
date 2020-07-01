Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_MedForma
    Dim Op As String = ""
    Dim objCe_F As New Ce_Alm_MedForma
    Dim objCn_F As New Cn_Alm_MedForma

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
        TbForma.Enabled = True
        CbEstado.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbForma.Enabled = False
        CbEstado.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbForma.Text = ""
        CbEstado.Text = "Seleccione..."
    End Sub

    Private Sub Frm_Alm_MedForma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
        ListarMedFormas()
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
        TbForma.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "N"
        TbForma.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If
        If Op = "A" Then
            Actualizar()
        End If
    End Sub

    Function ExisteMedForma(x) As Boolean
        Dim ds As New DataSet
        Try
            objCe_F.Forma = UCase(x)
            ds = objCn_F.ExisteMedForma(objCe_F)
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
        If TbForma.Text.Trim = "" Then
            MsgBox("Debe ingresar forma farmacéutica", MsgBoxStyle.Critical)
            TbForma.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar Forma", MsgBoxStyle.Critical, "Forma Farmacéutica")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteMedForma(TbForma.Text.Trim) = False Then
            If MsgBox("¿Confirma que desea registrar el forma farmacéutica?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_F.Forma = UCase(TbForma.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_F.Estado = 1 : Else : objCe_F.Estado = 0 : End If
                    objCn_F.NuevoMedForma(objCe_F)
                    Accion = "REGISTRO DE FORMA CONS: " & TbCons.Text & " - " & UCase(TbForma.Text)
                    RegistrarAuditoria()
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarMedFormas()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe la forma farmacéutica registrado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Actualizar()
        If TbForma.Text.Trim = "" Then
            MsgBox("Debe ingresar la forma farmacéutica", MsgBoxStyle.Critical)
            TbForma.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar la forma", MsgBoxStyle.Critical, "Forma Farmacéutica")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el tipo de producto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_F.Cons = Val(TbCons.Text.Trim)
                objCe_F.Forma = UCase(TbForma.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_F.Estado = 1 : Else : objCe_F.Estado = 0 : End If
                objCn_F.ModificarMedForma(objCe_F)
                Accion = "MODIFICACION DE FORMA CONS: " & TbCons.Text
                RegistrarAuditoria()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarMedFormas()
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
        If MsgBox("¿Confirma que desea eliminar la forma farmacética?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_F.Cons = Val(TbCons.Text.Trim)
                objCn_F.EliminarMedForma(objCe_F)
                Accion = "ELIMINACION DE FORMA CONS: " & TbCons.Text & " - " & UCase(TbForma.Text)
                RegistrarAuditoria()
                ListarMedFormas()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Function ListarMedFormas()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_F.ListarMedForma
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
        TbForma.Text = Dgv.Item(1, i).Value
        CbEstado.Text = Dgv.Item(2, i).Value
    End Sub
End Class