Imports System.IO

''' <summary>
''' Referert i frmMetroLogin
''' 
''' Lager en fil i Environment.CurrentDirectory
''' Hvis denne filen eksisterer så kjører programmet fra før av.
''' Avslutt den nyoppstartede prosessen da vi ikke vil ha noen komplikasjoner med databaseoppkobling o.l.
''' </summary>

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
