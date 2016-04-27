Imports Syncfusion.Windows.Forms
Imports System.Text.RegularExpressions

Public Class frmAddUsrMetro
    Inherits MetroForm

    Dim Core As New frmAdminCore
    Dim SQL As New SQL

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Initialize()

    End Sub
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click



        If txtPassord.Text = txtGjentaPassord.Text AndAlso Core.GyldigEpost(txtEpost.Text) Then

            Core.regAnsatt(txtBrukernavn.Text,
                           txtPassord.Text,
                           txtFornavn.Text,
                           txtEtternavn.Text,
                           dtpBirth.Value.ToShortDateString,
                           txtEpost.Text, txtTlf.Text,
                           txtAdresse.Text,
                           txtIntPostNr.Text,
                           cmbAvdeling.Text)


        Else

            MsgBox("Prøv igjen")

        End If
    End Sub

End Class
