Imports MySql.Data.MySqlClient
Public Class FormBarang

    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call dgv()
    End Sub
    Sub dgv()
        Call bukaDB()
        tampil = "select id,nama,stok from tbbarang"
        DA = New MySqlDataAdapter(tampil, Conn)
        DS = New DataSet
        DA.Fill(DS, "tbbarang")
        dgv1.DataSource = DS.Tables("tbbarang")
        dgv1.ReadOnly = True
    End Sub

    Sub auto()
        Call bukaDB()
        tampil = "select distinct nama from tbbarang"
        CMD = New MySqlCommand(tampil, Conn)
        RD = CMD.ExecuteReader()
        While RD.Read
            With TextBox1
                .AutoCompleteCustomSource.Add(RD("nama"))
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
    End Sub
    Sub pencarian()
        Call bukaDB()
        tampil = "select id,nama,stok from tbbarang where nama like '" & TextBox1.Text & "%'"
        Try
            DA = New MySqlDataAdapter(tampil, Conn)
            DS = New DataSet
            DA.Fill(DS, "tbbarang")
            dgv1.DataSource = DS.Tables("tbbarang")
            dgv1.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Dim baris As Integer
        baris = e.RowIndex
            tbstok.Text = dgv1.Rows(baris).Cells(2).Value.ToString
            tbid.Text = dgv1.Rows(baris).Cells(0).Value.ToString
            tbnama.Text = dgv1.Rows(baris).Cells(1).Value.ToString
            tbstok.Enabled = True
        tbstok.ReadOnly = False
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        Call bukaDB()
        ubah = "update tbbarang set stok=? where id=?"
        Try
            CMD = New MySqlCommand(ubah, Conn)
            CMD.Parameters.AddWithValue("@stok", tbstok.Text)
            CMD.Parameters.AddWithValue("@id", tbid.Text)
            CMD.ExecuteNonQuery()
            MsgBox("BERHASIL")
            Call pencarian()
            tbstok.Text = ""
            tbnama.Text = ""
            tbid.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Call auto()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call bukaDB()
        tampil = "select id,nama,stok from tbbarang where nama like '" & TextBox1.Text & "%'"
        CMD = New MySqlCommand(tampil, Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call pencarian()
        Else
            MsgBox("data tidak ditemukan")
        End If
        
    End Sub

    Private Sub tbstok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbstok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("silahkan masukan angka")
            'BAGIAN VALIDASI, SELAIN ANGKA 0-9 MAKA TIDAK AKAN MUNCUL DI TXTBOX
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call dgv()
        tbid.Text = ""
        tbnama.Text = ""
        tbstok.Text = ""
        TextBox1.Text = ""
    End Sub
End Class