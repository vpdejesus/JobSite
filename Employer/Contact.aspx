<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="Contact.aspx.vb" Inherits="EmployerContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style15 {
            height: 430px;
            width: 20%;
        }

        .style16 { color: #000000; }

        .style20 { width: 169px; }

        .style22 { width: 189px; }

        .style23 { width: 1001px; }

        .style24 {
            height: 70px;
            width: 100%;
        }

        .style25 {
            height: 456px;
            width: 1001px;
        }

        .style26 { height: 80px; }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br/>
            <div style="height: 93px">
                <!-- Begin BidVertiser code -->
                <script language="JavaScript1.1"
                        src="http://bdv.bidvertiser.com/BidVertiser.dbm?pid=246327&amp;bid=810792"
                        type="text/javascript">
                </script>
                <noscript>
                    <a href="http://www.bidvertiser.com">internet advertising</a>
                </noscript>
                <!-- End BidVertiser code -->
            </div>
            <br/>

            <table class="style15">
                <tr>
                    <td class="style25">
                        <asp:Panel ID="PanelContact" runat="server" BorderColor="Chartreuse"
                                   BorderStyle="Ridge" BorderWidth="2px" Height="469px" Width="650px">
                            <table class="style24">
                                <tr>
                                    <td style="text-align: justify" class="style26">
                                        <span class="style16">
                                        <br />
                                        You can contact this job seeker using the built-in email features of World&#39;s Top 
                                        Jobs. Please don&#39;t forget to put your contact information on your message&nbsp;area&nbsp; 
                                        for job seekers to contact you directly. Your email will be sent by World&#39;s Top 
                                        Job.</span></td>
                                </tr>
                            </table>
                            <span class="style16">
                            <br />
                            </span><span style="color: mediumblue;">
                            <br />
                            <table style="font-family: Comic Sans MS; font-size: 9pt; width: 610px;">
                                <tr>
                                    <td style="text-align: right; width: 63px;">
                                        <asp:Label ID="lblEmail" runat="server" Font-Names="Comic Sans MS" 
                                            Font-Size="9pt" Text="* Email From:" Width="83px"></asp:Label>
                                    </td>
                                    <td class="style22">
                                        <asp:TextBox ID="txtEmailFrom" runat="server" Width="272px"></asp:TextBox>
                                    </td>
                                    <td class="style20">
                                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" BorderStyle="None" 
                                            ControlToValidate="txtEmailFrom" ErrorMessage="Your email must not be blank!" 
                                            SetFocusOnError="True" Width="217px"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right; width: 63px;">
                                        <span style="color: mediumblue;">
                                        <asp:Label ID="lblTo" runat="server" Font-Names="Comic Sans MS" Font-Size="9pt" 
                                            Text="* Email To:" Width="83px"></asp:Label>
                                        </span>
                                    </td>
                                    <td class="style22">
                                        <span style="color: mediumblue;">
                                        <asp:TextBox ID="txtEmailTo" runat="server" Width="272px"></asp:TextBox>
                                        </span>
                                    </td>
                                    <td class="style20">
                                        <span style="color: mediumblue;">
                                        <asp:RequiredFieldValidator ID="rfvJobSeeker" runat="server" BorderStyle="None" 
                                            ControlToValidate="txtEmailTo" ErrorMessage="Job Seeker's email must not be blank!" 
                                            SetFocusOnError="True" Width="223px"></asp:RequiredFieldValidator>
                                        </span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right; width: 63px;">
                                        <asp:Label ID="lblSubject" runat="server" Font-Names="Comic Sans MS" 
                                            Font-Size="9pt" Text="* Subject:" Width="83px"></asp:Label>
                                    </td>
                                    <td class="style22">
                                        <asp:TextBox ID="txtSubject" runat="server" Width="272px"></asp:TextBox>
                                    </td>
                                    <td class="style20">
                                        <asp:RequiredFieldValidator ID="rfvSubject" runat="server" BorderStyle="None" 
                                            ControlToValidate="txtSubject" ErrorMessage="Please enter subject." 
                                            SetFocusOnError="True" Width="152px"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 106px; text-align: right; vertical-align: top; width: 63px;">
                                        <asp:Label ID="lblMessage" runat="server" Font-Names="Comic Sans MS" 
                                            Font-Size="9pt" Text="* Message:" Width="83px"></asp:Label>
                                    </td>
                                    <td colspan="2" style="height: 106px">
                                        <asp:TextBox ID="txtBody" runat="server" Height="135px" TextMode="MultiLine" 
                                            Width="506px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="height: 14px; vertical-align: top;">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Button ID="cmdSend" runat="server" onclick="cmdSend_Click" Text="Send" 
                                            Width="72px" Height="26px" />
                                              &nbsp;
                                        <asp:Button ID="cmdClear" runat="server" Height="26px" onclick="cmdClear_Click" 
                                            Text="Clear" Width="80px" />
                                    </td>
                                    <td colspan="1" class="style20">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="height: 19px">
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="height: 17px">
                                        <asp:Label ID="lblMess" runat="server" Font-Size="Small" ForeColor="Blue" 
                                            Width="520px"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            </span>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="style23">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>