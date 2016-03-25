<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPass
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
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEpost = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.btnRequest = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.TextBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Panel1.SuspendLayout()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Size = New System.Drawing.Size(195, 40)
        Me.ToolStripEx1.TabIndex = 0
        Me.ToolStripEx1.Text = "Få tilsendt nytt passord"
        Me.ToolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxExt1)
        Me.Panel1.Controls.Add(Me.lblEpost)
        Me.Panel1.Controls.Add(Me.btnRequest)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 170)
        Me.Panel1.TabIndex = 1
        '
        'lblEpost
        '
        Me.lblEpost.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEpost.Location = New System.Drawing.Point(13, 9)
        Me.lblEpost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(121, 21)
        Me.lblEpost.TabIndex = 4
        Me.lblEpost.Text = "Registrert Epost:"
        '
        'btnRequest
        '
        Me.btnRequest.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnRequest.BeforeTouchSize = New System.Drawing.Size(195, 84)
        Me.btnRequest.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRequest.ForeColor = System.Drawing.Color.White
        Me.btnRequest.IsBackStageButton = False
        Me.btnRequest.Location = New System.Drawing.Point(0, 86)
        Me.btnRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(195, 84)
        Me.btnRequest.TabIndex = 3
        Me.btnRequest.Text = "Få tilsendt nytt passord"
        Me.btnRequest.UseVisualStyle = True
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BeforeTouchSize = New System.Drawing.Size(254, 23)
        Me.TextBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt1.Location = New System.Drawing.Point(13, 33)
        Me.TextBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.Size = New System.Drawing.Size(170, 29)
        Me.TextBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt1.TabIndex = 5
        Me.TextBoxExt1.Text = "TextBoxExt1"
        '
        'frmForgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.userSettings
        CaptionImage1.Name = "CaptionImage1"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(195, 210)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripEx1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmForgotPass"
        Me.ShowIcon = False
        Me.ShowMaximizeBox = False
        Me.ShowMinimizeBox = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEpost As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents btnRequest As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents TextBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
End Class
