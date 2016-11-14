

Namespace JobSite.DataAccessLayer
    Public Class DataAccess
        Public Sub New()
            Dim objConnStringSettings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("JobSite")
            ConnectionString = objConnStringSettings.ConnectionString
        End Sub

        Public Property ConnectionString As String = ""
    End Class
End Namespace

