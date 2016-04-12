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
        Me.txtKundeFnavn = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtKundeEnavn = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txtKundeEpost = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFerdigLeie = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.txtKundeFnavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKundeEnavn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKundeEpost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKundeFnavn
        '
        Me.txtKundeFnavn.BeforeTouchSize = New System.Drawing.Size(100, 20)
        Me.txtKundeFnavn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKundeFnavn.Location = New System.Drawing.Point(12, 76)
        Me.txtKundeFnavn.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtKundeFnavn.Name = "txtKundeFnavn"
        Me.txtKundeFnavn.Size = New System.Drawing.Size(100, 20)
        Me.txtKundeFnavn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtKundeFnavn.TabIndex = 0
        Me.txtKundeFnavn.Text = "TextBoxExt1"
        '
        'txtKundeEnavn
        '
        Me.txtKundeEnavn.BeforeTouchSize = New System.Drawing.Size(100, 20)
        Me.txtKundeEnavn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKundeEnavn.Location = New System.Drawing.Point(12, 126)
        Me.txtKundeEnavn.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtKundeEnavn.Name = "txtKundeEnavn"
        Me.txtKundeEnavn.Size = New System.Drawing.Size(100, 20)
        Me.txtKundeEnavn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtKundeEnavn.TabIndex = 1
        Me.txtKundeEnavn.Text = "TextBoxExt2"
        '
        'txtKundeEpost
        '
        Me.txtKundeEpost.BeforeTouchSize = New System.Drawing.Size(100, 20)
        Me.txtKundeEpost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKundeEpost.Location = New System.Drawing.Point(12, 175)
        Me.txtKundeEpost.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtKundeEpost.Name = "txtKundeEpost"
        Me.txtKundeEpost.Size = New System.Drawing.Size(100, 20)
        Me.txtKundeEpost.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtKundeEpost.TabIndex = 2
        Me.txtKundeEpost.Text = "TextBoxExt3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fornavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Etternavn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Epost"
        '
        'btnFerdigLeie
        '
        Me.btnFerdigLeie.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnFerdigLeie.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFerdigLeie.BeforeTouchSize = New System.Drawing.Size(87, 34)
        Me.btnFerdigLeie.ForeColor = System.Drawing.Color.White
        Me.btnFerdigLeie.IsBackStageButton = False
        Me.btnFerdigLeie.Location = New System.Drawing.Point(16, 201)
        Me.btnFerdigLeie.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnFerdigLeie.Name = "btnFerdigLeie"
        Me.btnFerdigLeie.Size = New System.Drawing.Size(87, 34)
        Me.btnFerdigLeie.TabIndex = 33
        Me.btnFerdigLeie.Text = "Legg til leie"
        Me.btnFerdigLeie.UseVisualStyle = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Registrer ny kunde"
        '
        'frmAddKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.ClientSize = New System.Drawing.Size(250, 299)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFerdigLeie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKundeEpost)
        Me.Controls.Add(Me.txtKundeEnavn)
        Me.Controls.Add(Me.txtKundeFnavn)
        Me.Name = "frmAddKunde"
        Me.Text = "Registrer ny kunde"
        CType(Me.txtKundeFnavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKundeEnavn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKundeEpost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKundeFnavn As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtKundeEnavn As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txtKundeEpost As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFerdigLeie As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents Label4 As Label
End Class
