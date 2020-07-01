<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TbDoc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbClave = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnCancelar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbFunc = New System.Windows.Forms.Label()
        Me.LbCargo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbSede = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbEstado = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbDoc
        '
        Me.TbDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDoc.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDoc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TbDoc.ForeColor = System.Drawing.Color.SteelBlue
        Me.TbDoc.HintForeColor = System.Drawing.Color.Empty
        Me.TbDoc.HintText = ""
        Me.TbDoc.isPassword = False
        Me.TbDoc.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDoc.LineIdleColor = System.Drawing.Color.SteelBlue
        Me.TbDoc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDoc.LineThickness = 4
        Me.TbDoc.Location = New System.Drawing.Point(122, 71)
        Me.TbDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDoc.MaxLength = 32767
        Me.TbDoc.Name = "TbDoc"
        Me.TbDoc.Size = New System.Drawing.Size(200, 31)
        Me.TbDoc.TabIndex = 1
        Me.TbDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbClave
        '
        Me.TbClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbClave.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbClave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbClave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TbClave.ForeColor = System.Drawing.Color.SteelBlue
        Me.TbClave.HintForeColor = System.Drawing.Color.Empty
        Me.TbClave.HintText = ""
        Me.TbClave.isPassword = True
        Me.TbClave.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbClave.LineIdleColor = System.Drawing.Color.SteelBlue
        Me.TbClave.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbClave.LineThickness = 4
        Me.TbClave.Location = New System.Drawing.Point(122, 120)
        Me.TbClave.Margin = New System.Windows.Forms.Padding(4)
        Me.TbClave.MaxLength = 32767
        Me.TbClave.Name = "TbClave"
        Me.TbClave.Size = New System.Drawing.Size(200, 31)
        Me.TbClave.TabIndex = 2
        Me.TbClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INICIAR SESION"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ActiveBorderThickness = 1
        Me.BtnAceptar.ActiveCornerRadius = 20
        Me.BtnAceptar.ActiveFillColor = System.Drawing.Color.LightSteelBlue
        Me.BtnAceptar.ActiveForecolor = System.Drawing.Color.White
        Me.BtnAceptar.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.BtnAceptar.BackColor = System.Drawing.Color.White
        Me.BtnAceptar.BackgroundImage = CType(resources.GetObject("BtnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAceptar.ButtonText = "Aceptar"
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.SteelBlue
        Me.BtnAceptar.IdleBorderThickness = 1
        Me.BtnAceptar.IdleCornerRadius = 1
        Me.BtnAceptar.IdleFillColor = System.Drawing.Color.White
        Me.BtnAceptar.IdleForecolor = System.Drawing.Color.SteelBlue
        Me.BtnAceptar.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.BtnAceptar.Location = New System.Drawing.Point(122, 173)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(89, 41)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.TabStop = False
        Me.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ActiveBorderThickness = 1
        Me.BtnCancelar.ActiveCornerRadius = 20
        Me.BtnCancelar.ActiveFillColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCancelar.ActiveForecolor = System.Drawing.Color.White
        Me.BtnCancelar.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.ButtonText = "Cancelar"
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.SteelBlue
        Me.BtnCancelar.IdleBorderThickness = 1
        Me.BtnCancelar.IdleCornerRadius = 1
        Me.BtnCancelar.IdleFillColor = System.Drawing.Color.White
        Me.BtnCancelar.IdleForecolor = System.Drawing.Color.SteelBlue
        Me.BtnCancelar.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.BtnCancelar.Location = New System.Drawing.Point(233, 173)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(89, 41)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.TabStop = False
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(785, 235)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 380
        Me.LineShape1.X2 = 380
        Me.LineShape1.Y1 = 5
        Me.LineShape1.Y2 = 226
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(402, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(713, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(399, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Funcionario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(399, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cargo:"
        '
        'LbFunc
        '
        Me.LbFunc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFunc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LbFunc.Location = New System.Drawing.Point(501, 106)
        Me.LbFunc.Name = "LbFunc"
        Me.LbFunc.Size = New System.Drawing.Size(272, 16)
        Me.LbFunc.TabIndex = 12
        Me.LbFunc.Text = "LbFunc"
        '
        'LbCargo
        '
        Me.LbCargo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LbCargo.Location = New System.Drawing.Point(501, 135)
        Me.LbCargo.Name = "LbCargo"
        Me.LbCargo.Size = New System.Drawing.Size(272, 16)
        Me.LbCargo.TabIndex = 13
        Me.LbCargo.Text = "LbCargo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(399, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sede:"
        '
        'LbSede
        '
        Me.LbSede.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSede.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LbSede.Location = New System.Drawing.Point(501, 162)
        Me.LbSede.Name = "LbSede"
        Me.LbSede.Size = New System.Drawing.Size(272, 27)
        Me.LbSede.TabIndex = 15
        Me.LbSede.Text = "LbSede"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(399, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Estado:"
        '
        'LbEstado
        '
        Me.LbEstado.AutoSize = True
        Me.LbEstado.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LbEstado.Location = New System.Drawing.Point(501, 198)
        Me.LbEstado.Name = "LbEstado"
        Me.LbEstado.Size = New System.Drawing.Size(73, 16)
        Me.LbEstado.TabIndex = 17
        Me.LbEstado.Text = "LbEstado"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.LbEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbSede)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LbCargo)
        Me.Controls.Add(Me.LbFunc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbClave)
        Me.Controls.Add(Me.TbDoc)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbDoc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbClave As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAceptar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnCancelar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LbFunc As Label
    Friend WithEvents LbCargo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LbSede As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LbEstado As Label
End Class
