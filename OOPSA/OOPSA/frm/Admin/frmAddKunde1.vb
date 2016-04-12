Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddKunde1
    Inherits MetroForm
    Dim sql As New SQL
    Dim kundetype As Boolean


    Private Sub btnnyKunde_Click(sender As Object, e As EventArgs) Handles btnNyKunde.Click
        Try
            If kundetype = True Then
                'legger inn i PersonKunde tabellen
                Dim cmd1 As New MySqlCommand("INSERT INTO K_privat (P_addresse, Post) VALUES (@P_addresse, @Post)", con)

                cmd1.Parameters.AddWithValue("@P_addresse", txtPrivAdresse.Text)
                cmd1.Parameters.AddWithValue("@Post", txtPrivPnr)

                cmd1.ExecuteNonQuery()
            Else
                'legger inn i bedriftskunde tabellen
                Dim cmd2 As New MySqlCommand("INSERT INTO K_bedriftt (B_addresse, Post, Bedrift) VALUES (@B_addresse, @Post, @Bedrift)", con)

                cmd2.Parameters.AddWithValue("@B_addresse", txtBedAdresse.Text)
                cmd2.Parameters.AddWithValue("@Post", txtKundeEpost.Text)
                cmd2.Parameters.AddWithValue("@Bedrift", txtBedriftNavn.Text)

                cmd2.ExecuteNonQuery()

            End If

            'legger info inn i Kunde tabellen
            Dim cmd As New MySqlCommand("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)", con)

                cmd.Parameters.AddWithValue("@F_navn", txtKundeFnavn.Text)
                cmd.Parameters.AddWithValue("@E_navn", txtKundeEnavn.Text)
                cmd.Parameters.AddWithValue("@epostt", txtKundeEpost.Text)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()

        'sql.sporring("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)")
    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles btnPrivatKunde.Click
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

        btnBedriftKunde.Visible = False
        kundetype = True

    End Sub
    'viser elementer tilhørende privatkunde registrering

    Private Sub frmAddKunde1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        btnPrivatKunde.Hide()

    End Sub
    'viser elementer tilhørende bedriftsregistrering
End Class
