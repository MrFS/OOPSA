Public Class Base64Enc

    Private txt As String

    Public Property ToBase64 As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = Base64Encode(value)
        End Set
    End Property

    Public Property FrmBase64 As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = Base64Decode(value)
        End Set
    End Property

    Private Function Base64Encode(enc As String)

        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes(enc)

        Return Convert.ToBase64String(b)

    End Function

    Private Function Base64Decode(dec As String)

        Dim b As Byte() = Convert.FromBase64String(dec)

        Return System.Text.Encoding.UTF8.GetString(b)

    End Function
End Class
