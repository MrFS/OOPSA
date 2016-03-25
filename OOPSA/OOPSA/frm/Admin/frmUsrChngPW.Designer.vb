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
        Me.components = New System.ComponentModel.Container()
        Dim CaptionImage1 As Syncfusion.Windows.Forms.CaptionImage = New Syncfusion.Windows.Forms.CaptionImage()
        Me.chsEmpl = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.cmbAnsatte = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.lblOldPW = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.txtOldPw = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtNewPw = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtRepNewPw = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.chkViewPW = New System.Windows.Forms.CheckBox()
        Me.btnChangePW = New Syncfusion.Windows.Forms.ButtonAdv()
        CType(Me.cmbAnsatte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldPw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewPw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepNewPw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chsEmpl
        '
        Me.chsEmpl.Location = New System.Drawing.Point(12, 48)
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
        Me.ToolStripEx1.Size = New System.Drawing.Size(340, 40)
        Me.ToolStripEx1.TabIndex = 1
        Me.ToolStripEx1.Text = "Endre passord for dine ansatte"
        Me.ToolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro
        '
        'cmbAnsatte
        '
        Me.cmbAnsatte.BackColor = System.Drawing.Color.White
        Me.cmbAnsatte.BeforeTouchSize = New System.Drawing.Size(230, 29)
        Me.cmbAnsatte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnsatte.Location = New System.Drawing.Point(107, 40)
        Me.cmbAnsatte.Name = "cmbAnsatte"
        Me.cmbAnsatte.Size = New System.Drawing.Size(230, 29)
        Me.cmbAnsatte.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cmbAnsatte.TabIndex = 2
        Me.cmbAnsatte.Text = "Dine ansatte"
        '
        'lblOldPW
        '
        Me.lblOldPW.Location = New System.Drawing.Point(12, 83)
        Me.lblOldPW.Name = "lblOldPW"
        Me.lblOldPW.Size = New System.Drawing.Size(135, 21)
        Me.lblOldPW.TabIndex = 3
        Me.lblOldPW.Text = "Gammelt Passord:"
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(12, 118)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(101, 21)
        Me.AutoLabel2.TabIndex = 4
        Me.AutoLabel2.Text = "Nytt Passord:"
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Location = New System.Drawing.Point(12, 153)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(150, 21)
        Me.AutoLabel3.TabIndex = 5
        Me.AutoLabel3.Text = "Gjenta Nytt Passord:"
        '
        'txtOldPw
        '
        Me.txtOldPw.BeforeTouchSize = New System.Drawing.Size(151, 29)
        Me.txtOldPw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOldPw.Location = New System.Drawing.Point(186, 75)
        Me.txtOldPw.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtOldPw.Name = "txtOldPw"
        Me.txtOldPw.Size = New System.Drawing.Size(151, 29)
        Me.txtOldPw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtOldPw.TabIndex = 6
        Me.txtOldPw.Text = "TextBoxExt1"
        '
        'txtNewPw
        '
        Me.txtNewPw.BeforeTouchSize = New System.Drawing.Size(151, 29)
        Me.txtNewPw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPw.Location = New System.Drawing.Point(186, 110)
        Me.txtNewPw.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtNewPw.Name = "txtNewPw"
        Me.txtNewPw.Size = New System.Drawing.Size(151, 29)
        Me.txtNewPw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtNewPw.TabIndex = 7
        Me.txtNewPw.Text = "TextBoxExt2"
        '
        'txtRepNewPw
        '
        Me.txtRepNewPw.BeforeTouchSize = New System.Drawing.Size(151, 29)
        Me.txtRepNewPw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRepNewPw.Location = New System.Drawing.Point(186, 145)
        Me.txtRepNewPw.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtRepNewPw.Name = "txtRepNewPw"
        Me.txtRepNewPw.Size = New System.Drawing.Size(151, 29)
        Me.txtRepNewPw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtRepNewPw.TabIndex = 8
        Me.txtRepNewPw.Text = "TextBoxExt3"
        '
        'chkViewPW
        '
        Me.chkViewPW.AutoSize = True
        Me.chkViewPW.Location = New System.Drawing.Point(186, 180)
        Me.chkViewPW.Name = "chkViewPW"
        Me.chkViewPW.Size = New System.Drawing.Size(133, 25)
        Me.chkViewPW.TabIndex = 9
        Me.chkViewPW.Text = "Vis Passordene"
        Me.chkViewPW.UseVisualStyleBackColor = True
        '
        'btnChangePW
        '
        Me.btnChangePW.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnChangePW.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnChangePW.BeforeTouchSize = New System.Drawing.Size(151, 42)
        Me.btnChangePW.ForeColor = System.Drawing.Color.White
        Me.btnChangePW.IsBackStageButton = False
        Me.btnChangePW.Location = New System.Drawing.Point(186, 211)
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.Size = New System.Drawing.Size(151, 42)
        Me.btnChangePW.TabIndex = 10
        Me.btnChangePW.Text = "Endre Passord"
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
        Me.ClientSize = New System.Drawing.Size(340, 257)
        Me.Controls.Add(Me.btnChangePW)
        Me.Controls.Add(Me.chkViewPW)
        Me.Controls.Add(Me.txtRepNewPw)
        Me.Controls.Add(Me.txtNewPw)
        Me.Controls.Add(Me.txtOldPw)
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
        CType(Me.txtOldPw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewPw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepNewPw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chsEmpl As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents cmbAnsatte As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents lblOldPW As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents txtOldPw As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtNewPw As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtRepNewPw As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents chkViewPW As CheckBox
    Friend WithEvents btnChangePW As Syncfusion.Windows.Forms.ButtonAdv
End Class
