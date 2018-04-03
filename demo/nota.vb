Public Class nota

    Private Sub nota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Report1 As New notaa

        Report1.SetParameterValue("param", transaksi.lbId.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class