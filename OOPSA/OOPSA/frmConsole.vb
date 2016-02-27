Imports System.Console
Imports MySql

Public Class frmConsole

    Dim prev As String

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Initialize()
    End Sub

    Private Sub frmConsole_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        con.Close()
    End Sub

    Private Sub frmConsole_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.Pause

                TimerSet()

            Case Keys.Enter

                TextBox1.Text.ToLower()

                TextBox1.Clear()

                prev = TextBox1.Text

                Console.Commands()

            Case Keys.Up

                TextBox1.Text = prev

        End Select
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Debug()

    End Sub

    Public Sub Debug()

        With lstConsole.Items
            .Clear()
            .Add(Me.ProductName & " Console " & Me.ProductVersion)
            .Add("Server is ONLINE: " & online & " - Server: " & server)
            .Add("Server Ping: " & Console.PingSvr(server))
            .Add("")
            .Add("Database information:")
            DBNNFO()

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

        Select Case Timer1.Enabled
            Case 1
                Timer1.Enabled = 0
                ToolStripLabel1.Text = "Console Tick : DISABLED"
            Case 0
                Timer1.Enabled = 1
                ToolStripLabel1.Text = "Console Tick : ENABLED"
        End Select

    End Sub

End Class