<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_R2175
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_R2175))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnLeerArchivo = New System.Windows.Forms.Button()
        Me.DgvT2 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvT3 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvT4 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvT5 = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DgvT6 = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DgvT7 = New System.Windows.Forms.DataGridView()
        Me.Tb2 = New System.Windows.Forms.TextBox()
        Me.Tb3 = New System.Windows.Forms.TextBox()
        Me.Tb4 = New System.Windows.Forms.TextBox()
        Me.Tb5 = New System.Windows.Forms.TextBox()
        Me.Tb6 = New System.Windows.Forms.TextBox()
        Me.Tb7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbSede = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.ProgressBar2 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSubir = New System.Windows.Forms.Button()
        Me.BtnPlano = New System.Windows.Forms.Button()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DgvT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvT3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvT4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvT5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DgvT6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DgvT7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Validador Resolución 2175"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(962, -2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnLeerArchivo
        '
        Me.BtnLeerArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLeerArchivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLeerArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnLeerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLeerArchivo.Location = New System.Drawing.Point(545, 80)
        Me.BtnLeerArchivo.Name = "BtnLeerArchivo"
        Me.BtnLeerArchivo.Size = New System.Drawing.Size(102, 23)
        Me.BtnLeerArchivo.TabIndex = 5
        Me.BtnLeerArchivo.Text = "Leer Archivo"
        Me.BtnLeerArchivo.UseVisualStyleBackColor = True
        '
        'DgvT2
        '
        Me.DgvT2.AllowUserToAddRows = False
        Me.DgvT2.AllowUserToDeleteRows = False
        Me.DgvT2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvT2.EnableHeadersVisualStyles = False
        Me.DgvT2.Location = New System.Drawing.Point(6, 6)
        Me.DgvT2.Name = "DgvT2"
        Me.DgvT2.RowHeadersVisible = False
        Me.DgvT2.Size = New System.Drawing.Size(945, 282)
        Me.DgvT2.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(16, 131)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(965, 326)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvT2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(957, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tipo 2"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvT3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(957, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tipo 3"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvT3
        '
        Me.DgvT3.AllowUserToAddRows = False
        Me.DgvT3.AllowUserToDeleteRows = False
        Me.DgvT3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvT3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvT3.EnableHeadersVisualStyles = False
        Me.DgvT3.Location = New System.Drawing.Point(6, 6)
        Me.DgvT3.Name = "DgvT3"
        Me.DgvT3.RowHeadersVisible = False
        Me.DgvT3.Size = New System.Drawing.Size(945, 286)
        Me.DgvT3.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvT4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(957, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tipo 4"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvT4
        '
        Me.DgvT4.AllowUserToAddRows = False
        Me.DgvT4.AllowUserToDeleteRows = False
        Me.DgvT4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvT4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvT4.EnableHeadersVisualStyles = False
        Me.DgvT4.Location = New System.Drawing.Point(6, 6)
        Me.DgvT4.Name = "DgvT4"
        Me.DgvT4.RowHeadersVisible = False
        Me.DgvT4.Size = New System.Drawing.Size(945, 286)
        Me.DgvT4.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvT5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(957, 294)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tipo 5"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvT5
        '
        Me.DgvT5.AllowUserToAddRows = False
        Me.DgvT5.AllowUserToDeleteRows = False
        Me.DgvT5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvT5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvT5.EnableHeadersVisualStyles = False
        Me.DgvT5.Location = New System.Drawing.Point(6, 6)
        Me.DgvT5.Name = "DgvT5"
        Me.DgvT5.RowHeadersVisible = False
        Me.DgvT5.Size = New System.Drawing.Size(945, 286)
        Me.DgvT5.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DgvT6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 28)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(957, 294)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Tipo 6"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DgvT6
        '
        Me.DgvT6.AllowUserToAddRows = False
        Me.DgvT6.AllowUserToDeleteRows = False
        Me.DgvT6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvT6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvT6.EnableHeadersVisualStyles = False
        Me.DgvT6.Location = New System.Drawing.Point(6, 6)
        Me.DgvT6.Name = "DgvT6"
        Me.DgvT6.RowHeadersVisible = False
        Me.DgvT6.Size = New System.Drawing.Size(945, 286)
        Me.DgvT6.TabIndex = 7
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DgvT7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 28)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(957, 294)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Tipo 7"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DgvT7
        '
        Me.DgvT7.AllowUserToAddRows = False
        Me.DgvT7.AllowUserToDeleteRows = False
        Me.DgvT7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvT7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvT7.Location = New System.Drawing.Point(6, 6)
        Me.DgvT7.Name = "DgvT7"
        Me.DgvT7.Size = New System.Drawing.Size(945, 286)
        Me.DgvT7.TabIndex = 7
        '
        'Tb2
        '
        Me.Tb2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb2.ForeColor = System.Drawing.Color.Blue
        Me.Tb2.Location = New System.Drawing.Point(593, 56)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(58, 22)
        Me.Tb2.TabIndex = 9
        Me.Tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb3
        '
        Me.Tb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb3.ForeColor = System.Drawing.Color.Blue
        Me.Tb3.Location = New System.Drawing.Point(657, 56)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.Size = New System.Drawing.Size(58, 22)
        Me.Tb3.TabIndex = 10
        Me.Tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb4
        '
        Me.Tb4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb4.ForeColor = System.Drawing.Color.Blue
        Me.Tb4.Location = New System.Drawing.Point(721, 56)
        Me.Tb4.Name = "Tb4"
        Me.Tb4.Size = New System.Drawing.Size(58, 22)
        Me.Tb4.TabIndex = 11
        Me.Tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb5
        '
        Me.Tb5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb5.ForeColor = System.Drawing.Color.Blue
        Me.Tb5.Location = New System.Drawing.Point(785, 56)
        Me.Tb5.Name = "Tb5"
        Me.Tb5.Size = New System.Drawing.Size(58, 22)
        Me.Tb5.TabIndex = 12
        Me.Tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb6
        '
        Me.Tb6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb6.ForeColor = System.Drawing.Color.Blue
        Me.Tb6.Location = New System.Drawing.Point(849, 56)
        Me.Tb6.Name = "Tb6"
        Me.Tb6.Size = New System.Drawing.Size(58, 22)
        Me.Tb6.TabIndex = 13
        Me.Tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb7
        '
        Me.Tb7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb7.ForeColor = System.Drawing.Color.Blue
        Me.Tb7.Location = New System.Drawing.Point(913, 56)
        Me.Tb7.Name = "Tb7"
        Me.Tb7.Size = New System.Drawing.Size(58, 22)
        Me.Tb7.TabIndex = 14
        Me.Tb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tipo 2"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(657, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tipo 3"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(721, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tipo 4"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(785, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tipo 5"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(849, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tipo 6"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(913, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tipo 7"
        '
        'DtDesde
        '
        Me.DtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtDesde.Location = New System.Drawing.Point(20, 59)
        Me.DtDesde.Name = "DtDesde"
        Me.DtDesde.Size = New System.Drawing.Size(105, 22)
        Me.DtDesde.TabIndex = 21
        '
        'DtHasta
        '
        Me.DtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtHasta.Location = New System.Drawing.Point(131, 59)
        Me.DtHasta.Name = "DtHasta"
        Me.DtHasta.Size = New System.Drawing.Size(105, 22)
        Me.DtHasta.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Desde"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Hasta"
        '
        'CbSede
        '
        Me.CbSede.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbSede.ForeColor = System.Drawing.Color.Blue
        Me.CbSede.FormattingEnabled = True
        Me.CbSede.Location = New System.Drawing.Point(249, 56)
        Me.CbSede.Name = "CbSede"
        Me.CbSede.Size = New System.Drawing.Size(338, 24)
        Me.CbSede.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Sede"
        '
        'BtnValidar
        '
        Me.BtnValidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnValidar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValidar.Location = New System.Drawing.Point(653, 80)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(102, 23)
        Me.BtnValidar.TabIndex = 27
        Me.BtnValidar.Text = "Validar"
        Me.BtnValidar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(20, 104)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(195, 20)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Ancho Automatico Columnas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ProgressBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBar1.ChunkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgressBar1.ChunkColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgressBar1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar1.Location = New System.Drawing.Point(26, 459)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(227, 23)
        Me.ProgressBar1.TabIndex = 29
        Me.ProgressBar1.Text = "ProgressBarX1"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ProgressBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBar2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar2.Location = New System.Drawing.Point(259, 459)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(718, 23)
        Me.ProgressBar2.TabIndex = 30
        Me.ProgressBar2.Text = "ProgressBarX2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'BtnSubir
        '
        Me.BtnSubir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubir.Location = New System.Drawing.Point(761, 80)
        Me.BtnSubir.Name = "BtnSubir"
        Me.BtnSubir.Size = New System.Drawing.Size(102, 23)
        Me.BtnSubir.TabIndex = 31
        Me.BtnSubir.Text = "Subir"
        Me.BtnSubir.UseVisualStyleBackColor = True
        '
        'BtnPlano
        '
        Me.BtnPlano.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPlano.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlano.Location = New System.Drawing.Point(869, 80)
        Me.BtnPlano.Name = "BtnPlano"
        Me.BtnPlano.Size = New System.Drawing.Size(102, 23)
        Me.BtnPlano.TabIndex = 32
        Me.BtnPlano.Text = "Generar Plano"
        Me.BtnPlano.UseVisualStyleBackColor = True
        '
        'LbTotal
        '
        Me.LbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LbTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.Location = New System.Drawing.Point(246, 80)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(293, 23)
        Me.LbTotal.TabIndex = 33
        Me.LbTotal.Text = "LbTotal"
        Me.LbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(615, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(676, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(737, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(794, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(855, 103)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(55, 23)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(916, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(55, 23)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Frm_R2175
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbTotal)
        Me.Controls.Add(Me.BtnPlano)
        Me.Controls.Add(Me.BtnSubir)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnValidar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbSede)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtHasta)
        Me.Controls.Add(Me.DtDesde)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tb7)
        Me.Controls.Add(Me.Tb6)
        Me.Controls.Add(Me.Tb5)
        Me.Controls.Add(Me.Tb4)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnLeerArchivo)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_R2175"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgvT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvT3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvT4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvT5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DgvT6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DgvT7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnLeerArchivo As Button
    Friend WithEvents DgvT2 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DgvT3 As DataGridView
    Friend WithEvents DgvT4 As DataGridView
    Friend WithEvents DgvT5 As DataGridView
    Friend WithEvents DgvT6 As DataGridView
    Friend WithEvents DgvT7 As DataGridView
    Friend WithEvents Tb2 As TextBox
    Friend WithEvents Tb3 As TextBox
    Friend WithEvents Tb4 As TextBox
    Friend WithEvents Tb5 As TextBox
    Friend WithEvents Tb6 As TextBox
    Friend WithEvents Tb7 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DtDesde As DateTimePicker
    Friend WithEvents DtHasta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CbSede As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnValidar As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents ProgressBar2 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnSubir As Button
    Friend WithEvents BtnPlano As Button
    Friend WithEvents LbTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
