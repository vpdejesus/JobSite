Imports JobSite.BusinessObjectLayer

Partial Class Statistics
    Inherits UserControl

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblCompanies.Text = Company.GetCompanyCount().ToString()
        lblJobs.Text = JobPosting.GetJobPostingCount().ToString()
        lblResumes.Text = JobSeeker.GetResumeCount().ToString()
    End Sub
End Class
