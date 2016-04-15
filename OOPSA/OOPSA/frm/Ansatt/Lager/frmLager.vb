Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLager
    Inherits MetroForm

    Dim lager As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        ' Dim da = New MySqlCommand()
        Dim sql As New SQL

        Dim dt2 As DataTable
        Dim dr2 As DataRow
        dt2 = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & LagerLeggTil.Text & "'")
        dr2 = dt2.Rows(0)


        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & NavnLeggTil.Text & "', '" & PrisLeggTil.Text & "', '" & AntLeggTil.Text & "', '" & dr2("Lager_id") & "')")



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

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles EndreKnapp.Click
        Dim sql As New SQL

        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & lagerEndre.Text & "'")
            dr = dt.Rows(0)


            sql.sporring("UPDATE Produkt SET Produkt_navn = '" & navnEndreText.Text & "', Pris = '" & prisEndreText.Text & "', p_antall = '" & antEndreText.Text & "', Lager_id = '" & dr("Lager_id") & "' WHERE Produkt_navn='" & VareEndre.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VareEndre.SelectedIndexChanged



        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con)
        Dim ds = New DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        adapter.Fill(ds, "Produkt")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            navnEndreText.Text = (dr("Produkt_navn"))
            antEndreText.Text = (dr("p_antall"))
            prisEndreText.Text = (dr("Pris"))
            lagerEndre.Text = (dr("Lager_id"))
        Next



    End Sub

    Private Sub LagerLeggTil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LagerLeggTil.SelectedIndexChanged

    End Sub

    Private Sub TabControlAdv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlAdv1.SelectedIndexChanged
        VareEndre.Items.Clear()
        vareSlett.Items.Clear()
        LagerLeggTil.Items.Clear()
        lagerEndre.Items.Clear()


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
            vareSlett.Items.Add(dr("Produkt_navn"))
        Next



    End Sub

    Private Sub ButtonAdv2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub vareSlett_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        Initialize()
        Dim sql As New MySqlCommand("DELETE FROM Produkt WHERE Produkt_navn ='" & vareSlett.SelectedItem & "'", con)
        sql.ExecuteNonQuery()
        GridDataBoundGrid1.Refresh()
    End Sub
End Class
