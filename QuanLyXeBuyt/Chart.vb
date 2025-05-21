Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Reporting

Public Class Chart
    ' Thay chuỗi kết nối dưới đây cho phù hợp với máy của bạn
    Dim connectionString As String = "Data Source=POTATO\SQLEXPRESS;Initial Catalog=QuanLyVeKhach;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChart()
    End Sub

    Private Sub LoadChart()
        Dim query As String = "SELECT trang_Thai, COUNT(*) AS SoLuong FROM VE GROUP BY trang_Thai"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Xóa dữ liệu cũ
            Chart1.Series.Clear()

            ' Tạo series mới dạng cột
            Dim series As New Series("Số lượng vé")
            series.ChartType = SeriesChartType.Column
            series.IsValueShownAsLabel = True

            While reader.Read()
                Dim trangThai As String = reader("trang_Thai").ToString()
                Dim soLuong As Integer = Convert.ToInt32(reader("SoLuong"))
                series.Points.AddXY(trangThai, soLuong)
            End While

            Chart1.Series.Add(series)
            reader.Close()
        End Using
    End Sub
End Class
