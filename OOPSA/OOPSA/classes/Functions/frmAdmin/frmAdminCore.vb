Imports MySql.Data.MySqlClient

Public Class frmAdminCore
    Public Sub VisAnsatt()
        Dim sqlstring As String = "SELECT A_id as 'ID', F_navn as 'Fornavn', E_navn as 'Etternavn', bursdag as 'Fødselsdato', e_postt as 'Epost', tlf as 'Telefon', Adresse as 'Adresse', Avdeling_id_Avdeling as 'Avdeling' FROM Ansatt"

        Dim dataadapter As New MySqlDataAdapter()
        Dim cmd As New MySqlCommand(sqlstring, con)



        dataadapter.SelectCommand = cmd

        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim SDA As New MySqlDataAdapter

        SDA.SelectCommand = cmd
        SDA.Fill(dbdataset)
        bsource.DataSource = dbdataset

        My.Forms.frmAdmin.GridDataBoundGrid1.DataSource = bsource

        SDA.Update(dbdataset)
    End Sub
End Class
