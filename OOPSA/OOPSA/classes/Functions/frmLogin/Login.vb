Imports MySql.Data.MySqlClient

Public Class Login
    Public Sub Login(user As String, pass As String)
        Dim SHA As New SHA512

        user = My.Forms.frmMetroLogin.txtUsr.Text.Replace("'", "\'")
        pass = My.Forms.frmMetroLogin.txtPw.Text.Replace("'", "\'")

        'Dim pw = SHA.ToHashSHA512(pass)

        SHA.ToHashSHA512 = pass

        pass = SHA.ToHashSHA512

        Dim da = New MySqlDataAdapter("SELECT Brukernavn, Passord FROM Loggin WHERE Brukernavn='" & user & "' AND Passord='" & pass & "'", con)

        Dim ds = New DataSet

        da.Fill(ds, "Login")

        If (ds.Tables("Login").Rows.Count > 0) Then
            frmAdminMetro.Show()
            MsgBox("Du er logget inn som: " & user)
        Else
            MsgBox("Feil bruker/pass")
        End If

    End Sub
End Class
