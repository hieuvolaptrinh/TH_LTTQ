Public Class InThongKe
    Private Sub InThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kết nối đến SQL Server và lấy dữ liệu
        Dim connStr As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"
        Dim query As String =
            "SELECT
            FORMAT(VE.ngay_Dat, 'MM/yyyy') AS Thang,
            COUNT(*) AS TongSoVe,
            SUM(CASE WHEN VE.trang_Thai = N'Đã đặt' THEN 1 ELSE 0 END) AS SoVeDaDat,
            SUM(CASE WHEN VE.trang_Thai = N'Đã hủy' THEN 1 ELSE 0 END) AS SoVeDaHuy,
            SUM(CASE WHEN VE.trang_Thai = N'Đã đặt' THEN CAST(XK.gia_Ve AS MONEY) ELSE 0 END) AS TongDoanhThu
        FROM VE
        INNER JOIN XEKHACH XK ON VE.id_XeKhach = XK.id_XeKhach
        GROUP BY FORMAT(VE.ngay_Dat, 'MM/yyyy')
        ORDER BY MIN(VE.ngay_Dat)"

        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlClient.SqlCommand(query, conn)
                conn.Open()
                Using adapter As New SqlClient.SqlDataAdapter(cmd)
                    adapter.Fill(ThongKeDoanhThuDataSet.DataTable1)
                End Using
            End Using
        End Using

        ' Cập nhật ReportViewer
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class