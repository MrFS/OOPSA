<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetroLogin
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
        Me.txtUsr = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtPw = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.btnLgInn = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.aLblUsr = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.aLblPw = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        CType(Me.txtUsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.Color.White
        Me.txtUsr.BeforeTouchSize = New System.Drawing.Size(218, 20)
        Me.txtUsr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUsr.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.txtUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsr.Location = New System.Drawing.Point(12, 25)
        Me.txtUsr.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(218, 20)
        Me.txtUsr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro
        Me.txtUsr.TabIndex = 1
        '
        'txtPw
        '
        Me.txtPw.BackColor = System.Drawing.Color.White
        Me.txtPw.BeforeTouchSize = New System.Drawing.Size(218, 20)
        Me.txtPw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPw.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPw.Location = New System.Drawing.Point(12, 64)
        Me.txtPw.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(218, 20)
        Me.txtPw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro
        Me.txtPw.TabIndex = 2
        '
        'btnLgInn
        '
        Me.btnLgInn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnLgInn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLgInn.BeforeTouchSize = New System.Drawing.Size(88, 22)
        Me.btnLgInn.ForeColor = System.Drawing.Color.White
        Me.btnLgInn.IsBackStageButton = False
        Me.btnLgInn.Location = New System.Drawing.Point(142, 90)
        Me.btnLgInn.Name = "btnLgInn"
        Me.btnLgInn.Size = New System.Drawing.Size(88, 22)
        Me.btnLgInn.TabIndex = 3
        Me.btnLgInn.Text = "Logg inn"
        Me.btnLgInn.UseVisualStyle = True
        '
        'aLblUsr
        '
        Me.aLblUsr.Location = New System.Drawing.Point(12, 9)
        Me.aLblUsr.Name = "aLblUsr"
        Me.aLblUsr.Size = New System.Drawing.Size(65, 13)
        Me.aLblUsr.TabIndex = 4
        Me.aLblUsr.Text = "Brukernavn:"
        '
        'aLblPw
        '
        Me.aLblPw.Location = New System.Drawing.Point(12, 48)
        Me.aLblPw.Name = "aLblPw"
        Me.aLblPw.Size = New System.Drawing.Size(48, 13)
        Me.aLblPw.TabIndex = 5
        Me.aLblPw.Text = "Passord:"
        '
        'frmMetroLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.CaptionFont = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.userSettings
        CaptionImage1.Name = "captionSettings"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(520, 119)
        Me.Controls.Add(Me.aLblPw)
        Me.Controls.Add(Me.aLblUsr)
        Me.Controls.Add(Me.btnLgInn)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.txtUsr)
        Me.KeyPreview = True
        Me.Name = "frmMetroLogin"
        Me.ShowIcon = False
        Me.ShowMaximizeBox = False
        Me.ShowMinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TurCare AS Logg Inn | OOPSA BADR08 - Bits Please"
        CType(Me.txtUsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsr As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtPw As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnLgInn As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents aLblUsr As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents aLblPw As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
