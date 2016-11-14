Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports JobSite.BusinessObjectLayer
Imports JobSite.DataAccessLayer

Partial Class PostResume
    Inherits Page
    Private _j As JobSeeker
    Private _p As Photo

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("JobSeekerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If Not Page.IsPostBack Then
            If Not (Profile.JobSeeker.JobSeekerID = - 1) Then
                _j = JobSeeker.GetJobSeeker(Profile.UserName)
                txtJobTitle.Text = _j.JobTitle
                txtFName.Text = _j.FName
                txtMName.Text = _j.MName
                txtLName.Text = _j.LName
                txtPositionDesired.Text = _j.PositionDesired
                txtAge.Text = _j.Age
                ddlSex.Text = _j.Sex
                txtBirthDate.Text = _j.BirthDate
                txtEmail.Text = _j.Email
                txtMobile.Text = _j.Mobile
                txtTelNo.Text = _j.TelNo
                txtAddress.Text = _j.Address
                txtCity.Text = _j.City
                txtResume.Text = _j.Res
            End If
            If txtFName.Text <> "" And txtMName.Text <> "" And txtLName.Text <> "" Then
                RetrieveUserPhoto()
            End If
            FillCountries()
            FillStates()
            FillEducationLevels()
            FillExperienceLevels()
        End If
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dbAccess = New DataAccess
        Dim con = New SqlConnection(dbAccess.ConnectionString)
        Dim cmd As SqlCommand
        Dim j = New JobSeeker
        Dim birthDate = New DateTime

        'Converting String To DateTime
        Conversion.ConvertoDate(txtBirthDate.Text, birthDate)

        j.UserName = Profile.UserName
        j.JobTitle = txtJobTitle.Text
        j.FName = txtFName.Text
        j.MName = txtMName.Text
        j.LName = txtLName.Text
        j.PositionDesired = txtPositionDesired.Text
        j.Age = txtAge.Text
        j.Sex = ddlSex.SelectedValue
        j.BirthDate = birthDate
        j.Email = txtEmail.Text
        j.Mobile = txtMobile.Text
        j.TelNo = txtTelNo.Text
        j.Address = txtAddress.Text
        j.City = txtCity.Text
        j.StateID = Integer.Parse(ddlState.SelectedValue)
        j.CountryID = Integer.Parse(ddlCountry.SelectedValue)
        j.EducationLevelID = Integer.Parse(ddlEducationLevel.SelectedValue)
        j.ExperienceLevelID = Integer.Parse(ddlExperienceLevel.SelectedValue)
        j.Res = txtResume.Text

        'Opening Database Connection
        con.Open()

        'Searching for existing User in the Job Seeker Main Table (JSMain) based from the Login User
        cmd = New SqlCommand
        With cmd
            .CommandText = "SELECT JobSeekerID FROM dbo.JSMain WHERE Username = @Username" &
                           " AND FName = @FName AND MName = @MName AND LName = @LName"
            .CommandType = CommandType.Text
            .Connection = con
            .Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar, 50)).Value = j.UserName
            .Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar, 50)).Value = j.FName
            .Parameters.Add(New SqlParameter("@MName", SqlDbType.VarChar, 50)).Value = j.MName
            .Parameters.Add(New SqlParameter("@LName", SqlDbType.VarChar, 50)).Value = j.LName
        End With

        If Profile.JobSeeker.JobSeekerID = cmd.ExecuteScalar Then
            j.JobSeekerID = Profile.JobSeeker.JobSeekerID
            JobSeeker.Update(j)
        Else
            JobSeeker.Insert(j)
            cmd = New SqlCommand
            With cmd
                .CommandText = "SELECT JobSeekerID FROM dbo.JSMain WHERE Username = @Username" &
                               " AND FName = @FName AND MName = @MName AND LName = @LName"
                .CommandType = CommandType.Text
                .Connection = con
                .Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar, 50)).Value = j.UserName
                .Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar, 50)).Value = j.FName
                .Parameters.Add(New SqlParameter("@MName", SqlDbType.VarChar, 50)).Value = j.MName
                .Parameters.Add(New SqlParameter("@LName", SqlDbType.VarChar, 50)).Value = j.LName
            End With
            Profile.JobSeeker.JobSeekerID = cmd.ExecuteScalar
            Profile.FirstName = txtFName.Text
            Profile.LastName = txtLName.Text
        End If
        'Closing Database Connection
        con.Close()
        lblMsg.Text = "Your resume is successfully updated!"
    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim sizeLimit = 150000 'Size limit of Photo is only 15KB
        Dim fileOk = False

        If txtFName.Text = "" Or txtMName.Text = "" Or txtLName.Text = "" Then
            lblUpload.Text =
                "Please enter your complete profile first and save before uploading and attaching your photo!"
        Else
            If fuPhoto.HasFile Then
                If fuPhoto.PostedFile.ContentLength <= sizeLimit Then
                    Dim fileExtension As String
                    fileExtension = Path.GetExtension(fuPhoto.FileName).ToLower()
                    Dim allowedExtensions As String() = {".jpg", ".jpeg", ".png", ".gif"}
                    For i = 0 To allowedExtensions.Length - 1
                        If fileExtension = allowedExtensions(i) Then
                            fileOK = True
                        End If
                    Next

                    If fileOK Then
                        Try
                            Dim fileName As String = fuPhoto.PostedFile.FileName ' Gets the FileName
                            Dim imgType = fuPhoto.PostedFile.ContentType ' Gets the FileType
                            Dim intLength As Integer = Convert.ToInt32(fuPhoto.PostedFile.InputStream.Length) _
                            ' Gets the FileLength
                            Dim arrContent(intLength) As Byte ' Gets the content and length
                            ' Reads the image
                            fuPhoto.PostedFile.InputStream.Read(arrContent, 0, intLength)
                            If _
                                PhotoInsert(Profile.JobSeeker.JobSeekerID, arrContent, fileName, imgType, intLength) =
                                True Then
                                lblUpload.Text = "Photo uploaded successfully."
                                RetrieveUserPhoto()
                            Else
                                lblUpload.Text = "An error occured while uploading Image... Please try again."
                            End If
                        Catch ex As Exception
                            lblUpload.Text = "File could not be uploaded."
                        End Try
                    Else
                        lblUpload.Text =
                            "Cannot accept files of this type. Only files of type (.jpg, .jpeg, .png, .gif) is allowed."
                    End If
                Else
                    lblUpload.Text =
                        "File exceeds file limit! Photo size limit is up to 15KB only. Please edit the size of your photo."
                End If
            Else
                lblUpload.Text = "No file or image was selected!"
            End If
        End If
    End Sub

    Private Sub FillCountries()
        ddlCountry.DataSource = Country.GetCountries
        ddlCountry.DataTextField = "CountryName"
        ddlCountry.DataValueField = "CountryID"
        ddlCountry.DataBind()

        If Not (Profile.JobSeeker.JobSeekerID = - 1) Then
            Dim li As ListItem
            li = ddlCountry.Items.FindByValue(_j.CountryID.ToString)
            If Not (li Is Nothing) Then
                ddlCountry.ClearSelection()
                li.Selected = True
            End If
        End If
    End Sub

    Private Sub FillStates()
        _j = JobSeeker.GetJobSeeker(Profile.UserName)
        ddlState.DataSource = State.GetStates(Integer.Parse(ddlCountry.SelectedValue))
        ddlState.DataTextField = "StateName"
        ddlState.DataValueField = "StateID"
        ddlState.DataBind()
        If Not (Profile.JobSeeker.JobSeekerID = - 1) Then
            Dim li As ListItem
            li = ddlState.Items.FindByValue(_j.StateID.ToString)
            If Not (li Is Nothing) Then
                ddlState.ClearSelection()
                li.Selected = True
            End If
        End If
    End Sub

    Private Sub FillEducationLevels()
        ddlEducationLevel.DataSource = EducationLevel.GetEducationLevels
        ddlEducationLevel.DataTextField = "EducationLevelName"
        ddlEducationLevel.DataValueField = "EducationLevelID"
        ddlEducationLevel.DataBind()
        If Not (Profile.JobSeeker.JobSeekerID = - 1) Then
            Dim li As ListItem
            li = ddlEducationLevel.Items.FindByValue(_j.EducationLevelID.ToString)
            If Not (li Is Nothing) Then
                ddlEducationLevel.ClearSelection()
                li.Selected = True
            End If
        End If
    End Sub

    Private Sub FillExperienceLevels()
        ddlExperienceLevel.DataSource = ExperienceLevel.GetExperienceLevels
        ddlExperienceLevel.DataTextField = "ExperienceLevelName"
        ddlExperienceLevel.DataValueField = "ExperienceLevelID"
        ddlExperienceLevel.DataBind()
        If Not (Profile.JobSeeker.JobSeekerID = - 1) Then
            Dim li As ListItem
            li = ddlExperienceLevel.Items.FindByValue(_j.ExperienceLevelID.ToString)
            If Not (li Is Nothing) Then
                ddlExperienceLevel.ClearSelection()
                li.Selected = True
            End If
        End If
    End Sub

    Private Sub RetrieveUserPhoto()
        Dim dbAccess = New DataAccess
        Dim con = New SqlConnection(dbAccess.ConnectionString)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter

        'Opening Database Connection
        con.Open()

        With da
            .SelectCommand = New SqlCommand
            With .SelectCommand
                .CommandText = "SELECT JobSeekerID, PhotoFileName FROM dbo.JSPhotos WHERE JobSeekerID=@JobSeekerID"
                .CommandType = CommandType.Text
                .Connection = con
                .CommandTimeout = 120
                .Parameters.Add(New SqlParameter("@JobSeekerID", SqlDbType.Int, 100)).Value =
                    Profile.JobSeeker.JobSeekerID
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

    Protected Function PhotoInsert(id As Integer, content As Byte(), fName As String, fType As String,
                                   fLength As Integer) As Boolean
        Try
            Dim dbAccess = New DataAccess
            Dim con = New SqlConnection(dbAccess.ConnectionString)
            Dim cmd = New SqlCommand

            con.Open()
            With cmd
                .CommandText = "[JSPhotos_Insert]"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .Parameters.Add(New SqlParameter("@JobSeekerID", SqlDbType.Int)).Value = id
                .Parameters.Add(New SqlParameter("@Photo", SqlDbType.Image)).Value = content
                .Parameters.Add(New SqlParameter("@PhotoFileName", SqlDbType.VarChar)).Value = fName
                .Parameters.Add(New SqlParameter("@FileType", SqlDbType.VarChar)).Value = fType
                .Parameters.Add(New SqlParameter("@FileLength", SqlDbType.BigInt)).Value = fLength
                .ExecuteNonQuery()
            End With
            Return True
            con.Close()
        Catch ex As Exception
            Return False
        End Try
    End Function

    Protected Sub imgbtnDelete_Click(sender As Object, e As ImageClickEventArgs) Handles imgbtnDelete.Click
        Dim dbAccess = New DataAccess
        Dim con = New SqlConnection(dbAccess.ConnectionString)
        Dim cmd As SqlCommand

        If _
            MsgBox("Are you sure you want to delete your photo", MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                   "Confirmation") = MsgBoxResult.Yes Then
            imgPhoto.ImageUrl = ""
            'Opening Database Connection
            con.Open()
            'Deleting File in JSPhotos Table
            cmd = New SqlCommand
            With cmd
                .CommandText = "[JSPhotos_Delete]"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .Parameters.Add(New SqlParameter("@JobSeekerID", SqlDbType.Int)).Value = Profile.JobSeeker.JobSeekerID
                .ExecuteNonQuery()
            End With

            'Closing Database Connection
            con.Close()
            lblUpload.Text = "Your photo has been successfully deleted!"
        End If
    End Sub

    Protected Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ddlCountry.SelectedIndexChanged
        FillStates()
    End Sub
End Class
