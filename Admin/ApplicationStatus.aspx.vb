
Partial Class AdminApplicationStatus
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If dvStatus.Rows.Count < 1 Then
            dvStatus.DefaultMode = DetailsViewMode.Insert
        Else
            dvStatus.DefaultMode = DetailsViewMode.ReadOnly
        End If
    End Sub
End Class
