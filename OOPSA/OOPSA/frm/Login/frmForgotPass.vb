Imports Syncfusion.Windows.Forms
Imports System.Net.Mail
Imports System.Text

Public Class frmForgotPass
    Inherits MetroForm

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click

        Dim newPass As String

        Dim SHA As New SHA512

        Try
            Dim SMTP As New SmtpClient
            Dim msg As New MailMessage()

            SMTP.UseDefaultCredentials = 0
            SMTP.Credentials = New Net.NetworkCredential("drift82016@gmail.com", "badr08123456789")
            SMTP.Port = 587
            SMTP.EnableSsl = 1
            SMTP.Host = "smtp.gmail.com"

            Dim rnd As New Random()

            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!#¤%&/()=)@£$€{[]}?"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 8
                Dim idx As Integer = r.Next(0, 80)
                sb.Append(s.Substring(idx, 1))
            Next

            newPass = sb.ToString

            msg = New MailMessage()

            msg.From = New MailAddress("drift82016@gmail.com", "OOPSA TurCare AS")
            msg.To.Add(TextBoxExt1.Text)
            msg.Subject = "OOPSA TurCare AS Password Request"
            msg.IsBodyHtml = 0
            msg.Body = ("
                    You have requested an password reset through OOPSA TurCare AS.
                    This applies to " & user & " , if you believe this is wrong please contact
                    your superiors.

                    Your'e new password is " & newPass & "

                    OOPSA Team
                    Joachim F. Stamnes - Stig K. Rothaug - Martin Gabrielsen - Jakob Vagle
                    ")

            SMTP.Send(msg)

            SHA.ToHashSHA512 = newPass

            newPass = SHA.ToHashSHA512

            Dim SQL As New SQL

            SQL.sporring("UPDATE Loggin SET Passord = '" & newPass & "' WHERE mail = '" & TextBoxExt1.Text & "'")

            MsgBox("finito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
