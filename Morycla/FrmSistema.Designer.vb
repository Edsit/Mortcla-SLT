<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSistema
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSistema))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizarAlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormaFarmaceuticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoriosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TipoMedicamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeSalidaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CentroDeCostosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.UbicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MunicipiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepararLotesAbrilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RecatarCantidadInicialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(595, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cerrar Módulo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 29)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEMAS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 29)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(716, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneralesToolStripMenuItem
        '
        Me.GeneralesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacénToolStripMenuItem, Me.AreasToolStripMenuItem, Me.ToolStripMenuItem4, Me.CentroDeCostosToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProveedoresToolStripMenuItem, Me.ToolStripMenuItem3, Me.SedesToolStripMenuItem, Me.ToolStripMenuItem6, Me.UbicaciónToolStripMenuItem, Me.CerrarAlmacenesToolStripMenuItem, Me.RepararLotesAbrilToolStripMenuItem})
        Me.GeneralesToolStripMenuItem.Name = "GeneralesToolStripMenuItem"
        Me.GeneralesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.GeneralesToolStripMenuItem.Text = "Generales"
        '
        'AlmacénToolStripMenuItem
        '
        Me.AlmacénToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenesToolStripMenuItem1, Me.AutorizarAlmacénToolStripMenuItem, Me.FormaFarmaceuticaToolStripMenuItem, Me.LaboratoriosToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ProductosToolStripMenuItem1, Me.ToolStripMenuItem5, Me.TipoMedicamentoToolStripMenuItem1, Me.TipoDeProductosToolStripMenuItem1, Me.TipoDeSalidaToolStripMenuItem1, Me.RecatarCantidadInicialToolStripMenuItem})
        Me.AlmacénToolStripMenuItem.Name = "AlmacénToolStripMenuItem"
        Me.AlmacénToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlmacénToolStripMenuItem.Text = "Almacén"
        '
        'AlmacenesToolStripMenuItem1
        '
        Me.AlmacenesToolStripMenuItem1.Name = "AlmacenesToolStripMenuItem1"
        Me.AlmacenesToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.AlmacenesToolStripMenuItem1.Text = "Almacenes"
        '
        'AutorizarAlmacénToolStripMenuItem
        '
        Me.AutorizarAlmacénToolStripMenuItem.Name = "AutorizarAlmacénToolStripMenuItem"
        Me.AutorizarAlmacénToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AutorizarAlmacénToolStripMenuItem.Text = "Autorizar Almacén"
        '
        'FormaFarmaceuticaToolStripMenuItem
        '
        Me.FormaFarmaceuticaToolStripMenuItem.Name = "FormaFarmaceuticaToolStripMenuItem"
        Me.FormaFarmaceuticaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.FormaFarmaceuticaToolStripMenuItem.Text = "Forma Farmaceutica"
        '
        'LaboratoriosToolStripMenuItem1
        '
        Me.LaboratoriosToolStripMenuItem1.Name = "LaboratoriosToolStripMenuItem1"
        Me.LaboratoriosToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.LaboratoriosToolStripMenuItem1.Text = "Laboratorios"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(200, 6)
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(200, 6)
        '
        'TipoMedicamentoToolStripMenuItem1
        '
        Me.TipoMedicamentoToolStripMenuItem1.Name = "TipoMedicamentoToolStripMenuItem1"
        Me.TipoMedicamentoToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.TipoMedicamentoToolStripMenuItem1.Text = "Tipo Medicamento"
        '
        'TipoDeProductosToolStripMenuItem1
        '
        Me.TipoDeProductosToolStripMenuItem1.Name = "TipoDeProductosToolStripMenuItem1"
        Me.TipoDeProductosToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.TipoDeProductosToolStripMenuItem1.Text = "Tipo de Productos"
        '
        'TipoDeSalidaToolStripMenuItem1
        '
        Me.TipoDeSalidaToolStripMenuItem1.Name = "TipoDeSalidaToolStripMenuItem1"
        Me.TipoDeSalidaToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.TipoDeSalidaToolStripMenuItem1.Text = "Tipo de Salida"
        '
        'AreasToolStripMenuItem
        '
        Me.AreasToolStripMenuItem.Name = "AreasToolStripMenuItem"
        Me.AreasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AreasToolStripMenuItem.Text = "Areas"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(177, 6)
        '
        'CentroDeCostosToolStripMenuItem
        '
        Me.CentroDeCostosToolStripMenuItem.Name = "CentroDeCostosToolStripMenuItem"
        Me.CentroDeCostosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CentroDeCostosToolStripMenuItem.Text = "Centro de Costos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'SedesToolStripMenuItem
        '
        Me.SedesToolStripMenuItem.Name = "SedesToolStripMenuItem"
        Me.SedesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SedesToolStripMenuItem.Text = "Sedes"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(177, 6)
        '
        'UbicaciónToolStripMenuItem
        '
        Me.UbicaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.MunicipiosToolStripMenuItem})
        Me.UbicaciónToolStripMenuItem.Name = "UbicaciónToolStripMenuItem"
        Me.UbicaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UbicaciónToolStripMenuItem.Text = "Ubicación"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'MunicipiosToolStripMenuItem
        '
        Me.MunicipiosToolStripMenuItem.Name = "MunicipiosToolStripMenuItem"
        Me.MunicipiosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MunicipiosToolStripMenuItem.Text = "Municipios"
        '
        'CerrarAlmacenesToolStripMenuItem
        '
        Me.CerrarAlmacenesToolStripMenuItem.Name = "CerrarAlmacenesToolStripMenuItem"
        Me.CerrarAlmacenesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarAlmacenesToolStripMenuItem.Text = "Cerrar Almacenes"
        '
        'RepararLotesAbrilToolStripMenuItem
        '
        Me.RepararLotesAbrilToolStripMenuItem.Name = "RepararLotesAbrilToolStripMenuItem"
        Me.RepararLotesAbrilToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepararLotesAbrilToolStripMenuItem.Text = "Reparar Lotes Abril"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 53)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(716, 386)
        Me.PanelContenedor.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(716, 386)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RecatarCantidadInicialToolStripMenuItem
        '
        Me.RecatarCantidadInicialToolStripMenuItem.Name = "RecatarCantidadInicialToolStripMenuItem"
        Me.RecatarCantidadInicialToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RecatarCantidadInicialToolStripMenuItem.Text = "Recatar Cantidad Inicial"
        '
        'FrmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CentroDeCostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SedesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents AlmacénToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FormaFarmaceuticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaboratoriosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoDeProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoDeSalidaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoMedicamentoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents UbicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MunicipiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents CerrarAlmacenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepararLotesAbrilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorizarAlmacénToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecatarCantidadInicialToolStripMenuItem As ToolStripMenuItem
End Class
