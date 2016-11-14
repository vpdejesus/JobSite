Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.BusinessObjectLayer
Imports JobSite.DataAccessLayer

Partial Class Viewresume
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("employerrolename")) Then
            Response.Redirect("~/customerrorpages/NotAuthorized.aspx")
        End If
        RetrieveUserPhoto()
        Dim r As JobSeeker = JobSeeker.GetResume(Integer.Parse(Request.QueryString("id")))
        Dim p As ProfileCommon = Profile.GetProfile(r.UserName)
        lblName.Text = "Full Name : " + p.FirstName + " " + p.LastName
        lblEducation.Text = "Education Level : " + EducationLevel.GetEducationLevelName(r.EducationLevelID)
        lblExperience.Text = "Experience Level : " + ExperienceLevel.GetExperienceLevelName(r.ExperienceLevelID)
        txtResume.Text = r.Res
    End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Response.Redirect("~/Employer/ResumeSearch.aspx")
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim r = New MyResume
        r.JobSeekerID = Integer.Parse(Request.QueryString("id"))
        r.UserName = Profile.UserName
        r.CreatedDate = Now
        MyResume.Insert(r)
    End Sub

    Private Sub RetrieveUserPhoto()
        Dim dbAccess = New DataAccess
        Dim con = New SqlConnection(dbAccess.ConnectionString)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim r As Integer = Integer.Parse(Request.QueryString("id"))

        'Opening Database Connection
        con.Open()

        With da
            .SelectCommand = New SqlCommand
            With .SelectCommand
                .CommandText = "SELECT JobSeekerID, PhotoFileName FROM dbo.JSPhotos WHERE JobSeekerID = @JobSeekerID"
                .CommandType = CommandType.Text
                .Connection = con
                .CommandTimeout = 120
                .Parameters.Add(New SqlParameter("@JobSeekerID", SqlDbType.Int, 100)).Value = r
                .ExecuteNonQuery()
            End With
        End With

        da.Fill(ds)
        For Each tempRow As DataRow In ds.Tables(0).Rows
            imgPhoto.ImageUrl = ("ImageGrabber.aspx?id=" & tempRow.Item("JobSeekerID"))
        Next
        'Closing Database Connection
        con.Close()
    End Sub

    Protected Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnContact.Click
        Dim email As String
        email = JobSeeker.GetEmail(Integer.Parse(Request.QueryString("id")))

        Session.Add("Email", email)
        Response.Redirect("~/Employer/Contact.aspx")
    End Sub
End Class
