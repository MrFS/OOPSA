<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTst
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
        Me.Model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
        Me.SparkLine1 = New Syncfusion.Windows.Forms.Chart.SparkLine()
        CType(Me.Model1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Model1
        '
        Me.Model1.AlignmentType = AlignmentType.SelectedNode
        Me.Model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
        Me.Model1.DocumentScale.DisplayName = "No Scale"
        Me.Model1.DocumentScale.Height = 1.0!
        Me.Model1.DocumentScale.Width = 1.0!
        Me.Model1.DocumentSize.Height = 1169.0!
        Me.Model1.DocumentSize.Width = 827.0!
        Me.Model1.LineStyle.DashPattern = Nothing
        Me.Model1.LineStyle.LineColor = System.Drawing.Color.Black
        Me.Model1.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
        Me.Model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        '
        'SparkLine1
        '
        Me.SparkLine1.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        Me.SparkLine1.EndPoint = 10.0R
        Me.SparkLine1.HighPoint = 90.0R
        Me.SparkLine1.Location = New System.Drawing.Point(340, 159)
        Me.SparkLine1.LowPoint = 10.0R
        Me.SparkLine1.Name = "SparkLine1"
        Me.SparkLine1.NegativeItem = New Double() {0R, 0R, 0R, 0R, 0R}
        Me.SparkLine1.Size = New System.Drawing.Size(304, 120)
        Me.SparkLine1.Source = New Double() {20.0R, 90.0R, 30.0R, 60.0R, 10.0R}
        Me.SparkLine1.StartPoint = 20.0R
        Me.SparkLine1.TabIndex = 0
        Me.SparkLine1.Text = "SparkLine1"
        Me.SparkLine1.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.Line
        '
        'frmTst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 433)
        Me.Controls.Add(Me.SparkLine1)
        Me.Name = "frmTst"
        Me.Text = "Form1"
        CType(Me.Model1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Model1 As Syncfusion.Windows.Forms.Diagram.Model
    Friend WithEvents SparkLine1 As Syncfusion.Windows.Forms.Chart.SparkLine
End Class
