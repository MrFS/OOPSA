Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLager
    Inherits MetroForm

    Dim lager As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        ' Dim da = New MySqlCommand()
        Dim sql As New SQL




        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & NavnLeggTil.Text & "', '" & PrisLeggTil.Text & "', '" & AntLeggTil.Text & "', '" & lager & "')")



    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click
        Dim sql As New MySqlCommand("DELETE FROM Produkt WHERE Produkt_navn ='" & ComboBox2.SelectedItem & "'", con)
        sql.ExecuteNonQuery()
    End Sub

    Private Sub frmLager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Produkt' table. You can move, or remove it, as needed.
        Me.ProduktTableAdapter.Fill(Me.Drift8_2016DataSet.Produkt)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Produkt' table. You can move, or remove it, as needed.
        Me.ProduktTableAdapter.Fill(Me.Drift8_2016DataSet.Produkt)

        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM Lager", con)
        Dim ds2 = New DataSet
        Dim dr2 As DataRow
        Dim dt2 As DataTable
        adapter2.Fill(ds2, "Lager")
        dt2 = ds2.Tables(0)
        For Each dr2 In dt2.Rows
            LagerLeggTil.Items.Add(dr2("by"))
            lagerEndre.Items.Add(dr2("by"))
        Next

        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con)
        Dim ds = New DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        adapter.Fill(ds, "Produkt")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            VareEndre.Items.Add(dr("Produkt_navn"))
            ComboBox2.Items.Add(dr("Produkt_navn"))
        Next

        Try

            Initialize()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles EndreKnapp.Click
        Dim sql As New SQL

        sql.sporring("SELECT Lager_id FROM Lager WHERE by = '" & lagerEndre.Text & "'")


        '  sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & BtnNavnEndre.Text & "', '" & BtnPrisEndre.Text & "', '" & btnAntEndre.Text & "', '" & NEIN FIX THIS & "')")
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VareEndre.SelectedIndexChanged



        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con)
        Dim ds = New DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        adapter.Fill(ds, "Produkt")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            BtnNavnEndre.Text = (dr("Produkt_navn"))
            btnAntEndre.Text = (dr("p_antall"))
            BtnPrisEndre.Text = (dr("Pris"))
            lagerEndre.Text = (dr("Lager_id"))
        Next



    End Sub

    Private Sub LagerLeggTil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LagerLeggTil.SelectedIndexChanged

    End Sub
End Class
