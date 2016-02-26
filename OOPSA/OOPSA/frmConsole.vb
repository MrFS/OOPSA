Imports System.Console

Public Class frmConsole
    Dim prev As String
    Private Sub frmConsole_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.P

                If Timer1.Enabled = 0 Then
                    Timer1.Enabled = 1
                Else
                    Timer1.Enabled = 0
                End If

            Case Keys.Enter

                TextBox1.Text.ToLower()

                prev = TextBox1.Text

                Select Case TextBox1.Text

                    Case "exit"

                        Application.Exit()

                    Case "close"

                        Me.Close()

                    Case Else

                        MsgBox("Enter apporperiate value")

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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ms = ping.Send(server).RoundtripTime()

        With ListBox1.Items
            .Clear()
            .Add(Me.ProductName & " Console " & Me.ProductVersion)
            .Add("Opprettet kobling mot server: " & My.Computer.Network.Ping(server) & " - Server: " & server)
            .Add("Server Ping: " & ms & "ms")
        End With
    End Sub
End Class