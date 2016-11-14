
Partial Class AdminStateManager
    Inherits Page

    Protected Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        dvState.DataBind()
    End Sub

    Protected Sub dvState_PageIndexChanging(sender As Object, e As DetailsViewPageEventArgs) _
        Handles dvState.PageIndexChanging
        dvState.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("AdminRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If dvState.Rows.Count < 1 Then
            dvState.DefaultMode = DetailsViewMode.Insert
        Else
            dvState.DefaultMode = DetailsViewMode.ReadOnly
        End If
    End Sub
End Class
