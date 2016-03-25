Imports Syncfusion.Windows.Forms

Imports MySql.Data.MySqlClient

Public Class frmUsrChngPW
    Inherits MetroForm





    Private Sub frmUsrChngPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNewPw.UseSystemPasswordChar = True
        txtOldPw.UseSystemPasswordChar = True
        txtRepNewPw.UseSystemPasswordChar = True

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

        Dim dadapter As New MySqlDataAdapter("SELECT e_postt FROM Ansatt WHERE ", con)



    End Sub
End Class
