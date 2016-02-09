'Imports OOPSA.config
Imports MySql.Data.MySqlClient

Public Class DBConnect

    Public Sub ConnectDatabase()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "DATABASE=" & database & ";" _
                  & "SERVER=" & server & ";user id=" & user _
                  & ";password=" & pass & ";port=" &
                  port & ";charset=utf8"
                conn.Open()
            End If

        Catch myerror As Exception
            MessageBox.Show("Error Connecting to the database", "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch err As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(err.Message)
        End Try
    End Sub


End Class
