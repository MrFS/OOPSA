Imports Syncfusion.Windows.Forms
Imports OOPSA.versionController
Imports OOPSA.Update


Public Class frmMetroLogin
    Inherits MetroForm

    Dim Login As New Login

    Private Sub frmMetroLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F10
                txtUsr.Text = "//ADMINISTRATOR"
                txtUsr.Enabled = 0
            Case Keys.F12
                frmConsole.Show()
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmConsole.Show()
    End Sub

    Private Sub btnLgInn_Click(sender As Object, e As EventArgs) Handles btnLgInn.Click
        Login.Login(txtUsr.Text, txtPw.Text)
    End Sub

    Private Sub frmMetroLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DB As New DBConnect

        Dim Update As New Update


        Update.checkUpdate()

        If Update.isUpdate() = True Then
            Update.runUpdate()
        End If

        Try

            DB.ConnectDatabase()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DB.DisconnectDatabase()
        End Try

        MsgBox(major & minor & build & revision)

        MsgBox(Application.ProductVersion)

    End Sub
End Class
