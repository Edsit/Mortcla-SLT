<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Traslados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Traslados))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnAddProductos = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbConsMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbAño = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbMes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbCons = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbAlmOrigen = New System.Windows.Forms.ComboBox()
        Me.CbAlmDestino = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTProd = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TbObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LbResp = New System.Windows.Forms.Label()
        Me.LbResponsable = New System.Windows.Forms.Label()
        Me.LbSede = New System.Windows.Forms.Label()
        Me.LbCargo = New System.Windows.Forms.Label()
        Me.LbCarg = New System.Windows.Forms.Label()
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
        Me.BtnCerrar.Location = New System.Drawing.Point(760, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.FlatAppearance.BorderSize = 0
        Me.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportar.Image = CType(resources.GetObject("BtnExportar.Image"), System.Drawing.Image)
        Me.BtnExportar.Location = New System.Drawing.Point(154, 220)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(40, 38)
        Me.BtnExportar.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.BtnExportar, "Exportar")
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(62, 220)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 38
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
        Me.BtnNuevo.Location = New System.Drawing.Point(16, 219)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnAddProductos
        '
        Me.BtnAddProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddProductos.FlatAppearance.BorderSize = 0
        Me.BtnAddProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnAddProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddProductos.Image = CType(resources.GetObject("BtnAddProductos.Image"), System.Drawing.Image)
        Me.BtnAddProductos.Location = New System.Drawing.Point(739, 220)
        Me.BtnAddProductos.Name = "BtnAddProductos"
        Me.BtnAddProductos.Size = New System.Drawing.Size(40, 38)
        Me.BtnAddProductos.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.BtnAddProductos, "Agregar Productos")
        Me.BtnAddProductos.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(693, 220)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 38)
        Me.BtnBuscar.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.BtnBuscar, "Buscar")
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(108, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 38)
        Me.Button1.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancelar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Traslados de Productos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(391, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 28
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
        Me.TbConsMes.Location = New System.Drawing.Point(500, -2)
        Me.TbConsMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConsMes.MaxLength = 32767
        Me.TbConsMes.Name = "TbConsMes"
        Me.TbConsMes.Size = New System.Drawing.Size(43, 33)
        Me.TbConsMes.TabIndex = 27
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
        Me.TbAño.Location = New System.Drawing.Point(669, -2)
        Me.TbAño.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAño.MaxLength = 32767
        Me.TbAño.Name = "TbAño"
        Me.TbAño.Size = New System.Drawing.Size(61, 33)
        Me.TbAño.TabIndex = 26
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
        Me.TbMes.Location = New System.Drawing.Point(551, -2)
        Me.TbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMes.MaxLength = 32767
        Me.TbMes.Name = "TbMes"
        Me.TbMes.Size = New System.Drawing.Size(110, 33)
        Me.TbMes.TabIndex = 25
        Me.TbMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cons"
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
        Me.TbCons.Location = New System.Drawing.Point(68, 55)
        Me.TbCons.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCons.MaxLength = 32767
        Me.TbCons.Name = "TbCons"
        Me.TbCons.Size = New System.Drawing.Size(86, 29)
        Me.TbCons.TabIndex = 22
        Me.TbCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Fecha:"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(260, 60)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(114, 23)
        Me.DtFecha.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Almacén Origen"
        '
        'CbAlmOrigen
        '
        Me.CbAlmOrigen.BackColor = System.Drawing.Color.White
        Me.CbAlmOrigen.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmOrigen.ForeColor = System.Drawing.Color.Black
        Me.CbAlmOrigen.FormattingEnabled = True
        Me.CbAlmOrigen.Location = New System.Drawing.Point(16, 136)
        Me.CbAlmOrigen.Name = "CbAlmOrigen"
        Me.CbAlmOrigen.Size = New System.Drawing.Size(421, 24)
        Me.CbAlmOrigen.TabIndex = 31
        '
        'CbAlmDestino
        '
        Me.CbAlmDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbAlmDestino.BackColor = System.Drawing.Color.White
        Me.CbAlmDestino.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmDestino.ForeColor = System.Drawing.Color.Black
        Me.CbAlmDestino.FormattingEnabled = True
        Me.CbAlmDestino.Location = New System.Drawing.Point(445, 136)
        Me.CbAlmDestino.Name = "CbAlmDestino"
        Me.CbAlmDestino.Size = New System.Drawing.Size(334, 24)
        Me.CbAlmDestino.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(442, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Almacén Destino"
        '
        'CbTProd
        '
        Me.CbTProd.BackColor = System.Drawing.Color.White
        Me.CbTProd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTProd.ForeColor = System.Drawing.Color.Black
        Me.CbTProd.FormattingEnabled = True
        Me.CbTProd.Location = New System.Drawing.Point(500, 59)
        Me.CbTProd.Name = "CbTProd"
        Me.CbTProd.Size = New System.Drawing.Size(279, 24)
        Me.CbTProd.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tipo Producto"
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
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(16, 264)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(763, 213)
        Me.Dgv.TabIndex = 41
        '
        'TbObs
        '
        Me.TbObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbObs.Location = New System.Drawing.Point(16, 191)
        Me.TbObs.Name = "TbObs"
        Me.TbObs.Size = New System.Drawing.Size(645, 23)
        Me.TbObs.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Observación"
        '
        'TbEstado
        '
        Me.TbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbEstado.Location = New System.Drawing.Point(669, 191)
        Me.TbEstado.Name = "TbEstado"
        Me.TbEstado.ReadOnly = True
        Me.TbEstado.Size = New System.Drawing.Size(110, 23)
        Me.TbEstado.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(666, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Estado"
        '
        'LbResp
        '
        Me.LbResp.AutoSize = True
        Me.LbResp.Location = New System.Drawing.Point(205, 117)
        Me.LbResp.Name = "LbResp"
        Me.LbResp.Size = New System.Drawing.Size(57, 16)
        Me.LbResp.TabIndex = 49
        Me.LbResp.Text = "LbResp"
        Me.LbResp.Visible = False
        '
        'LbResponsable
        '
        Me.LbResponsable.AutoSize = True
        Me.LbResponsable.Location = New System.Drawing.Point(592, 115)
        Me.LbResponsable.Name = "LbResponsable"
        Me.LbResponsable.Size = New System.Drawing.Size(107, 16)
        Me.LbResponsable.TabIndex = 50
        Me.LbResponsable.Text = "LbResponsable"
        Me.LbResponsable.Visible = False
        '
        'LbSede
        '
        Me.LbSede.AutoSize = True
        Me.LbSede.Location = New System.Drawing.Point(592, 99)
        Me.LbSede.Name = "LbSede"
        Me.LbSede.Size = New System.Drawing.Size(57, 16)
        Me.LbSede.TabIndex = 51
        Me.LbSede.Text = "LbSede"
        Me.LbSede.Visible = False
        '
        'LbCargo
        '
        Me.LbCargo.AutoSize = True
        Me.LbCargo.Location = New System.Drawing.Point(693, 99)
        Me.LbCargo.Name = "LbCargo"
        Me.LbCargo.Size = New System.Drawing.Size(63, 16)
        Me.LbCargo.TabIndex = 52
        Me.LbCargo.Text = "LbCargo"
        Me.LbCargo.Visible = False
        '
        'LbCarg
        '
        Me.LbCarg.AutoSize = True
        Me.LbCarg.Location = New System.Drawing.Point(269, 117)
        Me.LbCarg.Name = "LbCarg"
        Me.LbCarg.Size = New System.Drawing.Size(55, 16)
        Me.LbCarg.TabIndex = 53
        Me.LbCarg.Text = "LbCarg"
        Me.LbCarg.Visible = False
        '
        'Frm_Traslados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(791, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbCarg)
        Me.Controls.Add(Me.LbCargo)
        Me.Controls.Add(Me.LbSede)
        Me.Controls.Add(Me.LbResponsable)
        Me.Controls.Add(Me.LbResp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbEstado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbObs)
        Me.Controls.Add(Me.BtnAddProductos)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbTProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbAlmDestino)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbAlmOrigen)
        Me.Controls.Add(Me.DtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbConsMes)
        Me.Controls.Add(Me.TbAño)
        Me.Controls.Add(Me.TbMes)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbCons)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Traslados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbConsMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbAño As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbMes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TbCons As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents CbAlmOrigen As ComboBox
    Friend WithEvents CbAlmDestino As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTProd As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnExportar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents BtnAddProductos As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TbObs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbEstado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LbResp As Label
    Friend WithEvents LbResponsable As Label
    Friend WithEvents LbSede As Label
    Friend WithEvents LbCargo As Label
    Friend WithEvents LbCarg As Label
End Class
