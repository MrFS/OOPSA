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

    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click

        dt2 = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & LagerLeggTil.Text & "'")
        dr2 = dt2.Rows(0)

        sql.sporring("INSERT INTO Produkt(Produkt_navn, Pris, p_antall, Lager_id) VALUES('" & NavnLeggTil.Text & "', '" & PrisLeggTil.Text & "', '" & AntLeggTil.Text & "', '" & dr2("Lager_id") & "')")

    End Sub

    Private Sub EndreKnapp_Click(sender As Object, e As EventArgs) Handles EndreKnapp.Click

        dt = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & lagerEndre.Text & "'")
        dr = dt.Rows(0)

        sql.sporring("UPDATE Produkt SET Produkt_navn = '" & navnEndreText.Text & "', Pris = '" & prisEndreText.Text & "', p_antall = '" & antEndreText.Text & "', Lager_id = '" & dr("Lager_id") & "' WHERE Produkt_navn='" & VareEndre.Text & "'")

    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        sql.sporring("DELETE FROM Produkt WHERE Produkt_navn ='" & vareSlett.SelectedItem & "'")

        GridDataBoundGrid1.Refresh()

    End Sub
End Class