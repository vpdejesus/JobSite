Imports AjaxControlToolkit

Partial Class LatestJobs
    Inherits UserControl

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If gvLatestJobs.Rows.Count = 0 Then
            Panel1.Visible = False
        End If
    End Sub

    Protected Sub gvLatestJobs_RowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim popup = CType(e.Row.FindControl("PopupControlExtender1"), PopupControlExtender)
            popup.DynamicServicePath = "~/webservice.asmx"
        End If
    End Sub
End Class
