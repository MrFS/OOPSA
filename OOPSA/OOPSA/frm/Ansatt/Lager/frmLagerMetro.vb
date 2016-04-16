Imports Syncfusion.Windows.Forms

Public Class frmLagerMetro
    Inherits MetroForm

    Private Sub frmLagerMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger' table. You can move, or remove it, as needed.
        Me.LagerRapportStavangerTableAdapter.Fill(Me.Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger)
        'TODO: This line of code loads data into the 'Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim' table. You can move, or remove it, as needed.
        Me.LagerRapportTrondheimTableAdapter.Fill(Me.Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim)
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE' table. You can move, or remove it, as needed.
        Me.LagerRapportALLETableAdapter.Fill(Me.Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE)

    End Sub
End Class
