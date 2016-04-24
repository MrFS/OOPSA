Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLagerMetro
    Inherits MetroForm
    Private sql As New SQL

    Dim Core As New frmAnsattCore

    Dim dt As DataTable 'For å sende inn lager_id utifra navn
    Dim dr As DataRow 'For å sende inn lager_id utifra navn

    Dim dt3 As DataTable
    Dim dr3 As DataRow

    Dim dt4 As DataTable ' For å hente inn by navn utifra Lager_id
    Dim dr4 As DataRow ' For å hente inn by navn utifra Lager_id

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

        Core.oppdater() ' Initially fills comboboxes

    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click

        dt = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & LagerLeggTil.Text & "'") ' Selects ID of the storage city
        dr = dt.Rows(0)

        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & NavnLeggTil.Text & "', '" & PrisLeggTil.Text & "', '" & AntLeggTil.Text & "', '" & dr("Lager_id") & "')") ' Sql query for adding new product uses city instead of id with the query above

        Core.oppdater()

    End Sub

    Private Sub EndreKnapp_Click(sender As Object, e As EventArgs) Handles EndreKnapp.Click

        dt = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & lagerEndre.Text & "'") ' Selects the ID of the storage city
        dr = dt.Rows(0)

        sql.sporring("UPDATE Produkt SET Produkt_navn = '" & navnEndreText.Text & "', Pris = '" & prisEndreText.Text & "', p_antall = '" & antEndreText.Text & "', Lager_id = '" & dr("Lager_id") & "' WHERE Produkt_navn='" & VareEndre.Text & "'") 'Changes product and uses the name with the previous query so user does not have to use numbers

        Core.oppdater()

    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        sql.sporring("DELETE FROM Produkt WHERE Produkt_navn ='" & vareSlett.SelectedItem & "'") ' Sql query for deleting chosen product

        Core.oppdater()

    End Sub

    Private Sub VareEndre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VareEndre.SelectedIndexChanged

        Dim dt3 = sql.sporring("SELECT * From Produkt WHERE Produkt_navn = '" & VareEndre.Text & "' ")
        Dim dr3 = dt3.Rows(0)

        For Each dr3 In dt3.Rows
            navnEndreText.Text = (dr3("Produkt_navn"))
            antEndreText.Text = (dr3("p_antall"))
            prisEndreText.Text = (dr3("Pris"))
        Next

        dt4 = sql.sporring("SELECT `by` FROM Lager WHERE Lager_id = '" & dr3("Lager_id") & "' ") ' Used to enter City name instead of a integer into the combobox for changing storage location
        dr4 = dt4.Rows(0)
        lagerEndre.Text = (dr4("by"))

    End Sub
End Class