<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Usuarios))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnNacionalidad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.CbTdoc = New System.Windows.Forms.ComboBox()
        Me.TbDoc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbNOmbre1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbNombre2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbApellido1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbApellido2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DtFecNac = New System.Windows.Forms.DateTimePicker()
        Me.CbDep = New System.Windows.Forms.ComboBox()
        Me.CbMun = New System.Windows.Forms.ComboBox()
        Me.CbZona = New System.Windows.Forms.ComboBox()
        Me.CbBarrio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbDir = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbTel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CbAseguradora = New System.Windows.Forms.ComboBox()
        Me.CbGenero = New System.Windows.Forms.ComboBox()
        Me.CbPais = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnBarrio = New System.Windows.Forms.Button()
        Me.BtnAseguradora = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarEnfoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEnfoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LbCons = New System.Windows.Forms.Label()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.CbTipoAfi = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(830, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(200, 45)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(40, 38)
        Me.BtnEliminar.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(154, 45)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(40, 38)
        Me.BtnCancelar.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(108, 45)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(62, 45)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(40, 38)
        Me.BtnModificar.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "Modificar")
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(16, 45)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnNacionalidad
        '
        Me.BtnNacionalidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNacionalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNacionalidad.FlatAppearance.BorderSize = 0
        Me.BtnNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNacionalidad.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNacionalidad.Location = New System.Drawing.Point(818, 291)
        Me.BtnNacionalidad.Name = "BtnNacionalidad"
        Me.BtnNacionalidad.Size = New System.Drawing.Size(31, 23)
        Me.BtnNacionalidad.TabIndex = 101
        Me.BtnNacionalidad.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnNacionalidad, "Ir a Nacionalidades")
        Me.BtnNacionalidad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuarios"
        '
        'Line1
        '
        Me.Line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.Location = New System.Drawing.Point(16, 89)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(833, 23)
        Me.Line1.TabIndex = 59
        Me.Line1.Text = "Line1"
        '
        'CbTdoc
        '
        Me.CbTdoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTdoc.ForeColor = System.Drawing.Color.Maroon
        Me.CbTdoc.FormattingEnabled = True
        Me.CbTdoc.Location = New System.Drawing.Point(154, 112)
        Me.CbTdoc.Name = "CbTdoc"
        Me.CbTdoc.Size = New System.Drawing.Size(214, 22)
        Me.CbTdoc.TabIndex = 0
        '
        'TbDoc
        '
        Me.TbDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDoc.ForeColor = System.Drawing.Color.Maroon
        Me.TbDoc.HintForeColor = System.Drawing.Color.Empty
        Me.TbDoc.HintText = ""
        Me.TbDoc.isPassword = False
        Me.TbDoc.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDoc.LineIdleColor = System.Drawing.Color.Gray
        Me.TbDoc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDoc.LineThickness = 2
        Me.TbDoc.Location = New System.Drawing.Point(154, 143)
        Me.TbDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDoc.MaxLength = 32767
        Me.TbDoc.Name = "TbDoc"
        Me.TbDoc.Size = New System.Drawing.Size(214, 33)
        Me.TbDoc.TabIndex = 1
        Me.TbDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbNOmbre1
        '
        Me.TbNOmbre1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbNOmbre1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbNOmbre1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNOmbre1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNOmbre1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNOmbre1.ForeColor = System.Drawing.Color.Maroon
        Me.TbNOmbre1.HintForeColor = System.Drawing.Color.Empty
        Me.TbNOmbre1.HintText = ""
        Me.TbNOmbre1.isPassword = False
        Me.TbNOmbre1.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbNOmbre1.LineIdleColor = System.Drawing.Color.Gray
        Me.TbNOmbre1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbNOmbre1.LineThickness = 2
        Me.TbNOmbre1.Location = New System.Drawing.Point(154, 184)
        Me.TbNOmbre1.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNOmbre1.MaxLength = 32767
        Me.TbNOmbre1.Name = "TbNOmbre1"
        Me.TbNOmbre1.Size = New System.Drawing.Size(214, 33)
        Me.TbNOmbre1.TabIndex = 2
        Me.TbNOmbre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbNombre2
        '
        Me.TbNombre2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbNombre2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbNombre2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNombre2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNombre2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombre2.ForeColor = System.Drawing.Color.Maroon
        Me.TbNombre2.HintForeColor = System.Drawing.Color.Empty
        Me.TbNombre2.HintText = ""
        Me.TbNombre2.isPassword = False
        Me.TbNombre2.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbNombre2.LineIdleColor = System.Drawing.Color.Gray
        Me.TbNombre2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbNombre2.LineThickness = 2
        Me.TbNombre2.Location = New System.Drawing.Point(154, 225)
        Me.TbNombre2.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNombre2.MaxLength = 32767
        Me.TbNombre2.Name = "TbNombre2"
        Me.TbNombre2.Size = New System.Drawing.Size(214, 33)
        Me.TbNombre2.TabIndex = 3
        Me.TbNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbApellido1
        '
        Me.TbApellido1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbApellido1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbApellido1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbApellido1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbApellido1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbApellido1.ForeColor = System.Drawing.Color.Maroon
        Me.TbApellido1.HintForeColor = System.Drawing.Color.Empty
        Me.TbApellido1.HintText = ""
        Me.TbApellido1.isPassword = False
        Me.TbApellido1.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbApellido1.LineIdleColor = System.Drawing.Color.Gray
        Me.TbApellido1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbApellido1.LineThickness = 2
        Me.TbApellido1.Location = New System.Drawing.Point(154, 266)
        Me.TbApellido1.Margin = New System.Windows.Forms.Padding(4)
        Me.TbApellido1.MaxLength = 32767
        Me.TbApellido1.Name = "TbApellido1"
        Me.TbApellido1.Size = New System.Drawing.Size(214, 33)
        Me.TbApellido1.TabIndex = 4
        Me.TbApellido1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbApellido2
        '
        Me.TbApellido2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbApellido2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbApellido2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbApellido2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbApellido2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbApellido2.ForeColor = System.Drawing.Color.Maroon
        Me.TbApellido2.HintForeColor = System.Drawing.Color.Empty
        Me.TbApellido2.HintText = ""
        Me.TbApellido2.isPassword = False
        Me.TbApellido2.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbApellido2.LineIdleColor = System.Drawing.Color.Gray
        Me.TbApellido2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbApellido2.LineThickness = 2
        Me.TbApellido2.Location = New System.Drawing.Point(154, 307)
        Me.TbApellido2.Margin = New System.Windows.Forms.Padding(4)
        Me.TbApellido2.MaxLength = 32767
        Me.TbApellido2.Name = "TbApellido2"
        Me.TbApellido2.Size = New System.Drawing.Size(214, 33)
        Me.TbApellido2.TabIndex = 5
        Me.TbApellido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DtFecNac
        '
        Me.DtFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecNac.Location = New System.Drawing.Point(154, 348)
        Me.DtFecNac.Name = "DtFecNac"
        Me.DtFecNac.Size = New System.Drawing.Size(214, 23)
        Me.DtFecNac.TabIndex = 6
        '
        'CbDep
        '
        Me.CbDep.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDep.ForeColor = System.Drawing.Color.Maroon
        Me.CbDep.FormattingEnabled = True
        Me.CbDep.Location = New System.Drawing.Point(154, 387)
        Me.CbDep.Name = "CbDep"
        Me.CbDep.Size = New System.Drawing.Size(214, 24)
        Me.CbDep.TabIndex = 7
        '
        'CbMun
        '
        Me.CbMun.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMun.ForeColor = System.Drawing.Color.Maroon
        Me.CbMun.FormattingEnabled = True
        Me.CbMun.Location = New System.Drawing.Point(154, 417)
        Me.CbMun.Name = "CbMun"
        Me.CbMun.Size = New System.Drawing.Size(214, 24)
        Me.CbMun.TabIndex = 8
        '
        'CbZona
        '
        Me.CbZona.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbZona.ForeColor = System.Drawing.Color.Maroon
        Me.CbZona.FormattingEnabled = True
        Me.CbZona.Items.AddRange(New Object() {"URBANA", "RURAL"})
        Me.CbZona.Location = New System.Drawing.Point(154, 447)
        Me.CbZona.Name = "CbZona"
        Me.CbZona.Size = New System.Drawing.Size(214, 24)
        Me.CbZona.TabIndex = 9
        '
        'CbBarrio
        '
        Me.CbBarrio.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbBarrio.ForeColor = System.Drawing.Color.Maroon
        Me.CbBarrio.FormattingEnabled = True
        Me.CbBarrio.Location = New System.Drawing.Point(154, 476)
        Me.CbBarrio.Name = "CbBarrio"
        Me.CbBarrio.Size = New System.Drawing.Size(214, 24)
        Me.CbBarrio.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Tipo Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Primer Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Segundo Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Primer Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Segundo Apellido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Fec. Nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Departamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 425)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Municipio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 455)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Zona"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 485)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 16)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Barrio / Vereda"
        '
        'TbDir
        '
        Me.TbDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDir.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbDir.ForeColor = System.Drawing.Color.Maroon
        Me.TbDir.HintForeColor = System.Drawing.Color.Empty
        Me.TbDir.HintText = ""
        Me.TbDir.isPassword = False
        Me.TbDir.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDir.LineIdleColor = System.Drawing.Color.Gray
        Me.TbDir.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDir.LineThickness = 3
        Me.TbDir.Location = New System.Drawing.Point(515, 103)
        Me.TbDir.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDir.MaxLength = 32767
        Me.TbDir.Name = "TbDir"
        Me.TbDir.Size = New System.Drawing.Size(334, 33)
        Me.TbDir.TabIndex = 11
        Me.TbDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbTel
        '
        Me.TbTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbTel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbTel.ForeColor = System.Drawing.Color.Maroon
        Me.TbTel.HintForeColor = System.Drawing.Color.Empty
        Me.TbTel.HintText = ""
        Me.TbTel.isPassword = False
        Me.TbTel.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbTel.LineIdleColor = System.Drawing.Color.Gray
        Me.TbTel.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbTel.LineThickness = 3
        Me.TbTel.Location = New System.Drawing.Point(515, 143)
        Me.TbTel.Margin = New System.Windows.Forms.Padding(4)
        Me.TbTel.MaxLength = 32767
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(334, 33)
        Me.TbTel.TabIndex = 12
        Me.TbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CbAseguradora
        '
        Me.CbAseguradora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbAseguradora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAseguradora.ForeColor = System.Drawing.Color.Maroon
        Me.CbAseguradora.FormattingEnabled = True
        Me.CbAseguradora.Location = New System.Drawing.Point(515, 193)
        Me.CbAseguradora.Name = "CbAseguradora"
        Me.CbAseguradora.Size = New System.Drawing.Size(297, 22)
        Me.CbAseguradora.TabIndex = 13
        '
        'CbGenero
        '
        Me.CbGenero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbGenero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbGenero.ForeColor = System.Drawing.Color.Maroon
        Me.CbGenero.FormattingEnabled = True
        Me.CbGenero.Location = New System.Drawing.Point(515, 260)
        Me.CbGenero.Name = "CbGenero"
        Me.CbGenero.Size = New System.Drawing.Size(334, 22)
        Me.CbGenero.TabIndex = 15
        '
        'CbPais
        '
        Me.CbPais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbPais.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPais.ForeColor = System.Drawing.Color.Maroon
        Me.CbPais.FormattingEnabled = True
        Me.CbPais.Location = New System.Drawing.Point(515, 290)
        Me.CbPais.Name = "CbPais"
        Me.CbPais.Size = New System.Drawing.Size(297, 22)
        Me.CbPais.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(417, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Dirección"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(417, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 16)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Teléfono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(417, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 16)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Aseguradora"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(417, 233)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 16)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Tipo Afiliación"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(417, 263)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 93
        Me.Label17.Text = "Genero"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(417, 293)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Nacionalidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(417, 324)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 16)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Estado"
        '
        'BtnBarrio
        '
        Me.BtnBarrio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBarrio.FlatAppearance.BorderSize = 0
        Me.BtnBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarrio.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarrio.Location = New System.Drawing.Point(374, 477)
        Me.BtnBarrio.Name = "BtnBarrio"
        Me.BtnBarrio.Size = New System.Drawing.Size(31, 23)
        Me.BtnBarrio.TabIndex = 96
        Me.BtnBarrio.Text = "..."
        Me.BtnBarrio.UseVisualStyleBackColor = True
        '
        'BtnAseguradora
        '
        Me.BtnAseguradora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAseguradora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAseguradora.FlatAppearance.BorderSize = 0
        Me.BtnAseguradora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAseguradora.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAseguradora.Location = New System.Drawing.Point(818, 193)
        Me.BtnAseguradora.Name = "BtnAseguradora"
        Me.BtnAseguradora.Size = New System.Drawing.Size(31, 23)
        Me.BtnAseguradora.TabIndex = 97
        Me.BtnAseguradora.Text = "..."
        Me.BtnAseguradora.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(420, 360)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(429, 173)
        Me.Dgv.TabIndex = 98
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEnfoqueToolStripMenuItem, Me.EliminarEnfoqueToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(165, 48)
        '
        'AgregarEnfoqueToolStripMenuItem
        '
        Me.AgregarEnfoqueToolStripMenuItem.Name = "AgregarEnfoqueToolStripMenuItem"
        Me.AgregarEnfoqueToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AgregarEnfoqueToolStripMenuItem.Text = "Agregar Enfoque"
        '
        'EliminarEnfoqueToolStripMenuItem
        '
        Me.EliminarEnfoqueToolStripMenuItem.Name = "EliminarEnfoqueToolStripMenuItem"
        Me.EliminarEnfoqueToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EliminarEnfoqueToolStripMenuItem.Text = "Eliminar Enfoque"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(708, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 16)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "Cons:"
        '
        'LbCons
        '
        Me.LbCons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbCons.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCons.ForeColor = System.Drawing.Color.DarkBlue
        Me.LbCons.Location = New System.Drawing.Point(759, 70)
        Me.LbCons.Name = "LbCons"
        Me.LbCons.Size = New System.Drawing.Size(90, 16)
        Me.LbCons.TabIndex = 100
        Me.LbCons.Text = "LbCons"
        Me.LbCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbEstado
        '
        Me.CbEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstado.ForeColor = System.Drawing.Color.Maroon
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.CbEstado.Location = New System.Drawing.Point(515, 321)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(334, 22)
        Me.CbEstado.TabIndex = 17
        '
        'CbTipoAfi
        '
        Me.CbTipoAfi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbTipoAfi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoAfi.ForeColor = System.Drawing.Color.Maroon
        Me.CbTipoAfi.FormattingEnabled = True
        Me.CbTipoAfi.Location = New System.Drawing.Point(515, 227)
        Me.CbTipoAfi.Name = "CbTipoAfi"
        Me.CbTipoAfi.Size = New System.Drawing.Size(334, 22)
        Me.CbTipoAfi.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(315, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 38)
        Me.Button1.TabIndex = 103
        Me.ToolTip1.SetToolTip(Me.Button1, "Buscar Persona")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID_ENFOQUE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "ENFOQUE_DIFERENCIAL"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CbTipoAfi)
        Me.Controls.Add(Me.BtnNacionalidad)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.LbCons)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.BtnAseguradora)
        Me.Controls.Add(Me.BtnBarrio)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CbPais)
        Me.Controls.Add(Me.CbGenero)
        Me.Controls.Add(Me.CbAseguradora)
        Me.Controls.Add(Me.TbTel)
        Me.Controls.Add(Me.TbDir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbBarrio)
        Me.Controls.Add(Me.CbZona)
        Me.Controls.Add(Me.CbMun)
        Me.Controls.Add(Me.CbDep)
        Me.Controls.Add(Me.DtFecNac)
        Me.Controls.Add(Me.TbApellido2)
        Me.Controls.Add(Me.TbApellido1)
        Me.Controls.Add(Me.TbNombre2)
        Me.Controls.Add(Me.TbNOmbre1)
        Me.Controls.Add(Me.TbDoc)
        Me.Controls.Add(Me.CbTdoc)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents CbTdoc As ComboBox
    Friend WithEvents TbDoc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbNOmbre1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbNombre2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbApellido1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbApellido2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DtFecNac As DateTimePicker
    Friend WithEvents CbDep As ComboBox
    Friend WithEvents CbMun As ComboBox
    Friend WithEvents CbZona As ComboBox
    Friend WithEvents CbBarrio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TbDir As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbTel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CbAseguradora As ComboBox
    Friend WithEvents CbGenero As ComboBox
    Friend WithEvents CbPais As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnBarrio As Button
    Friend WithEvents BtnAseguradora As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents LbCons As Label
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents BtnNacionalidad As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AgregarEnfoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarEnfoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbTipoAfi As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
