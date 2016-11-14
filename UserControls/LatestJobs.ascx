<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LatestJobs.ascx.vb" Inherits="LatestJobs" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
    <Services>
        <asp:ServiceReference Path="~/webservice.asmx"/>
    </Services>
</asp:ScriptManagerProxy>

<asp:GridView ID="gvLatestJobs" runat="server" DataSourceID="odsLatestJobs" AllowPaging="True"
              AutoGenerateColumns="False" Width="100%" DataKeyNames="PostingID"
              OnRowDataBound="gvLatestJobs_RowDataBound">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server"
                                 ImageUrl="~/images/showdetails.jpg" ToolTip="Click here for more details"/>
                <asp:Panel ID="pnlMsg" runat="server"></asp:Panel>
                <cc1:PopupControlExtender ID="PopupControlExtender1" runat="server"
                                          DynamicContextKey='<%#
                Eval("PostingId")%>' DynamicControlID="Panel1"
                                          DynamicServiceMethod="GetToolTipText"
                                          PopupControlID="Panel1" TargetControlID="ImageButton1" Position="Left">
                </cc1:PopupControlExtender>
            </ItemTemplate>
            <ItemStyle VerticalAlign="Top" Width="5%"/>
        </asp:TemplateField>
        <asp:HyperLinkField HeaderText="Latest Jobs!!" NavigateUrl="~/JobSeeker/ViewJobs.aspx?id="
                            DataNavigateUrlFields="postingid" DataNavigateUrlFormatString="~/JobSeeker/ViewJobs.aspx?id={0}"
                            DataTextField="Title">
            <ItemStyle HorizontalAlign="Left"/>
        </asp:HyperLinkField>
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="odsLatestJobs" runat="server" TypeName="JobSite.BusinessObjectLayer.JobPosting"
                      SelectMethod="GetLatest">
</asp:ObjectDataSource>
<asp:Panel ID="Panel1" runat="server"
           SkinID="TooltipPanel" HorizontalAlign="Left">
</asp:Panel>