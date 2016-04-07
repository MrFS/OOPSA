Imports Syncfusion.Windows.Forms

Public Class frmAddLeie
    Inherits MetroForm
    Dim Core As New frmAdminCore



    Private Sub frmAddLeie_Load(sender As Object, e As EventArgs) Handles MyBase.Load




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
