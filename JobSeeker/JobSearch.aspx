<%@ Page Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="JobSearch.aspx.vb" Inherits="Jobsearch" title="Search Jobs" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <div align="center" style="width: 854px">
        <br/>
        <asp:Label ID="lblSearchJobs" Runat="server" Text="Search Jobs!!!"></asp:Label>
        <br/>
        <asp:Label ID="lblJobCount" Runat="server"></asp:Label><br/>
        <br/>
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br/>
            <table style="width: 103%">
                <tr>
                    <td align="right" valign="top" class="style22">
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblSkills" Runat="server" Text="Skills :"></asp:Label>
                    </td>
                    <td align="left" class="style23">
                        <asp:TextBox ID="txtSkills" Runat="server" Width="150px"
                                     style="margin-left: 0px">
                        </asp:TextBox>
                        &nbsp;(Ex.: Software Developer, Tech Support, etc.)
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style24" valign="top">
                        Category:
                    </td>
                    <td align="left" class="style25">
                        <asp:DropDownList ID="ddlCategory" Runat="server" AutoPostBack="True"
                                          Height="23px" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"
                                          Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" valign="top" class="style26">
                        <asp:Label ID="lblCountry" Runat="server" Text="Country :"></asp:Label>
                    </td>
                    <td align="left" class="style27">
                        <asp:DropDownList ID="ddlCountry" Runat="server" AutoPostBack="True"
                                          Height="23px" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"
                                          Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" valign="top" class="style28">
                        <asp:Label ID="lblState" Runat="server" Text="State :"></asp:Label>
                    </td>
                    <td align="left" class="style29">
                        <asp:DropDownList ID="ddlState" Runat="server" AutoPostBack="True"
                                          onselectedindexchanged="ddlState_SelectedIndexChanged" Width="150px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" valign="top" class="style30">
                        <asp:Label ID="lblCity" Runat="server" Text="City :"></asp:Label>
                    </td>
                    <td align="left" class="style31">
                        <asp:TextBox ID="txtCity" Runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" valign="top">
                        <asp:Button ID="btnSearch" runat="server" Text="Search"/>
                        &nbsp;
                        <asp:Button ID="btnAdd" runat="server" Text="Add to my favorites"/>
                        <br/>
                        <br/>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="2" valign="top">
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server"
                        AssociatedUpdatePanelID="UpdatePanel1">
        <progresstemplate>
            <center>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/progress.gif"/>
            </center>
        </progresstemplate>
    </asp:UpdateProgress>
    <br/>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <contenttemplate>
            <asp:GridView ID="gvJobSearch" Runat="server" AllowPaging="True"
                          AutoGenerateColumns="False" DataKeyNames="PostingID"
                          OnPageIndexChanging="gvJobSearch_PageIndexChanging"
                          OnRowCommand="gvJobSearch_RowCommand" OnRowDataBound="gvJobSearch_RowDataBound"
                          PageSize="3" Width="100%">
                <columns>
                    <asp:templatefield HeaderText="Date">
                        <edititemtemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%#
                Bind("PostingDate")%>'>
                            </asp:TextBox>
                        </edititemtemplate>

                        <itemtemplate>
                            <asp:Label ID="Label1" runat="server"
                                       Text='<%#
                Bind("PostingDate", "{0:MM/dd/yyyy}")%>'>
                            </asp:Label>
                        </itemtemplate>
                    </asp:templatefield>
                    <asp:boundfield DataField="Title" HeaderText="Title" SortExpression="title">
                    </asp:boundfield>
                    <asp:boundfield DataField="City" HeaderText="Location" SortExpression="city">
                    </asp:boundfield>
                    <asp:boundfield DataField="companyname" HeaderText="Company" ShowHeader="False"
                                    SortExpression="companyname">
                    </asp:boundfield>
                    <asp:buttonfield CommandName="viewdetails" ButtonType="Image"
                                     ImageUrl="~/Images/showdetails.jpg" HeaderText="View">
                    </asp:buttonfield>
                </columns>
            </asp:GridView>
        </contenttemplate>
    </asp:UpdatePanel>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style15 {
            height: 34px;
            width: 150px;
        }

        .style18 { width: 329px; }

        .style19 { width: 322px; }

        .style22 {
            height: 15px;
            width: 143px;
        }

        .style23 { height: 15px; }

        .style24 {
            height: 6px;
            width: 143px;
        }

        .style25 { height: 6px; }

        .style26 {
            height: 1px;
            width: 143px;
        }

        .style27 { height: 1px; }

        .style28 {
            height: 9px;
            width: 143px;
        }

        .style29 { height: 9px; }

        .style30 {
            height: 4px;
            width: 143px;
        }

        .style31 { height: 4px; }
    </style>
</asp:Content>