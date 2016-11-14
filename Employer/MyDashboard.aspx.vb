
Partial Class MyDashBoard
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("EmployerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
    End Sub

    Protected Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim id As Integer = Profile.Employer.CompanyID
        With odsApplicants
            .SelectParameters("id").DefaultValue = id.ToString
        End With

        gvApplicants.DataBind()
        If gvApplicants.Rows.Count <= 0 Then
            lblMsg.Text = "You don't have applicants for your job post as of this time! You can browse resumes to hire."
        Else
            lblMsg.Text = ""
        End If
    End Sub

    Protected Sub gvApplicants_RowDeleted(sender As Object, e As GridViewDeletedEventArgs) _
        Handles gvApplicants.RowDeleted
        If e.Exception IsNot Nothing Then
            lblMsg.Text = "A database error has occurred. " & e.Exception.Message
            e.ExceptionHandled = True
        ElseIf e.AffectedRows = 0 Then
            lblMsg.Text = "Another user may have updated that product. " & "Please try again."
        End If
    End Sub

    Protected Sub gvApplicants_RowUpdated(sender As Object, e As GridViewUpdatedEventArgs) _
        Handles gvApplicants.RowUpdated
        If e.Exception IsNot Nothing Then
            lblMsg.Text = "A database error has occurred. " & e.Exception.Message
            e.ExceptionHandled = True
        ElseIf e.AffectedRows = 0 Then
            lblMsg.Text = "Another user may have updated that product. " & "Please try again."
        End If
    End Sub

    Protected Sub gvApplicants_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) _
        Handles gvApplicants.RowUpdating
        For Each row As GridViewRow In gvApplicants.Rows
            Dim ddlText As String = CType(row.FindControl("ddlStatus"), DropDownList).SelectedItem.Value
            e.NewValues("AppStatusID") = ddlText
        Next
    End Sub
End Class
