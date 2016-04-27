<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtBedAdresse = New System.Windows.Forms.TextBox()
        Me.txtBedPnr = New System.Windows.Forms.TextBox()
        Me.ComboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNyKunde
        '
        Me.btnNyKunde.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnNyKunde.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnNyKunde.BeforeTouchSize = New System.Drawing.Size(132, 34)
        Me.btnNyKunde.ForeColor = System.Drawing.Color.White
        Me.btnNyKunde.IsBackStageButton = False
        Me.btnNyKunde.Location = New System.Drawing.Point(184, 293)
        Me.btnNyKunde.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNyKunde.Name = "btnNyKunde"
        Me.btnNyKunde.Size = New System.Drawing.Size(132, 34)
        Me.btnNyKunde.TabIndex = 2
        Me.btnNyKunde.Text = "Registrer kunde"
        Me.btnNyKunde.UseVisualStyle = True
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(13, 81)
        Me.lblFornavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(61, 20)
        Me.lblFornavn.TabIndex = 4
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(180, 81)
        Me.lblEtternavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(71, 20)
        Me.lblEtternavn.TabIndex = 5
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.Location = New System.Drawing.Point(13, 155)
        Me.lblEpost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(46, 20)
        Me.lblEpost.TabIndex = 6
        Me.lblEpost.Text = "Epost"
        '
        'txtKundeFnavn
        '
        Me.txtKundeFnavn.Location = New System.Drawing.Point(17, 105)
        Me.txtKundeFnavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKundeFnavn.Name = "txtKundeFnavn"
        Me.txtKundeFnavn.Size = New System.Drawing.Size(132, 27)
        Me.txtKundeFnavn.TabIndex = 7
        '
        'txtKundeEnavn
        '
        Me.txtKundeEnavn.Location = New System.Drawing.Point(184, 105)
        Me.txtKundeEnavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKundeEnavn.Name = "txtKundeEnavn"
        Me.txtKundeEnavn.Size = New System.Drawing.Size(132, 27)
        Me.txtKundeEnavn.TabIndex = 8
        '
        'txtKundeEpost
        '
        Me.txtKundeEpost.Location = New System.Drawing.Point(17, 179)
        Me.txtKundeEpost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKundeEpost.Name = "txtKundeEpost"
        Me.txtKundeEpost.Size = New System.Drawing.Size(132, 27)
        Me.txtKundeEpost.TabIndex = 9
        '
        'txtPrivAdresse
        '
        Me.txtPrivAdresse.Location = New System.Drawing.Point(184, 179)
        Me.txtPrivAdresse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrivAdresse.Name = "txtPrivAdresse"
        Me.txtPrivAdresse.Size = New System.Drawing.Size(132, 27)
        Me.txtPrivAdresse.TabIndex = 10
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(184, 155)
        Me.lblAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(61, 20)
        Me.lblAdresse.TabIndex = 11
        Me.lblAdresse.Text = "Adresse"
        '
        'txtPrivPnr
        '
        Me.txtPrivPnr.Location = New System.Drawing.Point(17, 255)
        Me.txtPrivPnr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrivPnr.Name = "txtPrivPnr"
        Me.txtPrivPnr.Size = New System.Drawing.Size(132, 27)
        Me.txtPrivPnr.TabIndex = 12
        '
        'lblPostnr
        '
        Me.lblPostnr.AutoSize = True
        Me.lblPostnr.Location = New System.Drawing.Point(13, 230)
        Me.lblPostnr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostnr.Name = "lblPostnr"
        Me.lblPostnr.Size = New System.Drawing.Size(91, 20)
        Me.lblPostnr.TabIndex = 13
        Me.lblPostnr.Text = "Postnummer"
        '
        'txtBedriftNavn
        '
        Me.txtBedriftNavn.Location = New System.Drawing.Point(184, 255)
        Me.txtBedriftNavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBedriftNavn.Name = "txtBedriftNavn"
        Me.txtBedriftNavn.Size = New System.Drawing.Size(132, 27)
        Me.txtBedriftNavn.TabIndex = 14
        '
        'lblBedriftNavn
        '
        Me.lblBedriftNavn.AutoSize = True
        Me.lblBedriftNavn.Location = New System.Drawing.Point(184, 230)
        Me.lblBedriftNavn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBedriftNavn.Name = "lblBedriftNavn"
        Me.lblBedriftNavn.Size = New System.Drawing.Size(89, 20)
        Me.lblBedriftNavn.TabIndex = 15
        Me.lblBedriftNavn.Text = "Bedrift navn"
        '
        'txtBedAdresse
        '
        Me.txtBedAdresse.Location = New System.Drawing.Point(184, 179)
        Me.txtBedAdresse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBedAdresse.Name = "txtBedAdresse"
        Me.txtBedAdresse.Size = New System.Drawing.Size(132, 27)
        Me.txtBedAdresse.TabIndex = 18
        '
        'txtBedPnr
        '
        Me.txtBedPnr.Location = New System.Drawing.Point(17, 255)
        Me.txtBedPnr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBedPnr.Name = "txtBedPnr"
        Me.txtBedPnr.Size = New System.Drawing.Size(132, 27)
        Me.txtBedPnr.TabIndex = 19
        '
        'ComboBoxAdv1
        '
        Me.ComboBoxAdv1.BackColor = System.Drawing.Color.White
        Me.ComboBoxAdv1.BeforeTouchSize = New System.Drawing.Size(160, 28)
        Me.ComboBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAdv1.Items.AddRange(New Object() {"Privatkunde", "Bedriftskunde"})
        Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Privatkunde"))
        Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Bedriftskunde"))
        Me.ComboBoxAdv1.Location = New System.Drawing.Point(17, 34)
        Me.ComboBoxAdv1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxAdv1.Name = "ComboBoxAdv1"
        Me.ComboBoxAdv1.Size = New System.Drawing.Size(160, 28)
        Me.ComboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.ComboBoxAdv1.TabIndex = 20
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(13, 9)
        Me.AutoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(133, 20)
        Me.AutoLabel1.TabIndex = 21
        Me.AutoLabel1.Text = "Velg kundegruppe:"
        '
        'frmAddKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.CaptionButtonColor = System.Drawing.Color.Gray
        Me.CaptionFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(319, 337)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.ComboBoxAdv1)
        Me.Controls.Add(Me.txtBedPnr)
        Me.Controls.Add(Me.txtBedAdresse)
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
        Me.Controls.Add(Me.btnNyKunde)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddKunde"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrer ny kunde"
        CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNyKunde As Syncfusion.Windows.Forms.ButtonAdv
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
    Friend WithEvents txtBedAdresse As TextBox
    Friend WithEvents txtBedPnr As TextBox
    Friend WithEvents ComboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
