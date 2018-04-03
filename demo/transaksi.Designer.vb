<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
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
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.lbHari = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btTampung = New System.Windows.Forms.Button()
        Me.lbId = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.lbSatuan = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.idbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cGorsir = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbStok = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbKembalian = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.btHitung = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RUBAHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CETAKNOTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HAPUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbstokedit = New System.Windows.Forms.Label()
        Me.S = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbEdit = New System.Windows.Forms.TextBox()
        Me.btUbah = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbIdBarang = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Chocolate
        Me.Panel1.Controls.Add(Me.lbTanggal)
        Me.Panel1.Controls.Add(Me.lbHari)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 70)
        Me.Panel1.TabIndex = 0
        '
        'lbTanggal
        '
        Me.lbTanggal.AutoSize = True
        Me.lbTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTanggal.Location = New System.Drawing.Point(1026, 40)
        Me.lbTanggal.Name = "lbTanggal"
        Me.lbTanggal.Size = New System.Drawing.Size(85, 18)
        Me.lbTanggal.TabIndex = 5
        Me.lbTanggal.Text = "TANGGAL"
        '
        'lbHari
        '
        Me.lbHari.AutoSize = True
        Me.lbHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHari.Location = New System.Drawing.Point(1042, 9)
        Me.lbHari.Name = "lbHari"
        Me.lbHari.Size = New System.Drawing.Size(46, 18)
        Me.lbHari.TabIndex = 4
        Me.lbHari.Text = "HARI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(925, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TANGGAL :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(964, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HARI :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KASIR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KASIR :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ID TRANSAKSI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "BARANG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "JUMLAH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "SATUAN"
        '
        'btTampung
        '
        Me.btTampung.Location = New System.Drawing.Point(84, 357)
        Me.btTampung.Name = "btTampung"
        Me.btTampung.Size = New System.Drawing.Size(125, 51)
        Me.btTampung.TabIndex = 6
        Me.btTampung.Text = "TAMPUNG"
        Me.btTampung.UseVisualStyleBackColor = True
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbId.Location = New System.Drawing.Point(232, 73)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(133, 20)
        Me.lbId.TabIndex = 7
        Me.lbId.Text = "ID TRANSAKSI"
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(236, 150)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(206, 21)
        Me.tbNama.TabIndex = 8
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(235, 188)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(206, 20)
        Me.tbJumlah.TabIndex = 9
        '
        'lbSatuan
        '
        Me.lbSatuan.AutoSize = True
        Me.lbSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSatuan.Location = New System.Drawing.Point(232, 233)
        Me.lbSatuan.Name = "lbSatuan"
        Me.lbSatuan.Size = New System.Drawing.Size(80, 20)
        Me.lbSatuan.TabIndex = 10
        Me.lbSatuan.Text = "SATUAN"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idbarang, Me.nama, Me.satuan, Me.jumlah, Me.harga, Me.subTotal})
        Me.dgv1.Location = New System.Drawing.Point(483, 93)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(732, 217)
        Me.dgv1.TabIndex = 11
        '
        'idbarang
        '
        Me.idbarang.HeaderText = "ID Barang"
        Me.idbarang.Name = "idbarang"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Barang"
        Me.nama.Name = "nama"
        '
        'satuan
        '
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga Satuan"
        Me.harga.Name = "harga"
        '
        'subTotal
        '
        Me.subTotal.HeaderText = "SUB TOTAL"
        Me.subTotal.Name = "subTotal"
        '
        'cGorsir
        '
        Me.cGorsir.AutoSize = True
        Me.cGorsir.Location = New System.Drawing.Point(120, 307)
        Me.cGorsir.Name = "cGorsir"
        Me.cGorsir.Size = New System.Drawing.Size(68, 17)
        Me.cGorsir.TabIndex = 12
        Me.cGorsir.Text = "GROSIR"
        Me.cGorsir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "STOK"
        '
        'lbStok
        '
        Me.lbStok.AutoSize = True
        Me.lbStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStok.Location = New System.Drawing.Point(232, 272)
        Me.lbStok.Name = "lbStok"
        Me.lbStok.Size = New System.Drawing.Size(55, 20)
        Me.lbStok.TabIndex = 14
        Me.lbStok.Text = "STOK"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(521, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "TOTAL :"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(613, 350)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(97, 29)
        Me.lbTotal.TabIndex = 16
        Me.lbTotal.Text = "TOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(510, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "BAYAR  :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(475, 437)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "KEMBALIAN :"
        '
        'lbKembalian
        '
        Me.lbKembalian.AutoSize = True
        Me.lbKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKembalian.Location = New System.Drawing.Point(614, 437)
        Me.lbKembalian.Name = "lbKembalian"
        Me.lbKembalian.Size = New System.Drawing.Size(110, 20)
        Me.lbKembalian.TabIndex = 19
        Me.lbKembalian.Text = "KEMBALIAN"
        '
        'tbBayar
        '
        Me.tbBayar.Location = New System.Drawing.Point(618, 395)
        Me.tbBayar.Margin = New System.Windows.Forms.Padding(3, 4, 4, 3)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(206, 20)
        Me.tbBayar.TabIndex = 20
        '
        'btHitung
        '
        Me.btHitung.Location = New System.Drawing.Point(531, 489)
        Me.btHitung.Name = "btHitung"
        Me.btHitung.Size = New System.Drawing.Size(135, 68)
        Me.btHitung.TabIndex = 21
        Me.btHitung.Text = "HITUNG"
        Me.btHitung.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RUBAHToolStripMenuItem, Me.CETAKNOTAToolStripMenuItem, Me.HAPUSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 70)
        '
        'RUBAHToolStripMenuItem
        '
        Me.RUBAHToolStripMenuItem.Name = "RUBAHToolStripMenuItem"
        Me.RUBAHToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RUBAHToolStripMenuItem.Text = "RUBAH"
        '
        'CETAKNOTAToolStripMenuItem
        '
        Me.CETAKNOTAToolStripMenuItem.Name = "CETAKNOTAToolStripMenuItem"
        Me.CETAKNOTAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CETAKNOTAToolStripMenuItem.Text = "CETAK NOTA"
        '
        'HAPUSToolStripMenuItem
        '
        Me.HAPUSToolStripMenuItem.Name = "HAPUSToolStripMenuItem"
        Me.HAPUSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HAPUSToolStripMenuItem.Text = "HAPUS"
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(689, 489)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(135, 68)
        Me.btSimpan.TabIndex = 23
        Me.btSimpan.Text = "SIMPAN DAN CETAK "
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.lbstokedit)
        Me.Panel2.Controls.Add(Me.S)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.tbEdit)
        Me.Panel2.Controls.Add(Me.btUbah)
        Me.Panel2.Location = New System.Drawing.Point(993, 343)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(104, 164)
        Me.Panel2.TabIndex = 24
        '
        'lbstokedit
        '
        Me.lbstokedit.AutoSize = True
        Me.lbstokedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstokedit.Location = New System.Drawing.Point(53, 19)
        Me.lbstokedit.Name = "lbstokedit"
        Me.lbstokedit.Size = New System.Drawing.Size(25, 15)
        Me.lbstokedit.TabIndex = 29
        Me.lbstokedit.Text = "XX"
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.Location = New System.Drawing.Point(3, 19)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(51, 15)
        Me.S.TabIndex = 28
        Me.S.Text = "STOK :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "TUTUP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbEdit
        '
        Me.tbEdit.Location = New System.Drawing.Point(6, 49)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(89, 20)
        Me.tbEdit.TabIndex = 23
        '
        'btUbah
        '
        Me.btUbah.Location = New System.Drawing.Point(6, 86)
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Size = New System.Drawing.Size(89, 28)
        Me.btUbah.TabIndex = 22
        Me.btUbah.Text = "UBAH"
        Me.btUbah.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(42, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "ID BARANG"
        '
        'lbIdBarang
        '
        Me.lbIdBarang.AutoSize = True
        Me.lbIdBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdBarang.Location = New System.Drawing.Point(232, 113)
        Me.lbIdBarang.Name = "lbIdBarang"
        Me.lbIdBarang.Size = New System.Drawing.Size(108, 20)
        Me.lbIdBarang.TabIndex = 26
        Me.lbIdBarang.Text = "ID BARANG"
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1227, 625)
        Me.Controls.Add(Me.lbIdBarang)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.tbBayar)
        Me.Controls.Add(Me.btHitung)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbKembalian)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lbStok)
        Me.Controls.Add(Me.cGorsir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbId)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.lbSatuan)
        Me.Controls.Add(Me.btTampung)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "transaksi"
        Me.Text = "Transaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbTanggal As System.Windows.Forms.Label
    Friend WithEvents lbHari As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btTampung As System.Windows.Forms.Button
    Friend WithEvents lbId As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents tbJumlah As System.Windows.Forms.TextBox
    Friend WithEvents lbSatuan As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents cGorsir As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbStok As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbKembalian As System.Windows.Forms.Label
    Friend WithEvents tbBayar As System.Windows.Forms.TextBox
    Friend WithEvents btHitung As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RUBAHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CETAKNOTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tbEdit As System.Windows.Forms.TextBox
    Friend WithEvents btUbah As System.Windows.Forms.Button
    Friend WithEvents HAPUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbIdBarang As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbstokedit As System.Windows.Forms.Label
    Friend WithEvents S As System.Windows.Forms.Label
    Friend WithEvents idbarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
