Imports MySql.Data.MySqlClient
Public Class FormAdmin
    Public id, nama, satuan As String
    Public hgrosir, hrtail, stok As Integer
    Private Sub FormAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call mati()
        Call dgv()
    End Sub

    Sub aktif()
        'tbid.Enabled = True
        tbnama.Enabled = True
        tbsatuan.Enabled = True
        tbgrosir.Enabled = True
        tbretail.Enabled = True
        tbstok.Enabled = True
    End Sub

    Sub mati()
        tbid.Enabled = False
        tbnama.Enabled = False
        tbsatuan.Enabled = False
        tbgrosir.Enabled = False
        tbretail.Enabled = False
        tbstok.Enabled = False
        btTambah.Text = "TAMBAH"
    End Sub
    Sub idOtomatis()
        tampil = "Select * from tbbarang where id in (select max(id) from tbbarang)"
        CMD = New MySqlCommand(tampil, Conn)
        Dim urutan As String
        Dim hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "BR" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 4) + 1
            urutan = "BR" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        tbid.Text = urutan
    End Sub

    Sub bersih()
        tbid.Text = ""
        tbnama.Text = ""
        tbsatuan.Text = ""
        tbgrosir.Text = ""
        tbretail.Text = ""
        tbstok.Text = ""
    End Sub

    Sub dgv()
        Call bukaDB()
        DA = New MySqlDataAdapter("SELECT * from tbbarang", Conn)
        DS = New DataSet
        DA.Fill(DS, "tbbarang")
        dgv1.DataSource = DS.Tables("tbbarang")
        dgv1.ReadOnly = True
    End Sub

    Private Sub btTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        id = tbid.Text
        nama = tbnama.Text
        satuan = tbsatuan.Text
        hgrosir = Val(tbgrosir.Text)
        hrtail = Val(tbretail.Text)
        stok = Val(tbstok.Text)
        '==========================================
        If btTambah.Text = "TAMBAH" Then
            btTambah.Text = "SIMPAN"
            Call idOtomatis()
            Call aktif()
            Exit Sub
        End If
        If btTambah.Text = "SIMPAN" Then
            Call bukaDB()
            Try
                simpan = "insert into tbbarang(id,nama,satuan,hgrosir,hretail,stok) values ('" & id & "','" & nama & "','" & satuan & "','" & hgrosir & "','" & hrtail & "','" & stok & "')"
                CMD = New MySqlCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("DATA TERSIMPAN")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '===================================================
            Call dgv()
            Call mati()
            Call bersih()
        End If
    End Sub

    Private Sub tbgrosir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbgrosir.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("MAAF..HANYA BISA BERISI ANGKA")
        End If

    End Sub

    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Dim baris As Integer = e.RowIndex
        For baris = 0 To dgv1.RowCount - 2
            tbid.Text = dgv1.Rows(baris).Cells(0).Value
            tbnama.Text = dgv1.Rows(baris).Cells(1).Value
            tbsatuan.Text = dgv1.Rows(baris).Cells(2).Value
            tbgrosir.Text = dgv1.Rows(baris).Cells(3).Value
            tbretail.Text = dgv1.Rows(baris).Cells(4).Value
            tbstok.Text = dgv1.Rows(baris).Cells(5).Value
            Call aktif()
            btUbah.Text = "SIMPAN"
        Next
    End Sub

    Private Sub btUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUbah.Click
        id = tbid.Text
        nama = tbnama.Text
        satuan = tbsatuan.Text
        hgrosir = tbgrosir.Text
        hrtail = tbretail.Text
        stok = tbstok.Text
        '==========================================
        If btUbah.Text = "UBAH" Then
            MsgBox("klik tabel yang akan di rubah")
            Exit Sub
        End If
        If btUbah.Text = "SIMPAN" Then
            Call aktif()
            Call bukaDB()
            Try
                ubah = "update tbbarang set id='" & id & "',nama='" & nama & "', satuan='" & satuan & "', hgrosir='" & hgrosir & "', hretail='" & hrtail & "', stok='" & stok & "' where id='" & id & "'"
                CMD = New MySqlCommand(ubah, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("DATA TERSIMPAN")
                btUbah.Text = "UBAH"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '===================================================
            Call dgv()
            Call mati()
            Call bersih()
        End If
    End Sub

    Private Sub dgv1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Call mati()
            btUbah.Text = "UBAH"
            dgv1.ClearSelection()
            dgv1.Rows(e.RowIndex).Selected = True
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub HAAPUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAAPUSToolStripMenuItem.Click
        Dim x = dgv1.CurrentRow.Index
        Dim y = dgv1.Rows(x).Cells(1).Value
        Dim z = dgv1.CurrentRow.Selected
        Dim result As Integer = MessageBox.Show("ANDA AKAN MENGHAPUS DATA BARANG DENGAN NAMA :" & y, "", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            ' MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            '=========== BAGIAN PENGHAPUSAN =============
            Call bukaDB()
            Try
                hapus = "delete from tbbarang where id='" & tbid.Text & "'"
                CMD = New MySqlCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data terhapus")
                Call bersih()
                Call dgv()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btUbah.Text = "UBAH"
        btTambah.Text = "TAMBAH"
        Call bersih()
        Call mati()
    End Sub
End Class