Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class MyJobApplication
        Public Sub New()
        End Sub

        Private _postingId As Integer
        Private _jobSeekerId As Integer
        Private _appliedId As Integer
        Private _title As String
        Private _companyId As Integer
        Private _appliedDate As DateTime
        Private _appStatusId As Integer

        Public Property PostingId As Integer
            Get
                Return _PostingID
            End Get
            Set
                _PostingID = value
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

        Public Property AppliedId As Integer
            Get
                Return _AppliedID
            End Get
            Set
                _AppliedID = value
            End Set
        End Property

        Public Property Title As String
            Get
                Return _Title
            End Get
            Set
                _Title = value
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

        Public Property AppliedDate As DateTime
            Get
                Return _AppliedDate
            End Get
            Set
                _AppliedDate = value
            End Set
        End Property

        Public Property AppStatusID As Integer
            Get
                Return _AppStatusID
            End Get
            Set
                _AppStatusID = value
            End Set
        End Property

        Public Shared Function Insert(j As MyJobApplication) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobApplications_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@PostingID", j.PostingID))
                        .Parameters.Add(New SqlParameter("@JobSeekerID", j.JobSeekerID))
                        .Parameters.Add(New SqlParameter("@Title", j.Title))
                        .Parameters.Add(New SqlParameter("@CompanyID", j.CompanyID))
                        .Parameters.Add(New SqlParameter("@AppliedDate", j.AppliedDate))
                        .Parameters.Add(New SqlParameter("@AppStatusID", j.AppStatusID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetMyJobApplications(id As Integer) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[MyJobApplications_SelectOne]",
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

        Public Shared Function GetMyJobApplication(id As Integer) As MyJobApplication
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobApplications_SelectOne]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@AppliedID", id))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim j = New MyJobApplication
                        While dr.Read
                            j.AppliedID = dr.GetInt32(dr.GetOrdinal("id"))
                            j.PostingID = dr.GetInt32(dr.GetOrdinal("PostingID"))
                            j.JobSeekerID = dr.GetInt32(dr.GetOrdinal("JobSeekerID"))
                            j.Title = dr.GetString(dr.GetOrdinal("Title"))
                            j.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                            j.AppliedDate = dr.GetDateTime(dr.GetOrdinal("AppliedDate"))
                            j.AppStatusID = dr.GetInt32(dr.GetOrdinal("AppStatusID"))
                        End While
                        dr.Close()
                        Return j
                    Else
                        Return Nothing
                    End If

                End Using
            End Using
        End Function

        Public Shared Function Delete(j As MyJobApplication) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobApplications_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@AppliedID", j.AppliedID))
                    End With

                    Dim retval As Integer = cmd.ExecuteNonQuery
                    Return retval

                End Using
            End Using
        End Function

        Public Shared Function Update(j As MyJobApplication) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobApplications_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@AppliedID", j.AppliedID))
                        .Parameters.Add(New SqlParameter("@PostingID", j.PostingID))
                        .Parameters.Add(New SqlParameter("@JobSeekerID", j.JobSeekerID))
                        .Parameters.Add(New SqlParameter("@Title", j.Title))
                        .Parameters.Add(New SqlParameter("@CompanyID", j.CompanyID))
                        .Parameters.Add(New SqlParameter("@AppliedDate", j.AppliedDate))
                        .Parameters.Add(New SqlParameter("@AppStatusID", j.AppStatusID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function UpdateStatus(j As MyJobApplication) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobApplications_UpdateStatus]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@AppliedID", j.AppliedID))
                        .Parameters.Add(New SqlParameter("@AppStatusID", j.AppStatusID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetJobApplied(postid As Integer, seekerid As Integer, compid As Integer) As Boolean
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobApplications_GetJobApplied]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@PostingID", postid))
                        .Parameters.Add(New SqlParameter("@JobSeekerID", seekerid))
                        .Parameters.Add(New SqlParameter("@CompanyID", compid))
                    End With

                    If cmd.ExecuteScalar <> 0 Then
                        Return True
                    Else
                        Return False
                    End If

                End Using
            End Using
        End Function

        Public Shared Function GetJobApplicants(id As Integer) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[MyJobApplications_GetJobApplicants]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }
                    da.SelectCommand.Parameters.Add(New SqlParameter("@CompanyID", id))
                    da.SelectCommand.ExecuteNonQuery()

                    Dim ds As New DataSet
                    da.Fill(ds)

                    Return ds

                End Using
            End Using
        End Function
    End Class
End Namespace
