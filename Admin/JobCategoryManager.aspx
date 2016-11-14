<%@ Page Title="" Language="VB" MasterPageFile="~/AdminPage.master" AutoEventWireup="false" CodeFile="JobCategoryManager.aspx.vb" Inherits="AdminJobCategoryManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br/>
    <asp:Label ID="lblCategory" Runat="server" Text="Job Category Maintenance">
    </asp:Label>
    <br/>
    <br/>
    <asp:DetailsView ID="dvCategory" Runat="server" DataSourceID="odsCategory"
                     AllowPaging="True" AutoGenerateRows="False"
                     DataKeyNames="JobCategoryId" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                     BorderWidth="1px" Width="487px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"/>
        <CommandRowStyle HorizontalAlign="Left"></CommandRowStyle>
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"/>
        <Fields>
            <asp:CommandField ShowDeleteButton="True" ShowInsertButton="True"
                              ShowEditButton="True">
            </asp:CommandField>
            <asp:BoundField HeaderText="Job Category ID :" DataField="JobCategoryId" ReadOnly="True"
                            InsertVisible="False">
                <ItemStyle HorizontalAlign="Left"></ItemStyle>
                <HeaderStyle CssClass="dataentryformlabel"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField HeaderText="Job Category Name :" DataField="JobCategoryName">
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
    <asp:ObjectDataSource ID="odsCategory" Runat="server"
                          TypeName="JobSite.BusinessObjectLayer.JobCategory"
                          SelectMethod="GetJobCategories"
                          DataObjectTypeName="JobSite.BusinessObjectLayer.JobCategory"
                          DeleteMethod="Delete" InsertMethod="Insert" UpdateMethod="Update">
    </asp:ObjectDataSource>
</asp:Content>