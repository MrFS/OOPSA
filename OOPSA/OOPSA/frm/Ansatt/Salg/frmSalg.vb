Imports Syncfusion.Windows.Forms

Public Class frmSalg
    Inherits MetroForm

    Private Sub TabPageAdv1_Click(sender As Object, e As EventArgs) Handles TabPageAdv1.Click

    End Sub

    Private Sub TabPageAdv3_Click(sender As Object, e As EventArgs) Handles TabPageAdv3.Click

    End Sub

    Private Sub TextBoxExt11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmSalg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kjøp' table. You can move, or remove it, as needed.
        Me.KjøpTableAdapter.Fill(Me.Drift8_2016DataSet.Kjøp)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kunde' table. You can move, or remove it, as needed.
        Me.KundeTableAdapter.Fill(Me.Drift8_2016DataSet.Kunde)

    End Sub
End Class
