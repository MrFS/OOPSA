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

    Private WithEvents tmrUp As New Timer

    Public server As String = My.Settings.server
    Public database As String = My.Settings.database
    Public user As String = My.Settings.user
    Public pass As String = My.Settings.pass
    Public port As Integer = My.Settings.port

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
        tmrUp.Interval = 1000
        tmrUp.Start()
    End Sub

    Private Sub tmrUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUp.Tick
        getUpTime += 1
    End Sub

End Module
