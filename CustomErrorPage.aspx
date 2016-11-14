<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="CustomErrorPage.aspx.vb" Inherits="CustomErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14 { width: 451px; }

        .style8 {
            height: 199px;
            width: 430px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style8">
        <tr>
            <td class="style14">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="text-align: center" class="style14">
                Unexpected Error!!
            </td>
        </tr>
        <tr>
            <td class="style14">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>