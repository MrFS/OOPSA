Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmSalgMetro
    Inherits MetroForm

    Dim Core As New formAnsattCore
    Dim SQL As New SQL

    Public Sub New()
        Initialize()
        InitializeComponent()
    End Sub

    Private Sub frmSalgMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LagerRapportALLETableAdapter.Fill(Me.Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE)
        Me.LagerRapportStavangerTableAdapter.Fill(Me.Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger)
        Me.LagerRapportTrondheimTableAdapter.Fill(Me.Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim)
        dgvKurs.DataSource = SQL.bindingsource("SELECT * FROM Kurs")

        KursTableAdapter.Fill(Drift8_2016DataSet.Kurs)

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

        Dim adapter1 As New MySqlDataAdapter("SELECT * FROM Ansatt", con)
        Dim ds_kunde1 = New DataSet
        Dim dr_kunde1 As DataRow
        Dim dt_kunde1 As DataTable

        adapter1.Fill(ds_kunde1, "Ansatt")
        dt_kunde1 = ds_kunde1.Tables(0)
        For Each dr_kunde1 In dt_kunde1.Rows
            Dim Anavn As String

            Anavn = dr_kunde1("A_id").ToString
            Anavn += " " & dr_kunde1("F_navn").ToString
            Anavn += " " & dr_kunde1("E_navn").ToString

            ComboInstruktor.Items.Add(Anavn)
        Next




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



        'FINNER ANTALL Trenger ny funksjon
        'Dim adapter As New MySqlDataAdapter("SELECT Antall From Kjøp WHERE Kunde_Kid = " & kundeid & "", con)
        'Dim ds_produkt = New DataSet
        'Dim dr_produkt As DataRow
        'Dim dt_produkt As DataTable
        'adapter.Fill(ds_produkt, "Kjøp")
        'dt_produkt = ds_produkt.Tables(0)
        'For Each dr_produkt In dt_produkt.Rows
        '    TextBoxExt9.Text = dr_produkt("Antall")
        'Next

        'Dim adapter1 As New MySqlDataAdapter("SELECT Antall from Kurs_deltagelse WHERE Kunde_Kid = " & kundeid & "", con)
        'Dim ds_produkt1 = New DataSet
        'Dim dr_produkt1 As DataRow
        'Dim dt_produkt1 As DataTable
        'adapter1.Fill(ds_produkt1, "Kurs")
        'dt_produkt1 = ds_produkt1.Tables(0)
        'For Each dr_produkt1 In dt_produkt1.Rows
        '    TextBoxExt10.Text = dr_produkt1("Antall")
        'Next




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


        Dim adapter3 As New MySqlDataAdapter("SELECT Kurs_Kurs_id, Antall, Dato FROM Kurs_deltagelse WHERE Kunde_Kid = '" & kundeid & "' ", con)
        Dim ds_produkt22 = New DataSet
        Dim dr_produkt22 As DataRow
        Dim dt_produkt22 As DataTable
        adapter3.Fill(ds_produkt22, "Kjøp")
        dt_produkt22 = ds_produkt22.Tables(0)
        For Each dr_produkt22 In dt_produkt22.Rows
            Dim leie As String

            leie = dr_produkt22("Dato")
            leie += " " & dr_produkt22("Kurs_Kurs_id")
            leie += " " & dr_produkt22("Antall")
            ComboKUNDEVALG.Items.Add(leie)
        Next


    End Sub

    Private Sub ButtonAdv5_Click(sender As Object, e As EventArgs) Handles ButtonAdv5.Click
        Dim Salgsinfo() As String = ComboKUNDEVALG.Text.Split(" ")
        Dim dato As String = Salgsinfo(0)
        Dim PID As String = Salgsinfo(1)
        Dim kundeID As String = TextBoxExt7.Text


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
        Dim ansattid = UCore.UIDProp
        Dim fra As Date = dtpFra.Value
        Dim til As Date = dtpTil.Value
        Dim lager() As String = ComboLager.Text.Split(" ")
        Dim PrisPer As Integer = SQL.Return1Row("SELECT Pris FROM Produkt WHERE Produkt_id = 1", "Pris")
        Dim antall As Integer = IntegerTextBox2.Text
        Dim lagerbeholdning As Integer = SQL.Return1Row("SELECT Antall FROM Lagerbeholdning WHERE Lager_id = " & lager(0) & " AND Produkt_id = " & produkt(0) & "", "Antall")


        If lagerbeholdning >= antall Then

            SQL.sporring("INSERT INTO `drift8_2016`.`Leie` (`Leie_id`, `Fra`, `Til`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_id`, `Lager_id`) VALUES (NULL, '" & fra & "', '" & til & "', '" & ansattid & "', '" & kunde(0) & "', '" & produkt(0) & "', '" & lager(0) & "');", "Leiet er registrert")
            lstSalgIDag.Items.Add("Produkt navn: " & produkt(1) & vbCrLf & "Fra: " & fra & vbCrLf & "Til: " & til)
            totall += PrisPer
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


        Dim kunde_id As Integer = CInt(TextBoxExt7.Text)
        Dim Kurs_Kurs_id As Integer
        Dim Dato As Date
        Dim antall = CInt(TextBoxExt9.Text)
        Dim Velgsalg As String = Comboslgodt.Text

        If chkEndreSalg.Checked = True Then
            SQL.sporring("Update Kurs_deltagelse SET Kurs_Kurs_id = " & Kurs_Kurs_id & ", Dato = " & Dato & ", Antall = " & antall & " WHERE Kurs_deltagelse.Kurs_Kurs_id = " & Kurs_Kurs_id & " And Kurs_deltagelse.Kunde_Kid = " & kunde_id & " And Kurs_deltagelse.Dato` = " & Dato & "", "Oppdatert bestilling")

        ElseIf chkEndreLeie.Checked = True Then

            SQL.sporring("")


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
