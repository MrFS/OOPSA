<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsrChngPW
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Dim CaptionImage1 As Syncfusion.Windows.Forms.CaptionImage = New Syncfusion.Windows.Forms.CaptionImage()
        Me.chsEmpl = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.cmbAnsatte = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.lblOldPW = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        CType(Me.cmbAnsatte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chsEmpl
        '
        Me.chsEmpl.Location = New System.Drawing.Point(12, 40)
        Me.chsEmpl.Name = "chsEmpl"
        Me.chsEmpl.Size = New System.Drawing.Size(89, 21)
        Me.chsEmpl.TabIndex = 0
        Me.chsEmpl.Text = "Velg ansatt:"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Size = New System.Drawing.Size(501, 40)
        Me.ToolStripEx1.TabIndex = 1
        Me.ToolStripEx1.Text = "Endre passord for dine ansatte"
        Me.ToolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro
        '
        'cmbAnsatte
        '
        Me.cmbAnsatte.BackColor = System.Drawing.Color.White
        Me.cmbAnsatte.BeforeTouchSize = New System.Drawing.Size(153, 29)
        Me.cmbAnsatte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnsatte.Location = New System.Drawing.Point(107, 40)
        Me.cmbAnsatte.Name = "cmbAnsatte"
        Me.cmbAnsatte.Size = New System.Drawing.Size(153, 29)
        Me.cmbAnsatte.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cmbAnsatte.TabIndex = 2
        Me.cmbAnsatte.Text = "Dine ansatte"
        '
        'lblOldPW
        '
        Me.lblOldPW.Location = New System.Drawing.Point(12, 82)
        Me.lblOldPW.Name = "lblOldPW"
        Me.lblOldPW.Size = New System.Drawing.Size(135, 21)
        Me.lblOldPW.TabIndex = 3
        Me.lblOldPW.Text = "Gammelt Passord:"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(12, 113)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(101, 21)
        Me.AutoLabel2.TabIndex = 4
        Me.AutoLabel2.Text = "Nytt Passord:"
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(12, 144)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(150, 21)
        Me.AutoLabel3.TabIndex = 5
        Me.AutoLabel3.Text = "Gjenta Nytt Passord:"
        '
        'frmUsrChngPW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.userSettings
        CaptionImage1.Name = "CaptionImage1"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(501, 276)
        Me.Controls.Add(Me.AutoLabel3)
        Me.Controls.Add(Me.AutoLabel2)
        Me.Controls.Add(Me.lblOldPW)
        Me.Controls.Add(Me.cmbAnsatte)
        Me.Controls.Add(Me.ToolStripEx1)
        Me.Controls.Add(Me.chsEmpl)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmUsrChngPW"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ShowMaximizeBox = False
        Me.ShowMinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Endre passord for ansatt"
        CType(Me.cmbAnsatte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chsEmpl As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents cmbAnsatte As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents lblOldPW As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
