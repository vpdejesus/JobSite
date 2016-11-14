
Partial Class EducationLevelsManager
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If dvEducationLevel.Rows.Count < 1 Then
            dvEducationLevel.DefaultMode = DetailsViewMode.Insert
        Else
            dvEducationLevel.DefaultMode = DetailsViewMode.ReadOnly
        End If
    End Sub
End Class
