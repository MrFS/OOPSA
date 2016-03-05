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

    Public Function sporring(ByVal sql As String) As DataTable
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
        Finally
            con.Dispose()
        End Try
        Return dt

    End Function

    ''' <summary>
    ''' Prosedyre for registrering av ny ansatt
    ''' </summary>
    ''' <param name="bruker">Brukernavnet</param>
    ''' <param name="pw">Passordet</param>
    ''' <param name="fornavn">Fornavnet til ansatt</param>
    ''' <param name="etternavn">Etternavnet til ansatt</param>
    ''' <param name="bursdag">Bursdagen til ansatt, DATE</param>
    ''' <param name="epost">Epost til ansatt</param>
    ''' <param name="tlf">Telefonnummer til ansatt, integer</param>
    ''' <param name="adresse">Adressen til ansatt</param>
    ''' <param name="avdeling">Avdelingen ansatt tilhører, INTEGER</param>'

    Public Sub regAnsatt(bruker As String,
                         pw As String,
                         fornavn As String,
                         etternavn As String,
                         bursdag As Date,
                         epost As String,
                         tlf As Integer,
                         adresse As String,
                         avdeling As Integer)

        sporring("INSERT INTO logginn")
        sporring("INSERT INTO Ansatt")

    End Sub

    Public Sub seAnsatte()

        'Dim ds As DataSet

        'MsgBox(sporring("SELECT * FROM Ansatt"))

    End Sub
End Class
