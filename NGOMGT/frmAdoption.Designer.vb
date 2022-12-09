<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdoption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdoption))
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTerm = New System.Windows.Forms.Button
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.txtAdopter = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtChild = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.lblNgo = New System.Windows.Forms.Label
        Me.cboNgo = New System.Windows.Forms.ComboBox
        Me.btnPre = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(67, 142)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(185, 22)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "ADOPTER'S NAME"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(42, 203)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(223, 22)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "ADOPTER'S ADDRESS"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(101, 325)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(70, 22)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "EMAIL"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(67, 452)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(149, 22)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "CHILD'S NAME"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(67, 515)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(134, 22)
        Me.lbl5.TabIndex = 4
        Me.lbl5.Text = "CHILD'S AGE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PHONE NUMBER"
        '
        'btnTerm
        '
        Me.btnTerm.BackColor = System.Drawing.Color.Transparent
        Me.btnTerm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTerm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTerm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerm.ForeColor = System.Drawing.Color.Tan
        Me.btnTerm.Location = New System.Drawing.Point(886, 203)
        Me.btnTerm.Name = "btnTerm"
        Me.btnTerm.Size = New System.Drawing.Size(158, 77)
        Me.btnTerm.TabIndex = 6
        Me.btnTerm.Text = "TERMS AND CONDITIONS"
        Me.btnTerm.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Tan
        Me.btnConfirm.Location = New System.Drawing.Point(886, 329)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(158, 54)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtAdopter
        '
        Me.txtAdopter.Location = New System.Drawing.Point(417, 142)
        Me.txtAdopter.Name = "txtAdopter"
        Me.txtAdopter.Size = New System.Drawing.Size(162, 20)
        Me.txtAdopter.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(418, 203)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(155, 20)
        Me.txtAddress.TabIndex = 10
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(418, 268)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(155, 20)
        Me.txtPhone.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(417, 329)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(153, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtChild
        '
        Me.txtChild.Location = New System.Drawing.Point(418, 452)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(152, 20)
        Me.txtChild.TabIndex = 13
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(417, 519)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(153, 20)
        Me.txtAge.TabIndex = 14
        '
        'lblNgo
        '
        Me.lblNgo.AutoSize = True
        Me.lblNgo.BackColor = System.Drawing.Color.Transparent
        Me.lblNgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgo.Location = New System.Drawing.Point(101, 387)
        Me.lblNgo.Name = "lblNgo"
        Me.lblNgo.Size = New System.Drawing.Size(56, 24)
        Me.lblNgo.TabIndex = 15
        Me.lblNgo.Text = "NGO"
        '
        'cboNgo
        '
        Me.cboNgo.FormattingEnabled = True
        Me.cboNgo.Items.AddRange(New Object() {"Trishuul", "Sahaaya", "Aasra", "Kiran", "Mouse"})
        Me.cboNgo.Location = New System.Drawing.Point(417, 392)
        Me.cboNgo.Name = "cboNgo"
        Me.cboNgo.Size = New System.Drawing.Size(153, 21)
        Me.cboNgo.TabIndex = 16
        '
        'btnPre
        '
        Me.btnPre.BackColor = System.Drawing.Color.Transparent
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPre.ForeColor = System.Drawing.Color.Tan
        Me.btnPre.Location = New System.Drawing.Point(886, 452)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(154, 62)
        Me.btnPre.TabIndex = 17
        Me.btnPre.Text = "PREVIOUS"
        Me.btnPre.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(101, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ADOPTER ID"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(417, 77)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(161, 20)
        Me.txtId.TabIndex = 19
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Tan
        Me.btnAdd.Location = New System.Drawing.Point(886, 112)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 39)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 584)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ADOPTION DATE"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(417, 584)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(153, 20)
        Me.txtDate.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Tan
        Me.Label3.Location = New System.Drawing.Point(407, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 32)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ADOPTION FORM"
        '
        'frmAdoption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1089, 650)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPre)
        Me.Controls.Add(Me.cboNgo)
        Me.Controls.Add(Me.lblNgo)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtChild)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtAdopter)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnTerm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Name = "frmAdoption"
        Me.Text = "ADOPTION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTerm As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtAdopter As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtChild As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblNgo As System.Windows.Forms.Label
    Friend WithEvents cboNgo As System.Windows.Forms.ComboBox
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
