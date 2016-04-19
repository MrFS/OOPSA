Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmLager
    Inherits MetroForm

    Dim lager As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        ' Dim da = New MySqlCommand()



    End Sub

    Private Sub frmLager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Produkt' table. You can move, or remove it, as needed.
        Me.ProduktTableAdapter.Fill(Me.Drift8_2016DataSet.Produkt)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Produkt' table. You can move, or remove it, as needed.
        Me.ProduktTableAdapter.Fill(Me.Drift8_2016DataSet.Produkt)


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

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles EndreKnapp.Click
        Dim sql As New SQL

        Try
            Dim dt As DataTable
            Dim dr As DataRow
            dt = sql.sporring("SELECT Lager_id FROM `Lager` WHERE `by` = '" & lagerEndre.Text & "'")
            dr = dt.Rows(0)


            sql.sporring("UPDATE Produkt SET Produkt_navn = '" & navnEndreText.Text & "', Pris = '" & prisEndreText.Text & "', p_antall = '" & antEndreText.Text & "', Lager_id = '" & dr("Lager_id") & "' WHERE Produkt_navn='" & VareEndre.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VareEndre.SelectedIndexChanged







    End Sub

    Private Sub LagerLeggTil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LagerLeggTil.SelectedIndexChanged

    End Sub

    Private Sub TabControlAdv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlAdv1.SelectedIndexChanged



    End Sub

    Private Sub ButtonAdv2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub vareSlett_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles btnSlett.Click

    End Sub

    Private Sub NavnLeggTil_TextChanged(sender As Object, e As EventArgs) Handles NavnLeggTil.TextChanged

    End Sub
End Class
