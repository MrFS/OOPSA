<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminMetro
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Dim CaptionImage1 As Syncfusion.Windows.Forms.CaptionImage = New Syncfusion.Windows.Forms.CaptionImage()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.tbOverview = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tbLager = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tbAnsatte = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tbSalg = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tbSettings = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tabSettings = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.tbAnsatte.SuspendLayout()
        Me.tbSettings.SuspendLayout()
        CType(Me.tabSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSettings.SuspendLayout()
        CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.ActiveTabColor = System.Drawing.Color.LightGray
        Me.TabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(927, 412)
        Me.TabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TabControlAdv1.BorderWidth = 2
        Me.TabControlAdv1.Controls.Add(Me.tbOverview)
        Me.TabControlAdv1.Controls.Add(Me.tbAnsatte)
        Me.TabControlAdv1.Controls.Add(Me.tbLager)
        Me.TabControlAdv1.Controls.Add(Me.tbSalg)
        Me.TabControlAdv1.Controls.Add(Me.tbSettings)
        Me.TabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAdv1.FixedSingleBorderColor = System.Drawing.SystemColors.Window
        Me.TabControlAdv1.FocusOnTabClick = False
        Me.TabControlAdv1.InactiveTabColor = System.Drawing.Color.Transparent
        Me.TabControlAdv1.ItemSize = New System.Drawing.Size(104, 48)
        Me.TabControlAdv1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAdv1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.RotateTextWhenVertical = True
        Me.TabControlAdv1.ShowToolTips = True
        Me.TabControlAdv1.Size = New System.Drawing.Size(927, 412)
        Me.TabControlAdv1.TabIndex = 0
        Me.TabControlAdv1.TabPanelBackColor = System.Drawing.Color.Transparent
        Me.TabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererMetro)
        Me.TabControlAdv1.ThemesEnabled = True
        '
        'tbOverview
        '
        Me.tbOverview.BackColor = System.Drawing.Color.Transparent
        Me.tbOverview.Image = Global.OOPSA.My.Resources.Resources.tbOverview
        Me.tbOverview.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbOverview.Location = New System.Drawing.Point(105, 2)
        Me.tbOverview.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOverview.Name = "tbOverview"
        Me.tbOverview.ShowCloseButton = True
        Me.tbOverview.Size = New System.Drawing.Size(820, 408)
        Me.tbOverview.TabIndex = 1
        Me.tbOverview.ThemesEnabled = True
        '
        'tbLager
        '
        Me.tbLager.Image = Global.OOPSA.My.Resources.Resources.tbLager
        Me.tbLager.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbLager.Location = New System.Drawing.Point(105, 2)
        Me.tbLager.Name = "tbLager"
        Me.tbLager.ShowCloseButton = True
        Me.tbLager.Size = New System.Drawing.Size(820, 408)
        Me.tbLager.TabIndex = 4
        Me.tbLager.ThemesEnabled = True
        '
        'tbAnsatte
        '
        Me.tbAnsatte.Controls.Add(Me.GridDataBoundGrid1)
        Me.tbAnsatte.Controls.Add(Me.Splitter1)
        Me.tbAnsatte.Image = Global.OOPSA.My.Resources.Resources.tbAnsatte
        Me.tbAnsatte.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbAnsatte.Location = New System.Drawing.Point(105, 2)
        Me.tbAnsatte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAnsatte.Name = "tbAnsatte"
        Me.tbAnsatte.ShowCloseButton = True
        Me.tbAnsatte.Size = New System.Drawing.Size(820, 408)
        Me.tbAnsatte.TabIndex = 2
        Me.tbAnsatte.ThemesEnabled = True
        '
        'tbSalg
        '
        Me.tbSalg.Image = Global.OOPSA.My.Resources.Resources.tbSalg1
        Me.tbSalg.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbSalg.Location = New System.Drawing.Point(105, 2)
        Me.tbSalg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSalg.Name = "tbSalg"
        Me.tbSalg.ShowCloseButton = True
        Me.tbSalg.Size = New System.Drawing.Size(820, 408)
        Me.tbSalg.TabIndex = 3
        Me.tbSalg.ThemesEnabled = True
        '
        'tbSettings
        '
        Me.tbSettings.Controls.Add(Me.tabSettings)
        Me.tbSettings.Image = Global.OOPSA.My.Resources.Resources.tbSettings
        Me.tbSettings.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbSettings.Location = New System.Drawing.Point(105, 2)
        Me.tbSettings.Name = "tbSettings"
        Me.tbSettings.ShowCloseButton = True
        Me.tbSettings.Size = New System.Drawing.Size(820, 408)
        Me.tbSettings.TabIndex = 5
        Me.tbSettings.ThemesEnabled = True
        '
        'tabSettings
        '
        Me.tabSettings.ActiveTabColor = System.Drawing.Color.Transparent
        Me.tabSettings.BeforeTouchSize = New System.Drawing.Size(820, 408)
        Me.tabSettings.Controls.Add(Me.TabPageAdv1)
        Me.tabSettings.Controls.Add(Me.TabPageAdv2)
        Me.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSettings.InactiveTabColor = System.Drawing.Color.Transparent
        Me.tabSettings.Location = New System.Drawing.Point(0, 0)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(820, 408)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.TabPanelBackColor = System.Drawing.Color.Transparent
        Me.tabSettings.ThemesEnabled = True
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.Image = Nothing
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv1.Location = New System.Drawing.Point(3, 35)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(813, 369)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = "TabPageAdv1"
        Me.TabPageAdv1.ThemesEnabled = True
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.Image = Nothing
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(3, 35)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(813, 369)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "TabPageAdv2"
        Me.TabPageAdv2.ThemesEnabled = True
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Silver
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(160, 408)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'GridDataBoundGrid1
        '
        Me.GridDataBoundGrid1.AllowDragSelectedCols = True
        Me.GridDataBoundGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.GridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.GridDataBoundGrid1.Location = New System.Drawing.Point(160, 0)
        Me.GridDataBoundGrid1.Name = "GridDataBoundGrid1"
        Me.GridDataBoundGrid1.OptimizeInsertRemoveCells = True
        Me.GridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.GridDataBoundGrid1.Size = New System.Drawing.Size(660, 408)
        Me.GridDataBoundGrid1.SmartSizeBox = False
        Me.GridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.GridDataBoundGrid1.TabIndex = 1
        Me.GridDataBoundGrid1.Text = "GridDataBoundGrid1"
        Me.GridDataBoundGrid1.ThemesEnabled = True
        Me.GridDataBoundGrid1.UseListChangedEvent = True
        Me.GridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
        '
        'frmAdminMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.DagligLeder
        CaptionImage1.Name = "capDagligLeder"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(927, 412)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmAdminMetro"
        Me.ShowIcon = False
        Me.Text = "Daglig Leder | OOPSA - BADR08"
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.tbAnsatte.ResumeLayout(False)
        Me.tbSettings.ResumeLayout(False)
        CType(Me.tabSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSettings.ResumeLayout(False)
        CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents tbOverview As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tbAnsatte As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tbSalg As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tbLager As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tbSettings As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents GridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents tabSettings As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
End Class
