<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLager
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
        Me.MiniToolBar1 = New Syncfusion.Windows.Forms.Tools.MiniToolBar()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.LagerLeggTil = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrisLeggTil = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NavnLeggTil = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AntLeggTil = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.VareEndre = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnPrisEndre = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnNavnEndre = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EndreKnapp = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnAntEndre = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.GridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
        Me.ProduktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Drift8_2016DataSet = New OOPSA.drift8_2016DataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ProduktTableAdapter = New OOPSA.drift8_2016DataSetTableAdapters.ProduktTableAdapter()
        Me.lagerEndre = New System.Windows.Forms.ComboBox()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        CType(Me.PrisLeggTil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavnLeggTil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AntLeggTil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAdv2.SuspendLayout()
        CType(Me.BtnPrisEndre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNavnEndre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAntEndre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAdv3.SuspendLayout()
        Me.TabPageAdv4.SuspendLayout()
        CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drift8_2016DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MiniToolBar1
        '
        Me.MiniToolBar1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MiniToolBar1.Name = "MiniToolBar1"
        Me.MiniToolBar1.Size = New System.Drawing.Size(24, 24)
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(1190, 563)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv1)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv3)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv4)
        Me.TabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAdv1.ItemSize = New System.Drawing.Size(83, 48)
        Me.TabControlAdv1.Location = New System.Drawing.Point(0, 40)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.Size = New System.Drawing.Size(1190, 563)
        Me.TabControlAdv1.TabIndex = 2
        Me.TabControlAdv1.ThemesEnabled = True
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.Controls.Add(Me.LagerLeggTil)
        Me.TabPageAdv1.Controls.Add(Me.Button1)
        Me.TabPageAdv1.Controls.Add(Me.Label10)
        Me.TabPageAdv1.Controls.Add(Me.PrisLeggTil)
        Me.TabPageAdv1.Controls.Add(Me.Label11)
        Me.TabPageAdv1.Controls.Add(Me.NavnLeggTil)
        Me.TabPageAdv1.Controls.Add(Me.Label12)
        Me.TabPageAdv1.Controls.Add(Me.AntLeggTil)
        Me.TabPageAdv1.Controls.Add(Me.Label14)
        Me.TabPageAdv1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageAdv1.Image = Nothing
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv1.Location = New System.Drawing.Point(3, 53)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(1183, 506)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = "Legge til varer"
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'LagerLeggTil
        '
        Me.LagerLeggTil.FormattingEnabled = True
        Me.LagerLeggTil.Location = New System.Drawing.Point(138, 181)
        Me.LagerLeggTil.Margin = New System.Windows.Forms.Padding(2)
        Me.LagerLeggTil.Name = "LagerLeggTil"
        Me.LagerLeggTil.Size = New System.Drawing.Size(92, 23)
        Me.LagerLeggTil.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 227)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 24)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Legg til"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Endre lager :"
        '
        'PrisLeggTil
        '
        Me.PrisLeggTil.BeforeTouchSize = New System.Drawing.Size(116, 23)
        Me.PrisLeggTil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrisLeggTil.Location = New System.Drawing.Point(130, 148)
        Me.PrisLeggTil.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.PrisLeggTil.Name = "PrisLeggTil"
        Me.PrisLeggTil.Size = New System.Drawing.Size(100, 23)
        Me.PrisLeggTil.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.PrisLeggTil.TabIndex = 22
        Me.PrisLeggTil.Text = "TextBoxExt6"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Pris :"
        '
        'NavnLeggTil
        '
        Me.NavnLeggTil.BeforeTouchSize = New System.Drawing.Size(116, 23)
        Me.NavnLeggTil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NavnLeggTil.Location = New System.Drawing.Point(130, 112)
        Me.NavnLeggTil.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.NavnLeggTil.Name = "NavnLeggTil"
        Me.NavnLeggTil.Size = New System.Drawing.Size(100, 23)
        Me.NavnLeggTil.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.NavnLeggTil.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Navn :"
        '
        'AntLeggTil
        '
        Me.AntLeggTil.BeforeTouchSize = New System.Drawing.Size(116, 23)
        Me.AntLeggTil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AntLeggTil.Location = New System.Drawing.Point(130, 76)
        Me.AntLeggTil.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.AntLeggTil.Name = "AntLeggTil"
        Me.AntLeggTil.Size = New System.Drawing.Size(100, 23)
        Me.AntLeggTil.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.AntLeggTil.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(56, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Antall :"
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.Controls.Add(Me.lagerEndre)
        Me.TabPageAdv2.Controls.Add(Me.VareEndre)
        Me.TabPageAdv2.Controls.Add(Me.Label9)
        Me.TabPageAdv2.Controls.Add(Me.BtnPrisEndre)
        Me.TabPageAdv2.Controls.Add(Me.Label8)
        Me.TabPageAdv2.Controls.Add(Me.BtnNavnEndre)
        Me.TabPageAdv2.Controls.Add(Me.Label7)
        Me.TabPageAdv2.Controls.Add(Me.EndreKnapp)
        Me.TabPageAdv2.Controls.Add(Me.btnAntEndre)
        Me.TabPageAdv2.Controls.Add(Me.Label4)
        Me.TabPageAdv2.Controls.Add(Me.Label3)
        Me.TabPageAdv2.Image = Nothing
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(3, 53)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(1183, 506)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "Endre vare beholdning"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'VareEndre
        '
        Me.VareEndre.FormattingEnabled = True
        Me.VareEndre.Location = New System.Drawing.Point(188, 14)
        Me.VareEndre.Margin = New System.Windows.Forms.Padding(2)
        Me.VareEndre.Name = "VareEndre"
        Me.VareEndre.Size = New System.Drawing.Size(92, 21)
        Me.VareEndre.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(100, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Endre lager :"
        '
        'BtnPrisEndre
        '
        Me.BtnPrisEndre.BeforeTouchSize = New System.Drawing.Size(116, 23)
        Me.BtnPrisEndre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BtnPrisEndre.Location = New System.Drawing.Point(188, 100)
        Me.BtnPrisEndre.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnPrisEndre.Name = "BtnPrisEndre"
        Me.BtnPrisEndre.Size = New System.Drawing.Size(100, 20)
        Me.BtnPrisEndre.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.BtnPrisEndre.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(126, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ny  pris :"
        '
        'BtnNavnEndre
        '
        Me.BtnNavnEndre.BeforeTouchSize = New System.Drawing.Size(116, 23)
        Me.BtnNavnEndre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BtnNavnEndre.Location = New System.Drawing.Point(188, 76)
        Me.BtnNavnEndre.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnNavnEndre.Name = "BtnNavnEndre"
        Me.BtnNavnEndre.Size = New System.Drawing.Size(100, 20)
        Me.BtnNavnEndre.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.BtnNavnEndre.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nytt navn :"
        '
        'EndreKnapp
        '
        Me.EndreKnapp.BeforeTouchSize = New System.Drawing.Size(167, 29)
        Me.EndreKnapp.IsBackStageButton = False
        Me.EndreKnapp.Location = New System.Drawing.Point(153, 176)
        Me.EndreKnapp.Name = "EndreKnapp"
        Me.EndreKnapp.Size = New System.Drawing.Size(167, 29)
        Me.EndreKnapp.TabIndex = 4
        Me.EndreKnapp.Text = "Endre vare"
        '
        'btnAntEndre
        '
        Me.btnAntEndre.BeforeTouchSize = New System.Drawing.Size(116, 23)
        Me.btnAntEndre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnAntEndre.Location = New System.Drawing.Point(188, 50)
        Me.btnAntEndre.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnAntEndre.Name = "btnAntEndre"
        Me.btnAntEndre.Size = New System.Drawing.Size(100, 20)
        Me.btnAntEndre.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.btnAntEndre.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nytt antall :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Velg vare"
        '
        'TabPageAdv3
        '
        Me.TabPageAdv3.Controls.Add(Me.ComboBox2)
        Me.TabPageAdv3.Controls.Add(Me.ButtonAdv2)
        Me.TabPageAdv3.Controls.Add(Me.Label2)
        Me.TabPageAdv3.Image = Nothing
        Me.TabPageAdv3.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv3.Location = New System.Drawing.Point(3, 53)
        Me.TabPageAdv3.Name = "TabPageAdv3"
        Me.TabPageAdv3.ShowCloseButton = True
        Me.TabPageAdv3.Size = New System.Drawing.Size(1183, 506)
        Me.TabPageAdv3.TabIndex = 3
        Me.TabPageAdv3.Text = "Fjerne varer"
        Me.TabPageAdv3.ThemesEnabled = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(427, 93)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ButtonAdv2
        '
        Me.ButtonAdv2.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.ButtonAdv2.IsBackStageButton = False
        Me.ButtonAdv2.Location = New System.Drawing.Point(427, 139)
        Me.ButtonAdv2.Name = "ButtonAdv2"
        Me.ButtonAdv2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdv2.TabIndex = 2
        Me.ButtonAdv2.Text = "Slett"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Velg vare :"
        '
        'TabPageAdv4
        '
        Me.TabPageAdv4.Controls.Add(Me.GridDataBoundGrid1)
        Me.TabPageAdv4.Controls.Add(Me.Label5)
        Me.TabPageAdv4.Image = Nothing
        Me.TabPageAdv4.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv4.Location = New System.Drawing.Point(3, 53)
        Me.TabPageAdv4.Name = "TabPageAdv4"
        Me.TabPageAdv4.ShowCloseButton = True
        Me.TabPageAdv4.Size = New System.Drawing.Size(1183, 506)
        Me.TabPageAdv4.TabIndex = 4
        Me.TabPageAdv4.Text = "Oversikt"
        Me.TabPageAdv4.ThemesEnabled = False
        '
        'GridDataBoundGrid1
        '
        Me.GridDataBoundGrid1.AllowDragSelectedCols = True
        Me.GridDataBoundGrid1.DataMember = ""
        Me.GridDataBoundGrid1.DataSource = Me.ProduktBindingSource
        Me.GridDataBoundGrid1.Location = New System.Drawing.Point(324, 3)
        Me.GridDataBoundGrid1.Name = "GridDataBoundGrid1"
        Me.GridDataBoundGrid1.OptimizeInsertRemoveCells = True
        Me.GridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.GridDataBoundGrid1.Size = New System.Drawing.Size(855, 500)
        Me.GridDataBoundGrid1.SmartSizeBox = False
        Me.GridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.GridDataBoundGrid1.TabIndex = 3
        Me.GridDataBoundGrid1.Text = "GridDataBoundGrid1"
        Me.GridDataBoundGrid1.UseListChangedEvent = True
        Me.GridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
        '
        'ProduktBindingSource
        '
        Me.ProduktBindingSource.DataMember = "Produkt"
        Me.ProduktBindingSource.DataSource = Me.Drift8_2016DataSet
        '
        'Drift8_2016DataSet
        '
        Me.Drift8_2016DataSet.DataSetName = "drift8_2016DataSet"
        Me.Drift8_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Legge til stats her?"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Size = New System.Drawing.Size(1190, 40)
        Me.ToolStripEx1.TabIndex = 0
        Me.ToolStripEx1.Text = "ToolStripEx1"
        Me.ToolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro
        '
        'ProduktTableAdapter
        '
        Me.ProduktTableAdapter.ClearBeforeFill = True
        '
        'lagerEndre
        '
        Me.lagerEndre.FormattingEnabled = True
        Me.lagerEndre.Location = New System.Drawing.Point(188, 136)
        Me.lagerEndre.Name = "lagerEndre"
        Me.lagerEndre.Size = New System.Drawing.Size(121, 21)
        Me.lagerEndre.TabIndex = 14
        '
        'frmLager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        Me.ClientSize = New System.Drawing.Size(1190, 603)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Controls.Add(Me.ToolStripEx1)
        Me.Name = "frmLager"
        Me.Text = "Form1"
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.TabPageAdv1.PerformLayout()
        CType(Me.PrisLeggTil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavnLeggTil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AntLeggTil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAdv2.ResumeLayout(False)
        Me.TabPageAdv2.PerformLayout()
        CType(Me.BtnPrisEndre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNavnEndre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAntEndre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAdv3.ResumeLayout(False)
        Me.TabPageAdv3.PerformLayout()
        Me.TabPageAdv4.ResumeLayout(False)
        Me.TabPageAdv4.PerformLayout()
        CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drift8_2016DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MiniToolBar1 As Syncfusion.Windows.Forms.Tools.MiniToolBar
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents TabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv4 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents EndreKnapp As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents btnAntEndre As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents Label5 As Label
    Friend WithEvents GridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents Label10 As Label
    Friend WithEvents PrisLeggTil As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label11 As Label
    Friend WithEvents NavnLeggTil As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label12 As Label
    Friend WithEvents AntLeggTil As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnPrisEndre As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnNavnEndre As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LagerLeggTil As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents VareEndre As ComboBox
    Friend WithEvents Drift8_2016DataSet As drift8_2016DataSet
    Friend WithEvents ProduktBindingSource As BindingSource
    Friend WithEvents ProduktTableAdapter As drift8_2016DataSetTableAdapters.ProduktTableAdapter
    Friend WithEvents lagerEndre As ComboBox
End Class
