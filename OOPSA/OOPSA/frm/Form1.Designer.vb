<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.GridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        Me.TabPageAdv2.SuspendLayout()
        CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(685, 261)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv1)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAdv1.FocusOnTabClick = False
        Me.TabControlAdv1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.Size = New System.Drawing.Size(685, 261)
        Me.TabControlAdv1.TabGap = 10
        Me.TabControlAdv1.TabIndex = 1
        Me.TabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.Controls.Add(Me.DataGridView1)
        Me.TabPageAdv1.Image = Nothing
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv1.Location = New System.Drawing.Point(1, 22)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(682, 237)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = "TabPageAdv1"
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.Controls.Add(Me.GridDataBoundGrid1)
        Me.TabPageAdv2.Image = Nothing
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 22)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(682, 237)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "TabPageAdv2"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'GridDataBoundGrid1
        '
        Me.GridDataBoundGrid1.AllowDragSelectedCols = True
        Me.GridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.GridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Black
        Me.GridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
        Me.GridDataBoundGrid1.Name = "GridDataBoundGrid1"
        Me.GridDataBoundGrid1.OptimizeInsertRemoveCells = True
        Me.GridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.GridDataBoundGrid1.Size = New System.Drawing.Size(682, 237)
        Me.GridDataBoundGrid1.SmartSizeBox = False
        Me.GridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.GridDataBoundGrid1.TabIndex = 0
        Me.GridDataBoundGrid1.Text = "GridDataBoundGrid1"
        Me.GridDataBoundGrid1.ThemesEnabled = True
        Me.GridDataBoundGrid1.UseListChangedEvent = True
        Me.GridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 261)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.TabPageAdv2.ResumeLayout(False)
        CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents GridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
End Class
