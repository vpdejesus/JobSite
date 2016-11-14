

Namespace JobSite.DataAccessLayer
    Public Class DbFunctions
        Public Sub New()
        End Sub

        Public Shared Function NullScrubber (Of T)(checkValue As Object) As T
            Dim outValue As T
            If checkValue Is DBNull.Value Then
                outValue = Nothing
            Else
                outValue = CType(checkValue, T)
            End If
            Return outValue
        End Function
    End Class
End Namespace