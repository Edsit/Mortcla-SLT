<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDep))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbCons = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbCodigo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbDep = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
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
        Me.BtnCerrar.Location = New System.Drawing.Point(584, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 50
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
        Me.BtnEliminar.Location = New System.Drawing.Point(196, 50)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(40, 38)
        Me.BtnEliminar.TabIndex = 55
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
        Me.BtnCancelar.Location = New System.Drawing.Point(150, 50)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(40, 38)
        Me.BtnCancelar.TabIndex = 54
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
        Me.BtnGuardar.Location = New System.Drawing.Point(104, 50)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(40, 38)
        Me.BtnGuardar.TabIndex = 53
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
        Me.BtnModificar.Location = New System.Drawing.Point(58, 50)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(40, 38)
        Me.BtnModificar.TabIndex = 52
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
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 50)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(40, 38)
        Me.BtnNuevo.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Departamentos"
        '
        'TbCons
        '
        Me.TbCons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCons.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCons.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCons.Enabled = False
        Me.TbCons.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbCons.ForeColor = System.Drawing.Color.Maroon
        Me.TbCons.HintForeColor = System.Drawing.Color.Empty
        Me.TbCons.HintText = ""
        Me.TbCons.isPassword = False
        Me.TbCons.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCons.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCons.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCons.LineThickness = 3
        Me.TbCons.Location = New System.Drawing.Point(16, 130)
        Me.TbCons.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCons.MaxLength = 32767
        Me.TbCons.Name = "TbCons"
        Me.TbCons.Size = New System.Drawing.Size(67, 31)
        Me.TbCons.TabIndex = 56
        Me.TbCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbCodigo
        '
        Me.TbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCodigo.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbCodigo.ForeColor = System.Drawing.Color.Maroon
        Me.TbCodigo.HintForeColor = System.Drawing.Color.Empty
        Me.TbCodigo.HintText = ""
        Me.TbCodigo.isPassword = False
        Me.TbCodigo.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCodigo.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCodigo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCodigo.LineThickness = 3
        Me.TbCodigo.Location = New System.Drawing.Point(91, 130)
        Me.TbCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCodigo.MaxLength = 32767
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.Size = New System.Drawing.Size(75, 31)
        Me.TbCodigo.TabIndex = 57
        Me.TbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbDep
        '
        Me.TbDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDep.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDep.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbDep.ForeColor = System.Drawing.Color.Maroon
        Me.TbDep.HintForeColor = System.Drawing.Color.Empty
        Me.TbDep.HintText = ""
        Me.TbDep.isPassword = False
        Me.TbDep.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDep.LineIdleColor = System.Drawing.Color.Gray
        Me.TbDep.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDep.LineThickness = 3
        Me.TbDep.Location = New System.Drawing.Point(174, 130)
        Me.TbDep.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDep.MaxLength = 32767
        Me.TbDep.Name = "TbDep"
        Me.TbDep.Size = New System.Drawing.Size(303, 31)
        Me.TbDep.TabIndex = 58
        Me.TbDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Estado"
        '
        'CbEstado
        '
        Me.CbEstado.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstado.ForeColor = System.Drawing.Color.Maroon
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.CbEstado.Location = New System.Drawing.Point(487, 137)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(116, 24)
        Me.CbEstado.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Código"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Cons"
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
        Me.Dgv.Location = New System.Drawing.Point(12, 181)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(591, 174)
        Me.Dgv.TabIndex = 64
        '
        'FrmDep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.TbDep)
        Me.Controls.Add(Me.TbCodigo)
        Me.Controls.Add(Me.TbCons)
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
        Me.Name = "FrmDep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TbCons As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbCodigo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbDep As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Dgv As DataGridView
End Class
