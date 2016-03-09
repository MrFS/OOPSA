<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizardMetro
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
        Me.WizardControl1 = New Syncfusion.Windows.Forms.Tools.WizardControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WizardControl1.GridBagLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WizardControl1
        '
        '
        '
        '
        Me.WizardControl1.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WizardControl1.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.WizardControl1.BackButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.WizardControl1.BackButton.Enabled = False
        Me.WizardControl1.BackButton.IsBackStageButton = False
        Me.WizardControl1.BackButton.Location = New System.Drawing.Point(462, 488)
        Me.WizardControl1.BackButton.Name = "backButton"
        Me.WizardControl1.BackButton.Text = "<< Back"
        Me.WizardControl1.BackButton.UseVisualStyle = False
        Me.WizardControl1.BackButton.Visible = False
        Me.WizardControl1.Banner = Me.PictureBox1
        Me.WizardControl1.BannerPanel = Me.GradientPanel1
        '
        '
        '
        Me.WizardControl1.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WizardControl1.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.WizardControl1.CancelButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.WizardControl1.CancelButton.IsBackStageButton = False
        Me.WizardControl1.CancelButton.Location = New System.Drawing.Point(462, 488)
        Me.WizardControl1.CancelButton.Name = "cancelButton"
        Me.WizardControl1.CancelButton.Text = "Cancel"
        Me.WizardControl1.CancelButton.UseVisualStyle = False
        Me.WizardControl1.Controls.Add(Me.WizardContainer1)
        Me.WizardControl1.Controls.Add(Me.GradientPanel1)
        Me.WizardControl1.Description = Me.Label2
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.WizardControl1.FinishButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WizardControl1.FinishButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.WizardControl1.FinishButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.WizardControl1.FinishButton.IsBackStageButton = False
        Me.WizardControl1.FinishButton.Location = New System.Drawing.Point(542, 488)
        Me.WizardControl1.FinishButton.Name = "finishButton"
        Me.WizardControl1.FinishButton.Text = "Finish"
        Me.WizardControl1.FinishButton.UseVisualStyle = False
        '
        '
        '
        Me.WizardControl1.GridBagLayout.ContainerControl = Me.WizardControl1
        '
        '
        '
        Me.WizardControl1.HelpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.WizardControl1.HelpButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.WizardControl1.HelpButton.IsBackStageButton = False
        Me.WizardControl1.HelpButton.Location = New System.Drawing.Point(622, 488)
        Me.WizardControl1.HelpButton.Name = "helpButton"
        Me.WizardControl1.HelpButton.Text = "Help"
        Me.WizardControl1.HelpButton.UseVisualStyle = False
        Me.WizardControl1.Location = New System.Drawing.Point(0, 0)
        Me.WizardControl1.Name = "WizardControl1"
        '
        '
        '
        Me.WizardControl1.NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WizardControl1.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.WizardControl1.NextButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.WizardControl1.NextButton.Enabled = False
        Me.WizardControl1.NextButton.IsBackStageButton = False
        Me.WizardControl1.NextButton.Location = New System.Drawing.Point(462, 488)
        Me.WizardControl1.NextButton.Name = "nextButton"
        Me.WizardControl1.NextButton.Text = "Next >>"
        Me.WizardControl1.NextButton.UseVisualStyle = False
        Me.WizardControl1.NextButton.Visible = False
        Me.WizardControl1.SelectedWizardPage = Nothing
        Me.WizardControl1.Size = New System.Drawing.Size(702, 516)
        Me.WizardControl1.TabIndex = 0
        Me.WizardControl1.Title = Me.Label1
        Me.WizardControl1.WizardPageContainer = Me.WizardContainer1
        Me.WizardControl1.WizardPages = New Syncfusion.Windows.Forms.Tools.WizardControlPage(-1) {}
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GradientPanel1
        '
        Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel1.Controls.Add(Me.PictureBox1)
        Me.GradientPanel1.Controls.Add(Me.Label1)
        Me.GradientPanel1.Controls.Add(Me.Label2)
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(702, 70)
        Me.GradientPanel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is the title of the Wizard Page."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "This is the description of the Wizard Page."
        '
        'WizardContainer1
        '
        Me.WizardContainer1.Location = New System.Drawing.Point(0, 70)
        Me.WizardContainer1.Name = "WizardContainer1"
        Me.WizardContainer1.Size = New System.Drawing.Size(702, 405)
        Me.WizardContainer1.TabIndex = 1
        '
        'frmWizardMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CaptionBarColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.CaptionBarHeight = 48
        CaptionImage1.BackColor = System.Drawing.Color.Transparent
        CaptionImage1.Image = Global.OOPSA.My.Resources.Resources.usrAdd
        CaptionImage1.Name = "CaptionImage1"
        CaptionImage1.Size = New System.Drawing.Size(48, 48)
        Me.CaptionImages.Add(CaptionImage1)
        Me.ClientSize = New System.Drawing.Size(702, 516)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "frmWizardMetro"
        Me.ShowIcon = False
        Me.Text = "Legg Til Ny Ansatt"
        CType(Me.WizardControl1.GridBagLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WizardControl1 As Syncfusion.Windows.Forms.Tools.WizardControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer
End Class
