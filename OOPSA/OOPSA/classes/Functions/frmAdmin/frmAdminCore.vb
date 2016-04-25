Imports MySql.Data.MySqlClient
Imports OOPSA.SQL


Public Class frmAdminCore

    Dim SQL As New SQL

    Public Sub VisAnsatt()

        With My.Forms.frmAdminMetro.dgvAnsatte
            .Binder.InternalColumns(0).HeaderText = "ID"
            .Binder.InternalColumns(1).HeaderText = "Fornavn"
            .Binder.InternalColumns(2).HeaderText = "Etternavn"
            .Binder.InternalColumns(3).HeaderText = "Fødselsdato"
            .Binder.InternalColumns(4).HeaderText = "Epost"
            .Binder.InternalColumns(5).HeaderText = "Telefon"
            .Binder.InternalColumns(6).HeaderText = "Adresse"
            .Binder.InternalColumns(7).HeaderText = "Postnummer"
            .Binder.InternalColumns(7).HeaderText = "Avdeling"
        End With

    End Sub

    Public Sub visLeie()

        Dim sqlstring As String = "SELECT * FROM `VisLeie`"

        My.Forms.frmAdminMetro.GridDataBoundGrid1.DataSource = SQL.bindingsource(sqlstring)

        With My.Forms.frmAdminMetro.GridDataBoundGrid1
            .Binder.InternalColumns(0).HeaderText = "Leie ID"
            .Binder.InternalColumns(1).HeaderText = "Fra"
            .Binder.InternalColumns(2).HeaderText = "Til"
            .Binder.InternalColumns(3).HeaderText = "Utleier ID"
            .Binder.InternalColumns(4).HeaderText = "Kunde ID"
            .Binder.InternalColumns(5).HeaderText = "Produkt Navn"
            .Binder.InternalColumns(6).HeaderText = "Produkt ID"
        End With

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

        Dim SHA As New SHA512

        SQL.sporring("INSERT INTO logginn")
        SQL.sporring("INSERT INTO Ansatt")

    End Sub


    Public Sub regLeie(Produkt As Integer, Til As Date, Fra As Date, Kunde_nr As Integer, Lager As Integer, antall As Integer)


        Dim core As New UserCore
        Dim Ansatt_id As Integer = core.UID
        Dim lagerbeholdning As Integer = SQL.Return1Row("SELECT Antall FROM Lagerbeholdning WHERE Lager_id = " & Lager & " AND Produkt_id = " & Produkt & "", "Antall")


        If lagerbeholdning >= antall Then
            SQL.sporring("UPDATE Lagerbeholdning SET Antall = " & (lagerbeholdning - antall) & " WHERE Lager_id = " & Lager & " AND Produkt_id = " & Produkt & "")
            SQL.sporring("INSERT INTO `drift8_2016`.`Leie` (`Leie_id`, `Fra`, `Til`, `Ansatt_A_id`, `Kunde_Kid`, `Produkt_id`, `Lager_id`, `Antall`) VALUES (NULL, '" & Fra & "', '" & Til & "', '" & Ansatt_id & "', '" & Kunde_nr & "', '" & Produkt & "', '" & Lager & "', '" & antall & "' );", "Leiet er registrert")

        Else
            MsgBox("Det er ikke mer igjen av " & Produkt, MsgBoxStyle.Critical, "Ikke flere på lager")

        End If



    End Sub

End Class
