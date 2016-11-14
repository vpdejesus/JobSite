<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br/>
    <div style="height: 94px; width: 799px;">
        Below you can sign for a new World&#39;s Top Jobs account. If you already have an
        account, you can login straight away.<br/>
        <br/>
        Forgot your password or keep forgetting your current one? No problem; you can request
        a new password or change
        <br/>
        your existing at the bottom of this page.<br/>
        <br/>
    </div>

    <asp:Login ID="liBox" runat="server" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px"
               Font-Names="Verdana" Font-Size="10pt" Width="289px">
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF"/>
    </asp:Login>

    &nbsp;New User? Please click the link for registration&nbsp;&nbsp; ---&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Click here</asp:HyperLink>

    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BorderColor="#CCCC99"
                          BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" SuccessText="Your password has been sent to your email address."
                          Width="291px">
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF"/>
    </asp:PasswordRecovery>
    <br/>
    <br/>
    <div style="height: 290px">
        <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" id="color test" width="336"
                codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0"
                height="280" align="middle">
            <param name="allowScriptAccess" value="sameDomain"/>
            <param name="wmode" value="transparent"/>
            <param name="movie" value="http://img.tradepub.com/images/bimages/336x280catstatic.swf?ptnr=vpdejesus-blogspot&amp;offertype=all&amp;color1=999999&amp;color2=FFFFFF&amp;textcolor=FFFFFF&amp;lcolor1=666666&amp;trk=&amp;cat=Info&amp;catnum=16"/>
            <param name="quality" value="high"/>
            <param name="bgcolor" value="#ffffff"/>
            <embed align="middle" allowscriptaccess="sameDomain" bgcolor="#ffffff" height="280"
                   name="color test" pluginspage="http://www.macromedia.com/go/getflashplayer" quality="high"
                   src="http://img.tradepub.com/images/bimages/336x280catstatic.swf?ptnr=vpdejesus-blogspot&amp;offertype=all&amp;color1=999999&amp;color2=FFFFFF&amp;textcolor=FFFFFF&amp;lcolor1=666666&amp;trk=&amp;cat=Info&amp;catnum=16"
                   type="application/x-shockwave-flash" width="336" wmode="transparent"/></embed>
        </object>
    </div>
</asp:Content>