Imports C_Entidad
Imports C_Negocio
Public Class FrmFuncionarios
    Dim Op As String = ""
    Dim objCe_F As New Ce_Funcionarios
    Dim objCe_Co As New Ce_Consecutivos

    Dim objCn_F As New Cn_Funcionarios
    Dim objCn_T As New Cn_Tdoc
    Dim objCn_C As New Cn_Cargos
    Dim objCn_S As New Cn_Sedes
    Dim objCn_Co As New Cn_Consecutivos

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
        TbDoc.Enabled = True
        TbNombre.Enabled = True
        TbTel.Enabled = True
        CbCargo.Enabled = True
        CbEstado.Enabled = True
        CbSede.Enabled = True
        CbTdoc.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        TbDir.Enabled = False
        TbDoc.Enabled = False
        TbNombre.Enabled = False
        TbTel.Enabled = False
        CbCargo.Enabled = False
        CbEstado.Enabled = False
        CbSede.Enabled = False
        CbTdoc.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbDir.Text = ""
        TbDoc.Text = ""
        TbNombre.Text = ""
        TbTel.Text = ""
        LbCons.Text = ""
        CbCargo.Text = "Seleccione..."
        CbEstado.Text = "Seleccione..."
        CbSede.Text = "Seleccione..."
        CbTdoc.Text = "Seleccione..."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarSedesActivas()
        Dim ds As New DataSet
        CbSede.DataSource = Nothing
        CbSede.Items.Clear()
        Try
            ds = objCn_S.LoadSedesActivas
            If ds.Tables(0).Rows.Count > 0 Then
                CbSede.DataSource = ds.Tables(0)
                CbSede.DisplayMember = "Sede"
                CbSede.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarTdocActivos()
        Dim ds As New DataSet
        CbTdoc.DataSource = Nothing
        CbTdoc.Items.Clear()
        Try
            ds = objCn_T.ListarTdocActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTdoc.DataSource = ds.Tables(0)
                CbTdoc.DisplayMember = "Tipo"
                CbTdoc.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarCargosActivos()
        Dim ds As New DataSet
        CbCargo.DataSource = Nothing
        CbCargo.Items.Clear()
        Try
            ds = objCn_C.ListarCargosActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbCargo.DataSource = ds.Tables(0)
                CbCargo.DisplayMember = "Cargo"
                CbCargo.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarFuncionarios()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_F.ListarFuncinarios
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

    Private Sub FrmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        ListarSedesActivas()
        ListarTdocActivos()
        ListarCargosActivos()
        ListarFuncionarios()
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        CbSede.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        CbSede.Focus()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Function ExisteFuncionario(X) As Boolean
        Dim ds As New DataSet
        Try
            objCe_F.Doc = X
            ds = objCn_F.ExisteFuncionario(objCe_F)
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
        Finally
            ds.Dispose()
        End Try
    End Function

    Function ConsecutivoFuncionario() As Integer
        Dim ds As New DataSet
        Try
            ds = objCn_Co.VerConsFunc()
            Return ds.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Function

    Private Sub Nuevo()
        Dim clave As String = ""
        Texto = 123
        Cript()
        clave = Texto
        If Val(CbSede.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar la sede", MsgBoxStyle.Critical)
            CbSede.Focus()
            Exit Sub
        End If
        If Val(CbTdoc.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar el tipo de documento", MsgBoxStyle.Critical)
            CbTdoc.Focus()
            Exit Sub
        End If

        If Val(CbCargo.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar el cargo", MsgBoxStyle.Critical)
            CbCargo.Focus()
            Exit Sub
        End If

        If TbDoc.Text.Trim = "" Then
            MsgBox("Debe indicar el número de documento", MsgBoxStyle.Critical)
            TbDoc.Focus()
        End If

        If TbNombre.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre del funcionario", MsgBoxStyle.Critical)
            TbNombre.Focus()
        End If

        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del funcionario", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteFuncionario(UCase(TbDoc.Text.Trim)) = False Then
            If MsgBox("¿Confirma que desea registrar el funcionario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_F.Cons = ConsecutivoFuncionario() + 1
                    objCe_F.Sede = Val(CbSede.SelectedValue.ToString)
                    objCe_F.Tdoc = Val(CbTdoc.SelectedValue.ToString)
                    objCe_F.Doc = UCase(TbDoc.Text.Trim)
                    objCe_F.Nombre = UCase(TbNombre.Text.Trim)
                    objCe_F.Cargo = Val(CbCargo.SelectedValue.ToString)
                    objCe_F.Estado = 1
                    objCe_F.Dir = UCase(TbDir.Text.Trim)
                    objCe_F.Tel = UCase(TbTel.Text.Trim)
                    objCe_F.Pwd = clave
                    objCe_F.Perfil = 0
                    objCn_F.NuevoFuncionarios(objCe_F)
                    LbCons.Text = objCe_F.Cons
                    ActualizarConsecutivo()
                    Accion = "REGISTRO DE FUNCIONARIO CONS: " & LbCons.Text & " - " & UCase(TbNombre.Text)
                    RegistrarAuditoria()
                    Botones1()
                    Inhabilitar()
                    Op = ""
                    ListarFuncionarios()
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Ya existe un funcionario con el mismo número de documento", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ActualizarConsecutivo()
        Try
            objCe_Co.Func = Val(LbCons.Text.Trim)
            objCn_Co.ActualizarConsFunc(objCe_Co)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Modificar()
        If Val(CbSede.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar la sede", MsgBoxStyle.Critical)
            CbSede.Focus()
            Exit Sub
        End If
        If Val(CbTdoc.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar el tipo de documento", MsgBoxStyle.Critical)
            CbTdoc.Focus()
            Exit Sub
        End If

        If Val(CbCargo.SelectedValue.ToString) < 1 Then
            MsgBox("Debe seleccionar el cargo", MsgBoxStyle.Critical)
            CbCargo.Focus()
            Exit Sub
        End If

        If TbDoc.Text.Trim = "" Then
            MsgBox("Debe indicar el número de documento", MsgBoxStyle.Critical)
            TbDoc.Focus()
        End If

        If TbNombre.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre del funcionario", MsgBoxStyle.Critical)
            TbNombre.Focus()
        End If

        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del funcionario", MsgBoxStyle.Critical)
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el funcionario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_F.Cons = Val(LbCons.Text.Trim)
                objCe_F.Sede = Val(CbSede.SelectedValue.ToString)
                objCe_F.Tdoc = Val(CbTdoc.SelectedValue.ToString)
                objCe_F.Doc = UCase(TbDoc.Text.Trim)
                objCe_F.Nombre = UCase(TbNombre.Text.Trim)
                objCe_F.Cargo = Val(CbCargo.SelectedValue.ToString)
                objCe_F.Estado = 1
                objCe_F.Dir = UCase(TbDir.Text.Trim)
                objCe_F.Tel = UCase(TbTel.Text.Trim)
                objCn_F.MOdificarFuncionarios(objCe_F)
                Accion = "MODIFICACION DE FUNCIONARIO CONS: " & LbCons.Text
                RegistrarAuditoria()
                Inhabilitar()
                Op = ""
                ListarFuncionarios()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If

        If Op = "A" Then
            Modificar()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el funcionario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_F.Cons = Val(LbCons.Text.Trim)
                objCe_F.Sede = Val(CbSede.SelectedValue.ToString)
                objCn_F.EliminarFuncionarios(objCe_F)
                Accion = "ELIMINACION DE FUNCIONARIO CONS: " & LbCons.Text & " - " & UCase(TbNombre.Text)
                RegistrarAuditoria()
                Inhabilitar()
                Op = ""
                ListarFuncionarios()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub TbDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbDoc.KeyPress

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmFuncionarioBuscarDoc.ShowDialog()
        If DocFun <> "" Then
            BuscarFuncionario()
        End If
    End Sub

    Private Sub BuscarFuncionario()
        Dim ds As New DataSet
        Try
            objCe_F.Doc = DocFun
            ds = objCn_F.VerFuncionarioDoc(objCe_F)
            If ds.Tables(0).Rows.Count > 0 Then
                LbCons.Text = ds.Tables(0).Rows(0).Item(0)
                CbSede.Text = ds.Tables(0).Rows(0).Item(1)
                CbTdoc.Text = ds.Tables(0).Rows(0).Item(2)
                'TbDoc.Text = ds.Tables(0).Rows(0).Item(3)
                TbNombre.Text = ds.Tables(0).Rows(0).Item(4)
                CbCargo.Text = ds.Tables(0).Rows(0).Item(5)
                TbDir.Text = ds.Tables(0).Rows(0).Item(6)
                TbTel.Text = ds.Tables(0).Rows(0).Item(7)
                CbEstado.Text = ds.Tables(0).Rows(0).Item(8)
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmCargos.ShowDialog()
        ListarCargosActivos()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        CbSede.Text = Dgv.Item(1, i).Value
        CbTdoc.Text = Dgv.Item(2, i).Value
        TbDoc.Text = Dgv.Item(3, i).Value
        TbNombre.Text = Dgv.Item(4, i).Value
        CbCargo.Text = Dgv.Item(5, i).Value
        TbDir.Text = Dgv.Item(6, i).Value
        TbTel.Text = Dgv.Item(7, i).Value
        CbEstado.Text = Dgv.Item(8, i).Value
    End Sub
End Class