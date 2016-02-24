Imports MySql.Data.MySqlClient

Public Class SQL

    ''' <summary>
    ''' Spørringsfunksjonen, legger inn sql spørringen som en string,
    ''' kjører den gjennom SQLCMD og SQLDA fyller DataTable med informasjonen som ble hentet.
    ''' Ble det ikke returnert noe, typ. en feil i SQL setningen vil det kjøres en 'Catch'
    ''' og en feilmelding vil vises med relevant informasjon.
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns>DT, Informasjon fra databasen</returns>

    Private Function sporring(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Try
            con.Open()
            Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Spørring feilet")
            con.Close()
            End
        Finally
            con.Dispose()
        End Try
        Return dt

    End Function

    Public Sub regAnsatt(bruker As String,
                         pw As String,
                         fornavn As String,
                         etternavn As String,
                         bursdag As Date,
                         epost As String,
                         tlf As Integer,
                         adresse As String,
                         avdeling As Integer)



    End Sub
End Class
