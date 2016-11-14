
Partial Class ChangePassword
    Inherits Page

    Protected Sub ChangePassword1_ContinueButtonClick(sender As Object, e As EventArgs) _
        Handles ChangePassword1.ContinueButtonClick
        Response.Redirect("~/Default.aspx")
    End Sub
End Class
