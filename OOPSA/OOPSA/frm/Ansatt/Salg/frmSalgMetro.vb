Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmSalgMetro
    Inherits MetroForm

    Dim Core As New formAnsattCore
    Dim SQL As New SQL

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmSalgMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initialize()

        Me.SalgsRaportTableAdapter.Fill(Me.drift8_2016dsSalgsRapportView.SalgsRaport)

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

            ComboKunde1.Items.Add(navn)
        Next

        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", ComboKurs)
        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", ComboKurs1)
        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", ComboRegSalg)
        LeggTildataCOMBOBOX("SELECT * FROM Lager", "Lager", "Lager_id", "by", ComboSalgLager)

        Me.dgvKurs.Refresh()
    End Sub

    Public Sub LeggTildataCOMBOBOX(SQLstring As String, Tabell As String, ID_rad As String, Rad As String, Combo As Syncfusion.Windows.Forms.Tools.ComboBoxAdv)

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

    Private Sub btnRegSalg_Click(sender As Object, e As EventArgs) Handles btnRegSalg.Click
        Dim UCore As New UserCore

        Dim produkt() As String = ComboRegSalg.Text.Split(" ")
        Dim lager() As String = ComboSalgLager.Text.Split(" ")
        Dim avanse As Integer = CInt(txtavanse.Text)
        Dim ansatt_id As Integer = UCore.Getuserid(UCore.currentUsr)
        Dim kunde_id() As String = cmbKundeID.Text.Split(" ")
        Dim antall As Integer = CInt(Produktantall.Text)

        Try
            SQL.sporring("INSERT INTO `Kjøp`(`S_id`, `dato`, `Avanse`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_Produkt_id`, `Antall`, `Lager_id`) VALUES (NULL,CURDATE()," & avanse & "," & ansatt_id & "," & kunde_id(0) & "," & produkt(0) & "," & antall & "," & lager(0) & ")")
            MsgBox("Salget er registert", MsgBoxStyle.Information, "Salg Registrering")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click

        'Noe galt med spørringen ellers bør alt virke


        Dim sqlstring As String

        Dim Kundenavn As String = ComboKunde1.Text
        Dim KursNavn As String = ComboKurs.Text

        Dim kundeF() As String
        kundeF = Kundenavn.Split(" ")

        Try

            Kundenavn = Kundenavn(1) & " " & Kundenavn(2)
            Dim Kid As Integer = CInt(Kundenavn(0).ToString)

            MsgBox(Kid)

            sqlstring = "SELECT Kurs_id FROM Kurs WHERE Navn = " & KursNavn & " AND NOW() < Tid_avholdt"
            Dim Kurs_id As Integer = SQL.Return1Row(sqlstring, "Kurs_id")

            MsgBox(Kurs_id)

            sqlstring = "SELECT Tid_avholdt FROM Kurs WHERE Kurs_id=" & Kurs_id & ""
            Dim Tid As String = SQL.Return1Row(sqlstring, "Tid_avholdt")

            MsgBox(Tid)

            SQL.sporring("INSERT INTO Kurs_deltagelse (`Kurs_Kurs_id`, `Kunde_Kid`, `Dato`) VALUES (" & Kurs_id & ", " & Kid & ", " & Tid & ");")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSokBestilling_Click(sender As Object, e As EventArgs) Handles btnSokBestilling.Click
        Dim kundeid As Integer = CInt(TextBoxExt7.Text)
        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", ComboDropDown3)
        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", Combo)




        Dim adapter As New MySqlDataAdapter("SELECT Antall From Kjøp WHERE Kunde_Kid = " & kundeid & "", con)
        Dim ds_produkt = New DataSet
        Dim dr_produkt As DataRow
        Dim dt_produkt As DataTable
        adapter.Fill(ds_produkt, "Kjøp")
        dt_produkt = ds_produkt.Tables(0)
        For Each dr_produkt In dt_produkt.Rows
            TextBoxExt9.Text = dr_produkt("Antall")
        Next

        Dim adapter1 As New MySqlDataAdapter("SELECT Antall from Kurs WHERE Kunde_Kid = " & kundeid & "", con)
        Dim ds_produkt1 = New DataSet
        Dim dr_produkt1 As DataRow
        Dim dt_produkt1 As DataTable
        adapter1.Fill(ds_produkt1, "Kjøp")
        dt_produkt1 = ds_produkt1.Tables(0)
        For Each dr_produkt1 In dt_produkt1.Rows
            TextBoxExt9.Text = dr_produkt1("Antall")
        Next


        ComboKUNDEVALG.Items.Clear()

        Dim adapter2 As New MySqlDataAdapter("SELECT Dato, Kjøp.Produkt_Produkt_id, Produkt_navn FROM Kjøp INNER JOIN Produkt ON Kjøp.Produkt_Produkt_id=Produkt.Produkt_id WHERE kunde_Kid = " & kundeid & "", con)
        Dim ds_produkt2 = New DataSet
        Dim dr_produkt2 As DataRow
        Dim dt_produkt2 As DataTable
        adapter2.Fill(ds_produkt2, "Kjøp")
        dt_produkt2 = ds_produkt2.Tables(0)
        For Each dr_produkt2 In dt_produkt2.Rows
            Dim kjøp As String

            kjøp = dr_produkt2("Dato")
            kjøp += " " & dr_produkt2("Produkt_Produkt_id")
            kjøp += " " & dr_produkt2("Produkt_navn")
            ComboKUNDEVALG.Items.Add(kjøp)

        Next


    End Sub

    Private Sub ButtonAdv5_Click(sender As Object, e As EventArgs) Handles ButtonAdv5.Click
        Dim Salgsinfo() As String = ComboKUNDEVALG.Text.Split(" ")
        Dim dato As String = Salgsinfo(0)
        Dim PID As String = Salgsinfo(1)
        Dim kundeID As String = TextBoxExt7.Text



        MsgBox(dato)
        MsgBox(PID)
        MsgBox(kundeID)

        ' Dim sqlstreng As String = "SELECT Antall FROM Kjøp WHERE Kunde_Kid = " & kundeID & " AND Produkt_Produkt_id = " & PID & " AND dato = '" & dato & "'  "
        'Dim antall As Integer = sql.Return1Row(sqlstreng, "Antall")

        '  MsgBox(antall)

        'Noe galt med spørring???

        Try
            SQL.sporring("DELETE FROM Kjøp WHERE Produkt_Produkt_id = " & PID & " AND Kunde_Kid = " & kundeID & " AND  dato = '" & dato & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNyKunde_Click(sender As Object, e As EventArgs) Handles btnNyKunde.Click
        frmAddKunde.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Logout()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Logout()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Logout()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Logout()
    End Sub

    Private Sub ButtonAdv2_Click(sender As Object, e As EventArgs) Handles ButtonAdv2.Click

        Dim kunde() As String = ComboKunde1.Text.Split(" ")
        Dim kid As Integer = kunde(0)
        Dim Kurs_id() As String = ComboKurs1.Text.Split(" ")
        Dim antallPersoner As Integer = TextBoxExt3.Text
        Dim dato As Date = dtpKurs.Value

        SQL.sporring("INSERT INTO `drift8_2016`.`Kurs_deltagelse` (`Kurs_Kurs_id`, `Kunde_Kid`, `Dato`, `Antall`) VALUES ('" & Kurs_id(0) & "', '" & kid & "', '" & dato & "', '" & antallPersoner & "');")
        MsgBox("Kurset er registrert", MsgBoxStyle.Information, "Registering av kurs")


    End Sub

    Private Sub btbAddleie_Click(sender As Object, e As EventArgs) Handles btbAddleie.Click
        Dim UCore As New UserCore

        Dim produkt() As String = ComboProdukt.Text.Split(" ")
        Dim kunde() As String = ComboKunde1.Text.Split(" ")
        Dim ansattid = UCore.Getuserid(UCore.currentUsr)
        Dim fra As Date = dtpFra.Value
        Dim til As Date = dtpTil.Value
        Dim lager() As String = ComboLager.Text.Split(" ")



        SQL.sporring("INSERT INTO `drift8_2016`.`Leie` (`Leie_id`, `Fra`, `Til`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_id`, `Lager_id`) VALUES (NULL, '" & fra & "', '" & til & "', '" & ansattid & "', '" & kunde(0) & "', '" & produkt(0) & "', '" & lager(0) & "');", "Leiet er registrert")


    End Sub

    Private Sub ButtonAdv3_Click(sender As Object, e As EventArgs) Handles ButtonAdv3.Click
        'OPPDATER KURS
    End Sub

    Private Sub ButtonAdv4_Click(sender As Object, e As EventArgs) Handles ButtonAdv4.Click


        'DOOOOO STUFFFFF


        Dim kunde_id As Integer = CInt(TextBoxExt7.Text)
        Dim Kurs_Kurs_id As Integer
        Dim Dato As Date
        Dim antall = CInt(TextBoxExt9.Text)


        SQL.sporring("Update Kurs_deltagelse SET Kurs_Kurs_id = " & Kurs_Kurs_id & ", Dato = " & Dato & ", Antall = " & antall & " WHERE Kurs_deltagelse.Kurs_Kurs_id = " & Kurs_Kurs_id & " And Kurs_deltagelse.Kunde_Kid = " & kunde_id & " And Kurs_deltagelse.Dato` = " & Dato & "", "Oppdatert bestilling")





    End Sub
End Class
