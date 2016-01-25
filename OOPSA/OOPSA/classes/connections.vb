Imports System.Data.OleDb
Imports System.Data.SqlClient

Public MustInherit Class connections

    Public cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim cnnString As String

    Public Sub New()
        cnnString = "Data Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd
        cnn = New SqlConnection(cnnString)
    End Sub
    Public Function sqlTransaction(ByVal sql) As Boolean
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            cnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
