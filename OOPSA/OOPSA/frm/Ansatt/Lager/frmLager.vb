Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLager
    Inherits MetroForm
    'Public lager As Integer = 0


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

        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & TextBoxExt7.Text & "', '" & TextBoxExt6.Text & "', '" & TextBoxExt9.Text & "', '" & lager & "')")



    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        Dim sql As New MySqlCommand("DELETE FROM Produkt WHERE Produkt_navn ='" & ComboBox2.SelectedItem & "'", con)
        sql.ExecuteNonQuery()
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
        Try

            Initialize()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click

    End Sub
End Class
