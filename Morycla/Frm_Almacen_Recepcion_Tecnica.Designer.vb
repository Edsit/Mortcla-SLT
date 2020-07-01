<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacen_Recepcion_Tecnica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacen_Recepcion_Tecnica))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbCons = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.CbAlmacenes = New System.Windows.Forms.ComboBox()
        Me.CbTProd = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbFecha = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbSoporte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LbCargo = New System.Windows.Forms.Label()
        Me.LbSede = New System.Windows.Forms.Label()
        Me.LbResponsable = New System.Windows.Forms.Label()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(710, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(180, 45)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 38)
        Me.BtnBuscar.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.BtnBuscar, "Buscar")
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.FlatAppearance.BorderSize = 0
        Me.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportar.Image = CType(resources.GetObject("BtnExportar.Image"), System.Drawing.Image)
        Me.BtnExportar.Location = New System.Drawing.Point(698, 118)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(40, 24)
        Me.BtnExportar.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.BtnExportar, "Exportar")
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Entrada"
        '
        'TbCons
        '
        Me.TbCons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCons.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCons.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCons.Enabled = False
        Me.TbCons.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TbCons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbCons.HintForeColor = System.Drawing.Color.Empty
        Me.TbCons.HintText = ""
        Me.TbCons.isPassword = False
        Me.TbCons.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCons.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCons.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCons.LineThickness = 3
        Me.TbCons.Location = New System.Drawing.Point(78, 45)
        Me.TbCons.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCons.MaxLength = 32767
        Me.TbCons.Name = "TbCons"
        Me.TbCons.Size = New System.Drawing.Size(86, 29)
        Me.TbCons.TabIndex = 4
        Me.TbCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Recepción Tecnica"
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(16, 148)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(723, 288)
        Me.Dgv.TabIndex = 17
        '
        'CbAlmacenes
        '
        Me.CbAlmacenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbAlmacenes.BackColor = System.Drawing.Color.SteelBlue
        Me.CbAlmacenes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmacenes.ForeColor = System.Drawing.Color.White
        Me.CbAlmacenes.FormattingEnabled = True
        Me.CbAlmacenes.Location = New System.Drawing.Point(226, 118)
        Me.CbAlmacenes.Name = "CbAlmacenes"
        Me.CbAlmacenes.Size = New System.Drawing.Size(466, 24)
        Me.CbAlmacenes.TabIndex = 31
        '
        'CbTProd
        '
        Me.CbTProd.BackColor = System.Drawing.Color.SteelBlue
        Me.CbTProd.Enabled = False
        Me.CbTProd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTProd.ForeColor = System.Drawing.Color.White
        Me.CbTProd.FormattingEnabled = True
        Me.CbTProd.Location = New System.Drawing.Point(16, 118)
        Me.CbTProd.Name = "CbTProd"
        Me.CbTProd.Size = New System.Drawing.Size(204, 24)
        Me.CbTProd.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Tipo de Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Almacén"
        '
        'TbFecha
        '
        Me.TbFecha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbFecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbFecha.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbFecha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbFecha.Enabled = False
        Me.TbFecha.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbFecha.HintForeColor = System.Drawing.Color.Empty
        Me.TbFecha.HintText = ""
        Me.TbFecha.isPassword = False
        Me.TbFecha.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbFecha.LineIdleColor = System.Drawing.Color.Gray
        Me.TbFecha.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbFecha.LineThickness = 3
        Me.TbFecha.Location = New System.Drawing.Point(328, 45)
        Me.TbFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.TbFecha.MaxLength = 32767
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.Size = New System.Drawing.Size(86, 29)
        Me.TbFecha.TabIndex = 34
        Me.TbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbSoporte
        '
        Me.TbSoporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbSoporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbSoporte.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbSoporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbSoporte.Enabled = False
        Me.TbSoporte.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TbSoporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbSoporte.HintForeColor = System.Drawing.Color.Empty
        Me.TbSoporte.HintText = ""
        Me.TbSoporte.isPassword = False
        Me.TbSoporte.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbSoporte.LineIdleColor = System.Drawing.Color.Gray
        Me.TbSoporte.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbSoporte.LineThickness = 3
        Me.TbSoporte.Location = New System.Drawing.Point(431, 45)
        Me.TbSoporte.Margin = New System.Windows.Forms.Padding(4)
        Me.TbSoporte.MaxLength = 32767
        Me.TbSoporte.Name = "TbSoporte"
        Me.TbSoporte.Size = New System.Drawing.Size(307, 29)
        Me.TbSoporte.TabIndex = 35
        Me.TbSoporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Soporte"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.CheckBox1.Location = New System.Drawing.Point(492, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(200, 20)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Informe sede administrativa"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LbCargo
        '
        Me.LbCargo.AutoSize = True
        Me.LbCargo.Location = New System.Drawing.Point(394, 208)
        Me.LbCargo.Name = "LbCargo"
        Me.LbCargo.Size = New System.Drawing.Size(63, 16)
        Me.LbCargo.TabIndex = 55
        Me.LbCargo.Text = "LbCargo"
        Me.LbCargo.Visible = False
        '
        'LbSede
        '
        Me.LbSede.AutoSize = True
        Me.LbSede.Location = New System.Drawing.Point(293, 208)
        Me.LbSede.Name = "LbSede"
        Me.LbSede.Size = New System.Drawing.Size(57, 16)
        Me.LbSede.TabIndex = 54
        Me.LbSede.Text = "LbSede"
        Me.LbSede.Visible = False
        '
        'LbResponsable
        '
        Me.LbResponsable.AutoSize = True
        Me.LbResponsable.Location = New System.Drawing.Point(293, 224)
        Me.LbResponsable.Name = "LbResponsable"
        Me.LbResponsable.Size = New System.Drawing.Size(107, 16)
        Me.LbResponsable.TabIndex = 53
        Me.LbResponsable.Text = "LbResponsable"
        Me.LbResponsable.Visible = False
        '
        'FrmAlmacen_Recepcion_Tecnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbCargo)
        Me.Controls.Add(Me.LbSede)
        Me.Controls.Add(Me.LbResponsable)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbSoporte)
        Me.Controls.Add(Me.TbFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbAlmacenes)
        Me.Controls.Add(Me.CbTProd)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbCons)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAlmacen_Recepcion_Tecnica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents TbCons As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CbAlmacenes As ComboBox
    Friend WithEvents CbTProd As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbFecha As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbSoporte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnExportar As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LbCargo As Label
    Friend WithEvents LbSede As Label
    Friend WithEvents LbResponsable As Label
End Class
