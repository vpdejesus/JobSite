<%@ Page Title="" Language="VB" MasterPageFile="~/MainPage.master" AutoEventWireup="false"
CodeFile="Register.aspx.vb" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br/>
    Registration is very easy!! Just fill in your desired username and password,&nbsp;
    your security question and choose to register as &quot;Job Seeker&quot;&nbsp;or
    as an "Employer".
    <br/>
    <br/>
    <br/>
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BorderColor="#CCCC99"
                          BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" CreateUserButtonText="Register Me"
                          Width="274px" Height="255px">
        <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top"/>
        <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="#FFFFFF"/>
        <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                             BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775"/>
        <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                               BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775"/>
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" HorizontalAlign="Center"/>
        <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                               BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775"/>
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF"/>
        <StepStyle BorderWidth="0px"/>
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server">
                <ContentTemplate>
                    <table border="0" style="font-family: Verdana; font-size: 100%; width: 475px;">
                        <tr>
                            <td align="center" colspan="2" style="background-color: #6B696B; color: White; font-weight: bold;">
                                Sign Up for Your New Account
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style22">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                            </td>
                            <td class="style23">
                                <asp:TextBox ID="UserName" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                            ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">
                                    *
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style24">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                            </td>
                            <td class="style25">
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                            ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1"
                                                            Width="150px">
                                    *
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style26">
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                            </td>
                            <td class="style27">
                                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword"
                                                            ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required."
                                                            ValidationGroup="CreateUserWizard1">
                                    *
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style28">
                                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                            </td>
                            <td class="style29">
                                <asp:TextBox ID="Email" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email"
                                                            ErrorMessage="E-mail is required." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">
                                    *
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style28">
                                <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Security Question:</asp:Label>
                            </td>
                            <td class="style29">
                                <asp:TextBox ID="Question" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question"
                                                            ErrorMessage="Security question is required." ToolTip="Security question is required."
                                                            ValidationGroup="CreateUserWizard1">
                                    *
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style32">
                                <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Security Answer:</asp:Label>
                            </td>
                            <td class="style33">
                                <asp:TextBox ID="Answer" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer"
                                                            ErrorMessage="Security answer is required." ToolTip="Security answer is required."
                                                            ValidationGroup="CreateUserWizard1">
                                    *
                                </asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                                                      ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match."
                                                      ValidationGroup="CreateUserWizard1">
                                </asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color: Red;">
                                <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" StepType="Step" Title="Register as">
                <table class="style11" style="height: 47px">
                    <tr>
                        <td class="style34">
                            Register As:
                        </td>
                    </tr>
                    <tr>
                        <td class="style35">
                            <asp:DropDownList ID="ddlRegAs" runat="server" Height="21px" Width="153px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style19"></td>
                    </tr>
                </table>
            </asp:WizardStep>
            <asp:CompleteWizardStep runat="server"/>
        </WizardSteps>
    </asp:CreateUserWizard>
    <br/>
    <br/>
    <br/>
    <div style="height: 290px; margin-left: 0px; width: 767px;">
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