Imports Syncfusion.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmAddKunde
    Inherits MetroForm
    Dim sql As New SQL


    Private Sub btnFerdigLeie_Click(sender As Object, e As EventArgs) Handles btnFerdigLeie.Click
        Try

            Dim cmd As New MySqlCommand("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)", con)

            cmd.Parameters.AddWithValue("@F_navn", txtKundeFnavn.Text)
            cmd.Parameters.AddWithValue("@E_navn", txtKundeEnavn.Text)
            cmd.Parameters.AddWithValue("@epostt", txtKundeEpost.Text)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'sql.sporring("INSERT INTO Kunde (F_navn, E_navn, e_postt) VALUES (@F_navn, @E_navn, @epostt)")
    End Sub
End Class
