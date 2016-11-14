<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="JobPostings.aspx.vb" Inherits="JobPostings" title="View Postings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <div align="center">
        <asp:Label ID="Label14" Runat="server" Text="List of Job Postings"></asp:Label>
        <br/>
        <br/>
        <asp:HyperLink ID="hlNewJobs" runat="server"
                       NavigateUrl="~/Employer/Posting.aspx">
            Add New Jobs
        </asp:HyperLink>
        <br/>
    </div>
    <br/>
    <asp:GridView ID="gvJobPostings" Runat="server"
                  DataSourceID="odsJobPosting" AllowPaging="True"
                  AllowSorting="True" AutoGenerateColumns="False"
                  OnRowCommand="gvJobPostings_RowCommand" OnRowDataBound="gvJobPostings_RowDataBound"
                  DataKeyNames="PostingId" Width="100%" BackColor="White" BorderColor="#CCCCCC"
                  BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <RowStyle ForeColor="#000066"/>
        <Columns>
            <asp:BoundField HeaderText="Title" DataField="Title"></asp:BoundField>
            <asp:BoundField HeaderText="Job Code" DataField="JobCode"></asp:BoundField>
            <asp:BoundField HeaderText="Location" DataField="City"></asp:BoundField>
            <asp:BoundField HeaderText="Posted On" DataField="PostingDate" DataFormatString="{0:MM/dd/yyyy}"></asp:BoundField>
            <asp:ButtonField HeaderText="Show" Text="Show">
                <HeaderStyle HorizontalAlign="Center"/>
                <ItemStyle Wrap="False" HorizontalAlign="Center"></ItemStyle>
            </asp:ButtonField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066"/>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left"/>
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White"/>
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"/>
    </asp:GridView><br/>
    &nbsp;<asp:ObjectDataSource ID="odsJobPosting" Runat="server" TypeName="JobSite.BusinessObjectLayer.JobPosting"
                                DeleteMethod="Delete" InsertMethod="Insert"
                                SelectMethod="GetPostings" UpdateMethod="Update"
                                DataObjectTypeName="JobSite.BusinessObjectLayer.JobPosting">
        <SelectParameters>
            <asp:ProfileParameter Name="username" Type="String" PropertyName="UserName"></asp:ProfileParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>