<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEntradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntradas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbCons = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.CbProvedores = New System.Windows.Forms.ComboBox()
        Me.TbSoporte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TbPedido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnPedido = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnAlmacen = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAddProductos = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbTProd = New System.Windows.Forms.ComboBox()
        Me.TbMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbConsMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbAlmacenes = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Entradas de Productos"
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
        Me.TbCons.Location = New System.Drawing.Point(430, 2)
        Me.TbCons.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCons.MaxLength = 32767
        Me.TbCons.Name = "TbCons"
        Me.TbCons.Size = New System.Drawing.Size(86, 29)
        Me.TbCons.TabIndex = 2
        Me.TbCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cons"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(6, 70)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(111, 22)
        Me.DtFecha.TabIndex = 4
        '
        'CbProvedores
        '
        Me.CbProvedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbProvedores.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProvedores.ForeColor = System.Drawing.Color.Maroon
        Me.CbProvedores.FormattingEnabled = True
        Me.CbProvedores.Location = New System.Drawing.Point(430, 69)
        Me.CbProvedores.Name = "CbProvedores"
        Me.CbProvedores.Size = New System.Drawing.Size(287, 26)
        Me.CbProvedores.TabIndex = 5
        '
        'TbSoporte
        '
        Me.TbSoporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbSoporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbSoporte.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbSoporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbSoporte.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSoporte.ForeColor = System.Drawing.Color.Maroon
        Me.TbSoporte.HintForeColor = System.Drawing.Color.Empty
        Me.TbSoporte.HintText = ""
        Me.TbSoporte.isPassword = False
        Me.TbSoporte.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbSoporte.LineIdleColor = System.Drawing.Color.Gray
        Me.TbSoporte.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbSoporte.LineThickness = 3
        Me.TbSoporte.Location = New System.Drawing.Point(124, 62)
        Me.TbSoporte.Margin = New System.Windows.Forms.Padding(4)
        Me.TbSoporte.MaxLength = 32767
        Me.TbSoporte.Name = "TbSoporte"
        Me.TbSoporte.Size = New System.Drawing.Size(289, 33)
        Me.TbSoporte.TabIndex = 6
        Me.TbSoporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Soporte"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Proveedor"
        '
        'BtnProveedores
        '
        Me.BtnProveedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedores.Location = New System.Drawing.Point(724, 71)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(28, 23)
        Me.BtnProveedores.TabIndex = 10
        Me.BtnProveedores.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnProveedores, "Ir a Proveedores")
        Me.BtnProveedores.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(6, 147)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(967, 328)
        Me.Dgv.TabIndex = 11
        '
        'TbPedido
        '
        Me.TbPedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbPedido.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbPedido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPedido.Enabled = False
        Me.TbPedido.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPedido.ForeColor = System.Drawing.Color.Maroon
        Me.TbPedido.HintForeColor = System.Drawing.Color.Empty
        Me.TbPedido.HintText = ""
        Me.TbPedido.isPassword = False
        Me.TbPedido.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbPedido.LineIdleColor = System.Drawing.Color.Gray
        Me.TbPedido.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbPedido.LineThickness = 3
        Me.TbPedido.Location = New System.Drawing.Point(251, 32)
        Me.TbPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TbPedido.MaxLength = 32767
        Me.TbPedido.Name = "TbPedido"
        Me.TbPedido.Size = New System.Drawing.Size(104, 33)
        Me.TbPedido.TabIndex = 12
        Me.TbPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TbPedido.Visible = False
        '
        'BtnPedido
        '
        Me.BtnPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPedido.Location = New System.Drawing.Point(362, 44)
        Me.BtnPedido.Name = "BtnPedido"
        Me.BtnPedido.Size = New System.Drawing.Size(28, 23)
        Me.BtnPedido.TabIndex = 13
        Me.BtnPedido.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnPedido, "Buscar Pedido")
        Me.BtnPedido.UseVisualStyleBackColor = True
        Me.BtnPedido.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Pedido"
        Me.Label6.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(944, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnAlmacen
        '
        Me.BtnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlmacen.Location = New System.Drawing.Point(532, 111)
        Me.BtnAlmacen.Name = "BtnAlmacen"
        Me.BtnAlmacen.Size = New System.Drawing.Size(28, 23)
        Me.BtnAlmacen.TabIndex = 24
        Me.BtnAlmacen.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnAlmacen, "Ir a Almacenes")
        Me.BtnAlmacen.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(628, 103)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(582, 102)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(887, 103)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 38)
        Me.BtnBuscar.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.BtnBuscar, "Buscar")
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAddProductos
        '
        Me.BtnAddProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddProductos.FlatAppearance.BorderSize = 0
        Me.BtnAddProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnAddProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddProductos.Image = CType(resources.GetObject("BtnAddProductos.Image"), System.Drawing.Image)
        Me.BtnAddProductos.Location = New System.Drawing.Point(933, 103)
        Me.BtnAddProductos.Name = "BtnAddProductos"
        Me.BtnAddProductos.Size = New System.Drawing.Size(40, 38)
        Me.BtnAddProductos.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.BtnAddProductos, "Agregar Productos")
        Me.BtnAddProductos.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.FlatAppearance.BorderSize = 0
        Me.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportar.Image = CType(resources.GetObject("BtnExportar.Image"), System.Drawing.Image)
        Me.BtnExportar.Location = New System.Drawing.Point(674, 102)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(40, 38)
        Me.BtnExportar.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BtnExportar, "Exportar")
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(755, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tipo de Producto"
        '
        'CbTProd
        '
        Me.CbTProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbTProd.BackColor = System.Drawing.Color.White
        Me.CbTProd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTProd.ForeColor = System.Drawing.Color.Black
        Me.CbTProd.FormattingEnabled = True
        Me.CbTProd.Location = New System.Drawing.Point(758, 70)
        Me.CbTProd.Name = "CbTProd"
        Me.CbTProd.Size = New System.Drawing.Size(215, 24)
        Me.CbTProd.TabIndex = 17
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
        Me.TbMes.Location = New System.Drawing.Point(689, -2)
        Me.TbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMes.MaxLength = 32767
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(110, 33)
        Me.TbMes.TabIndex = 18
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TbAño.Location = New System.Drawing.Point(807, -2)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.MaxLength = 32767
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(61, 33)
        Me.TbAño.TabIndex = 19
        Me.TbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.TbConsMes.Location = New System.Drawing.Point(638, -2)
        Me.TbConsMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConsMes.MaxLength = 32767
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(43, 33)
        Me.TbConsMes.TabIndex = 20
        Me.TbConsMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(529, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Mes y Año Activo"
        '
        'CbAlmacenes
        '
        Me.CbAlmacenes.BackColor = System.Drawing.Color.White
        Me.CbAlmacenes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmacenes.ForeColor = System.Drawing.Color.Black
        Me.CbAlmacenes.FormattingEnabled = True
        Me.CbAlmacenes.Location = New System.Drawing.Point(85, 110)
        Me.CbAlmacenes.Name = "CbAlmacenes"
        Me.CbAlmacenes.Size = New System.Drawing.Size(441, 24)
        Me.CbAlmacenes.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Almacén"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(6, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Valor Total:"
        '
        'LbTotal
        '
        Me.LbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.ForeColor = System.Drawing.Color.Maroon
        Me.LbTotal.Location = New System.Drawing.Point(107, 485)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(66, 19)
        Me.LbTotal.TabIndex = 33
        Me.LbTotal.Text = "LbTotal"
        '
        'FrmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnAddProductos)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnAlmacen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbAlmacenes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.CbTProd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnPedido)
        Me.Controls.Add(Me.TbPedido)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.BtnProveedores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbSoporte)
        Me.Controls.Add(Me.CbProvedores)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbCons)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbCons As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents CbProvedores As ComboBox
    Friend WithEvents TbSoporte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents TbPedido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnPedido As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CbTProd As ComboBox
    Friend WithEvents TbMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbConsMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents CbAlmacenes As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAlmacen As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAddProductos As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents LbTotal As Label
End Class
