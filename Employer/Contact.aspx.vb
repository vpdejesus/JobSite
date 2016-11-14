Imports System.Drawing
Imports System.Net.Mail

Partial Class EmployerContact
    Inherits Page

    Protected Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
        'Create the mail message
        Dim mail As New MailMessage()
        Try
            'Set the addresses
            mail.From = New MailAddress(txtEmailFrom.Text)
            mail.To.Add(txtEmailTo.Text)
            'Set the content
            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text
            'Checking for empty fiels
            If IsDBNull(txtEmailFrom.Text) Then
                lblMess.Text = "Your email should not be left blank!"
            Else
                If IsDBNull(txtSubject.Text) Then
                    lblMess.Text = "Your Subject should not be left blank!"
                Else
                    If IsDBNull(txtBody.Text) Then
                        lblMess.Text = "Your Message should not be left blank!"
                    End If
                End If
            End If
            'Send the message
            Dim smtp As New SmtpClient()
            smtp.Host = "mail.worldstopjobs.com"
            smtp.Send(mail)
            lblMess.Text = "Mail sent successfully!!"

            With Session
                .Remove("Email")
            End With

        Catch ex As Exception
            lblMess.Text = ex.Message
            lblMess.ForeColor = Color.Red
        End Try
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("EmployerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If

        txtEmailTo.Text = Session("Email")
        txtEmailFrom.Text = Profile.Email
    End Sub

    Protected Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Try
            txtEmailFrom.Text = ""
            txtEmailTo.Text = ""
            txtSubject.Text = ""
            txtBody.Text = ""
            lblMess.Text = ""
        Catch ex As Exception
            lblMess.Text = ex.Message
            lblMess.ForeColor = Color.Red
        End Try
    End Sub
End Class
