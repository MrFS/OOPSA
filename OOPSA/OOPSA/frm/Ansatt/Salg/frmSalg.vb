Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class frmSalg
    Inherits MetroForm

    Private Sub TabPageAdv1_Click(sender As Object, e As EventArgs) Handles TabRagSalg.Click

    End Sub

    Private Sub TabPageAdv3_Click(sender As Object, e As EventArgs) Handles TabEndreBestilling.Click

    End Sub

    Private Sub TabpPageAdv4_Click(sender As Object, e As EventArgs) Handles TabBooking.Click



    End Sub

    Private Sub TextBoxExt11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmSalg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kjøp' table. You can move, or remove it, as needed.
        ' Me.KjøpTableAdapter.Fill(Me.Drift8_2016DataSet.Kjøp)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kunde' table. You can move, or remove it, as needed.
        Me.KundeTableAdapter.Fill(Me.Drift8_2016DataSet.Kunde)




        Dim adapter As New MySqlDataAdapter("SELECT * FROM Kurs", con)
        Dim ds_produkt = New DataSet
        Dim dr_produkt As DataRow
        Dim dt_produkt As DataTable
        adapter.Fill(ds_produkt, "Kurs")
        dt_produkt = ds_produkt.Tables(0)
        For Each dr_produkt In dt_produkt.Rows
            ComboKurs.Items.Add(dr_produkt("Navn"))
        Next





    End Sub
End Class
