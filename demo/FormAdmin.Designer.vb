<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btUbah = New System.Windows.Forms.Button()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbstok = New System.Windows.Forms.TextBox()
        Me.tbretail = New System.Windows.Forms.TextBox()
        Me.tbgrosir = New System.Windows.Forms.TextBox()
        Me.tbsatuan = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HAAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btUbah)
        Me.Panel1.Controls.Add(Me.btTambah)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbstok)
        Me.Panel1.Controls.Add(Me.tbretail)
        Me.Panel1.Controls.Add(Me.tbgrosir)
        Me.Panel1.Controls.Add(Me.tbsatuan)
        Me.Panel1.Controls.Add(Me.tbnama)
        Me.Panel1.Controls.Add(Me.tbid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 146)
        Me.Panel1.TabIndex = 0
        '
        'btUbah
        '
        Me.btUbah.BackColor = System.Drawing.Color.LawnGreen
        Me.btUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUbah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btUbah.Location = New System.Drawing.Point(668, 51)
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Size = New System.Drawing.Size(132, 29)
        Me.btUbah.TabIndex = 13
        Me.btUbah.Text = "UBAH"
        Me.btUbah.UseVisualStyleBackColor = False
        '
        'btTambah
        '
        Me.btTambah.BackColor = System.Drawing.Color.LawnGreen
        Me.btTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btTambah.Location = New System.Drawing.Point(668, 15)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(132, 29)
        Me.btTambah.TabIndex = 12
        Me.btTambah.Text = "TAMBAH"
        Me.btTambah.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(355, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "STOK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(345, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "H_RETAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(345, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "H_GROSIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(24, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SATUAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID BARANG"
        '
        'tbstok
        '
        Me.tbstok.Location = New System.Drawing.Point(445, 94)
        Me.tbstok.Name = "tbstok"
        Me.tbstok.Size = New System.Drawing.Size(167, 21)
        Me.tbstok.TabIndex = 5
        '
        'tbretail
        '
        Me.tbretail.Location = New System.Drawing.Point(445, 48)
        Me.tbretail.Name = "tbretail"
        Me.tbretail.Size = New System.Drawing.Size(167, 21)
        Me.tbretail.TabIndex = 4
        '
        'tbgrosir
        '
        Me.tbgrosir.Location = New System.Drawing.Point(445, 12)
        Me.tbgrosir.Name = "tbgrosir"
        Me.tbgrosir.Size = New System.Drawing.Size(167, 21)
        Me.tbgrosir.TabIndex = 3
        '
        'tbsatuan
        '
        Me.tbsatuan.Location = New System.Drawing.Point(117, 87)
        Me.tbsatuan.Name = "tbsatuan"
        Me.tbsatuan.Size = New System.Drawing.Size(100, 21)
        Me.tbsatuan.TabIndex = 2
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(117, 48)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(166, 21)
        Me.tbnama.TabIndex = 1
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(117, 12)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(100, 21)
        Me.tbid.TabIndex = 0
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 163)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(868, 344)
        Me.dgv1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HAAPUSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 26)
        '
        'HAAPUSToolStripMenuItem
        '
        Me.HAAPUSToolStripMenuItem.Name = "HAAPUSToolStripMenuItem"
        Me.HAAPUSToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HAAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(668, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "BATAL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(892, 548)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbstok As System.Windows.Forms.TextBox
    Friend WithEvents tbretail As System.Windows.Forms.TextBox
    Friend WithEvents tbgrosir As System.Windows.Forms.TextBox
    Friend WithEvents tbsatuan As System.Windows.Forms.TextBox
    Friend WithEvents tbnama As System.Windows.Forms.TextBox
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents btUbah As System.Windows.Forms.Button
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HAAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
