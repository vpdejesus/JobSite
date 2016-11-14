<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="PostResume.aspx.vb" Inherits="PostResume" Title="Resume Posting" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<style type="text/css">
    .style11 { color: #000000; }

    .style8 {
        height: 1151px;
        margin-left: 0px;
        width: 98%;
    }

    .style93 {
        height: 37px;
        text-align: right;
        width: 3490px;
    }

    .style94 {
        height: 30px;
        text-align: left;
    }

    .style23 {
        height: 37px;
        text-align: left;
    }

    .style32 {
        height: 19px;
        text-align: right;
        width: 3490px;
    }

    .style34 {
        height: 19px;
        text-align: left;
    }

    .style50 {
        height: 12px;
        text-align: right;
        width: 3490px;
    }

    .style49 {
        height: 12px;
        text-align: left;
    }

    .style109 {
        height: 10px;
        text-align: right;
        width: 3490px;
    }

    .style110 {
        height: 6px;
        text-align: right;
        width: 3490px;
    }

    .style100 {
        height: 6px;
        text-align: left;
    }

    .style111 {
        height: 16px;
        text-align: right;
        width: 3490px;
    }

    .style97 {
        height: 16px;
        text-align: left;
    }

    .style112 {
        height: 15px;
        text-align: right;
        width: 3490px;
    }

    .style98 {
        height: 15px;
        text-align: left;
    }

    .style63 {
        height: 18px;
        text-align: right;
        width: 3490px;
    }

    .style65 {
        height: 18px;
        text-align: left;
    }

    .style66 {
        height: 9px;
        text-align: right;
        width: 3490px;
    }

    .style68 {
        height: 9px;
        text-align: left;
    }

    .style24 {
        height: 24px;
        text-align: right;
        width: 3490px;
    }

    .style25 {
        height: 24px;
        text-align: left;
    }

    .style69 {
        height: 8px;
        text-align: right;
        width: 3490px;
    }

    .style71 {
        height: 8px;
        text-align: left;
    }

    .style72 {
        height: 5px;
        text-align: right;
        width: 3490px;
    }

    .style74 {
        height: 5px;
        text-align: left;
    }

    .style75 {
        height: 13px;
        text-align: right;
        width: 3490px;
    }

    .style77 {
        height: 13px;
        text-align: left;
    }

    .style78 {
        height: 17px;
        text-align: right;
        width: 3490px;
    }

    .style80 {
        height: 17px;
        text-align: left;
    }

    .style81 {
        height: 51px;
        text-align: right;
        width: 3490px;
    }

    .style83 {
        height: 51px;
        text-align: left;
    }

    .style84 {
        height: 7px;
        text-align: right;
        width: 3490px;
    }

    .style86 {
        height: 7px;
        text-align: left;
    }

    .style88 {
        height: 38px;
        text-align: right;
        width: 3490px;
    }

    .style90 {
        height: 38px;
        text-align: left;
    }

    .style91 {
        height: 49px;
        text-align: right;
        width: 3490px;
    }

    .style92 {
        height: 49px;
        text-align: left;
    }

    .style43 {
        height: 49px;
        text-align: center;
    }

    .style40 {
        height: 11px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<p style="height: 22px; text-align: center; width: 890px;">
    &nbsp;
</p>
<p style="height: 22px; text-align: center; width: 883px;">
    <span class="style11" style="font-size: large; font-weight: bold">Post Your Resume</span>
</p>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
<table class="style8">
<tr>
    <td class="style93">Photo:</td>
    <td class="style94">
        <div style="height: 195px; width: 598px;">
            <asp:Image ID="imgPhoto" runat="server" BorderColor="#339933"
                       BorderStyle="Solid" Height="162px" ImageAlign="Left" Width="143px"/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <br/>
            <asp:ImageButton ID="imgbtnDelete" runat="server" BorderStyle="Solid"
                             Height="32px" ImageAlign="Left" ImageUrl="~/Images/Delete.png"
                             ToolTip="Delete or change your photo" Width="28px"/>
            &nbsp;
            <br/>
            <br/>
            <asp:FileUpload ID="fuPhoto" runat="server" Height="23px" Width="223px"/>
            <asp:Button ID="btnUpload" runat="server" Height="23px"
                        Style="margin-bottom: 0px" Text="Upload &amp; Attach Photo" Width="157px"/>
        </div>
    </td>
    <td class="style23"></td>
</tr>
<tr>
    <td class="style32"></td>
    <td class="style34">
        <asp:Label ID="lblUpload" runat="server" ForeColor="#0033CC"></asp:Label>
    </td>
    <td class="style34"></td>
</tr>
<tr>
    <td class="style50" style="font-weight: bold">Personal Profile</td>
    <td class="style49"></td>
    <td class="style49"></td>
</tr>
<tr>
    <td class="style109">Job Title:</td>
    <td class="style12">
        <asp:TextBox ID="txtJobTitle" runat="server" Width="237px"></asp:TextBox>
    </td>
    <td class="style12"></td>
</tr>
<tr>
    <td class="style110">First Name:</td>
    <td class="style100">
        <asp:TextBox ID="txtFName" runat="server" Width="237px"></asp:TextBox>
    </td>
    <td class="style100"></td>
</tr>
<tr>
    <td class="style111">Middle Name:</td>
    <td class="style97">
        <asp:TextBox ID="txtMName" runat="server" Width="237px"></asp:TextBox>
    </td>
    <td class="style97"></td>
</tr>
<tr>
    <td class="style112">Last Name:</td>
    <td class="style98">
        <asp:TextBox ID="txtLName" runat="server" Width="237px"></asp:TextBox>
    </td>
    <td class="style98"></td>
</tr>
<tr>
    <td class="style63">Position Desired:</td>
    <td class="style65">
        <asp:TextBox ID="txtPositionDesired" runat="server" Width="238px"></asp:TextBox>
    </td>
    <td class="style65"></td>
</tr>
<tr>
    <td class="style66">Age:</td>
    <td class="style68">
        <asp:TextBox ID="txtAge" runat="server" Width="100px"></asp:TextBox>
    </td>
    <td class="style68"></td>
</tr>
<tr>
    <td class="style24">Sex:</td>
    <td class="style25">
        <asp:DropDownList ID="ddlSex" runat="server" Height="22px" Width="101px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
    </td>
    <td class="style25"></td>
</tr>
<tr>
    <td class="style69">Birth Date:</td>
    <td class="style71">
        <asp:TextBox ID="txtBirthDate" runat="server" Height="18px" Width="149px"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="calendarButtonExtender" runat="server"
                                      PopupButtonID="imgbtnCalendar" PopupPosition="BottomRight"
                                      TargetControlID="txtBirthDate"/>
        <asp:ImageButton ID="imgbtnCalendar" runat="server"
                         AlternateText="Click to show calendar" ImageUrl="~/Images/Calendar.png"/>
    </td>
    <td class="style71"></td>
</tr>
<tr>
    <td class="style72" style="font-weight: bold">Contact Information</td>
    <td class="style74"></td>
    <td class="style74"></td>
</tr>
<tr>
    <td class="style112">
        Email Address:
    </td>
    <td class="style98">
        <asp:TextBox ID="txtEmail" runat="server" Width="238px"></asp:TextBox>
    </td>
    <td class="style98"></td>
</tr>
<tr>
    <td class="style75">
        Mobile Number:
    </td>
    <td class="style77">
        <asp:TextBox ID="txtMobile" runat="server" Width="238px"></asp:TextBox>
    </td>
    <td class="style77"></td>
</tr>
<tr>
    <td class="style78">Telephone Number:</td>
    <td class="style80">
        <asp:TextBox ID="txtTelNo" runat="server" Width="238px"></asp:TextBox>
    </td>
    <td class="style80"></td>
</tr>
<tr>
    <td class="style81">Address:</td>
    <td class="style83">
        <asp:TextBox ID="txtAddress" runat="server" Height="64px" TextMode="MultiLine"
                     Width="238px">
        </asp:TextBox>
    </td>
    <td class="style83"></td>
</tr>
<tr>
    <td class="style112">City:</td>
    <td class="style98">
        <asp:TextBox ID="txtCity" runat="server" Width="238px"></asp:TextBox>
    </td>
    <td class="style98"></td>
</tr>
<tr>
    <td class="style109">Country:</td>
    <td class="style12">
        <asp:DropDownList ID="ddlCountry" runat="server" Height="21px" Width="243px">
        </asp:DropDownList>
    </td>
    <td class="style12"></td>
</tr>
<tr>
    <td class="style84">State/Province:</td>
    <td class="style86">
        <asp:DropDownList ID="ddlState" runat="server" Height="21px" Width="243px">
        </asp:DropDownList>
    </td>
    <td class="style86"></td>
</tr>
<tr>
    <td class="style112" style="font-weight: bold">Education and Experience</td>
    <td class="style98"></td>
    <td class="style98"></td>
</tr>
<tr>
    <td class="style112">Education Level:</td>
    <td class="style98">
        <asp:DropDownList ID="ddlEducationLevel" runat="server" Height="21px"
                          Width="243px">
        </asp:DropDownList>
    </td>
    <td class="style98"></td>
</tr>
<tr>
    <td class="style109">Experience Level:</td>
    <td class="style12">
        <asp:DropDownList ID="ddlExperienceLevel" runat="server" Height="21px"
                          Width="243px">
        </asp:DropDownList>
    </td>
    <td class="style12"></td>
</tr>
<tr>
    <td class="style88" style="font-weight: bold">Resume</td>
    <td class="style90"></td>
    <td class="style90"></td>
</tr>
<tr>
    <td class="style91">Resume:</td>
    <td class="style92">
        <asp:TextBox ID="txtResume" runat="server" Height="215px" TextMode="MultiLine"
                     Width="623px">
        </asp:TextBox>
    </td>
    <td class="style43"></td>
</tr>
<tr>
    <td class="style111"></td>
    <td class="style97"></td>
    <td class="style97"></td>
</tr>
<tr>
    <td class="style110">
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="75px"/>
    </td>
    <td class="style100">
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="75px"/>
    </td>
    <td class="style100"></td>
</tr>
<tr>
    <td class="style40" colspan="2">
        <asp:Label ID="lblMsg" runat="server" ForeColor="Blue"></asp:Label>
    </td>
    <td class="style40"></td>
</tr>
</table>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>