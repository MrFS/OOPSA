Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddLeie
    Inherits MetroForm
    Dim Core As New frmAdminCore



    Private Sub frmAddLeie_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con)
        Dim ds = New DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        adapter.Fill(ds, "Produkt")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            ComboProdukt.Items.Add(dr("Produkt_navn"))
        Next


        Dim adapter1 As New MySqlDataAdapter("SELECT * FROM Lager", con)
        adapter.Fill(ds, "Lager")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            ComboLager.Items.Add(dr("Addresse"))
        Next


        'Dim adapter2 As New MySqlDataAdapter("SELECT * FROM Kunde", con)
        'adapter.Fill(ds, "Kunde")
        'dt = ds.Tables(0)
        'For Each dr In dt.Rows
        '    ComboKunde.Items.Add(dr("Produkt_navn"))
        'Next




    End Sub


    Private Sub btnFerdigLeie_Click(sender As Object, e As EventArgs) Handles btnFerdigLeie.Click







        Dim Produkt1 As Integer = CInt(ComboProdukt.Text)
        Dim kunde1 As Integer = ComboKunde.Text  'EVT endre til int
        Dim fra1 As Date = dtpFra.Value
        Dim til1 As Date = dtpTil.Value
        Dim lager1 As Integer = CInt(ComboLager.Text)


        Core.regLeie(Produkt1, til1, fra1, kunde1, lager1)


        Me.Close()
    End Sub


End Class
