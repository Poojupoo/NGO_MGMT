Imports System.Data
Imports System.Data.SqlClient
Public Class frmSahaaya
    Dim ds As New DataSet
    Private Sub EXITToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ADOPTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADOPTIONToolStripMenuItem.Click
        frmVolunteer.Show()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Me.Hide()
        frmSelect.Show()
    End Sub

    Private Sub VOLUNTEERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOLUNTEERToolStripMenuItem.Click
        frmVolunteer.Show()
    End Sub

    Private Sub SPONSORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SPONSORToolStripMenuItem.Click
        frmSponsor.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        frmGrievance.Show()
    End Sub

    Private Sub WHOWEAREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WHOWEAREToolStripMenuItem.Click
        Dim connectionString As String = "Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True"
        Dim sql As String = "SELECT * from WHOWEARE where ID like 'SAH0%'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        connection.Open()
        dataadapter.Fill(ds, "WHOWEARE")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "WHOWEARE"
    End Sub


    Private Sub WToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WToolStripMenuItem.Click
        Dim connectionString As String = "Data Source=PROJECT34;Initial Catalog=NGOdb;Integrated Security=True"
        Dim sql As String = "SELECT * from WHATWEDO where ID like 'SAH0%'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        connection.Open()
        dataadapter.Fill(ds, "WHATWEDO")
        connection.Close()
        DataGridView2.DataSource = ds
        DataGridView2.DataMember = "WHATWEDO"

    End Sub
End Class