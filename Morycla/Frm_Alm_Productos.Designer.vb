<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Alm_Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Alm_Productos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnForma = New System.Windows.Forms.Button()
        Me.BtnTipoMed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbCons = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbATC = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbDescrip = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbPresent = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbConcent = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CbForma = New System.Windows.Forms.ComboBox()
        Me.TbUnidad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbTemp = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbMinimo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TbRiesgo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.CbTipoMed = New System.Windows.Forms.ComboBox()
        Me.CbTProd = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.CbCostos = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(977, 2)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(200, 52)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(154, 52)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(108, 52)
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
        Me.BtnModificar.Location = New System.Drawing.Point(62, 52)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(16, 52)
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
        Me.Button2.Location = New System.Drawing.Point(263, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 38)
        Me.Button2.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.Button2, "Buscar Producto")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnForma
        '
        Me.BtnForma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnForma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnForma.Location = New System.Drawing.Point(455, 367)
        Me.BtnForma.Name = "BtnForma"
        Me.BtnForma.Size = New System.Drawing.Size(40, 23)
        Me.BtnForma.TabIndex = 57
        Me.BtnForma.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnForma, "Ir a Formas Farmaceuticas")
        Me.BtnForma.UseVisualStyleBackColor = True
        '
        'BtnTipoMed
        '
        Me.BtnTipoMed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTipoMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoMed.Location = New System.Drawing.Point(952, 210)
        Me.BtnTipoMed.Name = "BtnTipoMed"
        Me.BtnTipoMed.Size = New System.Drawing.Size(40, 23)
        Me.BtnTipoMed.TabIndex = 58
        Me.BtnTipoMed.Text = "..."
        Me.ToolTip1.SetToolTip(Me.BtnTipoMed, "Ir a Formas Farmaceuticas")
        Me.BtnTipoMed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productos"
        '
        'TbCons
        '
        Me.TbCons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbCons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbCons.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbCons.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCons.Enabled = False
        Me.TbCons.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCons.ForeColor = System.Drawing.Color.Maroon
        Me.TbCons.HintForeColor = System.Drawing.Color.Empty
        Me.TbCons.HintText = ""
        Me.TbCons.isPassword = False
        Me.TbCons.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbCons.LineIdleColor = System.Drawing.Color.Gray
        Me.TbCons.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbCons.LineThickness = 3
        Me.TbCons.Location = New System.Drawing.Point(620, 59)
        Me.TbCons.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCons.MaxLength = 32767
        Me.TbCons.Name = "TbCons"
        Me.TbCons.Size = New System.Drawing.Size(375, 31)
        Me.TbCons.TabIndex = 28
        Me.TbCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbATC
        '
        Me.TbATC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbATC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbATC.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbATC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbATC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbATC.ForeColor = System.Drawing.Color.Maroon
        Me.TbATC.HintForeColor = System.Drawing.Color.Empty
        Me.TbATC.HintText = ""
        Me.TbATC.isPassword = False
        Me.TbATC.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbATC.LineIdleColor = System.Drawing.Color.Gray
        Me.TbATC.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbATC.LineThickness = 3
        Me.TbATC.Location = New System.Drawing.Point(120, 174)
        Me.TbATC.Margin = New System.Windows.Forms.Padding(4)
        Me.TbATC.MaxLength = 32767
        Me.TbATC.Name = "TbATC"
        Me.TbATC.Size = New System.Drawing.Size(375, 31)
        Me.TbATC.TabIndex = 1
        Me.TbATC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbDescrip
        '
        Me.TbDescrip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbDescrip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbDescrip.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbDescrip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDescrip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescrip.ForeColor = System.Drawing.Color.Maroon
        Me.TbDescrip.HintForeColor = System.Drawing.Color.Empty
        Me.TbDescrip.HintText = ""
        Me.TbDescrip.isPassword = False
        Me.TbDescrip.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbDescrip.LineIdleColor = System.Drawing.Color.Gray
        Me.TbDescrip.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbDescrip.LineThickness = 3
        Me.TbDescrip.Location = New System.Drawing.Point(120, 213)
        Me.TbDescrip.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDescrip.MaxLength = 32767
        Me.TbDescrip.Name = "TbDescrip"
        Me.TbDescrip.Size = New System.Drawing.Size(375, 31)
        Me.TbDescrip.TabIndex = 2
        Me.TbDescrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbPresent
        '
        Me.TbPresent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbPresent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbPresent.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbPresent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPresent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPresent.ForeColor = System.Drawing.Color.Maroon
        Me.TbPresent.HintForeColor = System.Drawing.Color.Empty
        Me.TbPresent.HintText = ""
        Me.TbPresent.isPassword = False
        Me.TbPresent.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbPresent.LineIdleColor = System.Drawing.Color.Gray
        Me.TbPresent.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbPresent.LineThickness = 3
        Me.TbPresent.Location = New System.Drawing.Point(118, 299)
        Me.TbPresent.Margin = New System.Windows.Forms.Padding(4)
        Me.TbPresent.MaxLength = 32767
        Me.TbPresent.Name = "TbPresent"
        Me.TbPresent.Size = New System.Drawing.Size(375, 31)
        Me.TbPresent.TabIndex = 3
        Me.TbPresent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbConcent
        '
        Me.TbConcent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbConcent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbConcent.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbConcent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbConcent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbConcent.ForeColor = System.Drawing.Color.Maroon
        Me.TbConcent.HintForeColor = System.Drawing.Color.Empty
        Me.TbConcent.HintText = ""
        Me.TbConcent.isPassword = False
        Me.TbConcent.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbConcent.LineIdleColor = System.Drawing.Color.Gray
        Me.TbConcent.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbConcent.LineThickness = 3
        Me.TbConcent.Location = New System.Drawing.Point(120, 260)
        Me.TbConcent.Margin = New System.Windows.Forms.Padding(4)
        Me.TbConcent.MaxLength = 32767
        Me.TbConcent.Name = "TbConcent"
        Me.TbConcent.Size = New System.Drawing.Size(375, 31)
        Me.TbConcent.TabIndex = 4
        Me.TbConcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CbForma
        '
        Me.CbForma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbForma.ForeColor = System.Drawing.Color.Maroon
        Me.CbForma.FormattingEnabled = True
        Me.CbForma.Location = New System.Drawing.Point(118, 367)
        Me.CbForma.Name = "CbForma"
        Me.CbForma.Size = New System.Drawing.Size(330, 24)
        Me.CbForma.TabIndex = 5
        '
        'TbUnidad
        '
        Me.TbUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbUnidad.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbUnidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbUnidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUnidad.ForeColor = System.Drawing.Color.Maroon
        Me.TbUnidad.HintForeColor = System.Drawing.Color.Empty
        Me.TbUnidad.HintText = ""
        Me.TbUnidad.isPassword = False
        Me.TbUnidad.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbUnidad.LineIdleColor = System.Drawing.Color.Gray
        Me.TbUnidad.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbUnidad.LineThickness = 3
        Me.TbUnidad.Location = New System.Drawing.Point(120, 418)
        Me.TbUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TbUnidad.MaxLength = 32767
        Me.TbUnidad.Name = "TbUnidad"
        Me.TbUnidad.Size = New System.Drawing.Size(375, 31)
        Me.TbUnidad.TabIndex = 6
        Me.TbUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbTemp
        '
        Me.TbTemp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbTemp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbTemp.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbTemp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTemp.ForeColor = System.Drawing.Color.Maroon
        Me.TbTemp.HintForeColor = System.Drawing.Color.Empty
        Me.TbTemp.HintText = ""
        Me.TbTemp.isPassword = False
        Me.TbTemp.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbTemp.LineIdleColor = System.Drawing.Color.Gray
        Me.TbTemp.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbTemp.LineThickness = 3
        Me.TbTemp.Location = New System.Drawing.Point(120, 457)
        Me.TbTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.TbTemp.MaxLength = 32767
        Me.TbTemp.Name = "TbTemp"
        Me.TbTemp.Size = New System.Drawing.Size(375, 31)
        Me.TbTemp.TabIndex = 7
        Me.TbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbMinimo
        '
        Me.TbMinimo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbMinimo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbMinimo.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbMinimo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbMinimo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMinimo.ForeColor = System.Drawing.Color.Maroon
        Me.TbMinimo.HintForeColor = System.Drawing.Color.Empty
        Me.TbMinimo.HintText = ""
        Me.TbMinimo.isPassword = False
        Me.TbMinimo.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbMinimo.LineIdleColor = System.Drawing.Color.Gray
        Me.TbMinimo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbMinimo.LineThickness = 3
        Me.TbMinimo.Location = New System.Drawing.Point(620, 106)
        Me.TbMinimo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbMinimo.MaxLength = 32767
        Me.TbMinimo.Name = "TbMinimo"
        Me.TbMinimo.Size = New System.Drawing.Size(375, 31)
        Me.TbMinimo.TabIndex = 8
        Me.TbMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TbRiesgo
        '
        Me.TbRiesgo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TbRiesgo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TbRiesgo.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TbRiesgo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbRiesgo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbRiesgo.ForeColor = System.Drawing.Color.Maroon
        Me.TbRiesgo.HintForeColor = System.Drawing.Color.Empty
        Me.TbRiesgo.HintText = ""
        Me.TbRiesgo.isPassword = False
        Me.TbRiesgo.LineFocusedColor = System.Drawing.Color.Blue
        Me.TbRiesgo.LineIdleColor = System.Drawing.Color.Gray
        Me.TbRiesgo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.TbRiesgo.LineThickness = 3
        Me.TbRiesgo.Location = New System.Drawing.Point(620, 154)
        Me.TbRiesgo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbRiesgo.MaxLength = 32767
        Me.TbRiesgo.Name = "TbRiesgo"
        Me.TbRiesgo.Size = New System.Drawing.Size(375, 31)
        Me.TbRiesgo.TabIndex = 9
        Me.TbRiesgo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cons"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "ATC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Presentación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Concentración"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 40)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Forma Farmacéutica"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 433)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Unidad Medida"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Temperatura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(554, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Minimo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(554, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Riesgo"
        '
        'CbTipoMed
        '
        Me.CbTipoMed.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoMed.ForeColor = System.Drawing.Color.Maroon
        Me.CbTipoMed.FormattingEnabled = True
        Me.CbTipoMed.Location = New System.Drawing.Point(621, 210)
        Me.CbTipoMed.Name = "CbTipoMed"
        Me.CbTipoMed.Size = New System.Drawing.Size(325, 24)
        Me.CbTipoMed.TabIndex = 10
        '
        'CbTProd
        '
        Me.CbTProd.BackColor = System.Drawing.Color.SteelBlue
        Me.CbTProd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTProd.ForeColor = System.Drawing.Color.White
        Me.CbTProd.FormattingEnabled = True
        Me.CbTProd.Location = New System.Drawing.Point(120, 113)
        Me.CbTProd.Name = "CbTProd"
        Me.CbTProd.Size = New System.Drawing.Size(376, 24)
        Me.CbTProd.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 16)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Tipo Producto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(554, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Tipo Med"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(554, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Estado"
        '
        'CbEstado
        '
        Me.CbEstado.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstado.ForeColor = System.Drawing.Color.Maroon
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.CbEstado.Location = New System.Drawing.Point(621, 252)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(374, 24)
        Me.CbEstado.TabIndex = 11
        '
        'Dgv
        '
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.EnableHeadersVisualStyles = False
        Me.Dgv.Location = New System.Drawing.Point(557, 330)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.RowHeadersVisible = False
        Me.Dgv.Size = New System.Drawing.Size(439, 159)
        Me.Dgv.TabIndex = 55
        '
        'CbCostos
        '
        Me.CbCostos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCostos.ForeColor = System.Drawing.Color.Maroon
        Me.CbCostos.FormattingEnabled = True
        Me.CbCostos.Location = New System.Drawing.Point(622, 299)
        Me.CbCostos.Name = "CbCostos"
        Me.CbCostos.Size = New System.Drawing.Size(374, 24)
        Me.CbCostos.TabIndex = 59
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(554, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 16)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Costo"
        '
        'Frm_Alm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CbCostos)
        Me.Controls.Add(Me.BtnTipoMed)
        Me.Controls.Add(Me.BtnForma)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CbTProd)
        Me.Controls.Add(Me.CbTipoMed)
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
        Me.Controls.Add(Me.TbRiesgo)
        Me.Controls.Add(Me.TbMinimo)
        Me.Controls.Add(Me.TbTemp)
        Me.Controls.Add(Me.TbUnidad)
        Me.Controls.Add(Me.CbForma)
        Me.Controls.Add(Me.TbConcent)
        Me.Controls.Add(Me.TbPresent)
        Me.Controls.Add(Me.TbDescrip)
        Me.Controls.Add(Me.TbATC)
        Me.Controls.Add(Me.TbCons)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Alm_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TbCons As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbATC As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbDescrip As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbPresent As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbConcent As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CbForma As ComboBox
    Friend WithEvents TbUnidad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbTemp As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbMinimo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TbRiesgo As Bunifu.Framework.UI.BunifuMaterialTextbox
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
    Friend WithEvents CbTipoMed As ComboBox
    Friend WithEvents CbTProd As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnForma As Button
    Friend WithEvents BtnTipoMed As Button
    Friend WithEvents CbCostos As ComboBox
    Friend WithEvents Label15 As Label
End Class
