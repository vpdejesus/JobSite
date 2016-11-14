Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class JobPosting
        Public Sub New()
        End Sub

        Private _postingId As Integer
        Private _companyId As Integer
        Private _contactPerson As String
        Private _title As String
        Private _department As String
        Private _jobCode As String
        Private _city As String
        Private _stateId As Integer
        Private _countryId As Integer
        Private _educationLevelId As Integer
        Private _jobTypeId As Integer
        Private _jobCategoryId As Integer
        Private _minSalary As Decimal
        Private _maxSalary As Decimal
        Private _description As String
        Private _postingDate As DateTime
        Private _postedBy As String

        Public Property PostingId As Integer
            Get
                Return _PostingID
            End Get
            Set
                _PostingID = value
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

        Public Property ContactPerson As String
            Get
                Return _ContactPerson
            End Get
            Set
                _ContactPerson = value
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

        Public Property Department As String
            Get
                Return _Department
            End Get
            Set
                _Department = value
            End Set
        End Property

        Public Property JobCode As String
            Get
                Return _JobCode
            End Get
            Set
                _JobCode = value
            End Set
        End Property

        Public Property City As String
            Get
                Return _City
            End Get
            Set
                _City = value
            End Set
        End Property

        Public Property StateId As Integer
            Get
                Return _StateID
            End Get
            Set
                _StateID = value
            End Set
        End Property

        Public Property CountryId As Integer
            Get
                Return _CountryID
            End Get
            Set
                _CountryID = value
            End Set
        End Property

        Public Property EducationLevelId As Integer
            Get
                Return _EducationLevelID
            End Get
            Set
                _EducationLevelID = value
            End Set
        End Property

        Public Property JobTypeId As Integer
            Get
                Return _JobTypeID
            End Get
            Set
                _JobTypeID = value
            End Set
        End Property

        Public Property JobCategoryId As Integer
            Get
                Return _JobCategoryID
            End Get
            Set
                _JobCategoryID = value
            End Set
        End Property

        Public Property MinSalary As Decimal
            Get
                Return _MinSalary
            End Get
            Set
                _MinSalary = value
            End Set
        End Property

        Public Property MaxSalary As Decimal
            Get
                Return _MaxSalary
            End Get
            Set
                _MaxSalary = value
            End Set
        End Property

        Public Property Description As String
            Get
                Return _Description
            End Get
            Set
                _Description = value
            End Set
        End Property

        Public Property PostingDate As DateTime
            Get
                Return _PostingDate
            End Get
            Set
                _PostingDate = value
            End Set
        End Property

        Public Property PostedBy As String
            Get
                Return _PostedBy
            End Get
            Set
                _PostedBy = value
            End Set
        End Property

        Public Shared Function Insert(j As JobPosting) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JobPostings_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@CompanyID", j.CompanyID))
                        .Parameters.Add(New SqlParameter("@ContactPerson", j.ContactPerson))
                        .Parameters.Add(New SqlParameter("@Title", j.Title))
                        .Parameters.Add(New SqlParameter("@Department", j.Department))
                        .Parameters.Add(New SqlParameter("@JobCode", j.JobCode))
                        .Parameters.Add(New SqlParameter("@City", j.City))
                        .Parameters.Add(New SqlParameter("@StateID", j.StateID))
                        .Parameters.Add(New SqlParameter("@CountryID", j.CountryID))
                        .Parameters.Add(New SqlParameter("@EducationLevelID", j.EducationLevelID))
                        .Parameters.Add(New SqlParameter("@JobTypeID", j.JobTypeID))
                        .Parameters.Add(New SqlParameter("@JobCategoryID", j.JobCategoryID))
                        .Parameters.Add(New SqlParameter("@MinSalary", j.MinSalary))
                        .Parameters.Add(New SqlParameter("@MaxSalary", j.MaxSalary))
                        .Parameters.Add(New SqlParameter("@JobDescription", j.Description))
                        .Parameters.Add(New SqlParameter("@PostingDate", j.PostingDate))
                        .Parameters.Add(New SqlParameter("@PostedBy", j.PostedBy))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Update(j As JobPosting) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JobPostings_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobPostingID", j.PostingID))
                        .Parameters.Add(New SqlParameter("@CompanyID", j.CompanyID))
                        .Parameters.Add(New SqlParameter("@ContactPerson", j.ContactPerson))
                        .Parameters.Add(New SqlParameter("@Title", j.Title))
                        .Parameters.Add(New SqlParameter("@Department", j.Department))
                        .Parameters.Add(New SqlParameter("@JobCode", j.JobCode))
                        .Parameters.Add(New SqlParameter("@City", j.City))
                        .Parameters.Add(New SqlParameter("@StateID", j.StateID))
                        .Parameters.Add(New SqlParameter("@CountryID", j.CountryID))
                        .Parameters.Add(New SqlParameter("@EducationLevelID", j.EducationLevelID))
                        .Parameters.Add(New SqlParameter("@JobTypeID", j.JobTypeID))
                        .Parameters.Add(New SqlParameter("@JobCategoryID", j.JobCategoryID))
                        .Parameters.Add(New SqlParameter("@MinSalary", j.MinSalary))
                        .Parameters.Add(New SqlParameter("@MaxSalary", j.MaxSalary))
                        .Parameters.Add(New SqlParameter("@JobDescription", j.Description))
                        .Parameters.Add(New SqlParameter("@PostingDate", j.PostingDate))
                        .Parameters.Add(New SqlParameter("@PostedBy", j.PostedBy))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(j As JobPosting) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JobPostings_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobPostingID", j.PostingID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetPosting(id As Integer) As JobPosting
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JobPostings_SelectOne]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@PostingID", id))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim j = New JobPosting
                        While dr.Read
                            j.PostingID = dr.GetInt32(dr.GetOrdinal("PostingID"))
                            j.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                            j.Title = dr.GetString(dr.GetOrdinal("Title"))
                            j.ContactPerson = dr.GetString(dr.GetOrdinal("ContactPerson"))
                            j.Department = dr.GetString(dr.GetOrdinal("Department"))
                            j.Description = dr.GetString(dr.GetOrdinal("JobDescription"))
                            j.City = dr.GetString(dr.GetOrdinal("City"))
                            j.StateID = dr.GetInt32(dr.GetOrdinal("StateID"))
                            j.CountryID = dr.GetInt32(dr.GetOrdinal("CountryID"))
                            j.EducationLevelID = dr.GetInt32(dr.GetOrdinal("EducationLevelID"))
                            j.JobTypeID = dr.GetInt32(dr.GetOrdinal("JobTypeID"))
                            j.JobTypeID = dr.GetInt32(dr.GetOrdinal("JobCategoryID"))
                            j.JobCode = dr.GetString(dr.GetOrdinal("JobCode"))
                            j.MinSalary = dr.GetDecimal(dr.GetOrdinal("MinSalary"))
                            j.MaxSalary = dr.GetDecimal(dr.GetOrdinal("MaxSalary"))
                            j.PostingDate = dr.GetDateTime(dr.GetOrdinal("PostingDate"))
                            j.PostedBy = dr.GetString(dr.GetOrdinal("PostedBy"))
                        End While
                        dr.Close()
                        Return j
                    Else
                        dr.Close()
                        Dim j = New JobPosting
                        j.PostingID = - 1
                        Return j
                    End If

                End Using
            End Using
        End Function

        Public Shared Function GetJobPostingCount() As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JobPostings_GetCount]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                    End With

                    Return CType(cmd.ExecuteScalar, Integer)

                End Using
            End Using
        End Function

        Public Shared Function GetPostings(username As String) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[JobPostings_SelectByUser]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }

                    da.SelectCommand.Parameters.Add(New SqlParameter("@UserName", username))
                    da.SelectCommand.ExecuteNonQuery()

                    Dim ds As New DataSet
                    da.Fill(ds)

                    Return ds

                End Using
            End Using
        End Function

        Public Shared Function GetLatest() As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[JobPostings_GetLatest]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }
                    da.SelectCommand.ExecuteNonQuery()

                    Dim ds As New DataSet
                    da.Fill(ds)

                    Return ds

                End Using
            End Using
        End Function

        Public Shared Function SearchJobs(skill As String, categoryid As Integer, countryid As Integer,
                                          stateid As Integer, city As String) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[JobPostings_SelectForMatchingSkills]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }

                    If skill = "" Then
                        da.SelectCommand.Parameters.Add(New SqlParameter("@Skill", DBNull.Value))
                    Else
                        da.SelectCommand.Parameters.Add(New SqlParameter("@Skill", skill))
                    End If

                    If categoryid = 1 Then
                        da.SelectCommand.Parameters.Add(New SqlParameter("@CategoryID", DBNull.Value))
                    Else
                        da.SelectCommand.Parameters.Add(New SqlParameter("@CategoryID", categoryid))
                    End If

                    If countryid = 1 Then
                        da.SelectCommand.Parameters.Add(New SqlParameter("@CountryID", DBNull.Value))
                    Else
                        da.SelectCommand.Parameters.Add(New SqlParameter("@CountryID", countryid))
                    End If

                    If stateid = 1 Then
                        da.SelectCommand.Parameters.Add(New SqlParameter("@StateID", DBNull.Value))
                    Else
                        da.SelectCommand.Parameters.Add(New SqlParameter("@StateID", stateid))
                    End If

                    If city = "" Then
                        da.SelectCommand.Parameters.Add(New SqlParameter("@City", DBNull.Value))
                    Else
                        da.SelectCommand.Parameters.Add(New SqlParameter("@City", city))
                    End If

                    da.SelectCommand.ExecuteNonQuery()

                    Dim ds As New DataSet
                    da.Fill(ds)

                    Return ds

                End Using
            End Using
        End Function
    End Class
End Namespace
