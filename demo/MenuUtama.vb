Public Class MenuUtama

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormBarang.StartPosition = FormStartPosition.CenterScreen
        FormBarang.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        transaksi.StartPosition = FormStartPosition.CenterScreen
        transaksi.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        login.Show()
        Me.Close()
    End Sub
End Class