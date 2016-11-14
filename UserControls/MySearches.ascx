<%@ Control Language="VB" AutoEventWireup="false" CodeFile="MySearches.ascx.vb" Inherits="MySearches" %>
<asp:GridView ID="gvMySearches" Runat="server" DataSourceID="odsMySearches" AllowPaging="True"
              AutoGenerateColumns="False" Width="100%"
              DataKeyNames="MySearchId">
    <Columns>
        <asp:HyperLinkField Text="View" DataNavigateUrlFields="MySearchID"
                            DataNavigateUrlFormatString="~/jobseeker/JobSearch.aspx?mysearchid={0}">
        </asp:HyperLinkField>
        <asp:BoundField HeaderText="Criteria" DataField="SearchCriteria"></asp:BoundField>
        <asp:BoundField HeaderText="Country" DataField="countryname"></asp:BoundField>
        <asp:BoundField HeaderText="State" DataField="statename"></asp:BoundField>
        <asp:BoundField HeaderText="City" DataField="city"></asp:BoundField>
        <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
    </Columns>
</asp:GridView><br/>
<asp:ObjectDataSource ID="odsMySearches"
                      Runat="server"
                      TypeName="JobSite.BusinessObjectLayer.MySearch"
                      DeleteMethod="Delete"
                      SelectMethod="GetMySearches"
                      DataObjectTypeName="JobSite.BusinessObjectLayer.MySearch">
    <SelectParameters>
        <asp:ProfileParameter Name="username" Type="String" PropertyName="UserName"></asp:ProfileParameter>
    </SelectParameters>
</asp:ObjectDataSource>