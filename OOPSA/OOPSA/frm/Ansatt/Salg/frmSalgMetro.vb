Imports Syncfusion.Windows.Forms

Public Class frmSalgMetro
    Inherits MetroForm

    Private Sub frmSalgMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger' table. You can move, or remove it, as needed.
        Me.LagerRapportStavangerTableAdapter.Fill(Me.Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger)
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE' table. You can move, or remove it, as needed.
        Me.LagerRapportALLETableAdapter.Fill(Me.Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE)
        'TODO: This line of code loads data into the 'Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim' table. You can move, or remove it, as needed.
        Me.LagerRapportTrondheimTableAdapter.Fill(Me.Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim)
        'TODO: This line of code loads data into the 'drift8_2016dsSalgsRapportView.SalgsRaport' table. You can move, or remove it, as needed.
        Me.SalgsRaportTableAdapter.Fill(Me.drift8_2016dsSalgsRapportView.SalgsRaport)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kurs' table. You can move, or remove it, as needed.
        Me.KursTableAdapter.Fill(Me.Drift8_2016DataSet.Kurs)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
