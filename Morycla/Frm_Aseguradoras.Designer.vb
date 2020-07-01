<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Aseguradoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Aseguradoras))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TbNit = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbTel = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbDir = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.TbCodigo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbCons = New System.Windows.Forms.Label()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(200, 48)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(40, 38)
        Me.BtnEliminar.TabIndex = 44
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
        Me.BtnCancelar.Location = New System.Drawing.Point(154, 48)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(40, 38)
        Me.BtnCancelar.TabIndex = 43
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
        Me.BtnGuardar.Location = New System.Drawing.Point(108, 48)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 42
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
        Me.BtnModificar.Location = New System.Drawing.Point(62, 48)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(40, 38)
        Me.BtnModificar.TabIndex = 41
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
        Me.BtnNuevo.Location = New System.Drawing.Point(16, 48)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(780, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aseguradoras (EPS)"
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
        Me.Dgv.Location = New System.Drawing.Point(12, 237)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(785, 209)
        Me.Dgv.TabIndex = 47
        '
        'TbNit
        '
        Me.TbNit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbNit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbNit.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbNit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbNit.HintForeColor = System.Drawing.Color.Empty
        Me.TbNit.HintText = ""
        Me.TbNit.isPassword = False
        Me.TbNit.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbNit.LineIdleColor = System.Drawing.Color.Gray
        Me.TbNit.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbNit.LineThickness = 3
        Me.TbNit.Location = New System.Drawing.Point(16, 121)
        Me.TbNit.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNit.MaxLength = 32767
        Me.TbNit.Name = "TbNit"
        Me.TbNit.Size = New System.Drawing.Size(184, 33)
        Me.TbNit.TabIndex = 48
        Me.TbNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbNombre
        '
        Me.TbNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbNombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbNombre.HintForeColor = System.Drawing.Color.Empty
        Me.TbNombre.HintText = ""
        Me.TbNombre.isPassword = False
        Me.TbNombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbNombre.LineIdleColor = System.Drawing.Color.Gray
        Me.TbNombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbNombre.LineThickness = 3
        Me.TbNombre.Location = New System.Drawing.Point(327, 121)
        Me.TbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNombre.MaxLength = 32767
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(469, 33)
        Me.TbNombre.TabIndex = 49
        Me.TbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbTel
        '
        Me.TbTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbTel.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbTel.HintForeColor = System.Drawing.Color.Empty
        Me.TbTel.HintText = ""
        Me.TbTel.isPassword = False
        Me.TbTel.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbTel.LineIdleColor = System.Drawing.Color.Gray
        Me.TbTel.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbTel.LineThickness = 3
        Me.TbTel.Location = New System.Drawing.Point(16, 177)
        Me.TbTel.Margin = New System.Windows.Forms.Padding(4)
        Me.TbTel.MaxLength = 32767
        Me.TbTel.Name = "TbTel"
        Me.TbTel.Size = New System.Drawing.Size(184, 33)
        Me.TbTel.TabIndex = 50
        Me.TbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbDir
        '
        Me.TbDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDir.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDir.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbDir.HintForeColor = System.Drawing.Color.Empty
        Me.TbDir.HintText = ""
        Me.TbDir.isPassword = False
        Me.TbDir.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDir.LineIdleColor = System.Drawing.Color.Gray
        Me.TbDir.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDir.LineThickness = 3
        Me.TbDir.Location = New System.Drawing.Point(208, 177)
        Me.TbDir.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDir.MaxLength = 32767
        Me.TbDir.Name = "TbDir"
        Me.TbDir.Size = New System.Drawing.Size(462, 33)
        Me.TbDir.TabIndex = 51
        Me.TbDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(677, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Estado"
        '
        'CbEstado
        '
        Me.CbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbEstado.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstado.ForeColor = System.Drawing.Color.Maroon
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.CbEstado.Location = New System.Drawing.Point(680, 186)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(116, 24)
        Me.CbEstado.TabIndex = 52
        '
        'TbCodigo
        '
        Me.TbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCodigo.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbCodigo.HintForeColor = System.Drawing.Color.Empty
        Me.TbCodigo.HintText = ""
        Me.TbCodigo.isPassword = False
        Me.TbCodigo.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCodigo.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCodigo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCodigo.LineThickness = 3
        Me.TbCodigo.Location = New System.Drawing.Point(208, 121)
        Me.TbCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCodigo.MaxLength = 32767
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.Size = New System.Drawing.Size(111, 33)
        Me.TbCodigo.TabIndex = 54
        Me.TbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Código"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Nombre de la Aseguradora (EPS)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Teléfono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(679, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Cons:"
        '
        'LbCons
        '
        Me.LbCons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbCons.Location = New System.Drawing.Point(730, 64)
        Me.LbCons.Name = "LbCons"
        Me.LbCons.Size = New System.Drawing.Size(67, 22)
        Me.LbCons.TabIndex = 61
        Me.LbCons.Text = "LbCons"
        Me.LbCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Aseguradoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbCons)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.TbDir)
        Me.Controls.Add(Me.TbTel)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.TbNit)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Aseguradoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents TbNit As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbTel As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbDir As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents TbCodigo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LbCons As Label
End Class
