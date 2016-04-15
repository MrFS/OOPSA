Imports MySql.Data.MySqlClient
Imports OOPSA.SQL

Public Class UserCore

    ''' <summary>
    ''' Husker brukernavnet til personen som har logget inn
    ''' </summary>

    Public currentUsr As String

    ''' <summary>
    ''' Mottar brukernavnet fra frmMetroLogin (Refererer til referanser)
    ''' Returnerer brukernavnet når aktuelt
    ''' </summary>
    ''' <returns>brukernavn</returns>

    Public Property crntUsr As String
        Get
            Return currentUsr
        End Get
        Set(ByVal value As String)
            currentUsr = value
        End Set
    End Property


    Public Function Getuserid(Username As String)

        Dim Brukerid As Integer
        Dim sqlstring As String = ("SELECT idLoggin from Loggin where Brukernavn = " & Username & "")
        Dim sql As New SQL

        'Dim dataadapter As New MySqlDataAdapter()
        'Dim cmd As New MySqlCommand(sqlstring, con)  'Takk takk FS


        'dataadapter.SelectCommand = cmd

        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource
        'Dim SDA As New MySqlDataAdapter

        'SDA.SelectCommand = cmd
        'SDA.Fill(dbdataset)
        'bsource.DataSource = dbdataset 'Takk takk FS

        Brukerid = sql.bindingsource(sqlstring)

        Return Brukerid

    End Function



End Class
