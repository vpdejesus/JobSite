<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="Articles.aspx.vb" Inherits="ArticlesArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    &nbsp;
    <p>
        Articles:
    </p>
    <p>
        <asp:HyperLink ID="hlWhatOnline" runat="server"
                       NavigateUrl="~/Articles/WhatOnline.aspx">
            What Online Job Sites Can Offer
        </asp:HyperLink>
    </p>
</asp:Content>