Imports System.Data
Imports System.Data.SqlClient
Public Class frmGrievance

    Private Sub btnCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCon.Click
        Dim con As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd As New SqlCommand
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into GRIEVANCE values('" & txtId.Text & "','" & txtComplainant.Text & "','" & txtAddress.Text & "','" & txtProblem.Text & "','" & txtPhone.Text & "','" & txtComplindt.Text & "','" & cboNgo.Text & "')"
        If txtAddress.Text = "" Or txtComplainant.Text = "" Or txtComplindt.Text = "" Or txtId.Text = "" Or txtPhone.Text = "" Or txtProblem.Text = "" Then
            MsgBox("Enter all fields!")
        End If
        cmd.ExecuteNonQuery()
        MsgBox("RECORD SAVED")
        MsgBox(" PROBLEM WILL BE SOLVED WITHIN ONE WEEK")
        con.Close()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        Me.Hide()
    End Sub

    
    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtPhone.Focus()
            End If
        End If
        If txtPhone.Text.Length > 9 Then
            MsgBox("Phone number invalid!")
        End If
    End Sub


    
    Private Sub txtComplainant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComplainant.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtComplainant.Focus()
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtId.Text = ""
        txtAddress.Text = ""
        txtComplainant.Text = ""
        txtComplindt.Text = ""
        txtProblem.Text = ""
        txtPhone.Text = ""


        Dim constring As String = "Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("Select max(ID) from GRIEVANCE", con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read = True Then
            Me.txtId.Text = dr.Item(0) + 1
        Else
            Exit Sub
        End If
        con.Close()
    End Sub

   
    Private Sub lblNgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNgo.Click

    End Sub
End Class