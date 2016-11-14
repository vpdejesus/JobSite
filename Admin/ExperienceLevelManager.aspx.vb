
Partial Public Class ExperienceLevelManagerAspx
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If dvExperienceLevel.Rows.Count < 1 Then
            dvExperienceLevel.DefaultMode = DetailsViewMode.Insert
        Else
            dvExperienceLevel.DefaultMode = DetailsViewMode.ReadOnly
        End If
    End Sub
End Class