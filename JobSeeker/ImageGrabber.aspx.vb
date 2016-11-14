Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Partial Class JobSeekerImageGrabber
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim dr As DataRow
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim dbAccess As New DataAccess

            Using con As New SqlConnection(dbAccess.ConnectionString)
                con.Open()

                da.SelectCommand = New SqlCommand
                With da.SelectCommand
                    .CommandText = "SELECT * FROM dbo.JSPhotos WHERE JobSeekerID = @JobSeekerID"
                    .CommandType = CommandType.Text
                    .Connection = con
                    .CommandTimeout = 120
                    .Parameters.Add(New SqlParameter("@JobSeekerID", SqlDbType.Int, 100)).Value =
                        Request.QueryString("ID")
                    .ExecuteNonQuery()
                End With

                da.Fill(ds)
                dr = ds.Tables(0).Rows(0)
                Dim conType As String = dr.Item("FileType").ToString()
                Dim arrContent = CType(dr.Item("Photo"), Byte())
                Response.ContentType = conType
                Response.OutputStream.Write(arrContent, 0, dr.Item("FileLength"))
                Response.End()
            End Using
        Catch ex As Exception
        End Try
    End Sub
End Class
