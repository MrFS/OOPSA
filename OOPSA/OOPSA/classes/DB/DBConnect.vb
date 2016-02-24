'Imports OOPSA.config
Imports MySql.Data.MySqlClient

Public Class DBConnect

    ''' <summary>
    ''' Prosedyren nedenfor kobler opp mot databasen,
    ''' først sjekker den om koblingen er lukket før den prøver å koble opp mot DB,
    ''' slik ungår vi å prøve å koble opp mot databasen når den allerede er koblet opp mot.
    ''' henter relevant oppkoblingsinfo fra applikasjonens My.Settings
    ''' 
    ''' Får den ikke opprettet en kobling utføres en 'Catch'
    ''' Relevant informasjon vises i en msgbox.
    ''' </summary>

    Public Sub ConnectDatabase()

        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "DATABASE=" & database & ";" _
                  & "SERVER=" & server & ";user id=" & user _
                  & ";password=" & pass & ";port=" &
                  port & ";charset=utf8"
                con.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Error Connecting to the database : " & ex.Message, "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    ''' <summary>
    ''' Kobler fra databasen, får den ikke koblet fra databasen, grunnet ett eller annet kjøres
    ''' en 'Catch' og relevant informasjon vises i en msgbox.
    ''' </summary>

    Public Sub DisconnectDatabase()
        Try
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error closing the connection : " & ex.Message, "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
