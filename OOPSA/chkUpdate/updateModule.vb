
Imports System.Diagnostics
Imports System.IO
Imports System.IO.Compression
Imports System.Reflection

Imports System.Net


Module updateModule


    ''' <summary>
    ''' 
    ''' </summary>
    Sub Main()


        'Dim OOPSA As Process = Process.GetProcessesByName("OOPSA").

        Dim dlVersion As String = "https://mrfs.me/school/oopsa/version.txt"
        Dim client As WebClient = New WebClient()

        Dim vReader As StreamReader = New StreamReader(client.OpenRead(dlVersion))

        Dim ans As Char

        Dim chkProcess As Integer = 0

        Console.WriteLine("OOPSA Update")

        FileVersionInfo.GetVersionInfo(Path.Combine(Environment.CurrentDirectory, "OOPSA.exe"))
        Dim vOOPSA As FileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\OOPSA.exe")


        ' Print the file name and version number.

        Console.WriteLine("Current version " & vOOPSA.FileVersion)
        Console.WriteLine("New version " & vReader.ReadToEnd)

        Console.WriteLine("This is new in version " & vReader.ReadToEnd)

        Dim vString As String = vReader.ReadToEnd

        Console.WriteLine("https://mrfs.me/school/oopsa/" + vString + ".txt")

        'Using sr As New StreamReader("https://mrfs.me/school/oopsa/" + vReader.ReadToEnd + ".txt")
        '    Dim news As String

        '    news = sr.ReadToEnd

        '    Console.WriteLine(news)

        'End Using

        Console.WriteLine("Would you like to update? Y/N")

        ans = Console.ReadLine()

        Char.ToUpper(ans)

        Select Case ans
            Case "Y"
                Console.WriteLine("Preparing Update")
                For Each OOPSA As Process In Process.GetProcesses
                    chkProcess += 1
                    Console.WriteLine(vbTab & "Checking Processes..." & vbTab & " {" & chkProcess & "}")
                    Threading.Thread.Sleep(100)
                    If OOPSA.ProcessName = "OOPSA" Then
                        Console.WriteLine(vbTab & "Found Process")
                        If OOPSA.HasExited = False Then
                            Console.WriteLine(vbTab & vbTab & "Killing Process: OOPSA.exe")
                            OOPSA.Kill()
                            Threading.Thread.Sleep(500)

                            Exit For

                        End If
                    End If
                Next

                Console.WriteLine("Preparing Complete")
                Console.WriteLine(vbTab & "Proceeding with file movement")
                Console.WriteLine(vbTab & vbTab & "Preparing file compression")

                For int As Integer = 0 To 10
                    Select Case int
                        Case = 2
                            Console.WriteLine("BREAKING")
                        Case = 5
                            Console.WriteLine("CLEARING CONSOLE - WAIT")
                            Threading.Thread.Sleep(4000)
                        Case = 7
                            Console.Clear()
                        Case 10
                            Exit For
                    End Select
                Next

                Dim zipArchive As New Syncfusion.Compression.Zip.ZipArchive()
                zipArchive.DefaultCompressionLevel = Syncfusion.Compression.CompressionLevel.BestSpeed

                Console.WriteLine("Adding files")

                If Not Directory.Exists("old") Then
                    Directory.CreateDirectory("old")
                End If

                Try
                    Dim di As New IO.DirectoryInfo(Environment.CurrentDirectory)
                    Dim diar1 As IO.FileInfo() = di.GetFiles()
                    Dim dra As IO.FileInfo

                    For Each dra In diar1
                        Try
                            If dra.Name <> "chkUpdate.exe" AndAlso
                               dra.Name <> "chkUpdate.pdb" AndAlso
                               dra.Name <> "chkUpdate.vshost.exe" AndAlso
                               dra.Name <> "OOPSA.vshost.exe" Then

                                Console.WriteLine("Adding file to archive: " & dra.Name)
                                zipArchive.AddFile(dra.Name)
                                Threading.Thread.Sleep(500)

                            End If
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try
                    Next
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try


                'Zip file name and location
                zipArchive.Save("old\" & Now.ToShortDateString & ".zip")
                zipArchive.Close()

                Console.WriteLine("Finished archiving files")
                Console.WriteLine("BREAKING")
                Threading.Thread.Sleep(1000)
                Console.WriteLine("Preparing to delete old files")
                Threading.Thread.Sleep(1000)

                Console.Clear()

                Dim diDel As New IO.DirectoryInfo(Environment.CurrentDirectory)
                Dim fileDel As IO.FileInfo() = diDel.GetFiles()
                Console.WriteLine("Deleting files")
                For Each dra In fileDel

                    Try

                        If dra.Name <> "chkUpdate.exe" Then
                            Console.WriteLine("Deleting file: " & dra.Name)
                            IO.File.Delete(dra.Name)
                            Threading.Thread.Sleep(250)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Next

                Console.WriteLine("Finished deleting files")
                Console.WriteLine("BREAKING")
                Threading.Thread.Sleep(1000)
                Console.WriteLine("Preparing to download new files")
                Threading.Thread.Sleep(1000)

                Console.Clear()

                Dim dlAdress As String = "https://mrfs.me/school/oopsa/"

                dlAdress += vReader.ReadToEnd.ToString & ".zip"

                Console.WriteLine(dlAdress)

                Console.WriteLine("Downloading File ""{0}"" from ""{1}"" ......." + ControlChars.Cr + ControlChars.Cr, vReader.ReadToEnd & ".zip", dlAdress)
                Console.WriteLine("Please Wait!")

                Try
                    client.DownloadFile(dlAdress, vReader.ReadToEnd & "update.zip")
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

                Console.WriteLine("Finished downloading archive")
                Console.WriteLine("BREAKING")
                Threading.Thread.Sleep(1000)
                Console.WriteLine("Preparing to extract archive")
                Threading.Thread.Sleep(1000)

                Console.Clear()

                Console.WriteLine("Extracting downloaded archive")
                Console.WriteLine(vbTab & "Please Wait!")


                Try
                    ZipFile.ExtractToDirectory("update.zip", Environment.CurrentDirectory)
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

                Console.WriteLine("Finished extracting archive")

                Console.WriteLine("BREAKING")
                Threading.Thread.Sleep(1000)
                Console.WriteLine("Preparing final steps")
                Threading.Thread.Sleep(1000)

                Console.Clear()

                Dim final As Char

                Console.WriteLine("Do you wish to delete old files? Y/N")

                final = Console.ReadLine()

                Select Case final
                    Case "Y"
                        Console.WriteLine("Deleting files")

                        Try
                            IO.Directory.Delete(Environment.CurrentDirectory & "\old", True)
                            IO.File.Delete(Environment.CurrentDirectory & "\update.zip")
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                            Threading.Thread.Sleep(2500)
                        End Try

                        Console.WriteLine("Directory deleted - '\old\'")

                        Console.WriteLine("OOPSA Updated to version " & vReader.ReadToEnd)

                        Console.WriteLine("EXITING Update - Starting OOPSA")

                        Process.Start("OOPSA.exe")

                        Threading.Thread.Sleep(3500)

                        Environment.Exit(0)

                    Case "N"

                        Console.WriteLine("OOPSA Updated to version " & vReader.ReadToEnd)

                        Console.WriteLine("EXITING Update - Starting OOPSA")

                        Process.Start("OOPSA.exe")

                        Threading.Thread.Sleep(3500)

                        Environment.Exit(0)

                End Select

                Console.ReadLine()

            Case "N"
                Environment.Exit(0)
        End Select

    End Sub

End Module
