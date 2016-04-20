Imports MySql.Data.MySqlClient

Public Class SQL

    ''' <summary>
    ''' Spørringsfunksjonen, legger inn sql spørringen som en string,
    ''' kjører den gjennom SQLCMD og SQLDA fyller DataTable med informasjonen som ble hentet.
    ''' Gir også mulighet for å legge til informasjon i databasen.
    ''' Ble det ikke returnert noe, typ. en feil i SQL setningen vil det kjøres en 'Catch'
    ''' og en feilmelding vil vises med relevant informasjon.
    ''' </summary>
    ''' <param name="sql">SQL setning som string</param>
    ''' <returns>DT as New DataTable, Informasjon fra databasen</returns>

    Public Function sporring(ByVal sql As String, Optional vellykett As String = "") As DataTable
        Dim dt As New DataTable

        If con.State = ConnectionState.Closed Then

            con.Open()

        End If

        Try
            Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            con.Close()
            If Not vellykett = "" Then
                MsgBox(vellykett)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Spørring feilet")
            con.Close()
        Finally
            con.Dispose()
        End Try
        Return dt

    End Function

    ''' <summary>
    ''' Henter informasjon ut ifra SQL string og legger det inn i en DataTable
    ''' 
    ''' Brukbart for f.eks datagridviews og andre designitems som trenger datasource som bindingsource
    ''' </summary>
    ''' <param name="query">SQLsetning som string</param>
    ''' <returns>bsource as New Bindingsource</returns>
    Public Function bindingsource(query As String)

        Dim dataadapter As New MySqlDataAdapter()
        Dim cmd As New MySqlCommand(query, con)

        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim SDA As New MySqlDataAdapter

        Try
            dataadapter.SelectCommand = cmd



            SDA.SelectCommand = cmd
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset

            SDA.Update(dbdataset)
        Catch ex As Exception
            MsgBox("Feil ved spørring. " & ex.Message)
        End Try

        Return bsource
    End Function



    Public Function Return1Row(SQLstring As String, NavnPaKollone As String)

        Dim variabel As String

        Dim dt As DataTable
        Dim dr As DataRow

        'Try

        dt = sporring(SQLstring)

        dr = dt.Rows(0)
        'variabel = dt.Rows(0).ToString
        variabel = dr(NavnPaKollone).ToString
        MsgBox(variabel)
        'Catch ex As Exception

        'MsgBox(ex.Message)

        'End Try

        Return variabel

    End Function

    Public Function dataset(ByVal sql As String) As DataSet
        Dim ds As New DataSet

        If con.State = ConnectionState.Closed Then

            con.Open()

        End If

        Try
            Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(ds)

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Spørring feilet")
            con.Close()
        Finally
            con.Dispose()
        End Try
        Return ds

    End Function




End Class
