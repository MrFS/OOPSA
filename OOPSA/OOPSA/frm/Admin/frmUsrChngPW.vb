Imports Syncfusion.Windows.Forms

Imports MySql.Data.MySqlClient

Public Class frmUsrChngPW
    Inherits MetroForm

    Private Sub frmUsrChngPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As New MySqlDataAdapter("SELECT F_navn, E_navn FROM Ansatt", con)

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
End Class
