Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Namespace JobSite.BusinessObjectLayer
    Public Class Photo
        Public Sub New()
        End Sub

        Private _jobSeekerId As Integer
        Private _attachmentId As Integer
        Private _photo As Image
        Private _photoFileName As String
        Private _fileType As String
        Private _fileLength As Integer

        Public Property JobSeekerId As Integer
            Get
                Return _JobSeekerID
            End Get
            Set
                _JobSeekerID = value
            End Set
        End Property

        Public Property AttachmentId As Integer
            Get
                Return _AttachmentID
            End Get
            Set
                _AttachmentID = value
            End Set
        End Property

        Public Property Photo As Image
            Get
                Return _Photo
            End Get
            Set
                _Photo = value
            End Set
        End Property

        Public Property PhotoFileName As String
            Get
                Return _PhotoFileName
            End Get
            Set
                _PhotoFileName = value
            End Set
        End Property

        Public Property FileType As String
            Get
                Return _FileType
            End Get
            Set
                _FileType = value
            End Set
        End Property

        Public Property FileLength As Integer
            Get
                Return _FileLength
            End Get
            Set
                _FileLength = value
            End Set
        End Property

        Public Shared Function Insert(p As Photo) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSPhotos_Insert]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", p.JobSeekerID))
                        .Parameters.Add(New SqlParameter("@Photo", p.Photo))
                        .Parameters.Add(New SqlParameter("@PhotoFileName", p.PhotoFileName))
                        .Parameters.Add(New SqlParameter("@FileType", p.FileType))
                        .Parameters.Add(New SqlParameter("@FileLength", p.FileLength))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Delete(p As Photo) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSPhotos_Delete]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@AttachmentID", p.AttachmentID))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function Update(p As Photo) As SqlCommand
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSPhotos_Update]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", p.JobSeekerID))
                        .Parameters.Add(New SqlParameter("@Photo", p.Photo))
                        .Parameters.Add(New SqlParameter("@PhotoFileName", p.PhotoFileName))
                        .Parameters.Add(New SqlParameter("@FileType", p.FileType))
                        .Parameters.Add(New SqlParameter("@FileLength", p.FileLength))
                        .ExecuteNonQuery()
                    End With

                    Return cmd

                End Using
            End Using
        End Function

        Public Shared Function GetPhotoFilePath(id As Integer) As String
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using cmd = New SqlCommand

                    con.Open()

                    With cmd
                        .CommandText = "[JSPhotos_SelectByUser]"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .Parameters.Add(New SqlParameter("@JobSeekerID", id))
                    End With

                    Return CType(cmd.ExecuteScalar, String)

                End Using
            End Using
        End Function

        Public Shared Function GetPhotos() As DataSet
            Dim dbAccess = New DataAccess
            Using con = New SqlConnection(dbAccess.ConnectionString)
                Using da = New SqlDataAdapter

                    con.Open()

                    da.SelectCommand = New SqlCommand() With {
                        .CommandText = "[JSPhotos_SelectAll]",
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
