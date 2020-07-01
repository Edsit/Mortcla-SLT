<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarPwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambiarPwd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TbActual = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TbNueva = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TbConformar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCambiar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.LbPwd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cambiar Contraseña"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(583, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'TbActual
        '
        Me.TbActual.BorderColorFocused = System.Drawing.Color.Blue
        Me.TbActual.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbActual.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TbActual.BorderThickness = 3
        Me.TbActual.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbActual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbActual.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbActual.isPassword = True
        Me.TbActual.Location = New System.Drawing.Point(168, 78)
        Me.TbActual.Margin = New System.Windows.Forms.Padding(4)
        Me.TbActual.MaxLength = 32767
        Me.TbActual.Name = "TbActual"
        Me.TbActual.Size = New System.Drawing.Size(238, 44)
        Me.TbActual.TabIndex = 5
        Me.TbActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbNueva
        '
        Me.TbNueva.BorderColorFocused = System.Drawing.Color.Blue
        Me.TbNueva.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbNueva.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TbNueva.BorderThickness = 3
        Me.TbNueva.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbNueva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNueva.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbNueva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbNueva.isPassword = True
        Me.TbNueva.Location = New System.Drawing.Point(168, 130)
        Me.TbNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNueva.MaxLength = 32767
        Me.TbNueva.Name = "TbNueva"
        Me.TbNueva.Size = New System.Drawing.Size(238, 44)
        Me.TbNueva.TabIndex = 6
        Me.TbNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbConformar
        '
        Me.TbConformar.BorderColorFocused = System.Drawing.Color.Blue
        Me.TbConformar.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbConformar.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.TbConformar.BorderThickness = 3
        Me.TbConformar.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbConformar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbConformar.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TbConformar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbConformar.isPassword = True
        Me.TbConformar.Location = New System.Drawing.Point(168, 182)
        Me.TbConformar.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConformar.MaxLength = 32767
        Me.TbConformar.Name = "TbConformar"
        Me.TbConformar.Size = New System.Drawing.Size(238, 44)
        Me.TbConformar.TabIndex = 7
        Me.TbConformar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contraseña Actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Contraseña Nueva"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Confirmar Contraseña"
        '
        'BtnCambiar
        '
        Me.BtnCambiar.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnCambiar.color = System.Drawing.Color.SeaGreen
        Me.BtnCambiar.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BtnCambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCambiar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnCambiar.ForeColor = System.Drawing.Color.White
        Me.BtnCambiar.Image = CType(resources.GetObject("BtnCambiar.Image"), System.Drawing.Image)
        Me.BtnCambiar.ImagePosition = 20
        Me.BtnCambiar.ImageZoom = 50
        Me.BtnCambiar.LabelPosition = 41
        Me.BtnCambiar.LabelText = "Cambiar"
        Me.BtnCambiar.Location = New System.Drawing.Point(427, 78)
        Me.BtnCambiar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(128, 148)
        Me.BtnCambiar.TabIndex = 11
        '
        'LbPwd
        '
        Me.LbPwd.AutoSize = True
        Me.LbPwd.Location = New System.Drawing.Point(295, 34)
        Me.LbPwd.Name = "LbPwd"
        Me.LbPwd.Size = New System.Drawing.Size(50, 16)
        Me.LbPwd.TabIndex = 12
        Me.LbPwd.Text = "LbPwd"
        Me.LbPwd.Visible = False
        '
        'FrmCambiarPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbPwd)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbConformar)
        Me.Controls.Add(Me.TbNueva)
        Me.Controls.Add(Me.TbActual)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmCambiarPwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TbActual As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TbNueva As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TbConformar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCambiar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents LbPwd As Label
End Class
