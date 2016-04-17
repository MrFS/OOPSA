Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class frmSalg
    Inherits MetroForm


    Dim sql As New SQL



    Private Sub frmSalg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kurs' table. You can move, or remove it, as needed.
        Me.KursTableAdapter.Fill(Me.Drift8_2016DataSet.Kurs)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kjøp' table. You can move, or remove it, as needed.
        ' Me.KjøpTableAdapter.Fill(Me.Drift8_2016DataSet.Kjøp)
        'TODO: This line of code loads data into the 'Drift8_2016DataSet.Kunde' table. You can move, or remove it, as needed.
        Me.KundeTableAdapter.Fill(Me.Drift8_2016DataSet.Kunde)



        Dim adapter As New MySqlDataAdapter("SELECT * FROM Kunde", con)

        Dim ds_kunde = New DataSet
        Dim dr_kunde As DataRow
        Dim dt_kunde As DataTable

        adapter.Fill(ds_kunde, "Kunde")
        dt_kunde = ds_kunde.Tables(0)
        For Each dr_kunde In dt_kunde.Rows
            Dim navn As String

            navn = dr_kunde("Kid").ToString
            navn += " " & dr_kunde("F_navn").ToString
            navn += " " & dr_kunde("E_navn").ToString

            ComboKunde.Items.Add(navn)
        Next

        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", ComboKurs)
        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", ComboRegSalg)
        LeggTildataCOMBOBOX("SELECT * FROM Lager", "Lager", "Lager_id", "by", ComboSalgLager)


    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click

        'Noe galt med spørringen ellers bør alt virke


        Dim sqlstring As String

        Dim Kundenavn As String = ComboKunde.Text
        Dim KursNavn As String = ComboKurs.Text

        Dim kundeF() As String
        kundeF = Kundenavn.Split(" ")

        sqlstring = "SELECT Kid FROM Kunde WHERE F_navn = '" & kundeF(0) & "' AND  E_navn = '" & kundeF(1) & "' "
        Dim Kid As Integer = sql.Return1Row(sqlstring, "Kid")

        MsgBox(Kid)

        sqlstring = "SELECT Kurs_id FROM Kurs WHERE Navn = " & KursNavn & " AND NOW() < Tid_avholdt"
        Dim Kurs_id As Integer = sql.Return1Row(sqlstring, "Kurs_id")

        MsgBox(Kurs_id)

        sqlstring = "SELECT Tid_avholdt FROM Kurs WHERE Kurs_id=" & Kurs_id & ""
        Dim Tid As String = sql.Return1Row(sqlstring, "Tid_avholdt")

        MsgBox(Tid)

        sql.sporring("INSERT INTO Kurs_deltagelse (`Kurs_Kurs_id`, `Kunde_Kid`, `Dato`) VALUES (" & Kurs_id & ", " & Kid & ", " & Tid & ");")



    End Sub

    Private Sub btnVelg_Click(sender As Object, e As EventArgs) Handles btnVelg.Click

        Dim kundeid As String = txtKundid.Text


        ComboKUNDEVALG.Items.Clear()

        Dim adapter As New MySqlDataAdapter("SELECT Dato, Kjøp.Produkt_Produkt_id, Produkt_navn FROM Kjøp INNER JOIN Produkt ON Kjøp.Produkt_Produkt_id=Produkt.Produkt_id WHERE kunde_Kid = " & kundeid & "", con)
        Dim ds_produkt = New DataSet
        Dim dr_produkt As DataRow
        Dim dt_produkt As DataTable
        adapter.Fill(ds_produkt, "Kjøp")
        dt_produkt = ds_produkt.Tables(0)
        For Each dr_produkt In dt_produkt.Rows
            Dim stuff As String

            stuff = dr_produkt("Dato")
            stuff += " " & dr_produkt("Produkt_Produkt_id")
            stuff += " " & dr_produkt("Produkt_navn")

            ComboKUNDEVALG.Items.Add(stuff)

        Next



    End Sub

    Private Sub btbFjern_Click(sender As Object, e As EventArgs) Handles btbFjern.Click


        Dim Salgsinfo() As String = ComboKUNDEVALG.Text.Split(" ")
        Dim dato As String = Salgsinfo(0)
        Dim PID As String = Salgsinfo(1)
        Dim kundeID As String = txtKundid.Text



        MsgBox(dato)
        MsgBox(PID)
        MsgBox(kundeID)

        ' Dim sqlstreng As String = "SELECT Antall FROM Kjøp WHERE Kunde_Kid = " & kundeID & " AND Produkt_Produkt_id = " & PID & " AND dato = '" & dato & "'  "
        'Dim antall As Integer = sql.Return1Row(sqlstreng, "Antall")

        '  MsgBox(antall)

        'Noe galt med spørring???

        Try
            sql.sporring("DELETE FROM Kjøp WHERE Produkt_Produkt_id = " & PID & " AND Kunde_Kid = " & kundeID & " AND  dato = '" & dato & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnAddUsr_Click(sender As Object, e As EventArgs) Handles btnLeggTilKunde.Click
        frmAddKunde.Show()
    End Sub

    Private Sub btnRegSalg_Click(sender As Object, e As EventArgs) Handles btnRegSalg.Click

        Dim UCore As New UserCore

        Dim produkt() As String = ComboRegSalg.Text.Split(" ")
        Dim lager() As String = ComboSalgLager.Text.Split(" ")
        Dim avanse As Integer = txtavanse.Text
        Dim ansatt_id As Integer = UCore.Getuserid(UCore.currentUsr)
        Dim kunde_id As Integer = TextBoxExt1.Text
        Dim antall As Integer = Produktantall.Text


        sql.sporring("INSERT INTO `Kjøp`(`S_id`, `dato`, `Avanse`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_Produkt_id`, `Antall`, `Lager_id`) VALUES (NULL,CURDATE()," & avanse & "," & ansatt_id & "," & kunde_id & "," & produkt(0) & "," & antall & "," & lager(0) & ")")
        MsgBox("Salget er registert", MsgBoxStyle.Information, "Salg Registrering")

    End Sub




    Public Sub LeggTildataCOMBOBOX(SQLstring As String, Tabell As String, ID_rad As String, Rad As String, Combo As ComboBox)

        Dim adapter As New MySqlDataAdapter(SQLstring, con)
        Dim ds_produkt = New DataSet
        Dim dr_produkt As DataRow
        Dim dt_produkt As DataTable
        adapter.Fill(ds_produkt, Tabell)
        dt_produkt = ds_produkt.Tables(0)
        For Each dr_produkt In dt_produkt.Rows
            Dim stuff As String = dr_produkt(ID_rad) & " " & dr_produkt(Rad)

            Combo.Items.Add(stuff)
        Next

    End Sub

    Private Sub btbAddleie_Click(sender As Object, e As EventArgs) Handles btbAddleie.Click
        frmAddLeie.Show()
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click

    End Sub

    Private Sub BtnRegSKL_Click(sender As Object, e As EventArgs) Handles BtnRegSKL.Click

    End Sub
End Class
