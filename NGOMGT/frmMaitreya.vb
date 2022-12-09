
Public Class frmMaitreya

    Private Sub frmMaitreya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Hide()
        Panel2.Hide()

        Panel4.Hide()


    End Sub

    Private Sub mnuMISSION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMISSION.Click
        Panel2.Hide()

        Panel4.Hide()

        Panel1.Show()
    End Sub

    Private Sub mnuPEOPLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPEOPLE.Click
        Panel1.Hide()

        Panel4.Hide()

        Panel2.Show()

    End Sub


    Private Sub mnuWORKING_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWORKING.Click

        Panel2.Hide()
        Panel1.Hide()

        Panel4.Show()
    End Sub


    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Panel4.Hide()
        Panel1.Hide()
        Panel2.Hide()
        frmLogin.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub mnuQUERIES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQUERIES.Click
        Me.Hide()
        frmQueries.Show()
    End Sub

    Private Sub mnuREPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuREPORT.Click
        frmReport.Show()
    End Sub

   
End Class