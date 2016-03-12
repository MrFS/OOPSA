Imports OOPSA.versionController
Imports System.Diagnostics
Imports System.IO


Module updateModule



    Sub Main()



        Console.Title = "OOPSA Updater v" & Environment.Version.ToString

        Console.WriteLine("OOPSA Updater")

        Console.WriteLine("Current version: " & major & "." & minor & "." & build & "." & revision)

        ' Get the file version for the notepad.
        ' Use either of the following two commands.
        FileVersionInfo.GetVersionInfo(Path.Combine(Environment.CurrentDirectory, "OOPSA.exe"))
        Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\OOPSA.exe")

        ' Print the file name and version number.
        Console.WriteLine("File: " + myFileVersionInfo.FileDescription + vbLf + "Version number: " + myFileVersionInfo.FileVersion)


        Console.In.ReadLine()

    End Sub

End Module
