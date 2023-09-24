<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CosasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proyecto2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proyecto3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proyecto4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proyecto5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(482, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 31)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Alejandro Rios Flores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "2127910"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Examen Medio Curso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Programacion Visual - N3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CosasToolStripMenuItem, Me.Proyecto2ToolStripMenuItem, Me.Proyecto3ToolStripMenuItem, Me.Proyecto4ToolStripMenuItem, Me.Proyecto5ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CosasToolStripMenuItem
        '
        Me.CosasToolStripMenuItem.Name = "CosasToolStripMenuItem"
        Me.CosasToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CosasToolStripMenuItem.Text = "Proyecto 1"
        '
        'Proyecto2ToolStripMenuItem
        '
        Me.Proyecto2ToolStripMenuItem.Name = "Proyecto2ToolStripMenuItem"
        Me.Proyecto2ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Proyecto2ToolStripMenuItem.Text = "Proyecto2"
        '
        'Proyecto3ToolStripMenuItem
        '
        Me.Proyecto3ToolStripMenuItem.Name = "Proyecto3ToolStripMenuItem"
        Me.Proyecto3ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Proyecto3ToolStripMenuItem.Text = "Proyecto3"
        '
        'Proyecto4ToolStripMenuItem
        '
        Me.Proyecto4ToolStripMenuItem.Name = "Proyecto4ToolStripMenuItem"
        Me.Proyecto4ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Proyecto4ToolStripMenuItem.Text = "Proyecto4"
        '
        'Proyecto5ToolStripMenuItem
        '
        Me.Proyecto5ToolStripMenuItem.Name = "Proyecto5ToolStripMenuItem"
        Me.Proyecto5ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.Proyecto5ToolStripMenuItem.Text = "Proyecto5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CosasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Proyecto2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Proyecto3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Proyecto4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Proyecto5ToolStripMenuItem As ToolStripMenuItem
End Class
