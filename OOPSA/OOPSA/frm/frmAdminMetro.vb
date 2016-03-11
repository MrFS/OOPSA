Imports Syncfusion.Windows.Forms

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

Public Class frmAdminMetro
    Inherits MetroForm
    Dim Core As New frmAdminCore

    Private Sub btnAddUsr_Click(sender As Object, e As EventArgs) Handles btnAddUsr.Click
        frmAddUsrMetro.Show()
    End Sub

    Private Sub frmAdminMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Core.VisAnsatt()
        Core.visLeie()


        For Each var As Object In Me.FontListBox1.Items
            txtFontCombo.Items.Add(var)
        Next
    End Sub

    Private Sub txtAlignLeft_Click(sender As Object, e As EventArgs) Handles txtAlignLeft.Click
        richTextBox1.SelectionAlignment = Windows.Forms.HorizontalAlignment.Left
    End Sub

    Private Sub txtAlignJust_Click(sender As Object, e As EventArgs) Handles txtAlignJust.Click
        richTextBox1.SelectionAlignment = Windows.Forms.HorizontalAlignment.Center
    End Sub

    Private Sub txtAlignRight_Click(sender As Object, e As EventArgs) Handles txtAlignRight.Click
        richTextBox1.SelectionAlignment = Windows.Forms.HorizontalAlignment.Right
    End Sub

    Private Sub txtFontCombo_DropDownClosed(sender As Object, e As EventArgs) Handles txtFontCombo.DropDownClosed

        If richTextBox1.SelectionFont IsNot Nothing Then
            richTextBox1.Font = New Font(txtFontCombo.Text, CInt(txtFontSizeCombo.Text), FontStyle.Regular)
        End If


    End Sub
End Class
