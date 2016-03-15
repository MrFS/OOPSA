<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim Binding1 As Syncfusion.Windows.Forms.Diagram.Binding = New Syncfusion.Windows.Forms.Diagram.Binding()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
        Me.Model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
        CType(Me.Diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Model1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 652)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1584, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1584, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Diagram1
        '
        Binding1.DefaultConnector = Nothing
        Binding1.DefaultNode = Nothing
        Binding1.Diagram = Me.Diagram1
        Binding1.Id = Nothing
        Binding1.Label = CType(resources.GetObject("Binding1.Label"), System.Collections.Generic.List(Of String))
        Binding1.ParentId = Nothing
        Me.Diagram1.Binding = Binding1
        Me.Diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
        Me.Diagram1.LayoutManager = Nothing
        Me.Diagram1.Location = New System.Drawing.Point(772, 99)
        Me.Diagram1.Model = Me.Model1
        Me.Diagram1.Name = "Diagram1"
        Me.Diagram1.ScrollVirtualBounds = CType(resources.GetObject("Diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
        Me.Diagram1.Size = New System.Drawing.Size(185, 185)
        Me.Diagram1.SmartSizeBox = False
        Me.Diagram1.TabIndex = 2
        Me.Diagram1.Text = "Diagram1"
        '
        '
        '
        Me.Diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.Diagram1.View.Controller = Me.Diagram1.Controller
        Me.Diagram1.View.Grid.MinPixelSpacing = 4.0!
        Me.Diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
        Me.Diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 674)
        Me.Controls.Add(Me.Diagram1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        CType(Me.Diagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Model1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
    Friend WithEvents Model1 As Syncfusion.Windows.Forms.Diagram.Model
End Class
