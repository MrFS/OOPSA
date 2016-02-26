Imports MySql.Data.MySqlClient

Module config

    ''' <summary>
    ''' Modul, henter info fra My.Settings og lagrer i respektive variabler, public gjør de tilgjengelig 
    ''' gjennom hele applikasjonen.
    ''' Gjør arbeidsprosessen enklere ved å tildele korte variabler istedenfor å skrive hele My.Settings linjen.
    ''' 
    ''' Huser også con variablen for MySQL
    ''' </summary>

    Public server As String = My.Settings.server
    Public database As String = My.Settings.database
    Public user As String = My.Settings.user
    Public pass As String = My.Settings.pass
    Public port As String = My.Settings.port


    Public con As New MySqlConnection

    Public online = My.Computer.Network.Ping(server)
    Public ping As New System.Net.NetworkInformation.Ping
    Public ms = ping.Send(server).RoundtripTime()

    Public ToBase64EncString As String
    Public FromBase64EncString As String

End Module
