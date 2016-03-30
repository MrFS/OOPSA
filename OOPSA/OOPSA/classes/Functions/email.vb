Imports System.Net.Mail

Imports MySql.Data.MySqlClient

Public Class email

    Public Sub massEmail()
        Dim da_kunde = New MySqlDataAdapter("SELECT e_postt FROM Kunde", con)

        Dim ds_kunde As New DataSet
        Dim dr_kunde As DataRow
        Dim dt_kunde As DataTable

        da_kunde.Fill(ds_kunde, "Kunder")

        dt_kunde = ds_kunde.Tables(0)

        Dim sendt As Integer = 0

        Dim value As Integer = 100 / CInt(dt_kunde.Rows.Count.ToString)

        My.Forms.frmAdminMetro.StatusStripProgressBar1.Maximum = 100

        'For Each dr_kunde In dt_kunde.Rows

        sendt += 1

        My.Forms.frmAdminMetro.StatusStripProgressBar1.Value += value

        My.Forms.frmAdminMetro.StatusStripLabel2.Text = "Antall eposter sendt: " & sendt & "/" & dt_kunde.Rows.Count.ToString

        My.Forms.frmAdminMetro.Refresh()

        Try
            Dim SMTP As New SmtpClient
            Dim msg As New MailMessage()

            SMTP.UseDefaultCredentials = 0
            SMTP.Credentials = New Net.NetworkCredential("drift82016@gmail.com", "badr08123456789")
            SMTP.Port = 587
            SMTP.EnableSsl = 1
            SMTP.Host = "smtp.gmail.com"

            msg = New MailMessage()

            msg.From = New MailAddress("drift82016@gmail.com", "OOPSA TurCare AS")
            'msg.To.Add(dr_kunde("e_postt"))
            msg.To.Add("mrfs94@gmail.com")

            msg.Subject = My.Forms.frmAdminMetro.ToolStripTxtSubject.Text
            msg.IsBodyHtml = 1

            'Legg bildet på mrfs.me iosteden

            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString("<html><header><img src=mrfs.me/school/oopsa/OOPSA.logoTurCareAS.png /></header>< /br>" & sRTF_To_HTML(My.Forms.frmAdminMetro.rtbKundeEpost.Rtf), Nothing, "text/html")
            'Add image to HTML version
            'Dim imageResource As New LinkedResource("OOPSA.logoTurCareAS.png", "image/png")
            'imageResource.ContentId = "HDIImage"
            'htmlView.LinkedResources.Add(imageResource)

            msg.AlternateViews.Add(htmlView)
            'msg.Body = sRTF_To_HTML(My.Forms.frmAdminMetro.rtbKundeEpost.Rtf)

            'msg.Body = My.Forms.frmAdminMetro.rtbKundeEpost.Text
            'msg.Body = sRTF_To_HTML(My.Forms.frmAdminMetro.rtbKundeEpost.Rtf)
            'msg.Body = My.Forms.frmAdminMetro.rtbKundeEpost.Rtf

            'msg.BodyEncoding = System.Text.Encoding.Unicode
            SMTP.Send(msg)

            MsgBox("finito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Next

    End Sub

    Public Function sRTF_To_HTML(ByVal sRTF As String) As String
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
            doRTF.SetData("Rich Text Format", sRTF)
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
            MsgBox("Error converting Rich Text to HTML")
        End Try
        Return sReturnString
    End Function

End Class
