''' <summary>
''' Enkel class for å enkode og dekode til fra Base64
''' </summary>
Public Class Base64Enc

    Private txt As String
    ''' <summary>
    ''' Parser en stringverdi til Base64Enc
    ''' </summary>
    ''' <returns>Base64 enkode string</returns>
    Public Property ToBase64 As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = Base64Encode(value)
        End Set
    End Property
    ''' <summary>
    ''' Parser en Base64 verdi over til en lesbar verdi
    ''' </summary>
    ''' <returns>String verdi i UTF8</returns>
    Public Property FrmBase64 As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = Base64Decode(value)
        End Set
    End Property
    ''' <summary>
    ''' Gjør om en tekstreng over til Base64
    ''' </summary>
    ''' <param name="enc">Tekststreng å konvertere</param>
    ''' <returns>Base64Konvertert streng</returns>
    Private Function Base64Encode(enc As String)

        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes(enc)

        Return Convert.ToBase64String(b)

    End Function
    ''' <summary>
    ''' Gjør om en Base64String over til lesbar tekst
    ''' </summary>
    ''' <param name="dec">Base64String å konvertere</param>
    ''' <returns>Lesbar tekst i UTF8</returns>
    Private Function Base64Decode(dec As String)

        Dim b As Byte() = Convert.FromBase64String(dec)

        Return System.Text.Encoding.UTF8.GetString(b)

    End Function
End Class
