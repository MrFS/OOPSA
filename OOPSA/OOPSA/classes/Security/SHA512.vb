Imports System.Security.Cryptography

''' <summary>
''' Brukes under innlogging, registrering av nye ansatte og endring av passord til alleredeeksisterende ansatte.
''' 
''' Parser en tekststring, f.eks. ett passord over til SHA512-Hash, 
''' konverterer den hashen så over til Base64 som fungerer som en "salt".
''' 
''' Her finnes det ikke noen form for dekryptering! 
''' Da dette vil utgjøre en sikkerhetsrisiko 
''' ovenfor de ansatte som ligger registrert
''' i databasen til firmaet som blir å 
''' bruke dette programmet
''' </summary>
Public Class SHA512

    Public txt As String

    ''' <summary>
    ''' Mottar en tekststring i plaintekst
    ''' Parser den over til SHA512Encrypt
    ''' Returnerer en Base64 Enkodet SHA512 hash
    ''' </summary>
    ''' <returns>Base64 enkodet SHA512 hash</returns>
    Public Property ToHashSHA512() As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = SHA512Encrypt(value)
        End Set
    End Property

    ''' <summary>
    ''' Kjernefunksjonaliteten til SHA512 krypteringen
    ''' </summary>
    ''' <param name="txt">plaintekst</param>
    ''' <returns>Base64 enkodet SHA512 hash</returns>
    Private Function SHA512Encrypt(txt As String)

        'Dim pwsalt As String = txt

        Dim SHA512 = New SHA512Managed

        Dim SHA512BSalt() As Byte = Text.Encoding.UTF8.GetBytes(txt)

        Dim SaltString As Byte() = SHA512.ComputeHash(SHA512BSalt)

        Convert.ToBase64String(SaltString)

        'Dim saltetPW As String = SaltString.ToString

        Dim SHA512B() As Byte = Text.Encoding.UTF8.GetBytes(SaltString.ToString)

        Dim cryString As Byte() = SHA512.ComputeHash(SHA512B)

        SHA512.Clear()

        Return Convert.ToBase64String(cryString)

    End Function
End Class