Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DBConnect As New DBConnect
        Dim SQL As New SQL

        Dim sqlstring As String = "SELECT * FROM Ansatt"

        Dim dataadapter As New MySqlDataAdapter()
        Dim cmd As New MySqlCommand(sqlstring, con)



        dataadapter.SelectCommand = cmd

        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim SDA As New MySqlDataAdapter

        SDA.SelectCommand = cmd
        SDA.Fill(dbdataset)
        bsource.DataSource = dbdataset

        GridDataBoundGrid1.DataSource = bsource
        SDA.Update(dbdataset)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Base64 As Base64Enc

        Base64 = New Base64Enc()

        Base64.ToBase64 = TextBox1.Text

        TextBox1.Text = Base64.ToBase64



    End Sub
End Class