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

    Public UID As Integer
    Public Property UIDProp() As String
        Get
            Return UID
        End Get
        Set(ByVal value As String)
            UID = setUID(value)
        End Set
    End Property

    Public Function setUID(ByVal user As String) As Integer
        Dim sqlstring As String = ("SELECT idLoggin from Loggin where Brukernavn = '" & crntUsr & "'")
        Dim sql As New SQL

        Dim dt As New DataTable

        Dim i As Integer

        Try

            dt = sql.sporring(sqlstring)

            i = CInt(dt.Rows(0).Item(0).ToString)

            UID = i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return UID
    End Function

    Public Sub FetchUID()
        Dim sqlstring As String = ("SELECT idLoggin from Loggin where Brukernavn = '" & crntUsr & "'")
        Dim sql As New SQL

        Dim dt As New DataTable

        Dim i As Integer

        Try

            dt = sql.sporring(sqlstring)

            i = CInt(dt.Rows(0).Item(0).ToString)

            UID = i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function Getuserid()

        Dim Brukerid As Integer
        'Dim sqlstring As String = ("SELECT idLoggin from Loggin where Brukernavn = " & currentUsr & "")
        Dim sqlstring As String = ("SELECT idLoggin from Loggin where Brukernavn = '" & crntUsr & "'")
        Dim sql As New SQL

        Try
            Brukerid = sql.Return1Row(sqlstring, "idLoggin")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        Return Brukerid

    End Function



End Class
