<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModulos))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnModulos = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSesión = New System.Windows.Forms.Button()
        Me.BtnSeguridad = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelTool = New System.Windows.Forms.Panel()
        Me.LbSede = New System.Windows.Forms.Label()
        Me.PanelModulo = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.LbFuncionario = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.LbCargo = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.PanelModulos = New System.Windows.Forms.Panel()
        Me.BtnInformes = New System.Windows.Forms.Button()
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.BtnSistema = New System.Windows.Forms.Button()
        Me.BtnAlmacen = New System.Windows.Forms.Button()
        Me.BtnFacturacion = New System.Windows.Forms.Button()
        Me.BtnAsistencial = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelTool.SuspendLayout()
        Me.PanelModulo.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelModulos.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.BtnSalir)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1005, 37)
        Me.PanelTitulo.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(959, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(43, 37)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Salir de Morycla")
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ESE DEPARTAMENTAL MORENO Y CLAVIJO"
        '
        'BtnModulos
        '
        Me.BtnModulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModulos.FlatAppearance.BorderSize = 0
        Me.BtnModulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModulos.Image = CType(resources.GetObject("BtnModulos.Image"), System.Drawing.Image)
        Me.BtnModulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModulos.Location = New System.Drawing.Point(12, 6)
        Me.BtnModulos.Name = "BtnModulos"
        Me.BtnModulos.Size = New System.Drawing.Size(228, 45)
        Me.BtnModulos.TabIndex = 0
        Me.BtnModulos.Text = "MODULOS"
        Me.BtnModulos.UseVisualStyleBackColor = True
        '
        'BtnSesión
        '
        Me.BtnSesión.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSesión.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSesión.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSesión.Image = CType(resources.GetObject("BtnSesión.Image"), System.Drawing.Image)
        Me.BtnSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSesión.Location = New System.Drawing.Point(642, 6)
        Me.BtnSesión.Name = "BtnSesión"
        Me.BtnSesión.Size = New System.Drawing.Size(94, 45)
        Me.BtnSesión.TabIndex = 2
        Me.BtnSesión.Text = "Sesion"
        Me.BtnSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnSesión, "Iniciar / Cerrar Sesión")
        Me.BtnSesión.UseVisualStyleBackColor = True
        '
        'BtnSeguridad
        '
        Me.BtnSeguridad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeguridad.Image = CType(resources.GetObject("BtnSeguridad.Image"), System.Drawing.Image)
        Me.BtnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeguridad.Location = New System.Drawing.Point(526, 6)
        Me.BtnSeguridad.Name = "BtnSeguridad"
        Me.BtnSeguridad.Size = New System.Drawing.Size(110, 45)
        Me.BtnSeguridad.TabIndex = 1
        Me.BtnSeguridad.Text = "Seguridad"
        Me.BtnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnSeguridad, "Cambiar Contraseña")
        Me.BtnSeguridad.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelTool)
        Me.Panel1.Controls.Add(Me.PanelModulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 61)
        Me.Panel1.TabIndex = 3
        '
        'PanelTool
        '
        Me.PanelTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTool.Controls.Add(Me.LbSede)
        Me.PanelTool.Controls.Add(Me.BtnSeguridad)
        Me.PanelTool.Controls.Add(Me.BtnSesión)
        Me.PanelTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTool.Location = New System.Drawing.Point(255, 0)
        Me.PanelTool.Name = "PanelTool"
        Me.PanelTool.Size = New System.Drawing.Size(750, 61)
        Me.PanelTool.TabIndex = 1
        '
        'LbSede
        '
        Me.LbSede.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbSede.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSede.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.LbSede.Location = New System.Drawing.Point(5, 6)
        Me.LbSede.Name = "LbSede"
        Me.LbSede.Size = New System.Drawing.Size(515, 45)
        Me.LbSede.TabIndex = 3
        Me.LbSede.Text = "LbSede"
        Me.LbSede.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelModulo
        '
        Me.PanelModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelModulo.Controls.Add(Me.BtnModulos)
        Me.PanelModulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelModulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelModulo.Name = "PanelModulo"
        Me.PanelModulo.Size = New System.Drawing.Size(255, 61)
        Me.PanelModulo.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MetroStatusBar1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 490)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1005, 23)
        Me.Panel4.TabIndex = 4
        '
        'MetroStatusBar1
        '
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar1.DragDropSupport = True
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.LbFuncionario, Me.LabelItem2, Me.LbCargo, Me.LabelItem3, Me.LabelItem4})
        Me.MetroStatusBar1.Location = New System.Drawing.Point(0, 1)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(1005, 22)
        Me.MetroStatusBar1.TabIndex = 0
        '
        'LabelItem1
        '
        Me.LabelItem1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItem1.ForeColor = System.Drawing.Color.White
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Funcionario:"
        '
        'LbFuncionario
        '
        Me.LbFuncionario.FontBold = True
        Me.LbFuncionario.ForeColor = System.Drawing.Color.White
        Me.LbFuncionario.Name = "LbFuncionario"
        Me.LbFuncionario.Text = "LbFuncionario"
        '
        'LabelItem2
        '
        Me.LabelItem2.FontBold = True
        Me.LabelItem2.ForeColor = System.Drawing.Color.White
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "|"
        '
        'LbCargo
        '
        Me.LbCargo.FontBold = True
        Me.LbCargo.ForeColor = System.Drawing.Color.White
        Me.LbCargo.Name = "LbCargo"
        Me.LbCargo.Text = "LbCargo"
        '
        'LabelItem3
        '
        Me.LabelItem3.FontBold = True
        Me.LabelItem3.ForeColor = System.Drawing.Color.White
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "|"
        '
        'LabelItem4
        '
        Me.LabelItem4.ForeColor = System.Drawing.Color.White
        Me.LabelItem4.Name = "LabelItem4"
        Me.LabelItem4.Stretch = True
        Me.LabelItem4.Text = "Morycla SLT v1.1.5"
        Me.LabelItem4.TextAlignment = System.Drawing.StringAlignment.Far
        Me.LabelItem4.TextLineAlignment = System.Drawing.StringAlignment.Far
        '
        'PanelModulos
        '
        Me.PanelModulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelModulos.Controls.Add(Me.BtnInformes)
        Me.PanelModulos.Controls.Add(Me.BtnEmpresa)
        Me.PanelModulos.Controls.Add(Me.BtnSistema)
        Me.PanelModulos.Controls.Add(Me.BtnAlmacen)
        Me.PanelModulos.Controls.Add(Me.BtnFacturacion)
        Me.PanelModulos.Controls.Add(Me.BtnAsistencial)
        Me.PanelModulos.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelModulos.Location = New System.Drawing.Point(0, 98)
        Me.PanelModulos.Name = "PanelModulos"
        Me.PanelModulos.Size = New System.Drawing.Size(255, 392)
        Me.PanelModulos.TabIndex = 5
        '
        'BtnInformes
        '
        Me.BtnInformes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformes.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInformes.Image = CType(resources.GetObject("BtnInformes.Image"), System.Drawing.Image)
        Me.BtnInformes.Location = New System.Drawing.Point(12, 249)
        Me.BtnInformes.Name = "BtnInformes"
        Me.BtnInformes.Size = New System.Drawing.Size(111, 107)
        Me.BtnInformes.TabIndex = 5
        Me.BtnInformes.Text = "Informes"
        Me.BtnInformes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInformes.UseVisualStyleBackColor = True
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresa.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.Image = CType(resources.GetObject("BtnEmpresa.Image"), System.Drawing.Image)
        Me.BtnEmpresa.Location = New System.Drawing.Point(12, 5)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(111, 107)
        Me.BtnEmpresa.TabIndex = 4
        Me.BtnEmpresa.Text = "Empresa"
        Me.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEmpresa.UseVisualStyleBackColor = True
        '
        'BtnSistema
        '
        Me.BtnSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSistema.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSistema.Image = CType(resources.GetObject("BtnSistema.Image"), System.Drawing.Image)
        Me.BtnSistema.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSistema.Location = New System.Drawing.Point(129, 250)
        Me.BtnSistema.Name = "BtnSistema"
        Me.BtnSistema.Size = New System.Drawing.Size(111, 107)
        Me.BtnSistema.TabIndex = 3
        Me.BtnSistema.Text = "Sistema"
        Me.BtnSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSistema.UseVisualStyleBackColor = True
        '
        'BtnAlmacen
        '
        Me.BtnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlmacen.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlmacen.Image = CType(resources.GetObject("BtnAlmacen.Image"), System.Drawing.Image)
        Me.BtnAlmacen.Location = New System.Drawing.Point(129, 5)
        Me.BtnAlmacen.Name = "BtnAlmacen"
        Me.BtnAlmacen.Size = New System.Drawing.Size(111, 107)
        Me.BtnAlmacen.TabIndex = 2
        Me.BtnAlmacen.Text = "Almacén"
        Me.BtnAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAlmacen.UseVisualStyleBackColor = True
        '
        'BtnFacturacion
        '
        Me.BtnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturacion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturacion.Image = CType(resources.GetObject("BtnFacturacion.Image"), System.Drawing.Image)
        Me.BtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFacturacion.Location = New System.Drawing.Point(129, 136)
        Me.BtnFacturacion.Name = "BtnFacturacion"
        Me.BtnFacturacion.Size = New System.Drawing.Size(111, 107)
        Me.BtnFacturacion.TabIndex = 1
        Me.BtnFacturacion.Text = "Facturación"
        Me.BtnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFacturacion.UseVisualStyleBackColor = True
        '
        'BtnAsistencial
        '
        Me.BtnAsistencial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAsistencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnAsistencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAsistencial.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAsistencial.Image = CType(resources.GetObject("BtnAsistencial.Image"), System.Drawing.Image)
        Me.BtnAsistencial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAsistencial.Location = New System.Drawing.Point(12, 136)
        Me.BtnAsistencial.Name = "BtnAsistencial"
        Me.BtnAsistencial.Size = New System.Drawing.Size(111, 107)
        Me.BtnAsistencial.TabIndex = 0
        Me.BtnAsistencial.Text = "Asistencial"
        Me.BtnAsistencial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAsistencial.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(255, 98)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(750, 392)
        Me.PanelContenedor.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelModulos)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelTool.ResumeLayout(False)
        Me.PanelModulo.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelModulos.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnModulos As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelModulo As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelModulos As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnAsistencial As Button
    Friend WithEvents BtnSistema As Button
    Friend WithEvents BtnAlmacen As Button
    Friend WithEvents BtnFacturacion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTool As Panel
    Friend WithEvents BtnSeguridad As Button
    Friend WithEvents BtnSesión As Button
    Friend WithEvents BtnEmpresa As Button
    Friend WithEvents LbSede As Label
    Private WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Private WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Private WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Private WithEvents LbCargo As DevComponents.DotNetBar.LabelItem
    Private WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Private WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LbFuncionario As DevComponents.DotNetBar.LabelItem
    Friend WithEvents BtnInformes As Button
End Class
