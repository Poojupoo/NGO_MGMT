Imports System.Data
Imports System.Data.SqlClient
Public Class frmSelect
    Dim ds As New DataSet

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub




    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If optTrishuul.Checked = True Then
            frmTrishuul.Show()
        ElseIf optAasra.Checked = True Then
            frmAasra.Show()
        ElseIf optKiran.Checked = True Then
            frmKiran.Show()
        ElseIf optMouse.Checked = True Then
            frmMouse.Show()
        ElseIf optSahaaya.Checked = True Then
            frmSahaaya.Show()
        Else
            MsgBox("Please select your preferred NGO")
        End If

    End Sub





    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class
