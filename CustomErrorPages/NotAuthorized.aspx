<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="NotAuthorized.aspx.vb" Inherits="CustomErrorPagesNotAuthorized" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br/>
        You are not authorized to view this page! <br/>
        <br/>
        You may not have appropriate access rights to view this page.
        <br/>
        <br/>
        For members, please login first for you to access the page. Go to the member&#39;s
        menu and login.
        <br/>
        <br/>
        <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="~/Default.aspx"
                       ForeColor="Blue" Font-Size="Small">
            Go to Home Page
        </asp:HyperLink>
    </div>
</asp:Content>