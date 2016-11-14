Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class State
        Public Sub New()
        End Sub

        Private _stateId As Integer
        Private _countryId As Integer
        Private _stateName As String

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

        Public Property StateName As String
            Get
                Return _StateName
            End Get
            Set
                _StateName = value
            End Set
        End Property

        Public Shared Function Insert(s As State) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[States_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@CountryID", s.CountryID))
                        .Parameters.Add(New SqlParameter("@StateName", s.StateName))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(s As State) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[States_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@StateID", s.StateID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Update(s As State) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[States_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@StateID", s.StateID))
                        .Parameters.Add(New SqlParameter("@CountryID", s.CountryID))
                        .Parameters.Add(New SqlParameter("@StateName", s.StateName))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetStateName(id As Integer) As String
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[States_GetStateName]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@StateID", id))
                    End With

                    Return CType(cmd.ExecuteScalar, String)

                End Using
            End Using
        End Function

        Public Shared Function GetAllStates() As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With {
                        .CommandText = "[States_SelectAll]",
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

        Public Shared Function GetStates(countryid As Integer) As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With {
                        .CommandText = "[States_SelectForCountry]",
                        .CommandType = CommandType.StoredProcedure,
                        .Connection = con
                        }
                    da.SelectCommand.Parameters.Add(New SqlParameter("@CountryID", countryid))
                    da.SelectCommand.ExecuteNonQuery()

                    Dim ds As New DataSet
                    da.Fill(ds)

                    Return ds

                End Using
            End Using
        End Function
    End Class
End Namespace
