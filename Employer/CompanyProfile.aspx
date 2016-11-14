<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="CompanyProfile.aspx.vb" Inherits="CompanyProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style13 {
            height: 26px;
            width: 237px;
        }

        .style16 { width: 237px; }

        .style18 { height: 13px; }

        .style19 { width: 532px; }

        .style20 {
            height: 16px;
            width: 674px;
        }

        .style21 {
            height: 17px;
            width: 530px;
        }

        .style22 {
            height: 17px;
            width: 674px;
        }

        .style23 {
            height: 18px;
            width: 532px;
        }

        .style24 {
            height: 18px;
            width: 674px;
        }

        .style25 {
            height: 16px;
            width: 530px;
        }

        .style27 {
            height: 40px;
            width: 530px;
        }

        .style28 {
            height: 40px;
            width: 674px;
        }

        .style29 {
            height: 43px;
            width: 530px;
        }

        .style30 {
            height: 43px;
            width: 674px;
        }

        .style31 {
            height: 29px;
            width: 530px;
        }

        .style32 {
            height: 29px;
            width: 674px;
        }

        .style33 {
            height: 22px;
            width: 530px;
        }

        .style34 {
            height: 22px;
            width: 674px;
        }

        .style35 {
            height: 14px;
            width: 532px;
        }

        .style36 {
            height: 14px;
            width: 674px;
        }

        .style37 {
            height: 9px;
            width: 532px;
        }

        .style38 {
            height: 9px;
            width: 674px;
        }

        .style39 {
            height: 24px;
            width: 530px;
        }

        .style40 {
            height: 24px;
            width: 674px;
        }

        .style41 {
            border-left-style: solid;
            border-left-width: 1px;
            height: 21px;
            padding: 1px 4px;
            text-align: left;
            width: 674px;
        }

        .style43 {
            height: 14px;
            text-align: left;
            width: 674px;
        }

        .style48 {
            height: 18px;
            text-align: left;
            width: 674px;
        }

        .style50 {
            height: 9px;
            text-align: left;
            width: 674px;
        }

        .style51 {
            height: 15px;
            width: 530px;
        }

        .style52 {
            height: 15px;
            text-align: left;
            width: 674px;
        }

        .style53 {
            height: 21px;
            width: 530px;
        }

        .style54 {
            height: 18px;
            width: 530px;
        }

        .style55 {
            height: 14px;
            width: 530px;
        }

        .style56 {
            height: 9px;
            width: 530px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<p>
    <asp:Label ID="lblCompanyProfile" runat="server"
               Style="text-align: center" Text="Your Company Profile" Font-Bold="True"
               Font-Size="Large">
    </asp:Label>
</p>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
<table style="height: 793px; width: 100%;">
<tr>
    <td align="left" colspan="2" valign="top" style="font-weight: bold">Your Name As The Company Representative</td>
</tr>
<tr>
    <td align="right" class="style25" valign="top">
        <asp:Label ID="lblFName" runat="server" Text="First Name :"></asp:Label>
    </td>
    <td align="left" class="style20">
        <asp:TextBox ID="txtFName" runat="server" Height="22px" Width="240px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                    ControlToValidate="txtFName" Display="Dynamic"
                                    ErrorMessage="Please enter your first name." Height="18px">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style54" valign="top">
        <asp:Label ID="lblMName" runat="server" Text="Middle Name :"></asp:Label>
    </td>
    <td align="left" class="style24">
        <asp:TextBox ID="txtMName" runat="server" Height="22px" Width="240px"></asp:TextBox>
    </td>
</tr>
<tr>
    <td align="right" class="style55" valign="top">
        <asp:Label ID="lblLName" runat="server" Text="Last Name :"></asp:Label>
    </td>
    <td align="left" class="style43">
        <asp:TextBox ID="txtLName" runat="server" Height="22px" Width="240px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                                    ControlToValidate="txtLName" Display="Dynamic"
                                    ErrorMessage="Please enter your last name">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="left" colspan="2" valign="top" style="font-weight: bold">
        <asp:Label ID="lblIntroduce" runat="server"
                   Text="Introduce Your Company">
        </asp:Label>
    </td>
</tr>
<tr>
    <td align="right" class="style55" valign="top">
        <asp:Label ID="lblCompanyName" runat="server" Text="Company Name :"></asp:Label>
    </td>
    <td align="left" class="style43">
        <asp:TextBox ID="txtCompanyName" runat="server" Width="240px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="txtCompanyName" Display="Dynamic"
                                    ErrorMessage="Please enter company name">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style27" valign="top">
        <asp:Label ID="lblProfile" runat="server" Text="Brief Profile :"></asp:Label>
    </td>
    <td align="left" class="style28">
        <asp:TextBox ID="txtProfile" runat="server" Rows="5" TextMode="MultiLine"
                     Width="350px">
        </asp:TextBox>
    </td>
</tr>
<tr>
    <td align="left" colspan="2" valign="top">
        <asp:Label ID="lblLocation" runat="server"
                   Text="Location" Font-Bold="True">
        </asp:Label>
    </td>
</tr>
<tr>
    <td align="right" class="style29" valign="top">
        <asp:Label ID="lblAddress1" runat="server" Text="Address 1 :"></asp:Label>
    </td>
    <td align="left" class="style30">
        <asp:TextBox ID="txtAddress1" runat="server" Height="50px" TextMode="MultiLine"
                     Width="250px">
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                    ControlToValidate="txtAddress1" Display="Dynamic"
                                    ErrorMessage="Please enter address">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style31" valign="top">
        <asp:Label ID="lblAddress2" runat="server" Text="Address 2 :"></asp:Label>
    </td>
    <td align="left" class="style32">
        <asp:TextBox ID="txtAddress2" runat="server" Height="50px" TextMode="MultiLine"
                     Width="250px">
        </asp:TextBox>
    </td>
</tr>
<tr>
    <td align="right" class="style33" valign="top">
        <asp:Label ID="lblCity" runat="server" Text="City :"></asp:Label>
    </td>
    <td align="left" class="style34">
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                    ControlToValidate="txtCity" Display="Dynamic"
                                    ErrorMessage="Please enter city">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style21" valign="top">
        <asp:Label ID="lblCountry" runat="server" Text="Country :"></asp:Label>
    </td>
    <td align="left" class="style22">
        <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True"
                          Height="19px" Width="218px">
        </asp:DropDownList>
    </td>
</tr>
<tr>
    <td align="right" class="style55" valign="top">
        <asp:Label ID="lblState" runat="server" Text="State/Province :"></asp:Label>
    </td>
    <td align="left" class="style36">
        <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True"
                          Height="19px" Width="218px">
        </asp:DropDownList>
    </td>
</tr>
<tr>
    <td align="right" class="style56" valign="top">
        <asp:Label ID="lblZIP" runat="server" Text="ZIP :"></asp:Label>
    </td>
    <td align="left" class="style38">
        <asp:TextBox ID="txtZIP" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                    ControlToValidate="txtZIP" Display="Dynamic"
                                    ErrorMessage="Please enter ZIP code">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="left" colspan="2" valign="top">
        <asp:Label ID="lblContactDetails" runat="server"
                   Text="Contact Details" Font-Bold="True">
        </asp:Label>
    </td>
</tr>
<tr>
    <td align="right" class="style39" valign="top">
        <asp:Label ID="lblPhone" runat="server" Text="Phone :"></asp:Label>
    </td>
    <td align="left" class="style40">
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label17" runat="server" Text="(e.g. 111-111-1111)"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                    ControlToValidate="txtProfile" Display="Dynamic"
                                    ErrorMessage="Please enter phone number">
            *
        </asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style51" valign="top">
        <asp:Label ID="lblFax" runat="server" Text="Fax :"></asp:Label>
    </td>
    <td align="left" class="style52">
        <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td align="right" class="style54" valign="top">
        <asp:Label ID="lblEmail" runat="server" Text="Email :"></asp:Label>
    </td>
    <td align="left" class="style48">
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                    ControlToValidate="txtEmail" Display="Dynamic"
                                    ErrorMessage="Please enter email address">
            *
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                        ControlToValidate="txtEmail" Display="Dynamic"
                                        ErrorMessage="Please enter valid email address"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            *
        </asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style53" valign="top">
        <asp:Label ID="lblWebsiteURL" runat="server" Text="Web Site :"></asp:Label>
    </td>
    <td align="left" class="style41">
        <asp:TextBox ID="txtWebSiteUrl" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="lbldomain" runat="server"
                   Text="(e.g. http://www.somedomain.com)">
        </asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"
                                        ControlToValidate="txtWebSiteUrl" Display="Dynamic"
                                        ErrorMessage="Please enter valid web site URL"
                                        ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">
            *
        </asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td align="right" class="style56" valign="top"></td>
    <td align="left" class="style50"></td>
</tr>
<tr>
    <td align="center" colspan="2" valign="top">
        <asp:Button ID="btnSave" runat="server" Height="22px" Text="Save"
                    Width="59px"/>
        &nbsp;
        <asp:Button ID="btnCancel" runat="server" Height="22px" Text="Cancel"/>
    </td>
</tr>
<tr>
    <td align="center" colspan="2" valign="top">
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                               Style="margin-bottom: 0px"/>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <asp:Image ID="Image1" runat="server"
                           ImageUrl="~/Images/Progress.gif"/>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </td>
</tr>
</table>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>