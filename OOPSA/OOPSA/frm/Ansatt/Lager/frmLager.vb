Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLager
    Inherits MetroForm
    'Public lager As Integer = 0
    Private Sub TabPageAdv1_Click(sender As Object, e As EventArgs) Handles TabPageAdv1.Click

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
        Dim lager As Integer

        Select Case ComboBox3.Text
            Case "Trondheim"
                lager = 2
            Case "Bryne"
                lager = 1
        End Select

        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & TextBoxExt7.Text & "', '" & TextBoxExt6.Text & "', '" & TextBoxExt9.Text & "', '" & lager & "' )")


    End Sub

    Private Sub ComboDropDown1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPageAdv3_Click(sender As Object, e As EventArgs) Handles TabPageAdv3.Click
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        Dim adapter As New MySqlCommand("DELETE FROM Produkt WHERE Produkt_navn='" & ComboBox2.Text & "'", con)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
    End Sub

    Private Sub frmLager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Produkt' table. You can move, or remove it, as needed.
        Me.ProduktTableAdapter.Fill(Me.Drift8_2016DataSet.Produkt)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Produkt' table. You can move, or remove it, as needed.
        Me.ProduktTableAdapter.Fill(Me.Drift8_2016DataSet.Produkt)



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


        ComboBox1.Items.Add("Trondheim")
        ComboBox1.Items.Add("Bryne")

        'If ComboBox1.Text = "Bryne" Then
        '    lager = 1
        'ElseIf ComboBox1.Text = "Trondheim" Then
        '    lager = 2
        'End If
    End Sub

    Private Sub TextBoxExt9_TextChanged(sender As Object, e As EventArgs) Handles TextBoxExt9.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub GridDataBoundGrid1_CellClick(sender As Object, e As Grid.GridCellClickEventArgs) Handles GridDataBoundGrid1.CellClick

    End Sub

    Private Sub ComboDropDown3_Click(sender As Object, e As EventArgs) Handles ComboDropDown3.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBoxExt2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxExt2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
