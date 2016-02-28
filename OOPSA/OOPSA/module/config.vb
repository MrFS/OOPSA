Imports MySql.Data.MySqlClient

Module config

    ''' <summary>
    ''' Modul, henter info fra My.Settings og lagrer i respektive variabler, public gjør de tilgjengelig 
    ''' gjennom hele applikasjonen.
    ''' Gjør arbeidsprosessen enklere ved å tildele korte variabler istedenfor å skrive hele My.Settings linjen.
    ''' 
    ''' Huser også con variablen for MySQL
    ''' </summary>
    ''' 

    Private WithEvents Timer1 As New Timer

    Public server As String = My.Settings.server
    Public database As String = My.Settings.database
    Public user As String = My.Settings.user
    Public pass As String = My.Settings.pass
    Public port As String = My.Settings.port

    Public currentUser As String

    Public getUpTime As Integer


    Public con As New MySqlConnection

    Public online = My.Computer.Network.Ping(server)
    Public ping As New System.Net.NetworkInformation.Ping


    Public ToBase64EncString As String
    Public FromBase64EncString As String

    Public Sub Initialize()

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpTime()
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        getUpTime += 1
    End Sub

End Module
