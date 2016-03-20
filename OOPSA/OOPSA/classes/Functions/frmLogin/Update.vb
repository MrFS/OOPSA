Imports System.Net
Imports System.IO

Imports OOPSA.versionController


Public Class Update

    Dim availableUpdate As Boolean
    Private doUpdate As Boolean

    Public Sub checkUpdate()
        Dim getCurrentV As String
        Dim getV As String = "https://mrfs.me/school/oopsa/version.txt"

        getCurrentV = version

        Dim applyWebV As String


        Dim client As WebClient = New WebClient
        Dim readNewV As StreamReader = New StreamReader(client.OpenRead(getV))

        applyWebV = readNewV.ReadToEnd()

        If applyWebV.Contains(version.ToString) Then
            isUpdate = False
        Else
            isUpdate = True
        End If
    End Sub

    Public Property isUpdate() As Boolean
        Get
            Return doUpdate
        End Get
        Set(ByVal value As Boolean)
            doUpdate = value
        End Set
    End Property

    Public Sub runUpdate()
        MsgBox(doUpdate.ToString)

        Process.Start("chkUpdate.exe")

    End Sub
End Class
