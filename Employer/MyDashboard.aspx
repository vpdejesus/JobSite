<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="MyDashboard.aspx.vb" Inherits="MyDashBoard" Title="DashBoard" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Import Namespace="JobSite.BusinessObjectLayer" %>
<%@ Register Src="../UserControls/MyResumes.ascx" TagName="MyResumes" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style21 { width: 100%; }

        .style24 { width: 103px; }

        .style25 { width: 405px; }

        .style26 { width: 138px; }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    &nbsp;
    <br/>
    You can view who applied to your post, your favorite resumes, know WTJ statistics
    and more.<br/>
    <br/>
    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
            <asp:TabContainer ID="tcDashboard" runat="server" ActiveTabIndex="0" Height="501px"
                              Width="894px">
                <asp:TabPanel ID="tpApplicant" runat="server" HeaderText="Job Applications">
                    <ContentTemplate>
                        <br/>
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="btnView" runat="server" Height="27px" Text="View Applicants" Width="127px"/>
                                <br/>
                                <br/>
                                <asp:GridView ID="gvApplicants" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                              DataKeyNames="AppliedId" DataSourceID="odsApplicants" Height="91px" PageSize="3"
                                              Width="867px">
                                    <Columns>
                                        <asp:BoundField DataField="AppliedDate" DataFormatString="{0:d}" HeaderText="Applied Date"/>
                                        <asp:BoundField DataField="Title" HeaderText="Title"/>
                                        <asp:HyperLinkField DataNavigateUrlFields="JobSeekerID" DataNavigateUrlFormatString="~/Employer/ViewResume.aspx?id={0}"
                                                            HeaderText="Applicant" Text="View"/>
                                        <asp:HyperLinkField DataNavigateUrlFields="PostingID" DataNavigateUrlFormatString="~/Employer/Posting.aspx?id={0}"
                                                            HeaderText="Job Posting" Text="View"/>
                                        <asp:TemplateField HeaderText="Status">
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlStatus" runat="server" Height="24px" Width="167px" DataSourceID="odsApplicantStatus"
                                                                  DataTextField="AppStatus" DataValueField="AppStatusID" SelectedValue='<%#
                Bind("AppStatusID")%>'>
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblStatus" runat="server" Text='<%#
                ApplicationStatus.GetStatusName(CType(Eval("AppStatusID"),
                                                      integer))%>'>
                                                </asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"/>
                                    </Columns>
                                </asp:GridView>
                                <br/>
                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                <br/>
                                <asp:ObjectDataSource ID="odsApplicants" runat="server" DataObjectTypeName="JobSite.BusinessObjectLayer.MyJobApplication"
                                                      DeleteMethod="Delete" SelectMethod="GetJobApplicants" TypeName="JobSite.BusinessObjectLayer.MyJobApplication"
                                                      UpdateMethod="UpdateStatus">
                                    <SelectParameters>
                                        <asp:Parameter Name="id" Type="Int32"/>
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsApplicantStatus" runat="server" SelectMethod="GetAllStatus"
                                                      TypeName="JobSite.BusinessObjectLayer.ApplicationStatus">
                                </asp:ObjectDataSource>
                                <br/>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <br/>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="tpResumes" runat="server" HeaderText="Resumes">
                    <ContentTemplate>
                        <br/>
                        Favorite Resumes:<br/>
                        <br/>
                        <uc2:MyResumes ID="MyResumes1" runat="server"/>
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
    </p>
</asp:Content>