<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrishuul
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrishuul))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.WHOWEAREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HOWCANWEHELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADOPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SPONSORSHIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VOLUNTEERINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HOWCANWEHELPToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
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
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WHOWEAREToolStripMenuItem, Me.ABOUTUSToolStripMenuItem, Me.HOWCANWEHELPToolStripMenuItem, Me.HOWCANWEHELPToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(1090, 29)
        Me.MenuStrip1.TabIndex = 1
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
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABOUTUSToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABOUTUSToolStripMenuItem.Image = CType(resources.GetObject("ABOUTUSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(136, 21)
        Me.ABOUTUSToolStripMenuItem.Text = "WHAT WE DO"
        '
        'HOWCANWEHELPToolStripMenuItem
        '
        Me.HOWCANWEHELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADOPTIONToolStripMenuItem, Me.SPONSORSHIPToolStripMenuItem, Me.VOLUNTEERINGToolStripMenuItem})
        Me.HOWCANWEHELPToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOWCANWEHELPToolStripMenuItem.Image = CType(resources.GetObject("HOWCANWEHELPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HOWCANWEHELPToolStripMenuItem.Name = "HOWCANWEHELPToolStripMenuItem"
        Me.HOWCANWEHELPToolStripMenuItem.Size = New System.Drawing.Size(190, 21)
        Me.HOWCANWEHELPToolStripMenuItem.Text = "HOW CAN YOU HELP"
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
        'HOWCANWEHELPToolStripMenuItem1
        '
        Me.HOWCANWEHELPToolStripMenuItem1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOWCANWEHELPToolStripMenuItem1.Image = CType(resources.GetObject("HOWCANWEHELPToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HOWCANWEHELPToolStripMenuItem1.Name = "HOWCANWEHELPToolStripMenuItem1"
        Me.HOWCANWEHELPToolStripMenuItem1.Size = New System.Drawing.Size(127, 21)
        Me.HOWCANWEHELPToolStripMenuItem1.Text = "GRIEVANCE"
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
        Me.btnPrevious.Location = New System.Drawing.Point(707, 71)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(124, 46)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(430, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(629, 126)
        Me.DataGridView1.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(430, 467)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(629, 113)
        Me.DataGridView2.TabIndex = 4
        '
        'frmTrishuul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1090, 502)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmTrishuul"
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
    Friend WithEvents HOWCANWEHELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADOPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SPONSORSHIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOLUNTEERINGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HOWCANWEHELPToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents ABOUTUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
