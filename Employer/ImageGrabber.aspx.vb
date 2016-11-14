Imports System.Data
Imports System.Data.SqlClient
Imports JobSite.DataAccessLayer

Partial Class EmployerImageGrabber
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim dbAccess = New DataAccess
            Dim con = New SqlConnection(dbAccess.ConnectionString)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim dr As DataRow
            Dim arrContent As Byte()

            con.Open()

            With da
                .SelectCommand = New SqlCommand
                With .SelectCommand
                    .CommandText = "SELECT * FROM dbo.JSPhotos WHERE JobSeekerID=@JobSeekerID"
                    .CommandType = CommandType.Text
                    .Connection = con
                    .CommandTimeout = 120
                    .Parameters.Add(New SqlParameter("@JobSeekerID", SqlDbType.Int, 100)).Value =
                        Request.QueryString("ID")
                    .ExecuteNonQuery()
                End With
            End With

            da.Fill(ds)
            dr = ds.Tables(0).Rows(0)
            arrContent = CType(dr.Item("Photo"), Byte())
            Dim conType As String = dr.Item("FileType").ToString()
            Response.ContentType = conType
            Response.OutputStream.Write(arrContent, 0, dr.Item("FileLength"))
            Response.End()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class
