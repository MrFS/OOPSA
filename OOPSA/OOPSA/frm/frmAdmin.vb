Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtServer.Enabled = 0
        txtDB.Enabled = 0
        txtPort.Enabled = 0
        txtDBUser.Enabled = 0
        txtDBpwd.Enabled = 0

        txtServer.Text = server
        txtDB.Text = database
        txtPort.Text = port
        txtDBUser.Text = user
        txtDBpwd.Text = pass

    End Sub

    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        If ChangeToolStripMenuItem.Text = "Change" Then
            'Add global ADMIN pw
            ChangeToolStripMenuItem.Text = "Save"
            txtServer.Enabled = 1
            txtDB.Enabled = 1
            txtPort.Enabled = 1
            txtDBUser.Enabled = 1
            txtDBpwd.Enabled = 1

            My.Settings.server = txtServer.Text
            My.Settings.database = txtDB.Text
            My.Settings.user = txtDBUser.Text
            My.Settings.pass = txtDBpwd.Text
            My.Settings.port = txtPort.Text

            My.Settings.Save()

        Else
            ChangeToolStripMenuItem.Text = "Change"
            txtServer.Enabled = 0
            txtDB.Enabled = 0
            txtPort.Enabled = 0
            txtDBUser.Enabled = 0
            txtDBpwd.Enabled = 0

            My.Settings.server = txtServer.Text
            My.Settings.database = txtDB.Text
            My.Settings.user = txtDBUser.Text
            My.Settings.pass = txtDBpwd.Text
            My.Settings.port = txtPort.Text

            My.Settings.Save()

        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        My.Settings.Reload()
    End Sub
End Class