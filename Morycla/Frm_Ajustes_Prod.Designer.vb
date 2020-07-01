<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ajustes_Prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ajustes_Prod))
        Me.LbAlmacen = New System.Windows.Forms.Label()
        Me.LbNombreAlmacen = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LbTipoProd = New System.Windows.Forms.Label()
        Me.LbTProd = New System.Windows.Forms.Label()
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LbLote = New System.Windows.Forms.Label()
        Me.LbConsLote = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LbIni = New System.Windows.Forms.Label()
        Me.LbEntradas = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbSalidas = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LbSaldo = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbCant = New System.Windows.Forms.TextBox()
        Me.TbUnitario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LbCons = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbAlmacen
        '
        Me.LbAlmacen.AutoSize = True
        Me.LbAlmacen.Location = New System.Drawing.Point(87, 19)
        Me.LbAlmacen.Name = "LbAlmacen"
        Me.LbAlmacen.Size = New System.Drawing.Size(78, 16)
        Me.LbAlmacen.TabIndex = 115
        Me.LbAlmacen.Text = "LbAlmacen"
        Me.LbAlmacen.Visible = False
        '
        'LbNombreAlmacen
        '
        Me.LbNombreAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNombreAlmacen.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombreAlmacen.ForeColor = System.Drawing.Color.MediumBlue
        Me.LbNombreAlmacen.Location = New System.Drawing.Point(76, 41)
        Me.LbNombreAlmacen.Name = "LbNombreAlmacen"
        Me.LbNombreAlmacen.Size = New System.Drawing.Size(456, 23)
        Me.LbNombreAlmacen.TabIndex = 114
        Me.LbNombreAlmacen.Text = "LbNombreAlmacen"
        Me.LbNombreAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label21.Location = New System.Drawing.Point(3, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 16)
        Me.Label21.TabIndex = 113
        Me.Label21.Text = "Almacén:"
        '
        'LbTipoProd
        '
        Me.LbTipoProd.AutoSize = True
        Me.LbTipoProd.Location = New System.Drawing.Point(261, 18)
        Me.LbTipoProd.Name = "LbTipoProd"
        Me.LbTipoProd.Size = New System.Drawing.Size(81, 16)
        Me.LbTipoProd.TabIndex = 112
        Me.LbTipoProd.Text = "LbTipoProd"
        Me.LbTipoProd.Visible = False
        '
        'LbTProd
        '
        Me.LbTProd.AutoSize = True
        Me.LbTProd.Location = New System.Drawing.Point(181, 19)
        Me.LbTProd.Name = "LbTProd"
        Me.LbTProd.Size = New System.Drawing.Size(63, 16)
        Me.LbTProd.TabIndex = 109
        Me.LbTProd.Text = "LbTProd"
        Me.LbTProd.Visible = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(2, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(951, 120)
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
        Me.Label10.Location = New System.Drawing.Point(861, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Año"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(703, 13)
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
        Me.TbAño.Location = New System.Drawing.Point(864, 32)
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
        Me.TbMes.Location = New System.Drawing.Point(743, 32)
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
        Me.TbConsMes.Location = New System.Drawing.Point(706, 32)
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(31, 23)
        Me.TbConsMes.TabIndex = 103
        Me.TbConsMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Ajustes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(933, 8)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 101
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 203)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(83, 20)
        Me.RadioButton1.TabIndex = 116
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Entradas"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(122, 203)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 20)
        Me.RadioButton2.TabIndex = 117
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Salidas"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(5, 229)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(957, 179)
        Me.Dgv.TabIndex = 118
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "FECHA"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "CONSLOTE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "LOTE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "ENTRADA"
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
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 16)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Lote Seleccionado:"
        '
        'LbLote
        '
        Me.LbLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbLote.AutoSize = True
        Me.LbLote.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLote.Location = New System.Drawing.Point(154, 416)
        Me.LbLote.Name = "LbLote"
        Me.LbLote.Size = New System.Drawing.Size(56, 16)
        Me.LbLote.TabIndex = 120
        Me.LbLote.Text = "LbLote"
        '
        'LbConsLote
        '
        Me.LbConsLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbConsLote.AutoSize = True
        Me.LbConsLote.Location = New System.Drawing.Point(404, 411)
        Me.LbConsLote.Name = "LbConsLote"
        Me.LbConsLote.Size = New System.Drawing.Size(85, 16)
        Me.LbConsLote.TabIndex = 121
        Me.LbConsLote.Text = "LbConsLote"
        Me.LbConsLote.Visible = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 451)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "Cantidad Inciial"
        '
        'LbIni
        '
        Me.LbIni.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbIni.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbIni.Location = New System.Drawing.Point(10, 474)
        Me.LbIni.Name = "LbIni"
        Me.LbIni.Size = New System.Drawing.Size(104, 16)
        Me.LbIni.TabIndex = 123
        Me.LbIni.Text = "LbIni"
        Me.LbIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbEntradas
        '
        Me.LbEntradas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbEntradas.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEntradas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbEntradas.Location = New System.Drawing.Point(123, 474)
        Me.LbEntradas.Name = "LbEntradas"
        Me.LbEntradas.Size = New System.Drawing.Size(119, 16)
        Me.LbEntradas.TabIndex = 125
        Me.LbEntradas.Text = "LbEntradas"
        Me.LbEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(120, 451)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 16)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Cantidad Entradas"
        '
        'LbSalidas
        '
        Me.LbSalidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbSalidas.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSalidas.ForeColor = System.Drawing.Color.Green
        Me.LbSalidas.Location = New System.Drawing.Point(255, 474)
        Me.LbSalidas.Name = "LbSalidas"
        Me.LbSalidas.Size = New System.Drawing.Size(112, 16)
        Me.LbSalidas.TabIndex = 127
        Me.LbSalidas.Text = "LbSalidas"
        Me.LbSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Green
        Me.Label16.Location = New System.Drawing.Point(252, 451)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 16)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Cantidad Salidas"
        '
        'LbSaldo
        '
        Me.LbSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbSaldo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSaldo.ForeColor = System.Drawing.Color.Green
        Me.LbSaldo.Location = New System.Drawing.Point(376, 474)
        Me.LbSaldo.Name = "LbSaldo"
        Me.LbSaldo.Size = New System.Drawing.Size(102, 16)
        Me.LbSaldo.TabIndex = 129
        Me.LbSaldo.Text = "LbSaldo"
        Me.LbSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Green
        Me.Label17.Location = New System.Drawing.Point(373, 451)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 16)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "Cantidad Saldo"
        '
        'TbCant
        '
        Me.TbCant.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbCant.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCant.Location = New System.Drawing.Point(556, 467)
        Me.TbCant.Name = "TbCant"
        Me.TbCant.Size = New System.Drawing.Size(100, 23)
        Me.TbCant.TabIndex = 130
        Me.TbCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TbUnitario
        '
        Me.TbUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbUnitario.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUnitario.Location = New System.Drawing.Point(666, 467)
        Me.TbUnitario.Name = "TbUnitario"
        Me.TbUnitario.Size = New System.Drawing.Size(100, 23)
        Me.TbUnitario.TabIndex = 131
        Me.TbUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(556, 448)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 16)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "Cantidad"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(666, 448)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "V. Unitario"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(785, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 134
        Me.Button1.Text = "Ajustar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LbCons
        '
        Me.LbCons.AutoSize = True
        Me.LbCons.Location = New System.Drawing.Point(527, 416)
        Me.LbCons.Name = "LbCons"
        Me.LbCons.Size = New System.Drawing.Size(57, 16)
        Me.LbCons.TabIndex = 135
        Me.LbCons.Text = "LbCons"
        Me.LbCons.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.Location = New System.Drawing.Point(874, 467)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(83, 23)
        Me.BtnEliminar.TabIndex = 136
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Frm_Ajustes_Prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.LbCons)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TbUnitario)
        Me.Controls.Add(Me.TbCant)
        Me.Controls.Add(Me.LbSaldo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LbSalidas)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LbEntradas)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LbIni)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LbConsLote)
        Me.Controls.Add(Me.LbLote)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LbAlmacen)
        Me.Controls.Add(Me.LbNombreAlmacen)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LbTipoProd)
        Me.Controls.Add(Me.LbTProd)
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
        Me.Name = "Frm_Ajustes_Prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbAlmacen As Label
    Friend WithEvents LbNombreAlmacen As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LbTipoProd As Label
    Friend WithEvents LbTProd As Label
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents LbLote As Label
    Friend WithEvents LbConsLote As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LbIni As Label
    Friend WithEvents LbEntradas As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LbSalidas As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LbSaldo As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TbCant As TextBox
    Friend WithEvents TbUnitario As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LbCons As Label
    Friend WithEvents BtnEliminar As Button
End Class
