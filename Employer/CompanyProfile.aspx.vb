Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.BusinessObjectLayer
Imports JobSite.DataAccessLayer

Partial Class CompanyProfile
    Inherits Page
    Private _c As Company

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Roles.IsUserInRole(ConfigurationManager.AppSettings("EmployerRoleName")) Then
            Response.Redirect("~/CustomErrorPages/NotAuthorized.aspx")
        End If
        If Not Page.IsPostBack Then
            If Not (Profile.Employer.CompanyID = - 1) Then
                _c = Company.GetCompany(Profile.UserName)
                txtFName.Text = _c.FName
                txtMName.Text = _c.MName
                txtLName.Text = _c.LName
                txtCompanyName.Text = _c.CompanyName
                txtProfile.Text = _c.CompanyProfile
                txtAddress1.Text = _c.Address1
                txtAddress2.Text = _c.Address2
                txtCity.Text = _c.City
                txtZIP.Text = _c.ZIP
                txtPhone.Text = _c.Phone
                txtFax.Text = _c.Fax
                txtEmail.Text = _c.CompanyEmail
                txtWebSiteUrl.Text = _c.WebSiteURL
            End If
            FillCountries()
            FillStates()
        End If
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dbAccess = New DataAccess
        Using con = New SqlConnection(dbAccess.ConnectionString)
            Dim cmd As SqlCommand

            Dim c As New Company
            c.FName = txtFName.Text
            c.MName = txtMName.Text
            c.LName = txtLName.Text
            c.CompanyName = txtCompanyName.Text
            c.Address1 = txtAddress1.Text
            c.Address2 = txtAddress2.Text
            c.City = txtCity.Text
            c.CountryID = Integer.Parse(ddlCountry.SelectedValue)
            c.StateID = Integer.Parse(ddlState.SelectedValue)
            c.ZIP = txtZIP.Text
            c.Phone = txtPhone.Text
            c.Fax = txtFax.Text
            c.CompanyEmail = txtEmail.Text
            c.WebSiteURL = txtWebSiteUrl.Text
            c.CompanyProfile = txtProfile.Text
            c.UserName = Profile.UserName

            ' Opening Database Connection
            con.Open()

            ' Searching for existing User in the Companies Table based from the Login User
            cmd = New SqlCommand
            With cmd
                .CommandText = "SELECT CompanyID FROM dbo.Companies WHERE Username = @Username" &
                               " AND CompanyName = @CompanyName AND FName = @FName AND LName = @LName"
                .CommandType = CommandType.Text
                .Connection = con
                .Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar, 50)).Value = c.UserName
                .Parameters.Add(New SqlParameter("@CompanyName", SqlDbType.VarChar, 255)).Value = c.CompanyName
                .Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar, 50)).Value = c.FName
                .Parameters.Add(New SqlParameter("@LName", SqlDbType.VarChar, 50)).Value = c.LName
            End With

            If Profile.Employer.CompanyID = cmd.ExecuteScalar Then
                c.CompanyID = Profile.Employer.CompanyID
                Company.Update(c)
            Else
                Company.Insert(c)
                cmd = New SqlCommand
                With cmd
                    .CommandText = "SELECT CompanyID FROM dbo.Companies WHERE Username = @Username" &
                                   " AND CompanyName = @CompanyName AND FName = @FName AND LName = @LName"
                    .CommandType = CommandType.Text
                    .Connection = con
                    .Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar, 50)).Value = c.UserName
                    .Parameters.Add(New SqlParameter("@CompanyName", SqlDbType.VarChar, 255)).Value = c.CompanyName
                    .Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar, 50)).Value = c.FName
                    .Parameters.Add(New SqlParameter("@LName", SqlDbType.VarChar, 50)).Value = c.LName
                End With
                Profile.Employer.CompanyID = cmd.ExecuteScalar
                Profile.FirstName = txtFName.Text
                Profile.LastName = txtLName.Text
            End If

            lblMsg.Text = "Your company profile is successfully updated!"
        End Using
    End Sub

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Response.Redirect("~/Default.aspx")
    End Sub

    Private Sub FillCountries()
        ddlCountry.DataSource = Country.GetCountries
        ddlCountry.DataTextField = "CountryName"
        ddlCountry.DataValueField = "CountryID"
        ddlCountry.DataBind()

        If Not (Profile.Employer.CompanyID = - 1) Then
            Dim li As ListItem
            li = ddlCountry.Items.FindByValue(_c.CountryID.ToString)
            If Not (li Is Nothing) Then
                ddlCountry.ClearSelection()
                li.Selected = True
            End If
        End If
    End Sub

    Private Sub FillStates()
        _c = Company.GetCompany(Profile.UserName)

        ddlState.DataSource = State.GetStates(Integer.Parse(ddlCountry.SelectedValue))
        ddlState.DataTextField = "StateName"
        ddlState.DataValueField = "StateID"
        ddlState.DataBind()
        If Not (Profile.Employer.CompanyID = - 1) Then
            Dim li As ListItem
            li = ddlState.Items.FindByValue(_c.StateID.ToString)
            If Not (li Is Nothing) Then
                ddlState.ClearSelection()
                li.Selected = True
            End If
        End If
    End Sub

    Protected Sub ddlCountry_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ddlCountry.SelectedIndexChanged
        FillStates()
    End Sub
End Class
