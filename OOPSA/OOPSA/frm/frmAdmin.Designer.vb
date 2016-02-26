<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverviewStorageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbOverview = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.txtDBpwd = New System.Windows.Forms.TextBox()
        Me.lblDBNfo = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtDBUser = New System.Windows.Forms.TextBox()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.tbEmployees = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnRegAns = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tabSaleStorage = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tabRent = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabOvieStor = New System.Windows.Forms.TabPage()
        Me.tabResources = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbOverview.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.tbEmployees.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tabSaleStorage.SuspendLayout()
        Me.tabRent.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1599, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(105, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabsToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TabsToolStripMenuItem
        '
        Me.TabsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverviewToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.SalesToolStripMenuItem, Me.RentalToolStripMenuItem, Me.OverviewStorageToolStripMenuItem, Me.ResourcesToolStripMenuItem})
        Me.TabsToolStripMenuItem.Name = "TabsToolStripMenuItem"
        Me.TabsToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.TabsToolStripMenuItem.Text = "Tabs"
        '
        'OverviewToolStripMenuItem
        '
        Me.OverviewToolStripMenuItem.Name = "OverviewToolStripMenuItem"
        Me.OverviewToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.OverviewToolStripMenuItem.Text = "Overview"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'OverviewStorageToolStripMenuItem
        '
        Me.OverviewStorageToolStripMenuItem.Name = "OverviewStorageToolStripMenuItem"
        Me.OverviewStorageToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.OverviewStorageToolStripMenuItem.Text = "Overview Storage"
        '
        'ResourcesToolStripMenuItem
        '
        Me.ResourcesToolStripMenuItem.Name = "ResourcesToolStripMenuItem"
        Me.ResourcesToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ResourcesToolStripMenuItem.Text = "Resources"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(110, 6)
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 646)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1599, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbOverview)
        Me.TabControl1.Controls.Add(Me.tbEmployees)
        Me.TabControl1.Controls.Add(Me.tabSaleStorage)
        Me.TabControl1.Controls.Add(Me.tabRent)
        Me.TabControl1.Controls.Add(Me.tabOvieStor)
        Me.TabControl1.Controls.Add(Me.tabResources)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(56, 25)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1599, 618)
        Me.TabControl1.TabIndex = 2
        '
        'tbOverview
        '
        Me.tbOverview.Controls.Add(Me.SplitContainer1)
        Me.tbOverview.Location = New System.Drawing.Point(4, 29)
        Me.tbOverview.Margin = New System.Windows.Forms.Padding(4)
        Me.tbOverview.Name = "tbOverview"
        Me.tbOverview.Padding = New System.Windows.Forms.Padding(4)
        Me.tbOverview.Size = New System.Drawing.Size(1591, 585)
        Me.tbOverview.TabIndex = 0
        Me.tbOverview.Text = "Overview"
        Me.tbOverview.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuStrip3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1583, 577)
        Me.SplitContainer1.SplitterDistance = 358
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtDBpwd)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblDBNfo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtServer)
        Me.SplitContainer2.Panel1.Controls.Add(Me.MenuStrip2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtPort)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtDBUser)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtDB)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Size = New System.Drawing.Size(358, 577)
        Me.SplitContainer2.SplitterDistance = 208
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 0
        '
        'txtDBpwd
        '
        Me.txtDBpwd.Location = New System.Drawing.Point(113, 209)
        Me.txtDBpwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDBpwd.Name = "txtDBpwd"
        Me.txtDBpwd.Size = New System.Drawing.Size(228, 32)
        Me.txtDBpwd.TabIndex = 11
        Me.txtDBpwd.UseSystemPasswordChar = True
        '
        'lblDBNfo
        '
        Me.lblDBNfo.AutoSize = True
        Me.lblDBNfo.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBNfo.Location = New System.Drawing.Point(7, 48)
        Me.lblDBNfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDBNfo.Name = "lblDBNfo"
        Me.lblDBNfo.Size = New System.Drawing.Size(88, 207)
        Me.lblDBNfo.TabIndex = 10
        Me.lblDBNfo.Text = "Server:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Port:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Username:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(113, 47)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(228, 32)
        Me.txtServer.TabIndex = 6
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ChangeToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(341, 28)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(113, 130)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(228, 32)
        Me.txtPort.TabIndex = 9
        '
        'txtDBUser
        '
        Me.txtDBUser.Location = New System.Drawing.Point(113, 171)
        Me.txtDBUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDBUser.Name = "txtDBUser"
        Me.txtDBUser.Size = New System.Drawing.Size(228, 32)
        Me.txtDBUser.TabIndex = 8
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(113, 89)
        Me.txtDB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(228, 32)
        Me.txtDB.TabIndex = 7
        '
        'MenuStrip3
        '
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(1220, 24)
        Me.MenuStrip3.TabIndex = 0
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'tbEmployees
        '
        Me.tbEmployees.Controls.Add(Me.GroupBox6)
        Me.tbEmployees.Controls.Add(Me.GroupBox5)
        Me.tbEmployees.Location = New System.Drawing.Point(4, 29)
        Me.tbEmployees.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEmployees.Name = "tbEmployees"
        Me.tbEmployees.Padding = New System.Windows.Forms.Padding(4)
        Me.tbEmployees.Size = New System.Drawing.Size(1591, 585)
        Me.tbEmployees.TabIndex = 1
        Me.tbEmployees.Text = "Employees"
        Me.tbEmployees.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.TextBox7)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.TextBox6)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.btnRegAns)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 113)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(386, 388)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Registrere ny ansatt"
        '
        'btnRegAns
        '
        Me.btnRegAns.Location = New System.Drawing.Point(247, 336)
        Me.btnRegAns.Name = "btnRegAns"
        Me.btnRegAns.Size = New System.Drawing.Size(120, 31)
        Me.btnRegAns.TabIndex = 0
        Me.btnRegAns.Text = "Legg til"
        Me.btnRegAns.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ansatte"
        '
        'tabSaleStorage
        '
        Me.tabSaleStorage.Controls.Add(Me.GroupBox4)
        Me.tabSaleStorage.Controls.Add(Me.GroupBox3)
        Me.tabSaleStorage.Location = New System.Drawing.Point(4, 29)
        Me.tabSaleStorage.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSaleStorage.Name = "tabSaleStorage"
        Me.tabSaleStorage.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSaleStorage.Size = New System.Drawing.Size(1591, 585)
        Me.tabSaleStorage.TabIndex = 2
        Me.tabSaleStorage.Text = "Sales"
        Me.tabSaleStorage.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(452, 167)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sales Storage"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(855, 169)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Reports"
        '
        'tabRent
        '
        Me.tabRent.Controls.Add(Me.GroupBox2)
        Me.tabRent.Controls.Add(Me.GroupBox1)
        Me.tabRent.Location = New System.Drawing.Point(4, 29)
        Me.tabRent.Margin = New System.Windows.Forms.Padding(4)
        Me.tabRent.Name = "tabRent"
        Me.tabRent.Padding = New System.Windows.Forms.Padding(4)
        Me.tabRent.Size = New System.Drawing.Size(1591, 585)
        Me.tabRent.TabIndex = 3
        Me.tabRent.Text = "Rentals"
        Me.tabRent.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(816, 374)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rental Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(892, 138)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rental Storage"
        '
        'tabOvieStor
        '
        Me.tabOvieStor.Location = New System.Drawing.Point(4, 29)
        Me.tabOvieStor.Margin = New System.Windows.Forms.Padding(4)
        Me.tabOvieStor.Name = "tabOvieStor"
        Me.tabOvieStor.Padding = New System.Windows.Forms.Padding(4)
        Me.tabOvieStor.Size = New System.Drawing.Size(1591, 585)
        Me.tabOvieStor.TabIndex = 4
        Me.tabOvieStor.Text = "Overview Storage"
        Me.tabOvieStor.UseVisualStyleBackColor = True
        '
        'tabResources
        '
        Me.tabResources.Location = New System.Drawing.Point(4, 29)
        Me.tabResources.Margin = New System.Windows.Forms.Padding(4)
        Me.tabResources.Name = "tabResources"
        Me.tabResources.Padding = New System.Windows.Forms.Padding(4)
        Me.tabResources.Size = New System.Drawing.Size(1591, 585)
        Me.tabResources.TabIndex = 5
        Me.tabResources.Text = "Resources"
        Me.tabResources.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Brukernavn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Passord:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gjenta Passord:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fornavn:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Etternavn:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Telefon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Epost:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Adresse:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Bursdag:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 32)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 260)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 32)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(175, 298)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 32)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(175, 222)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 32)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(175, 184)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 32)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(175, 146)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(192, 32)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(175, 108)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(192, 32)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(175, 70)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(192, 32)
        Me.TextBox8.TabIndex = 17
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1599, 668)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAdmin"
        Me.Text = "frmAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbOverview.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.tbEmployees.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tabSaleStorage.ResumeLayout(False)
        Me.tabRent.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbOverview As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents tbEmployees As TabPage
    Friend WithEvents lblDBNfo As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtDBUser As TextBox
    Friend WithEvents txtDB As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtDBpwd As TextBox
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents tabSaleStorage As TabPage
    Friend WithEvents tabRent As TabPage
    Friend WithEvents tabOvieStor As TabPage
    Friend WithEvents tabResources As TabPage
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverviewStorageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnRegAns As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
