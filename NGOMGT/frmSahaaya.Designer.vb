<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSahaaya
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSahaaya))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.WHOWEAREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HOWCANYOUHELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOLUNTEERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SPONSORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADOPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WHOWEAREToolStripMenuItem, Me.WToolStripMenuItem, Me.HOWCANYOUHELPToolStripMenuItem, Me.EXITToolStripMenuItem, Me.EXITToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WHOWEAREToolStripMenuItem
        '
        Me.WHOWEAREToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WHOWEAREToolStripMenuItem.Image = CType(resources.GetObject("WHOWEAREToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WHOWEAREToolStripMenuItem.Name = "WHOWEAREToolStripMenuItem"
        Me.WHOWEAREToolStripMenuItem.Size = New System.Drawing.Size(137, 21)
        Me.WHOWEAREToolStripMenuItem.Text = "WHO WE ARE"
        '
        'WToolStripMenuItem
        '
        Me.WToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WToolStripMenuItem.Image = CType(resources.GetObject("WToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WToolStripMenuItem.Name = "WToolStripMenuItem"
        Me.WToolStripMenuItem.Size = New System.Drawing.Size(136, 21)
        Me.WToolStripMenuItem.Text = "WHAT WE DO"
        '
        'HOWCANYOUHELPToolStripMenuItem
        '
        Me.HOWCANYOUHELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VOLUNTEERToolStripMenuItem, Me.SPONSORToolStripMenuItem, Me.ADOPTIONToolStripMenuItem})
        Me.HOWCANYOUHELPToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOWCANYOUHELPToolStripMenuItem.Image = CType(resources.GetObject("HOWCANYOUHELPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HOWCANYOUHELPToolStripMenuItem.Name = "HOWCANYOUHELPToolStripMenuItem"
        Me.HOWCANYOUHELPToolStripMenuItem.Size = New System.Drawing.Size(190, 21)
        Me.HOWCANYOUHELPToolStripMenuItem.Text = "HOW CAN YOU HELP"
        '
        'VOLUNTEERToolStripMenuItem
        '
        Me.VOLUNTEERToolStripMenuItem.Image = CType(resources.GetObject("VOLUNTEERToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VOLUNTEERToolStripMenuItem.Name = "VOLUNTEERToolStripMenuItem"
        Me.VOLUNTEERToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VOLUNTEERToolStripMenuItem.Text = "ADOPTION"
        '
        'SPONSORToolStripMenuItem
        '
        Me.SPONSORToolStripMenuItem.Image = CType(resources.GetObject("SPONSORToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SPONSORToolStripMenuItem.Name = "SPONSORToolStripMenuItem"
        Me.SPONSORToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SPONSORToolStripMenuItem.Text = "SPONSORSHIP"
        '
        'ADOPTIONToolStripMenuItem
        '
        Me.ADOPTIONToolStripMenuItem.Image = CType(resources.GetObject("ADOPTIONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ADOPTIONToolStripMenuItem.Name = "ADOPTIONToolStripMenuItem"
        Me.ADOPTIONToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ADOPTIONToolStripMenuItem.Text = "VOLUNTEERING"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem.Image = CType(resources.GetObject("EXITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(127, 21)
        Me.EXITToolStripMenuItem.Text = "GRIEVANCE"
        '
        'EXITToolStripMenuItem1
        '
        Me.EXITToolStripMenuItem1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem1.Image = CType(resources.GetObject("EXITToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem1.Name = "EXITToolStripMenuItem1"
        Me.EXITToolStripMenuItem1.Size = New System.Drawing.Size(69, 21)
        Me.EXITToolStripMenuItem1.Text = "EXIT"
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(157, 633)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(148, 52)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(157, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(588, 106)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(613, 495)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(588, 118)
        Me.DataGridView2.TabIndex = 3
        '
        'frmSahaaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSahaaya"
        Me.Text = "SAHAAYA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents WHOWEAREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HOWCANYOUHELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOLUNTEERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SPONSORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADOPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
