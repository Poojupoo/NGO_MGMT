Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim con As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim flag As Boolean
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select * from LOGIN"
        cmd.ExecuteNonQuery()
        Dim lrd As SqlDataReader = cmd.ExecuteReader
        flag = False
        While lrd.Read
            If lrd("UserName") = txtUsername.Text And lrd("Password") = txtPassword.Text Then
                MsgBox("Valid user")
                flag = True
                Me.Hide()
                frmSelect.Show()
            End If
        End While
        If flag = False Then
            MsgBox("Invalid user")
        End If
        con.Close()

    End Sub


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
