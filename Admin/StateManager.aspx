<%@ Page Title="" Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="StateManager.aspx.vb" Inherits="AdminStateManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        <br/>
        <asp:Label ID="lblState" Runat="server" Text="State Maintenance">
        </asp:Label>
        <br/>
        <br/>
        <asp:Label ID="lblCountry" runat="server" Text="Select Country:"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="ddlCountry" runat="server"
                          DataSourceID="odsCountry" DataTextField="CountryName"
                          DataValueField="CountryID" Height="20px" Width="200px">
        </asp:DropDownList>
        <br/>
        <br/>
        <asp:Button ID="btnOk" runat="server" Height="26px"
                    Text="Ok" Width="91px"/>
        <br/>
        <br/>
        <asp:DetailsView ID="dvState" Runat="server"
                         AllowPaging="True" AutoGenerateRows="False"
                         DataKeyNames="StateId" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                         BorderWidth="1px" Width="327px" DataSourceID="odsState">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"/>
            <CommandRowStyle HorizontalAlign="Left"></CommandRowStyle>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"/>
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowInsertButton="True"
                                  ShowEditButton="True">
                </asp:CommandField>
                <asp:BoundField HeaderText="State ID :" DataField="StateId" ReadOnly="True"
                                InsertVisible="False">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField DataField="CountryId" HeaderText="Country ID :">
                    <FooterStyle HorizontalAlign="Left"/>
                    <ItemStyle HorizontalAlign="Left"/>
                </asp:BoundField>
                <asp:BoundField HeaderText="State Name :" DataField="StateName">
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
                              SelectMethod="GetCountries">
        </asp:ObjectDataSource>

        <asp:ObjectDataSource ID="odsState" Runat="server"
                              TypeName="JobSite.BusinessObjectLayer.State"
                              SelectMethod="GetStates"
                              DataObjectTypeName="JobSite.BusinessObjectLayer.State" DeleteMethod="Delete"
                              InsertMethod="Insert" UpdateMethod="Update">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCountry" Name="countryid"
                                      PropertyName="SelectedValue" Type="Int32"/>
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>