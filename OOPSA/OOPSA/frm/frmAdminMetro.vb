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
            ToolStripComboBoxEx1.Items.Add(var)
        Next
    End Sub
End Class
