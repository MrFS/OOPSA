Imports MySql.Data.MySqlClient
Imports OOPSA.SQL

Public Class frmAdminCore

    Dim SQL As New SQL

    Public Sub VisAnsatt()

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

        My.Forms.frmAdminMetro.dgvAnsatte.DataSource = bsource

        With My.Forms.frmAdminMetro.dgvAnsatte
            .Binder.InternalColumns(0).HeaderText = "ID"
            .Binder.InternalColumns(1).HeaderText = "Fornavn"
            .Binder.InternalColumns(2).HeaderText = "Etternavn"
            .Binder.InternalColumns(3).HeaderText = "Fødselsdato"
            .Binder.InternalColumns(4).HeaderText = "Epost"
            .Binder.InternalColumns(5).HeaderText = "Telefon"
            .Binder.InternalColumns(6).HeaderText = "Adresse"
            .Binder.InternalColumns(7).HeaderText = "Avdeling"
        End With

        SDA.Update(dbdataset)
    End Sub

    Public Sub visLeie()

        Dim sqlstring As String = "SELECT Leie_id, fra, til, Ansatt_A_id, Kunde_Kid, Produkt_navn, Produkt.Produkt_id
FROM Leie
LEFT OUTER JOIN Produkt
ON Leie.Produkt_id=Produkt.Produkt_id"
        Dim dataadapter As New MySqlDataAdapter()
        Dim cmd As New MySqlCommand(sqlstring, con)  'Takk takk FS


        dataadapter.SelectCommand = cmd

        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim SDA As New MySqlDataAdapter

        SDA.SelectCommand = cmd
        SDA.Fill(dbdataset)
        bsource.DataSource = dbdataset 'Takk takk FS


        My.Forms.frmAdminMetro.GridDataBoundGrid1.DataSource = bsource

        With My.Forms.frmAdminMetro.GridDataBoundGrid1
            .Binder.InternalColumns(0).HeaderText = "Leie ID"
            .Binder.InternalColumns(1).HeaderText = "Fra"
            .Binder.InternalColumns(2).HeaderText = "Til"
            .Binder.InternalColumns(3).HeaderText = "Utleier ID"
            .Binder.InternalColumns(4).HeaderText = "Kunde ID"
            .Binder.InternalColumns(5).HeaderText = "Produkt Navn"
            .Binder.InternalColumns(6).HeaderText = "Produkt ID"
        End With


        SDA.Update(dbdataset)

    End Sub

    ''' <summary>
    ''' Prosedyre for registrering av ny ansatt
    ''' </summary>
    ''' <param name="bruker">Brukernavnet</param>
    ''' <param name="pw">Passordet</param>
    ''' <param name="fornavn">Fornavnet til ansatt</param>
    ''' <param name="etternavn">Etternavnet til ansatt</param>
    ''' <param name="bursdag">Bursdagen til ansatt, DATE</param>
    ''' <param name="epost">Epost til ansatt</param>
    ''' <param name="tlf">Telefonnummer til ansatt, integer</param>
    ''' <param name="adresse">Adressen til ansatt</param>
    ''' <param name="avdeling">Avdelingen ansatt tilhører, INTEGER</param>'

    Public Sub regAnsatt(bruker As String,
                         pw As String,
                         fornavn As String,
                         etternavn As String,
                         bursdag As Date,
                         epost As String,
                         tlf As Integer,
                         adresse As String,
                         avdeling As Integer)

        SQL.sporring("INSERT INTO logginn")
        SQL.sporring("INSERT INTO Ansatt")

    End Sub


    Public Sub regLeie(Produkt As String,
                       Til As Date,
                       Fra As Date,
                       Kunde As String)





        SQL.sporring("INSERT INTO Leie")
    End Sub



End Class
