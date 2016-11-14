Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class Company
        Public Sub New()
        End Sub

        Private _companyId As Integer
        Private _userName As String
        Private _fName As String
        Private _mName As String
        Private _lName As String
        Private _companyName As String
        Private _address1 As String
        Private _address2 As String
        Private _city As String
        Private _countryId As Integer
        Private _stateId As Integer
        Private _zip As String
        Private _phone As String
        Private _fax As String
        Private _companyEmail As String
        Private _webSiteUrl As String
        Private _companyProfile As String

        Public Property CompanyId As Integer
            Get
                Return _CompanyID
            End Get
            Set
                _CompanyID = value
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

        Public Property FName As String
            Get
                Return _FName
            End Get
            Set
                _FName = value
            End Set
        End Property

        Public Property MName As String
            Get
                Return _MName
            End Get
            Set
                _MName = value
            End Set
        End Property

        Public Property LName As String
            Get
                Return _LName
            End Get
            Set
                _LName = value
            End Set
        End Property

        Public Property CompanyName As String
            Get
                Return _CompanyName
            End Get
            Set
                _CompanyName = value
            End Set
        End Property

        Public Property CompanyProfile As String
            Get
                Return _CompanyProfile
            End Get
            Set
                _CompanyProfile = value
            End Set
        End Property

        Public Property Address1 As String
            Get
                Return _Address1
            End Get
            Set
                _Address1 = value
            End Set
        End Property

        Public Property Address2 As String
            Get
                Return _Address2
            End Get
            Set
                _Address2 = value
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

        Public Property Zip As String
            Get
                Return _ZIP
            End Get
            Set
                _ZIP = value
            End Set
        End Property

        Public Property Phone As String
            Get
                Return _Phone
            End Get
            Set
                _Phone = value
            End Set
        End Property

        Public Property Fax As String
            Get
                Return _Fax
            End Get
            Set
                _Fax = value
            End Set
        End Property

        Public Property CompanyEmail As String
            Get
                Return _CompanyEmail
            End Get
            Set
                _CompanyEmail = value
            End Set
        End Property

        Public Property WebSiteUrl As String
            Get
                Return _WebSiteURL
            End Get
            Set
                _WebSiteURL = value
            End Set
        End Property

        Public Shared Function Insert(c As Company) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[Companies_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@UserName", c.UserName))
                        .Parameters.Add(New SqlParameter("@FName", c.FName))
                        .Parameters.Add(New SqlParameter("@MName", c.MName))
                        .Parameters.Add(New SqlParameter("@LName", c.LName))
                        .Parameters.Add(New SqlParameter("@CompanyName", c.CompanyName))
                        .Parameters.Add(New SqlParameter("@CompanyProfile", c.CompanyProfile))
                        .Parameters.Add(New SqlParameter("@Address1", c.Address1))
                        .Parameters.Add(New SqlParameter("@Address2", c.Address2))
                        .Parameters.Add(New SqlParameter("@City", c.City))
                        .Parameters.Add(New SqlParameter("@CountryID", c.CountryID))
                        .Parameters.Add(New SqlParameter("@StateID", c.StateID))
                        .Parameters.Add(New SqlParameter("@Zip", c.ZIP))
                        .Parameters.Add(New SqlParameter("@Phone", c.Phone))
                        .Parameters.Add(New SqlParameter("@Fax", c.Fax))
                        .Parameters.Add(New SqlParameter("@CompanyEmail", c.CompanyEmail))
                        .Parameters.Add(New SqlParameter("@WebSiteUrl", c.WebSiteURL))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(c As Company) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()
                    With cmd
                        .CommandText = "[Countries_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@CompanyID", c.CompanyID))
                        .ExecuteNonQuery()
                    End With
                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Update(c As Company) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[Companies_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@CompanyID", c.CompanyID))
                        .Parameters.Add(New SqlParameter("@UserName", c.UserName))
                        .Parameters.Add(New SqlParameter("@FName", c.FName))
                        .Parameters.Add(New SqlParameter("@MName", c.MName))
                        .Parameters.Add(New SqlParameter("@LName", c.LName))
                        .Parameters.Add(New SqlParameter("@CompanyName", c.CompanyName))
                        .Parameters.Add(New SqlParameter("@CompanyProfile", c.CompanyProfile))
                        .Parameters.Add(New SqlParameter("@Address1", c.Address1))
                        .Parameters.Add(New SqlParameter("@Address2", c.Address2))
                        .Parameters.Add(New SqlParameter("@City", c.City))
                        .Parameters.Add(New SqlParameter("@CountryID", c.CountryID))
                        .Parameters.Add(New SqlParameter("@StateID", c.StateID))
                        .Parameters.Add(New SqlParameter("@Zip", c.ZIP))
                        .Parameters.Add(New SqlParameter("@Phone", c.Phone))
                        .Parameters.Add(New SqlParameter("@Fax", c.Fax))
                        .Parameters.Add(New SqlParameter("@CompanyEmail", c.CompanyEmail))
                        .Parameters.Add(New SqlParameter("@WebSiteUrl", c.WebSiteURL))
                        .ExecuteNonQuery()
                    End With

                    Return cmd
                End Using
            End Using
        End Function

        Public Shared Function GetCompany(UserName As String) As Company
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[Companies_SelectByUserName]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@UserName", UserName))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim c = New Company
                        While dr.Read
                            c.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                            c.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                            c.FName = dr.GetString(dr.GetOrdinal("FName"))
                            c.MName = dr.GetString(dr.GetOrdinal("MName"))
                            c.LName = dr.GetString(dr.GetOrdinal("LName"))
                            c.CompanyName = dr.GetString(dr.GetOrdinal("CompanyName"))
                            c.CompanyProfile = dr.GetString(dr.GetOrdinal("CompanyProfile"))
                            c.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                            c.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                            c.City = dr.GetString(dr.GetOrdinal("City"))
                            c.CountryID = dr.GetInt32(dr.GetOrdinal("CountryID"))
                            c.StateID = dr.GetInt32(dr.GetOrdinal("StateID"))
                            c.ZIP = dr.GetString(dr.GetOrdinal("Zip"))
                            c.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                            c.Fax = dr.GetString(dr.GetOrdinal("Fax"))
                            c.CompanyEmail = dr.GetString(dr.GetOrdinal("CompanyEmail"))
                            c.WebSiteURL = dr.GetString(dr.GetOrdinal("WebSiteUrl"))
                        End While
                        dr.Close()
                        Return c
                    Else
                        dr.Close()
                        Return Nothing
                    End If

                End Using
            End Using
        End Function

        Public Shared Function GetCompany(CompanyID As Integer) As Company
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[Companies_SelectOne]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
                    End With

                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    If dr.HasRows Then
                        Dim c = New Company
                        While dr.Read
                            c.CompanyID = dr.GetInt32(dr.GetOrdinal("CompanyID"))
                            c.UserName = dr.GetString(dr.GetOrdinal("UserName"))
                            c.FName = dr.GetString(dr.GetOrdinal("FName"))
                            c.MName = dr.GetString(dr.GetOrdinal("MName"))
                            c.LName = dr.GetString(dr.GetOrdinal("LName"))
                            c.CompanyName = dr.GetString(dr.GetOrdinal("CompanyName"))
                            c.CompanyProfile = dr.GetString(dr.GetOrdinal("CompanyProfile"))
                            c.Address1 = dr.GetString(dr.GetOrdinal("Address1"))
                            c.Address2 = dr.GetString(dr.GetOrdinal("Address2"))
                            c.City = dr.GetString(dr.GetOrdinal("City"))
                            c.CountryID = dr.GetInt32(dr.GetOrdinal("CountryID"))
                            c.StateID = dr.GetInt32(dr.GetOrdinal("StateID"))
                            c.ZIP = dr.GetString(dr.GetOrdinal("Zip"))
                            c.Phone = dr.GetString(dr.GetOrdinal("Phone"))
                            c.Fax = dr.GetString(dr.GetOrdinal("Fax"))
                            c.CompanyEmail = dr.GetString(dr.GetOrdinal("CompanyEmail"))
                            c.WebSiteURL = dr.GetString(dr.GetOrdinal("WebSiteUrl"))
                        End While

                        dr.Close()
                        Return c
                    Else
                        dr.Close()
                        Return Nothing
                    End If

                End Using
            End Using
        End Function

        Public Shared Function GetCompanyName(CompanyID As Integer) As String
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand()

                    con.Open()

                    With cmd
                        .CommandText = "[Companies_SelectName]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@CompanyID", CompanyID))
                    End With

                    Return CType(cmd.ExecuteScalar, String)

                End Using
            End Using
        End Function

        Public Shared Function GetCompanyCount() As Integer
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand()

                    con.Open()

                    With cmd
                        .CommandText = "[Companies_GetCount]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                    End With

                    Return CType(cmd.ExecuteScalar, Integer)

                End Using
            End Using
        End Function
    End Class
End Namespace
