Imports MySql
Imports System.Diagnostics
Imports System.IO

Public Class frmConsole

    Dim Console As New Console

    Dim DebugTick As Integer

    Dim w As IO.StreamWriter

    Dim prev As String

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()

        tmConsole.Start()

        Console.GetDir(My.Application.Info.DirectoryPath)

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

                Console.Commands(TextBox1.Text)

                TextBox1.Clear()

                prev = TextBox1.Text

        End Select
    End Sub

    Private Sub Console_Tick(sender As Object, Now As EventArgs) Handles tmConsole.Tick

        Console.Debug()

        lstConsole.Items.Clear()

        Dim ctrl As Control = CType(sender, Control)

        lstConsole.Items.Add(New Object() {ctrl.Parent.Name & ctrl.Name, ctrl.GetType})




        If DebugTick < 25 Then
            DebugTick += 1
        Else

            Dim i As Integer
            w = New IO.StreamWriter("test.txt")
            w.WriteLine("")
            w.WriteLine(My.Computer.Clock.GmtTime)
            For i = 0 To lstConsoleOverview.Items.Count - 1
                w.WriteLine(lstConsoleOverview.Items.Item(i))
            Next
            w.Close()


            DebugTick = 0
        End If

        ToolStripLabel2.Text = "Application Uptime: " & getUpTime

        ToolStripProgressBar1.Value = Console.CPU()
        ToolStripProgressBar2.Value = Console.RAM()

        ToolStripStatusLabel1.Text = Console.CPU()
        ToolStripStatusLabel2.Text = Console.RAM()


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

    'Legg inn EVENTLOG Listener






End Class