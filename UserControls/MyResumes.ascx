<%@ Control Language="VB" AutoEventWireup="false" CodeFile="MyResumes.ascx.vb" Inherits="MyResumes" %>
<asp:GridView ID="gvMyResumes" Runat="server" DataSourceID="odsMyResumes" AllowPaging="True"
              AutoGenerateColumns="False" Width="100%" DataKeyNames="MyResumeId">
    <Columns>
        <asp:HyperLinkField Text="View" DataNavigateUrlFields="JobSeekerID"
                            DataNavigateUrlFormatString="~/Employer/ViewResume.aspx?id={0}">
        </asp:HyperLinkField>
        <asp:BoundField HeaderText="Title" DataField="JobTitle"></asp:BoundField>
        <asp:BoundField HeaderText="Education" DataField="EducationLevelName"></asp:BoundField>
        <asp:BoundField HeaderText="Experience" DataField="ExperienceLevelName"></asp:BoundField>
        <asp:BoundField HeaderText="Location" DataField="City"></asp:BoundField>
        <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
    </Columns>
</asp:GridView><br/>
<asp:ObjectDataSource ID="odsMyResumes" Runat="server" TypeName="JobSite.BusinessObjectLayer.MyResume"
                      DeleteMethod="Delete" SelectMethod="GetMyResumes"
                      DataObjectTypeName="JobSite.BusinessObjectLayer.MyResume">
    <SelectParameters>
        <asp:ProfileParameter Name="username" Type="String" PropertyName="UserName"></asp:ProfileParameter>
    </SelectParameters>
</asp:ObjectDataSource>