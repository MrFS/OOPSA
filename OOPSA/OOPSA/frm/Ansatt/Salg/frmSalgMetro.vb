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

            ComboKunde.Items.Add(navn)
        Next

        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", ComboKurs)
        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", ComboRegSalg)
        LeggTildataCOMBOBOX("SELECT * FROM Lager", "Lager", "Lager_id", "by", ComboSalgLager)

        Me.ReportViewer1.RefreshReport()
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

    Private Sub btnRegSalg_Click(sender As Object, e As EventArgs) Handles btnRegSalg.Click
        Dim UCore As New UserCore

        Dim produkt() As String = ComboRegSalg.Text.Split(" ")
        Dim lager() As String = ComboSalgLager.Text.Split(" ")
        Dim avanse As Integer = CInt(txtavanse.Text)
        Dim ansatt_id As Integer = UCore.Getuserid(UCore.currentUsr)
        Dim kunde_id As Integer = CInt(cmbKundeID.Text)
        Dim antall As Integer = CInt(Produktantall.Text)

        Try
            SQL.sporring("INSERT INTO `Kjøp`(`S_id`, `dato`, `Avanse`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_Produkt_id`, `Antall`, `Lager_id`) VALUES (NULL,CURDATE()," & avanse & "," & ansatt_id & "," & kunde_id & "," & produkt(0) & "," & antall & "," & lager(0) & ")")
            MsgBox("Salget er registert", MsgBoxStyle.Information, "Salg Registrering")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click

        'Noe galt med spørringen ellers bør alt virke


        Dim sqlstring As String

        Dim Kundenavn As String = ComboKunde.Text
        Dim KursNavn As String = ComboKurs.Text

        Dim kundeF() As String
        kundeF = Kundenavn.Split(" ")

        Try

            sqlstring = "SELECT Kid FROM Kunde WHERE F_navn = '" & kundeF(0) & "' AND  E_navn = '" & kundeF(1) & "' "
            Dim Kid As Integer = SQL.Return1Row(sqlstring, "Kid")

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
        Dim kundeid As String = TextBoxExt7.Text


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
End Class
