Imports Syncfusion.Windows.Forms

Public Class frmAddUsrMetro
    Inherits MetroForm

    Dim Core As New frmAdminCore
    Dim SQL As New SQL

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        If txtPassord.Text = txtGjentaPassord.Text AndAlso InStr("@", txtEpost.Text) Then

            Core.regAnsatt(txtBrukernavn.Text,
                           txtPassord.Text,
                           txtFornavn.Text,
                           txtEtternavn.Text,
                           dtpBirth.Value.ToShortDateString,
                           txtEpost.Text, txtTlf.Text,
                           txtAdresse.Text,
                           cmbAvdeling.Text)


        Else

            MsgBox("Prøv igjen")

        End If
    End Sub

    Private Sub frmAddUsrMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = SQL.sporring("SELECT avd FROM Loggin")
        Dim dr As DataRow

        For Each dr In dt.Rows
            cmbAvdeling.Items.Add(dr("avd"))
        Next
    End Sub
End Class
