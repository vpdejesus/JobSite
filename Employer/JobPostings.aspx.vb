
Partial Class JobPostings
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("EmployerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
    End Sub

    Protected Sub gvJobPostings_RowCommand(sender As Object, e As GridViewCommandEventArgs) _
        Handles gvJobPostings.RowCommand
        If e.CommandName = "edit" Then
            Response.Redirect("~/Employer/Posting.aspx?id=" + e.CommandArgument.ToString())
        End If
    End Sub

    Protected Sub gvJobPostings_RowDataBound(sender As Object, e As GridViewRowEventArgs) _
        Handles gvJobPostings.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim b = CType(e.Row.Cells(4).Controls(0), LinkButton)
            b.CommandName = "edit"
            b.CommandArgument = gvJobPostings.DataKeys(e.Row.RowIndex).Value.ToString
        End If
    End Sub
End Class
