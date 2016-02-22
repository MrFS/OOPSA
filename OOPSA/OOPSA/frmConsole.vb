
Public Class frmConsole
    Dim prev As String
    Private Sub frmConsole_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

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
End Class