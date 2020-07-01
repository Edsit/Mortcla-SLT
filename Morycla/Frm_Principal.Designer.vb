<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbFuncionario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.LbSede = New System.Windows.Forms.Label()
        Me.BtnSeguridad = New System.Windows.Forms.Button()
        Me.BtnSesión = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BtnSistemas = New System.Windows.Forms.Button()
        Me.BtnFacturacion = New System.Windows.Forms.Button()
        Me.BtnAlmacen = New System.Windows.Forms.Button()
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.PicFondo = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(742, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(33, 28)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Firebrick
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.LbFuncionario)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.BtnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelMenu.Location = New System.Drawing.Point(0, 409)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(778, 36)
        Me.PanelMenu.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(636, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Morycla SLT v1.2.5"
        '
        'LbFuncionario
        '
        Me.LbFuncionario.AutoSize = True
        Me.LbFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFuncionario.ForeColor = System.Drawing.Color.White
        Me.LbFuncionario.Location = New System.Drawing.Point(98, 13)
        Me.LbFuncionario.Name = "LbFuncionario"
        Me.LbFuncionario.Size = New System.Drawing.Size(98, 17)
        Me.LbFuncionario.TabIndex = 2
        Me.LbFuncionario.Text = "LbFuncionario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Funcionario:"
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu.FlatAppearance.BorderSize = 0
        Me.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(372, 6)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(36, 27)
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.UseVisualStyleBackColor = True
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.White
        Me.PanelTitulo.Controls.Add(Me.LbSede)
        Me.PanelTitulo.Controls.Add(Me.BtnSeguridad)
        Me.PanelTitulo.Controls.Add(Me.BtnSesión)
        Me.PanelTitulo.Controls.Add(Me.btnSalir)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(778, 38)
        Me.PanelTitulo.TabIndex = 21
        '
        'LbSede
        '
        Me.LbSede.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSede.ForeColor = System.Drawing.Color.Teal
        Me.LbSede.Location = New System.Drawing.Point(10, 6)
        Me.LbSede.Name = "LbSede"
        Me.LbSede.Size = New System.Drawing.Size(433, 24)
        Me.LbSede.TabIndex = 9
        Me.LbSede.Text = "ESE DEPARTAMENTAL MORENO Y CLAVIJO"
        '
        'BtnSeguridad
        '
        Me.BtnSeguridad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSeguridad.BackColor = System.Drawing.Color.White
        Me.BtnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSeguridad.FlatAppearance.BorderSize = 0
        Me.BtnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeguridad.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeguridad.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSeguridad.Image = CType(resources.GetObject("BtnSeguridad.Image"), System.Drawing.Image)
        Me.BtnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeguridad.Location = New System.Drawing.Point(449, 3)
        Me.BtnSeguridad.Name = "BtnSeguridad"
        Me.BtnSeguridad.Size = New System.Drawing.Size(160, 28)
        Me.BtnSeguridad.TabIndex = 8
        Me.BtnSeguridad.Text = "Cambiar Contraseña"
        Me.BtnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSeguridad.UseVisualStyleBackColor = False
        '
        'BtnSesión
        '
        Me.BtnSesión.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSesión.BackColor = System.Drawing.Color.White
        Me.BtnSesión.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSesión.FlatAppearance.BorderSize = 0
        Me.BtnSesión.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSesión.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSesión.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSesión.Image = CType(resources.GetObject("BtnSesión.Image"), System.Drawing.Image)
        Me.BtnSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSesión.Location = New System.Drawing.Point(615, 3)
        Me.BtnSesión.Name = "BtnSesión"
        Me.BtnSesión.Size = New System.Drawing.Size(121, 28)
        Me.BtnSesión.TabIndex = 7
        Me.BtnSesión.Text = "Iniciar Sesión"
        Me.BtnSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnSesión, "Iniciar Sesión")
        Me.BtnSesión.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.BtnSistemas)
        Me.PanelContenedor.Controls.Add(Me.BtnFacturacion)
        Me.PanelContenedor.Controls.Add(Me.BtnAlmacen)
        Me.PanelContenedor.Controls.Add(Me.BtnEmpresa)
        Me.PanelContenedor.Controls.Add(Me.PicFondo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 38)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(778, 371)
        Me.PanelContenedor.TabIndex = 23
        '
        'BtnSistemas
        '
        Me.BtnSistemas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSistemas.BackColor = System.Drawing.Color.White
        Me.BtnSistemas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnSistemas.FlatAppearance.BorderSize = 0
        Me.BtnSistemas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSistemas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSistemas.Image = CType(resources.GetObject("BtnSistemas.Image"), System.Drawing.Image)
        Me.BtnSistemas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSistemas.Location = New System.Drawing.Point(658, 97)
        Me.BtnSistemas.Name = "BtnSistemas"
        Me.BtnSistemas.Size = New System.Drawing.Size(109, 107)
        Me.BtnSistemas.TabIndex = 7
        Me.BtnSistemas.Text = "Sistemas"
        Me.BtnSistemas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSistemas.UseVisualStyleBackColor = False
        '
        'BtnFacturacion
        '
        Me.BtnFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFacturacion.BackColor = System.Drawing.Color.White
        Me.BtnFacturacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnFacturacion.FlatAppearance.BorderSize = 0
        Me.BtnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturacion.Image = CType(resources.GetObject("BtnFacturacion.Image"), System.Drawing.Image)
        Me.BtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFacturacion.Location = New System.Drawing.Point(543, 97)
        Me.BtnFacturacion.Name = "BtnFacturacion"
        Me.BtnFacturacion.Size = New System.Drawing.Size(109, 107)
        Me.BtnFacturacion.TabIndex = 6
        Me.BtnFacturacion.Text = "Facturtación"
        Me.BtnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFacturacion.UseVisualStyleBackColor = False
        '
        'BtnAlmacen
        '
        Me.BtnAlmacen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlmacen.BackColor = System.Drawing.Color.White
        Me.BtnAlmacen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnAlmacen.FlatAppearance.BorderSize = 0
        Me.BtnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlmacen.Image = CType(resources.GetObject("BtnAlmacen.Image"), System.Drawing.Image)
        Me.BtnAlmacen.Location = New System.Drawing.Point(428, 97)
        Me.BtnAlmacen.Name = "BtnAlmacen"
        Me.BtnAlmacen.Size = New System.Drawing.Size(109, 107)
        Me.BtnAlmacen.TabIndex = 5
        Me.BtnAlmacen.Text = "Almacén"
        Me.BtnAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAlmacen.UseVisualStyleBackColor = False
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEmpresa.BackColor = System.Drawing.Color.White
        Me.BtnEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.BtnEmpresa.FlatAppearance.BorderSize = 0
        Me.BtnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.Image = CType(resources.GetObject("BtnEmpresa.Image"), System.Drawing.Image)
        Me.BtnEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEmpresa.Location = New System.Drawing.Point(313, 97)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(109, 107)
        Me.BtnEmpresa.TabIndex = 4
        Me.BtnEmpresa.Text = "Empresa"
        Me.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEmpresa.UseVisualStyleBackColor = False
        '
        'PicFondo
        '
        Me.PicFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFondo.Image = CType(resources.GetObject("PicFondo.Image"), System.Drawing.Image)
        Me.PicFondo.Location = New System.Drawing.Point(0, 0)
        Me.PicFondo.Name = "PicFondo"
        Me.PicFondo.Size = New System.Drawing.Size(778, 371)
        Me.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFondo.TabIndex = 2
        Me.PicFondo.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.BtnEmpresa
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        Me.BunifuElipse2.TargetControl = Me.BtnAlmacen
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 7
        Me.BunifuElipse3.TargetControl = Me.BtnFacturacion
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 7
        Me.BunifuElipse4.TargetControl = Me.BtnSistemas
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Principal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnSalir As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnMenu As Button
    Friend WithEvents PicFondo As PictureBox
    Friend WithEvents BtnSistemas As Button
    Friend WithEvents BtnFacturacion As Button
    Friend WithEvents BtnAlmacen As Button
    Friend WithEvents BtnEmpresa As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LbFuncionario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSeguridad As Button
    Friend WithEvents BtnSesión As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LbSede As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
End Class
