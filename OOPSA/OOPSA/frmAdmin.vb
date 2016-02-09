Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dbNfo.Items
            .Add("Server: " & My.Settings.server)
            .Add("Database: " & My.Settings.database)
            .Add("Port: " & My.Settings.port)
            .Add("Username: " & My.Settings.user)
            .Add("Overview:")
            .Add(My.Settings.server & ":" & My.Settings.port & " // " & My.Settings.database)
            .Add(port)

            'Sett opp mulighet for å se database passord på server, trenger admin passordet for sikkerhetssjekk. Typ, trykk en knapp i menustrip, promt adminpw, vis ny nfo
        End With
    End Sub
End Class