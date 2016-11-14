Imports System.Web.Script.Services
Imports System.Web.Services
Imports JobSite.BusinessObjectLayer
Imports Microsoft.VisualBasic.CompilerServices

<ScriptService> _
<WebService(Namespace := "http://tempuri.org/")> _
<WebServiceBinding(ConformsTo := WsiProfiles.BasicProfile1_1)> _
<DesignerGenerated>
Public Class WebService
    Inherits Services.WebService

    <WebMethod> _
    <ScriptMethod>
    Public Function GetTooltipText(contextKey As String) As String
        Dim job As JobPosting = JobPosting.GetPosting(contextKey)
        Return job.Description
    End Function

    <WebMethod> _
    <ScriptMethod>
    Public Function GetCompanyProfile(contextKey As Integer) As String
        Dim c As Company = Company.GetCompany(contextKey)
        Dim sb = New StringBuilder()
        sb.Append("<table width='100%'>")

        sb.Append("<tr><td colspan='2' class='dataentryformlabelbig' align='left'>")
        sb.Append("Company Details")
        sb.Append("</td></tr>")

        sb.Append("<tr><td nowrap align='right'>")
        sb.Append("Company Name :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.CompanyName)
        sb.Append("</td></tr>")

        sb.Append("<tr><td nowrap valign='top' align='right'>")
        sb.Append("Brief Profile :")
        sb.Append("</td>")
        sb.Append("<td><textarea readonly='true' rows=5 cols=30>")
        sb.Append(c.CompanyProfile)
        sb.Append("</textarea></td></tr>")

        sb.Append("<tr><td colspan='2' class='dataentryformlabelbig' align='left'>")
        sb.Append("Location")
        sb.Append("</td></tr>")

        sb.Append("<tr><td valign='top' align='right'>")
        sb.Append("Address 1 :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.Address1)
        sb.Append("</td></tr>")

        sb.Append("<tr><td valign='top' align='right'>")
        sb.Append("Address 2 :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.Address2)
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("City :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.City)
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("State :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(State.GetStateName(c.StateID))
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("Country :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(Country.GetCountryName(c.CountryID))
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("Zip :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.ZIP)
        sb.Append("</td></tr>")

        sb.Append("<tr><td colspan='2' class='dataentryformlabelbig' align='left'>")
        sb.Append("Contact Details")
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("Phone :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.Phone)
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("Fax :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.Fax)
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("Email :")
        sb.Append("</td>")
        sb.Append("<td>")
        sb.Append(c.CompanyEmail)
        sb.Append("</td></tr>")

        sb.Append("<tr><td align='right'>")
        sb.Append("Web Site :")
        sb.Append("</td>")
        sb.Append("<td><a href='")
        sb.Append(c.WebSiteUrl)
        sb.Append("'>")
        sb.Append(c.WebSiteUrl)
        sb.Append("</a></td></tr>")

        sb.Append("</table>")

        Return sb.ToString()
    End Function
End Class
