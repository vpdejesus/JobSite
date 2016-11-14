<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="ViewJobs.aspx.vb" Inherits="ViewJobs" title="View Jobs" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <div style="text-align: center; width: 458px;">
        <div align="center">
            <br/>
            <asp:Label ID="Label14" Runat="server" Text="View Job Posting"></asp:Label>
            <br/>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="margin-left: 46px; width: 163%;" cellpadding="3">
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="Label16" Runat="server" Text="Contact Details">
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style19">
                            <asp:Label ID="Label1" Runat="server" Text="Company :"></asp:Label>
                        </td>
                        <td align="left" class="style20">
                            <asp:Label ID="lblCompany" Runat="server" Text="Label"></asp:Label>
                            <asp:LinkButton ID="btnViewProfile" runat="server">[View Profile]</asp:LinkButton>
                            <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                                                    TargetControlID="btnViewProfile"
                                                    PopupControlID="Panel1"
                                                    DynamicControlID="Label20"
                                                    DynamicServicePath='<%#
                Page.ResolveClientUrl("~/WebService.asmx")%>'
                                                    DynamicServiceMethod="GetCompanyProfile"
                                                    OkControlID="LinkButton1">
                            </cc1:ModalPopupExtender>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style21">
                            <asp:Label ID="Label2" Runat="server" Text="Contact Person :"></asp:Label>
                        </td>
                        <td align="left" class="style22">
                            <asp:Label ID="lblContactPerson" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="Label17" Runat="server" Text="Job Details"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style23">
                            <asp:Label ID="Label3" Runat="server" Text="Job Title :"></asp:Label>
                        </td>
                        <td align="left" class="style51">
                            <asp:Label ID="lblTitle" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" nowrap valign="top" class="style25">
                            <asp:Label ID="Label13" Runat="server" Text="Description :"></asp:Label>
                        </td>
                        <td align="left" class="style26">
                            <asp:Label ID="lblDesc" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style27">
                            <asp:Label ID="Label9" Runat="server" Text="Job Type :"></asp:Label>
                        </td>
                        <td align="left" class="style28">
                            <asp:Label ID="lblJobType" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style31">
                            <asp:Label ID="Label4" Runat="server" Text="Department :"></asp:Label>
                        </td>
                        <td align="left" class="style32">
                            <asp:Label ID="lblDept" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style33">
                            <asp:Label ID="Label5" Runat="server" Text="Job Code :"></asp:Label>
                        </td>
                        <td align="left" class="style34">
                            <asp:Label ID="lblJobCode" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style35">
                            <asp:Label ID="Label10" Runat="server" Text="Education Level :">
                            </asp:Label>
                        </td>
                        <td align="left" class="style36">
                            <asp:Label ID="lblEduLevel" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="Label18" Runat="server" Text="Location"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style52">
                            <asp:Label ID="Label6" Runat="server" Text="City :"></asp:Label>
                        </td>
                        <td align="left" class="style37">
                            <asp:Label ID="lblCity" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style38">
                            <asp:Label ID="Label7" Runat="server" Text="State :"></asp:Label>
                        </td>
                        <td align="left" class="style39">
                            <asp:Label ID="lblState" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style40">
                            <asp:Label ID="Label8" Runat="server" Text="Country :"></asp:Label>
                        </td>
                        <td align="left" class="style41">
                            <asp:Label ID="lblCountry" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="Label19" Runat="server" Text="Salary Details">
                            </asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style23">
                            <asp:Label ID="Label11" Runat="server" Text="Min. Salary :"></asp:Label>
                        </td>
                        <td align="left" class="style51">
                            <asp:Label ID="lblMinSal" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style42">
                            <asp:Label ID="Label12" Runat="server" Text="Max. Salary :"></asp:Label>
                        </td>
                        <td align="left" class="style43">
                            <asp:Label ID="lblMaxSal" Runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style44">
                        </td>
                        <td align="left" class="style45">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style49">
                        </td>
                        <td align="left" class="style50">
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            &nbsp;<asp:Button ID="btnBack" runat="server" Height="26px" Text="Back"
                                              Width="79px"/>
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnAddFavorites" runat="server"
                                                                Text="Add To My Favorites" Height="26px"/>
                            &nbsp;&nbsp;
                            <asp:Button ID="btnApply" runat="server" Text="Apply"
                                        Height="26px" Width="89px"/>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="lblStatus" runat="server" ForeColor="#3366CC"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br/>
        <br/>
        <div align="left">
            <asp:Panel ID="Panel1" runat="server"
                       BackColor="#E9E9E9" Width="514px">
                <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
                <br/>
                <div align="right">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True">Close</asp:LinkButton>
                </div>
            </asp:Panel>
        </div>
        <br/>
        <br/>
    </div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style15 { width: 147px; }

        .style16 {
            height: 11px;
            width: 147px;
        }

        .style18 {
            height: 9px;
            width: 2028px;
        }

        .style19 {
            height: 24px;
            width: 38%;
        }

        .style20 {
            height: 24px;
            width: 287px;
        }

        .style21 {
            height: 10px;
            width: 38%;
        }

        .style22 {
            height: 10px;
            width: 287px;
        }

        .style23 {
            height: 16px;
            width: 38%;
        }

        .style25 {
            height: 23px;
            width: 38%;
        }

        .style26 {
            height: 23px;
            width: 287px;
        }

        .style27 {
            height: 28px;
            width: 38%;
        }

        .style28 {
            height: 28px;
            width: 287px;
        }

        .style31 {
            height: 9px;
            width: 38%;
        }

        .style32 {
            height: 9px;
            width: 287px;
        }

        .style33 {
            height: 15px;
            width: 38%;
        }

        .style34 {
            height: 15px;
            width: 287px;
        }

        .style35 {
            height: 12px;
            width: 38%;
        }

        .style36 {
            height: 12px;
            width: 287px;
        }

        .style37 {
            text-align: left;
            width: 287px;
        }

        .style38 {
            height: 7px;
            width: 38%;
        }

        .style39 {
            height: 7px;
            width: 287px;
        }

        .style40 {
            height: 19px;
            width: 38%;
        }

        .style41 {
            height: 19px;
            width: 287px;
        }

        .style42 {
            height: 8px;
            width: 38%;
        }

        .style43 {
            height: 8px;
            width: 287px;
        }

        .style44 {
            height: 2px;
            width: 38%;
        }

        .style45 {
            height: 2px;
            width: 287px;
        }

        .style49 {
            height: 1px;
            width: 38%;
        }

        .style50 {
            height: 1px;
            width: 287px;
        }

        .style51 {
            height: 16px;
            width: 287px;
        }

        .style52 { width: 2028px; }
    </style>
</asp:Content>