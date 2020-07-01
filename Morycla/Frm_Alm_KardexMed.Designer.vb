<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Alm_KardexMed
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Alm_KardexMed))
        Me.DgvMed = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbBAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbBMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TbConsMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvMed
        '
        Me.DgvMed.AllowUserToAddRows = False
        Me.DgvMed.AllowUserToDeleteRows = False
        Me.DgvMed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvMed.BackgroundColor = System.Drawing.Color.White
        Me.DgvMed.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column19, Me.Column20, Me.Column21, Me.Column23, Me.Column24, Me.Column22, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column25, Me.Column28})
        Me.DgvMed.EnableHeadersVisualStyles = False
        Me.DgvMed.Location = New System.Drawing.Point(12, 110)
        Me.DgvMed.Name = "DgvMed"
        Me.DgvMed.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMed.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMed.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMed.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMed.Size = New System.Drawing.Size(743, 336)
        Me.DgvMed.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONSLOTE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 101
        '
        'Column19
        '
        Me.Column19.HeaderText = "CUM"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 63
        '
        'Column20
        '
        Me.Column20.HeaderText = "ATC"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 59
        '
        'Column21
        '
        Me.Column21.HeaderText = "PRINCIPIO ACTIVO"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 139
        '
        'Column23
        '
        Me.Column23.HeaderText = "PRESENTACION"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Width = 130
        '
        'Column24
        '
        Me.Column24.HeaderText = "FORMA FARMACEUTICA"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.Width = 168
        '
        'Column22
        '
        Me.Column22.HeaderText = "CONCENTRACION"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "UNIDAD"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 83
        '
        'Column3
        '
        Me.Column3.HeaderText = "LABORATORIO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 126
        '
        'Column4
        '
        Me.Column4.HeaderText = "LOTE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 63
        '
        'Column5
        '
        Me.Column5.HeaderText = "REGISTRO INVIMA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 135
        '
        'Column6
        '
        Me.Column6.HeaderText = "VENCE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 76
        '
        'Column7
        '
        Me.Column7.HeaderText = "INICIAL"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 81
        '
        'Column8
        '
        Me.Column8.HeaderText = "UNITARIO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 94
        '
        'Column9
        '
        Me.Column9.HeaderText = "TOTAL"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 72
        '
        'Column10
        '
        Me.Column10.HeaderText = "ENTRADA"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 93
        '
        'Column11
        '
        Me.Column11.HeaderText = "UNITARIO"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 94
        '
        'Column12
        '
        Me.Column12.HeaderText = "TOTAL"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 72
        '
        'Column13
        '
        Me.Column13.HeaderText = "SALIDA"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 79
        '
        'Column14
        '
        Me.Column14.HeaderText = "UNITARIO"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 94
        '
        'Column15
        '
        Me.Column15.HeaderText = "TOTAL"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 72
        '
        'Column16
        '
        Me.Column16.HeaderText = "SALDO"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 76
        '
        'Column17
        '
        Me.Column17.HeaderText = "UNITARIO"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 94
        '
        'Column18
        '
        Me.Column18.HeaderText = "TOTAL"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 72
        '
        'Column25
        '
        Me.Column25.HeaderText = "TIPO"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.Width = 61
        '
        'Column28
        '
        Me.Column28.HeaderText = "OBS"
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(726, 5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 62
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.Location = New System.Drawing.Point(548, 53)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(80, 23)
        Me.BtnExportar.TabIndex = 75
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGenerar.Location = New System.Drawing.Point(466, 53)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(76, 23)
        Me.BtnGenerar.TabIndex = 74
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Mes"
        '
        'TbBAño
        '
        Me.TbBAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbBAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbBAño.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbBAño.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbBAño.Enabled = False
        Me.TbBAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbBAño.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbBAño.HintForeColor = System.Drawing.Color.Empty
        Me.TbBAño.HintText = ""
        Me.TbBAño.isPassword = False
        Me.TbBAño.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbBAño.LineIdleColor = System.Drawing.Color.Gray
        Me.TbBAño.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbBAño.LineThickness = 3
        Me.TbBAño.Location = New System.Drawing.Point(337, 69)
        Me.TbBAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbBAño.MaxLength = 32767
        Me.TbBAño.Name = "TbBAño"
        Me.TbBAño.Size = New System.Drawing.Size(61, 33)
        Me.TbBAño.TabIndex = 71
        Me.TbBAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbBMes
        '
        Me.TbBMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbBMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbBMes.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbBMes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbBMes.Enabled = False
        Me.TbBMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbBMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbBMes.HintForeColor = System.Drawing.Color.Empty
        Me.TbBMes.HintText = ""
        Me.TbBMes.isPassword = False
        Me.TbBMes.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbBMes.LineIdleColor = System.Drawing.Color.Gray
        Me.TbBMes.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbBMes.LineThickness = 3
        Me.TbBMes.Location = New System.Drawing.Point(286, 69)
        Me.TbBMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbBMes.MaxLength = 32767
        Me.TbBMes.Name = "TbBMes"
        Me.TbBMes.Size = New System.Drawing.Size(43, 33)
        Me.TbBMes.TabIndex = 70
        Me.TbBMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(132, 82)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(130, 20)
        Me.RadioButton3.TabIndex = 69
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Seleccionar Mes"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 82)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton1.TabIndex = 63
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mes Activo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TbConsMes
        '
        Me.TbConsMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbConsMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbConsMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbConsMes.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbConsMes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbConsMes.Enabled = False
        Me.TbConsMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbConsMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbConsMes.HintForeColor = System.Drawing.Color.Empty
        Me.TbConsMes.HintText = ""
        Me.TbConsMes.isPassword = False
        Me.TbConsMes.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbConsMes.LineIdleColor = System.Drawing.Color.Gray
        Me.TbConsMes.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbConsMes.LineThickness = 3
        Me.TbConsMes.Location = New System.Drawing.Point(474, 5)
        Me.TbConsMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConsMes.MaxLength = 32767
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(43, 33)
        Me.TbConsMes.TabIndex = 79
        Me.TbConsMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbAño
        '
        Me.TbAño.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbAño.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbAño.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbAño.Enabled = False
        Me.TbAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbAño.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbAño.HintForeColor = System.Drawing.Color.Empty
        Me.TbAño.HintText = ""
        Me.TbAño.isPassword = False
        Me.TbAño.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbAño.LineIdleColor = System.Drawing.Color.Gray
        Me.TbAño.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbAño.LineThickness = 3
        Me.TbAño.Location = New System.Drawing.Point(643, 5)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.MaxLength = 32767
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(61, 33)
        Me.TbAño.TabIndex = 78
        Me.TbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbMes
        '
        Me.TbMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbMes.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbMes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbMes.Enabled = False
        Me.TbMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbMes.HintForeColor = System.Drawing.Color.Empty
        Me.TbMes.HintText = ""
        Me.TbMes.isPassword = False
        Me.TbMes.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbMes.LineIdleColor = System.Drawing.Color.Gray
        Me.TbMes.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbMes.LineThickness = 3
        Me.TbMes.Location = New System.Drawing.Point(525, 5)
        Me.TbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMes.MaxLength = 32767
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(110, 33)
        Me.TbMes.TabIndex = 77
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Mes y Año Activo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 23)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Kardex de Medicamentos"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(525, 86)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(218, 20)
        Me.CheckBox1.TabIndex = 81
        Me.CheckBox1.Text = "Exportar con todos los colores"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(634, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Exportar Simple"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Alm_KardexMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbBAño)
        Me.Controls.Add(Me.TbBMes)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.DgvMed)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Alm_KardexMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgvMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvMed As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
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
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbBAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbBMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TbConsMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
End Class
