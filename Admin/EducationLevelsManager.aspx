<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="EducationLevelsManager.aspx.vb" Inherits="EducationLevelsManager" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <div align="center">
        <br/>
        <asp:Label ID="Label14" Runat="server" Text="Education Levels Maintenance">
        </asp:Label>
        <br/>
        <br/>
        <asp:DetailsView ID="dvEducationLevel" Runat="server" DataSourceID="odsEducationLevel"
                         AllowPaging="True" AutoGenerateRows="False"
                         DataKeyNames="EducationLevelId" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                         BorderWidth="1px">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"/>
            <CommandRowStyle HorizontalAlign="Left"></CommandRowStyle>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"/>
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowInsertButton="True"
                                  ShowEditButton="True">
                </asp:CommandField>
                <asp:BoundField HeaderText="Education Level ID :" DataField="EducationLevelId" ReadOnly="True" InsertVisible="False">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Education Level Name :" DataField="educationlevelname">
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
        </asp:DetailsView><br/>
        <asp:ObjectDataSource ID="odsEducationLevel" Runat="server"
                              TypeName="JobSite.BusinessObjectLayer.EducationLevel"
                              SelectMethod="GetEducationLevels"
                              DataObjectTypeName="JobSite.BusinessObjectLayer.EducationLevel"
                              DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
        </asp:ObjectDataSource>
    </div>
</asp:Content>