Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class JobSeeker
        Public Sub New()
        End Sub

        Private _jobSeekerId As Integer
        Private _userName As String
        Private _jobTitle As String
        Private _firstName As String
        Private _middleName As String
        Private _lastName As String
        Private _positionDesired As String
        Private _age As String
        Private _sex As String
        Private _birthDate As DateTime
        Private _email As String
        Private _mobile As String
        Private _telephoneNo As String
        Private _address As String
        Private _city As String
        Private _countryId As Integer
        Private _stateId As Integer
        Private _educationLevelId As Integer
        Private _experienceLevelId As Integer
        Private _resumeDetail As String

        Public Property JobSeekerId As Integer
            Get
                Return _jobSeekerId
            End Get
            Set
                _jobSeekerId = value
            End Set
        End Property

        Public Property UserName As String
            Get
                Return _userName
            End Get
            Set
                _userName = value
            End Set
        End Property

        Public Property JobTitle As String
            Get
                Return _jobTitle
            End Get
            Set
                _jobTitle = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set
                _firstName = value
            End Set
        End Property

        Public Property MiddleName As String
            Get
                Return _middleName
            End Get
            Set
                _middleName = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set
                _lastName = value
            End Set
        End Property

        Public Property PositionDesired As String
            Get
                Return _positionDesired
            End Get
            Set
                _positionDesired = value
            End Set
        End Property

        Public Property Age As String
            Get
                Return _age
            End Get
            Set
                _age = value
            End Set
        End Property

        Public Property Sex As String
            Get
                Return _sex
            End Get
            Set
                _sex = value
            End Set
        End Property

        Public Property BirthDate As DateTime
            Get
                Return _birthDate
            End Get
            Set
                _birthDate = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return _email
            End Get
            Set
                _email = value
            End Set
        End Property

        Public Property Mobile As String
            Get
                Return _mobile
            End Get
            Set
                _mobile = value
            End Set
        End Property

        Public Property TelephoneNo As String
            Get
                Return _telephoneNo
            End Get
            Set
                _telephoneNo = value
            End Set
        End Property

        Public Property Address As String
            Get
                Return _address
            End Get
            Set
                _address = value
            End Set
        End Property

        Public Property City As String
            Get
                Return _city
            End Get
            Set
                _city = value
            End Set
        End Property

        Public Property CountryId As Integer
            Get
                Return _countryId
            End Get
            Set
                _countryId = value
            End Set
        End Property

        Public Property StateId As Integer
            Get
                Return _stateId
            End Get
            Set
                _stateId = value
            End Set
        End Property

        Public Property EducationLevelId As Integer
            Get
                Return _educationLevelId
            End Get
            Set
                _educationLevelId = value
            End Set
        End Property

        Public Property ExperienceLevelId As Integer
            Get
                Return _experienceLevelId
            End Get
            Set
                _experienceLevelId = value
            End Set
        End Property

        Public Property ResumeDetail As String
            Get
                Return _resumeDetail
            End Get
            Set
                _resumeDetail = value
            End Set
        End Property

        Public Shared Function Insert(j As JobSeeker) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@UserName", j.UserName))
                        .Parameters.Add(New SqlParameter("@JobTitle", j.JobTitle))
                        .Parameters.Add(New SqlParameter("@FName", j.FirstName))
                        .Parameters.Add(New SqlParameter("@MName", j.MiddleName))
                        .Parameters.Add(New SqlParameter("@LName", j.LastName))
                        .Parameters.Add(New SqlParameter("@PositionDesired", j.PositionDesired))
                        .Parameters.Add(New SqlParameter("@Age", j.Age))
                        .Parameters.Add(New SqlParameter("@Sex", j.Sex))
                        .Parameters.Add(New SqlParameter("@BirthDate", j.BirthDate))
                        .Parameters.Add(New SqlParameter("@Email", j.Email))
                        .Parameters.Add(New SqlParameter("@Mobile", j.Mobile))
                        .Parameters.Add(New SqlParameter("@TelNo", j.TelephoneNo))
                        .Parameters.Add(New SqlParameter("@Address", j.Address))
                        .Parameters.Add(New SqlParameter("@City", j.City))
                        .Parameters.Add(New SqlParameter("@CountryID", j.CountryID))
                        .Parameters.Add(New SqlParameter("@StateID", j.StateID))
                        .Parameters.Add(New SqlParameter("@EducationLevelID", j.EducationLevelID))
                        .Parameters.Add(New SqlParameter("@ExperienceLevelID", j.ExperienceLevelID))
                        .Parameters.Add(New SqlParameter("@Resume", j.ResumeDetail))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(j As JobSeeker) As SqlCommand
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using cmd As New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", j.JobSeekerId))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Update(j As JobSeeker) As SqlCommand
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using cmd As New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", j.JobSeekerId))
                        .Parameters.Add(New SqlParameter("@UserName", j.UserName))
                        .Parameters.Add(New SqlParameter("@JobTitle", j.JobTitle))
                        .Parameters.Add(New SqlParameter("@FName", j.FirstName))
                        .Parameters.Add(New SqlParameter("@MName", j.MiddleName))
                        .Parameters.Add(New SqlParameter("@LName", j.LastName))
                        .Parameters.Add(New SqlParameter("@PositionDesired", j.PositionDesired))
                        .Parameters.Add(New SqlParameter("@Age", j.Age))
                        .Parameters.Add(New SqlParameter("@Sex", j.Sex))
                        .Parameters.Add(New SqlParameter("@BirthDate", j.BirthDate))
                        .Parameters.Add(New SqlParameter("@Email", j.Email))
                        .Parameters.Add(New SqlParameter("@Mobile", j.Mobile))
                        .Parameters.Add(New SqlParameter("@TelNo", j.TelephoneNo))
                        .Parameters.Add(New SqlParameter("@Address", j.Address))
                        .Parameters.Add(New SqlParameter("@City", j.City))
                        .Parameters.Add(New SqlParameter("@CountryID", j.CountryId))
                        .Parameters.Add(New SqlParameter("@StateID", j.StateId))
                        .Parameters.Add(New SqlParameter("@EducationLevelID", j.EducationLevelId))
                        .Parameters.Add(New SqlParameter("@ExperienceLevelID", j.ExperienceLevelId))
                        .Parameters.Add(New SqlParameter("@Resume", j.ResumeDetail))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetJobSeeker(UserName As String) As JobSeeker
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using cmd As New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_SelectForUser]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@UserName", UserName))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim j = New JobSeeker
                        While dr.Read
                            j.JobSeekerId = dr.GetInt32(dr.GetOrdinal("JobSeekerID"))
                            j.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                            j.JobTitle = dr.GetString(dr.GetOrdinal("JobTitle"))
                            j.FirstName = dr.GetString(dr.GetOrdinal("FName"))
                            j.MiddleName = dr.GetString(dr.GetOrdinal("MName"))
                            j.LastName = dr.GetString(dr.GetOrdinal("LName"))
                            j.PositionDesired = dr.GetString(dr.GetOrdinal("PositionDesired"))
                            j.Age = dr.GetString(dr.GetOrdinal("Age"))
                            j.Sex = dr.GetString(dr.GetOrdinal("Sex"))
                            j.BirthDate = dr.GetDateTime(dr.GetOrdinal("BirthDate"))
                            j.Email = dr.GetString(dr.GetOrdinal("Email"))
                            j.Mobile = dr.GetString(dr.GetOrdinal("Mobile"))
                            j.TelephoneNo = dr.GetString(dr.GetOrdinal("TelNo"))
                            j.Address = dr.GetString(dr.GetOrdinal("Address"))
                            j.City = dr.GetString(dr.GetOrdinal("City"))
                            j.CountryId = dr.GetInt32(dr.GetOrdinal("CountryID"))
                            j.StateId = dr.GetInt32(dr.GetOrdinal("StateID"))
                            j.EducationLevelId = dr.GetInt32(dr.GetOrdinal("EducationLevelID"))
                            j.ExperienceLevelId = dr.GetInt32(dr.GetOrdinal("ExperienceLevelID"))
                            j.ResumeDetail = dr.GetString(dr.GetOrdinal("Resume"))
                        End While
                        dr.Close()
                        Return j
                    Else
                        dr.Close()
                        Dim j = New JobSeeker
                        j.JobSeekerId = - 1
                        Return j
                    End If

                End Using
            End Using
        End Function

        Public Shared Function GetResume(resumeid As Integer) As JobSeeker
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using cmd As New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_SelectOne]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", resumeid))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim j = New JobSeeker
                        While dr.Read
                            j.JobSeekerId = dr.GetInt32(dr.GetOrdinal("JobSeekerID"))
                            j.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                            j.JobTitle = dr.GetString(dr.GetOrdinal("JobTitle"))
                            j.FirstName = dr.GetString(dr.GetOrdinal("FName"))
                            j.MiddleName = dr.GetString(dr.GetOrdinal("MName"))
                            j.LastName = dr.GetString(dr.GetOrdinal("LName"))
                            j.PositionDesired = dr.GetString(dr.GetOrdinal("PositionDesired"))
                            j.Age = dr.GetString(dr.GetOrdinal("Age"))
                            j.Sex = dr.GetString(dr.GetOrdinal("Sex"))
                            j.BirthDate = dr.GetDateTime(dr.GetOrdinal("BirthDate"))
                            j.Email = dr.GetString(dr.GetOrdinal("Email"))
                            j.Mobile = dr.GetString(dr.GetOrdinal("Mobile"))
                            j.TelephoneNo = dr.GetString(dr.GetOrdinal("TelNo"))
                            j.Address = dr.GetString(dr.GetOrdinal("Address"))
                            j.City = dr.GetString(dr.GetOrdinal("City"))
                            j.CountryId = dr.GetInt32(dr.GetOrdinal("CountryID"))
                            j.StateId = dr.GetInt32(dr.GetOrdinal("StateID"))
                            j.EducationLevelId = dr.GetInt32(dr.GetOrdinal("EducationLevelID"))
                            j.ExperienceLevelId = dr.GetInt32(dr.GetOrdinal("ExperienceLevelID"))
                            j.ResumeDetail = dr.GetString(dr.GetOrdinal("Resume"))
                        End While
                        dr.Close()
                        Return j
                    Else
                        dr.Close()
                        Return New JobSeeker
                    End If

                End Using
            End Using
        End Function

        Public Shared Function SearchResumes(skill As String, countryid As Integer, stateid As Integer, city As String) _
            As DataSet
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using da As New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[JSMain_SelectForMatchingSkills]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }

                    If skill = "" Then
                        da.SelectCommand.Parameters.Add(New SqlParameter("@Skill", DBNull.Value))
                    Else
                        da.SelectCommand.Parameters.Add(New SqlParameter("@Skill", skill))
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

        Public Shared Function GetResumeCount() As Integer
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using cmd As New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_GetCount]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                    End With

                    Return CType(cmd.ExecuteScalar, Integer)

                End Using
            End Using
        End Function

        Public Shared Function GetEmail(id As Integer) As String
            Dim dbAccess As New DataAccess
            Using con As New SqlConnection(dbAccess.ConnectionString)
                Using cmd As New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSMain_GetEmail]"
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