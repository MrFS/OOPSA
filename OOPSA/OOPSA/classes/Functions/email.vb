Imports System.Net.Mail

Imports MySql.Data.MySqlClient

Public Class email

    ''' <summary>
    ''' Gir daglig leder mulighet til å sende ut epost til alle som er registrert som kunde i databasen
    ''' 
    ''' Henter alle epostene som finnes i table "Kunde" fra DB
    ''' Legger de inn i DS_Kunde
    ''' 
    ''' DS_Kunde overføres til DT_Kunde
    ''' 
    ''' emailPW er en enkode string, må dekodes av class Base64Enc
    ''' 
    ''' value regnes ut som 100 / antall rader funnet i database table "Kunde"
    ''' Dette brukes for å inkrementere en progress bar i frmAdminMetro
    ''' 
    ''' Skriv om epostfunskjonaliteten her
    ''' </summary>
    Public Sub massEmail()
        Dim da_kunde = New MySqlDataAdapter("SELECT e_postt FROM Kunde", con)

        Dim ds_kunde As New DataSet
        Dim dr_kunde As DataRow
        Dim dt_kunde As DataTable

        Dim BASE64 As New Base64Enc
        Dim emailPW As String = "YmFkcjA4MTIzNDU2Nzg5"

        da_kunde.Fill(ds_kunde, "Kunder")

        dt_kunde = ds_kunde.Tables(0)

        BASE64.FrmBase64 = emailPW
        emailPW = BASE64.FrmBase64

        Dim sendt As Integer = 0

        Dim value As Integer = 100 / CInt(dt_kunde.Rows.Count.ToString)

        My.Forms.frmAdminMetro.StatusStripProgressBar1.Maximum = 100

        Try
            For Each dr_kunde In dt_kunde.Rows

                sendt += 1

                My.Forms.frmAdminMetro.StatusStripProgressBar1.Value += value

                My.Forms.frmAdminMetro.StatusStripLabel2.Text = "Antall eposter sendt: " & sendt & "/" & dt_kunde.Rows.Count.ToString

                My.Forms.frmAdminMetro.Refresh()


                Dim SMTP As New SmtpClient
                Dim msg As New MailMessage()

                SMTP.UseDefaultCredentials = 0
                SMTP.Credentials = New Net.NetworkCredential("drift82016@gmail.com", emailPW)
                SMTP.Port = 587
                SMTP.EnableSsl = 1
                SMTP.Host = "smtp.gmail.com"

                msg = New MailMessage()

                msg.From = New MailAddress("drift82016@gmail.com", "OOPSA TurCare AS")
                msg.To.Add(dr_kunde("e_postt"))
                'msg.To.Add("mrfs94@gmail.com")

                msg.Subject = My.Forms.frmAdminMetro.ToolStripTxtSubject.Text
                msg.IsBodyHtml = 1

                Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString("<html><header><img src=mrfs.me/school/oopsa/OOPSA.logoTurCareAS.png /></header>" & HTMLConvert(My.Forms.frmAdminMetro.rtbKundeEpost.Rtf), Nothing, "text/html")

                msg.AlternateViews.Add(htmlView)

                SMTP.Send(msg)


            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            Throw New Exception("Epost kunne ikke sendes.")
        End Try
    End Sub

    ''' <summary>
    ''' Implementerer WordFunskjonalitet, gjennom assembly Microsoft.Office.Core, brukes som en del av "massEmail"
    ''' Konverterer RTF-format(Som brukes i en RichTextBox control) ovber til HTML format, som endes som epost.
    ''' </summary>
    ''' <param name="RTF">Henter tekst i RTF format</param>
    ''' <returns>HTML formatert dokument</returns>
    ''' 
    Public Function HTMLConvert(ByVal RTF As String) As String
        'Declare a Word Application Object and a Word WdSaveOptions object
        Dim MyWord As Microsoft.Office.Interop.Word.Application
        Dim oDoNotSaveChanges As Object =
             Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges
        'Declare two strings to handle the data
        Dim sReturnString As String = ""
        Dim sConvertedString As String = ""
        Try
            'Instantiate the Word application,
            'Set visible To False And create a document
            MyWord = CreateObject("Word.application")
            MyWord.Visible = False
            MyWord.Documents.Add()
            'Create a DataObject to hold the Rich Text
            'and copy it to the clipboard
            Dim doRTF As New System.Windows.Forms.DataObject
            doRTF.SetData("Rich Text Format", RTF)
            Clipboard.SetDataObject(doRTF)
            'Paste the contents of the clipboard to the empty,
            'hidden Word Document
            MyWord.Windows(1).Selection.Paste()
            'â€¦then, select the entire contents of the document
            'and copy back to the clipboard
            MyWord.Windows(1).Selection.WholeStory()
            MyWord.Windows(1).Selection.Copy()
            'Now retrieve the HTML property of the DataObject
            'stored on the clipboard
            sConvertedString =
                 Clipboard.GetData(System.Windows.Forms.DataFormats.Html)
            'Remove some leading text that shows up in some instances
            '(like when you insert it into an email in Outlook
            sConvertedString =
                 sConvertedString.Substring(sConvertedString.IndexOf("<html"))
            'Also remove multiple Ã‚ characters that somehow end up in there
            sConvertedString = sConvertedString.Replace("Ã‚", "")
            'â€¦and you're done.
            sReturnString = sConvertedString
            If Not MyWord Is Nothing Then
                MyWord.Quit(oDoNotSaveChanges)
                MyWord = Nothing
            End If
        Catch ex As Exception
            If Not MyWord Is Nothing Then
                MyWord.Quit(oDoNotSaveChanges)
                MyWord = Nothing
            End If
            MsgBox("Error converting Email to HTML" & ex.Message)
        End Try
        Return sReturnString
    End Function

End Class
