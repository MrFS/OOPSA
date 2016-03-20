Imports System.Net
Imports System.IO


Public Class Update

    Dim availableUpdate As Boolean
    Public doUpdate As Boolean

    Public Sub chkUpdate()
        Dim getCurrentV As String
        Dim getV As String = "https://mrfs.me/school/oopsa/version.txt"

        getCurrentV = Application.ProductVersion.ToString


        Dim client As WebClient = New WebClient
        Dim readCurrentV As StreamReader = New StreamReader(client.OpenRead(getV))

        If getV.Contains(getCurrentV.ToString) Then
            isUpdate(True)
        End If

    End Sub

    Public Function isUpdate(update As Boolean)

        update = doUpdate

        Return update

    End Function

End Class
