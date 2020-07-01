<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFuncionarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbCons = New System.Windows.Forms.Label()
        Me.CbSede = New System.Windows.Forms.ComboBox()
        Me.CbTdoc = New System.Windows.Forms.ComboBox()
        Me.TbDoc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CbCargo = New System.Windows.Forms.ComboBox()
        Me.TbDir = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbTel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Funcionarios"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(794, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 29)
        Me.Button1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button1, "Cerrar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(184, 45)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(40, 38)
        Me.BtnEliminar.TabIndex = 27
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
        Me.BtnCancelar.Location = New System.Drawing.Point(138, 45)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(40, 38)
        Me.BtnCancelar.TabIndex = 26
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
        Me.BtnGuardar.Location = New System.Drawing.Point(92, 45)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 25
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
        Me.BtnModificar.Location = New System.Drawing.Point(46, 45)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(40, 38)
        Me.BtnModificar.TabIndex = 24
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
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 45)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(245, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 38)
        Me.Button2.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button2, "Buscar Funcionario")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 39)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(670, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cons:"
        '
        'LbCons
        '
        Me.LbCons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCons.Location = New System.Drawing.Point(732, 52)
        Me.LbCons.Name = "LbCons"
        Me.LbCons.Size = New System.Drawing.Size(82, 16)
        Me.LbCons.TabIndex = 5
        Me.LbCons.Text = "LbCons"
        Me.LbCons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbSede
        '
        Me.CbSede.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbSede.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSede.ForeColor = System.Drawing.Color.Maroon
        Me.CbSede.FormattingEnabled = True
        Me.CbSede.Location = New System.Drawing.Point(12, 118)
        Me.CbSede.Name = "CbSede"
        Me.CbSede.Size = New System.Drawing.Size(317, 24)
        Me.CbSede.TabIndex = 6
        '
        'CbTdoc
        '
        Me.CbTdoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbTdoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTdoc.ForeColor = System.Drawing.Color.Maroon
        Me.CbTdoc.FormattingEnabled = True
        Me.CbTdoc.Location = New System.Drawing.Point(348, 118)
        Me.CbTdoc.Name = "CbTdoc"
        Me.CbTdoc.Size = New System.Drawing.Size(282, 23)
        Me.CbTdoc.TabIndex = 7
        '
        'TbDoc
        '
        Me.TbDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDoc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbDoc.ForeColor = System.Drawing.Color.Maroon
        Me.TbDoc.HintForeColor = System.Drawing.Color.Empty
        Me.TbDoc.HintText = ""
        Me.TbDoc.isPassword = False
        Me.TbDoc.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDoc.LineIdleColor = System.Drawing.Color.Gray
        Me.TbDoc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDoc.LineThickness = 3
        Me.TbDoc.Location = New System.Drawing.Point(637, 109)
        Me.TbDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDoc.MaxLength = 32767
        Me.TbDoc.Name = "TbDoc"
        Me.TbDoc.Size = New System.Drawing.Size(176, 33)
        Me.TbDoc.TabIndex = 8
        Me.TbDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbNombre
        '
        Me.TbNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbNombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbNombre.ForeColor = System.Drawing.Color.Maroon
        Me.TbNombre.HintForeColor = System.Drawing.Color.Empty
        Me.TbNombre.HintText = ""
        Me.TbNombre.isPassword = False
        Me.TbNombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbNombre.LineIdleColor = System.Drawing.Color.Gray
        Me.TbNombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbNombre.LineThickness = 3
        Me.TbNombre.Location = New System.Drawing.Point(11, 173)
        Me.TbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNombre.MaxLength = 32767
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(379, 33)
        Me.TbNombre.TabIndex = 9
        Me.TbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CbCargo
        '
        Me.CbCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbCargo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCargo.ForeColor = System.Drawing.Color.Maroon
        Me.CbCargo.FormattingEnabled = True
        Me.CbCargo.Location = New System.Drawing.Point(415, 182)
        Me.CbCargo.Name = "CbCargo"
        Me.CbCargo.Size = New System.Drawing.Size(356, 24)
        Me.CbCargo.TabIndex = 10
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
        Me.TbDir.Location = New System.Drawing.Point(11, 237)
        Me.TbDir.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDir.MaxLength = 32767
        Me.TbDir.Name = "TbDir"
        Me.TbDir.Size = New System.Drawing.Size(379, 33)
        Me.TbDir.TabIndex = 11
        Me.TbDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbTel
        '
        Me.TbTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TbTel.Location = New System.Drawing.Point(415, 237)
        Me.TbTel.Margin = New System.Windows.Forms.Padding(4)
        Me.TbTel.MaxLength = 32767
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(206, 33)
        Me.TbTel.TabIndex = 12
        Me.TbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CbEstado
        '
        Me.CbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbEstado.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstado.ForeColor = System.Drawing.Color.Maroon
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.CbEstado.Location = New System.Drawing.Point(628, 246)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(185, 24)
        Me.CbEstado.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sede"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tipo Documento"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(634, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cargo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Dirección"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(412, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Teléfono"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(625, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Estado"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(780, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(12, 286)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(802, 158)
        Me.Dgv.TabIndex = 30
        '
        'FrmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.TbTel)
        Me.Controls.Add(Me.TbDir)
        Me.Controls.Add(Me.CbCargo)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.TbDoc)
        Me.Controls.Add(Me.CbTdoc)
        Me.Controls.Add(Me.CbSede)
        Me.Controls.Add(Me.LbCons)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LbCons As Label
    Friend WithEvents CbSede As ComboBox
    Friend WithEvents CbTdoc As ComboBox
    Friend WithEvents TbDoc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CbCargo As ComboBox
    Friend WithEvents TbDir As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbTel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Dgv As DataGridView
End Class
