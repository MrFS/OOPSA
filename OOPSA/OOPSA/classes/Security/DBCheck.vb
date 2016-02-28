Imports System.IO

Public Class DBCheck

    Public Sub DBCheck()


        If File.Exists(Application.StartupPath & "\db.idc") Then

            MsgBox("Only one Instance of the application is allowed!!!")

            Environment.Exit(0)

        Else
            File.Create(Application.StartupPath & "\db.idc", 10, FileOptions.DeleteOnClose)
        End If

    End Sub
End Class
