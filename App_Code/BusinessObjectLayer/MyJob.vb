Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class MyJob
        Public Sub New()
        End Sub

        Private _myJobId As Integer
        Private _postingId As Integer
        Private _userName As String

        Public Property MyJobId As Integer
            Get
                Return _MyJobID
            End Get
            Set
                _MyJobID = value
            End Set
        End Property

        Public Property PostingId As Integer
            Get
                Return _PostingID
            End Get
            Set
                _PostingID = value
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

        Public Shared Function Insert(j As MyJob) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand
                    Dim objParam = New SqlParameter("@MyJobID", SqlDbType.Int) With
                            {
                            .Direction = ParameterDirection.Output
                            }

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobs_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@PostingID", j.PostingID))
                        .Parameters.Add(New SqlParameter("@ContactPerson", j.UserName))
                    End With

                    If cmd.ExecuteNonQuery = 1 Then
                        Return Integer.Parse(objParam.Value.ToString)
                    Else
                        Return - 1
                    End If

                End Using
            End Using
        End Function

        Public Shared Function Delete(j As MyJob) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MyJobs_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@MyJobID", j.MyJobID))
                    End With

                    Dim retval As Integer = cmd.ExecuteNonQuery

                    Return retval

                End Using
            End Using
        End Function

        Public Shared Function GetMyJobs(username As String) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[MyJobs_SelectForUser]",
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