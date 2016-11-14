<%@ Control Language="VB" AutoEventWireup="false" CodeFile="MyJobs.ascx.vb" Inherits="MyJobs" %>
<asp:GridView ID="gvMyJobs" Runat="server" DataSourceID="odsMyJobs" AllowPaging="True"
              AutoGenerateColumns="False" Width="100%" DataKeyNames="MyJobId">
    <Columns>
        <asp:HyperLinkField Text="View" DataNavigateUrlFields="PostingID"
                            DataNavigateUrlFormatString="~/JobSeeker/ViewJobs.aspx?id={0}">
        </asp:HyperLinkField>
        <asp:BoundField HeaderText="Date" DataField="PostingDate" DataFormatString="{0:MM/dd/yyyy}"></asp:BoundField>
        <asp:BoundField HeaderText="Title" DataField="Title"></asp:BoundField>
        <asp:BoundField HeaderText="Location" DataField="City"></asp:BoundField>
        <asp:BoundField HeaderText="Company" DataField="CompanyName"></asp:BoundField>
        <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
    </Columns>
</asp:GridView><br/>
<asp:ObjectDataSource ID="odsMyJobs" Runat="server" TypeName="JobSite.BusinessObjectLayer.MyJob"
                      DeleteMethod="Delete" SelectMethod="GetMyJobs"
                      DataObjectTypeName="JobSite.BusinessObjectLayer.MyJob">
    <SelectParameters>
        <asp:ProfileParameter Name="username" Type="String" PropertyName="UserName"></asp:ProfileParameter>
    </SelectParameters>
</asp:ObjectDataSource>