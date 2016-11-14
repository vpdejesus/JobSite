<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="ChangePassword.aspx.vb" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style15 {
            height: 51px;
            width: 2390px;
        }

        .style16 { width: 2390px; }

        .style18 {
            height: 67px;
            width: 2675px;
        }

        .style19 {
            height: 22px;
            width: 2675px;
        }

        .style20 {
            height: 118px;
            text-align: left;
            width: 2675px;
        }

        .style8 {
            height: 244px;
            width: 715px;
        }

        .style21 {
            border-top-width: 2px;
            height: 45px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style8">
        <tr>
            <td class="style21">
                You can change your password here. Just fill in your current password and enter
                your new password for changes.<br/>
                <br/>
            </td>
        </tr>
        <tr>
            <td class="style20">
                <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F7DE"
                                    BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px"
                                    Font-Names="Verdana" Font-Size="10pt">
                    <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF"/>
                </asp:ChangePassword>
            </td>
        </tr>
    </table>
</asp:Content>