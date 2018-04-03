Imports MySql.Data.MySqlClient
Public Class formkasir

    Private Sub formkasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call dgv()
        Call mati()
    End Sub
    Sub dgv()
        Call bukaDB()
        tampil = "select * from user"
        DA = New MySqlDataAdapter(tampil, Conn)
        DS = New DataSet
        DA.Fill(DS, "user")
        dgv1.DataSource = DS.Tables("user")
        dgv1.ReadOnly = True
    End Sub
    Sub idOtomatis()
        tampil = "Select * from user where id in (select max(id) from user)"
        CMD = New MySqlCommand(tampil, Conn)
        Dim urutan As String
        Dim hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            urutan = "U" + "01"
        Else
            hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 2) + 1
            urutan = "U" + Microsoft.VisualBasic.Right("00" & hitung, 2)
        End If
        lbId.Text = urutan
    End Sub
    Sub bersih()
        lbId.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Sub mati()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False

    End Sub
    Sub hidup()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub

    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Dim baris As Integer = e.RowIndex
            lbId.Text = dgv1.Rows(baris).Cells(0).Value.ToString
        TextBox1.Text = dgv1.Rows(baris).Cells(1).Value.ToString '/FUNSI TOSTRING UNTUK MENGHINDARI ERROR KOLOM KOSONG
            TextBox2.Text = dgv1.Rows(baris).Cells(2).Value.ToString
            TextBox3.Text = dgv1.Rows(baris).Cells(3).Value.ToString
            btTambah.Text = "UBAH"
            Call hidup()
    End Sub

    Private Sub dgv1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseUp
        If e.Button = MouseButtons.Right Then
            dgv1.ClearSelection()
            dgv1.Rows(e.RowIndex).Selected = True
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        If btTambah.Text = "TAMBAH" Then
            Call hidup()
            Call idOtomatis()
            btTambah.Text = "SIMPAN"
            Exit Sub
        End If
        If btTambah.Text = "SIMPAN" Then
            If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
                MsgBox("DATA BELUM LENGKAP")
            Else
                Call bukaDB()
                simpan = "insert into user(id,username,password,nama) values(?,?,?,?)"
                Try
                    CMD = New MySqlCommand(simpan, Conn)
                    CMD.Parameters.AddWithValue("@id", lbId.Text)
                    CMD.Parameters.AddWithValue("@username", TextBox1.Text)
                    CMD.Parameters.AddWithValue("@password", TextBox2.Text)
                    CMD.Parameters.AddWithValue("@nama", TextBox3.Text)
                    CMD.ExecuteNonQuery()
                    MsgBox("BERHASIL")
                    Call dgv()
                    Call bersih()
                    Call mati()
                    btTambah.Text = "TAMBAH"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        '===================================
        If btTambah.Text = "UBAH" Then
            Call bukaDB()
            ubah = "update user set username=?, password=?, nama=? where id=?"
            Try
                CMD = New MySqlCommand(ubah, Conn)
                CMD.Parameters.AddWithValue("@username", TextBox1.Text)
                CMD.Parameters.AddWithValue("@password", TextBox2.Text)
                CMD.Parameters.AddWithValue("@nama", TextBox3.Text)
                CMD.Parameters.AddWithValue("@id", lbId.Text)
                CMD.ExecuteNonQuery()
                Call dgv()
                Call bersih()
                Call mati()
                btTambah.Text = "TAMBAH"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call bersih()
        Call mati()
        btTambah.Text = "TAMBAH"
        Call dgv()
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSToolStripMenuItem.Click
        Dim x = dgv1.CurrentRow.Index
        Dim y = dgv1.Rows(x).Cells(3).Value
        Dim z = dgv1.CurrentRow.Selected
        Dim result As Integer = MessageBox.Show("ANDA AKAN MENGHAPUS DATA user DENGAN NAMA :" & y, "", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            ' MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            '=========== BAGIAN PENGHAPUSAN =============
            Call bukaDB()
            Try
                hapus = "delete from user where id='" & lbId.Text & "'"
                CMD = New MySqlCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("data terhapus")
                btTambah.Text = "TAMBAH"
                Call bersih()
                Call mati()
                Call dgv()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class