Public Class frmReport

    Private Sub btnAdoption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdoption.Click

    End Sub

    Private Sub btnSponsor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSponsor.Click

    End Sub

   
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        frmMaitreya.Show()
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class