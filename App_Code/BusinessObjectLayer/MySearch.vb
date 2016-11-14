Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class MySearch
        Public Sub New()
        End Sub

        Private _mySearchId As Integer
        Private _searchCriteria As String
        Private _countryId As Integer
        Private _stateId As Integer
        Private _city As String
        Private _userName As String

        Public Property MySearchId As Integer
            Get
                Return _MySearchID
            End Get
            Set
                _MySearchID = value
            End Set
        End Property

        Public Property SearchCriteria As String
            Get
                Return _SearchCriteria
            End Get
            Set
                _SearchCriteria = value
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

        Public Property StateId As Integer
            Get
                Return _StateID
            End Get
            Set
                _StateID = value
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

        Public Property UserName As String
            Get
                Return _UserName
            End Get
            Set
                _UserName = value
            End Set
        End Property

        Public Shared Function Insert(s As MySearch) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MySearches_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@SearchCriteria", s.SearchCriteria))
                        .Parameters.Add(New SqlParameter("@CountryID", s.CountryID))
                        .Parameters.Add(New SqlParameter("@StateID", s.StateID))
                        .Parameters.Add(New SqlParameter("@City", s.City))
                        .Parameters.Add(New SqlParameter("@UserName", s.UserName))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetMySearches(username As String) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With {
                        .CommandText = "[MySearches_SelectForUser]",
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

        Public Shared Function GetMySearch(id As Integer) As MySearch
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MySearches_SelectOne]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@MySearchID", id))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim s = New MySearch
                        While dr.Read
                            s.MySearchID = dr.GetInt32(dr.GetOrdinal("id"))
                            s.SearchCriteria = dr.GetString(dr.GetOrdinal("SearchCriteria"))
                            s.CountryID = dr.GetInt32(dr.GetOrdinal("CountryID"))
                            s.StateID = dr.GetInt32(dr.GetOrdinal("StateID"))
                            s.City = dr.GetString(dr.GetOrdinal("City"))
                            s.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                        End While

                        dr.Close()
                        Return s
                    Else
                        Return Nothing
                    End If

                End Using
            End Using
        End Function

        Public Shared Function Delete(s As MySearch) As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[MySearches_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@MySearchID", s.MySearchID))
                    End With

                    Dim retval As Integer = cmd.ExecuteNonQuery
                    Return retval

                End Using
            End Using
        End Function
    End Class
End Namespace