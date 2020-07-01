Public Class FrmAlmacen
    Private FormularioActivo As Form = Nothing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub SedesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SedesToolStripMenuItem.Click
        AbrirFormularioHijo(FrmSedes)
    End Sub

    Private Sub AbrirFormularioHijo(FormularioHijo As Form)
        On Error Resume Next
        If FormularioActivo IsNot Nothing Then
            FormularioActivo.Dispose()
            FormularioActivo.Close()
        End If
        FormularioActivo = FormularioHijo
        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FormularioHijo)
        PanelContenedor.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()
    End Sub

    Private Sub TipoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeProductosToolStripMenuItem.Click
        ' AbrirFormularioHijo(FrmAlm_TipoProd)
        FrmAlm_TipoProd.TopLevel = False
        FrmAlm_TipoProd.FormBorderStyle = FormBorderStyle.None
        FrmAlm_TipoProd.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmAlm_TipoProd)
        PanelContenedor.Tag = FrmAlm_TipoProd
        FrmAlm_TipoProd.BringToFront()
        FrmAlm_TipoProd.Show()
    End Sub

    Private Sub TipoDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeSalidaToolStripMenuItem.Click
        ' AbrirFormularioHijo(FrmAlm_TipoSalida)
        FrmAlm_TipoSalida.TopLevel = False
        FrmAlm_TipoSalida.FormBorderStyle = FormBorderStyle.None
        FrmAlm_TipoSalida.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmAlm_TipoSalida)
        PanelContenedor.Tag = FrmAlm_TipoSalida
        FrmAlm_TipoSalida.BringToFront()
        FrmAlm_TipoSalida.Show()
    End Sub

    Private Sub FormaFarmacéuticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaFarmacéuticaToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_Alm_MedForma)
        Frm_Alm_MedForma.TopLevel = False
        Frm_Alm_MedForma.FormBorderStyle = FormBorderStyle.None
        Frm_Alm_MedForma.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Alm_MedForma)
        PanelContenedor.Tag = Frm_Alm_MedForma
        Frm_Alm_MedForma.BringToFront()
        Frm_Alm_MedForma.Show()
    End Sub

    Private Sub TipoMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoMedicamentoToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_Alm_TipoMed)
        Frm_Alm_TipoMed.TopLevel = False
        Frm_Alm_TipoMed.FormBorderStyle = FormBorderStyle.None
        Frm_Alm_TipoMed.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Alm_TipoMed)
        PanelContenedor.Tag = Frm_Alm_TipoMed
        Frm_Alm_TipoMed.BringToFront()
        Frm_Alm_TipoMed.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_Alm_Productos)
        Frm_Alm_Productos.TopLevel = False
        Frm_Alm_Productos.FormBorderStyle = FormBorderStyle.None
        Frm_Alm_Productos.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Alm_Productos)
        PanelContenedor.Tag = Frm_Alm_Productos
        Frm_Alm_Productos.BringToFront()
        Frm_Alm_Productos.Show()
    End Sub

    Private Sub LaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaboratoriosToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_Alm_Laboratorios)
        Frm_Alm_Laboratorios.TopLevel = False
        Frm_Alm_Laboratorios.FormBorderStyle = FormBorderStyle.None
        Frm_Alm_Laboratorios.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Alm_Laboratorios)
        PanelContenedor.Tag = Frm_Alm_Laboratorios
        Frm_Alm_Laboratorios.BringToFront()
        Frm_Alm_Laboratorios.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmProveedores)
        FrmProveedores.TopLevel = False
        FrmProveedores.FormBorderStyle = FormBorderStyle.None
        FrmProveedores.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmProveedores)
        PanelContenedor.Tag = FrmProveedores
        FrmProveedores.BringToFront()
        FrmProveedores.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        ' AbrirFormularioHijo(FrmEntradas)
        FrmEntradas.TopLevel = False
        FrmEntradas.FormBorderStyle = FormBorderStyle.None
        FrmEntradas.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmEntradas)
        PanelContenedor.Tag = FrmEntradas
        FrmEntradas.BringToFront()
        FrmEntradas.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmSalidas)
        FrmSalidas.TopLevel = False
        FrmSalidas.FormBorderStyle = FormBorderStyle.None
        FrmSalidas.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmSalidas)
        PanelContenedor.Tag = FrmSalidas
        FrmSalidas.BringToFront()
        FrmSalidas.Show()
    End Sub


    Private Sub KardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmKardex)
        FrmKardex.TopLevel = False
        FrmKardex.FormBorderStyle = FormBorderStyle.None
        FrmKardex.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmKardex)
        PanelContenedor.Tag = FrmKardex
        FrmKardex.BringToFront()
        FrmKardex.Show()
    End Sub

    Private Sub CierreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmCierre)
        FrmCierre.TopLevel = False
        FrmCierre.FormBorderStyle = FormBorderStyle.None
        FrmCierre.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmCierre)
        PanelContenedor.Tag = FrmCierre
        FrmCierre.BringToFront()
        FrmCierre.Show()
    End Sub

    Private Sub ActaDeBajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActaDeBajaToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmBajas)
        FrmBajas.TopLevel = False
        FrmBajas.FormBorderStyle = FormBorderStyle.None
        FrmBajas.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmBajas)
        PanelContenedor.Tag = FrmBajas
        FrmBajas.BringToFront()
        FrmBajas.Show()
    End Sub

    Private Sub ActasDeBajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActasDeBajaToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmActaBaja)
        FrmActaBaja.TopLevel = False
        FrmActaBaja.FormBorderStyle = FormBorderStyle.None
        FrmActaBaja.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmActaBaja)
        PanelContenedor.Tag = FrmActaBaja
        FrmActaBaja.BringToFront()
        FrmActaBaja.Show()
    End Sub

    Private Sub CentroDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroDeCostosToolStripMenuItem.Click
        ' AbrirFormularioHijo(FrmCcostos)
        FrmCcostos.TopLevel = False
        FrmCcostos.FormBorderStyle = FormBorderStyle.None
        FrmCcostos.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmCcostos)
        PanelContenedor.Tag = FrmCcostos
        FrmCcostos.BringToFront()
        FrmCcostos.Show()
    End Sub

    Private Sub StopDeAreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopDeAreasToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_Alm_Stop_Areas)

    End Sub

    Private Sub TrasldosStopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrasldosStopToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmStop)
    End Sub

    Private Sub RecepciónTécnicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepciónTécnicaToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmAlmacen_Recepcion_Tecnica)
        FrmAlmacen_Recepcion_Tecnica.TopLevel = False
        FrmAlmacen_Recepcion_Tecnica.FormBorderStyle = FormBorderStyle.None
        FrmAlmacen_Recepcion_Tecnica.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmAlmacen_Recepcion_Tecnica)
        PanelContenedor.Tag = FrmAlmacen_Recepcion_Tecnica
        FrmAlmacen_Recepcion_Tecnica.BringToFront()
        FrmAlmacen_Recepcion_Tecnica.Show()
    End Sub

    Private Sub ProximosAVencerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProximosAVencerToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_Prox_Vencer)
        Frm_Prox_Vencer.TopLevel = False
        Frm_Prox_Vencer.FormBorderStyle = FormBorderStyle.None
        Frm_Prox_Vencer.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Prox_Vencer)
        PanelContenedor.Tag = Frm_Prox_Vencer
        Frm_Prox_Vencer.BringToFront()
        Frm_Prox_Vencer.Show()
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        ' AbrirFormularioHijo(Frm_Ajustes)
        Frm_Ajustes.TopLevel = False
        Frm_Ajustes.FormBorderStyle = FormBorderStyle.None
        Frm_Ajustes.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Ajustes)
        PanelContenedor.Tag = Frm_Ajustes
        Frm_Ajustes.BringToFront()
        Frm_Ajustes.Show()
    End Sub

    Private Sub CentrosDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentrosDeCostosToolStripMenuItem.Click
        'AbrirFormularioHijo(Frm_InformeCCostos)
        Frm_InformeCCostos.TopLevel = False
        Frm_InformeCCostos.FormBorderStyle = FormBorderStyle.None
        Frm_InformeCCostos.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_InformeCCostos)
        PanelContenedor.Tag = Frm_InformeCCostos
        Frm_InformeCCostos.BringToFront()
        Frm_InformeCCostos.Show()
    End Sub

    Private Sub EntradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem1.Click
        FrmEntradasSedeAdmin.TopLevel = False
        FrmEntradasSedeAdmin.FormBorderStyle = FormBorderStyle.None
        FrmEntradasSedeAdmin.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmEntradasSedeAdmin)
        PanelContenedor.Tag = FrmEntradasSedeAdmin
        FrmEntradasSedeAdmin.BringToFront()
        FrmEntradasSedeAdmin.Show()
    End Sub

    Private Sub EnviarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarToolStripMenuItem.Click
        Frm_Traslados.TopLevel = False
        Frm_Traslados.FormBorderStyle = FormBorderStyle.None
        Frm_Traslados.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_Traslados)
        PanelContenedor.Tag = Frm_Traslados
        Frm_Traslados.BringToFront()
        Frm_Traslados.Show()
    End Sub

    Private Sub RecibirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecibirToolStripMenuItem.Click
        FrmListarTraslado.TopLevel = False
        FrmListarTraslado.FormBorderStyle = FormBorderStyle.None
        FrmListarTraslado.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmListarTraslado)
        PanelContenedor.Tag = FrmListarTraslado
        FrmListarTraslado.BringToFront()
        FrmListarTraslado.Show()
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
        ' AbrirFormularioHijo(Frm_AlmacenEgresos)
        Frm_AlmacenEgresos.TopLevel = False
        Frm_AlmacenEgresos.FormBorderStyle = FormBorderStyle.None
        Frm_AlmacenEgresos.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_AlmacenEgresos)
        PanelContenedor.Tag = Frm_AlmacenEgresos
        Frm_AlmacenEgresos.BringToFront()
        Frm_AlmacenEgresos.Show()
    End Sub

    Private Sub PorTipoDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorTipoDeSalidaToolStripMenuItem.Click
        FrmEgresos.TopLevel = False
        FrmEgresos.FormBorderStyle = FormBorderStyle.None
        FrmEgresos.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmEgresos)
        PanelContenedor.Tag = FrmEgresos
        FrmEgresos.BringToFront()
        FrmEgresos.Show()
    End Sub

    Private Sub PorAreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorAreasToolStripMenuItem.Click
        FrmEgresosAreas.TopLevel = False
        FrmEgresosAreas.FormBorderStyle = FormBorderStyle.None
        FrmEgresosAreas.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmEgresosAreas)
        PanelContenedor.Tag = FrmEgresosAreas
        FrmEgresosAreas.BringToFront()
        FrmEgresosAreas.Show()
    End Sub

    Private Sub MovimientosDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeInventarioToolStripMenuItem.Click
        FrmInventarioMovimientos.TopLevel = False
        FrmInventarioMovimientos.FormBorderStyle = FormBorderStyle.None
        FrmInventarioMovimientos.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmInventarioMovimientos)
        PanelContenedor.Tag = FrmInventarioMovimientos
        FrmInventarioMovimientos.BringToFront()
        FrmInventarioMovimientos.Show()
    End Sub
End Class