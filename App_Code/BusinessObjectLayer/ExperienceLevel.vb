Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class ExperienceLevel
        Public Sub New()
        End Sub

        Private _experienceLevelId As Integer
        Private _experienceLevelName As String

        Public Property ExperienceLevelId As Integer
            Get
                Return _ExperienceLevelID
            End Get
            Set
                _ExperienceLevelID = value
            End Set
        End Property

        Public Property ExperienceLevelName As String
            Get
                Return _ExperienceLevelName
            End Get
            Set
                _ExperienceLevelName = value
            End Set
        End Property

        Public Shared Function Insert(el As ExperienceLevel) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[ExperienceLevels_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@ExperienceLevelName", el.ExperienceLevelName))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(el As ExperienceLevel) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[ExperienceLevels_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@ExperienceLevelID", el.ExperienceLevelID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Update(el As ExperienceLevel) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[ExperienceLevels_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@ExperienceLevelID", el.ExperienceLevelID))
                        .Parameters.Add(New SqlParameter("@ExperienceLevelName", el.ExperienceLevelName))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetExperienceLevelName(id As Integer) As String
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[ExperienceLevels_GetLevelName]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@ExperienceLevelID", id))
                    End With

                    Return CType(cmd.ExecuteScalar, String)

                End Using
            End Using
        End Function

        Public Shared Function GetExperienceLevels() As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With
                        {
                        .CommandText = "[ExperienceLevels_SelectAll]",
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
    End Class
End Namespace