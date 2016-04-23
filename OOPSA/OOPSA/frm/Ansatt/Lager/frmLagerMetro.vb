Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLagerMetro
    Inherits MetroForm
    Private sql As New SQL

    Dim dt2 As DataTable
    Dim dr2 As DataRow

    Dim dt As DataTable
    Dim dr As DataRow



    Public Sub New()
        Initialize()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmLagerMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger' table. You can move, or remove it, as needed.
        Me.LagerRapportStavangerTableAdapter.Fill(Me.Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger)
        'TODO: This line of code loads data into the 'Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim' table. You can move, or remove it, as needed.
        Me.LagerRapportTrondheimTableAdapter.Fill(Me.Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim)
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE' table. You can move, or remove it, as needed.
        Me.LagerRapportALLETableAdapter.Fill(Me.Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE)

        oppdater() ' Fyller comboboxene

    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click

        dt2 = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & LagerLeggTil.Text & "'")
        dr2 = dt2.Rows(0)

        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & NavnLeggTil.Text & "', '" & PrisLeggTil.Text & "', '" & AntLeggTil.Text & "', '" & dr2("Lager_id") & "')")

        oppdater()

    End Sub

    Private Sub EndreKnapp_Click(sender As Object, e As EventArgs) Handles EndreKnapp.Click

        dt = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & lagerEndre.Text & "'")
        dr = dt.Rows(0)

        sql.sporring("UPDATE Produkt SET Produkt_navn = '" & navnEndreText.Text & "', Pris = '" & prisEndreText.Text & "', p_antall = '" & antEndreText.Text & "', Lager_id = '" & dr("Lager_id") & "' WHERE Produkt_navn='" & VareEndre.Text & "'")

        antEndreText.Clear()
        navnEndreText.Clear()
        prisEndreText.Clear()

        oppdater()

    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        sql.sporring("DELETE FROM Produkt WHERE Produkt_navn ='" & vareSlett.SelectedItem & "'")

        GridDataBoundGrid1.Refresh()

        oppdater()

    End Sub

    Private Sub VareEndre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VareEndre.SelectedIndexChanged

        Dim adapter3 As New MySqlDataAdapter("SELECT * From Produkt WHERE Produkt_navn = '" & VareEndre.Text & "' ", con)
        Dim ds3 = New DataSet
        Dim dr3 As DataRow
        Dim dt3 As DataTable
        adapter3.Fill(ds3, "Produkt")
        dt3 = ds3.Tables(0)
        For Each dr3 In dt3.Rows
            navnEndreText.Text = (dr3("Produkt_navn"))
            antEndreText.Text = (dr3("p_antall"))
            prisEndreText.Text = (dr3("Pris"))
            lagerEndre.Text = (dr3("Lager_id"))
        Next

    End Sub

    Private Sub oppdater()

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

    Private Sub SplitContainer4_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer4.Panel1.Paint

    End Sub
End Class