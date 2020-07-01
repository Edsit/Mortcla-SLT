<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Alm_Entradas1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Alm_Entradas1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbAlmacen = New System.Windows.Forms.Label()
        Me.LbTProd = New System.Windows.Forms.Label()
        Me.LbNombreAlmacen = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbConsMes = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TbMes = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TbAño = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.BtnBuscarProd = New System.Windows.Forms.Button()
        Me.LbConsProd = New System.Windows.Forms.Label()
        Me.LbProd = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvE = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvS = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LbEntrada = New System.Windows.Forms.Label()
        Me.LbLote = New System.Windows.Forms.Label()
        Me.LbConsLote = New System.Windows.Forms.Label()
        Me.LbTipoProd = New System.Windows.Forms.Label()
        Me.LbSaldo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbUnitario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbCant = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LbMensajeMed = New System.Windows.Forms.Label()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DgvE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entradas"
        '
        'LbAlmacen
        '
        Me.LbAlmacen.AutoSize = True
        Me.LbAlmacen.Location = New System.Drawing.Point(123, 9)
        Me.LbAlmacen.Name = "LbAlmacen"
        Me.LbAlmacen.Size = New System.Drawing.Size(78, 17)
        Me.LbAlmacen.TabIndex = 64
        Me.LbAlmacen.Text = "LbAlmacen"
        Me.LbAlmacen.Visible = False
        '
        'LbTProd
        '
        Me.LbTProd.AutoSize = True
        Me.LbTProd.Location = New System.Drawing.Point(287, 9)
        Me.LbTProd.Name = "LbTProd"
        Me.LbTProd.Size = New System.Drawing.Size(63, 17)
        Me.LbTProd.TabIndex = 63
        Me.LbTProd.Text = "LbTProd"
        Me.LbTProd.Visible = False
        '
        'LbNombreAlmacen
        '
        Me.LbNombreAlmacen.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreAlmacen.ForeColor = System.Drawing.Color.DarkGreen
        Me.LbNombreAlmacen.Location = New System.Drawing.Point(80, 50)
        Me.LbNombreAlmacen.Name = "LbNombreAlmacen"
        Me.LbNombreAlmacen.Size = New System.Drawing.Size(981, 23)
        Me.LbNombreAlmacen.TabIndex = 67
        Me.LbNombreAlmacen.Text = "LbNombreAlmacen"
        Me.LbNombreAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label20.Location = New System.Drawing.Point(13, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Almacén:"
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.Green
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(70, 78)
        Me.BunifuDatepicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(163, 25)
        Me.BunifuDatepicker1.TabIndex = 68
        Me.BunifuDatepicker1.Value = New Date(2020, 5, 14, 20, 17, 24, 189)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label18.Location = New System.Drawing.Point(12, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Fecha"
        '
        'TbConsMes
        '
        Me.TbConsMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbConsMes.BorderColorFocused = System.Drawing.Color.Blue
        Me.TbConsMes.BorderColorIdle = System.Drawing.Color.Blue
        Me.TbConsMes.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TbConsMes.BorderThickness = 3
        Me.TbConsMes.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbConsMes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbConsMes.Enabled = False
        Me.TbConsMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbConsMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbConsMes.isPassword = False
        Me.TbConsMes.Location = New System.Drawing.Point(874, 6)
        Me.TbConsMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConsMes.MaxLength = 32767
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(43, 27)
        Me.TbConsMes.TabIndex = 70
        Me.TbConsMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbMes
        '
        Me.TbMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbMes.BorderColorFocused = System.Drawing.Color.Blue
        Me.TbMes.BorderColorIdle = System.Drawing.Color.Blue
        Me.TbMes.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TbMes.BorderThickness = 3
        Me.TbMes.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbMes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbMes.Enabled = False
        Me.TbMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbMes.isPassword = False
        Me.TbMes.Location = New System.Drawing.Point(925, 6)
        Me.TbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMes.MaxLength = 32767
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(114, 27)
        Me.TbMes.TabIndex = 71
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbAño
        '
        Me.TbAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbAño.BorderColorFocused = System.Drawing.Color.Blue
        Me.TbAño.BorderColorIdle = System.Drawing.Color.Blue
        Me.TbAño.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TbAño.BorderThickness = 3
        Me.TbAño.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbAño.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbAño.Enabled = False
        Me.TbAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbAño.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbAño.isPassword = False
        Me.TbAño.Location = New System.Drawing.Point(1047, 6)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.MaxLength = 32767
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(60, 27)
        Me.TbAño.TabIndex = 72
        Me.TbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(763, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Périodo Activo"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(1160, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(31, 23)
        Me.BtnCerrar.TabIndex = 74
        Me.BtnCerrar.Text = "X"
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Line1
        '
        Me.Line1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Line1.Location = New System.Drawing.Point(16, 36)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1053, 11)
        Me.Line1.TabIndex = 75
        Me.Line1.Text = "Line1"
        '
        'BtnBuscarProd
        '
        Me.BtnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarProd.ForeColor = System.Drawing.Color.ForestGreen
        Me.BtnBuscarProd.Image = CType(resources.GetObject("BtnBuscarProd.Image"), System.Drawing.Image)
        Me.BtnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarProd.Location = New System.Drawing.Point(253, 77)
        Me.BtnBuscarProd.Name = "BtnBuscarProd"
        Me.BtnBuscarProd.Size = New System.Drawing.Size(150, 26)
        Me.BtnBuscarProd.TabIndex = 77
        Me.BtnBuscarProd.Text = "Buscar Producto"
        Me.BtnBuscarProd.UseVisualStyleBackColor = True
        '
        'LbConsProd
        '
        Me.LbConsProd.BackColor = System.Drawing.Color.SeaGreen
        Me.LbConsProd.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConsProd.ForeColor = System.Drawing.Color.White
        Me.LbConsProd.Location = New System.Drawing.Point(409, 81)
        Me.LbConsProd.Name = "LbConsProd"
        Me.LbConsProd.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LbConsProd.Size = New System.Drawing.Size(70, 19)
        Me.LbConsProd.TabIndex = 78
        Me.LbConsProd.Text = "Cons"
        Me.LbConsProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbProd
        '
        Me.LbProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbProd.BackColor = System.Drawing.Color.SeaGreen
        Me.LbProd.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProd.ForeColor = System.Drawing.Color.White
        Me.LbProd.Location = New System.Drawing.Point(485, 81)
        Me.LbProd.Name = "LbProd"
        Me.LbProd.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LbProd.Size = New System.Drawing.Size(706, 19)
        Me.LbProd.TabIndex = 79
        Me.LbProd.Text = "LbProd"
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column11, Me.Column12, Me.Column13})
        Me.Dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.GridColor = System.Drawing.Color.LightGray
        Me.Dgv.Location = New System.Drawing.Point(15, 147)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(792, 171)
        Me.Dgv.TabIndex = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUM"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "LABORATORIO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "LOTE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "INVIMA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "VENCE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "INICIAL"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "UNITARIO"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "TOTAL"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoLoteToolStripMenuItem, Me.ModificarLoteToolStripMenuItem, Me.BuscarLoteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 70)
        '
        'NuevoLoteToolStripMenuItem
        '
        Me.NuevoLoteToolStripMenuItem.Name = "NuevoLoteToolStripMenuItem"
        Me.NuevoLoteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NuevoLoteToolStripMenuItem.Text = "Nuevo Lote"
        '
        'ModificarLoteToolStripMenuItem
        '
        Me.ModificarLoteToolStripMenuItem.Name = "ModificarLoteToolStripMenuItem"
        Me.ModificarLoteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ModificarLoteToolStripMenuItem.Text = "Modificar Lote"
        '
        'BuscarLoteToolStripMenuItem
        '
        Me.BuscarLoteToolStripMenuItem.Name = "BuscarLoteToolStripMenuItem"
        Me.BuscarLoteToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BuscarLoteToolStripMenuItem.Text = "Buscar Lote"
        '
        'DgvE
        '
        Me.DgvE.AllowUserToAddRows = False
        Me.DgvE.AllowUserToDeleteRows = False
        Me.DgvE.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DgvE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DgvE.EnableHeadersVisualStyles = False
        Me.DgvE.GridColor = System.Drawing.Color.LightGray
        Me.DgvE.Location = New System.Drawing.Point(15, 347)
        Me.DgvE.Name = "DgvE"
        Me.DgvE.ReadOnly = True
        Me.DgvE.RowHeadersVisible = False
        Me.DgvE.Size = New System.Drawing.Size(569, 143)
        Me.DgvE.TabIndex = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CONS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "FECHA"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "CANT"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "UNITARIO"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "TOTAL"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'DgvS
        '
        Me.DgvS.AllowUserToAddRows = False
        Me.DgvS.AllowUserToDeleteRows = False
        Me.DgvS.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DgvS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DgvS.EnableHeadersVisualStyles = False
        Me.DgvS.GridColor = System.Drawing.Color.LightGray
        Me.DgvS.Location = New System.Drawing.Point(603, 347)
        Me.DgvS.Name = "DgvS"
        Me.DgvS.ReadOnly = True
        Me.DgvS.RowHeadersVisible = False
        Me.DgvS.Size = New System.Drawing.Size(588, 143)
        Me.DgvS.TabIndex = 82
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CONS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "CANT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "UNITARIO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(13, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Entradas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(600, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Salidas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(13, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Lotes"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(579, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "No. Entrada:"
        '
        'LbEntrada
        '
        Me.LbEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbEntrada.AutoSize = True
        Me.LbEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntrada.ForeColor = System.Drawing.Color.Blue
        Me.LbEntrada.Location = New System.Drawing.Point(674, 15)
        Me.LbEntrada.Name = "LbEntrada"
        Me.LbEntrada.Size = New System.Drawing.Size(74, 16)
        Me.LbEntrada.TabIndex = 95
        Me.LbEntrada.Text = "LbEntrada"
        '
        'LbLote
        '
        Me.LbLote.AutoSize = True
        Me.LbLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLote.ForeColor = System.Drawing.Color.DarkGreen
        Me.LbLote.Location = New System.Drawing.Point(67, 127)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.Size = New System.Drawing.Size(58, 17)
        Me.LbLote.TabIndex = 96
        Me.LbLote.Text = "LbLote"
        '
        'LbConsLote
        '
        Me.LbConsLote.AutoSize = True
        Me.LbConsLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbConsLote.ForeColor = System.Drawing.Color.DarkGreen
        Me.LbConsLote.Location = New System.Drawing.Point(67, 110)
        Me.LbConsLote.Name = "LbConsLote"
        Me.LbConsLote.Size = New System.Drawing.Size(94, 17)
        Me.LbConsLote.TabIndex = 97
        Me.LbConsLote.Text = "LbConsLote"
        Me.LbConsLote.Visible = False
        '
        'LbTipoProd
        '
        Me.LbTipoProd.AutoSize = True
        Me.LbTipoProd.Location = New System.Drawing.Point(207, 15)
        Me.LbTipoProd.Name = "LbTipoProd"
        Me.LbTipoProd.Size = New System.Drawing.Size(82, 17)
        Me.LbTipoProd.TabIndex = 99
        Me.LbTipoProd.Text = "LbTipoProd"
        Me.LbTipoProd.UseWaitCursor = True
        Me.LbTipoProd.Visible = False
        '
        'LbSaldo
        '
        Me.LbSaldo.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LbSaldo.Location = New System.Drawing.Point(1053, 146)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(108, 17)
        Me.LbSaldo.TabIndex = 107
        Me.LbSaldo.Text = "LbSaldo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label8.Location = New System.Drawing.Point(976, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Saldo:"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Location = New System.Drawing.Point(979, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 33)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Location = New System.Drawing.Point(1061, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Valor Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(976, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Cantidad"
        '
        'TbUnitario
        '
        Me.TbUnitario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbUnitario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbUnitario.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbUnitario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbUnitario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbUnitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TbUnitario.HintForeColor = System.Drawing.Color.Empty
        Me.TbUnitario.HintText = ""
        Me.TbUnitario.isPassword = False
        Me.TbUnitario.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbUnitario.LineIdleColor = System.Drawing.Color.LightSeaGreen
        Me.TbUnitario.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbUnitario.LineThickness = 3
        Me.TbUnitario.Location = New System.Drawing.Point(1062, 219)
        Me.TbUnitario.Margin = New System.Windows.Forms.Padding(4)
        Me.TbUnitario.MaxLength = 32767
        Me.TbUnitario.Name = "TbUnitario"
        Me.TbUnitario.Size = New System.Drawing.Size(99, 31)
        Me.TbUnitario.TabIndex = 102
        Me.TbUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbCant
        '
        Me.TbCant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCant.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCant.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbCant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TbCant.HintForeColor = System.Drawing.Color.Empty
        Me.TbCant.HintText = ""
        Me.TbCant.isPassword = False
        Me.TbCant.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCant.LineIdleColor = System.Drawing.Color.LightSeaGreen
        Me.TbCant.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCant.LineThickness = 3
        Me.TbCant.Location = New System.Drawing.Point(979, 219)
        Me.TbCant.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCant.MaxLength = 32767
        Me.TbCant.Name = "TbCant"
        Me.TbCant.Size = New System.Drawing.Size(75, 31)
        Me.TbCant.TabIndex = 101
        Me.TbCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbMensajeMed
        '
        Me.LbMensajeMed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbMensajeMed.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMensajeMed.ForeColor = System.Drawing.Color.Red
        Me.LbMensajeMed.Location = New System.Drawing.Point(531, 111)
        Me.LbMensajeMed.Name = "LbMensajeMed"
        Me.LbMensajeMed.Size = New System.Drawing.Size(660, 16)
        Me.LbMensajeMed.TabIndex = 108
        Me.LbMensajeMed.Text = "LbMensajeMed"
        Me.LbMensajeMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Alm_Entradas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1195, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbMensajeMed)
        Me.Controls.Add(Me.LbSaldo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbUnitario)
        Me.Controls.Add(Me.TbCant)
        Me.Controls.Add(Me.LbTipoProd)
        Me.Controls.Add(Me.LbConsLote)
        Me.Controls.Add(Me.LbLote)
        Me.Controls.Add(Me.LbEntrada)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DgvS)
        Me.Controls.Add(Me.DgvE)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.LbProd)
        Me.Controls.Add(Me.LbConsProd)
        Me.Controls.Add(Me.BtnBuscarProd)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.LbNombreAlmacen)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LbAlmacen)
        Me.Controls.Add(Me.LbTProd)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Alm_Entradas1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DgvE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LbAlmacen As Label
    Friend WithEvents LbTProd As Label
    Friend WithEvents LbNombreAlmacen As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label18 As Label
    Friend WithEvents TbConsMes As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TbMes As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TbAño As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents BtnBuscarProd As Button
    Friend WithEvents LbConsProd As Label
    Friend WithEvents LbProd As Label
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents DgvE As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents DgvS As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents LbEntrada As Label
    Friend WithEvents LbLote As Label
    Friend WithEvents LbConsLote As Label
    Friend WithEvents LbTipoProd As Label
    Friend WithEvents LbSaldo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbUnitario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbCant As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LbMensajeMed As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NuevoLoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarLoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarLoteToolStripMenuItem As ToolStripMenuItem
End Class
