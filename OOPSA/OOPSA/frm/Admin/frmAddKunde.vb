Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddKunde
    Inherits MetroForm
    Dim sql As New SQL
    Dim kundetype As Boolean


    Private Sub btnnyKunde_Click(sender As Object, e As EventArgs) Handles btnNyKunde.Click
        Try
            Dim kundeId As String
            Dim KID As String
            Dim dt As MySqlDataReader
            Dim cmd As New MySqlCommand("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)", con)

            cmd.Parameters.AddWithValue("@F_navn", txtKundeFnavn.Text)
            cmd.Parameters.AddWithValue("@E_navn", txtKundeEnavn.Text)
            cmd.Parameters.AddWithValue("@epostt", txtKundeEpost.Text)

            cmd.ExecuteNonQuery()

            Dim cmdKID As New MySqlCommand("SELECT Kid from Kunde WHERE e_postt = @epost", con)

            cmdKID.Parameters.AddWithValue("@epost", txtKundeEpost.Text)

            dt = cmdKID.ExecuteReader

            While dt.Read()
                KID = dt(0).ToString
            End While

            dt.Close()

            'KID = dt.Item(0).ToString

            'Dim dr As MySqlDataReader = cmdKID.ExecuteReader()




            'dt.Load(dr)

            'Dim cmd3 As String = ("Select Kid from Kunde WHERE e_postt = " & txtKundeEpost.Text & "")

            'dt = sql.sporring(cmd3)


            'cmd3.Parameters.AddWithValue("@epostt", txtKundeEpost.Text)

            'dt = cmd3
            'kundeId = dt.Rows(0).Table("Kid").ToString

            'MsgBox(KID)


            If kundetype = True Then
                'legger inn i PersonKunde tabellen
                Dim cmd1 As New MySqlCommand("INSERT INTO K_privat (Kunde_Kid, P_addresse, Post) VALUES (@Kunde_Kid, @P_addresse, @Post)", con)

                cmd1.Parameters.AddWithValue("@P_addresse", txtPrivAdresse.Text)
                cmd1.Parameters.AddWithValue("@Post", CInt(txtPrivPnr.Text))
                cmd1.Parameters.AddWithValue("@Kunde_Kid", CInt(KID))

                cmd1.ExecuteNonQuery()
            Else
                'legger inn i bedriftskunde tabellen
                Dim cmd2 As New MySqlCommand("INSERT INTO K_bedriftt (B_addresse, Post, Bedrift) VALUES (@B_addresse, @Post, @Bedrift)", con)

                cmd2.Parameters.AddWithValue("@B_addresse", txtBedAdresse.Text)
                cmd2.Parameters.AddWithValue("@Post", CInt(txtBedPnr.Text))
                cmd2.Parameters.AddWithValue("@Bedrift", txtBedriftNavn.Text)

                cmd2.ExecuteNonQuery()

            End If

            'legger info inn i Kunde tabellen


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()

        'sql.sporring("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)")
    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles btnPrivatKunde.Click

        Me.Height = 375

        txtKundeEnavn.Visible = True
        txtKundeEpost.Visible = True
        txtKundeFnavn.Visible = True
        txtPrivAdresse.Visible = True
        txtPrivPnr.Visible = True
        lblPostnr.Visible = True

        lblAdresse.Visible = True
        lblEpost.Visible = True
        lblFornavn.Visible = True
        lblEtternavn.Visible = True
        lblPostnr.Visible = True
        lblBedriftNavn.Visible = False
        txtBedriftNavn.Visible = False

        'btnBedriftKunde.Visible = False
        kundetype = True

    End Sub
    'viser elementer tilhørende privatkunde registrering

    Private Sub frmAddKunde1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initialize()

        Me.Height = 150
        Me.Refresh()

        'privatkunde + bedriftkunde
        txtKundeEnavn.Visible = False
        txtKundeEpost.Visible = False
        txtKundeFnavn.Visible = False
        lblEpost.Visible = False
        lblFornavn.Visible = False
        lblEtternavn.Visible = False
        'samme for begge
        lblPostnr.Visible = False
        lblAdresse.Visible = False

        'privatkunde
        txtPrivAdresse.Visible = False
        txtPrivPnr.Visible = False

        'bedriftskunde
        lblBedriftNavn.Visible = False
        txtBedriftNavn.Visible = False
        txtBedPnr.Visible = False
        txtBedAdresse.Visible = False


    End Sub
    'Sjuler alle elementer før man har valgt hva som skal registreres
    Private Sub btnBedriftKunde_Click(sender As Object, e As EventArgs) Handles btnBedriftKunde.Click

        Me.Height = 375
        Me.Refresh()

        txtBedriftNavn.Visible = True
        txtBedPnr.Visible = True
        txtBedAdresse.Visible = True
        txtKundeEnavn.Visible = True
        txtKundeEpost.Visible = True
        txtKundeFnavn.Visible = True

        lblPostnr.Visible = True
        lblAdresse.Visible = True
        lblBedriftNavn.Visible = True
        lblEpost.Visible = True
        lblFornavn.Visible = True
        lblEtternavn.Visible = True

        'btnPrivatKunde.Hide()

    End Sub
    'viser elementer tilhørende bedriftsregistrering
End Class
