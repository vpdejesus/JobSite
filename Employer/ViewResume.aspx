<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="viewresume.aspx.vb" Inherits="Viewresume" title="Resume View" %>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style16 { width: 741px; }

        .style18 {
            height: 31px;
            text-align: left;
        }

        .style20 {
            height: 8px;
            text-align: left;
        }

        .style21 {
            height: 4px;
            text-align: left;
        }

        .style23 {
            height: 9px;
            text-align: left;
        }

        .style24 {
            height: 15px;
            text-align: left;
        }

        .style25 {
            border-top-width: 2px;
            height: 53px;
            text-align: left;
        }

        .style26 {
            height: 52px;
            text-align: left;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <table style="height: 312px; margin-left: 0px; width: 895px;">
        <tr>
            <td class="style25">
                <asp:Label ID="lblComplete" Runat="server" Text="Complete Resume of Job Seeker"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style20">
                <asp:Image ID="imgPhoto" runat="server" Height="162px" Width="143px"
                           ImageAlign="Left" BorderColor="#339933" BorderStyle="Solid"
                           style="margin-left: 0px"/>
            </td>
        </tr>
        <tr>
            <td class="style20">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style21">
                <asp:Label ID="lblName" Runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEducation" Runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style23">
                <asp:Label ID="lblExperience" Runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style24">
                <asp:TextBox ID="txtResume" runat="server" Height="451px"
                             style="text-align: left" TextMode="MultiLine" Width="859px">
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style26">
                <asp:Button ID="btnBack" runat="server" Height="26px" Text="Back"
                            Width="71px"/>
                &nbsp;
                <asp:Button ID="btnAdd" runat="server" Text="Add To My Favorites"
                            Width="153px" Height="26px"/>
                &nbsp;
                <asp:Button ID="btnContact" runat="server" Text="Contact Job Seeker"
                            Height="26px"/>
            </td>
        </tr>
    </table>
</asp:Content>