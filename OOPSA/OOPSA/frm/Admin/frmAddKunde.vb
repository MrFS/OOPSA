Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddKunde
    Inherits MetroForm
    Dim SQL As New SQL


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Initialize()

    End Sub

    Private Sub frmAddKunde1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub btnnyKunde_Click(sender As Object, e As EventArgs) Handles btnNyKunde.Click
        Try
            'Legger inn info i Kundetabellen

            Dim KID As Integer
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
                KID = CInt(dt(0).ToString)
            End While

            dt.Close()

            Select Case ComboBoxAdv1.SelectedIndex
                Case = 0 ' Privatkunde
                    'legger inn i PersonKunde tabellen
                    Dim cmd1 As New MySqlCommand("INSERT INTO K_privat (Kunde_Kid, P_addresse, Post) VALUES (@Kunde_Kid, @P_addresse, @Post)", con)

                    cmd1.Parameters.AddWithValue("@P_addresse", txtPrivAdresse.Text)
                    cmd1.Parameters.AddWithValue("@Post", CInt(txtPrivPnr.Text))
                    cmd1.Parameters.AddWithValue("@Kunde_Kid", CInt(KID))

                    cmd1.ExecuteNonQuery()
                Case = 1 ' Bedriftskunde
                    'legger inn i bedriftskunde tabellen
                    Dim cmd2 As New MySqlCommand("INSERT INTO K_bedriftt (Kunde_Kid, B_addresse, Post, Bedrift) VALUES (@Kunde_Kid, @B_addresse, @Post, @Bedrift)", con)

                    cmd2.Parameters.AddWithValue("@B_addresse", txtBedAdresse.Text)
                    cmd2.Parameters.AddWithValue("@Post", CInt(txtBedPnr.Text))
                    cmd2.Parameters.AddWithValue("@Bedrift", txtBedriftNavn.Text)
                    cmd2.Parameters.AddWithValue("@Kunde_Kid", CInt(KID))

                    cmd2.ExecuteNonQuery()

                Case Else
                    MsgBox("Du fikk en feil, men vi vet ikke hvor")
            End Select

            MsgBox("Registrering av kunde var vellykket")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Close()


        'sql.sporring("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)")
    End Sub
    'viser elementer tilhørende privatkunde registrering


    'Sjuler alle elementer før man har valgt hva som skal registreres

    Private Sub ComboBoxAdv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAdv1.SelectedIndexChanged
        Select Case ComboBoxAdv1.SelectedIndex
            Case = 0 'Privatkunde
                Me.Height = 391
                Me.Refresh()

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

            Case = 1 'Bedriftskunde
                Me.Height = 391
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
            Case Else
                MsgBox("")
        End Select
    End Sub

    'viser elementer tilhørende bedriftsregistrering
End Class
