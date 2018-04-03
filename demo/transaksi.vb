Imports MySql.Data.MySqlClient
Public Class transaksi
    Public tmp_id, tmp_satuan, idforedit As String
    Public tmp_stok, tmp_jumlah, tmp_total, tmp_harga As Integer

    Private Sub transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lbTotal.Text = "TOTAL" Then
            btSimpan.Enabled = False
        End If
        lbHari.Text = rubahtgl(Format(CDate(Now.Date), "dddd"))
        lbTanggal.Text = rubahtgl(Format(CDate(Now.Date), "dd-MM-yyyy"))
        '==================================================================
        'merubah cultureinfo menjadi indonesia
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("id-ID")
        '===================================================================
        Call auto()
        Call autoid()
        dgv1.ReadOnly = True
        Panel2.Visible = False
        With dgv1
            .Columns(0).Width = 110
            .Columns(1).Width = 173
            .Columns(2).Width = 60
            .Columns(3).Width = 50
            .Columns(4).Width = 150
            .Columns(5).Width = 150
        End With
    End Sub
    Sub awal()
        Call bersih()
        Call bersih2()
        Call autoid()
        dgv1.Rows.Clear()
    End Sub
    Sub simpandata()
        '==================================================================
        Dim total, kembalian As Integer
        total = lbTotal.Text.ToString
        kembalian = lbKembalian.Text.ToString
        Call bukaDB()
        Try
            For Each baris As DataGridViewRow In dgv1.Rows
                simpan = "insert into tbjual(nofaktur,kasir,tanggal,id_barang,nama_barang,satuan,jumlah,harga,subtotal,totalbayar,bayar,kembalian) values(?,?,?,?,?,?,?,?,?,?,?,?)"
                CMD = New MySqlCommand(simpan, Conn)
                CMD.Parameters.AddWithValue("@nofaktur", lbId.Text)
                CMD.Parameters.AddWithValue("@kasir", Label2.Text)
                CMD.Parameters.AddWithValue("@tanggal", lbTanggal.Text)
                CMD.Parameters.AddWithValue("@id_barang", baris.Cells(0).Value)
                CMD.Parameters.AddWithValue("@nama_barang", baris.Cells(1).Value)
                CMD.Parameters.AddWithValue("@satuan", baris.Cells(2).Value)
                CMD.Parameters.AddWithValue("@jumlah", baris.Cells(3).Value)
                CMD.Parameters.AddWithValue("@harga", baris.Cells(4).Value)
                CMD.Parameters.AddWithValue("@subtotal", baris.Cells(5).Value)
                CMD.Parameters.AddWithValue("@totalbayar", total)
                CMD.Parameters.AddWithValue("@bayar", tbBayar.Text)
                CMD.Parameters.AddWithValue("@kembalian", kembalian)
                CMD.ExecuteNonQuery()
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        MsgBox("oke")
    End Sub
    
    Sub bersih()
        tbNama.Text = ""
        tbJumlah.Text = ""
        lbSatuan.Text = ""
        lbStok.Text = ""
    End Sub
    Sub bersih2()
        lbIdBarang.Text = ""
        'lbId.Text = ""
        lbKembalian.Text = ""
        lbTotal.Text = ""
    End Sub
    Sub periksadata()
        '========================= untuk cek data sebelum masuk ke dgv
        tampil = "select nama from tbbarang where nama=? and id=?"
        Call bukaDB()
        Try
            CMD = New MySqlCommand(tampil, Conn)
            CMD.Parameters.AddWithValue("@nama", tbNama.Text)
            CMD.Parameters.AddWithValue("@id", lbIdBarang.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("barang tidak ditemukan,periksa kembali nama barang")
                btTampung.Enabled = False
            Else
                btTampung.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub dgv()
        Dim sub_total As Integer
        '=============================== BAGIAN INPUT DATA KE DGV ==================
        tampil = "select id,satuan,hgrosir,hretail,stok from tbbarang where nama ='" & tbNama.Text & "'"
        Call bukaDB()
        CMD = New MySqlCommand(tampil, Conn)
        RD = CMD.ExecuteReader()
        While RD.Read
            tmp_id = (RD("id"))
            tmp_satuan = (RD("satuan"))
            tmp_stok = (RD("stok"))
            hretail = (RD("hretail"))
            hgrosir = (RD("hgrosir"))
            'haha = (RD("satuan"))
        End While
        If cGorsir.Checked = True Then
            sub_total = Val(tbJumlah.Text) * hgrosir
            dgv1.Rows.Add(1)
            dgv1.Rows(dgv1.RowCount - 2).Cells(0).Value = lbIdBarang.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(1).Value = tbNama.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(2).Value = lbSatuan.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(3).Value = tbJumlah.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(4).Value = hgrosir
            dgv1.Rows(dgv1.RowCount - 2).Cells(5).Value = sub_total
            dgv1.Update()
        ElseIf cGorsir.Checked = False Then
            sub_total = Val(tbJumlah.Text) * hretail
            dgv1.Rows.Add(1)
            dgv1.Rows(dgv1.RowCount - 2).Cells(0).Value = lbIdBarang.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(1).Value = tbNama.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(2).Value = lbSatuan.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(3).Value = tbJumlah.Text
            dgv1.Rows(dgv1.RowCount - 2).Cells(4).Value = hretail
            dgv1.Rows(dgv1.RowCount - 2).Cells(5).Value = sub_total
            dgv1.Update()
        End If
        
    End Sub
    Sub auto()
        '============== SEARCHING AUTO KOMPLIT DI TEXTBOX =======================
        Call bukaDB()
        Try
            tampil = "select nama from tbbarang"
            CMD = New MySqlCommand(tampil, Conn)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                While RD.Read()
                    With tbNama
                        .AutoCompleteCustomSource.Add(RD("nama"))
                        .AutoCompleteMode = AutoCompleteMode.Suggest
                        .AutoCompleteSource = AutoCompleteSource.CustomSource
                        .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    End With
                End While
            Else
                MsgBox("kosong")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Sub autoid()
        Call bukaDB()
        tampil = "Select * from tbjual where nofaktur in (select max(nofaktur) from tbjual)"
        CMD = New MySqlCommand(tampil, Conn)
        Dim urutan As String
        Dim hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "TR" + "00001"
        Else
            hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 5) + 1
            urutan = "TR" + Microsoft.VisualBasic.Right("00000" & hitung, 5)
        End If
        lbId.Text = urutan
    End Sub

    Private Sub dgv1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDown
        Dim baris As Integer
        baris = e.RowIndex
        If e.Button = MouseButtons.Right Then
            tmp_jumlah = dgv1.Rows(baris).Cells(3).Value
            tmp_harga = dgv1.Rows(baris).Cells(4).Value
            dgv1.ClearSelection()
            dgv1.Rows(e.RowIndex).Selected = True
            ContextMenuStrip1.Show(Cursor.Position)
            '====================================== mengambil id berdasarkan nama dan satuan di dgv untuk validasi stok
            Call bukaDB()
            Try
                tampil = "select stok from tbbarang where nama=? and satuan=?"
                CMD = New MySqlCommand(tampil, Conn)
                CMD.Parameters.AddWithValue("@nama", dgv1.Rows(baris).Cells(1).Value)
                CMD.Parameters.AddWithValue("@satuan", dgv1.Rows(baris).Cells(2).Value)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    lbstokedit.Text = RD("stok")
                Else
                    MsgBox("data tidak ditemukan")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub RUBAHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RUBAHToolStripMenuItem.Click
        Panel2.Visible = True
        tbEdit.Text = tmp_jumlah
    End Sub

    Private Sub tbJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("silahkan masukan angka")
            'BAGIAN VALIDASI, SELAIN ANGKA 0-9 MAKA TIDAK AKAN MUNCUL DI TXTBOX
        End If
        Call periksadata()
    End Sub
    Sub panggilstok()
        tampil = "select id,satuan,stok from tbbarang where nama =?"
        Call bukaDB()
        Try
            CMD = New MySqlCommand(tampil, Conn)
            CMD.Parameters.AddWithValue("@nama", tbNama.Text)
            RD = CMD.ExecuteReader()
            While RD.Read
                lbIdBarang.Text = (RD("id"))
                lbSatuan.Text = (RD("satuan"))
                lbStok.Text = (RD("stok"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btTampung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTampung.Click
        '================================ validasi jumlah harus < stok
        If tbJumlah.Text > lbStok.Text Then
            MsgBox("maaf..jumlah melebihi stok")
        Else
            '===================== BAGIAN VALIDASI INPUT NAMA BARANG =========
            For row As Integer = 0 To dgv1.RowCount - 1
                If tbNama.Text = dgv1.Rows(row).Cells(0).Value Then
                    MsgBox("data ada, silahkan rubah jumlah")
                    Call bersih()
                    Exit Sub
                End If
            Next
            '==============================================================
            Call dgv()
            Call bersih()
            '============ BAGIAN PERHITUNGAN TOTAL BAYAR ===============
            Dim totalbayar As Integer
            For t As Integer = 0 To dgv1.Rows.Count - 2
                totalbayar = totalbayar + dgv1.Rows(t).Cells(5).Value
                lbTotal.Text = FormatCurrency(totalbayar)
            Next
        End If
    End Sub

    Private Sub btHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHitung.Click
        Dim bayar, kembalian, totbayar As Integer
        totbayar = Val(lbTotal.Text)
        bayar = Val(tbBayar.Text)
        If bayar <= 0 Or bayar < lbTotal.Text Then
            MsgBox("MAAF UANG KURANG")
            lbKembalian.Text = "0"
        Else
            kembalian = bayar - lbTotal.Text
            lbKembalian.Text = FormatCurrency(kembalian)
            btSimpan.Enabled = True
        End If
       
    End Sub

    Private Sub tbBayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbBayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("silahkan masukan angka")
            'BAGIAN VALIDASI, SELAIN ANGKA 0-9 MAKA TIDAK AKAN MUNCUL DI TXTBOX
        End If
        Dim bayar, totbayar As Integer
        totbayar = Val(lbTotal.Text)
        bayar = Val(tbBayar.Text)
        If bayar <= 0 Or bayar < lbTotal.Text Then
            btSimpan.Enabled = False
        Else
            btSimpan.Enabled = True
        End If
    End Sub

    Private Sub tbJumlah_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbJumlah.MouseClick
        'Call periksadata()
        Call panggilstok()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tbEdit.Text = ""
        Panel2.Visible = False
    End Sub

    Private Sub btUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUbah.Click
        '================================ validasi jumlah harus < stok
        If tbEdit.Text > lbstokedit.Text Then
            MsgBox("maaf..jumlah melebihi stok")
            Exit Sub
        End If
        '=============================================================
        Dim baris, totalbaru As Integer
        baris = dgv1.CurrentRow.Index
        With dgv1
            tmp_total = tbEdit.Text * tmp_harga
            .Rows(baris).Cells(3).Value = tbEdit.Text
            .Rows(baris).Cells(5).Value = tmp_total
            For t As Integer = 0 To dgv1.Rows.Count - 2
                totalbaru = totalbaru + dgv1.Rows(t).Cells(5).Value
                lbTotal.Text = FormatCurrency(totalbaru)
            Next
        End With
    End Sub

    Private Sub tbEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbEdit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("silahkan masukan angka")
            'BAGIAN VALIDASI, SELAIN ANGKA 0-9 MAKA TIDAK AKAN MUNCUL DI TXTBOX
        End If
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSToolStripMenuItem.Click
        Dim x = dgv1.CurrentRow.Index
        Dim y = dgv1.Rows(x).Cells(0).Value
        Dim result As Integer = MessageBox.Show("YAKIN INGIN MENGHAPUS :" & y & " DARI DAFTAR BELANJA?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then
            ' MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            ' MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            dgv1.Rows.RemoveAt(x)
        End If
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        'If tbBayar.Text <= 0 Or tbBayar.Text = "" Then
        '    MsgBox("periksa pembayaran")
        '    lbKembalian.Text = "0"
        'ElseIf tbBayar.Text < lbTotal.Text Then
        '    MsgBox("uang kurang, periksa pembayaran")
        '    lbKembalian.Text = "0"
        '    Exit Sub
        'End If
        Dim result As Integer = MessageBox.Show("PILIH NO JIKA HANYA INGIN MENYIMPAN,, DAN YES UNTUK CETAK NOTA", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Call simpandata()
            tbBayar.Text = ""
            Call awal()
        ElseIf result = DialogResult.Yes Then
            Call simpandata()
            tbBayar.Text = ""
            nota.Show()
            Call awal()
        End If
        
    End Sub
End Class