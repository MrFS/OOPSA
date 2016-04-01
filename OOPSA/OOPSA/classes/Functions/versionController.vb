Imports OOPSA

''' <summary>
''' Kontroller programversjonen
''' 
''' Brukes for å finne ut om en oppdatering trengs gjennom class Update(Classes/Functions/frmLogin)
''' </summary>
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

    ''' <summary>
    ''' Property for version, readonly, getonly
    ''' </summary>
    ''' <returns>version, som deklarert i versionControler</returns>
    Public ReadOnly Property getVersion() As String
        Get
            Return version
        End Get
    End Property
End Class
