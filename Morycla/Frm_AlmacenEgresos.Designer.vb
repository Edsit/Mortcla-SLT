<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AlmacenEgresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AlmacenEgresos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbTProd = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtHasta = New System.Windows.Forms.DateTimePicker()
        Me.DtDesde = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TbConsMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbBMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbBAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Egresos"
        '
        'CbTProd
        '
        Me.CbTProd.BackColor = System.Drawing.Color.SteelBlue
        Me.CbTProd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTProd.ForeColor = System.Drawing.Color.White
        Me.CbTProd.FormattingEnabled = True
        Me.CbTProd.Location = New System.Drawing.Point(16, 68)
        Me.CbTProd.Name = "CbTProd"
        Me.CbTProd.Size = New System.Drawing.Size(215, 24)
        Me.CbTProd.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Tipo de Producto"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(749, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(31, 32)
        Me.BtnCerrar.TabIndex = 25
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Tipo de Salida"
        Me.Label4.Visible = False
        '
        'CbTipo
        '
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(237, 68)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(176, 24)
        Me.CbTipo.TabIndex = 32
        Me.CbTipo.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 118)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton1.TabIndex = 34
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mes Activo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(371, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Mes y Año Activo"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(115, 118)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 20)
        Me.RadioButton2.TabIndex = 38
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Fecha"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Desde"
        '
        'DtHasta
        '
        Me.DtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtHasta.Location = New System.Drawing.Point(138, 169)
        Me.DtHasta.Name = "DtHasta"
        Me.DtHasta.Size = New System.Drawing.Size(116, 23)
        Me.DtHasta.TabIndex = 40
        '
        'DtDesde
        '
        Me.DtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtDesde.Location = New System.Drawing.Point(16, 169)
        Me.DtDesde.Name = "DtDesde"
        Me.DtDesde.Size = New System.Drawing.Size(116, 23)
        Me.DtDesde.TabIndex = 39
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(188, 118)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(130, 20)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Seleccionar Mes"
        Me.RadioButton3.UseVisualStyleBackColor = True
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
        Me.TbConsMes.Location = New System.Drawing.Point(492, 9)
        Me.TbConsMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConsMes.MaxLength = 32767
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(43, 33)
        Me.TbConsMes.TabIndex = 46
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
        Me.TbAño.Location = New System.Drawing.Point(661, 9)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.MaxLength = 32767
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(61, 33)
        Me.TbAño.TabIndex = 45
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
        Me.TbMes.Location = New System.Drawing.Point(543, 9)
        Me.TbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMes.MaxLength = 32767
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(110, 33)
        Me.TbMes.TabIndex = 44
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TbBMes.Location = New System.Drawing.Point(289, 159)
        Me.TbBMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbBMes.MaxLength = 32767
        Me.TbBMes.Name = "TbBMes"
        Me.TbBMes.Size = New System.Drawing.Size(43, 33)
        Me.TbBMes.TabIndex = 47
        Me.TbBMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TbBAño.Location = New System.Drawing.Point(340, 159)
        Me.TbBAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbBAño.MaxLength = 32767
        Me.TbBAño.Name = "TbBAño"
        Me.TbBAño.Size = New System.Drawing.Size(61, 33)
        Me.TbBAño.TabIndex = 48
        Me.TbBAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Mes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Año"
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(16, 210)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(755, 277)
        Me.Dgv.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "LOTE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "INVIMA"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "VENCIMIENTO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "DETALLE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "UNIDAD"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "CANTIDAD"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "UNITARIO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "TOTAL"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "OBS"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGenerar.Location = New System.Drawing.Point(541, 181)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(112, 23)
        Me.BtnGenerar.TabIndex = 52
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.Location = New System.Drawing.Point(659, 181)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(112, 23)
        Me.BtnExportar.TabIndex = 53
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Frm_AlmacenEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbBAño)
        Me.Controls.Add(Me.TbBMes)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtHasta)
        Me.Controls.Add(Me.DtDesde)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbTipo)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.CbTProd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_AlmacenEgresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbTProd As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtHasta As DateTimePicker
    Friend WithEvents DtDesde As DateTimePicker
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TbConsMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbBMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbBAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents BtnExportar As Button
End Class
