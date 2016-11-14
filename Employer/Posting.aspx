<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="Posting.aspx.vb" Inherits="EmployerPosting" %>
<%@ Import Namespace="JobSite.BusinessObjectLayer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="height: 842px; text-align: center;">
<div align="center">
    <br/>
    <asp:Label ID="Label14" Runat="server" Text="Add / Edit Job Posting"></asp:Label>
</div>
<br/>
<asp:HyperLink ID="hlJobListing" Runat="server"
               NavigateUrl="~/Employer/JobPostings.aspx">
    View Your Job Listing
</asp:HyperLink>
<br/>
<asp:Label ID="Label6" runat="server" Text="(All the fields are mandatory)"></asp:Label>
<br/>
<br/>
<asp:Label ID="lblNote" runat="server" Height="19px" Width="390px">Note: Remove or delete job postings that are already closed.</asp:Label>
<br/>
<br/>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    <asp:DetailsView ID="dvJobPostings" Runat="server" AutoGenerateRows="False"
                     BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                     CellPadding="3" DataKeyNames="PostingID" DataSourceID="sdsJobPosting"
                     Height="46px" HorizontalAlign="Center" OnDataBound="dvJobPostings_DataBound"
                     OnItemDeleted="dvJobPostings_ItemDeleted"
                     OnItemInserted="dvJobPostings_ItemInserted"
                     OnItemUpdated="dvJobPostings_ItemUpdated" style="margin-left: 55px"
                     Width="58%">
        <FooterStyle BackColor="White" ForeColor="#000066"/>
        <rowstyle ForeColor="#000066" horizontalalign="Left"/>
        <fieldheaderstyle horizontalalign="Right" Wrap="false"/>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left"/>
        <fields>
            <asp:boundfield DataField="PostingID" HeaderText="Posting ID :"
                            InsertVisible="False" ReadOnly="True" SortExpression="PostingID">
                <headerstyle wrap="False"/>
                <itemstyle cssclass="dataentryformlabel" wrap="False"/>
            </asp:boundfield>
            <asp:boundfield DataField="Title" HeaderText="Job Title :"
                            SortExpression="Title"/>
            <asp:templatefield HeaderText="Contact Person :" SortExpression="ContactPerson">
                <edititemtemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%#
                Bind("ContactPerson")%>'>
                    </asp:TextBox>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%#
                Bind("ContactPerson")%>'>
                    </asp:TextBox>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label1" Runat="server" Text='<%#
                Bind("ContactPerson")%>'>
                    </asp:Label>
                </itemtemplate>
                <headerstyle cssclass="dataentryformlabel" wrap="False"/>
                <itemstyle wrap="False"/>
            </asp:templatefield>
            <asp:boundfield DataField="Department" HeaderText="Department :"
                            SortExpression="Department"/>
            <asp:boundfield DataField="JobCode" HeaderText="Job Code :"
                            SortExpression="JobCode"/>
            <asp:templatefield HeaderText="Country :" SortExpression="CountryID">
                <edititemtemplate>
                    <asp:DropDownList ID="ddlCountryUpdate" Runat="server" AutoPostBack="True"
                                      DataSourceID="odsCountry" DataTextField="CountryName"
                                      DataValueField="CountryID"
                                      OnSelectedIndexChanged="ddlCountryUpdate_SelectedIndexChanged"
                                      SelectedValue='<%#
                Bind("CountryID")%>'>
                    </asp:DropDownList>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:DropDownList ID="ddlCountryInsert" Runat="server" AutoPostBack="True"
                                      DataSourceID="odsCountry" DataTextField="CountryName"
                                      DataValueField="CountryID"
                                      OnSelectedIndexChanged="ddlCountryInsert_SelectedIndexChanged"
                                      SelectedValue='<%#
                Bind("CountryID")%>'>
                    </asp:DropDownList>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label2" Runat="server"
                               Text='<%#
                Country.GetCountryName(CType(Eval("CountryID"), integer))%>'>
                    </asp:Label>
                </itemtemplate>
            </asp:templatefield>
            <asp:templatefield HeaderText="State :" SortExpression="StateID">
                <edititemtemplate>
                    <asp:DropDownList ID="ddlStateUpdate" Runat="server" DataSourceID="odsState"
                                      DataTextField="StateName" DataValueField="StateID" Width="200px">
                    </asp:DropDownList>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:DropDownList ID="ddlStateInsert" Runat="server" DataSourceID="odsState"
                                      DataTextField="StateName" DataValueField="StateID" Width="200px">
                    </asp:DropDownList>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label3" Runat="server"
                               Text='<%#
                State.GetStateName(CType(Eval("StateID"), integer))%>'>
                    </asp:Label>
                </itemtemplate>
            </asp:templatefield>
            <asp:boundfield DataField="City" HeaderText="City :" SortExpression="City"/>
            <asp:templatefield HeaderText="Education Level :"
                               SortExpression="EducationLevelID">
                <edititemtemplate>
                    <asp:DropDownList ID="ddlEduLevelUpdate" Runat="server"
                                      DataSourceID="odsEducationLevel" DataTextField="EducationLevelName"
                                      DataValueField="EducationLevelID"
                                      SelectedValue='<%#
                Bind("EducationLevelID")%>'>
                    </asp:DropDownList>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:DropDownList ID="ddlEduLevelInsert" Runat="server"
                                      DataSourceID="odsEducationLevel" DataTextField="EducationLevelName"
                                      DataValueField="EducationLevelID"
                                      SelectedValue='<%#
                Bind("EducationLevelID")%>'>
                    </asp:DropDownList>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label4" Runat="server"
                               Text='<%#
                EducationLevel.GetEducationLevelName(
                    CType(Eval("EducationLevelID"), Integer))%>'>
                    </asp:Label>
                </itemtemplate>
                <headerstyle wrap="False"/>
                <itemstyle wrap="False"/>
            </asp:templatefield>
            <asp:templatefield HeaderText="Job Type :" SortExpression="JobTypeID">
                <edititemtemplate>
                    <asp:DropDownList ID="ddlJobTypeUpdate" Runat="server"
                                      DataSourceID="odsJobType" DataTextField="JobTypeName"
                                      DataValueField="JobTypeID" SelectedValue='<%#
                Bind("JobTypeID")%>'>
                    </asp:DropDownList>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:DropDownList ID="ddlJobTypeInsert" Runat="server"
                                      DataSourceID="odsJobType" DataTextField="JobTypeName"
                                      DataValueField="JobTypeID" SelectedValue='<%#
                Bind("JobTypeID")%>'>
                    </asp:DropDownList>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label5" Runat="server"
                               Text='<%#
                JobType.GetJobTypeName(CType(Eval("JobTypeID"), Integer))%>'>
                    </asp:Label>
                </itemtemplate>
            </asp:templatefield>
            <asp:templatefield HeaderText="Job Category :" SortExpression="JobCategoryID">
                <edititemtemplate>
                    <asp:DropDownList ID="ddlJobCategoryUpdate" Runat="server"
                                      DataSourceID="odsJobCategory" DataTextField="JobCategoryName"
                                      DataValueField="JobCategoryID" SelectedValue='<%#
                Bind("JobCategoryID")%>'>
                    </asp:DropDownList>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:DropDownList ID="ddlJobCategoryInsert" Runat="server"
                                      DataSourceID="odsJobCategory" DataTextField="JobCategoryName"
                                      DataValueField="JobCategoryID" SelectedValue='<%#
                Bind("JobCategoryID")%>'>
                    </asp:DropDownList>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label6" Runat="server"
                               Text='<%#
                JobCategory.GetJobCategoryName(CType(Eval("JobCategoryID"),
                                                     Integer))%>'>
                    </asp:Label>
                </itemtemplate>
            </asp:templatefield>
            <asp:boundfield DataField="MinSalary" HeaderText="Min Salary :"
                            SortExpression="MinSalary"/>
            <asp:boundfield DataField="MaxSalary" HeaderText="Max Salary :"
                            SortExpression="MaxSalary"/>
            <asp:templatefield HeaderText="Description :" SortExpression="JobDescription">
                <edititemtemplate>
                    <asp:TextBox ID="TextBox1" Runat="server" Rows="5"
                                 Text='<%#
                Bind("JobDescription")%>' TextMode="MultiLine" Width="98%">
                    </asp:TextBox>
                </edititemtemplate>
                <insertitemtemplate>
                    <asp:TextBox ID="TextBox4" Runat="server" Rows="5"
                                 Text='<%#
                Bind("JobDescription")%>' TextMode="MultiLine">
                    </asp:TextBox>
                </insertitemtemplate>
                <itemtemplate>
                    <asp:Label ID="Label7" Runat="server"
                               Text='<%#
                (Server.HtmlEncode(Eval("JobDescription").ToString())).Replace(vbCrLf, "<br>")%>'>
                    </asp:Label>
                </itemtemplate>
            </asp:templatefield>
            <asp:commandfield DeleteImageUrl="" EditImageUrl="" InsertImageUrl=""
                              NewImageUrl="" ShowDeleteButton="True" ShowEditButton="True"
                              ShowInsertButton="True" UpdateImageUrl="">
                <footerstyle horizontalalign="Center"/>
                <itemstyle horizontalalign="Center"/>
            </asp:commandfield>
        </fields>
        <headerstyle BackColor="#006699" Font-Bold="True" ForeColor="White"
                     horizontalalign="Right"/>
        <insertrowstyle horizontalalign="Left"/>
        <editrowstyle BackColor="#669999" Font-Bold="True" ForeColor="White"
                      horizontalalign="Left"/>
    </asp:DetailsView>
</ContentTemplate>
</asp:UpdatePanel>
<asp:UpdateProgress ID="UpdateProgress1" runat="server"
                    AssociatedUpdatePanelID="UpdatePanel1">
    <progresstemplate>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/progress.gif"/>
    </progresstemplate>
</asp:UpdateProgress>
<br/>
<asp:Label ID="lblError" runat="server" Height="19px" Width="252px"></asp:Label>
<br/>
<br/>
<asp:HyperLink ID="HyperLink1" Runat="server"
               NavigateUrl="~/Employer/JobPostings.aspx">
    Go to Listing Page
</asp:HyperLink>
<br/>
<asp:SqlDataSource ID="sdsJobPosting" runat="server"
                   ConnectionString="<%$ ConnectionStrings:JobSite %>"
                   DeleteCommand="JobPostings_Delete" DeleteCommandType="StoredProcedure"
                   InsertCommand="JobPostings_Insert" InsertCommandType="StoredProcedure"
                   SelectCommand="JobPostings_SelectOne" SelectCommandType="StoredProcedure"
                   UpdateCommand="JobPostings_Update" UpdateCommandType="StoredProcedure">
    <DeleteParameters>
        <asp:Parameter Name="PostingID" Type="Int32"/>
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="CompanyID" Type="Int32"/>
        <asp:Parameter Name="ContactPerson" Type="String"/>
        <asp:Parameter Name="Title" Type="String"/>
        <asp:Parameter Name="Department" Type="String"/>
        <asp:Parameter Name="JobCode" Type="String" DefaultValue=""/>
        <asp:Parameter Name="City" Type="String"/>
        <asp:Parameter Name="StateID" Type="Int32"/>
        <asp:Parameter Name="CountryID" Type="Int32"/>
        <asp:Parameter Name="EducationLevelID" Type="Int32"/>
        <asp:Parameter Name="JobTypeID" Type="Int32"/>
        <asp:Parameter Name="JobCategoryID" Type="Int32"/>
        <asp:Parameter Name="MinSalary" Type="Decimal" DefaultValue=""/>
        <asp:Parameter Name="MaxSalary" Type="Decimal" DefaultValue=""/>
        <asp:Parameter Name="JobDescription" Type="String"/>
        <asp:Parameter Name="PostingDate" Type="DateTime"/>
        <asp:Parameter Name="PostedBy" Type="String"/>
    </InsertParameters>
    <SelectParameters>
        <asp:QueryStringParameter Name="PostingID" QueryStringField="id" Type="Int32"/>
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="PostingID" Type="Int32"/>
        <asp:Parameter Name="CompanyID" Type="Int32"/>
        <asp:Parameter Name="ContactPerson" Type="String"/>
        <asp:Parameter Name="Title" Type="String"/>
        <asp:Parameter Name="Department" Type="String"/>
        <asp:Parameter Name="JobCode" Type="String"/>
        <asp:Parameter Name="City" Type="String"/>
        <asp:Parameter Name="StateID" Type="Int32"/>
        <asp:Parameter Name="CountryID" Type="Int32"/>
        <asp:Parameter Name="EducationLevelID" Type="Int32"/>
        <asp:Parameter Name="JobTypeID" Type="Int32"/>
        <asp:Parameter Name="JobCategoryID" Type="Int32"/>
        <asp:Parameter Name="MinSalary" Type="Decimal"/>
        <asp:Parameter Name="MaxSalary" Type="Decimal"/>
        <asp:Parameter Name="JobDescription" Type="String"/>
        <asp:Parameter Name="PostingDate" Type="DateTime"/>
        <asp:Parameter Name="PostedBy" Type="String"/>
    </UpdateParameters>
</asp:SqlDataSource>
<asp:ObjectDataSource ID="odsState" Runat="server" TypeName="JobSite.BusinessObjectLayer.State"
                      SelectMethod="GetStates">
    <SelectParameters>
        <asp:Parameter Type="Int32" Name="countryid"></asp:Parameter>
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCountry" Runat="server" TypeName="JobSite.BusinessObjectLayer.Country"
                      SelectMethod="GetCountries">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsEducationLevel" Runat="server"
                      SelectMethod="GetEducationLevels"
                      TypeName="JobSite.BusinessObjectLayer.EducationLevel">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsJobType" Runat="server" SelectMethod="GetJobTypes"
                      TypeName="JobSite.BusinessObjectLayer.JobType">
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsJobCategory" runat="server"
                      SelectMethod="GetJobCategories"
                      TypeName="JobSite.BusinessObjectLayer.JobCategory">
</asp:ObjectDataSource>
</div>
</asp:Content>