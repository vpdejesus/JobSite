
Partial Class Register
    Inherits Page

    Protected Sub CreateUserWizard1_ContinueButtonClick1(sender As Object, e As EventArgs) _
        Handles CreateUserWizard1.ContinueButtonClick
        Response.Redirect("~/Default.aspx")
    End Sub

    Protected Sub CreateUserWizard1_ActiveStepChanged1(sender As Object, e As EventArgs) _
        Handles CreateUserWizard1.ActiveStepChanged
        If CreateUserWizard1.ActiveStep.ID = "WizardStep2" Then
            Dim ddl = CType(CreateUserWizard1.ActiveStep.FindControl("ddlRegAs"), DropDownList)
            If Not (ddl Is Nothing) Then
                Dim li1 = New ListItem("Job Seeker", ConfigurationManager.AppSettings("JobSeekerRoleName"))
                Dim li2 = New ListItem("Employer", ConfigurationManager.AppSettings("EmployerRoleName"))
                ddl.Items.Add(li1)
                ddl.Items.Add(li2)
            End If
        End If
    End Sub

    Protected Sub CreateUserWizard1_NextButtonClick1(sender As Object, e As WizardNavigationEventArgs) _
        Handles CreateUserWizard1.NextButtonClick
        If CreateUserWizard1.ActiveStep.ID = "WizardStep2" Then
            Dim objUser As MembershipUser = Membership.GetUser
            Dim ddl = CType(CreateUserWizard1.ActiveStep.FindControl("ddlRegAs"), DropDownList)
            If Not (ddl Is Nothing) Then
                Roles.AddUserToRole(objUser.UserName, ddl.SelectedValue)
            End If
            Profile.UserName = objUser.UserName
            Profile.Email = objUser.Email
            Profile.JobSeeker.JobSeekerID = - 1
            Profile.Employer.CompanyID = - 1
        End If
    End Sub
End Class
