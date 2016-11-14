Imports JobSite.BusinessObjectLayer

Partial Class EmployerPosting
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("EmployerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If Not Page.IsPostBack Then
            If Company.GetCompany(User.Identity.Name) Is Nothing Then
                Response.Redirect("~/CustomErrorPages/ProfileNotFound.aspx")
            End If
            If Request.QueryString("id") Is Nothing Then
                dvJobPostings.DefaultMode = DetailsViewMode.Insert
            Else
                dvJobPostings.DefaultMode = DetailsViewMode.ReadOnly
            End If
        End If
    End Sub

    Protected Sub ddlCountryUpdate_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim ddl As DropDownList
        ddl = CType(sender, DropDownList)
        odsState.SelectParameters("countryid").DefaultValue = ddl.SelectedValue
        odsState.Select()
    End Sub

    Protected Sub ddlCountryInsert_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim ddl As DropDownList
        ddl = CType(sender, DropDownList)
        odsState.SelectParameters("countryid").DefaultValue = ddl.SelectedValue
        odsState.Select()
    End Sub

    Protected Sub dvJobPostings_DataBound(sender As Object, e As EventArgs) Handles dvJobPostings.DataBound
        Dim ddl As DropDownList
        ddl = CType(dvJobPostings.FindControl("ddlCountryUpdate"), DropDownList)
        If Not (ddl Is Nothing) Then
            odsState.SelectParameters("countryid").DefaultValue = ddl.SelectedValue
            odsState.Select()
        End If
    End Sub

    Protected Sub dvJobPostings_ItemDeleted(sender As Object, e As DetailsViewDeletedEventArgs) _
        Handles dvJobPostings.ItemDeleted
        Response.Redirect("~/Employer/JobPostings.aspx")
    End Sub

    Protected Sub dvJobPostings_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) _
        Handles dvJobPostings.ItemInserted
        If e.Exception IsNot Nothing Then
            lblError.Text = "A database error has occurred. " _
                            & e.Exception.Message
            e.ExceptionHandled = True
        End If
    End Sub

    Protected Sub dvJobPostings_ItemInserting(sender As Object, e As DetailsViewInsertEventArgs) _
        Handles dvJobPostings.ItemInserting
        Dim ddl As DropDownList
        ddl = CType(dvJobPostings.FindControl("ddlStateInsert"), DropDownList)
        e.Values("StateID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlCountryInsert"), DropDownList)
        e.Values("CountryID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlEduLevelInsert"), DropDownList)
        e.Values("EducationLevelID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlJobTypeInsert"), DropDownList)
        e.Values("JobTypeID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlJobCategoryInsert"), DropDownList)
        e.Values("JobCategoryID") = ddl.SelectedValue
        e.Values("PostedBy") = Profile.UserName
        e.Values("CompanyID") = Profile.Employer.CompanyID.ToString
        e.Values("PostingDate") = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub

    Protected Sub dvJobPostings_ItemUpdated(sender As Object, e As DetailsViewUpdatedEventArgs) _
        Handles dvJobPostings.ItemUpdated
        If e.Exception IsNot Nothing Then
            lblError.Text = "A database error has occurred. " & e.Exception.Message
            e.ExceptionHandled = True
        ElseIf e.AffectedRows = 0 Then
            lblError.Text = "Another user may have updated that product. " & "Please try again."
        End If
    End Sub

    Protected Sub dvJobPostings_ItemUpdating(sender As Object, e As DetailsViewUpdateEventArgs) _
        Handles dvJobPostings.ItemUpdating
        Dim ddl As DropDownList
        ddl = CType(dvJobPostings.FindControl("ddlStateUpdate"), DropDownList)
        e.NewValues("StateID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlCountryUpdate"), DropDownList)
        e.NewValues("CountryID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlEduLevelUpdate"), DropDownList)
        e.NewValues("EducationLevelID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlJobTypeUpdate"), DropDownList)
        e.NewValues("JobTypeID") = ddl.SelectedValue
        ddl = CType(dvJobPostings.FindControl("ddlJobCategoryUpdate"), DropDownList)
        e.NewValues("JobCategoryID") = ddl.SelectedValue
        e.NewValues("PostedBy") = Profile.UserName
        e.NewValues("CompanyID") = Profile.Employer.CompanyID.ToString
        e.NewValues("PostingDate") = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub
End Class
