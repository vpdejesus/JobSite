
Partial Class [Default]
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/Admin/Default.aspx")
        End If
    End Sub
End Class