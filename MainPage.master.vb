

Partial Class MainPage
    Inherits MasterPage

    Protected Sub LoginStatus1_LoggedOut(sender As Object, e As EventArgs) Handles LoginStatus1.LoggedOut
        Response.Redirect("~/Default.aspx")
    End Sub
End Class

