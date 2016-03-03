<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsole))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OpenConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetTickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseResumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitEnvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripOnline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripConnected = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripServerLoad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstConsoleOverview = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lstConsole = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstDir = New System.Windows.Forms.ListBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lstRecent = New System.Windows.Forms.ListBox()
        Me.tmConsole = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 459)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(944, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripDropDownButton1, Me.ToolStripComboBox1, Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripLabel4, Me.ToolStripProgressBar1, Me.ToolStripLabel5, Me.ToolStripProgressBar2, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripSeparator5, Me.ToolStripSeparator7, Me.ToolStripSeparator6, Me.ToolStripLabel7, Me.ToolStripOnline, Me.ToolStripLabel8, Me.ToolStripConnected, Me.ToolStripLabel9, Me.ToolStripServerLoad, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(944, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = "tmConsole"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripLabel2.Text = "Application Uptime: &&"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenConfigToolStripMenuItem, Me.ToolStripSeparator8, Me.CommandsToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ToolStripSeparator9, Me.CloseToolStripMenuItem, Me.QuitEnvToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'OpenConfigToolStripMenuItem
        '
        Me.OpenConfigToolStripMenuItem.Name = "OpenConfigToolStripMenuItem"
        Me.OpenConfigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenConfigToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.OpenConfigToolStripMenuItem.Text = "Open Config"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(182, 6)
        '
        'CommandsToolStripMenuItem
        '
        Me.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem"
        Me.CommandsToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CommandsToolStripMenuItem.Text = "Commands"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.TickToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'TickToolStripMenuItem
        '
        Me.TickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetTickToolStripMenuItem, Me.PauseResumeToolStripMenuItem})
        Me.TickToolStripMenuItem.Name = "TickToolStripMenuItem"
        Me.TickToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.TickToolStripMenuItem.Text = "Tick"
        '
        'SetTickToolStripMenuItem
        '
        Me.SetTickToolStripMenuItem.Name = "SetTickToolStripMenuItem"
        Me.SetTickToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SetTickToolStripMenuItem.Text = "Set Tick"
        '
        'PauseResumeToolStripMenuItem
        '
        Me.PauseResumeToolStripMenuItem.Name = "PauseResumeToolStripMenuItem"
        Me.PauseResumeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.PauseResumeToolStripMenuItem.Text = "Pause | Resume"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(182, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'QuitEnvToolStripMenuItem
        '
        Me.QuitEnvToolStripMenuItem.Name = "QuitEnvToolStripMenuItem"
        Me.QuitEnvToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitEnvToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.QuitEnvToolStripMenuItem.Text = "Quit Env"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"help", "help /gen", "help /all", "reset", "reset /gen", "reset /settings", "reset /all", "class", "class /gen", "class /define", "class /properties"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripLabel3.Text = "Quick Commands:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel4.Text = "CPU:"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripProgressBar1.Step = 1
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel5.Text = "RAM:"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(50, 22)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel7.Text = "Online:"
        '
        'ToolStripOnline
        '
        Me.ToolStripOnline.BackColor = System.Drawing.Color.Red
        Me.ToolStripOnline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripOnline.Enabled = False
        Me.ToolStripOnline.Image = CType(resources.GetObject("ToolStripOnline.Image"), System.Drawing.Image)
        Me.ToolStripOnline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripOnline.Name = "ToolStripOnline"
        Me.ToolStripOnline.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripOnline.Text = "ToolStripLabel6"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel8.Text = "Connected:"
        '
        'ToolStripConnected
        '
        Me.ToolStripConnected.BackColor = System.Drawing.Color.Red
        Me.ToolStripConnected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripConnected.Enabled = False
        Me.ToolStripConnected.Image = CType(resources.GetObject("ToolStripConnected.Image"), System.Drawing.Image)
        Me.ToolStripConnected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripConnected.Name = "ToolStripConnected"
        Me.ToolStripConnected.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripConnected.Text = "ToolStripButton1"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel9.Text = "Quality:"
        '
        'ToolStripServerLoad
        '
        Me.ToolStripServerLoad.BackColor = System.Drawing.Color.Red
        Me.ToolStripServerLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripServerLoad.Enabled = False
        Me.ToolStripServerLoad.Image = CType(resources.GetObject("ToolStripServerLoad.Image"), System.Drawing.Image)
        Me.ToolStripServerLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripServerLoad.Name = "ToolStripServerLoad"
        Me.ToolStripServerLoad.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripServerLoad.Text = "ToolStripButton2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(68, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(944, 434)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstConsoleOverview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(936, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Overview"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstConsoleOverview
        '
        Me.lstConsoleOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstConsoleOverview.Enabled = False
        Me.lstConsoleOverview.FormattingEnabled = True
        Me.lstConsoleOverview.Location = New System.Drawing.Point(3, 3)
        Me.lstConsoleOverview.Name = "lstConsoleOverview"
        Me.lstConsoleOverview.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstConsoleOverview.Size = New System.Drawing.Size(930, 390)
        Me.lstConsoleOverview.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.lstConsole)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Size = New System.Drawing.Size(936, 398)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Console"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(2, 376)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(932, 20)
        Me.TextBox1.TabIndex = 2
        '
        'lstConsole
        '
        Me.lstConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstConsole.FormattingEnabled = True
        Me.lstConsole.Location = New System.Drawing.Point(2, 2)
        Me.lstConsole.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstConsole.Name = "lstConsole"
        Me.lstConsole.Size = New System.Drawing.Size(932, 394)
        Me.lstConsole.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstDir)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.lstRecent)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(936, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Misc"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstDir
        '
        Me.lstDir.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstDir.FormattingEnabled = True
        Me.lstDir.Location = New System.Drawing.Point(123, 3)
        Me.lstDir.Name = "lstDir"
        Me.lstDir.Size = New System.Drawing.Size(473, 392)
        Me.lstDir.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(767, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'lstRecent
        '
        Me.lstRecent.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstRecent.FormattingEnabled = True
        Me.lstRecent.Location = New System.Drawing.Point(3, 3)
        Me.lstRecent.Name = "lstRecent"
        Me.lstRecent.Size = New System.Drawing.Size(120, 392)
        Me.lstRecent.TabIndex = 0
        '
        'tmConsole
        '
        Me.tmConsole.Interval = 500
        '
        'frmConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 481)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsole"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tmConsole As Timer
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lstConsoleOverview As ListBox
    Friend WithEvents lstRecent As ListBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents OpenConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents CommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetTickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseResumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitEnvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstDir As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lstConsole As ListBox
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripOnline As ToolStripButton
    Friend WithEvents ToolStripLabel8 As ToolStripLabel
    Friend WithEvents ToolStripLabel9 As ToolStripLabel
    Friend WithEvents ToolStripServerLoad As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripConnected As ToolStripButton
End Class
