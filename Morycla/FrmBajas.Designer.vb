<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbConsMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBaja = New System.Windows.Forms.Button()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 23)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Baja de Productos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Mes y Año Activo"
        '
        'TbConsMes
        '
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
        Me.TbConsMes.Location = New System.Drawing.Point(434, -4)
        Me.TbConsMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConsMes.MaxLength = 32767
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(43, 33)
        Me.TbConsMes.TabIndex = 52
        Me.TbConsMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbAño
        '
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
        Me.TbAño.Location = New System.Drawing.Point(603, -4)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.MaxLength = 32767
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(61, 33)
        Me.TbAño.TabIndex = 51
        Me.TbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbMes
        '
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
        Me.TbMes.Location = New System.Drawing.Point(485, -4)
        Me.TbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMes.MaxLength = 32767
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(110, 33)
        Me.TbMes.TabIndex = 50
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(740, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 49
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column6, Me.Column3, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column5, Me.Column19})
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(12, 36)
        Me.Dgv.Name = "Dgv"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv.Size = New System.Drawing.Size(757, 400)
        Me.Dgv.TabIndex = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 71
        '
        'Column2
        '
        Me.Column2.HeaderText = "DETALLE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 83
        '
        'Column4
        '
        Me.Column4.HeaderText = "LOTE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 62
        '
        'Column6
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "VENCE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 77
        '
        'Column3
        '
        Me.Column3.HeaderText = "INVIMA"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 78
        '
        'Column7
        '
        Me.Column7.HeaderText = "INICIAL"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 78
        '
        'Column8
        '
        Me.Column8.HeaderText = "UNITARIO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        Me.Column8.Width = 90
        '
        'Column9
        '
        Me.Column9.HeaderText = "TOTAL"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        Me.Column9.Width = 69
        '
        'Column10
        '
        Me.Column10.HeaderText = "ENTRADA"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        Me.Column10.Width = 91
        '
        'Column11
        '
        Me.Column11.HeaderText = "UNITARIO"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        Me.Column11.Width = 90
        '
        'Column12
        '
        Me.Column12.HeaderText = "TOTAL"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        Me.Column12.Width = 69
        '
        'Column13
        '
        Me.Column13.HeaderText = "SALIDA"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        Me.Column13.Width = 76
        '
        'Column14
        '
        Me.Column14.HeaderText = "UNITARIO"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        Me.Column14.Width = 90
        '
        'Column15
        '
        Me.Column15.HeaderText = "TOTAL"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        Me.Column15.Width = 69
        '
        'Column16
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column16.HeaderText = "SALDO"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 75
        '
        'Column17
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column17.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column17.HeaderText = "UNITARIO"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 90
        '
        'Column18
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column18.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column18.HeaderText = "TOTAL"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 69
        '
        'Column5
        '
        Me.Column5.HeaderText = "DAR DE BAJA"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 97
        '
        'Column19
        '
        Me.Column19.HeaderText = "Med"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Visible = False
        Me.Column19.Width = 61
        '
        'BtnBaja
        '
        Me.BtnBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaja.Location = New System.Drawing.Point(627, 442)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(142, 35)
        Me.BtnBaja.TabIndex = 56
        Me.BtnBaja.Text = "Dar de Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'FrmBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnBaja)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmBajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbConsMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
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
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents BtnBaja As Button
End Class
