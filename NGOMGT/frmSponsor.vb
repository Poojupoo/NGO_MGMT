Imports System.Data
Imports System.Data.SqlClient

Public Class frmSponsor

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtId.Text = "" Or txtName.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Or txtQualification.Text = "" Or txtAmount.Text = "" Then
            MsgBox("ENTER ALL DETAILS!")
        End If

        Dim con As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd As New SqlCommand
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into SPONSORSHIP values('" & txtId.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtQualification.Text & "','" & txtAmount.Text & "')"

        cmd.ExecuteNonQuery()
        MsgBox("RECORD SAVED")
        con.Close()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.Hide()
    End Sub

    

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim constring As String = ("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim con As New SqlConnection(constring)
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("Select max(ID) from SPONSORSHIP", con)
        Dim result As String
        Dim curvalue As Integer
        con.Open()
        result = cmd.ExecuteScalar().ToString
        If String.IsNullOrEmpty(result) Then
            result = "SP001"
        End If
        result = result.Substring(3)
        Int32.TryParse(result, curvalue)
        curvalue = curvalue + 1
        result = "SP" + curvalue.ToString("D3")
        txtId.Text = result
        cmd.Dispose()
        con.Close()
    End Sub
    Sub clearfields()
        txtId.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtAmount.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtQualification.Text = ""

    End Sub


    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtName.Focus()
            End If
        End If
    End Sub


    Private Sub txtQualification_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQualification.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtQualification.Focus()
            End If
        End If
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


    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtAmount.Focus()
            End If
        End If

    End Sub



    Private Sub frmSponsor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class