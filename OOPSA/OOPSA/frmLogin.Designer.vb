<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DigitalClockRenderer1 As Syncfusion.Windows.Forms.Tools.DigitalClockRenderer = New Syncfusion.Windows.Forms.Tools.DigitalClockRenderer()
        Dim ClockRenderer1 As Syncfusion.Windows.Forms.Tools.ClockRenderer = New Syncfusion.Windows.Forms.Tools.ClockRenderer()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Clock1 = New Syncfusion.Windows.Forms.Tools.Clock()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(121, 2)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(121, 53)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(123, 26)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 22)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(123, 76)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(152, 106)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(93, 33)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(251, 106)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(93, 33)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'Clock1
        '
        Me.Clock1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Clock1.BeforeTouchSize = New System.Drawing.Size(100, 100)
        Me.Clock1.ClockFormat = "HH:mm:ss"
        Me.Clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame
        Me.Clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle
        Me.Clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Analog
        Me.Clock1.CurrentDateTime = New Date(2016, 3, 4, 20, 28, 28, 174)
        Me.Clock1.CustomTime = New Date(2016, 3, 4, 20, 28, 28, 174)
        Me.Clock1.DigitalRenderer = DigitalClockRenderer1
        Me.Clock1.DisplayDates = True
        Me.Clock1.Location = New System.Drawing.Point(16, 15)
        Me.Clock1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Clock1.MinimumSize = New System.Drawing.Size(100, 92)
        Me.Clock1.Name = "Clock1"
        Me.Clock1.Now = New Date(CType(0, Long))
        Me.Clock1.Remainder = New Date(2016, 3, 4, 20, 28, 28, 174)
        Me.Clock1.Renderer = ClockRenderer1
        Me.Clock1.ShowClockFrame = False
        Me.Clock1.ShowCustomTimeClock = False
        Me.Clock1.ShowHourDesignator = False
        Me.Clock1.Size = New System.Drawing.Size(100, 100)
        Me.Clock1.StopTimer = False
        Me.Clock1.TabIndex = 6
        Me.Clock1.Text = "Clock1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(349, 144)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OOPSA - AS TurCare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clock1 As Syncfusion.Windows.Forms.Tools.Clock
    Friend WithEvents Button1 As Button
End Class
