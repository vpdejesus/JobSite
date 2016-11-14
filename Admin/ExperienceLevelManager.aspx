<%@ Page Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="ExperienceLevelManager.aspx.vb" Inherits="ExperienceLevelManagerAspx" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <div align="center">
        <br/>
        <asp:Label ID="Label14" Runat="server" Text="Experience Levels Maintenance">
        </asp:Label><br/>
        <br/>
        <asp:DetailsView ID="dvExperienceLevel" Runat="server" DataSourceID="odsExperienceLevel"
                         AllowPaging="True" AutoGenerateRows="False" GridLines="Horizontal"
                         CellPadding="3" DataKeyNames="ExperienceLevelId"
                         BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"/>
            <CommandRowStyle HorizontalAlign="Left"></CommandRowStyle>
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"/>
            <Fields>
                <asp:CommandField ButtonType="Link" ShowDeleteButton="True" ShowInsertButton="True"
                                  ShowEditButton="True">
                </asp:CommandField>
                <asp:BoundField ReadOnly="True" HeaderText="Experience Level ID :" InsertVisible="False"
                                DataField="ExperienceLevelId">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Experience Level Name :" DataField="experiencelevelname">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
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
        <asp:ObjectDataSource ID="odsExperienceLevel" Runat="server"
                              TypeName="JobSite.BusinessObjectLayer.ExperienceLevel"
                              SelectMethod="GetExperienceLevels" DataObjectTypeName="JobSite.BusinessObjectLayer.ExperienceLevel"
                              DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
        </asp:ObjectDataSource>
    </div>
</asp:Content>