<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="ProfileNotFound.aspx.vb" Inherits="CustomErrorPagesProfileNotFound" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style17 { width: 100%; }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="style17">
        <tr>
            <td>
                <br/>
                <asp:Label ID="lblCompany" runat="server" Text="Company Profile Not Found!"></asp:Label>
                <br/>
                <br/>
                You can add job postings only after filling your company profile. Your company
                profile was not found. Please click on the following link to fill your company
                profile.<br/>
                <br/>
                <asp:HyperLink ID="hlCompanyProfile" runat="server" NavigateUrl="~/Employer/CompanyProfile.aspx">Fill Company Profile</asp:HyperLink>
            </td>
        </tr>
    </table>

</asp:Content>