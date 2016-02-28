Imports System.Console
Imports MySql
Imports System.Diagnostics.Process
Imports System.IO

Public Class frmConsole

    Dim Console As New Console

    Dim c As Process = Process.GetCurrentProcess()

    Dim prev As String

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        tmConsole.Start()

        Console.GetDir()


    End Sub

    Private Sub frmConsole_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        con.Close()
    End Sub

    Private Sub frmConsole_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.Pause

                TimerSet()

            Case Keys.Up

                TextBox1.Text = prev

        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter

                TextBox1.Text.ToLower()

                lstRecent.Items.Add(TextBox1.Text)

                Select Case TextBox1.Text

                    Case "exit"

                        Console.Quit()

                    Case "reset"
                        tmConsole.Enabled = 0
                        ToolStripLabel1.Text = "Console Tick : DISABLED"
                        With lstConsole.Items
                            .Add("Timer enabled : " & tmConsole.Enabled)
                        End With

                        TextBox1.Clear()

                End Select

                prev = TextBox1.Text

        End Select
    End Sub

    Private Sub Console_Tick(sender As Object, e As EventArgs) Handles tmConsole.Tick

        Debug()

        ToolStripLabel2.Text = "Application Uptime: " & getUpTime

        ToolStripProgressBar1.Value = Console.CPU()
        ToolStripProgressBar2.Value = Console.RAM()

        ToolStripStatusLabel1.Text = Console.CPU
        ToolStripStatusLabel2.Text = Console.RAM


    End Sub

    Public Sub Debug()

        With lstConsole.Items
            .Clear()
            .Add(Application.ProductName & " - " & Application.ProductVersion)
            .Add(Me.ProductName & " Console " & Me.ProductVersion)
            .Add("Server is ONLINE: " & online & " - Server: " & server)
            .Add("Server Ping: " & Console.PingSvr(server))
            .Add("")
            .Add("Database information:")
            DBNNFO()
            .Add("")
            .Add("Computer & System Spesifications")
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

                    With lstConsole.Items
                        .Add("Database connection could not be established")
                    End With

                Case 1

                    With lstConsole.Items
                        .Add("Server version: " & con.ServerVersion)
                        .Add("Connection State: " & con.State & " " & con.Ping)
                        .Add("Open port: " & port)
                    End With
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub TimerSet()

        Select Case tmConsole.Enabled
            Case 1
                tmConsole.Enabled = 0
                ToolStripLabel1.Text = "Console Tick : DISABLED"
            Case 0
                tmConsole.Enabled = 1
                ToolStripLabel1.Text = "Console Tick : ENABLED"
        End Select

    End Sub

End Class