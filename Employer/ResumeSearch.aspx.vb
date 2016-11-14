Imports System.Data
Imports JobSite.BusinessObjectLayer

Partial Class ResumeSearch
    Inherits Page

    Private Sub BindGrid()
        Dim countryid As Integer = - 1
        Dim stateid As Integer = - 1
        If Not (ddlCountry.SelectedItem Is Nothing) Then
            countryid = Integer.Parse(ddlCountry.SelectedValue)
        End If
        If Not (ddlState.SelectedItem Is Nothing) Then
            stateid = Integer.Parse(ddlState.SelectedValue)
        End If
        Dim ds As DataSet = JobSeeker.SearchResumes(txtSkills.Text, countryid, stateid, txtCity.Text)
        gvResume.DataSource = ds
        gvResume.DataBind()

        If gvResume.Rows.Count <= 0 Then
            lblMsg.Text = "No records found!"
        Else
            lblMsg.Text = ""
        End If
        'UpdatePanel2.Update()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("EmployerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If Not Page.IsPostBack Then
            FillCountries()
            FillStates()
            lblResumeCount.Text = "(Currently we have " + JobSeeker.GetResumeCount.ToString() + " resume/s !!!)"
        End If
    End Sub

    Private Sub FillCountries()
        ddlCountry.DataSource = Country.GetCountries
        ddlCountry.DataTextField = "CountryName"
        ddlCountry.DataValueField = "CountryID"
        ddlCountry.DataBind()
    End Sub

    Private Sub FillStates()
        ddlState.DataSource = State.GetStates(Integer.Parse(ddlCountry.SelectedValue))
        ddlState.DataTextField = "StateName"
        ddlState.DataValueField = "StateID"
        ddlState.DataBind()
    End Sub

    Protected Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs)
        FillStates()
        txtCity.Enabled = False
    End Sub

    Protected Sub ddlState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlState.SelectedIndexChanged
        If ddlState.SelectedIndex > 0 Then
            txtCity.Enabled = True
        Else
            txtCity.Enabled = False
        End If
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        BindGrid()
    End Sub

    Protected Sub gvResume_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) _
        Handles gvResume.PageIndexChanging
        gvResume.PageIndex = e.NewPageIndex
        BindGrid()
    End Sub

    Protected Sub gvResume_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvResume.RowCommand
        If e.CommandName = "viewdetails" Then
            ResumeViewCount(e.CommandArgument.ToString)
            Response.Redirect("~/Employer/ViewResume.aspx?id=" + e.CommandArgument.ToString())
        End If
    End Sub

    Protected Sub gvResume_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvResume.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim b = CType(e.Row.Cells(5).Controls(0), ImageButton)
            b.CommandName = "viewdetails"
            b.CommandArgument = gvResume.DataKeys(e.Row.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub ResumeViewCount(id As String)
        Dim rview = New MyResumeView
        rview.JobSeekerID = Int32.Parse(id)
        rview.CompanyID = Profile.Employer.CompanyID
        rview.ViewDate = Now
        MyResumeView.Insert(rview)
    End Sub
End Class
