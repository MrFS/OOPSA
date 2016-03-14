<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUsrMetro
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
        Me.lblUsername = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.btnFinish = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.lblPass = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblPassRep = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblFNavn = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblENavn = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblBirth = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblEmail = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblTlf = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblAdress = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblDepartment = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TextBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt3 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt4 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt5 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt6 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt7 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt8 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt9 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.dtpBirth = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(15, 94)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Brukernavn:"
        '
        'btnFinish
        '
        Me.btnFinish.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnFinish.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFinish.BeforeTouchSize = New System.Drawing.Size(116, 42)
        Me.btnFinish.ForeColor = System.Drawing.Color.White
        Me.btnFinish.IsBackStageButton = False
        Me.btnFinish.Location = New System.Drawing.Point(258, 198)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(116, 42)
        Me.btnFinish.TabIndex = 1
        Me.btnFinish.Text = "Legg til ansatt"
        Me.btnFinish.UseVisualStyle = True
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(136, 94)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 17)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "Passord:"
        '
        'lblPassRep
        '
        Me.lblPassRep.Location = New System.Drawing.Point(258, 94)
        Me.lblPassRep.Name = "lblPassRep"
        Me.lblPassRep.Size = New System.Drawing.Size(94, 17)
        Me.lblPassRep.TabIndex = 3
        Me.lblPassRep.Text = "Gjenta Passord:"
        '
        'lblFNavn
        '
        Me.lblFNavn.Location = New System.Drawing.Point(14, 44)
        Me.lblFNavn.Name = "lblFNavn"
        Me.lblFNavn.Size = New System.Drawing.Size(55, 17)
        Me.lblFNavn.TabIndex = 4
        Me.lblFNavn.Text = "Fornavn:"
        '
        'lblENavn
        '
        Me.lblENavn.Location = New System.Drawing.Point(136, 44)
        Me.lblENavn.Name = "lblENavn"
        Me.lblENavn.Size = New System.Drawing.Size(64, 17)
        Me.lblENavn.TabIndex = 5
        Me.lblENavn.Text = "Etternavn:"
        '
        'lblBirth
        '
        Me.lblBirth.Location = New System.Drawing.Point(258, 44)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(76, 17)
        Me.lblBirth.TabIndex = 6
        Me.lblBirth.Text = "Fødselsdato:"
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(14, 144)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 17)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Epost:"
        '
        'lblTlf
        '
        Me.lblTlf.Location = New System.Drawing.Point(14, 194)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(52, 17)
        Me.lblTlf.TabIndex = 8
        Me.lblTlf.Text = "Telefon:"
        '
        'lblAdress
        '
        Me.lblAdress.Location = New System.Drawing.Point(136, 144)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(54, 17)
        Me.lblAdress.TabIndex = 9
        Me.lblAdress.Text = "Adresse:"
        '
        'lblDepartment
        '
        Me.lblDepartment.Location = New System.Drawing.Point(136, 194)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(59, 17)
        Me.lblDepartment.TabIndex = 10
        Me.lblDepartment.Text = "Avdeling:"
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt1.Location = New System.Drawing.Point(14, 65)
        Me.TextBoxExt1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt1.TabIndex = 11
        Me.TextBoxExt1.Text = "TextBoxExt1"
        '
        'TextBoxExt2
        '
        Me.TextBoxExt2.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt2.Location = New System.Drawing.Point(136, 65)
        Me.TextBoxExt2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt2.Name = "TextBoxExt2"
        Me.TextBoxExt2.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt2.TabIndex = 12
        Me.TextBoxExt2.Text = "TextBoxExt2"
        '
        'TextBoxExt3
        '
        Me.TextBoxExt3.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt3.Location = New System.Drawing.Point(14, 115)
        Me.TextBoxExt3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt3.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt3.Name = "TextBoxExt3"
        Me.TextBoxExt3.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt3.TabIndex = 13
        Me.TextBoxExt3.Text = "TextBoxExt3"
        '
        'TextBoxExt4
        '
        Me.TextBoxExt4.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt4.Location = New System.Drawing.Point(136, 115)
        Me.TextBoxExt4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt4.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt4.Name = "TextBoxExt4"
        Me.TextBoxExt4.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt4.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt4.TabIndex = 14
        Me.TextBoxExt4.Text = "TextBoxExt4"
        '
        'TextBoxExt5
        '
        Me.TextBoxExt5.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt5.Location = New System.Drawing.Point(258, 115)
        Me.TextBoxExt5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt5.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt5.Name = "TextBoxExt5"
        Me.TextBoxExt5.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt5.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt5.TabIndex = 15
        Me.TextBoxExt5.Text = "TextBoxExt5"
        '
        'TextBoxExt6
        '
        Me.TextBoxExt6.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt6.Location = New System.Drawing.Point(14, 165)
        Me.TextBoxExt6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt6.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt6.Name = "TextBoxExt6"
        Me.TextBoxExt6.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt6.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt6.TabIndex = 16
        Me.TextBoxExt6.Text = "TextBoxExt6"
        '
        'TextBoxExt7
        '
        Me.TextBoxExt7.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt7.Location = New System.Drawing.Point(136, 165)
        Me.TextBoxExt7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt7.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt7.Name = "TextBoxExt7"
        Me.TextBoxExt7.Size = New System.Drawing.Size(238, 25)
        Me.TextBoxExt7.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt7.TabIndex = 17
        Me.TextBoxExt7.Text = "TextBoxExt7"
        '
        'TextBoxExt8
        '
        Me.TextBoxExt8.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt8.Location = New System.Drawing.Point(14, 215)
        Me.TextBoxExt8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt8.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt8.Name = "TextBoxExt8"
        Me.TextBoxExt8.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt8.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt8.TabIndex = 18
        Me.TextBoxExt8.Text = "TextBoxExt8"
        '
        'TextBoxExt9
        '
        Me.TextBoxExt9.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.TextBoxExt9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxExt9.Location = New System.Drawing.Point(136, 215)
        Me.TextBoxExt9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExt9.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt9.Name = "TextBoxExt9"
        Me.TextBoxExt9.Size = New System.Drawing.Size(116, 25)
        Me.TextBoxExt9.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.TextBoxExt9.TabIndex = 19
        Me.TextBoxExt9.Text = "TextBoxExt9"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(6, 9)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(377, 17)
        Me.AutoLabel1.TabIndex = 21
        Me.AutoLabel1.Text = "Fyll inn områdene nedenfor for å legge til en ny ansatt i systemet."
        '
        'dtpBirth
        '
        Me.dtpBirth.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtpBirth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dtpBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpBirth.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirth.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtpBirth.Checked = False
        Me.dtpBirth.CustomFormat = "yyyy-MM-dd"
        Me.dtpBirth.DropDownImage = Nothing
        Me.dtpBirth.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpBirth.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpBirth.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dtpBirth.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirth.Location = New System.Drawing.Point(258, 65)
        Me.dtpBirth.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpBirth.MinValue = New Date(CType(0, Long))
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.ShowCheckBox = False
        Me.dtpBirth.Size = New System.Drawing.Size(116, 25)
        Me.dtpBirth.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.dtpBirth.TabIndex = 22
        Me.dtpBirth.Value = New Date(2016, 3, 10, 12, 36, 8, 262)
        '
        'frmAddUsrMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.usrAdd
        CaptionImage1.Name = "capAddAnsatt"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(384, 252)
        Me.Controls.Add(Me.dtpBirth)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.TextBoxExt9)
        Me.Controls.Add(Me.TextBoxExt8)
        Me.Controls.Add(Me.TextBoxExt7)
        Me.Controls.Add(Me.TextBoxExt6)
        Me.Controls.Add(Me.TextBoxExt5)
        Me.Controls.Add(Me.TextBoxExt4)
        Me.Controls.Add(Me.TextBoxExt3)
        Me.Controls.Add(Me.TextBoxExt2)
        Me.Controls.Add(Me.TextBoxExt1)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblAdress)
        Me.Controls.Add(Me.lblTlf)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.lblENavn)
        Me.Controls.Add(Me.lblFNavn)
        Me.Controls.Add(Me.lblPassRep)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblUsername)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAddUsrMetro"
        Me.ShowIcon = False
        Me.Text = "Legg Til Ny Ansatt"
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpBirth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents btnFinish As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents lblPass As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblPassRep As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblFNavn As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblENavn As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblBirth As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblEmail As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblTlf As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblAdress As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblDepartment As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TextBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt3 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt4 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt5 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt6 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt7 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt8 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt9 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents dtpBirth As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
End Class
