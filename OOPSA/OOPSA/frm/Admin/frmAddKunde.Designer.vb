﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddKunde
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
        Me.btnNyKunde = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblEpost = New System.Windows.Forms.Label()
        Me.txtKundeFnavn = New System.Windows.Forms.TextBox()
        Me.txtKundeEnavn = New System.Windows.Forms.TextBox()
        Me.txtKundeEpost = New System.Windows.Forms.TextBox()
        Me.txtPrivAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtPrivPnr = New System.Windows.Forms.TextBox()
        Me.lblPostnr = New System.Windows.Forms.Label()
        Me.txtBedriftNavn = New System.Windows.Forms.TextBox()
        Me.lblBedriftNavn = New System.Windows.Forms.Label()
        Me.btnPrivatKunde = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnBedriftKunde = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.txtBedAdresse = New System.Windows.Forms.TextBox()
        Me.txtBedPnr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNyKunde
        '
        Me.btnNyKunde.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnNyKunde.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnNyKunde.BeforeTouchSize = New System.Drawing.Size(133, 52)
        Me.btnNyKunde.ForeColor = System.Drawing.Color.White
        Me.btnNyKunde.IsBackStageButton = False
        Me.btnNyKunde.Location = New System.Drawing.Point(187, 320)
        Me.btnNyKunde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNyKunde.Name = "btnNyKunde"
        Me.btnNyKunde.Size = New System.Drawing.Size(133, 52)
        Me.btnNyKunde.TabIndex = 2
        Me.btnNyKunde.Text = "Registrer kunde"
        Me.btnNyKunde.UseVisualStyle = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registrer ny kunde"
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(16, 121)
        Me.lblFornavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(60, 17)
        Me.lblFornavn.TabIndex = 4
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(183, 121)
        Me.lblEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(69, 17)
        Me.lblEtternavn.TabIndex = 5
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.Location = New System.Drawing.Point(16, 180)
        Me.lblEpost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(44, 17)
        Me.lblEpost.TabIndex = 6
        Me.lblEpost.Text = "Epost"
        '
        'txtKundeFnavn
        '
        Me.txtKundeFnavn.Location = New System.Drawing.Point(20, 140)
        Me.txtKundeFnavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKundeFnavn.Name = "txtKundeFnavn"
        Me.txtKundeFnavn.Size = New System.Drawing.Size(132, 22)
        Me.txtKundeFnavn.TabIndex = 7
        '
        'txtKundeEnavn
        '
        Me.txtKundeEnavn.Location = New System.Drawing.Point(187, 140)
        Me.txtKundeEnavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKundeEnavn.Name = "txtKundeEnavn"
        Me.txtKundeEnavn.Size = New System.Drawing.Size(132, 22)
        Me.txtKundeEnavn.TabIndex = 8
        '
        'txtKundeEpost
        '
        Me.txtKundeEpost.Location = New System.Drawing.Point(20, 199)
        Me.txtKundeEpost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKundeEpost.Name = "txtKundeEpost"
        Me.txtKundeEpost.Size = New System.Drawing.Size(132, 22)
        Me.txtKundeEpost.TabIndex = 9
        '
        'txtPrivAdresse
        '
        Me.txtPrivAdresse.Location = New System.Drawing.Point(187, 199)
        Me.txtPrivAdresse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrivAdresse.Name = "txtPrivAdresse"
        Me.txtPrivAdresse.Size = New System.Drawing.Size(132, 22)
        Me.txtPrivAdresse.TabIndex = 10
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(187, 180)
        Me.lblAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(60, 17)
        Me.lblAdresse.TabIndex = 11
        Me.lblAdresse.Text = "Adresse"
        '
        'txtPrivPnr
        '
        Me.txtPrivPnr.Location = New System.Drawing.Point(20, 260)
        Me.txtPrivPnr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrivPnr.Name = "txtPrivPnr"
        Me.txtPrivPnr.Size = New System.Drawing.Size(132, 22)
        Me.txtPrivPnr.TabIndex = 12
        '
        'lblPostnr
        '
        Me.lblPostnr.AutoSize = True
        Me.lblPostnr.Location = New System.Drawing.Point(16, 240)
        Me.lblPostnr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostnr.Name = "lblPostnr"
        Me.lblPostnr.Size = New System.Drawing.Size(87, 17)
        Me.lblPostnr.TabIndex = 13
        Me.lblPostnr.Text = "Postnummer"
        '
        'txtBedriftNavn
        '
        Me.txtBedriftNavn.Location = New System.Drawing.Point(187, 260)
        Me.txtBedriftNavn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBedriftNavn.Name = "txtBedriftNavn"
        Me.txtBedriftNavn.Size = New System.Drawing.Size(132, 22)
        Me.txtBedriftNavn.TabIndex = 14
        '
        'lblBedriftNavn
        '
        Me.lblBedriftNavn.AutoSize = True
        Me.lblBedriftNavn.Location = New System.Drawing.Point(187, 240)
        Me.lblBedriftNavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBedriftNavn.Name = "lblBedriftNavn"
        Me.lblBedriftNavn.Size = New System.Drawing.Size(84, 17)
        Me.lblBedriftNavn.TabIndex = 15
        Me.lblBedriftNavn.Text = "Bedrift navn"
        '
        'btnPrivatKunde
        '
        Me.btnPrivatKunde.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnPrivatKunde.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnPrivatKunde.BeforeTouchSize = New System.Drawing.Size(120, 32)
        Me.btnPrivatKunde.ForeColor = System.Drawing.Color.White
        Me.btnPrivatKunde.IsBackStageButton = False
        Me.btnPrivatKunde.Location = New System.Drawing.Point(16, 52)
        Me.btnPrivatKunde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrivatKunde.Name = "btnPrivatKunde"
        Me.btnPrivatKunde.Size = New System.Drawing.Size(120, 32)
        Me.btnPrivatKunde.TabIndex = 16
        Me.btnPrivatKunde.Text = "Privat-kunde"
        Me.btnPrivatKunde.UseVisualStyle = True
        '
        'btnBedriftKunde
        '
        Me.btnBedriftKunde.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnBedriftKunde.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBedriftKunde.BeforeTouchSize = New System.Drawing.Size(133, 32)
        Me.btnBedriftKunde.ForeColor = System.Drawing.Color.White
        Me.btnBedriftKunde.IsBackStageButton = False
        Me.btnBedriftKunde.Location = New System.Drawing.Point(187, 52)
        Me.btnBedriftKunde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBedriftKunde.Name = "btnBedriftKunde"
        Me.btnBedriftKunde.Size = New System.Drawing.Size(133, 32)
        Me.btnBedriftKunde.TabIndex = 17
        Me.btnBedriftKunde.Text = "Bedrifts-kunde"
        Me.btnBedriftKunde.UseVisualStyle = True
        '
        'txtBedAdresse
        '
        Me.txtBedAdresse.Location = New System.Drawing.Point(187, 199)
        Me.txtBedAdresse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBedAdresse.Name = "txtBedAdresse"
        Me.txtBedAdresse.Size = New System.Drawing.Size(132, 22)
        Me.txtBedAdresse.TabIndex = 18
        '
        'txtBedPnr
        '
        Me.txtBedPnr.Location = New System.Drawing.Point(20, 260)
        Me.txtBedPnr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBedPnr.Name = "txtBedPnr"
        Me.txtBedPnr.Size = New System.Drawing.Size(132, 22)
        Me.txtBedPnr.TabIndex = 19
        '
        'frmAddKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.CaptionButtonColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(342, 398)
        Me.Controls.Add(Me.txtBedPnr)
        Me.Controls.Add(Me.txtBedAdresse)
        Me.Controls.Add(Me.btnBedriftKunde)
        Me.Controls.Add(Me.btnPrivatKunde)
        Me.Controls.Add(Me.lblBedriftNavn)
        Me.Controls.Add(Me.txtBedriftNavn)
        Me.Controls.Add(Me.lblPostnr)
        Me.Controls.Add(Me.txtPrivPnr)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.txtPrivAdresse)
        Me.Controls.Add(Me.txtKundeEpost)
        Me.Controls.Add(Me.txtKundeEnavn)
        Me.Controls.Add(Me.txtKundeFnavn)
        Me.Controls.Add(Me.lblEpost)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNyKunde)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAddKunde"
        Me.Text = "Registrer ny kunde"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNyKunde As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFornavn As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblEpost As Label
    Friend WithEvents txtKundeFnavn As TextBox
    Friend WithEvents txtKundeEnavn As TextBox
    Friend WithEvents txtKundeEpost As TextBox
    Friend WithEvents txtPrivAdresse As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents txtPrivPnr As TextBox
    Friend WithEvents lblPostnr As Label
    Friend WithEvents txtBedriftNavn As TextBox
    Friend WithEvents lblBedriftNavn As Label
    Friend WithEvents btnPrivatKunde As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents btnBedriftKunde As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents txtBedAdresse As TextBox
    Friend WithEvents txtBedPnr As TextBox
End Class
