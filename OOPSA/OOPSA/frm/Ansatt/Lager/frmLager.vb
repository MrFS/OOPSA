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
        ' Dim da = New MySqlCommand()
        Dim sql As New SQL
        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & TextBoxExt7.Text & "', '" & TextBoxExt6.Text & "', '" & TextBoxExt9.Text & "', '" & lager & "' )")


    End Sub

    Private Sub ComboDropDown1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPageAdv3_Click(sender As Object, e As EventArgs) Handles TabPageAdv3.Click
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
    End Sub

    Private Sub frmLager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con)
        Dim ds = New DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        adapter.Fill(ds, "Produkt")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            ComboBox3.Items.Add(dr("Produkt_navn"))
            ComboBox2.Items.Add(dr("Produkt_navn"))
        Next
    End Sub
End Class
