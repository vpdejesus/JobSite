Imports System.Data
Imports JobSite.BusinessObjectLayer

Partial Class Jobsearch
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("JobSeekerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If Not Page.IsPostBack Then
            FillCategory()
            FillCountries()
            FillStates()
            lblJobCount.Text = "(Currently we have " + JobPosting.GetJobPostingCount.ToString() + " job/s!!!)"
            If Not (Request.QueryString("mysearchid") Is Nothing) Then
                Dim s As MySearch = MySearch.GetMySearch(Integer.Parse(Request.QueryString("mysearchid")))
                txtSkills.Text = s.SearchCriteria
                txtCity.Text = s.City
                ddlCountry.SelectedIndex = s.CountryID
                FillStates()
                Dim li As ListItem = ddlState.Items.FindByValue(s.StateID.ToString)
                If Not (li Is Nothing) Then
                    ddlState.ClearSelection()
                    li.Selected = True
                End If
                Exit Sub
            End If
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

    Private Sub FillCategory()
        ddlCategory.DataSource = JobCategory.GetJobCategories
        ddlCategory.DataTextField = "JobCategoryName"
        ddlCategory.DataValueField = "JobCategoryID"
        ddlCategory.DataBind()
    End Sub

    Protected Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ddlCountry.SelectedIndexChanged, ddlCategory.SelectedIndexChanged
        FillStates()
    End Sub

    Private Sub BindGrid()
        Dim categoryid = 1
        Dim countryid = 1
        Dim stateid = 1

        If Not (ddlCategory.SelectedItem Is Nothing) Then
            categoryid = Integer.Parse(ddlCategory.SelectedValue)
        End If
        If Not (ddlCountry.SelectedItem Is Nothing) Then
            countryid = Integer.Parse(ddlCountry.SelectedValue)
        End If
        If Not (ddlState.SelectedItem Is Nothing) Then
            stateid = Integer.Parse(ddlState.SelectedValue)
        End If

        Dim ds As DataSet

        ds = JobPosting.SearchJobs(txtSkills.Text, categoryid, countryid, stateid, txtCity.Text)
        gvJobSearch.DataSource = ds
        gvJobSearch.DataBind()

        If gvJobSearch.Rows.Count <= 0 Then
            lblMsg.Text = "No records found!"
        Else
            lblMsg.Text = ""
        End If
        UpdatePanel2.Update()
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

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim s = New MySearch
        s.SearchCriteria = txtSkills.Text
        s.CountryID = Integer.Parse(ddlCountry.SelectedValue)
        s.StateID = Integer.Parse(ddlState.SelectedValue)
        s.City = txtCity.Text
        s.UserName = Profile.UserName
        MySearch.Insert(s)
        lblMsg.Text = "Search added to your favorites!"
    End Sub

    Protected Sub gvJobSearch_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) _
        Handles gvJobSearch.PageIndexChanging
        gvJobSearch.PageIndex = e.NewPageIndex
        BindGrid()
    End Sub

    Protected Sub gvJobSearch_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvJobSearch.RowCommand
        If e.CommandName = "viewdetails" Then
            Response.Redirect("~/JobSeeker/ViewJobs.aspx?id=" + e.CommandArgument.ToString())
        End If
    End Sub

    Protected Sub gvJobSearch_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvJobSearch.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim b = CType(e.Row.Cells(4).Controls(0), ImageButton)
            b.CommandName = "viewdetails"
            b.CommandArgument = gvJobSearch.DataKeys(e.Row.RowIndex).Value.ToString
        End If
    End Sub
End Class
