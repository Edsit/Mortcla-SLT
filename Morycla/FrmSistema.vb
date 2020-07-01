Public Class FrmSistema
    Private FormularioActivo As Form = Nothing
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
    Private Sub CentroDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroDeCostosToolStripMenuItem.Click
        AbrirFormularioHijo(FrmCcostos)
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        AbrirFormularioHijo(FrmProveedores)
    End Sub

    Private Sub SedesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SedesToolStripMenuItem.Click
        AbrirFormularioHijo(FrmSedes)
    End Sub

    Private Sub FormaFarmaceuticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaFarmaceuticaToolStripMenuItem.Click
        AbrirFormularioHijo(Frm_Alm_MedForma)
    End Sub

    Private Sub LaboratoriosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaboratoriosToolStripMenuItem1.Click
        AbrirFormularioHijo(Frm_Alm_Laboratorios)
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        AbrirFormularioHijo(Frm_Alm_Productos)
    End Sub

    Private Sub TipoDeProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeProductosToolStripMenuItem1.Click
        AbrirFormularioHijo(FrmAlm_TipoProd)
    End Sub

    Private Sub TipoDeSalidaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoDeSalidaToolStripMenuItem1.Click
        AbrirFormularioHijo(FrmAlm_TipoSalida)
    End Sub

    Private Sub TipoMedicamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoMedicamentoToolStripMenuItem1.Click
        AbrirFormularioHijo(Frm_Alm_TipoMed)
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        AbrirFormularioHijo(FrmDep)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub MunicipiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MunicipiosToolStripMenuItem.Click
        AbrirFormularioHijo(Frm_Mun)
    End Sub

    Private Sub CerrarAlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAlmacenesToolStripMenuItem.Click
        'AbrirFormularioHijo(FrmCierre)
        AbrirFormularioHijo(Frm_Cierre_Nuevo)
    End Sub

    Private Sub RepararLotesAbrilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepararLotesAbrilToolStripMenuItem.Click
        AbrirFormularioHijo(FrmArregloLotesAbril)
    End Sub

    Private Sub AlmacenesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem1.Click
        FrmAlmacenes.TopLevel = False
        FrmAlmacenes.FormBorderStyle = FormBorderStyle.None
        FrmAlmacenes.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FrmAlmacenes)
        PanelContenedor.Tag = FrmAlmacenes
        FrmAlmacenes.BringToFront()
        FrmAlmacenes.Show()
    End Sub

    Private Sub AutorizarAlmacénToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizarAlmacénToolStripMenuItem.Click
        Frm_AlmacenFunc.TopLevel = False
        Frm_AlmacenFunc.FormBorderStyle = FormBorderStyle.None
        Frm_AlmacenFunc.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(Frm_AlmacenFunc)
        PanelContenedor.Tag = Frm_AlmacenFunc
        Frm_AlmacenFunc.BringToFront()
        Frm_AlmacenFunc.Show()
    End Sub

    Private Sub AreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreasToolStripMenuItem.Click
        Frm_Areas.ShowDialog()
    End Sub

    Private Sub RecatarCantidadInicialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecatarCantidadInicialToolStripMenuItem.Click
        FrmRescate.ShowDialog()
    End Sub
End Class