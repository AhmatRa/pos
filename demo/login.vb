Imports MySql.Data.MySqlClient
Public Class login
    Public user, pass, tmp_user, tmp_pass, nama As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Sub bos()
        Call bukaDB()
        tampil = "select * from admin where username=? and password=?"
        Try
            CMD = New MySqlCommand(tampil, Conn)
            CMD.Parameters.AddWithValue("@username", tbUser.Text)
            CMD.Parameters.AddWithValue("@password", tbPass.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MenuUtama.Show()
                MenuUtama.btnAdmin.Visible = True
                Me.Hide()
            Else
                MsgBox("ada yang salah bos ^_^")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub userbiasa()
        Call bukaDB()
        tampil = "select * from user where username=? and password=?"
        Try
            CMD = New MySqlCommand(tampil, Conn)
            CMD.Parameters.AddWithValue("@username", tbUser.Text)
            CMD.Parameters.AddWithValue("@password", tbPass.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Call getNama()
                MenuUtama.Show()
                MenuUtama.btnAdmin.Visible = False
                Me.Hide()

            Else
                Call bos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub getNama()
        Call bukaDB()
        tampil = "select nama from user where username=? and password=?"
        Try
            CMD = New MySqlCommand(tampil, Conn)
            CMD.Parameters.AddWithValue("@username", tbUser.Text)
            CMD.Parameters.AddWithValue("@password", tbPass.Text)
            RD = CMD.ExecuteReader
            RD.Read()
            nama = RD("nama")
            transaksi.Label2.Text = nama
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tbUser.Text = "" And tbPass.Text = "" Then
            MsgBox("USERNAME ATAU PASSWORD TIDAK BOLEH KOSONG")
        Else
            Call userbiasa()
            tbPass.Text = ""
            tbUser.Text = ""
        End If

    End Sub
End Class
