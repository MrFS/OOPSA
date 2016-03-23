<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMetroLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim CaptionImage1 As Syncfusion.Windows.Forms.CaptionImage = New Syncfusion.Windows.Forms.CaptionImage()
        Me.txtUsr = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtPw = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.btnLgInn = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.aLblUsr = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.aLblPw = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblVersion = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.pxUpdate = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CarouselItem1 = New Syncfusion.Windows.Forms.Tools.CarouselItem()
        Me.lblUpdateAvailable = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblNewVersion = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        CType(Me.txtUsr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarouselItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.Color.White
        Me.txtUsr.BeforeTouchSize = New System.Drawing.Size(254, 23)
        Me.txtUsr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUsr.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.txtUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsr.Location = New System.Drawing.Point(14, 29)
        Me.txtUsr.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(254, 23)
        Me.txtUsr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro
        Me.txtUsr.TabIndex = 1
        Me.txtUsr.Text = "FS"
        '
        'txtPw
        '
        Me.txtPw.BackColor = System.Drawing.Color.White
        Me.txtPw.BeforeTouchSize = New System.Drawing.Size(254, 23)
        Me.txtPw.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPw.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPw.Location = New System.Drawing.Point(14, 74)
        Me.txtPw.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPw.Name = "txtPw"
        Me.txtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPw.Size = New System.Drawing.Size(254, 23)
        Me.txtPw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro
        Me.txtPw.TabIndex = 2
        Me.txtPw.Text = "aaa"
        Me.txtPw.UseSystemPasswordChar = True
        '
        'btnLgInn
        '
        Me.btnLgInn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnLgInn.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLgInn.BeforeTouchSize = New System.Drawing.Size(103, 25)
        Me.btnLgInn.ForeColor = System.Drawing.Color.White
        Me.btnLgInn.IsBackStageButton = False
        Me.btnLgInn.Location = New System.Drawing.Point(166, 104)
        Me.btnLgInn.Name = "btnLgInn"
        Me.btnLgInn.Size = New System.Drawing.Size(103, 25)
        Me.btnLgInn.TabIndex = 3
        Me.btnLgInn.Text = "Logg inn"
        Me.btnLgInn.UseVisualStyle = True
        '
        'aLblUsr
        '
        Me.aLblUsr.Location = New System.Drawing.Point(14, 10)
        Me.aLblUsr.Name = "aLblUsr"
        Me.aLblUsr.Size = New System.Drawing.Size(70, 15)
        Me.aLblUsr.TabIndex = 4
        Me.aLblUsr.Text = "Brukernavn:"
        '
        'aLblPw
        '
        Me.aLblPw.Location = New System.Drawing.Point(14, 55)
        Me.aLblPw.Name = "aLblPw"
        Me.aLblPw.Size = New System.Drawing.Size(51, 15)
        Me.aLblPw.TabIndex = 5
        Me.aLblPw.Text = "Passord:"
        '
        'lblVersion
        '
        Me.lblVersion.Location = New System.Drawing.Point(274, 10)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(90, 15)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "Current version:"
        '
        'pxUpdate
        '
        Me.pxUpdate.Image = Global.OOPSA.My.Resources.Resources.updateAvailable
        Me.pxUpdate.Location = New System.Drawing.Point(373, 75)
        Me.pxUpdate.Name = "pxUpdate"
        Me.pxUpdate.Size = New System.Drawing.Size(62, 58)
        Me.pxUpdate.TabIndex = 9
        Me.pxUpdate.TabStop = False
        Me.pxUpdate.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.OOPSA.My.Resources.Resources.Kiwi
        Me.PictureBox2.Location = New System.Drawing.Point(441, 75)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 58)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OOPSA.My.Resources.Resources.loginForgot
        Me.PictureBox1.Location = New System.Drawing.Point(441, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 58)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'CarouselItem1
        '
        Me.CarouselItem1.BackColor = System.Drawing.Color.Black
        Me.CarouselItem1.Location = New System.Drawing.Point(111, -20)
        Me.CarouselItem1.Name = "CarouselItem1"
        Me.CarouselItem1.Size = New System.Drawing.Size(100, 50)
        Me.CarouselItem1.TabIndex = 0
        Me.CarouselItem1.TabStop = False
        Me.CarouselItem1.Tag = 0R
        Me.CarouselItem1.Visible = False
        '
        'lblUpdateAvailable
        '
        Me.lblUpdateAvailable.Location = New System.Drawing.Point(274, 29)
        Me.lblUpdateAvailable.Name = "lblUpdateAvailable"
        Me.lblUpdateAvailable.Size = New System.Drawing.Size(97, 15)
        Me.lblUpdateAvailable.TabIndex = 10
        Me.lblUpdateAvailable.Text = "Update available!"
        Me.lblUpdateAvailable.Visible = False
        '
        'lblNewVersion
        '
        Me.lblNewVersion.Location = New System.Drawing.Point(274, 47)
        Me.lblNewVersion.Name = "lblNewVersion"
        Me.lblNewVersion.Size = New System.Drawing.Size(77, 15)
        Me.lblNewVersion.TabIndex = 11
        Me.lblNewVersion.Text = "New version: "
        Me.lblNewVersion.Visible = False
        '
        'frmMetroLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.CaptionFont = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.userSettings
        CaptionImage1.Name = "captionSettings"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(515, 140)
        Me.Controls.Add(Me.lblNewVersion)
        Me.Controls.Add(Me.lblUpdateAvailable)
        Me.Controls.Add(Me.pxUpdate)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.aLblPw)
        Me.Controls.Add(Me.aLblUsr)
        Me.Controls.Add(Me.btnLgInn)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.txtUsr)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmMetroLogin"
        Me.ShowIcon = False
        Me.ShowMaximizeBox = False
        Me.ShowMinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TurCare AS Logg Inn | OOPSA BADR08 - Bits Please"
        CType(Me.txtUsr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarouselItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsr As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtPw As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnLgInn As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents aLblUsr As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents aLblPw As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents CarouselItem1 As Syncfusion.Windows.Forms.Tools.CarouselItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblVersion As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents pxUpdate As PictureBox
    Friend WithEvents lblUpdateAvailable As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblNewVersion As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
