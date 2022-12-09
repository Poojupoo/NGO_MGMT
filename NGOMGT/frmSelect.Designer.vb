<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelect))
        Me.lblSelect = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.optMouse = New System.Windows.Forms.RadioButton
        Me.optKiran = New System.Windows.Forms.RadioButton
        Me.optSahaaya = New System.Windows.Forms.RadioButton
        Me.optAasra = New System.Windows.Forms.RadioButton
        Me.optTrishuul = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSelect.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(386, 42)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(224, 28)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Text = "SELECT THE NGO"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(164, 443)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 36)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(391, 444)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 35)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 44)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "APPROACH"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optMouse)
        Me.Panel1.Controls.Add(Me.optKiran)
        Me.Panel1.Controls.Add(Me.optSahaaya)
        Me.Panel1.Controls.Add(Me.optAasra)
        Me.Panel1.Controls.Add(Me.optTrishuul)
        Me.Panel1.Location = New System.Drawing.Point(376, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 262)
        Me.Panel1.TabIndex = 8
        '
        'optMouse
        '
        Me.optMouse.AutoSize = True
        Me.optMouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMouse.Location = New System.Drawing.Point(15, 216)
        Me.optMouse.Name = "optMouse"
        Me.optMouse.Size = New System.Drawing.Size(102, 28)
        Me.optMouse.TabIndex = 4
        Me.optMouse.TabStop = True
        Me.optMouse.Text = "MOUSE"
        Me.optMouse.UseVisualStyleBackColor = True
        '
        'optKiran
        '
        Me.optKiran.AutoSize = True
        Me.optKiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optKiran.Location = New System.Drawing.Point(15, 170)
        Me.optKiran.Name = "optKiran"
        Me.optKiran.Size = New System.Drawing.Size(89, 28)
        Me.optKiran.TabIndex = 3
        Me.optKiran.TabStop = True
        Me.optKiran.Text = "KIRAN"
        Me.optKiran.UseVisualStyleBackColor = True
        '
        'optSahaaya
        '
        Me.optSahaaya.AutoSize = True
        Me.optSahaaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSahaaya.Location = New System.Drawing.Point(15, 124)
        Me.optSahaaya.Name = "optSahaaya"
        Me.optSahaaya.Size = New System.Drawing.Size(125, 28)
        Me.optSahaaya.TabIndex = 2
        Me.optSahaaya.TabStop = True
        Me.optSahaaya.Text = "SAHAAYA"
        Me.optSahaaya.UseVisualStyleBackColor = True
        '
        'optAasra
        '
        Me.optAasra.AutoSize = True
        Me.optAasra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAasra.Location = New System.Drawing.Point(15, 80)
        Me.optAasra.Name = "optAasra"
        Me.optAasra.Size = New System.Drawing.Size(97, 28)
        Me.optAasra.TabIndex = 1
        Me.optAasra.TabStop = True
        Me.optAasra.Text = "AASRA"
        Me.optAasra.UseVisualStyleBackColor = True
        '
        'optTrishuul
        '
        Me.optTrishuul.AutoSize = True
        Me.optTrishuul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTrishuul.Location = New System.Drawing.Point(15, 35)
        Me.optTrishuul.Name = "optTrishuul"
        Me.optTrishuul.Size = New System.Drawing.Size(127, 28)
        Me.optTrishuul.TabIndex = 0
        Me.optTrishuul.TabStop = True
        Me.optTrishuul.Text = "TRISHUUL"
        Me.optTrishuul.UseVisualStyleBackColor = True
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(686, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSelect)
        Me.Name = "frmSelect"
        Me.Text = "SELECT THE NGO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents optMouse As System.Windows.Forms.RadioButton
    Friend WithEvents optKiran As System.Windows.Forms.RadioButton
    Friend WithEvents optSahaaya As System.Windows.Forms.RadioButton
    Friend WithEvents optAasra As System.Windows.Forms.RadioButton
    Friend WithEvents optTrishuul As System.Windows.Forms.RadioButton
End Class
