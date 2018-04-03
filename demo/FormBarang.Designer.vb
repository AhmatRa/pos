<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.edit = New System.Windows.Forms.Button()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbstok = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CARI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 49)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(362, 385)
        Me.dgv1.TabIndex = 2
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(452, 206)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(138, 38)
        Me.edit.TabIndex = 3
        Me.edit.Text = "UBAH STOK"
        Me.edit.UseVisualStyleBackColor = True
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(452, 87)
        Me.tbid.Name = "tbid"
        Me.tbid.ReadOnly = True
        Me.tbid.Size = New System.Drawing.Size(139, 20)
        Me.tbid.TabIndex = 4
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(452, 113)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.ReadOnly = True
        Me.tbnama.Size = New System.Drawing.Size(205, 20)
        Me.tbnama.TabIndex = 5
        '
        'tbstok
        '
        Me.tbstok.Location = New System.Drawing.Point(452, 170)
        Me.tbstok.Name = "tbstok"
        Me.tbstok.ReadOnly = True
        Me.tbstok.Size = New System.Drawing.Size(139, 20)
        Me.tbstok.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 7)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 31)
        Me.TextBox1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(452, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 31)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "REFRESH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClientSize = New System.Drawing.Size(904, 517)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tbstok)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbstok As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
