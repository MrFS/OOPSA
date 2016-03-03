Imports System.Windows.Forms




Public Class Console

    Dim c As Process = Process.GetCurrentProcess



    Private WithEvents pc_CPU As New PerformanceCounter
    Private WithEvents pc_RAM As New PerformanceCounter

    Public Function PingSvr(server As String)

        Return ping.Send(server).RoundtripTime()

    End Function

    Public Sub Commands(txt As String)

    End Sub

    Public Sub Quit(txt As String)

        Select Case txt
            Case "ENV"
                Application.Exit()
            Case "WINDOW"
                My.Forms.frmConsole.Close()
        End Select



    End Sub

    Public Sub Admin()
        My.Forms.frmAdmin.Show()
    End Sub

    Public Sub Clear()

        With My.Forms.frmConsole.lstConsoleOverview.Items
            .Clear()
        End With
    End Sub

    Public Sub Debug()

        Select Case con.State
            Case ConnectionState.Connecting
                My.Forms.frmConsole.ToolStripConnected.BackColor = Color.Orange
            Case ConnectionState.Open
                My.Forms.frmConsole.ToolStripConnected.BackColor = Color.Green
            Case ConnectionState.Closed
                My.Forms.frmConsole.ToolStripConnected.BackColor = Color.Black
            Case ConnectionState.Broken
                My.Forms.frmConsole.ToolStripConnected.BackColor = Color.Red
            Case ConnectionState.Executing
                My.Forms.frmConsole.ToolStripConnected.BackColor = Color.OrangeRed
            Case ConnectionState.Fetching
                My.Forms.frmConsole.ToolStripConnected.BackColor = Color.GreenYellow
            Case Else

        End Select

        If online = True Then
            My.Forms.frmConsole.ToolStripOnline.BackColor = Color.Green
        Else
            My.Forms.frmConsole.ToolStripOnline.BackColor = Color.Red
        End If

        Select Case PingSvr(server)
            Case < 5
                My.Forms.frmConsole.ToolStripServerLoad.BackColor = Color.Green
            Case >= 5
                My.Forms.frmConsole.ToolStripServerLoad.BackColor = Color.Orange
            Case > 15
                My.Forms.frmConsole.ToolStripServerLoad.BackColor = Color.DarkOrange
            Case > 25
                My.Forms.frmConsole.ToolStripServerLoad.BackColor = Color.Red
        End Select

        With My.Forms.frmConsole.lstConsoleOverview.Items
            .Clear()

            .Add(Application.ProductName & " Console " & Application.ProductVersion)
            .Add("Server is ONLINE: " & online & " - Server: " & server)
            .Add("Server Ping: " & PingSvr(server) & "ms")
            .Add("")
            .Add("Database information:")
            DBNNFO()
            .Add("")
            .Add("Computer & System Specifications")
            .Add("Directory: " & Application.ProductVersion & Application.StartupPath)
            .Add(My.Computer.Info.OSFullName & (" ") & My.Computer.Info.OSPlatform & (" ") & My.Computer.Info.OSVersion)
            .Add(My.Computer.Info.TotalPhysicalMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
            .Add(My.Computer.Info.TotalVirtualMemory & (" ") & My.Computer.Info.AvailableVirtualMemory)
            .Add(vbNewLine)
            .Add(My.Application.Info.AssemblyName & My.Application.Info.CompanyName)
            .Add(My.Application.Info.Copyright & My.Application.Info.Description)
            .Add("Mem Usage (Working Set) :   " & c.WorkingSet64 / 1024 & " K")
            .Add("VM Size (Private Bytes) " & c.PagedMemorySize64 / 1024 & " K")
            .Add("GC TotalMemory " & GC.GetTotalMemory(True) & " bytes" & "Current Memory Usage")
            .Add(vbNewLine)

        End With
    End Sub

    Private Sub DBNNFO()

        Try
            Select Case con.State

                Case 0

                    With My.Forms.frmConsole.lstConsoleOverview.Items
                        .Add("Database connection could not be established")
                    End With

                Case 1

                    With My.Forms.frmConsole.lstConsoleOverview.Items
                        .Add("Server version: " & con.ServerVersion)
                        .Add("Connection State: " & con.State & " " & con.Ping)
                        .Add("Open port: " & port)
                    End With
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub Reset()

    End Sub

    Public Sub SaveDebug()

    End Sub

    Public Sub GetDir(dir As String)

        Dim di As New IO.DirectoryInfo(dir)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo


        'list the names of all files in the specified directory
        My.Forms.frmConsole.lstDir.Items.Add("Parent Directory : " & di.Name)
        For Each dra In diar1
            My.Forms.frmConsole.lstDir.Items.Add(vbTab & dra.Name & dra.Extension)
        Next
    End Sub

    Public Function CPU()

        pc_CPU.CategoryName = "Processor"
        pc_CPU.CounterName = "% Processor Time"
        pc_CPU.InstanceName = "_Total"

        Return pc_CPU.NextValue

    End Function

    Public Function RAM()

        pc_RAM.CategoryName = "Memory"
        pc_RAM.CounterName = "% Committed Bytes In Use"

        Return pc_RAM.NextValue

    End Function
End Class
