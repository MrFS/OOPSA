<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUsrMetro
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
        Me.txtFornavn = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtEtternavn = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtBrukernavn = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtPassord = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtGjentaPassord = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtEpost = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtAdresse = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.dtpBirth = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.txtTlf = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.cmbAvdeling = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        CType(Me.txtFornavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEtternavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBrukernavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGjentaPassord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEpost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTlf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAvdeling, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txtFornavn
        '
        Me.txtFornavn.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtFornavn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFornavn.Location = New System.Drawing.Point(14, 65)
        Me.txtFornavn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFornavn.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(116, 25)
        Me.txtFornavn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtFornavn.TabIndex = 11
        Me.txtFornavn.Text = "TextBoxExt1"
        '
        'txtEtternavn
        '
        Me.txtEtternavn.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtEtternavn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEtternavn.Location = New System.Drawing.Point(136, 65)
        Me.txtEtternavn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEtternavn.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(116, 25)
        Me.txtEtternavn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtEtternavn.TabIndex = 12
        Me.txtEtternavn.Text = "TextBoxExt2"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtBrukernavn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBrukernavn.Location = New System.Drawing.Point(14, 115)
        Me.txtBrukernavn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBrukernavn.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(116, 25)
        Me.txtBrukernavn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtBrukernavn.TabIndex = 13
        Me.txtBrukernavn.Text = "TextBoxExt3"
        '
        'txtPassord
        '
        Me.txtPassord.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtPassord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassord.Location = New System.Drawing.Point(136, 115)
        Me.txtPassord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassord.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.Size = New System.Drawing.Size(116, 25)
        Me.txtPassord.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtPassord.TabIndex = 14
        Me.txtPassord.Text = "TextBoxExt4"
        '
        'txtGjentaPassord
        '
        Me.txtGjentaPassord.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtGjentaPassord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGjentaPassord.Location = New System.Drawing.Point(258, 115)
        Me.txtGjentaPassord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGjentaPassord.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtGjentaPassord.Name = "txtGjentaPassord"
        Me.txtGjentaPassord.Size = New System.Drawing.Size(116, 25)
        Me.txtGjentaPassord.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtGjentaPassord.TabIndex = 15
        Me.txtGjentaPassord.Text = "TextBoxExt5"
        '
        'txtEpost
        '
        Me.txtEpost.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtEpost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEpost.Location = New System.Drawing.Point(14, 165)
        Me.txtEpost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEpost.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(116, 25)
        Me.txtEpost.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtEpost.TabIndex = 16
        Me.txtEpost.Text = "TextBoxExt6"
        '
        'txtAdresse
        '
        Me.txtAdresse.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdresse.Location = New System.Drawing.Point(136, 165)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdresse.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(238, 25)
        Me.txtAdresse.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtAdresse.TabIndex = 17
        Me.txtAdresse.Text = "TextBoxExt7"
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
        'txtTlf
        '
        Me.txtTlf.BackGroundColor = System.Drawing.SystemColors.Window
        Me.txtTlf.BeforeTouchSize = New System.Drawing.Size(226, 29)
        Me.txtTlf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTlf.IntegerValue = CType(1, Long)
        Me.txtTlf.Location = New System.Drawing.Point(14, 214)
        Me.txtTlf.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.NullString = ""
        Me.txtTlf.Size = New System.Drawing.Size(116, 25)
        Me.txtTlf.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTlf.TabIndex = 23
        Me.txtTlf.Text = "1"
        '
        'cmbAvdeling
        '
        Me.cmbAvdeling.BackColor = System.Drawing.Color.White
        Me.cmbAvdeling.BeforeTouchSize = New System.Drawing.Size(116, 25)
        Me.cmbAvdeling.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAvdeling.Location = New System.Drawing.Point(136, 214)
        Me.cmbAvdeling.Name = "cmbAvdeling"
        Me.cmbAvdeling.Size = New System.Drawing.Size(116, 25)
        Me.cmbAvdeling.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.cmbAvdeling.TabIndex = 24
        Me.cmbAvdeling.Text = "ComboBoxAdv1"
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
        Me.Controls.Add(Me.cmbAvdeling)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.dtpBirth)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtEpost)
        Me.Controls.Add(Me.txtGjentaPassord)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
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
        CType(Me.txtFornavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEtternavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBrukernavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGjentaPassord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEpost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdresse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpBirth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTlf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAvdeling, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtFornavn As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtEtternavn As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtBrukernavn As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtPassord As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtGjentaPassord As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtEpost As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtAdresse As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents dtpBirth As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Friend WithEvents txtTlf As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents cmbAvdeling As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
End Class
