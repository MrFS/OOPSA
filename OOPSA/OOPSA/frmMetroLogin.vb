Imports Syncfusion.Windows.Forms

Public Class frmMetroLogin
    Inherits MetroForm

    Private Sub frmMetroLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F10
                txtUsr.Text = "//ADMINISTRATOR"
                txtUsr.Enabled = 0
            Case Keys.F12
                frmConsole.Show()
        End Select
    End Sub
End Class
