
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

End Class
