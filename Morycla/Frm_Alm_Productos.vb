Imports C_Entidad
Imports C_Negocio
Public Class Frm_Alm_Productos
    Dim Op As String = ""
    Dim objCe_P As New Ce_Alm_Productos

    Dim objCn_P As New Cn_Alm_Productos
    Dim objCn_Tp As New Cn_Alm_TipoProd
    Dim objCn_Tm As New Cn_Alm_TipoMed
    Dim objCn_F As New Cn_Alm_MedForma
    Dim objCe_C As New Ce_CCostos
    Dim objCn_C As New Cn_CCostos

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

    Sub Habilitar()
        TbATC.Enabled = True
        TbConcent.Enabled = True
        TbDescrip.Enabled = True
        TbMinimo.Enabled = True
        TbPresent.Enabled = True
        TbRiesgo.Enabled = True
        TbTemp.Enabled = True
        TbUnidad.Enabled = True
        CbEstado.Enabled = True
        CbForma.Enabled = True
        CbTipoMed.Enabled = True
        CbTProd.Enabled = True
        CbCostos.Enabled = True
    End Sub

    Sub Inhabilitar()
        TbATC.Enabled = False
        TbConcent.Enabled = False
        TbDescrip.Enabled = False
        TbMinimo.Enabled = False
        TbPresent.Enabled = False
        TbRiesgo.Enabled = False
        TbTemp.Enabled = False
        TbUnidad.Enabled = False
        CbEstado.Enabled = False
        CbForma.Enabled = False
        CbTipoMed.Enabled = False
        CbTProd.Enabled = False
        CbCostos.Enabled = False
    End Sub

    Private Sub Limpiar()
        TbCons.Text = ""
        TbATC.Text = ""
        TbConcent.Text = ""
        TbDescrip.Text = ""
        TbMinimo.Text = ""
        TbPresent.Text = ""
        TbRiesgo.Text = ""
        TbTemp.Text = ""
        TbUnidad.Text = ""
        CbEstado.Text = ""
        CbForma.Text = ""
        CbTipoMed.Text = ""
        CbTProd.Text = ""
        CbCostos.Text = ""
    End Sub

    Private Sub ListarTipoProd()
        Dim ds As New DataSet
        CbTProd.DataSource = Nothing
        CbTProd.Items.Clear()
        Try
            ds = objCn_Tp.ListarTipoProdActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTProd.DataSource = ds.Tables(0)
                CbTProd.DisplayMember = "Tipo"
                CbTProd.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarTipoMed()
        Dim ds As New DataSet
        CbTipoMed.DataSource = Nothing
        CbTipoMed.Items.Clear()
        Try
            ds = objCn_Tm.ListarTipoMedActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbTipoMed.DataSource = ds.Tables(0)
                CbTipoMed.DisplayMember = "Tipo"
                CbTipoMed.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarForma()
        Dim ds As New DataSet
        CbForma.DataSource = Nothing
        CbForma.Items.Clear()
        Try
            ds = objCn_F.ListarMedFormaActivos
            If ds.Tables(0).Rows.Count > 0 Then
                CbForma.DataSource = ds.Tables(0)
                CbForma.DisplayMember = "Forma"
                CbForma.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub ListarCostos()
        Dim ds As New DataSet
        CbCostos.DataSource = Nothing
        CbCostos.Items.Clear()
        Try
            ds = objCn_C.ListarCCostoActivo
            If ds.Tables(0).Rows.Count > 0 Then
                CbCostos.DataSource = ds.Tables(0)
                CbCostos.DisplayMember = "CCosto"
                CbCostos.ValueMember = "Cons"
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub Frm_Alm_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Font = New Font("Arial", 8, FontStyle.Regular)
        ListarTipoProd()
        ListarForma()
        ListarTipoMed()
        ListarCostos()
        Botones1()
        Limpiar()
        Inhabilitar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Botones2()
        Limpiar()
        Habilitar()
        TbTemp.Text = "Menor a 30°C"
        Op = "N"
        CbEstado.Text = "ACTIVO"
        CbTProd.Focus()
    End Sub

    Private Sub CbTProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTProd.SelectedIndexChanged
        If CbTProd.Text = "MEDICAMENTO" Then
            CbForma.Text = ""
            TbConcent.Text = ""
            CbTipoMed.Text = ""
            CbTipoMed.Text = ""
            TbATC.Text = ""
            TbPresent.Text = ""
            TbRiesgo.Text = ""
            CbForma.Enabled = True
            TbConcent.Enabled = True
            CbTipoMed.Enabled = True
            TbATC.Enabled = True
            TbPresent.Enabled = True
            TbRiesgo.Enabled = False
        Else
            CbForma.Text = ""
            TbConcent.Text = ""
            CbTipoMed.Text = ""
            TbATC.Text = ""
            TbPresent.Text = ""
            CbForma.Enabled = False
            TbConcent.Enabled = False
            CbTipoMed.Enabled = False
            TbATC.Enabled = False
            TbPresent.Enabled = False
            TbRiesgo.Enabled = True
        End If
    End Sub

    Private Sub CbTProd_Click(sender As Object, e As EventArgs) Handles CbTProd.Click

    End Sub

    Private Sub Nuevo()
        If TbDescrip.Text.Trim = "" Then
            MsgBox("Debe indicar la descripción", MsgBoxStyle.Critical)
            TbDescrip.Focus()
            Exit Sub
        End If

        If TbUnidad.Text.Trim = "" Then
            MsgBox("Debe indicar la unidad de medida", MsgBoxStyle.Critical)
            TbUnidad.Focus()
            Exit Sub
        End If

        If CbTProd.Text = "MEDICAMENTO" Then
            If TbATC.Text.Trim = "" Then
                MsgBox("Debe indicar el código ATC", MsgBoxStyle.Critical)
                TbATC.Focus()
                Exit Sub
            End If
            If TbPresent.Text.Trim = "" Then
                MsgBox("Debe indicar la presentción", MsgBoxStyle.Critical)
                TbPresent.Focus()
                Exit Sub
            End If
            If TbConcent.Text.Trim = "" Then
                MsgBox("Debe indicar la concentración", MsgBoxStyle.Critical)
                TbConcent.Focus()
                Exit Sub
            End If
            If Val(CbForma.SelectedValue.ToString) = 0 Then
                MsgBox("Debe seleccionar la forma farmacéutica", MsgBoxStyle.Critical)
                CbForma.Focus()
                Exit Sub
            End If
            If Val(CbTipoMed.SelectedValue.ToString) = 0 Then
                MsgBox("Debe seleccionar el tipo de medicamento", MsgBoxStyle.Critical)
                CbTipoMed.Focus()
                Exit Sub
            End If
        End If

        If CbTProd.Text <> "MEDICAMENTO" Then
            If TbRiesgo.Text.Trim = "" Then
                MsgBox("Debe indicar el riesgo", MsgBoxStyle.Critical)
                TbRiesgo.Focus()
                Exit Sub
            End If
        End If
        If TbTemp.Text.Trim = "" Then
            MsgBox("Debe indicar la temperatura de almacenamiento", MsgBoxStyle.Critical)
            TbTemp.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del producto", MsgBoxStyle.Critical, "Nueva Producto")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea registrar el producto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.ATC = UCase(TbATC.Text.Trim)
                objCe_P.Descripcion = UCase(TbDescrip.Text.Trim)
                objCe_P.Presentacion = UCase(TbPresent.Text.Trim)
                objCe_P.Concentracion = LCase(TbConcent.Text.Trim)
                objCe_P.Forma = Val(CbForma.SelectedValue.ToString)
                If CbTProd.Text.Trim = "MEDICAMENTO" Then
                    objCe_P.Unidad = LCase(TbUnidad.Text.Trim)
                Else
                    objCe_P.Unidad = UCase(TbUnidad.Text.Trim)
                End If
                objCe_P.Temperatura = UCase(TbTemp.Text.Trim)
                objCe_P.Minimo = Val(TbMinimo.Text.Trim)
                objCe_P.Riesgo = UCase(TbRiesgo.Text.Trim)
                objCe_P.TipoMed = Val(CbTipoMed.SelectedValue.ToString)
                objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_P.Estado = 1 : Else : objCe_P.Estado = 0 : End If
                objCe_P.CCostos = Val(CbCostos.SelectedValue.ToString)
                objCn_P.NuevoProducto(objCe_P)
                Accion = "REGISTRO DE PRODUCTO  " & UCase(TbDescrip.Text) & " " & UCase(TbConcent.Text) & " " & UCase(TbPresent.Text)
                RegistrarAuditoria()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Actualizar()
        If TbDescrip.Text.Trim = "" Then
            MsgBox("Debe indicar la descripción", MsgBoxStyle.Critical)
            TbDescrip.Focus()
            Exit Sub
        End If
        If TbPresent.Text.Trim = "" Then
            MsgBox("Debe indicar la presentción", MsgBoxStyle.Critical)
            TbPresent.Focus()
            Exit Sub
        End If
        If TbUnidad.Text.Trim = "" Then
            MsgBox("Debe indicar la unidad de medida", MsgBoxStyle.Critical)
            TbUnidad.Focus()
            Exit Sub
        End If

        If CbTProd.Text = "MEDICAMENTO" Then
            If TbATC.Text.Trim = "" Then
                MsgBox("Debe indicar el código ATC", MsgBoxStyle.Critical)
                TbATC.Focus()
                Exit Sub
            End If
            If TbConcent.Text.Trim = "" Then
                MsgBox("Debe indicar la concentración", MsgBoxStyle.Critical)
                TbConcent.Focus()
                Exit Sub
            End If
            If Val(CbForma.SelectedValue.ToString) = 0 Then
                MsgBox("Debe seleccionar la forma farmacéutica", MsgBoxStyle.Critical)
                CbForma.Focus()
                Exit Sub
            End If
            If Val(CbTipoMed.SelectedValue.ToString) = 0 Then
                MsgBox("Debe seleccionar el tipo de medicamento", MsgBoxStyle.Critical)
                CbTipoMed.Focus()
                Exit Sub
            End If
        End If

        If CbTipoMed.Text <> "MEDICAMENTO" Then
            If TbRiesgo.Text.Trim = "" Then
                MsgBox("Debe indicar el riesgo", MsgBoxStyle.Critical)
                TbRiesgo.Focus()
                Exit Sub
            End If
        End If
        If TbTemp.Text.Trim = "" Then
            MsgBox("Debe indicar la temperatura de almacenamiento", MsgBoxStyle.Critical)
            TbTemp.Focus()
            Exit Sub
        End If
        If CbEstado.Text.Trim <> "ACTIVO" And CbEstado.Text.Trim <> "INACTIVO" Then
            MsgBox("Debe indicar el estado del producto", MsgBoxStyle.Critical, "Nueva Producto")
            CbEstado.Focus()
            Exit Sub
        End If

        If MsgBox("¿Confirma que desea modificar el producto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.Cons = Val(TbCons.Text.Trim)
                objCe_P.ATC = UCase(TbATC.Text.Trim)
                objCe_P.Descripcion = UCase(TbDescrip.Text.Trim)
                objCe_P.Presentacion = UCase(TbPresent.Text.Trim)
                objCe_P.Concentracion = LCase(TbConcent.Text.Trim)
                If Val(CbTProd.SelectedValue.ToString) <> 1 Or UCase(CbTProd.Text <> "MEDICAMENTO") Then
                    objCe_P.Forma = ""
                Else
                    objCe_P.Forma = Val(CbForma.SelectedValue.ToString)
                End If
                objCe_P.Unidad = LCase(TbUnidad.Text.Trim)
                objCe_P.Temperatura = UCase(TbTemp.Text.Trim)
                objCe_P.Minimo = Val(TbMinimo.Text.Trim)
                objCe_P.Riesgo = UCase(TbRiesgo.Text.Trim)
                objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
                objCe_P.TipoMed = Val(CbTipoMed.SelectedValue.ToString)
                If UCase(CbEstado.Text.Trim) = "ACTIVO" Then : objCe_P.Estado = 1 : Else : objCe_P.Estado = 0 : End If
                objCe_P.CCostos = Val(CbCostos.SelectedValue.ToString)
                objCn_P.ModificarProducto(objCe_P)
                Accion = "MODIFICACION DE PRODUCTO CONS: " & TbCons.Text
                RegistrarAuditoria()
                Botones1()
                Limpiar()
                Inhabilitar()
                Op = ""
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Botones2()
        Habilitar()
        Op = "A"
        TbDescrip.Focus()
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
        If MsgBox("¿Confirma que desea eliminar el producto? - Esta acción no se podrá deshacer", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                objCe_P.Cons = Val(TbCons.Text.Trim)
                objCn_P.EliminarProducto(objCe_P)
                Accion = "ELIMINACION DE PRODUCTO CONS: " & TbCons.Text & " - " & UCase(TbDescrip.Text)
                RegistrarAuditoria()
                Limpiar()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CbTProd_LostFocus(sender As Object, e As EventArgs) Handles CbTProd.LostFocus
        If CbTProd.Text = "MEDICAMENTO" Then
            CbForma.Text = ""
            TbConcent.Text = ""
            CbTipoMed.Text = ""
            CbTipoMed.Text = ""
            TbATC.Text = ""
            TbPresent.Text = ""
            TbRiesgo.Text = ""
            CbForma.Enabled = True
            TbConcent.Enabled = True
            CbTipoMed.Enabled = True
            TbATC.Enabled = True
            TbPresent.Enabled = True
            TbRiesgo.Enabled = False

        Else

            CbForma.Text = ""
            TbConcent.Text = ""
            CbTipoMed.Text = ""
            TbATC.Text = ""
            TbPresent.Text = ""

            CbForma.Enabled = False
            TbConcent.Enabled = False
            CbTipoMed.Enabled = False
            TbATC.Enabled = False
            TbPresent.Enabled = False
            TbRiesgo.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Limpiar()
        BProd = 1
        Frm_Alm_BuscarProd.TopLevel = False
        Frm_Alm_BuscarProd.FormBorderStyle = FormBorderStyle.None
        Frm_Alm_BuscarProd.Dock = DockStyle.Fill
        FrmAlmacen.PanelContenedor.Controls.Add(Frm_Alm_BuscarProd)
        FrmAlmacen.PanelContenedor.Tag = Frm_Alm_BuscarProd
        Frm_Alm_BuscarProd.BringToFront()
        Frm_Alm_BuscarProd.Show()
    End Sub

    Private Sub ListarProductoCons()
        Dim ds As New DataSet
        Try
            objCe_P.Cons = Val(TbCons.Text.Trim)
            ds = objCn_P.LitarProductosCons(objCe_P)
            If ds.Tables(0).Rows.Count > 0 Then
                ' TbCons.Text = ds.Tables(0).Rows(0).Item(0)
                CbTProd.Text = ds.Tables(0).Rows(0).Item(1)
                If IsDBNull(ds.Tables(0).Rows(0).Item(1)) = False Then
                    CbTProd.Text = ds.Tables(0).Rows(0).Item(1)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(2)) = False Then
                    TbATC.Text = ds.Tables(0).Rows(0).Item(2)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(3)) = False Then
                    TbDescrip.Text = ds.Tables(0).Rows(0).Item(3)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(4)) = False Then
                    TbConcent.Text = ds.Tables(0).Rows(0).Item(4)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(5)) = False Then
                    TbPresent.Text = ds.Tables(0).Rows(0).Item(5)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(6)) = False Then
                    CbForma.Text = ds.Tables(0).Rows(0).Item(6)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(7)) = False Then
                    TbUnidad.Text = ds.Tables(0).Rows(0).Item(7)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(8)) = False Then
                    TbTemp.Text = ds.Tables(0).Rows(0).Item(8)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(9)) = False Then
                    TbMinimo.Text = ds.Tables(0).Rows(0).Item(9)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(10)) = False Then
                    TbRiesgo.Text = ds.Tables(0).Rows(0).Item(10)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(11)) = False Then
                    CbTipoMed.Text = ds.Tables(0).Rows(0).Item(11)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(12)) = False Then
                    CbEstado.Text = ds.Tables(0).Rows(0).Item(12)
                End If
                If IsDBNull(ds.Tables(0).Rows(0).Item(13)) = False Then
                    CbCostos.Text = ds.Tables(0).Rows(0).Item(13)
                End If
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub TbCons_OnValueChanged(sender As Object, e As EventArgs) Handles TbCons.OnValueChanged
        ListarProductoCons()
    End Sub

    Private Sub TbCons_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles TbCons.ChangeUICues
        ListarProductoCons()
    End Sub

    Private Sub BtnForma_Click(sender As Object, e As EventArgs) Handles BtnForma.Click
        Frm_Alm_MedForma.ShowDialog()
        ListarForma()
    End Sub

    Private Sub BtnTipoMed_Click(sender As Object, e As EventArgs) Handles BtnTipoMed.Click
        Frm_Alm_TipoMed.ShowDialog()
        ListarTipoMed()
    End Sub

    Private Sub TbDescrip_OnValueChanged(sender As Object, e As EventArgs) Handles TbDescrip.OnValueChanged
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            objCe_P.Descripcion = UCase(TbDescrip.Text.Trim)
            ds = objCn_P.LitarProductosSimilar(objCe_P)
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

    Private Sub TbDescrip_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles TbDescrip.ChangeUICues
        Dim ds As New DataSet
        Dgv.DataSource = Nothing
        Try
            objCe_P.TipoProd = Val(CbTProd.SelectedValue.ToString)
            objCe_P.Descripcion = UCase(TbDescrip.Text.Trim)
            ds = objCn_P.LitarProductosSimilar(objCe_P)
            If ds.Tables(0).Rows.Count > 0 Then
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                Dgv.DataSource = ds.Tables(0)
                Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
        Finally
            ds.Dispose()
        End Try
    End Sub

End Class