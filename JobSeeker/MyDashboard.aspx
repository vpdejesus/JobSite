<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="MyDashboard.aspx.vb" Inherits="MyDashboard" Title="My Dashboard" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Import Namespace="JobSite.BusinessObjectLayer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    &nbsp;
    <br/>
    You can view your job applications and know what companies viewed your resume.<br/>
    <br/>
    <asp:TabContainer ID="tcDashboard" runat="server" ActiveTabIndex="0" Height="479px" Width="892px">
        <asp:TabPanel ID="tpJobsApplied" runat="server" HeaderText="Jobs Applied">
            <ContentTemplate>
                <br/>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <table class="style21">
                            <tr>
                                <td class="style27">
                                    <asp:Button ID="btnView" runat="server" Height="27px" Text="View Application" Width="127px"/><br/>
                                    <br/>
                                    <asp:GridView ID="gvJobsApplied" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                                  PageSize="3" Width="100%">
                                        <Columns>
                                            <asp:BoundField DataField="AppliedDate" DataFormatString="{0:d}" HeaderText="Date Applied"/>
                                            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="title"/>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company" ShowHeader="False" SortExpression="companyname"/>
                                            <asp:BoundField DataField="JobCode" HeaderText="Job Code" SortExpression="city"/>
                                            <asp:BoundField DataField="JobDescription" HeaderText="Job Description"/>
                                            <asp:TemplateField HeaderText="Status">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtStatus" runat="server" Text='<%#
                Bind("AppStatusID")%>'>
                                                    </asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblStatus" runat="server" Text='<%#
                ApplicationStatus.GetStatusName(CType(Eval("AppStatusID"),
                                                      integer))%>'>
                                                    </asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                    <br/>
                                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="tpResumeView" runat="server" HeaderText="Resume Views">
            <ContentTemplate>
                <br/>
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="lblView" runat="server" Font-Bold="True" ForeColor="#000099"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br/>
                <br/>
                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="btnCompany" runat="server" Height="27px" Text="View Details" Width="127px"/><br/>
                        <br/>
                        Companies who viewed your resume:
                        <br/>
                        &#160;&#160;<br/>
                        <asp:GridView ID="gvCompany" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                      DataKeyNames="ViewId" DataSourceID="odsMyResumeView" Height="91px" PageSize="3"
                                      Width="800px">
                            <Columns>
                                <asp:BoundField DataField="ViewDate" DataFormatString="{0:d}" HeaderText="Date Viewed"/>
                                <asp:BoundField DataField="CompanyName" HeaderText="Company Name" SortExpression="companyname"/>
                                <asp:BoundField DataField="CompanyEmail" HeaderText="Email" SortExpression="companyemail"/>
                                <asp:BoundField DataField="WebsiteUrl" HeaderText="Website"/>
                                <asp:CommandField ShowDeleteButton="True"/>
                            </Columns>
                        </asp:GridView>
                        <br/>
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br/>
                <br/>
                <asp:ObjectDataSource ID="odsMyResumeView" runat="server" DataObjectTypeName="JobSite.BusinessObjectLayer.MyResumeView"
                                      DeleteMethod="Delete" SelectMethod="GetMyResumeViews" TypeName="JobSite.BusinessObjectLayer.MyResumeView">
                    <SelectParameters>
                        <asp:Parameter Name="id" Type="Int32"/>
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br/>
            </ContentTemplate>
        </asp:TabPanel>
    </asp:TabContainer>
</asp:Content>