Imports Syncfusion.Windows.Forms
Imports OOPSA.versionController
Imports OOPSA.Update

Imports System.IO
Imports System.Net

''' <summary>
''' frmMetroLogin
''' Dim variabelen Login as new Login (Class : Classes/Functions/frmLogin)
''' Gir muligheten for inlogging ved å sammenligne tastet informasjon med informasjonen i databasen.
''' </summary>
Public Class frmMetroLogin
    Inherits MetroForm

    Dim Login As New Login

    ''' <summary>
    ''' KeyPreview = True
    ''' Når brukeren trykker F12, vises frmConsole
    ''' hvor brukeren for tilgang til diverse informasjon.
    ''' Samme kan også oppnås ved å trykke på Kiwi i frm under runtime
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMetroLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                frmConsole.Show()
            Case Keys.Enter
                Login.Login(txtUsr.Text, txtPw.Text)
        End Select
    End Sub

    ''' <summary>
    ''' Når brukeren trykker på Kiwi, vises frmConsole
    ''' hvor brukeren får tilgang til diverse informasjon.
    ''' Samme kan også oppnås ved å trykke F12 under runtime
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmConsole.Show()
    End Sub

    ''' <summary>
    ''' Refererer til class Login når bruker trykker btnLogin
    ''' Sender relevant informasjon over til referert class(Login)
    ''' txtUsr as "user" og txtPw as "pass"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLgInn_Click(sender As Object, e As EventArgs) Handles btnLgInn.Click
        Login.Login(txtUsr.Text, txtPw.Text)
    End Sub

    ''' <summary>
    ''' Nedenfor er koden som kjøres når frmMetroLogin blir lastet
    ''' Variablene DB, Update, User, chk refererer til respektive classer
    ''' 
    ''' DEN KODEN HER MÅ RYDDES FØR MER SKRIVES I COMMENTS
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMetroLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim DB As New DBConnect

        Dim Update As New Update

        Dim User As New UserCore

        Dim chk As New DBCheck

        Dim SHA As New SHA512

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

        Dim test As String = "aaa"

        SHA.ToHashSHA512 = test

        test = SHA.ToHashSHA512

        txtUsr.Text = test


    End Sub

    ''' <summary>
    ''' Viser frmForgotPass når brukeren trykker på nøkkelen i frmMetroLogin
    ''' Gir brukeren mulighet til å endre passord på sin bruker ved hjelp av registrert epostadresse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmForgotPass.Show()
    End Sub

    Private Sub frmMetroLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Environment.Exit(0)
    End Sub
End Class
