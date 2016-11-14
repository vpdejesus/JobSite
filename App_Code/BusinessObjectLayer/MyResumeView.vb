Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class MyResumeView
        Public Sub New()
        End Sub

        Private _viewId As Integer
        Private _jobSeekerId As Integer
        Private _companyId As Integer
        Private _viewDate As DateTime

        Public Property ViewId As Integer
            Get
                Return _ViewID
            End Get
            Set
                _ViewID = value
            End Set
        End Property

        Public Property JobSeekerId As Integer
            Get
                Return _JobSeekerID
            End Get
            Set
                _JobSeekerID = value
            End Set
        End Property

        Public Property CompanyId As Integer
            Get
                Return _CompanyID
            End Get
            Set
                _CompanyID = value
            End Set
        End Property

        Public Property ViewDate As DateTime
            Get
                Return _ViewDate
            End Get
            Set
                _ViewDate = value
            End Set
        End Property

        Public Shared Function Insert(r As MyResumeView) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyResumeViews_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", r.JobSeekerID))
                        .Parameters.Add(New SqlParameter("@CompanyID", r.CompanyID))
                        .Parameters.Add(New SqlParameter("@ViewDate", r.ViewDate))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(r As MyResumeView) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyResumeViews_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@ViewID", r.ViewID))
                    End With

                    Dim retval As Integer = cmd.ExecuteNonQuery
                    Return retval

                End Using
            End Using
        End Function

        Public Shared Function GetMyResumeViews(id As Integer) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With {
                        .CommandText = "[MyResumeViews_SelectOne]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }
                    da.SelectCommand.Parameters.Add(New SqlParameter("@JobSeekerID", id))
                    da.SelectCommand.ExecuteNonQuery()

                    Dim ds As New DataSet
                    da.Fill(ds)

                    Return ds

                End Using
            End Using
        End Function

        Public Shared Function GetResumeViews(id As Integer) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyResumeViews_GetAll]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", id))
                    End With

                    Return cmd.ExecuteScalar

                End Using
            End Using
        End Function
    End Class
End Namespace