<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalidasStop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalidasStop))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LbAlmacen = New System.Windows.Forms.Label()
        Me.LbNombreAlmacen = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbStop = New System.Windows.Forms.ComboBox()
        Me.LbTipoProd = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.TbValor = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbCantidad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LbTProd = New System.Windows.Forms.Label()
        Me.LbSaldo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbLab = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LbConsLote = New System.Windows.Forms.Label()
        Me.LbLote = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbUnidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscarMed = New System.Windows.Forms.Button()
        Me.TbTipo = New System.Windows.Forms.TextBox()
        Me.TbForma = New System.Windows.Forms.TextBox()
        Me.TbPresentacion = New System.Windows.Forms.TextBox()
        Me.TbConcentracion = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.TbAtc = New System.Windows.Forms.TextBox()
        Me.TbCons = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbAño = New System.Windows.Forms.TextBox()
        Me.TbMes = New System.Windows.Forms.TextBox()
        Me.TbConsMes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(878, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 101
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LbAlmacen
        '
        Me.LbAlmacen.AutoSize = True
        Me.LbAlmacen.Location = New System.Drawing.Point(139, 16)
        Me.LbAlmacen.Name = "LbAlmacen"
        Me.LbAlmacen.Size = New System.Drawing.Size(78, 16)
        Me.LbAlmacen.TabIndex = 134
        Me.LbAlmacen.Text = "LbAlmacen"
        Me.LbAlmacen.Visible = False
        '
        'LbNombreAlmacen
        '
        Me.LbNombreAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNombreAlmacen.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreAlmacen.ForeColor = System.Drawing.Color.MediumBlue
        Me.LbNombreAlmacen.Location = New System.Drawing.Point(81, 39)
        Me.LbNombreAlmacen.Name = "LbNombreAlmacen"
        Me.LbNombreAlmacen.Size = New System.Drawing.Size(396, 23)
        Me.LbNombreAlmacen.TabIndex = 133
        Me.LbNombreAlmacen.Text = "LbNombreAlmacen"
        Me.LbNombreAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label21.Location = New System.Drawing.Point(8, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 16)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "Almacén:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(12, 446)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Stop Destino"
        '
        'CbStop
        '
        Me.CbStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbStop.FormattingEnabled = True
        Me.CbStop.Location = New System.Drawing.Point(10, 465)
        Me.CbStop.Name = "CbStop"
        Me.CbStop.Size = New System.Drawing.Size(405, 24)
        Me.CbStop.TabIndex = 126
        '
        'LbTipoProd
        '
        Me.LbTipoProd.AutoSize = True
        Me.LbTipoProd.Location = New System.Drawing.Point(324, 16)
        Me.LbTipoProd.Name = "LbTipoProd"
        Me.LbTipoProd.Size = New System.Drawing.Size(81, 16)
        Me.LbTipoProd.TabIndex = 125
        Me.LbTipoProd.Text = "LbTipoProd"
        Me.LbTipoProd.Visible = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(487, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 17)
        Me.Label18.TabIndex = 124
        Me.Label18.Text = "Fecha"
        '
        'DtFecha
        '
        Me.DtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(540, 28)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(102, 23)
        Me.DtFecha.TabIndex = 123
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(599, 448)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 16)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "Valor"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(468, 448)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 16)
        Me.Label16.TabIndex = 121
        Me.Label16.Text = "Cantidad"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegistrar.Location = New System.Drawing.Point(741, 460)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(157, 33)
        Me.BtnRegistrar.TabIndex = 120
        Me.BtnRegistrar.Text = "Registrar Producto"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TbValor
        '
        Me.TbValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbValor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbValor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbValor.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbValor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbValor.ForeColor = System.Drawing.Color.Red
        Me.TbValor.HintForeColor = System.Drawing.Color.Empty
        Me.TbValor.HintText = ""
        Me.TbValor.isPassword = False
        Me.TbValor.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbValor.LineIdleColor = System.Drawing.Color.Gray
        Me.TbValor.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbValor.LineThickness = 3
        Me.TbValor.Location = New System.Drawing.Point(600, 460)
        Me.TbValor.Margin = New System.Windows.Forms.Padding(4)
        Me.TbValor.MaxLength = 32767
        Me.TbValor.Name = "TbValor"
        Me.TbValor.Size = New System.Drawing.Size(121, 33)
        Me.TbValor.TabIndex = 119
        Me.TbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbCantidad
        '
        Me.TbCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbCantidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCantidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCantidad.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbCantidad.ForeColor = System.Drawing.Color.Red
        Me.TbCantidad.HintForeColor = System.Drawing.Color.Empty
        Me.TbCantidad.HintText = ""
        Me.TbCantidad.isPassword = False
        Me.TbCantidad.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCantidad.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCantidad.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCantidad.LineThickness = 3
        Me.TbCantidad.Location = New System.Drawing.Point(471, 460)
        Me.TbCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCantidad.MaxLength = 32767
        Me.TbCantidad.Name = "TbCantidad"
        Me.TbCantidad.Size = New System.Drawing.Size(121, 33)
        Me.TbCantidad.TabIndex = 118
        Me.TbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbTProd
        '
        Me.LbTProd.AutoSize = True
        Me.LbTProd.Location = New System.Drawing.Point(236, 17)
        Me.LbTProd.Name = "LbTProd"
        Me.LbTProd.Size = New System.Drawing.Size(63, 16)
        Me.LbTProd.TabIndex = 117
        Me.LbTProd.Text = "LbTProd"
        Me.LbTProd.Visible = False
        '
        'LbSaldo
        '
        Me.LbSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbSaldo.AutoSize = True
        Me.LbSaldo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.Green
        Me.LbSaldo.Location = New System.Drawing.Point(597, 408)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(60, 16)
        Me.LbSaldo.TabIndex = 116
        Me.LbSaldo.Text = "LbSaldo"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(542, 408)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Saldo:"
        '
        'LbLab
        '
        Me.LbLab.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbLab.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLab.ForeColor = System.Drawing.Color.Green
        Me.LbLab.Location = New System.Drawing.Point(391, 408)
        Me.LbLab.Name = "LbLab"
        Me.LbLab.Size = New System.Drawing.Size(145, 16)
        Me.LbLab.TabIndex = 114
        Me.LbLab.Text = "LbLab"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(298, 408)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 16)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Laboratorio:"
        '
        'LbConsLote
        '
        Me.LbConsLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbConsLote.AutoSize = True
        Me.LbConsLote.Location = New System.Drawing.Point(687, 408)
        Me.LbConsLote.Name = "LbConsLote"
        Me.LbConsLote.Size = New System.Drawing.Size(85, 16)
        Me.LbConsLote.TabIndex = 112
        Me.LbConsLote.Text = "LbConsLote"
        Me.LbConsLote.Visible = False
        '
        'LbLote
        '
        Me.LbLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbLote.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLote.ForeColor = System.Drawing.Color.Green
        Me.LbLote.Location = New System.Drawing.Point(147, 408)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.Size = New System.Drawing.Size(145, 16)
        Me.LbLote.TabIndex = 111
        Me.LbLote.Text = "LbLote"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(8, 408)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 16)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Lote Seleccionado:"
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv.BackgroundColor = System.Drawing.Color.DarkGray
        Me.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19})
        Me.Dgv.Location = New System.Drawing.Point(11, 180)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv.Size = New System.Drawing.Size(887, 225)
        Me.Dgv.TabIndex = 109
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 72
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUM"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 63
        '
        'Column3
        '
        Me.Column3.HeaderText = "LABORATORIO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 132
        '
        'Column4
        '
        Me.Column4.HeaderText = "LOTE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "INVIMA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 77
        '
        'Column6
        '
        Me.Column6.HeaderText = "VENCE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 79
        '
        'Column7
        '
        Me.Column7.HeaderText = "INICIAL"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 78
        '
        'Column8
        '
        Me.Column8.HeaderText = "UNITARIO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 95
        '
        'Column9
        '
        Me.Column9.HeaderText = "TOTAL"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 78
        '
        'Column10
        '
        Me.Column10.HeaderText = "ENTRADA"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 98
        '
        'Column11
        '
        Me.Column11.HeaderText = "UNITARIO"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 95
        '
        'Column12
        '
        Me.Column12.HeaderText = "TOTAL"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 78
        '
        'Column13
        '
        Me.Column13.HeaderText = "SALIDA"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 81
        '
        'Column14
        '
        Me.Column14.HeaderText = "UNITARIO"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 95
        '
        'Column15
        '
        Me.Column15.HeaderText = "TOTAL"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 78
        '
        'Column16
        '
        Me.Column16.HeaderText = "SALDO"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 80
        '
        'Column17
        '
        Me.Column17.HeaderText = "UNITARIO"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 95
        '
        'Column18
        '
        Me.Column18.HeaderText = "TOTAL"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 78
        '
        'Column19
        '
        Me.Column19.HeaderText = "OBS"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Visible = False
        Me.Column19.Width = 62
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TbUnidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarMed)
        Me.GroupBox1.Controls.Add(Me.TbTipo)
        Me.GroupBox1.Controls.Add(Me.TbForma)
        Me.GroupBox1.Controls.Add(Me.TbPresentacion)
        Me.GroupBox1.Controls.Add(Me.TbConcentracion)
        Me.GroupBox1.Controls.Add(Me.TbDescripcion)
        Me.GroupBox1.Controls.Add(Me.TbAtc)
        Me.GroupBox1.Controls.Add(Me.TbCons)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 120)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Básicos del Producto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(767, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Unidad Medida"
        '
        'TbUnidad
        '
        Me.TbUnidad.BackColor = System.Drawing.Color.White
        Me.TbUnidad.Enabled = False
        Me.TbUnidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUnidad.Location = New System.Drawing.Point(770, 38)
        Me.TbUnidad.Name = "TbUnidad"
        Me.TbUnidad.Size = New System.Drawing.Size(121, 23)
        Me.TbUnidad.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(405, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(229, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Forma Farmacéutica"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Presentación Comercial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(626, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Concentración"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(229, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(122, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cod. ATC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cons"
        '
        'BtnBuscarMed
        '
        Me.BtnBuscarMed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarMed.FlatAppearance.BorderSize = 0
        Me.BtnBuscarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarMed.Font = New System.Drawing.Font("Century Gothic", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarMed.Location = New System.Drawing.Point(626, 79)
        Me.BtnBuscarMed.Name = "BtnBuscarMed"
        Me.BtnBuscarMed.Size = New System.Drawing.Size(138, 29)
        Me.BtnBuscarMed.TabIndex = 7
        Me.BtnBuscarMed.Text = "Buscar Producto"
        Me.BtnBuscarMed.UseVisualStyleBackColor = True
        '
        'TbTipo
        '
        Me.TbTipo.BackColor = System.Drawing.Color.White
        Me.TbTipo.Enabled = False
        Me.TbTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTipo.Location = New System.Drawing.Point(405, 85)
        Me.TbTipo.Name = "TbTipo"
        Me.TbTipo.Size = New System.Drawing.Size(215, 23)
        Me.TbTipo.TabIndex = 6
        '
        'TbForma
        '
        Me.TbForma.BackColor = System.Drawing.Color.White
        Me.TbForma.Enabled = False
        Me.TbForma.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbForma.Location = New System.Drawing.Point(229, 85)
        Me.TbForma.Name = "TbForma"
        Me.TbForma.Size = New System.Drawing.Size(169, 23)
        Me.TbForma.TabIndex = 5
        '
        'TbPresentacion
        '
        Me.TbPresentacion.BackColor = System.Drawing.Color.White
        Me.TbPresentacion.Enabled = False
        Me.TbPresentacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPresentacion.Location = New System.Drawing.Point(15, 85)
        Me.TbPresentacion.Name = "TbPresentacion"
        Me.TbPresentacion.Size = New System.Drawing.Size(207, 23)
        Me.TbPresentacion.TabIndex = 4
        '
        'TbConcentracion
        '
        Me.TbConcentracion.BackColor = System.Drawing.Color.White
        Me.TbConcentracion.Enabled = False
        Me.TbConcentracion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbConcentracion.Location = New System.Drawing.Point(626, 38)
        Me.TbConcentracion.Name = "TbConcentracion"
        Me.TbConcentracion.Size = New System.Drawing.Size(138, 23)
        Me.TbConcentracion.TabIndex = 3
        '
        'TbDescripcion
        '
        Me.TbDescripcion.BackColor = System.Drawing.Color.White
        Me.TbDescripcion.Enabled = False
        Me.TbDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcion.Location = New System.Drawing.Point(229, 38)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(391, 23)
        Me.TbDescripcion.TabIndex = 2
        '
        'TbAtc
        '
        Me.TbAtc.BackColor = System.Drawing.Color.White
        Me.TbAtc.Enabled = False
        Me.TbAtc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAtc.Location = New System.Drawing.Point(122, 38)
        Me.TbAtc.Name = "TbAtc"
        Me.TbAtc.Size = New System.Drawing.Size(100, 23)
        Me.TbAtc.TabIndex = 1
        '
        'TbCons
        '
        Me.TbCons.BackColor = System.Drawing.Color.White
        Me.TbCons.Enabled = False
        Me.TbCons.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCons.Location = New System.Drawing.Point(15, 38)
        Me.TbCons.Name = "TbCons"
        Me.TbCons.Size = New System.Drawing.Size(100, 23)
        Me.TbCons.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(806, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Año"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(648, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Mes Activo"
        '
        'TbAño
        '
        Me.TbAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbAño.BackColor = System.Drawing.Color.White
        Me.TbAño.Enabled = False
        Me.TbAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAño.Location = New System.Drawing.Point(809, 30)
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(64, 23)
        Me.TbAño.TabIndex = 105
        Me.TbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbMes
        '
        Me.TbMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbMes.BackColor = System.Drawing.Color.White
        Me.TbMes.Enabled = False
        Me.TbMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMes.Location = New System.Drawing.Point(688, 30)
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(115, 23)
        Me.TbMes.TabIndex = 104
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbConsMes
        '
        Me.TbConsMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbConsMes.BackColor = System.Drawing.Color.White
        Me.TbConsMes.Enabled = False
        Me.TbConsMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbConsMes.Location = New System.Drawing.Point(651, 30)
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(31, 23)
        Me.TbConsMes.TabIndex = 103
        Me.TbConsMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 18)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Traslados a Stop"
        '
        'FrmSalidasStop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbAlmacen)
        Me.Controls.Add(Me.LbNombreAlmacen)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbStop)
        Me.Controls.Add(Me.LbTipoProd)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.TbValor)
        Me.Controls.Add(Me.TbCantidad)
        Me.Controls.Add(Me.LbTProd)
        Me.Controls.Add(Me.LbSaldo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LbLab)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LbConsLote)
        Me.Controls.Add(Me.LbLote)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSalidasStop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LbAlmacen As Label
    Friend WithEvents LbNombreAlmacen As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CbStop As ComboBox
    Friend WithEvents LbTipoProd As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents TbValor As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbCantidad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LbTProd As Label
    Friend WithEvents LbSaldo As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LbLab As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LbConsLote As Label
    Friend WithEvents LbLote As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbUnidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscarMed As Button
    Friend WithEvents TbTipo As TextBox
    Friend WithEvents TbForma As TextBox
    Friend WithEvents TbPresentacion As TextBox
    Friend WithEvents TbConcentracion As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents TbAtc As TextBox
    Friend WithEvents TbCons As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbAño As TextBox
    Friend WithEvents TbMes As TextBox
    Friend WithEvents TbConsMes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
End Class
