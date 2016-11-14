Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class MyResume
        Public Sub New()
        End Sub

        Private _myResumeId As Integer
        Private _jobSeekerId As Integer
        Private _userName As String
        Private _createdDate As DateTime

        Public Property MyResumeId As Integer
            Get
                Return _MyResumeID
            End Get
            Set
                _MyResumeID = value
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

        Public Property UserName As String
            Get
                Return _UserName
            End Get
            Set
                _UserName = value
            End Set
        End Property

        Public Property CreatedDate As DateTime
            Get
                Return _CreatedDate
            End Get
            Set
                _CreatedDate = value
            End Set
        End Property

        Public Shared Function Insert(r As MyResume) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyResumes_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", r.JobSeekerID))
                        .Parameters.Add(New SqlParameter("@UserName", r.UserName))
                        .Parameters.Add(New SqlParameter("@CreatedDate", r.CreatedDate))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(r As MyResume) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyResumes_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@MyResumeID", r.MyResumeID))
                    End With

                    Dim retval As Integer = cmd.ExecuteNonQuery
                    Return retval

                End Using
            End Using
        End Function

        Public Shared Function GetMyResumes(username As String) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With {
                        .CommandText = "[MyResumes_SelectForUser]",
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
    End Class
End Namespace