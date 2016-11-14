Imports System.Globalization

Namespace JobSite.BusinessObjectLayer
    Public Class Conversion
        Public Shared Function ConvertoDate(dateString As String, ByRef result As DateTime) As Boolean
            Try
                Dim supportedFormats = New String() {"yymmdd", "MM/dd/yyyy", "MM/dd/yy", "ddMMMyyyy", "dMMMyyyy"}
                result = DateTime.ParseExact(dateString, supportedFormats, CultureInfo.CurrentCulture,
                                             DateTimeStyles.None)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
