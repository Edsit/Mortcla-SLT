Imports C_Entidad
Imports C_Negocio
Public Class FrmSedes
    Dim Op As String
    Dim objCe_S As New Ce_Sedes
    Dim objCe_Sd As New Ce_SedesDir
    Dim objCe_St As New Ce_SedesTel

    Dim objCn_S As New Cn_Sedes
    Dim objCn_Sd As New Cn_SedesDir
    Dim objCn_St As New Cn_SedesTel

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

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
        CbUsaPrefijo.Enabled = True
        CbEstado.Enabled = True
        TbCodHabilitacion.Enabled = True
        TbNit.Enabled = True
        TbPrefijo.Enabled = True
        TbSede.Enabled = True
    End Sub

    Private Sub Inhabilitar()
        CbUsaPrefijo.Enabled = False
        CbEstado.Enabled = False
        TbCodHabilitacion.Enabled = False
        TbNit.Enabled = False
        TbPrefijo.Enabled = False
        TbSede.Enabled = False
    End Sub

    Private Sub Limpiar()
        CbEstado.Text = "Seleccione..."
        CbUsaPrefijo.Text = "Seleccione..."
        TbCodHabilitacion.Text = ""
        TbNit.Text = ""
        TbPrefijo.Text = ""
        TbSede.Text = ""
    End Sub

    Sub ListarSedes()
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            ds = objCn_S.LoadSedes
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.DataSource = ds.Tables(0)
            End If
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub FrmSedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        Dgv1.Font = New Font("Arial", 8, FontStyle.Regular)
        LbCons.Text = ""
        ListarSedes()
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub Dgv_Click(sender As Object, e As EventArgs) Handles Dgv.Click
        On Error Resume Next
        Dim i As Integer = Dgv.CurrentRow.Index
        LbCons.Text = Dgv.Item(0, i).Value
        CbUsaPrefijo.Text = Dgv.Item(1, i).Value
        TbPrefijo.Text = Dgv.Item(2, i).Value
        TbSede.Text = Dgv.Item(3, i).Value
        TbCodHabilitacion.Text = Dgv.Item(4, i).Value
        TbNit.Text = Dgv.Item(5, i).Value
        CbEstado.Text = Dgv.Item(6, i).Value
        ListarSedesDirActivas()
        ListarSedesTelActivas()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        CbUsaPrefijo.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        CbUsaPrefijo.Focus()
    End Sub

    Private Function ExisteSede(X, Y) As Boolean
        Dim ds As New DataSet
        Try
            objCe_S.Prefijo = UCase(TbPrefijo.Text.Trim)
            objCe_S.Sede = UCase(TbSede.Text.Trim)
            ds = objCn_S.ExisteSede(objCe_S)
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

    Sub Nuevo()
        If CbUsaPrefijo.Text.Trim <> "SI" And CbUsaPrefijo.Text.Trim <> "NO" Then
            MsgBox("Debe indicar si la sede usa prefijo", MsgBoxStyle.Critical, "Nueva Sede")
            CbUsaPrefijo.Focus()
            Exit Sub
        End If
        If CbUsaPrefijo.Text.Trim = "SI" And TbPrefijo.Text.Trim = "" Then
            MsgBox("Debe indicar el prefijo de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbPrefijo.Focus()
            Exit Sub
        End If
        If TbSede.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbSede.Focus()
            Exit Sub
        End If
        If TbCodHabilitacion.Text.Trim = "" Then
            MsgBox("Debe indicar el código de habilitación de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbCodHabilitacion.Focus()
            Exit Sub
        End If
        If TbNit.Text.Trim = "" Then
            MsgBox("Debe indicar el Nit de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbNit.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nueva Sede")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteSede(UCase(TbPrefijo.Text.Trim), UCase(TbSede.Text.Trim)) = True Then
            MsgBox("Ya existe una sede con el mismo nombre o prefijo", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If MsgBox("¿Confirma que desea registrar la nueva Sede?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_S.UsaPrefijo = UCase(CbUsaPrefijo.Text.Trim)
                    objCe_S.Prefijo = UCase(TbPrefijo.Text.Trim)
                    objCe_S.Sede = UCase(TbSede.Text.Trim)
                    objCe_S.CodHabilitacion = UCase(TbCodHabilitacion.Text.Trim)
                    objCe_S.Nit = UCase(TbNit.Text.Trim)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then
                        objCe_S.Estado = 1
                    Else
                        objCe_S.Estado = 0
                    End If
                    objCn_S.NuevoSede(objCe_S)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    ListarSedes()
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub Actualizar()
        If CbUsaPrefijo.Text.Trim <> "SI" And CbUsaPrefijo.Text.Trim <> "NO" Then
            MsgBox("Debe indicar si la sede usa prefijo", MsgBoxStyle.Critical, "Nueva Sede")
            CbUsaPrefijo.Focus()
            Exit Sub
        End If
        If CbUsaPrefijo.Text.Trim = "SI" And TbPrefijo.Text.Trim = "" Then
            MsgBox("Debe indicar el prefijo de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbPrefijo.Focus()
            Exit Sub
        End If
        If TbSede.Text.Trim = "" Then
            MsgBox("Debe indicar el nombre de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbSede.Focus()
            Exit Sub
        End If
        If TbCodHabilitacion.Text.Trim = "" Then
            MsgBox("Debe indicar el código de habilitación de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbCodHabilitacion.Focus()
            Exit Sub
        End If
        If TbNit.Text.Trim = "" Then
            MsgBox("Debe indicar el Nit de la sede", MsgBoxStyle.Critical, "Nueva Sede")
            TbNit.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado la sede", MsgBoxStyle.Critical, "Nueva Sede")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar la Sede?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_S.Cons = Val(LbCons.Text.Trim)
                objCe_S.UsaPrefijo = UCase(CbUsaPrefijo.Text.Trim)
                objCe_S.Prefijo = UCase(TbPrefijo.Text.Trim)
                objCe_S.Sede = UCase(TbSede.Text.Trim)
                objCe_S.CodHabilitacion = UCase(TbCodHabilitacion.Text.Trim)
                objCe_S.Nit = UCase(TbNit.Text.Trim)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_S.Estado = 1 : Else : objCe_S.Estado = 0 : End If
                objCn_S.ModificarSede(objCe_S)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                ListarSedes()
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
        If MsgBox("¿Confirma que desea eliminar la Sede?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_S.Cons = Val(LbCons.Text.Trim)
                objCn_S.EliminarSede(objCe_S)
                ListarSedes()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(LbCons.Text.Trim) > 0 Then
            FrmSedesDir.LbConsSede.Text = LbCons.Text
            FrmSedesDir.TbSede.Text = TbSede.Text
            FrmSedesDir.ShowDialog()
        End If
    End Sub

    Private Sub ListarSedesDirActivas()
        Dim ds As New DataSet
        Dgv1.Rows.Clear()
        Try
            objCe_Sd.Sede = Val(LbCons.Text.Trim)
            ds = objCn_Sd.ListarSedesDirActivas(objCe_Sd)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Do
                    Dgv1.Rows.Add()
                    Dgv1.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv1.Item(1, i).Value = "DIRECCION"
                    Dgv1.Item(2, i).Value = ds.Tables(0).Rows(i).Item(1)
                    i = i + 1
                Loop Until i = c
                Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarSedesTelActivas()
        Dim ds As New DataSet
        Try
            objCe_St.Sede = Val(LbCons.Text.Trim)
            ds = objCn_St.ListarSedesTelActivas(objCe_St)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = Dgv1.Rows.Count
                Dim i1 As Integer = 0
                Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Do
                    Dgv1.Rows.Add()
                    Dgv1.Item(0, i).Value = ds.Tables(0).Rows(i1).Item(0)
                    Dgv1.Item(1, i).Value = "TELEFONO"
                    Dgv1.Item(2, i).Value = ds.Tables(0).Rows(i1).Item(1)
                    i = i + 1
                    i1 = i1 + 1
                Loop Until i1 = c
                Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(LbCons.Text.Trim) > 0 Then
            FrmSedesTel.LbConsSede.Text = LbCons.Text
            FrmSedesTel.TbSede.Text = TbSede.Text
            FrmSedesTel.ShowDialog()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Val(LbCons.Text.Trim) > 0 Then
            SedeSelNo()
            SedeSelSi()
            ListarSedes()
        End If
    End Sub

    Private Sub SedeSelNo()
        Try
            objCn_S.SedeSelNO()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SedeSelSi()
        Try
            objCe_S.Cons = Val(LbCons.Text.Trim)
            objCn_S.SedeSelSI(objCe_S)
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadColorDgv()
        Dim c = Dgv.Rows.Count
        If c > 0 Then
            For Each fila As DataGridViewRow In Dgv.Rows
                If fila.Cells("Sel").Value = "SI" Then
                    fila.DefaultCellStyle.BackColor = Color.Tomato
                    fila.DefaultCellStyle.ForeColor = Color.White
                Else
                    fila.DefaultCellStyle.BackColor = Color.White
                    fila.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
        End If
    End Sub

    Sub ColorFila()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                If Dgv.Item(7, i).Value = "SI" Then
                    Dgv.Rows(i).DefaultCellStyle.BackColor = Color.Tomato
                    Dgv.Rows(i).DefaultCellStyle.ForeColor = Color.White
                Else
                    Dgv.Rows(i).DefaultCellStyle.BackColor = Color.White
                    Dgv.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadColorDgv()
    End Sub
End Class