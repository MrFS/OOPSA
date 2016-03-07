Imports System.Security.Cryptography

Public Class SHA512

    Public txt As String
    Public Property ToHashSHA512() As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = SHA512Encrypt(value)
        End Set
    End Property


    Private Function SHA512Encrypt(txt As String)

        Dim SHA512 = New SHA512Managed

        Dim SHA512B() As Byte = Text.Encoding.UTF8.GetBytes(txt)

        Dim cryString As Byte() = SHA512.ComputeHash(SHA512B)

        SHA512.Clear()

        Return Convert.ToBase64String(cryString)

    End Function
End Class