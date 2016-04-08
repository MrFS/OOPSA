<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLeie
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
        Me.dtpTil = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.dtpFra = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
        Me.lblfra = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblTil = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.lblVelgKunde = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.btnFerdigLeie = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.ComboProdukt = New System.Windows.Forms.ComboBox()
        Me.ComboKunde = New System.Windows.Forms.ComboBox()
        Me.ComboLager = New System.Windows.Forms.ComboBox()
        CType(Me.dtpTil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpTil
        '
        Me.dtpTil.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtpTil.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dtpTil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpTil.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtpTil.Checked = False
        Me.dtpTil.CustomFormat = "yyyy-MM-dd"
        Me.dtpTil.DropDownImage = Nothing
        Me.dtpTil.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpTil.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpTil.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dtpTil.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTil.Location = New System.Drawing.Point(243, 128)
        Me.dtpTil.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpTil.MinValue = New Date(CType(0, Long))
        Me.dtpTil.Name = "dtpTil"
        Me.dtpTil.ShowCheckBox = False
        Me.dtpTil.Size = New System.Drawing.Size(116, 25)
        Me.dtpTil.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.dtpTil.TabIndex = 23
        Me.dtpTil.Value = New Date(2016, 3, 10, 12, 36, 8, 262)
        '
        'dtpFra
        '
        Me.dtpFra.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.dtpFra.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dtpFra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFra.CalendarSize = New System.Drawing.Size(189, 176)
        Me.dtpFra.Checked = False
        Me.dtpFra.CustomFormat = "yyyy-MM-dd"
        Me.dtpFra.DropDownImage = Nothing
        Me.dtpFra.DropDownNormalColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpFra.DropDownPressedColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpFra.DropDownSelectedColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dtpFra.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFra.Location = New System.Drawing.Point(243, 63)
        Me.dtpFra.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtpFra.MinValue = New Date(CType(0, Long))
        Me.dtpFra.Name = "dtpFra"
        Me.dtpFra.ShowCheckBox = False
        Me.dtpFra.Size = New System.Drawing.Size(116, 25)
        Me.dtpFra.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.dtpFra.TabIndex = 24
        Me.dtpFra.Value = New Date(2016, 3, 10, 12, 36, 8, 262)
        '
        'lblfra
        '
        Me.lblfra.Location = New System.Drawing.Point(243, 43)
        Me.lblfra.Name = "lblfra"
        Me.lblfra.Size = New System.Drawing.Size(33, 17)
        Me.lblfra.TabIndex = 25
        Me.lblfra.Text = "Fra:"
        '
        'lblTil
        '
        Me.lblTil.Location = New System.Drawing.Point(242, 108)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(33, 17)
        Me.lblTil.TabIndex = 26
        Me.lblTil.Text = "Fra:"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Location = New System.Drawing.Point(54, 43)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(92, 17)
        Me.AutoLabel1.TabIndex = 28
        Me.AutoLabel1.Text = "Velg produkt:"
        '
        'lblVelgKunde
        '
        Me.lblVelgKunde.Location = New System.Drawing.Point(54, 108)
        Me.lblVelgKunde.Name = "lblVelgKunde"
        Me.lblVelgKunde.Size = New System.Drawing.Size(81, 17)
        Me.lblVelgKunde.TabIndex = 30
        Me.lblVelgKunde.Text = "Velg Kunde"
        '
        'btnFerdigLeie
        '
        Me.btnFerdigLeie.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnFerdigLeie.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFerdigLeie.BeforeTouchSize = New System.Drawing.Size(116, 42)
        Me.btnFerdigLeie.ForeColor = System.Drawing.Color.White
        Me.btnFerdigLeie.IsBackStageButton = False
        Me.btnFerdigLeie.Location = New System.Drawing.Point(54, 194)
        Me.btnFerdigLeie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFerdigLeie.Name = "btnFerdigLeie"
        Me.btnFerdigLeie.Size = New System.Drawing.Size(116, 42)
        Me.btnFerdigLeie.TabIndex = 32
        Me.btnFerdigLeie.Text = "Legg til leie"
        Me.btnFerdigLeie.UseVisualStyle = True
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Location = New System.Drawing.Point(380, 43)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(76, 17)
        Me.AutoLabel2.TabIndex = 34
        Me.AutoLabel2.Text = "Velg lager:"
        '
        'ComboProdukt
        '
        Me.ComboProdukt.FormattingEnabled = True
        Me.ComboProdukt.Location = New System.Drawing.Point(54, 64)
        Me.ComboProdukt.Name = "ComboProdukt"
        Me.ComboProdukt.Size = New System.Drawing.Size(121, 24)
        Me.ComboProdukt.TabIndex = 35
        '
        'ComboKunde
        '
        Me.ComboKunde.FormattingEnabled = True
        Me.ComboKunde.Location = New System.Drawing.Point(54, 129)
        Me.ComboKunde.Name = "ComboKunde"
        Me.ComboKunde.Size = New System.Drawing.Size(121, 24)
        Me.ComboKunde.TabIndex = 36
        '
        'ComboLager
        '
        Me.ComboLager.FormattingEnabled = True
        Me.ComboLager.Location = New System.Drawing.Point(380, 64)
        Me.ComboLager.Name = "ComboLager"
        Me.ComboLager.Size = New System.Drawing.Size(121, 24)
        Me.ComboLager.TabIndex = 37
        '
        'frmAddLeie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.ClientSize = New System.Drawing.Size(558, 266)
        Me.Controls.Add(Me.ComboLager)
        Me.Controls.Add(Me.ComboKunde)
        Me.Controls.Add(Me.ComboProdukt)
        Me.Controls.Add(Me.AutoLabel2)
        Me.Controls.Add(Me.btnFerdigLeie)
        Me.Controls.Add(Me.lblVelgKunde)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.lblTil)
        Me.Controls.Add(Me.lblfra)
        Me.Controls.Add(Me.dtpFra)
        Me.Controls.Add(Me.dtpTil)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddLeie"
        Me.ShowIcon = False
        Me.Text = "Legg til Leie"
        CType(Me.dtpTil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpTil As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Friend WithEvents dtpFra As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
    Friend WithEvents lblfra As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblTil As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblVelgKunde As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents btnFerdigLeie As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents ComboProdukt As ComboBox
    Friend WithEvents ComboKunde As ComboBox
    Friend WithEvents ComboLager As ComboBox
End Class
