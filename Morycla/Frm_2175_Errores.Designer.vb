<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_2175_Errores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_2175_Errores))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.Lb4 = New System.Windows.Forms.Label()
        Me.Lb5 = New System.Windows.Forms.Label()
        Me.Lb6 = New System.Windows.Forms.Label()
        Me.Lb7 = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Informe de Validación Resolción 2175"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(930, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(29, 29)
        Me.BtnCerrar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar")
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnExportar)
        Me.Panel1.Controls.Add(Me.BtnPrint)
        Me.Panel1.Controls.Add(Me.LbTotal)
        Me.Panel1.Controls.Add(Me.Lb7)
        Me.Panel1.Controls.Add(Me.Lb6)
        Me.Panel1.Controls.Add(Me.Lb5)
        Me.Panel1.Controls.Add(Me.Lb4)
        Me.Panel1.Controls.Add(Me.Lb3)
        Me.Panel1.Controls.Add(Me.Lb2)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 143)
        Me.Panel1.TabIndex = 6
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(20, 14)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(155, 16)
        Me.Lb2.TabIndex = 0
        Me.Lb2.Text = "Errores Registro Tipo 2"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(20, 47)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(155, 16)
        Me.Lb3.TabIndex = 1
        Me.Lb3.Text = "Errores Registro Tipo 3"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.Location = New System.Drawing.Point(20, 80)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(155, 16)
        Me.Lb4.TabIndex = 2
        Me.Lb4.Text = "Errores Registro Tipo 4"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.Location = New System.Drawing.Point(20, 112)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(155, 16)
        Me.Lb5.TabIndex = 3
        Me.Lb5.Text = "Errores Registro Tipo 5"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.Location = New System.Drawing.Point(403, 14)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(155, 16)
        Me.Lb6.TabIndex = 4
        Me.Lb6.Text = "Errores Registro Tipo 6"
        '
        'Lb7
        '
        Me.Lb7.AutoSize = True
        Me.Lb7.Location = New System.Drawing.Point(403, 47)
        Me.Lb7.Name = "Lb7"
        Me.Lb7.Size = New System.Drawing.Size(155, 16)
        Me.Lb7.TabIndex = 5
        Me.Lb7.Text = "Errores Registro Tipo 7"
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Location = New System.Drawing.Point(403, 79)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(128, 16)
        Me.LbTotal.TabIndex = 6
        Me.LbTotal.Text = "TOTAL ERRORES:"
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(895, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(47, 30)
        Me.BtnPrint.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BtnPrint, "Imprimir resporte de errores")
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(12, 204)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(947, 300)
        Me.Dgv.TabIndex = 7
        '
        'BtnExportar
        '
        Me.BtnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.FlatAppearance.BorderSize = 0
        Me.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportar.Image = CType(resources.GetObject("BtnExportar.Image"), System.Drawing.Image)
        Me.BtnExportar.Location = New System.Drawing.Point(842, 0)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(47, 30)
        Me.BtnExportar.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BtnExportar, "Exportar resporte de errores")
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'Frm_2175_Errores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_2175_Errores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbTotal As Label
    Friend WithEvents Lb7 As Label
    Friend WithEvents Lb6 As Label
    Friend WithEvents Lb5 As Label
    Friend WithEvents Lb4 As Label
    Friend WithEvents Lb3 As Label
    Friend WithEvents Lb2 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents BtnExportar As Button
End Class
