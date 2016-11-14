
Partial Class AdminCountryManager
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If dvCountry.Rows.Count < 1 Then
            dvCountry.DefaultMode = DetailsViewMode.Insert
        Else
            dvCountry.DefaultMode = DetailsViewMode.ReadOnly
        End If
    End Sub
End Class
