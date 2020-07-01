Imports C_Entidad
Imports C_Negocio
Public Class Frm_Usuarios
    Dim Op As String = ""
    Dim Doc As String = 0
    Dim objCe_M As New Ce_Mun
    Dim objCe_B As New Ce_Barrio
    Dim objCe_U As New Ce_Usuarios
    Dim objCe_Ue As New Ce_UsuarioEnfoque

    Dim objCn_Td As New Cn_Tdoc
    Dim objCn_D As New Cn_Dep
    Dim objCn_M As New Cn_Mun
    Dim objCn_B As New Cn_Barrios
    Dim objCn_E As New Cn_Eps
    Dim objCn_Tu As New Cn_TipoUsuario
    Dim objCn_G As New Cn_Genero
    Dim objCn_N As New Cn_Nacionalidad
    Dim objCn_U As New Cn_Usuarios
    Dim objCn_Ue As New Cn_UsuariosEnfoques

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
        TbApellido1.Enabled = True
        TbApellido2.Enabled = True
        TbDir.Enabled = True
        TbDoc.Enabled = True
        TbNOmbre1.Enabled = True
        TbNombre2.Enabled = True
        TbTel.Enabled = True
        CbAseguradora.Enabled = True
        CbBarrio.Enabled = True
        CbDep.Enabled = True
        CbEstado.Enabled = True
        CbGenero.Enabled = True
        CbMun.Enabled = True
        CbPais.Enabled = True
        CbTdoc.Enabled = True
        CbTipoAfi.Enabled = True
        CbZona.Enabled = True
        DtFecNac.Enabled = True
        BtnAseguradora.Enabled = True
        BtnBarrio.Enabled = True
        BtnNacionalidad.Enabled = True
    End Sub


    Private Sub Inhabilitar()
        TbApellido1.Enabled = False
        TbApellido2.Enabled = False
        TbDir.Enabled = False
        TbDoc.Enabled = True
        TbNOmbre1.Enabled = False
        TbNombre2.Enabled = False
        TbTel.Enabled = False
        CbAseguradora.Enabled = False
        CbBarrio.Enabled = False
        CbDep.Enabled = False
        CbEstado.Enabled = False
        CbGenero.Enabled = False
        CbMun.Enabled = False
        CbPais.Enabled = False
        CbTdoc.Enabled = False
        CbTipoAfi.Enabled = False
        CbZona.Enabled = False
        DtFecNac.Enabled = False
        BtnAseguradora.Enabled = False
        BtnBarrio.Enabled = False
        BtnNacionalidad.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbApellido1.Text = ""
        TbApellido2.Text = ""
        TbDir.Text = ""
        TbDoc.Text = ""
        TbNOmbre1.Text = ""
        TbNombre2.Text = ""
        TbTel.Text = ""
        CbAseguradora.Text = ""
        CbBarrio.Text = ""
        CbDep.Text = ""
        CbEstado.Text = ""
        CbGenero.Text = ""
        CbMun.Text = ""
        CbPais.Text = ""
        CbTdoc.Text = ""
        CbTipoAfi.Text = ""
        CbZona.Text = ""
        DtFecNac.Value = Now
        LbCons.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub ListarTdocActivos()
        Dim ds As New DataSet
        CbTdoc.DataSource = Nothing
        CbTdoc.Items.Clear()
        Try
            ds = objCn_Td.ListarTdocActivos
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

    Private Sub ListarDepActivos()
        Dim ds As New DataSet
        CbDep.DataSource = Nothing
        CbDep.Items.Clear()
        Try
            ds = objCn_D.Listar_Dep_Activos
            If ds.Tables(0).Rows.Count > 0 Then
                CbDep.DataSource = ds.Tables(0)
                CbDep.DisplayMember = "Dep"
                CbDep.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarMunActivos()
        Dim ds As New DataSet
        CbMun.DataSource = Nothing
        CbMun.Items.Clear()
        Try
            objCe_M.CodDep = Val(CbDep.SelectedValue.ToString)
            ds = objCn_M.ListarMunActivos(objCe_M)
            If ds.Tables(0).Rows.Count > 0 Then
                CbMun.DataSource = ds.Tables(0)
                CbMun.DisplayMember = "Mun"
                CbMun.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarBarriosActivos()
        Dim ds As New DataSet
        CbBarrio.DataSource = Nothing
        CbBarrio.Items.Clear()
        Try
            objCe_B.CodMun = Val(CbMun.SelectedValue.ToString)
            objCe_B.Zona = UCase(Mid(CbZona.Text.Trim, 1, 1))
            ds = objCn_B.Listar_Barrios_Activos(objCe_B)
            If ds.Tables(0).Rows.Count > 0 Then
                CbBarrio.DataSource = ds.Tables(0)
                CbBarrio.DisplayMember = "Barrio"
                CbBarrio.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarEpsActivos()
        Dim ds As New DataSet
        CbAseguradora.DataSource = Nothing
        CbAseguradora.Items.Clear()
        Try
            ds = objCn_E.ListarEpsActivo
            If ds.Tables(0).Rows.Count > 0 Then
                CbAseguradora.DataSource = ds.Tables(0)
                CbAseguradora.DisplayMember = "Eps"
                CbAseguradora.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarTipoUsuarioActivos()
        Dim ds As New DataSet
        CbTipoAfi.DataSource = Nothing
        CbTipoAfi.Items.Clear()
        Try
            ds = objCn_Tu.ListarTupoUsuarioActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTipoAfi.DataSource = ds.Tables(0)
                CbTipoAfi.DisplayMember = "Tipo"
                CbTipoAfi.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarGeneroActivos()
        Dim ds As New DataSet
        CbGenero.DataSource = Nothing
        CbGenero.Items.Clear()
        Try
            ds = objCn_G.ListarGenerosActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbGenero.DataSource = ds.Tables(0)
                CbGenero.DisplayMember = "Genero"
                CbGenero.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarNacionalidadActivas()
        Dim ds As New DataSet
        CbPais.DataSource = Nothing
        CbPais.Items.Clear()
        Try
            ds = objCn_N.Listar_NacionalidadActivas
            If ds.Tables(0).Rows.Count > 0 Then
                CbPais.DataSource = ds.Tables(0)
                CbPais.DisplayMember = "Nacionalidad"
                CbPais.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Function VerConsMun() As Integer
        Dim ds As New DataSet
        Try
            objCe_M.Mun = UCase(CbMun.Text.Trim)
            ds = objCn_M.Ver_Cons_Mun(objCe_M)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Function

    Function VerConsBarrio() As Integer
        Dim ds As New DataSet
        Try
            objCe_B.Barrio = UCase(CbBarrio.Text.Trim)
            ds = objCn_B.Ver_Cons_Barrio(objCe_B)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0).Item(0)
            Else
                Return 0
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Function

    Private Sub Frm_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 9, FontStyle.Regular)
        Botones1()
        Limpiar()
        Inhabilitar()
        Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        ListarTdocActivos()
        ListarDepActivos()
        ListarEpsActivos()
        ListarGeneroActivos()
        ListarNacionalidadActivas()
        ListarTipoUsuarioActivos()
    End Sub

    Private Sub CbDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDep.SelectedIndexChanged
        ListarMunActivos()
    End Sub

    Private Sub CbDep_Click(sender As Object, e As EventArgs) Handles CbDep.Click
        ListarMunActivos()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        DtFecNac.Value = Now
        Botones2()
        Limpiar()
        Habilitar()
        Op = "N"
        Dgv.Rows.Clear()
        CbTdoc.Focus()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "M"
        CbTdoc.Focus()
    End Sub

    Private Sub CbZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbZona.SelectedIndexChanged
        ListarBarriosActivos()
    End Sub

    Private Sub CbZona_Click(sender As Object, e As EventArgs) Handles CbZona.Click
        ListarBarriosActivos()
    End Sub

    Private Sub CbMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMun.SelectedIndexChanged
        ListarBarriosActivos()
    End Sub

    Private Sub CbMun_Click(sender As Object, e As EventArgs) Handles CbMun.Click
        ListarBarriosActivos()
    End Sub

    Private Sub BtnBarrio_Click(sender As Object, e As EventArgs) Handles BtnBarrio.Click
        Ba = 1
        Frm_Barrios.ShowDialog()
        ListarBarriosActivos()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Botones1()
        Limpiar()
        Inhabilitar()
        Op = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("¿Confirma que desea eliminar el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_U.Cons = Val(LbCons.Text.Trim)
                objCn_U.Eliminar_Usuario(objCe_U)
                Limpiar()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnAseguradora_Click(sender As Object, e As EventArgs) Handles BtnAseguradora.Click
        Frm_Aseguradoras.ShowDialog()
        ListarEpsActivos()
    End Sub

    Private Sub BtnNacionalidad_Click(sender As Object, e As EventArgs) Handles BtnNacionalidad.Click
        Frm_Nacionalidad.ShowDialog()
        ListarNacionalidadActivas()
    End Sub

    Private Sub AgregarEnfoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEnfoqueToolStripMenuItem.Click
        Frm_AddEnfoqueUsuario.ShowDialog()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Op = "N" Then
            Nuevo()
        End If

        If Op = "M" Then
            Modificar
        End If
    End Sub

    Function ExisteUsuario() As Boolean
        Dim ds As New DataSet
        Try
            objCe_U.Tdoc = Val(CbTdoc.SelectedValue.ToString)
            objCe_U.Doc = UCase(TbDoc.Text.Trim)
            ds = objCn_U.ExisteUsuario(objCe_U)
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
        If Val(CbTdoc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un tipo de documento válido", MsgBoxStyle.Critical)
            CbTdoc.Focus()
            Exit Sub
        End If
        If TbDoc.Text.Trim = "" Then
            MsgBox("Debe ingresar el documento", MsgBoxStyle.Critical)
            TbDoc.Focus()
            Exit Sub
        End If
        If TbNOmbre1.Text.Trim = "" Then
            MsgBox("Debe ingresar el primer nombre", MsgBoxStyle.Critical)
            TbNOmbre1.Focus()
            Exit Sub
        End If
        If TbApellido1.Text.Trim = "" Then
            MsgBox("Debe ingresar el primar apellido", MsgBoxStyle.Critical)
            TbApellido1.Focus()
            Exit Sub
        End If
        If Val(CbDep.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un departamento válido", MsgBoxStyle.Critical)
            CbDep.Focus()
            Exit Sub
        End If
        If Val(VerConsMun) < 1 Then
            MsgBox("Debe seleccionar un municipio válido", MsgBoxStyle.Critical)
            CbMun.Focus()
            Exit Sub
        End If
        If CbZona.Text.Trim <> "URBANA" And CbZona.Text.Trim <> "RURAL" Then
            MsgBox("Debe seleccionar una zona válida", MsgBoxStyle.Critical)
            CbZona.Focus()
            Exit Sub
        End If
        If Val(VerConsBarrio) < 1 Then
            MsgBox("Debe seleccionar un barrio o Vereda válida", MsgBoxStyle.Critical)
            CbBarrio.Focus()
            Exit Sub
        End If
        If Val(CbAseguradora.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar una aseguradora válida", MsgBoxStyle.Critical)
            CbAseguradora.Focus()
            Exit Sub
        End If
        If Val(CbTipoAfi.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un tipo de afiliación válido", MsgBoxStyle.Critical)
            CbTipoAfi.Focus()
            Exit Sub
        End If
        If Val(CbGenero.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un genero válido", MsgBoxStyle.Critical)
            CbGenero.Focus()
            Exit Sub
        End If
        If Val(CbPais.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar una nacionalidad válida", MsgBoxStyle.Critical)
            CbPais.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Nuevo Usuario")
            CbEstado.Focus()
            Exit Sub
        End If
        If ExisteUsuario() = True Then
            MsgBox("Ya existe un usuario con la misma identificación", MsgBoxStyle.Critical)
            TbDoc.Focus()
        Else
            If MsgBox("¿Confirma que desea registrar el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    objCe_U.Apellido1 = UCase(TbApellido1.Text.Trim)
                    objCe_U.Apellido2 = UCase(TbApellido2.Text.Trim)
                    objCe_U.Barrio = Val(CbBarrio.SelectedValue.ToString)
                    objCe_U.Dep = Val(CbDep.SelectedValue.ToString)
                    objCe_U.Dir = UCase(TbDir.Text.Trim)
                    objCe_U.Doc = UCase(TbDoc.Text.Trim)
                    objCe_U.EAPB = Val(CbAseguradora.SelectedValue.ToString)
                    objCe_U.TipoEAPB = Val(CbTipoAfi.SelectedValue.ToString)
                    If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_U.Estado = 1 : Else : objCe_U.Estado = 0 : End If
                    objCe_U.FecNac = Format(DtFecNac.Value.Date, "yyyy/MM/dd")
                    objCe_U.Genero = Val(CbGenero.SelectedValue.ToString)
                    objCe_U.Mun = Val(VerConsMun)
                    objCe_U.Nacionalidad = Val(CbPais.SelectedValue.ToString)
                    objCe_U.Nombre1 = UCase(TbNOmbre1.Text.Trim)
                    objCe_U.Nombre2 = UCase(TbNombre2.Text.Trim)
                    objCe_U.Tdoc = Val(CbTdoc.SelectedValue.ToString)
                    objCe_U.Zona = UCase(Mid(CbZona.Text, 1, 1))
                    objCe_U.Tel = TbTel.Text.Trim
                    objCn_U.Nuevo_Usuario(objCe_U)
                    Doc = UCase(TbDoc.Text.Trim)
                    Botones1()
                    Limpiar()
                    Inhabilitar()
                    Op = ""
                    VerUsuarioDoc()
                    If Val(LbCons.Text.Trim) > 0 Then
                        GuardarEnfoque()
                    End If
                    If Val(LbCons.Text.Trim) > 0 Then
                        ListarEnfoquesUsuario()
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub VerUsuarioDoc()
        Dim ds As New DataSet
        Try
            objCe_U.Doc = Doc
            ds = objCn_U.VerUsuarioDoc(objCe_U)
            If ds.Tables(0).Rows.Count > 0 Then
                LbCons.Text = ds.Tables(0).Rows(0).Item(0)
                CbTdoc.Text = ds.Tables(0).Rows(0).Item(1)
                TbDoc.Text = ds.Tables(0).Rows(0).Item(2)
                TbNOmbre1.Text = ds.Tables(0).Rows(0).Item(3)
                TbNombre2.Text = ds.Tables(0).Rows(0).Item(4)
                TbApellido1.Text = ds.Tables(0).Rows(0).Item(5)
                TbApellido2.Text = ds.Tables(0).Rows(0).Item(6)
                DtFecNac.Value = ds.Tables(0).Rows(0).Item(7)
                CbDep.Text = ds.Tables(0).Rows(0).Item(8)
                CbMun.Text = ds.Tables(0).Rows(0).Item(9)
                If ds.Tables(0).Rows(0).Item(10) = "U" Then
                    CbZona.Text = "URBANA"
                Else
                    CbZona.Text = "RURAL"
                End If
                CbBarrio.Text = ds.Tables(0).Rows(0).Item(11)
                TbDir.Text = ds.Tables(0).Rows(0).Item(12)
                TbTel.Text = ds.Tables(0).Rows(0).Item(13)
                CbAseguradora.Text = ds.Tables(0).Rows(0).Item(14)
                CbTipoAfi.Text = ds.Tables(0).Rows(0).Item(15)
                CbGenero.Text = ds.Tables(0).Rows(0).Item(16)
                CbPais.Text = ds.Tables(0).Rows(0).Item(17)
                CbEstado.Text = ds.Tables(0).Rows(0).Item(18)
                ListarEnfoquesUsuario()
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub VerUsuarioCons()
        Dim ds As New DataSet
        Try
            objCe_U.Cons = Val(LbCons.Text.Trim)
            ds = objCn_U.VerUsuarioCons(objCe_U)
            If ds.Tables(0).Rows.Count > 0 Then
                '     LbCons.Text = ds.Tables(0).Rows(0).Item(0)
                CbTdoc.Text = ds.Tables(0).Rows(0).Item(1)
                TbDoc.Text = ds.Tables(0).Rows(0).Item(2)
                TbNOmbre1.Text = ds.Tables(0).Rows(0).Item(3)
                TbNombre2.Text = ds.Tables(0).Rows(0).Item(4)
                TbApellido1.Text = ds.Tables(0).Rows(0).Item(5)
                TbApellido2.Text = ds.Tables(0).Rows(0).Item(6)
                DtFecNac.Value = ds.Tables(0).Rows(0).Item(7)
                CbDep.Text = ds.Tables(0).Rows(0).Item(8)
                CbMun.Text = ds.Tables(0).Rows(0).Item(9)
                If ds.Tables(0).Rows(0).Item(10) = "U" Then
                    CbZona.Text = "URBANA"
                Else
                    CbZona.Text = "RURAL"
                End If
                CbBarrio.Text = ds.Tables(0).Rows(0).Item(11)
                TbDir.Text = ds.Tables(0).Rows(0).Item(12)
                TbTel.Text = ds.Tables(0).Rows(0).Item(13)
                CbAseguradora.Text = ds.Tables(0).Rows(0).Item(14)
                CbTipoAfi.Text = ds.Tables(0).Rows(0).Item(15)
                CbGenero.Text = ds.Tables(0).Rows(0).Item(16)
                CbPais.Text = ds.Tables(0).Rows(0).Item(17)
                CbEstado.Text = ds.Tables(0).Rows(0).Item(18)
                ListarEnfoquesUsuario()
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub GuardarEnfoque()
        Dim c As Integer = Dgv.Rows.Count
        If c > 0 Then
            Dim i As Integer = 0
            Do
                If Val(Dgv.Item(0, i).Value) = False Then
                    Try
                        objCe_Ue.Usuario = Val(LbCons.Text)
                        objCe_Ue.Enfoque = Val(Dgv.Item(1, i).Value)
                        objCn_Ue.Nuevo_UsuarioEnfoque(objCe_Ue)
                    Catch ex As Exception
                    End Try
                End If
                i = i + 1
            Loop Until i = c
        End If
    End Sub

    Private Sub ListarEnfoquesUsuario()
        Dim ds As New DataSet
        Dgv.Rows.Clear()
        Try
            objCe_Ue.Usuario = Val(LbCons.Text)
            ds = objCn_Ue.ListarUsuarioEnfoques(objCe_Ue)
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim i As Integer = 0
                Do
                    Dgv.Rows.Add()
                    Dgv.Item(0, i).Value = ds.Tables(0).Rows(i).Item(0)
                    Dgv.Item(1, i).Value = ds.Tables(0).Rows(i).Item(1)
                    Dgv.Item(2, i).Value = ds.Tables(0).Rows(i).Item(2)
                    i = i + 1
                Loop Until i = c
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Modificar()
        If Val(CbTdoc.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un tipo de documento válido", MsgBoxStyle.Critical)
            CbTdoc.Focus()
            Exit Sub
        End If
        If TbDoc.Text.Trim = "" Then
            MsgBox("Debe ingresar el documento", MsgBoxStyle.Critical)
            TbDoc.Focus()
            Exit Sub
        End If
        If TbNOmbre1.Text.Trim = "" Then
            MsgBox("Debe ingresar el primer nombre", MsgBoxStyle.Critical)
            TbNOmbre1.Focus()
            Exit Sub
        End If
        If TbApellido1.Text.Trim = "" Then
            MsgBox("Debe ingresar el primar apellido", MsgBoxStyle.Critical)
            TbApellido1.Focus()
            Exit Sub
        End If
        If Val(CbDep.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un departamento válido", MsgBoxStyle.Critical)
            CbDep.Focus()
            Exit Sub
        End If
        If Val(VerConsMun) < 1 Then
            MsgBox("Debe seleccionar un municipio válido", MsgBoxStyle.Critical)
            CbMun.Focus()
            Exit Sub
        End If
        If CbZona.Text.Trim <> "URBANA" And CbZona.Text.Trim <> "RURAL" Then
            MsgBox("Debe seleccionar una zona válida", MsgBoxStyle.Critical)
            CbZona.Focus()
            Exit Sub
        End If
        If Val(VerConsBarrio) < 1 Then
            MsgBox("Debe seleccionar un barrio o Vereda válida", MsgBoxStyle.Critical)
            CbBarrio.Focus()
            Exit Sub
        End If
        If Val(CbAseguradora.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar una aseguradora válida", MsgBoxStyle.Critical)
            CbAseguradora.Focus()
            Exit Sub
        End If
        If Val(CbTipoAfi.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un tipo de afiliación válido", MsgBoxStyle.Critical)
            CbTipoAfi.Focus()
            Exit Sub
        End If
        If Val(CbGenero.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar un genero válido", MsgBoxStyle.Critical)
            CbGenero.Focus()
            Exit Sub
        End If
        If Val(CbPais.SelectedValue.ToString) = 0 Then
            MsgBox("Debe seleccionar una nacionalidad válida", MsgBoxStyle.Critical)
            CbPais.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado", MsgBoxStyle.Critical, "Nuevo Usuario")
            CbEstado.Focus()
            Exit Sub
        End If
        If MsgBox("¿Confirma que desea modificar el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_U.Cons = Val(LbCons.Text.Trim)
                objCe_U.Apellido1 = UCase(TbApellido1.Text.Trim)
                objCe_U.Apellido2 = UCase(TbApellido2.Text.Trim)
                objCe_U.Barrio = Val(VerConsBarrio)
                objCe_U.Dep = Val(CbDep.SelectedValue.ToString)
                objCe_U.Dir = UCase(TbDir.Text.Trim)
                objCe_U.Doc = UCase(TbDoc.Text.Trim)
                objCe_U.EAPB = Val(CbAseguradora.SelectedValue.ToString)
                objCe_U.TipoEAPB = Val(CbTipoAfi.SelectedValue.ToString)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_U.Estado = 1 : Else : objCe_U.Estado = 0 : End If
                objCe_U.FecNac = Format(DtFecNac.Value.Date, "yyyy/MM/dd")
                objCe_U.Genero = Val(CbGenero.SelectedValue.ToString)
                objCe_U.Mun = Val(VerConsMun)
                objCe_U.Nacionalidad = Val(CbPais.SelectedValue.ToString)
                objCe_U.Nombre1 = UCase(TbNOmbre1.Text.Trim)
                objCe_U.Nombre2 = UCase(TbNombre2.Text.Trim)
                objCe_U.Tdoc = Val(CbTdoc.SelectedValue.ToString)
                objCe_U.Zona = UCase(Mid(CbZona.Text, 1, 1))
                objCe_U.Tel = TbTel.Text.Trim
                objCn_U.Modificar_Usuario(objCe_U)
                Doc = UCase(TbDoc.Text.Trim)
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
                VerUsuarioDoc()
                If Val(LbCons.Text.Trim) > 0 Then
                    GuardarEnfoque()
                End If
                If Val(LbCons.Text.Trim) > 0 Then
                    ListarEnfoquesUsuario()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Bu = 1
        Frm_Usuario_Buscar.ShowDialog()
        VerUsuarioCons
    End Sub

    Private Sub EliminarEnfoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarEnfoqueToolStripMenuItem.Click
        Dim i As Integer = Dgv.CurrentRow.Index
        If MsgBox("¿Confirma que desea eliminar el enfoque " & Dgv.Item(2, i).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_Ue.Cons = Val(Dgv.Item(0, i).Value)
                objCn_Ue.Eliminar_UsuarioEnfoque(objCe_Ue)
                ListarEnfoquesUsuario()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class