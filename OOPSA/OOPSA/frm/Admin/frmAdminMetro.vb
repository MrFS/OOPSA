Imports Syncfusion.Windows.Forms

Imports System
Imports System.Windows


Imports Syncfusion
Imports Syncfusion.PivotAnalysis
Imports Syncfusion.PivotAnalysis.Base

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

''' <summary>
''' Dim variabel Core as New frmAdminCore (Classes/Functions/frmAdmin)
''' Gir tilgang til kjernefunksjonalitet
''' </summary>
Public Class frmAdminMetro
    Inherits MetroForm
    Dim Core As New frmAdminCore

    ''' <summary>
    ''' Viser frmAddUsr
    ''' Gir daglig leder mulighet til å legge til flere ansatte
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddUsr_Click(sender As Object, e As EventArgs)
        frmAddUsrMetro.Show()
    End Sub

    ''' <summary>
    ''' RYDDDDDDDD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAdminMetro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger' table. You can move, or remove it, as needed.
        Me.LagerRapportStavangerTableAdapter.Fill(Me.Drift8_2016DataSetLagerRapportStavnager.LagerRapportStavanger)
        Try
            Me.LagerRapportALLETableAdapter.Fill(Me.Drift8_2016DataSetLageroversiktALLE.LagerRapportALLE)
        Catch ex As Exception
        End Try

        'TODO: This line of code loads data into the 'Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim' table. You can move, or remove it, as needed.
        Me.LagerRapportTrondheimTableAdapter.Fill(Me.Drift8_2016DataSetTrondheimLager.LagerRapportTrondheim)
        'TODO: This line of code loads data into the 'drift8_2016DataSet.Kunde' table. You can move, or remove it, as needed.
        Me.KundeTableAdapter.Fill(Me.drift8_2016DataSet.Kunde)

        Me.SalgsRaportTableAdapter.Fill(Me.drift8_2016dsSalgsRapportView.SalgsRaport)

        'TODO: This line of code loads data into the 'drift8_2016DataSet.Ansatt' table. You can move, or remove it, as needed.
        Me.AnsattTableAdapter.Fill(Me.drift8_2016DataSet.Ansatt)
        Core.VisAnsatt()
        Core.visLeie()


        'Legg dt her i en class




        '-------------------------------------
        txtServer.Text = My.Settings.server
        txtSvrDB.Text = My.Settings.database
        TxtSvrUser.Text = My.Settings.user
        txtSvrPass.Text = My.Settings.pass
        txtSvrPassRep.Text = ""

        txtServer.Enabled = 0
        txtSvrDB.Enabled = 0
        TxtSvrUser.Enabled = 0
        txtSvrPass.Enabled = 0
        txtSvrPassRep.Enabled = 0

        txtSvrPassRep.Visible = 0


        For Each var As Object In Me.FontListBox1.Items
            txtFontCombo.Items.Add(var)
        Next

        Me.richTextBox1.Font = New Font(Me.richTextBox1.Font.Name, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub txtAlignLeft_Click(sender As Object, e As EventArgs) Handles txtAlignLeft.Click
        richTextBox1.SelectionAlignment = Forms.HorizontalAlignment.Left
    End Sub

    Private Sub txtAlignJust_Click(sender As Object, e As EventArgs) Handles txtAlignJust.Click
        richTextBox1.SelectionAlignment = Forms.HorizontalAlignment.Center
    End Sub

    Private Sub txtAlignRight_Click(sender As Object, e As EventArgs) Handles txtAlignRight.Click
        richTextBox1.SelectionAlignment = Forms.HorizontalAlignment.Right
    End Sub

    Private Sub txtFontCombo_DropDownClosed(sender As Object, e As EventArgs) Handles txtFontCombo.DropDownClosed

        If Me.richTextBox1.SelectedText = "" Then
            richTextBox1.Font = New Font(txtFontCombo.Text, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        Else
            richTextBox1.SelectionFont = New Font(txtFontCombo.Text, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        End If

    End Sub
    Private Sub txtFontSizeCombo_DropDownClosed(sender As Object, e As EventArgs) Handles txtFontSizeCombo.DropDownClosed
        If Me.richTextBox1.SelectedText = "" Then
            Me.richTextBox1.Font = New Font(Me.richTextBox1.Font.Name, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        Else
            richTextBox1.SelectionFont = New Font(Me.richTextBox1.Font.Name, CInt(txtFontSizeCombo.Text), Me.richTextBox1.Font.Style)
        End If
    End Sub

    Private Sub richTextBox1_TextChanged(sender As Object, e As EventArgs) Handles richTextBox1.TextChanged
        Me.txtUndo.Enabled = Me.richTextBox1.CanUndo
        Me.txtRedo.Enabled = Me.richTextBox1.CanRedo
    End Sub

    Private Sub txtUndo_Click(sender As Object, e As EventArgs) Handles txtUndo.Click
        Me.richTextBox1.Undo()
    End Sub

    Private Sub txtRedo_Click(sender As Object, e As EventArgs) Handles txtRedo.Click
        Me.richTextBox1.Redo()
    End Sub

    Private Sub txtInsertImg_Click(sender As Object, e As EventArgs) Handles txtInsertImg.Click

        Dim ofd As New OpenFileDialog

        ofd.ShowDialog()

        Dim lstrFile As String = ofd.FileName

        Dim img As New Bitmap(lstrFile)

        System.Windows.Clipboard.SetDataObject(img)

        Dim imgformat As Forms.DataFormats.Format = Forms.DataFormats.GetFormat(Forms.DataFormats.Bitmap)



        If Me.richTextBox1.CanPaste(imgformat) Then
            richTextBox1.Paste(imgformat)
        Else
            MsgBox("Feil format")
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If richTextBox1.Text IsNot Nothing Then
            'Save before proceeding
            MsgBox("Save before creating a new document?", MsgBoxStyle.YesNo, "Save masterpiece?")

            If MsgBoxResult.Ok Then
                Dim sfd As New SaveFileDialog
                sfd.Filter = "Penis Files (*.kuk) |*.kuk"

                If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    richTextBox1.SaveFile(sfd.FileName)
                End If

            ElseIf MsgBoxResult.No Then
                richTextBox1.Clear()
            End If




        Else

            richTextBox1.Clear()



        End If
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        Dim print As New PrintPreviewDialog

        print.ShowDialog()

    End Sub

    Private Sub tsBtnDBInfo_Click(sender As Object, e As EventArgs) Handles tsBtnDBInfo.Click
        Select Case tsBtnDBInfo.Text
            Case "Change Database Information"

                txtServer.Enabled = 1
                txtSvrDB.Enabled = 1
                TxtSvrUser.Enabled = 1
                txtSvrPass.Enabled = 1
                txtSvrPassRep.Enabled = 1

                txtSvrPassRep.Visible = 1

                tsBtnDBInfo.Text = "Save Database Information"

            Case "Save Database Information"

                txtServer.Enabled = 0
                txtSvrDB.Enabled = 0
                TxtSvrUser.Enabled = 0
                txtSvrPass.Enabled = 0
                txtSvrPassRep.Enabled = 0

                txtSvrPassRep.Visible = 0

                tsBtnDBInfo.Text = "Change Database Information"

        End Select
    End Sub

    Private Sub ButtonLeggTilLeie_Click(sender As Object, e As EventArgs) Handles ButtonLeggTilLeie.Click
        frmAddLeie.Show()
    End Sub

    Private Sub FrmLagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrmLagerToolStripMenuItem.Click
        Me.Hide()
        frmLager.Show()
    End Sub

    Private Sub FrmSalgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrmSalgToolStripMenuItem.Click
        Me.Hide()
        frmSalg.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub btnChngPW_Click(sender As Object, e As EventArgs)
        frmUsrChngPW.Show()
    End Sub

    Private Sub SalgsrapportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalgsrapportToolStripMenuItem.Click
        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "OOPSA.SalgsRapport.rdlc"
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub DagligeSalgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DagligeSalgToolStripMenuItem.Click
        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "OOPSA.SalgsRapportChart.rdlc"


        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnSendEpostKunde_Click(sender As Object, e As EventArgs) Handles btnSendEpostKunde.Click

        Dim Send As New email



        'Dim t As New Threading.Thread(AddressOf MySub)
        't.IsBackground = True
        't.SetApartmentState(0)
        't.Start()

        'Dim Send As New email

        Send.massEmail()

    End Sub

    Private Sub FakturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FakturaToolStripMenuItem.Click
        ' Create an OpenFileDialog to request a file to open.
        Dim openFile1 As New OpenFileDialog()

        ' Initialize the OpenFileDialog to look for RTF files.
        openFile1.DefaultExt = "*.rtf"
        openFile1.Filter = "RTF Files|*.rtf"

        ' Determine whether the user selected a file from the OpenFileDialog.
        If (openFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (openFile1.FileName.Length > 0) Then

            ' Load the contents of the file into the RichTextBox.
            rtbKundeEpost.LoadFile(openFile1.FileName)
        End If
    End Sub

    Private Sub btnAnsattUpdate_Click(sender As Object, e As EventArgs) Handles btnAnsattUpdate.Click
        Me.AnsattTableAdapter.Update(drift8_2016DataSet.Ansatt)
    End Sub

    Private Sub TabLager_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabLager.SelectedIndexChanged

    End Sub

    Private Sub btnAddKunde_Click(sender As Object, e As EventArgs) Handles btnAddKunde.Click
        frmAddKunde1.Show()
    End Sub

    '<STAThread>
    'Public Sub MySub()

    '    Dim Send As New email

    '    Dim converted As String

    '    converted = Send.HTMLConvert(rtbKundeEpost.Text)

    '    Send.massEmail(converted)
    'End Sub

End Class
