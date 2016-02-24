Imports MySql.Data.MySqlClient

Public Class SQL
    Private Function sporring(ByVal sql As String) As DataTable
        Dim mydata As New DataTable
        Try
            con.Open()
            Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(mydata)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Spørring feilet")
            con.Close()
            End
        Finally
            con.Dispose()
        End Try
        Return mydata

    End Function
End Class
