Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class frmSalg
    Inherits MetroForm

    Private Sub TextBoxExt11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmSalg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kurs' table. You can move, or remove it, as needed.
        Me.KursTableAdapter.Fill(Me.Drift8_2016DataSet.Kurs)
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


        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM Kunde", con)

        Dim ds_kunde = New DataSet
        Dim dr_kunde As DataRow
        Dim dt_kunde As DataTable

        adapter2.Fill(ds_kunde, "Kunde")
        dt_kunde = ds_kunde.Tables(0)
        For Each dr_kunde In dt_kunde.Rows
            Dim navn As String

            navn = dr_kunde("F_navn").ToString
            navn += " " & dr_kunde("E_navn").ToString

            ComboKunde.Items.Add(navn)
        Next


    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click




        Dim sql As New SQL
        Dim sqlstring As String
        Dim dt As DataTable
        Dim dr As DataRow

        Dim Kundenavn As String = ComboKunde.Text
        Dim KursNavn As String = ComboKurs.Text
        Dim kundeF() As String


        kundeF = Kundenavn.Split(" ")



        sqlstring = "SELECT Kid FROM Kunde WHERE F_navn = '" & kundeF(0) & "' AND  E_navn = '" & kundeF(1) & "' "
        dt = sql.sporring(sqlstring)
        Dim kid As String
        dr = dt.Rows(0)
        kid = dr("Kid")



        'Dim Kurs_id As Integer
        'Dim Kid As Integer
        'Dim Tid As String



        'sql.sporring("INSERT INTO Kurs_deltagelse (`Kurs_Kurs_id`, `Kunde_Kid`, `Dato`) VALUES (" & Kurs_id & ", " & Kid & ", " & Tid & ");")



    End Sub

    Private Sub btnVelg_Click(sender As Object, e As EventArgs) Handles btnVelg.Click

        Dim kunde As String = CInt(txtKundid.Text)









    End Sub
End Class
