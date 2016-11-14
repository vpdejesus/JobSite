<%@ Page Title="" Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="CountryManager.aspx.vb" Inherits="AdminCountryManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        <br/>
        <asp:Label ID="lblCountry" Runat="server"
                   Text="Country Maintenance">
        </asp:Label>
        <br/>
        <br/>
        <asp:DetailsView ID="dvCountry" Runat="server" DataSourceID="odsCountry"
                         AllowPaging="True" AutoGenerateRows="False"
                         DataKeyNames="CountryId" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                         BorderWidth="1px" Width="274px">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"/>
            <CommandRowStyle HorizontalAlign="Left"></CommandRowStyle>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"/>
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowInsertButton="True"
                                  ShowEditButton="True">
                </asp:CommandField>
                <asp:BoundField HeaderText="Country ID :" DataField="CountryId" ReadOnly="True"
                                InsertVisible="False">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Country Name :" DataField="CountryName">
                    <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Left"/>
                </asp:BoundField>
            </Fields>
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C"/>
            <FieldHeaderStyle HorizontalAlign="Right"></FieldHeaderStyle>
            <HeaderStyle HorizontalAlign="Right" BackColor="#4A3C8C" Font-Bold="True"
                         ForeColor="#F7F7F7">
            </HeaderStyle>
            <EditRowStyle HorizontalAlign="Left" BackColor="#738A9C" Font-Bold="True"
                          ForeColor="#F7F7F7">
            </EditRowStyle>
            <AlternatingRowStyle BackColor="#F7F7F7"/>
        </asp:DetailsView>
        <br/>
        <asp:ObjectDataSource ID="odsCountry" Runat="server"
                              TypeName="JobSite.BusinessObjectLayer.Country"
                              SelectMethod="GetCountries"
                              DataObjectTypeName="JobSite.BusinessObjectLayer.Country" DeleteMethod="Delete"
                              InsertMethod="Insert" UpdateMethod="Update">
        </asp:ObjectDataSource>
    </div>
</asp:Content>