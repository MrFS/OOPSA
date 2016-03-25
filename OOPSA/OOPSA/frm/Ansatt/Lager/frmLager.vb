Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLager
    Inherits MetroForm
    Public lager As Integer = 0
    Private Sub TabPageAdv1_Click(sender As Object, e As EventArgs) Handles TabPageAdv1.Click
        ComboBox1.Items.Add("Trondheim")

        If ComboBox1.Text = "Trondheim" Then
            lager = 2
        ElseIf ComboBox1.Text = "Oslo" Then
            lager = 3
        End If
    End Sub

    Private Sub TabControlAdv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlAdv1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da = New MySqlCommand("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & TextBoxExt7.Text & "', '" & TextBoxExt6.Text & "', '" & TextBoxExt9.Text & "', '" & lager & "' )")

        Dim da As New DataTable


    End Sub
End Class
