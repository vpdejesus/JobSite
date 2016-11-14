Imports JobSite.BusinessObjectLayer

Partial Class ViewJobs
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("JobSeekerRoleName")) Then
            Response.Redirect("~/CustomErrorpages/NotAuthorized.aspx")
        End If

        If Not Page.IsPostBack Then
            Dim postingid As Integer
            postingid = Integer.Parse(Request.QueryString("id"))

            Dim p As JobPosting = JobPosting.GetPosting(postingid)

            lblCity.Text = p.City
            lblCompany.Text = Company.GetCompanyName(p.CompanyID)
            btnViewProfile.CommandArgument = p.CompanyID.ToString()
            ModalPopupExtender1.DynamicContextKey = p.CompanyID.ToString()
            lblContactPerson.Text = p.ContactPerson
            lblCountry.Text = Country.GetCountryName(p.CountryID)
            lblDept.Text = p.Department
            lblDesc.Text = p.Description.Replace(vbCrLf, "<br>")
            lblEduLevel.Text = EducationLevel.GetEducationLevelName(p.EducationLevelID)
            lblJobCode.Text = p.JobCode
            lblJobType.Text = JobType.GetJobTypeName(p.JobTypeID)
            lblMaxSal.Text = p.MaxSalary.ToString("C")
            lblMinSal.Text = p.MinSalary.ToString("C")
            lblState.Text = State.GetStateName(p.StateID)
            lblTitle.Text = p.Title
        End If
        Page.DataBind()
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("~/JobSeeker/JobSearch.aspx")
    End Sub

    Protected Sub btnAddFavorites_Click(sender As Object, e As EventArgs) Handles btnAddFavorites.Click
        Dim j = New MyJob
        j.PostingID = Integer.Parse(Request.QueryString("id"))
        j.UserName = Profile.UserName
        MyJob.Insert(j)
    End Sub

    Protected Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim mj = New MyJobApplication
        Dim postingid As Integer = Integer.Parse(Request.QueryString("id"))
        Dim jobseekerid As Integer = Profile.JobSeeker.JobSeekerID
        Dim jp As JobPosting = JobPosting.GetPosting(postingid)

        If MyJobApplication.GetJobApplied(postingid, jobseekerid, jp.CompanyID) = True Then
            MsgBox("You have already applied for this job!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly,
                   "Error Message")
        Else
            mj.PostingID = postingid
            mj.JobSeekerID = jobseekerid
            mj.CompanyID = jp.CompanyID
            mj.Title = jp.Title
            mj.AppliedDate = Now()
            mj.AppStatusID = 2
            MyJobApplication.Insert(mj)
            lblStatus.Text = "Job vacancy successfully applied!!"
        End If
    End Sub
End Class
