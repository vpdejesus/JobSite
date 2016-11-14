Imports System.Data
Imports JobSite.BusinessObjectLayer

Partial Class MyDashboard
    Inherits Page

    Protected Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim id As Integer = Profile.JobSeeker.JobSeekerID
        Dim ds As DataSet = MyJobApplication.GetMyJobApplications(id)

        gvJobsApplied.DataSource = ds
        gvJobsApplied.DataBind()

        If gvJobsApplied.Rows.Count <= 0 Then
            lblMsg.Text = "You don't have job application as of this time! You can browse jobs to apply."
        Else
            lblMsg.Text = ""
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("JobSeekerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        UpdateView()
    End Sub

    Protected Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
        Dim id As Integer = Profile.JobSeeker.JobSeekerID
        With odsMyResumeView
            .SelectParameters("id").DefaultValue = id.ToString
        End With

        gvCompany.DataBind()
        If gvCompany.Rows.Count <= 0 Then
            lblError.Text = "No companies have viewed your resume as of this time!"
        Else
            lblError.Text = ""
        End If
    End Sub

    Protected Sub gvCompany_RowDeleted(sender As Object, e As GridViewDeletedEventArgs) Handles gvCompany.RowDeleted
        If e.Exception IsNot Nothing Then
            lblError.Text = "A database error has occurred. " & e.Exception.Message
            e.ExceptionHandled = True
        ElseIf e.AffectedRows = 0 Then
            lblError.Text = "Another user may have updated that product. " & "Please try again."
        ElseIf e.AffectedRows = 1 Then
            UpdateView()
        End If
        UpdateView()
    End Sub

    Private Sub UpdateView()
        Dim views As String = MyResumeView.GetResumeViews(Profile.JobSeeker.JobSeekerID).ToString
        lblView.Text = "Your resume has been viewed" & " " & views & " " & "times."
    End Sub
End Class
