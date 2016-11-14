
Partial Class AdminJobCategoryManager
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If dvCategory.Rows.Count < 1 Then
            dvCategory.DefaultMode = DetailsViewMode.Insert
        Else
            dvCategory.DefaultMode = DetailsViewMode.ReadOnly
        End If
    End Sub
End Class
