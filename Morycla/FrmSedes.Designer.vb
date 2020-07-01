<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSedes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSedes))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CbUsaPrefijo = New System.Windows.Forms.ComboBox()
        Me.TbPrefijo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbSede = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbCodHabilitacion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbNit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbCons = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sedes"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1173, -3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button1, "Cerrar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(409, 187)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(455, 187)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(40, 38)
        Me.BtnModificar.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "Modificar")
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(501, 187)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(547, 187)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(40, 38)
        Me.BtnCancelar.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(593, 187)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(40, 38)
        Me.BtnEliminar.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1096, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 38)
        Me.Button2.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.Button2, "Dirección")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1142, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 38)
        Me.Button3.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.Button3, "Teléfono")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CbUsaPrefijo
        '
        Me.CbUsaPrefijo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbUsaPrefijo.ForeColor = System.Drawing.Color.Maroon
        Me.CbUsaPrefijo.FormattingEnabled = True
        Me.CbUsaPrefijo.Items.AddRange(New Object() {"NO", "SI"})
        Me.CbUsaPrefijo.Location = New System.Drawing.Point(17, 81)
        Me.CbUsaPrefijo.Name = "CbUsaPrefijo"
        Me.CbUsaPrefijo.Size = New System.Drawing.Size(122, 24)
        Me.CbUsaPrefijo.TabIndex = 2
        '
        'TbPrefijo
        '
        Me.TbPrefijo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbPrefijo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbPrefijo.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbPrefijo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPrefijo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbPrefijo.ForeColor = System.Drawing.Color.Maroon
        Me.TbPrefijo.HintForeColor = System.Drawing.Color.Empty
        Me.TbPrefijo.HintText = ""
        Me.TbPrefijo.isPassword = False
        Me.TbPrefijo.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbPrefijo.LineIdleColor = System.Drawing.Color.Gray
        Me.TbPrefijo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbPrefijo.LineThickness = 3
        Me.TbPrefijo.Location = New System.Drawing.Point(146, 72)
        Me.TbPrefijo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbPrefijo.MaxLength = 32767
        Me.TbPrefijo.Name = "TbPrefijo"
        Me.TbPrefijo.Size = New System.Drawing.Size(116, 33)
        Me.TbPrefijo.TabIndex = 3
        Me.TbPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbSede
        '
        Me.TbSede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbSede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbSede.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbSede.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbSede.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbSede.ForeColor = System.Drawing.Color.Maroon
        Me.TbSede.HintForeColor = System.Drawing.Color.Empty
        Me.TbSede.HintText = ""
        Me.TbSede.isPassword = False
        Me.TbSede.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbSede.LineIdleColor = System.Drawing.Color.Gray
        Me.TbSede.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbSede.LineThickness = 3
        Me.TbSede.Location = New System.Drawing.Point(270, 72)
        Me.TbSede.Margin = New System.Windows.Forms.Padding(4)
        Me.TbSede.MaxLength = 32767
        Me.TbSede.Name = "TbSede"
        Me.TbSede.Size = New System.Drawing.Size(363, 33)
        Me.TbSede.TabIndex = 4
        Me.TbSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbCodHabilitacion
        '
        Me.TbCodHabilitacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCodHabilitacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCodHabilitacion.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCodHabilitacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCodHabilitacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbCodHabilitacion.ForeColor = System.Drawing.Color.Maroon
        Me.TbCodHabilitacion.HintForeColor = System.Drawing.Color.Empty
        Me.TbCodHabilitacion.HintText = ""
        Me.TbCodHabilitacion.isPassword = False
        Me.TbCodHabilitacion.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCodHabilitacion.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCodHabilitacion.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCodHabilitacion.LineThickness = 3
        Me.TbCodHabilitacion.Location = New System.Drawing.Point(17, 129)
        Me.TbCodHabilitacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCodHabilitacion.MaxLength = 32767
        Me.TbCodHabilitacion.Name = "TbCodHabilitacion"
        Me.TbCodHabilitacion.Size = New System.Drawing.Size(245, 33)
        Me.TbCodHabilitacion.TabIndex = 5
        Me.TbCodHabilitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbNit
        '
        Me.TbNit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbNit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbNit.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbNit.ForeColor = System.Drawing.Color.Maroon
        Me.TbNit.HintForeColor = System.Drawing.Color.Empty
        Me.TbNit.HintText = ""
        Me.TbNit.isPassword = False
        Me.TbNit.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbNit.LineIdleColor = System.Drawing.Color.Gray
        Me.TbNit.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbNit.LineThickness = 3
        Me.TbNit.Location = New System.Drawing.Point(270, 129)
        Me.TbNit.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNit.MaxLength = 32767
        Me.TbNit.Name = "TbNit"
        Me.TbNit.Size = New System.Drawing.Size(240, 33)
        Me.TbNit.TabIndex = 6
        Me.TbNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CbEstado
        '
        Me.CbEstado.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstado.ForeColor = System.Drawing.Color.Maroon
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.CbEstado.Location = New System.Drawing.Point(517, 138)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(116, 24)
        Me.CbEstado.TabIndex = 7
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(17, 231)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dgv.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv.Size = New System.Drawing.Size(616, 235)
        Me.Dgv.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Usa Prefijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(514, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Prefijo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sede"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Codigo de Habilitación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(504, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cons:"
        '
        'LbCons
        '
        Me.LbCons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCons.Location = New System.Drawing.Point(559, 19)
        Me.LbCons.Name = "LbCons"
        Me.LbCons.Size = New System.Drawing.Size(74, 18)
        Me.LbCons.TabIndex = 17
        Me.LbCons.Text = "LbCons"
        Me.LbCons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(640, 101)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 378)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dgv1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(544, 349)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ubicación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Dgv1.EnableHeadersVisualStyles = False
        Me.Dgv1.Location = New System.Drawing.Point(6, 16)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.RowHeadersVisible = False
        Me.Dgv1.Size = New System.Drawing.Size(532, 324)
        Me.Dgv1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "TIPO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "DETALLE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Parámetros"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(17, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 38)
        Me.Button4.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Button4, "Seleccionar Sede Para Salidas")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FrmSedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LbCons)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.TbNit)
        Me.Controls.Add(Me.TbCodHabilitacion)
        Me.Controls.Add(Me.TbSede)
        Me.Controls.Add(Me.TbPrefijo)
        Me.Controls.Add(Me.CbUsaPrefijo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSedes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CbUsaPrefijo As ComboBox
    Friend WithEvents TbPrefijo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbSede As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbCodHabilitacion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbNit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LbCons As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
End Class
