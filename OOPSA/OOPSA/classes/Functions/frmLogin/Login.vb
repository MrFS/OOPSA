Imports MySql.Data.MySqlClient

Public Class Login
    Public Sub Login(user As String, pass As String)
        Dim SHA As New SHA512

        user = My.Forms.frmMetroLogin.txtUsr.Text.Replace("'", "\'")
        pass = My.Forms.frmMetroLogin.txtPw.Text.Replace("'", "\'")

        'Dim pw = SHA.ToHashSHA512(pass)

        SHA.ToHashSHA512 = pass

        pass = SHA.ToHashSHA512

        Dim da = New MySqlDataAdapter("SELECT Brukernavn, Passord, avd FROM Loggin WHERE Brukernavn='" & user & "' AND Passord='" & pass & "'", con)
        'Dim daAvd = New MySqlDataAdapter("SELECT ")

        Dim ds = New DataSet

        da.Fill(ds, "Login")

        If (ds.Tables("Login").Rows.Count > 0) Then

            Dim avd As String = ds.Tables("Login").Rows(0).Item(2).ToString

            Select Case avd
                Case = "dl"
                    frmAdminMetro.Show()
                    MsgBox("Du er logget inn som: " & user)
                Case = "salg"
                    frmSalgMetro.Show()
                    MsgBox("Du er logget inn som: " & user)
                Case = "lager"
                    frmLagerMetro.Show()
                    MsgBox("Du er logget inn som: " & user)
                Case Else
                    Exit Select
            End Select

        Else
            MsgBox("Feil bruker/pass")
        End If

    End Sub
End Class
