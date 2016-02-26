Imports System.Console
Imports MySql

Public Class frmConsole
    Dim prev As String
    Private Sub frmConsole_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.P

                Select Case Timer1.Enabled
                    Case 1
                        Timer1.Enabled = 0
                        ToolStripLabel1.Text = "Console Tick : DISABLED"
                    Case 0
                        Timer1.Enabled = 1
                        ToolStripLabel1.Text = "Console Tick : ENABLED"
                    Case Else
                        MsgBox("Unable to enable/disable tick")
                End Select

            Case Keys.Enter

                TextBox1.Text.ToLower()

                prev = TextBox1.Text

                Select Case TextBox1.Text

                    Case "exit"

                        Application.Exit()

                    Case "close"

                        Me.Close()

                    Case ""

                    Case ""

                    Case ""

                    Case ""

                    Case Else

                        MsgBox("Enter approperiate value")

                End Select

                TextBox1.Clear()

            Case Keys.Up

                TextBox1.Text = prev

        End Select
    End Sub

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add(Application.OpenForms)
            .Add(Application.OpenForms.Count)
        End With
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ms = ping.Send(server).RoundtripTime()

        With ListBox1.Items
            .Clear()
            .Add(Me.ProductName & " Console " & Me.ProductVersion)
            .Add("Server is ONLINE: " & online & " - Server: " & server)
            .Add("Server Ping: " & ms & "ms")
            .Add("")
            .Add("Database information:")
            DBNNFO()
        End With
    End Sub

    Private Sub DBNNFO()
        Try
            Select Case con.State

                Case 0

                    With ListBox1.Items
                        .Add("Database connection could not be established")
                        .Add("Server version: &&")
                        .Add("Connection State: &&")
                        .Add("Open port: &&")
                    End With

                Case 1

                    With ListBox1.Items
                        .Add("Server version: " & con.ServerVersion)
                        .Add("Connection State: " & con.State & " " & con.Ping)
                        .Add("Open port: " & port)
                    End With

                Case Else
                    Throw New Exception("Unable to view DBNFO")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class