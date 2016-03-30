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

        Dim value As Integer = 100 / dt_kunde.Rows.ToString

        My.Forms.frmAdminMetro.StatusStripProgressBar1.Maximum = 100

        For Each dr_kunde In dt_kunde.Rows

            My.Forms.frmAdminMetro.StatusStripProgressBar1.Value += value

            My.Forms.frmAdminMetro.Refresh()

            MsgBox(dr_kunde("e_postt"))

            'Try
            '    Dim SMTP As New SmtpClient
            '    Dim msg As New MailMessage()

            '    SMTP.UseDefaultCredentials = 0
            '    SMTP.Credentials = New Net.NetworkCredential("drift82016@gmail.com", "badr08123456789")
            '    SMTP.Port = 587
            '    SMTP.EnableSsl = 1
            '    SMTP.Host = "smtp.gmail.com"

            '    msg = New MailMessage()

            '    msg.From = New MailAddress("drift82016@gmail.com", "OOPSA TurCare AS")
            '    msg.To.Add(dr_kunde("e_postt"))
            '    msg.Subject = My.Forms.frmAdminMetro.ToolStripTxtSubject.Text
            '    msg.IsBodyHtml = 0
            '    msg.Body = My.Forms.frmAdminMetro.rtbKundeEpost.Text

            '    SMTP.Send(msg)

            '    MsgBox("finito")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
        Next

    End Sub
End Class
