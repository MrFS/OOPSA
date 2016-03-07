Public Class ServerCore
    Public Property ServerString As String
        Get
            Return server
        End Get
        Set(ByVal value As String)
            server = value
        End Set
    End Property

    Public Property ServerPW As String
        Get
            Return pass
        End Get
        Set(ByVal value As String)
            pass = value
        End Set
    End Property

    Public Property ServerDB As String
        Get
            Return database
        End Get
        Set(ByVal value As String)
            database = value
        End Set
    End Property

    Public Property ServerUsr As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property

    Public Property ServerPort As Integer
        Get
            Return port
        End Get
        Set(ByVal value As Integer)
            port = value
        End Set
    End Property
End Class
