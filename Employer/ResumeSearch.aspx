<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="ResumeSearch.aspx.vb" Inherits="resumesearch" title="Search Resume" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">

    <div align="center" style="width: 886px">
        <br/>
        <asp:Label ID="Label14" Runat="server" Text="Search Resume Database"></asp:Label>
        <br/>
        <asp:Label ID="lblResumeCount" Runat="server"></asp:Label>
        <br/>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width: 58%">
                    <tr>
                        <td align="right" valign="top" class="style25">
                        </td>
                        <td align="left" class="style26">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top" class="style28">
                            <asp:Label ID="Label1" Runat="server" Text="Skills :"></asp:Label>
                        </td>
                        <td align="left" class="style21">
                            <asp:TextBox ID="txtSkills" Runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Runat="server"
                                                        ControlToValidate="txtSkills" Display="Dynamic"
                                                        ErrorMessage="Please enter skills to search for">
                                *
                            </asp:RequiredFieldValidator>
                            &nbsp;(Ex.: Sales Agent, Programmer, etc.)
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top" class="style28">
                            <asp:Label ID="Label3" Runat="server" Text="Country :"></asp:Label>
                        </td>
                        <td align="left" class="style27">
                            <asp:DropDownList ID="ddlCountry" Runat="server" AutoPostBack="True"
                                              OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" Width="250px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top" class="style28">
                            <asp:Label ID="Label4" Runat="server" Text="State :"></asp:Label>
                        </td>
                        <td align="left" class="style27">
                            <asp:DropDownList ID="ddlState" Runat="server" AutoPostBack="True"
                                              onselectedindexchanged="ddlState_SelectedIndexChanged" Width="150px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" valign="top" class="style28">
                            <asp:Label ID="Label2" Runat="server" Text="City :"></asp:Label>
                        </td>
                        <td align="left" class="style27">
                            <asp:TextBox ID="txtCity" Runat="server" Enabled="False" Width="150px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" valign="top">
                            <asp:Button ID="btnSearch" runat="server" Text="Search"/>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" valign="top">
                            <asp:Label ID="lblMsg" runat="server" SkinID="FormLabel"></asp:Label>
                            <asp:ValidationSummary ID="ValidationSummary1" Runat="server"/>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server"
                            AssociatedUpdatePanelID="UpdatePanel1">
            <progresstemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/progress.gif"/>
            </progresstemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:GridView ID="gvResume" Runat="server" AllowPaging="True"
                              AutoGenerateColumns="False" DataKeyNames="JobSeekerID"
                              OnPageIndexChanging="gvResume_PageIndexChanging"
                              OnRowCommand="gvResume_RowCommand" OnRowDataBound="gvResume_RowDataBound"
                              Width="91%">
                    <columns>
                        <asp:boundfield DataField="JobTitle" HeaderText="Title"/>
                        <asp:boundfield DataField="EducationLevelName" HeaderText="Education"
                                        ShowHeader="False"/>
                        <asp:boundfield DataField="ExperienceLevelName" HeaderText="Experience"/>
                        <asp:BoundField DataField="CountryName" HeaderText="Country"/>
                        <asp:boundfield DataField="City" HeaderText="City"/>
                        <asp:buttonfield ButtonType="Image" CommandName="viewdetails"
                                         ImageUrl="~/Images/showdetails.jpg" HeaderText="View"/>
                    </columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">

        .style16 { width: 100px; }

        .style18 {
            height: 3px;
            width: 45%;
        }

        .style21 {
            text-align: left;
            width: 929px;
        }

        .style25 {
            height: 1px;
            width: 21%;
        }

        .style26 {
            height: 1px;
            text-align: left;
            width: 929px;
        }

        .style27 { width: 929px; }

        .style28 { width: 21%; }
    </style>
</asp:Content>