<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false"
CodeFile="Default.aspx.vb" Inherits="Default" Title="World's Top Jobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .MsoNormal {
            text-align: justify;
            width: 808px;
        }

        .style19 {
            height: 269px;
            width: 292px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    &nbsp;
    <br/>
    <div>
        &nbsp;<img alt="Logo" src="Images/Logo.png" style="height: 236px; width: 329px;"/>
    </div>

    <p style="font-family: Verdana; font-size: x-large; font-style: normal; font-weight: bold; text-align: left;" align="left">
        Welcome To World&#39;s Top Jobs!!!
    </p>
    <p class="MsoNormal">
        World’s Top Jobs is a site designed to provide a very convenient way for job seekers
        or applicants to find suitable positions in line with their qualifications. It has
        features that are very useful for them to navigate and seek available positions
        posted by employers. This is also a good site for employers to post their job vacancies
        and have the option of choosing the best applicants for their required positions.
    </p>
    <p style="height: 36px; text-align: justify; width: 810px;">
        So, start searching for job openings, post resume, search resumes, post job openings
        and do it now. This site will be your best tool to do all that.
    </p>
    <p style="font-weight: bold; text-align: left;">
        To Companies, Recruitment Agencies or Head Hunters:
    </p>
    <p style="text-align: left">
        There are many applicants that are searching for jobs now,
        <asp:HyperLink ID="hlRegisterEm" runat="server" NavigateUrl="~/Register.aspx">register</asp:HyperLink>
        &nbsp;now to post your job vacancy, search and hire qualified applicants.
    </p>
    <p style="text-align: left">
        Reminders for employers, please post only legitimate jobs to avoid termination of
        your account.
    </p>
    <p style="font-weight: bold; text-align: left;">
        To Job Seekers or Applicants:
    </p>
    <p style="text-align: left">
        Find jobs that suit your qualifications. Great companies are posting job vacancies
        here.
        <asp:HyperLink ID="hlRegisterJS" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
        &nbsp;and post your resume now to get hired.&nbsp;
    </p>
</asp:Content>