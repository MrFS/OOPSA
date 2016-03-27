Imports Syncfusion.Windows.Forms
Imports OOPSA.versionController
Imports OOPSA.Update

Imports System.IO
Imports System.Net


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

        Dim User As New UserCore

        Dim chk As New DBCheck

        chk.DBCheck()

        Dim dlAdress As String = "https://mrfs.me/school/oopsa/"
        Dim WebVersion As String = "https://mrfs.me/school/oopsa/version.txt"
        Dim client As WebClient = New WebClient()

        Dim vReader As StreamReader = New StreamReader(client.OpenRead(WebVersion))

        Update.checkUpdate()

        If Update.isUpdate() = True Then
            Update.runUpdate()

            lblNewVersion.Visible = True
            lblUpdateAvailable.Visible = True
            pxUpdate.Visible = True
        End If

        Try

            DB.ConnectDatabase()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DB.DisconnectDatabase()
        End Try

        User.crntUsr = txtUsr.Text

        lblVersion.Text = ("Current Version: " & version)

        lblNewVersion.Text = ("New version: " & vReader.ReadToEnd)

        'MsgBox(major & minor & build & revision)

        'MsgBox(Application.ProductVersion)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmForgotPass.Show()
    End Sub
End Class
