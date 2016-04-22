Imports Syncfusion.Windows.Forms

Imports MySql.Data.MySqlClient

Public Class frmUsrChngPW
    Inherits MetroForm

    Dim SQL As New SQL
    Dim SHA As New SHA512


    Dim fNavn As String
    Dim eNavn As String

    Private Sub frmUsrChngPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNewPw.UseSystemPasswordChar = True
        txtOldPw.UseSystemPasswordChar = True
        txtRepNewPw.UseSystemPasswordChar = True

        txtMail.Enabled = 0

        Dim da As New MySqlDataAdapter("SELECT A_id, F_navn, E_navn FROM Ansatt", con)

        Dim dr As DataRow
        Dim ds As New DataSet
        Dim dt As DataTable

        'Fill dataset

        da.Fill(ds, "Ansatt")

        dt = ds.Tables(0)

        For Each dr In dt.Rows
            Dim ansatt As String = dr("F_Navn") & " " & dr("E_navn")

            cmbAnsatte.Items.Add(ansatt)
        Next
    End Sub

    Private Sub chkViewPW_CheckedChanged(sender As Object, e As EventArgs) Handles chkViewPW.CheckedChanged
        Select Case chkViewPW.Checked
            Case 1
                txtNewPw.UseSystemPasswordChar = False
                txtOldPw.UseSystemPasswordChar = False
                txtRepNewPw.UseSystemPasswordChar = False
            Case 0
                txtNewPw.UseSystemPasswordChar = True
                txtOldPw.UseSystemPasswordChar = True
                txtRepNewPw.UseSystemPasswordChar = True
        End Select
    End Sub

    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click
        'Sjekke om gammelt passord stemmer med dt i databasen

        Dim OldPWHash As String

        SHA.ToHashSHA512 = txtOldPw.Text

        OldPWHash = SHA.ToHashSHA512

        Dim dt As DataTable

        Try
            dt = SQL.sporring("SELECT Passord, mail FROM Loggin WHERE Passord = '" & OldPWHash & "' AND mail = '" & txtMail.Text & "'")

            If dt.Rows.Count > 0 AndAlso txtNewPw.Text = txtRepNewPw.Text Then

                Dim PwNew As String = txtNewPw.Text

                SHA.ToHashSHA512 = PwNew

                PwNew = SHA.ToHashSHA512

                SQL.sporring("UPDATE `Loggin` SET `Passord`= '" & PwNew & "' WHERE mail = '" & txtMail.Text & "'")

                MsgBox("Ansatt " & cmbAnsatte.Text & "oppdatert.")

            Else
                MsgBox("Prøv igjen")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbAnsatte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnsatte.SelectedIndexChanged

        Dim navn() As String

        Dim dt As DataTable

        navn = cmbAnsatte.Text.Split(" ")

        dt = SQL.sporring("SELECT e_postt FROM Ansatt WHERE F_navn = '" & navn(0) & "' AND E_navn = '" & navn(1) & "'")

        txtMail.Text = dt.Rows(0).Item(0).ToString


    End Sub
End Class
