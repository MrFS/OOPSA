Imports MySql.Data.MySqlClient
Imports OOPSA.SQL
Public Class frmAnsattCore
    Dim SQL As New SQL


    ''' <summary>
    ''' FrmLager
    ''' </summary>
    Public Sub oppdater() ' Procedure for updating and clearing upon submission of information

        My.Forms.frmLagerMetro.NavnLeggTil.Clear()
        My.Forms.frmLagerMetro.AntLeggTil.Clear()
        My.Forms.frmLagerMetro.PrisLeggTil.Clear()
        My.Forms.frmLagerMetro.LagerLeggTil.Items.Clear()

        My.Forms.frmLagerMetro.antEndreText.Clear()
        My.Forms.frmLagerMetro.navnEndreText.Clear()
        My.Forms.frmLagerMetro.prisEndreText.Clear()

        My.Forms.frmLagerMetro.VareEndre.Text = ""
        My.Forms.frmLagerMetro.lagerEndre.Text = ""
        My.Forms.frmLagerMetro.vareSlett.Text = ""

        My.Forms.frmLagerMetro.VareEndre.Items.Clear()
        My.Forms.frmLagerMetro.lagerEndre.Items.Clear()

        My.Forms.frmLagerMetro.vareSlett.Items.Clear()

        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM Lager", con)  ' Fills comboboxes with city names
        Dim ds2 = New DataSet
        Dim dr2 As DataRow
        Dim dt2 As DataTable
        adapter2.Fill(ds2, "Lager")
        dt2 = ds2.Tables(0)
        For Each dr2 In dt2.Rows
            My.Forms.frmLagerMetro.LagerLeggTil.Items.Add(dr2("by"))
            My.Forms.frmLagerMetro.lagerEndre.Items.Add(dr2("by"))
        Next

        Dim adapter As New MySqlDataAdapter("SELECT * FROM Produkt", con) ' Fills comboboxes with product names
        Dim ds = New DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        adapter.Fill(ds, "Produkt")
        dt = ds.Tables(0)
        For Each dr In dt.Rows
            My.Forms.frmLagerMetro.VareEndre.Items.Add(dr("Produkt_navn"))
            My.Forms.frmLagerMetro.vareSlett.Items.Add(dr("Produkt_navn"))
        Next

        My.Forms.frmLagerMetro.GridDataBoundGrid1.Refresh() ' Updates datagrids
        My.Forms.frmLagerMetro.GridDataBoundGrid2.Refresh()
        My.Forms.frmLagerMetro.GridDataBoundGrid3.Refresh()
    End Sub
End Class
