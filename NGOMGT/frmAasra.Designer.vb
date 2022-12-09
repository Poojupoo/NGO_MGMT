<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAasra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAasra))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.WHOWEAREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WHATWEDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HOWCANYOUHELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADOPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SPONSORSHIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOLUNTEERINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GRIEVANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WHOWEAREToolStripMenuItem, Me.WHATWEDOToolStripMenuItem, Me.HOWCANYOUHELPToolStripMenuItem, Me.GRIEVANCEToolStripMenuItem, Me.EXITToolStripMenuItem})
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
        'WHATWEDOToolStripMenuItem
        '
        Me.WHATWEDOToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WHATWEDOToolStripMenuItem.Image = CType(resources.GetObject("WHATWEDOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WHATWEDOToolStripMenuItem.Name = "WHATWEDOToolStripMenuItem"
        Me.WHATWEDOToolStripMenuItem.Size = New System.Drawing.Size(136, 21)
        Me.WHATWEDOToolStripMenuItem.Text = "WHAT WE DO"
        '
        'HOWCANYOUHELPToolStripMenuItem
        '
        Me.HOWCANYOUHELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADOPTIONToolStripMenuItem, Me.SPONSORSHIPToolStripMenuItem, Me.VOLUNTEERINGToolStripMenuItem})
        Me.HOWCANYOUHELPToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOWCANYOUHELPToolStripMenuItem.Image = CType(resources.GetObject("HOWCANYOUHELPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HOWCANYOUHELPToolStripMenuItem.Name = "HOWCANYOUHELPToolStripMenuItem"
        Me.HOWCANYOUHELPToolStripMenuItem.Size = New System.Drawing.Size(190, 21)
        Me.HOWCANYOUHELPToolStripMenuItem.Text = "HOW CAN YOU HELP"
        '
        'ADOPTIONToolStripMenuItem
        '
        Me.ADOPTIONToolStripMenuItem.Image = CType(resources.GetObject("ADOPTIONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ADOPTIONToolStripMenuItem.Name = "ADOPTIONToolStripMenuItem"
        Me.ADOPTIONToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ADOPTIONToolStripMenuItem.Text = "ADOPTION"
        '
        'SPONSORSHIPToolStripMenuItem
        '
        Me.SPONSORSHIPToolStripMenuItem.Image = CType(resources.GetObject("SPONSORSHIPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SPONSORSHIPToolStripMenuItem.Name = "SPONSORSHIPToolStripMenuItem"
        Me.SPONSORSHIPToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SPONSORSHIPToolStripMenuItem.Text = "SPONSORSHIP"
        '
        'VOLUNTEERINGToolStripMenuItem
        '
        Me.VOLUNTEERINGToolStripMenuItem.Image = CType(resources.GetObject("VOLUNTEERINGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VOLUNTEERINGToolStripMenuItem.Name = "VOLUNTEERINGToolStripMenuItem"
        Me.VOLUNTEERINGToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VOLUNTEERINGToolStripMenuItem.Text = "VOLUNTEERING"
        '
        'GRIEVANCEToolStripMenuItem
        '
        Me.GRIEVANCEToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIEVANCEToolStripMenuItem.Image = CType(resources.GetObject("GRIEVANCEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GRIEVANCEToolStripMenuItem.Name = "GRIEVANCEToolStripMenuItem"
        Me.GRIEVANCEToolStripMenuItem.Size = New System.Drawing.Size(127, 21)
        Me.GRIEVANCEToolStripMenuItem.Text = "GRIEVANCE"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem.Image = CType(resources.GetObject("EXITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(1091, 647)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(135, 45)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(639, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 119)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(159, 495)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(615, 121)
        Me.DataGridView2.TabIndex = 3
        '
        'frmAasra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1366, 746)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAasra"
        Me.Text = "AASRA"
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
    Friend WithEvents WHATWEDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HOWCANYOUHELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADOPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SPONSORSHIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOLUNTEERINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRIEVANCEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
