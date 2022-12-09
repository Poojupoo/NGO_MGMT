
Imports System.Data
Imports System.Data.SqlClient
Public Class frmQueries


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox1.Clear()
        TextBox2.Clear()
        Dim con As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        cmd.CommandText = "Select SPONSOR from SPONSORSHIP where ID='" & ComboBox2.Text & "'"
        cmd.Connection = con
        con.Open()
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        'da.Fill(ds, "SPONSORSHIP")
        'TextBox1.Text = ds.Tables("SPONSORSHIP").Rows(0).Item("SPONSOR").ToString




    End Sub





    Private Sub frmQueries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql1 As String = Nothing
        Dim sql2 As String = Nothing

        connetionString = "Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True"
        sql1 = "select ID from SPONSORSHIP"
        connection = New SqlConnection(connetionString)
        Try
            connection.Open()
            command = New SqlCommand(sql1, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            ComboBox2.DataSource = ds.Tables(0)
            ComboBox2.ValueMember = "ID"
        Catch ex As Exception
        End Try




        sql2 = "select CHILD_NAME from ADOPTION"
        connection = New SqlConnection(connetionString)
        Try
            connection.Open()
            command = New SqlCommand(sql2, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "CHILD_NAME"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")


        End Try
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmad.Click
        TextBox2.Clear()
        TextBox1.Clear()
        Dim con1 As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd1 As New SqlCommand
        Dim da1 As SqlDataAdapter
        Dim ds1 As DataSet

        cmd1.CommandText = "Select ADOPTER_NAME from ADOPTION where CHILD_NAME='" & ComboBox1.Text & "'"
        cmd1.Connection = con1
        con1.Open()
        da1 = New SqlDataAdapter(cmd1)
        ds1 = New DataSet
        da1.Fill(ds1, "ADOPTION")
        TextBox1.Text = ds1.Tables("ADOPTION").Rows(0).Item("ADOPTER_NAME").ToString
        'TextBox1.Text = ds1.Tables("ADOPTION").Rows(1).Item("NGO").ToString
        'TextBox1.Text = ds1.Tables("ADOPTION").Rows(0).Item("")


        'con1.Close()
    End Sub

    Private Sub btnConfirmsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmsp.Click
        Dim con As New SqlClient.SqlConnection("Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        cmd.CommandText = "Select SPONSORER_NAME from SPONSORSHIP where ID='" & ComboBox2.Text & "'"
        cmd.Connection = con
        con.Open()
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "SPONSORSHIP")
        TextBox2.Text = ds.Tables("SPONSORSHIP").Rows(0).Item("SPONSORER_NAME").ToString
        'TextBox1.Text = ds1.Tables("ADOPTION").Rows(0).Item("")

        'con.Close()

    End Sub
    
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.Hide()
        TextBox2.Clear()
        TextBox1.Clear()
        ComboBox2.Text = " "
        ComboBox1.Text = " "
        frmMaitreya.Show()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLogin.Show()
    End Sub

  
End Class
