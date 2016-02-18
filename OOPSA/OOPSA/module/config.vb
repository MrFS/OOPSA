Imports MySql.Data.MySqlClient

Module config

    Public server As String = My.Settings.server
    Public database As String = My.Settings.database
    Public user As String = My.Settings.user
    Public pass As String = My.Settings.pass
    Public port As String = My.Settings.port


    Public conn As New MySqlConnection
    'Sett følgende verdier inn i project settings! Dette gir administrator mulighet til å endre verdiene til databasen selv, uten at vi må inn i kildekode!
    '    Name         Type      Scope   Value
    'myDB ->      String -> User -> DatabaseName
    'myServer->   String -> User -> Servername
    'myUsername-> String -> User -> DbUserName
    'myPassword-> String -> User -> DbPassword
    'myPort->     String -> User -> mySQLPort(3306)

    'Ny kode for unnagjort steget over:
    'If conn.State = ConnectionState.Closed Then
    '            conn.ConnectionString = "DATABASE=" & My.Settings.myDB &amp;amp;amp; ";" _
    '              & "SERVER=" & My.Settings.myServer & ";user id=" & My.Settings.myUsername _
    '              & ";password=" & My.Settings.myPassword &amp;amp;amp;";port=" & _
    '              My.Settings.myPort &amp;amp;amp; ";charset=utf8"
    '            conn.Open()
    '        End If

End Module
