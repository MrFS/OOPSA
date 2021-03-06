﻿Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmSalgMetro
    Inherits MetroForm

    Dim Core As New frmAnsattCore
    Dim SQL As New SQL

    Public Sub New()
        Initialize()
        InitializeComponent()
    End Sub

    Private Sub frmSalgMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fyller rapportene med info
        Me.LagerRapportALLETableAdapter.Fill(Me.Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE)
        Me.LagerRapportStavangerTableAdapter.Fill(Me.Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger)
        Me.LagerRapportTrondheimTableAdapter.Fill(Me.Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim)
        dgvKurs.DataSource = SQL.bindingsource("SELECT * FROM Kurs")
        KursTableAdapter.Fill(Drift8_2016DataSet.Kurs)
        Me.SalgsRaportTableAdapter.Fill(Me.drift8_2016dsSalgsRapportView.SalgsRaport)

        'Fylller aller nødvendige comboboxer med string varial hentet fra sql spørringen

        leggTildataCOMBOBOX3X("SELECT * FROM Kunde", "Kunde", "Kid", "F_navn", "E_navn", ComboKunde1)
        leggTildataCOMBOBOX3X("SELECT * FROM Ansatt", "Ansatt", "A_id", "F_navn", "E_navn", ComboInstruktor)
        LeggTildataCOMBOBOX("SELECT * FROM Avdeling", "Avdeling", "id_Avdeling", "city", ComboAvdeling)
        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", ComboKurs1)
        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", ComboRegSalg)
        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", ComboProdukt)
        LeggTildataCOMBOBOX("SELECT * FROM Lager", "Lager", "Lager_id", "by", ComboSalgLager)
        LeggTildataCOMBOBOX("SELECT * FROM Lager", "Lager", "Lager_id", "by", ComboLager)


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



    Public Sub leggTildataCOMBOBOX3X(SQLstring As String, Tabell As String, Rad1 As String, Rad2 As String, Rad3 As String, Combo As Syncfusion.Windows.Forms.Tools.ComboBoxAdv)


        Dim adapter As New MySqlDataAdapter(SQLstring, con)
        Dim ds_kunde = New DataSet
        Dim dr_kunde As DataRow
        Dim dt_kunde As DataTable

        adapter.Fill(ds_kunde, Tabell)
        dt_kunde = ds_kunde.Tables(0)
        For Each dr_kunde In dt_kunde.Rows
            Dim samling As String
            samling = dr_kunde(Rad1).ToString
            samling += " " & dr_kunde(Rad2).ToString
            samling += " " & dr_kunde(Rad3).ToString
            ComboKunde1.Items.Add(samling)
        Next


    End Sub




    Dim totall As Integer

    Private Sub btnRegSalg_Click(sender As Object, e As EventArgs) Handles btnRegSalg.Click
        Dim UCore As New UserCore
        Dim produkt() As String = ComboRegSalg.Text.Split(" ")
        Dim lager() As String = ComboSalgLager.Text.Split(" ")
        Dim avanse As Integer = CInt(txtavanse.Text)
        Dim ansatt_id As Integer = UCore.UIDProp
        Dim kunde_id() As String = ComboKunde1.Text.Split(" ")
        Dim antall As Integer = CInt(Produktantall.Text)
        Dim PrisPer As Integer = SQL.Return1Row("SELECT Pris FROM Produkt WHERE Produkt_id = " & produkt(0) & "", "Pris")
        Dim PrismAvanse As Integer = (((avanse / 100) * PrisPer) + PrisPer) * antall

        Dim lagerbeholdning As Integer = SQL.Return1Row("SELECT Antall FROM Lagerbeholdning WHERE Lager_id = " & lager(0) & " AND Produkt_id = " & produkt(0) & "", "Antall")





        If lagerbeholdning >= antall Then

            Try
                SQL.sporring("INSERT INTO `Kjøp`(`S_id`, `dato`, `Avanse`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_Produkt_id`, `Antall`, `Lager_id`) VALUES (NULL,CURDATE()," & avanse & "," & ansatt_id & "," & kunde_id(0) & "," & produkt(0) & "," & antall & "," & lager(0) & ")")
                SQL.sporring("UPDATE Lagerbeholdning SET Antall = " & (lagerbeholdning - antall) & " WHERE Lager_id = " & lager(0) & " AND Produkt_id = " & produkt(0) & "")
                MsgBox("Salget er registert", MsgBoxStyle.Information, "Salg Registrering")
                lstSalgIDag.Items.Add("Produkt navn: " & produkt(1) & vbCrLf & " Antall: " & antall & " Avannse: " & avanse)

                totall += PrismAvanse

                lblTotPris.Text = "Total pris " & totall

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("Det er ikke mer igjen av " & produkt(1), MsgBoxStyle.Critical, "Ikke flere på lager")
        End If




    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles ButtonAdv1.Click

        Dim navn As String = Txt.Text
        Dim pris_per As Integer = CInt(IntegerTextBox1.Text)
        Dim beskrivelse As String = TextBoxExt1.Text
        Dim instrukor() As String = ComboInstruktor.Text.Split(" ")
        Dim avdeling() As String = ComboAvdeling.Text.Split(" ")


        SQL.sporring("INSERT INTO `drift8_2016`.`Kurs` (`Kurs_id`, `Navn`, `Beskrivelse`, `Pris_per`, `ekstern_Ansatt_id`, `Avdeling_id`) VALUES (NULL, '" & navn & "', '" & beskrivelse & "', '" & pris_per & "', '" & instrukor(0) & "', '" & avdeling(0) & "');")


        dgvKurs.DataSource = SQL.bindingsource("SELECT * FROM Kurs")
        dgvKurs.Refresh()

    End Sub

    Private Sub btnSokBestilling_Click(sender As Object, e As EventArgs) Handles btnSokBestilling.Click
        Dim kundeid As Integer = CInt(TextBoxExt7.Text)


        'Refresh
        ComboKUNDEVALG.Items.Clear()
        Combo.Items.Clear()
        Comboendrepro.Items.Clear()
        TextBoxExt9.Clear()
        TextBoxExt10.Clear()


        LeggTildataCOMBOBOX("SELECT * FROM Produkt", "Produkt", "Produkt_id", "Produkt_navn", Comboendrepro)
        LeggTildataCOMBOBOX("SELECT * FROM Kurs", "Kurs", "Kurs_id", "Navn", Combo)
        leggTildataCOMBOBOX3X("SELECT Dato, Kjøp.Produkt_Produkt_id, Produkt_navn FROM Kjøp INNER JOIN Produkt ON Kjøp.Produkt_Produkt_id=Produkt.Produkt_id WHERE kunde_Kid = " & kundeid & "", "Kjøp", "Dato", "Produkt_Produkt_id", "Produkt_navn", ComboKUNDEVALG)
        leggTildataCOMBOBOX3X("SELECT Kurs_Kurs_id, Antall, Dato FROM Kurs_deltagelse WHERE Kunde_Kid = '" & kundeid & "' ", "Kjøp", "Dato", "Kurs_Kurs_id", "Antall", ComboKUNDEVALG)


    End Sub

    Private Sub ButtonAdv5_Click(sender As Object, e As EventArgs) Handles ButtonAdv5.Click
        Dim Salgsinfo() As String = ComboKUNDEVALG.Text.Split(" ")
        Dim dato As String = Salgsinfo(0)
        Dim PID As String = Salgsinfo(1)
        Dim kundeID As String = TextBoxExt7.Text

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
        'Registrer Kurs

        Dim kunde() As String = ComboKunde1.Text.Split(" ")
        Dim kid As Integer = kunde(0)
        Dim Kurs_id() As String = ComboKurs1.Text.Split(" ")
        Dim antallPersoner As Integer = TextBoxExt3.Text
        Dim dato As String = dtpKurs.Value.ToString
        Dim PrisPer As Integer = SQL.Return1Row("SELECT Pris_per FROM Kurs WHERE Kurs_id = " & Kurs_id(0) & "", "Pris_per")
        Dim pristot As Integer = PrisPer * antallPersoner


        SQL.sporring("INSERT INTO `drift8_2016`.`Kurs_deltagelse` (`Kurs_Kurs_id`, `Kunde_Kid`, `Dato`, `Antall`) VALUES ('" & Kurs_id(0) & "', '" & kid & "', '" & dato & "', '" & antallPersoner & "');")
        MsgBox("Kurset er registrert", MsgBoxStyle.Information, "Registering av kurs")
        lstSalgIDag.Items.Add("Kurs navn: " & Kurs_id(1) & vbCrLf & "Antall personer: " & antallPersoner & vbCrLf & "Dato:" & dato)


        totall += pristot
        lblTotPris.Text = "Total pris " & totall

    End Sub

    Private Sub btbAddleie_Click(sender As Object, e As EventArgs) Handles btbAddleie.Click
        'LEIE
        Dim UCore As New UserCore

        Dim produkt() As String = ComboProdukt.Text.Split(" ")
        Dim kunde() As String = ComboKunde1.Text.Split(" ")
        Dim ansattid = UCore.UID
        Dim fra As Date = dtpFra.Value
        Dim til As Date = dtpTil.Value
        Dim lager() As String = ComboLager.Text.Split(" ")
        Dim PrisPer As Integer = SQL.Return1Row("SELECT Pris FROM Produkt WHERE Produkt_id = 1", "Pris")
        Dim antall As Integer = IntegerTextBox2.Text
        Dim lagerbeholdning As Integer = SQL.Return1Row("SELECT Antall FROM Lagerbeholdning WHERE Lager_id = " & lager(0) & " AND Produkt_id = " & produkt(0) & "", "Antall")


        If lagerbeholdning >= antall Then
            SQL.sporring("UPDATE Lagerbeholdning SET Antall = " & (lagerbeholdning - antall) & " WHERE Lager_id = " & lager(0) & " AND Produkt_id = " & produkt(0) & "")
            SQL.sporring("INSERT INTO `drift8_2016`.`Leie` (`Leie_id`, `Fra`, `Til`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_id`, `Lager_id`, `Antall`) VALUES (NULL, '" & fra & "', '" & til & "', '" & ansattid & "', '" & kunde(0) & "', '" & produkt(0) & "', '" & lager(0) & "', '" & antall & "' );", "Leiet er registrert")
            lstSalgIDag.Items.Add("Produkt navn: " & produkt(1) & vbCrLf & "Fra: " & fra & vbCrLf & "Til: " & til)
            totall += PrisPer * antall
            lblTotPris.Text = "Total pris " & totall
        Else
            MsgBox("Det er ikke mer igjen av " & produkt(1), MsgBoxStyle.Critical, "Ikke flere på lager")

        End If

    End Sub

    Private Sub ButtonAdv3_Click(sender As Object, e As EventArgs) Handles ButtonAdv3.Click

        Me.KursTableAdapter.Update(Drift8_2016DataSet.Kurs)

        'OPPDATER KURS
    End Sub

    Private Sub ButtonAdv4_Click(sender As Object, e As EventArgs) Handles ButtonAdv4.Click

        'DOOOOO STUFFFFF
        Dim tabbbble() As String = ComboKUNDEVALG.Text.Split(" ")
        Dim Dato_ogrinal As Date = tabbbble(0)
        Dim p_id_orinal As Integer = tabbbble(1)




        Dim kunde_id As Integer = CInt(TextBoxExt7.Text)
        Dim Kurs_Kurs_id As Integer
        Dim Dato As Date
        Dim antall = CInt(TextBoxExt9.Text)
        Dim Velgsalg As String = Comboslgodt.Text
        Dim produkt_id() As String = Comboendrepro.Text.Split(" ")




        If chkEndreSalg.Checked = True Then
            SQL.sporring("Update Kurs_deltagelse SET Kurs_Kurs_id = " & Kurs_Kurs_id & ", Dato = " & Dato & ", Antall = " & antall & " WHERE Kurs_deltagelse.Kurs_Kurs_id = " & Kurs_Kurs_id & " And Kurs_deltagelse.Kunde_Kid = " & kunde_id & " And Kurs_deltagelse.Dato` = " & Dato & "", "Oppdatert bestilling")

        ElseIf chkEndreLeie.Checked = True Then

            SQL.sporring("UPDATE `drift8_2016`.`Kjøp` SET `dato` = '" & Dato & "', `Produkt_Produkt_id` = '" & produkt_id(0) & "', `Antall` = '" & antall & "', WHERE `Kjøp`.`dato` = '" & Dato_ogrinal & "' AND `Kjøp`.`Kunde_Kid` = '" & kunde_id & "' AND `Kjøp`.`Produkt_Produkt_id` = '" & p_id_orinal & "';")


        End If


    End Sub

    Private Sub chkEndreSalg_CheckStateChanged(sender As Object, e As EventArgs) Handles chkEndreSalg.CheckStateChanged

        chkEndreLeie.Checked = False

        TextBoxExt9.Show()
        Comboendrepro.Show()


        Combo.Hide()
        TextBoxExt10.Hide()
        dtpEndre.Hide()

    End Sub

    Private Sub chkEndreLeie_CheckStateChanged(sender As Object, e As EventArgs) Handles chkEndreLeie.CheckStateChanged

        chkEndreSalg.Checked = False

        Combo.Show()
        TextBoxExt10.Show()
        dtpEndre.Show()

        TextBoxExt9.Hide()
        Comboendrepro.Hide()

    End Sub

    Private Sub checkboxKunde_endret(sender As Object, e As EventArgs) Handles ComboKunde1.DropDownCloseOnClick

        lstSalgIDag.Items.Clear()
        totall = 0
        lblTotPris.Text = "Totall pris: " & totall

    End Sub
End Class
