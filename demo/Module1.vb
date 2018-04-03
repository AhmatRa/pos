Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet
    Public simpan, ubah, hapus, tampil, satuan, kode, kodeTransaksi As String
    Public hgrosir, hretail As Integer
    Public Sub bukaDB()
        Dim SQLConn As String
        Try
            SQLConn = "server=localhost;Uid=root;Passwd=;Database=demo"
            Conn = New MySqlConnection(SQLConn)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Public Function rubahtgl(ByVal tgl As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(tgl, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function
End Module
