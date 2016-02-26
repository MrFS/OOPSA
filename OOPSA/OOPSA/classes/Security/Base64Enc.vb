Public Class Base64Enc

    Public Function Base64Encode(txt As String)

        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes(txt)

        Return Convert.ToBase64String(b)

    End Function

    Public Function Base64Decode(txt As String)

        Dim b As Byte() = Convert.FromBase64String(txt)

        Return System.Text.Encoding.UTF8.GetString(b)

    End Function
End Class
