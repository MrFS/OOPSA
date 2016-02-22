'Imports OOPSA.config
Imports MySql.Data.MySqlClient
'Class for oppkobling mot database
'Database info finnes i My.Settings

'Variablene er lagret i en modul, som gjør de tilgjengelige over hele applikasjonen. ( & ikke lokalt for hver frm)

Public Class DBConnect

    Public Sub ConnectDatabase()

        'Se om koblingen mot databasen er avsluttet, hvis så koble opp mot den.
        'Lurt slik at man ikke prøver å kjøre doble oppkoblinger / koblinger.

        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "DATABASE=" & database & ";" _
                  & "SERVER=" & server & ";user id=" & user _
                  & ";password=" & pass & ";port=" &
                  port & ";charset=utf8"
                con.Open()
            End If

            'Støtter vi på en feil, kjører vi en 'Catch'

        Catch ex As Exception
            MessageBox.Show("Error Connecting to the database : " & ex.Message, "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    Public Sub DisconnectDatabase()
        Try
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error closing the connection : " & ex.Message, "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


End Class
