Imports OOPSA
Public Class versionController
    'Public Shared major = 0
    'Public Shared minor = 1
    'Public Shared build = 8
    'Public Shared revision = 32

    Public Shared major = 1
    Public Shared minor = 1
    Public Shared build = 1
    Public Shared revision = 1

    Public Shared version = major & "." & minor & "." & build & "." & revision


    Public ReadOnly Property getVersion() As String
        Get
            Return version
        End Get
    End Property
End Class
