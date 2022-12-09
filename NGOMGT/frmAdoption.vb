Imports System.Data
Imports System.Data.SqlClient
Public Class frmAdoption

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtAddress.Text = "" Or txtAdopter.Text = "" Or txtAge.Text = "" Or txtChild.Text = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Then
            MsgBox("ENTER ALL DETAILS!")
        End If

        Dim con As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd As New SqlCommand
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into ADOPTION values('" & txtId.Text & "', '" & txtAdopter.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & cboNgo.Text & "','" & txtChild.Text & "','" & txtAge.Text & "','" & txtDate.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("RECORD SAVED")
        con.Close()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        Me.Hide()
    End Sub


    Private Sub btnTerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerm.Click
        frmTandC2.Show()
    End Sub

    

    

    Private Sub txtAdopter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdopter.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtAdopter.Focus()
            End If
        End If
    End Sub


    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtAge.Focus()
            End If
        End If


    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        'Dim result As String
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


    Private Sub txtChild_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChild.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtChild.Focus()
            End If
        End If
    End Sub

    

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim constring As String = ("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim con As New SqlConnection(constring)
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("Select max(ID) from ADOPTION", con)
        Dim result As String
        Dim curvalue As Integer
        con.Open()
        result = cmd.ExecuteScalar().ToString
        If String.IsNullOrEmpty(result) Then
            result = "AD001"
        End If
        result = result.Substring(3)
        Int32.TryParse(result, curvalue)
        curvalue = curvalue + 1
        result = "AD" + curvalue.ToString("D3")
        txtId.Text = result
        cmd.Dispose()
        con.Close()
    End Sub
    Sub clearfields()
        txtId.Text = ""
        txtAdopter.Text = ""
        txtAddress.Text = ""
        txtAge.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtChild.Text = ""
        txtDate.Text = ""


    End Sub

  
End Class