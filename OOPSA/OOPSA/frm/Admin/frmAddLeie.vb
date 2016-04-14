Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddLeie
    Inherits MetroForm
    Dim Core As New frmAdminCore



    Private Sub frmAddLeie_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con)
        Dim ds_produkt = New DataSet
        Dim dr_produkt As DataRow
        Dim dt_produkt As DataTable
        adapter.Fill(ds_produkt, "Produkt")
        dt_produkt = ds_produkt.Tables(0)
        For Each dr_produkt In dt_produkt.Rows
            Dim produkt As String

            produkt = dr_produkt("Produkt_id")
            produkt += " " & dr_produkt("Produkt_navn")

            ComboProdukt.Items.Add(produkt)
        Next



        Dim adapter1 As New MySqlDataAdapter("SELECT * FROM Lager", con)

        Dim ds_lager = New DataSet
        Dim dr_lager As DataRow
        Dim dt_lager As DataTable

        adapter1.Fill(ds_lager, "Lager")
        dt_lager = ds_lager.Tables(0)
        For Each dr_lager In dt_lager.Rows
            Dim lager As String

            lager = dr_lager("Lager_id")
            lager += " " & dr_lager("Addresse")

            ComboLager.Items.Add(lager)
        Next

        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM Kunde", con)

        Dim ds_kunde = New DataSet
        Dim dr_kunde As DataRow
        Dim dt_kunde As DataTable

        adapter2.Fill(ds_kunde, "Kunde")
        dt_kunde = ds_kunde.Tables(0)
        For Each dr_kunde In dt_kunde.Rows
            Dim navn As String

            navn = dr_kunde("Kid").ToString
            navn += " " & dr_kunde("F_navn").ToString
            navn += " " & dr_kunde("E_navn").ToString


            ComboKunde.Items.Add(navn)
        Next




    End Sub


    Private Sub btnFerdigLeie_Click(sender As Object, e As EventArgs) Handles btnFerdigLeie.Click

        Dim navn() As String = ComboKunde.Text.Split(" ")
        Dim Lager() As String = ComboLager.Text.Split(" ")

        Dim Produkt1 As Integer = CInt(ComboProdukt.Text)
        Dim kunde1 As Integer = navn(0)
        Dim fra1 As Date = dtpFra.Value
        Dim til1 As Date = dtpTil.Value
        Dim lager1 As Integer = Lager(0)


        Core.regLeie(Produkt1, til1, fra1, kunde1, lager1)


        Me.Close()
    End Sub


End Class
