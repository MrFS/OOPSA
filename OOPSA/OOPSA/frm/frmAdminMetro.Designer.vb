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
        Me.tbSalg = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.tbAnsatte = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.ActiveTabColor = System.Drawing.Color.LightGray
        Me.TabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(892, 433)
        Me.TabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TabControlAdv1.BorderWidth = 2
        Me.TabControlAdv1.Controls.Add(Me.tbOverview)
        Me.TabControlAdv1.Controls.Add(Me.tbAnsatte)
        Me.TabControlAdv1.Controls.Add(Me.tbSalg)
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
        Me.TabControlAdv1.Size = New System.Drawing.Size(892, 433)
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
        Me.tbOverview.Size = New System.Drawing.Size(785, 429)
        Me.tbOverview.TabIndex = 1
        Me.tbOverview.ThemesEnabled = True
        '
        'tbSalg
        '
        Me.tbSalg.Image = Global.OOPSA.My.Resources.Resources.tbSalg1
        Me.tbSalg.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbSalg.Location = New System.Drawing.Point(105, 2)
        Me.tbSalg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSalg.Name = "tbSalg"
        Me.tbSalg.ShowCloseButton = True
        Me.tbSalg.Size = New System.Drawing.Size(785, 429)
        Me.tbSalg.TabIndex = 3
        Me.tbSalg.ThemesEnabled = True
        '
        'tbAnsatte
        '
        Me.tbAnsatte.Image = Global.OOPSA.My.Resources.Resources.tbAnsatte
        Me.tbAnsatte.ImageSize = New System.Drawing.Size(48, 48)
        Me.tbAnsatte.Location = New System.Drawing.Point(105, 2)
        Me.tbAnsatte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAnsatte.Name = "tbAnsatte"
        Me.tbAnsatte.ShowCloseButton = True
        Me.tbAnsatte.Size = New System.Drawing.Size(785, 429)
        Me.tbAnsatte.TabIndex = 2
        Me.tbAnsatte.ThemesEnabled = True
        '
        'frmAdminMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.DagligLeder
        CaptionImage1.Name = "capDagligLeder"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(892, 433)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmAdminMetro"
        Me.ShowIcon = False
        Me.Text = "Daglig Leder | OOPSA - BADR08"
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents tbOverview As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tbAnsatte As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents tbSalg As Syncfusion.Windows.Forms.Tools.TabPageAdv
End Class
