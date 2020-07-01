<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcedimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasDeCobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R3280ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 29)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(537, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cerrar Módulo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTURACION"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 24)
        Me.Panel2.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralesToolStripMenuItem, Me.CitaToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.CuentasDeCobroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneralesToolStripMenuItem
        '
        Me.GeneralesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ProcedimientosToolStripMenuItem, Me.ContratosToolStripMenuItem})
        Me.GeneralesToolStripMenuItem.Name = "GeneralesToolStripMenuItem"
        Me.GeneralesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.GeneralesToolStripMenuItem.Text = "Generales"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ProcedimientosToolStripMenuItem
        '
        Me.ProcedimientosToolStripMenuItem.Name = "ProcedimientosToolStripMenuItem"
        Me.ProcedimientosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ProcedimientosToolStripMenuItem.Text = "Procedimientos"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'CitaToolStripMenuItem
        '
        Me.CitaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignaciónToolStripMenuItem, Me.ToolStripMenuItem2, Me.SolicitudToolStripMenuItem, Me.ToolStripMenuItem1, Me.ParametrosToolStripMenuItem})
        Me.CitaToolStripMenuItem.Name = "CitaToolStripMenuItem"
        Me.CitaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.CitaToolStripMenuItem.Text = "Cita"
        '
        'AsignaciónToolStripMenuItem
        '
        Me.AsignaciónToolStripMenuItem.Name = "AsignaciónToolStripMenuItem"
        Me.AsignaciónToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AsignaciónToolStripMenuItem.Text = "Asignación"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(135, 6)
        '
        'SolicitudToolStripMenuItem
        '
        Me.SolicitudToolStripMenuItem.Name = "SolicitudToolStripMenuItem"
        Me.SolicitudToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SolicitudToolStripMenuItem.Text = "Solicitud"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 6)
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultoriosToolStripMenuItem, Me.EspecialidadesToolStripMenuItem, Me.ProfesionalesToolStripMenuItem})
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ParametrosToolStripMenuItem.Text = "Parametros"
        '
        'ConsultoriosToolStripMenuItem
        '
        Me.ConsultoriosToolStripMenuItem.Name = "ConsultoriosToolStripMenuItem"
        Me.ConsultoriosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultoriosToolStripMenuItem.Text = "Consultorios"
        '
        'EspecialidadesToolStripMenuItem
        '
        Me.EspecialidadesToolStripMenuItem.Name = "EspecialidadesToolStripMenuItem"
        Me.EspecialidadesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EspecialidadesToolStripMenuItem.Text = "Especialidades"
        '
        'ProfesionalesToolStripMenuItem
        '
        Me.ProfesionalesToolStripMenuItem.Name = "ProfesionalesToolStripMenuItem"
        Me.ProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfesionalesToolStripMenuItem.Text = "Profesionales"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarFacturaToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'GenerarFacturaToolStripMenuItem
        '
        Me.GenerarFacturaToolStripMenuItem.Name = "GenerarFacturaToolStripMenuItem"
        Me.GenerarFacturaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GenerarFacturaToolStripMenuItem.Text = "Generar Factura"
        '
        'CuentasDeCobroToolStripMenuItem
        '
        Me.CuentasDeCobroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarToolStripMenuItem, Me.RipsToolStripMenuItem})
        Me.CuentasDeCobroToolStripMenuItem.Name = "CuentasDeCobroToolStripMenuItem"
        Me.CuentasDeCobroToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.CuentasDeCobroToolStripMenuItem.Text = "Cuentas de Cobro"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'RipsToolStripMenuItem
        '
        Me.RipsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarToolStripMenuItem1, Me.ValidacionesToolStripMenuItem})
        Me.RipsToolStripMenuItem.Name = "RipsToolStripMenuItem"
        Me.RipsToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.RipsToolStripMenuItem.Text = "Rips"
        '
        'GenerarToolStripMenuItem1
        '
        Me.GenerarToolStripMenuItem1.Name = "GenerarToolStripMenuItem1"
        Me.GenerarToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.GenerarToolStripMenuItem1.Text = "Generar"
        '
        'ValidacionesToolStripMenuItem
        '
        Me.ValidacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.R3280ToolStripMenuItem})
        Me.ValidacionesToolStripMenuItem.Name = "ValidacionesToolStripMenuItem"
        Me.ValidacionesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ValidacionesToolStripMenuItem.Text = "Validaciones"
        '
        'R3280ToolStripMenuItem
        '
        Me.R3280ToolStripMenuItem.Name = "R3280ToolStripMenuItem"
        Me.R3280ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.R3280ToolStripMenuItem.Text = "R3280"
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 53)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(676, 412)
        Me.PanelContenedor.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(676, 412)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GeneralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcedimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasDeCobroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RipsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents GenerarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ValidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R3280ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecialidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SolicitudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents PictureBox1 As PictureBox
End Class
