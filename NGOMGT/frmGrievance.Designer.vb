<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrievance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.lblComplainant = New System.Windows.Forms.Label
        Me.lblAdress = New System.Windows.Forms.Label
        Me.lblProblem = New System.Windows.Forms.Label
        Me.lblCMPLNDT = New System.Windows.Forms.Label
        Me.lblNgo = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtComplainant = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtProblem = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtComplindt = New System.Windows.Forms.TextBox
        Me.cboNgo = New System.Windows.Forms.ComboBox
        Me.btnCon = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 0
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Purple
        Me.lblId.Location = New System.Drawing.Point(326, 162)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(31, 26)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID"
        '
        'lblComplainant
        '
        Me.lblComplainant.AutoSize = True
        Me.lblComplainant.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblComplainant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComplainant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplainant.ForeColor = System.Drawing.Color.Purple
        Me.lblComplainant.Location = New System.Drawing.Point(261, 253)
        Me.lblComplainant.Name = "lblComplainant"
        Me.lblComplainant.Size = New System.Drawing.Size(159, 26)
        Me.lblComplainant.TabIndex = 2
        Me.lblComplainant.Text = "COMPLAINANT"
        '
        'lblAdress
        '
        Me.lblAdress.AutoSize = True
        Me.lblAdress.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblAdress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdress.ForeColor = System.Drawing.Color.Purple
        Me.lblAdress.Location = New System.Drawing.Point(289, 339)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(108, 26)
        Me.lblAdress.TabIndex = 3
        Me.lblAdress.Text = "ADDRESS"
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblProblem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProblem.ForeColor = System.Drawing.Color.Purple
        Me.lblProblem.Location = New System.Drawing.Point(289, 434)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(110, 26)
        Me.lblProblem.TabIndex = 4
        Me.lblProblem.Text = "PROBLEM"
        '
        'lblCMPLNDT
        '
        Me.lblCMPLNDT.AutoSize = True
        Me.lblCMPLNDT.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblCMPLNDT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCMPLNDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMPLNDT.ForeColor = System.Drawing.Color.Purple
        Me.lblCMPLNDT.Location = New System.Drawing.Point(242, 593)
        Me.lblCMPLNDT.Name = "lblCMPLNDT"
        Me.lblCMPLNDT.Size = New System.Drawing.Size(178, 26)
        Me.lblCMPLNDT.TabIndex = 5
        Me.lblCMPLNDT.Text = "COMPLAIN DATE"
        '
        'lblNgo
        '
        Me.lblNgo.AutoSize = True
        Me.lblNgo.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblNgo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgo.ForeColor = System.Drawing.Color.Purple
        Me.lblNgo.Location = New System.Drawing.Point(313, 675)
        Me.lblNgo.Name = "lblNgo"
        Me.lblNgo.Size = New System.Drawing.Size(58, 26)
        Me.lblNgo.TabIndex = 6
        Me.lblNgo.Text = "NGO"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Purple
        Me.lblPhone.Location = New System.Drawing.Point(277, 514)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(122, 26)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "PHONE NO"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(637, 166)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(156, 20)
        Me.txtId.TabIndex = 9
        '
        'txtComplainant
        '
        Me.txtComplainant.Location = New System.Drawing.Point(637, 257)
        Me.txtComplainant.Name = "txtComplainant"
        Me.txtComplainant.Size = New System.Drawing.Size(156, 20)
        Me.txtComplainant.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(637, 345)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(156, 20)
        Me.txtAddress.TabIndex = 11
        '
        'txtProblem
        '
        Me.txtProblem.Location = New System.Drawing.Point(637, 434)
        Me.txtProblem.Name = "txtProblem"
        Me.txtProblem.Size = New System.Drawing.Size(156, 20)
        Me.txtProblem.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(637, 514)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(156, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtComplindt
        '
        Me.txtComplindt.Location = New System.Drawing.Point(637, 597)
        Me.txtComplindt.Name = "txtComplindt"
        Me.txtComplindt.Size = New System.Drawing.Size(156, 20)
        Me.txtComplindt.TabIndex = 14
        '
        'cboNgo
        '
        Me.cboNgo.FormattingEnabled = True
        Me.cboNgo.Items.AddRange(New Object() {"Trishuul", "Sahaaya", "Aasra", "Kiran", "Mouse"})
        Me.cboNgo.Location = New System.Drawing.Point(637, 679)
        Me.cboNgo.Name = "cboNgo"
        Me.cboNgo.Size = New System.Drawing.Size(154, 20)
        Me.cboNgo.TabIndex = 19
        '
        'btnCon
        '
        Me.btnCon.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.ForeColor = System.Drawing.Color.Purple
        Me.btnCon.Location = New System.Drawing.Point(1095, 434)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(157, 62)
        Me.btnCon.TabIndex = 20
        Me.btnCon.Text = "CONFIRM"
        Me.btnCon.UseVisualStyleBackColor = False
        '
        'btnPre
        '
        Me.btnPre.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPre.ForeColor = System.Drawing.Color.Purple
        Me.btnPre.Location = New System.Drawing.Point(1095, 611)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(151, 64)
        Me.btnPre.TabIndex = 21
        Me.btnPre.Text = "PREVIOUS"
        Me.btnPre.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Purple
        Me.btnAdd.Location = New System.Drawing.Point(1095, 253)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(157, 63)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(592, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "GRIEVANCE FORM"
        '
        'frmGrievance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPre)
        Me.Controls.Add(Me.btnCon)
        Me.Controls.Add(Me.cboNgo)
        Me.Controls.Add(Me.txtComplindt)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtProblem)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtComplainant)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblNgo)
        Me.Controls.Add(Me.lblCMPLNDT)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.lblAdress)
        Me.Controls.Add(Me.lblComplainant)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmGrievance"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblComplainant As System.Windows.Forms.Label
    Friend WithEvents lblAdress As System.Windows.Forms.Label
    Friend WithEvents lblProblem As System.Windows.Forms.Label
    Friend WithEvents lblCMPLNDT As System.Windows.Forms.Label
    Friend WithEvents lblNgo As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtComplainant As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtProblem As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtComplindt As System.Windows.Forms.TextBox
    Friend WithEvents cboNgo As System.Windows.Forms.ComboBox
    Friend WithEvents btnCon As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
