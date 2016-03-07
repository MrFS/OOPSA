Public Class UserCore
    Public currentUsr As String

    Public Property crntUsr As String
        Get
            Return currentUsr
        End Get
        Set(ByVal value As String)
            currentUsr = value
        End Set
    End Property

End Class
