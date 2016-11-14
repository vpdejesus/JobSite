<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Statistics.ascx.vb" Inherits="Statistics" %>
<style type="text/css">
    .style2 {
        height: 9px;
        text-align: center;
        width: 21%;
    }

    .style3 {
        height: 31px;
        text-align: center;
        width: 21%;
    }

    .style6 {
        height: 9px;
        text-align: center;
        width: 17%;
    }

    .style7 {
        height: 31px;
        text-align: center;
        width: 17%;
    }

    .style8 {
        height: 9px;
        text-align: center;
        width: 19%;
    }

    .style9 {
        height: 31px;
        text-align: center;
        width: 19%;
    }
</style>
<table cellspacing="0" cellpadding="5" border="1"
       style="height: 65px; width: 383px">
    <tr>
        <td nowrap="nowrap" align="center" colspan="3">
            <asp:Label ID="lblStat" Text="WTJ Statistics" Runat="server" SkinID="FormLabel"
                       Font-Bold="True" ForeColor="#0066FF">
            </asp:Label>
        </td>
    </tr>
    <tr>
        <td nowrap="nowrap" class="style6">
            <asp:Label ID="lblJob" Text="Total Jobs " Runat="server"></asp:Label>
        </td>
        <td class="style2">
            <asp:Label ID="lblResume" Text="Total Resumes" Runat="server"></asp:Label>
        </td>
        <td class="style8">
            <asp:Label ID="lblCompany" Text="Total Companies" Runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td nowrap="nowrap" class="style7">
            <asp:Label ID="lblJobs" Text="Label" Runat="server" SkinID="FormLabel"
                       ForeColor="#003300">
            </asp:Label>
        </td>
        <td class="style3">
            <asp:Label ID="lblResumes" Text="Label" Runat="server" SkinID="FormLabel"
                       ForeColor="#003366">
            </asp:Label>
        </td>
        <td class="style9">
            <asp:Label ID="lblCompanies" Text="Label" Runat="server" SkinID="FormLabel"></asp:Label>
        </td>
    </tr>
</table>