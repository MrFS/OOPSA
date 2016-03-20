Imports OOPSA.versionController
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection

Imports System.Net

Imports EnvDTE


Module updateModule


    ''' <summary>
    ''' 
    ''' </summary>
    Sub Main()


        Dim getCurrentV As String
        Dim getNewV As String

        getCurrentV = ""
        getNewV = ""

        Dim client As WebClient = New WebClient
        Dim readCurrentV As StreamReader = New StreamReader(client.OpenRead(getCurrentV))



        Console.Title = "OOPSA Updater v" & Environment.Version.ToString

        Console.WriteLine("OOPSA Updater")

        Console.WriteLine("Current version: " & major & "." & minor & "." & build & "." & revision)

        ' Get the file version for the notepad.
        ' Use either of the following two commands.
        FileVersionInfo.GetVersionInfo(Path.Combine(Environment.CurrentDirectory, "OOPSA.exe"))
        Dim OOPSAversion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\OOPSA.exe")

        ' Print the file name and version number.
        Console.WriteLine("File: " + OOPSAversion.FileDescription + vbLf + "Version number: " + OOPSAversion.FileVersion)



        Console.WriteLine("Version: {0}", version)
        Console.WriteLine("Major: {0}", major)
        Console.WriteLine("Minor: {0}", minor)
        Console.WriteLine("Build: {0}", build)
        Console.WriteLine("Revision: {0}", revision)

        Console.In.ReadLine()

    End Sub

End Module
