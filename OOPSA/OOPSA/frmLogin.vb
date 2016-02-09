Public Class frmLogin
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F10
                UsernameTextBox.Text = "//ADMINISTRATOR"
                UsernameTextBox.Enabled = 0

        End Select
    End Sub

    Private Sub UsernameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                PasswordTextBox.Focus()
        End Select
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                'KOde for inlogging
                If UsernameTextBox.Enabled = 0 Then
                    'KOde for admin inlogging
                    MsgBox("ADmin")
                    frmAdmin.Show()
                Else
                    'KOde for ansatt
                    MsgBox("Ansatt")
                End If
        End Select

        Me.Hide()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Focus()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        If UsernameTextBox.Enabled = 0 Then
            'KOde for admin inlogging
            MsgBox("ADmin")
            frmAdmin.Show()
        Else
            'KOde for ansatt
            MsgBox("Ansatt")
        End If

        Me.Hide()
    End Sub
End Class
