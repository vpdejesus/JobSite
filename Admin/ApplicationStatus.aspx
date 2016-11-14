<%@ Page Title="" Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="ApplicationStatus.aspx.vb" Inherits="AdminApplicationStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: left">
        <br/>
        <asp:Label ID="lblStatus" Runat="server"
                   Text="Application Status Maintenance">
        </asp:Label>
        <br/>
        <br/>
        <asp:DetailsView ID="dvStatus" Runat="server" DataSourceID="odsStatus"
                         AllowPaging="True" AutoGenerateRows="False"
                         DataKeyNames="AppStatusId" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                         BorderWidth="1px" Width="258px">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"/>
            <CommandRowStyle HorizontalAlign="Left"></CommandRowStyle>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"/>
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowInsertButton="True"
                                  ShowEditButton="True">
                </asp:CommandField>
                <asp:BoundField HeaderText="Status ID :" DataField="AppStatusId"
                                ReadOnly="True" InsertVisible="False">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Status Name :" DataField="AppStatus">
                    <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
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
        <asp:ObjectDataSource ID="odsStatus" Runat="server"
                              TypeName="JobSite.BusinessObjectLayer.ApplicationStatus"
                              SelectMethod="GetAllStatus"
                              DataObjectTypeName="JobSite.BusinessObjectLayer.ApplicationStatus"
                              DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
        </asp:ObjectDataSource>
    </div>
</asp:Content>