Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtServer.Enabled = 0
        txtDB.Enabled = 0
        txtPort.Enabled = 0
        txtDBUser.Enabled = 0
        txtDBpwd.Enabled = 0

        txtServer.Text = My.Settings.server
        txtDB.Text = My.Settings.database
        txtPort.Text = My.Settings.port
        txtDBUser.Text = My.Settings.user
        txtDBpwd.Text = My.Settings.pass

    End Sub
End Class