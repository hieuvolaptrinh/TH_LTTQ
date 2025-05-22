Imports System.Data
Imports System.Data.SqlClient

Module TestThongKeVe

    Sub Main()
        ' Kết nối tới SQL Server
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

        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        ' Kiểm tra các cột cần thiết
        If Not (dt.Columns.Contains("Thang") AndAlso
                dt.Columns.Contains("TongSoVe") AndAlso
                dt.Columns.Contains("SoVeDaDat") AndAlso
                dt.Columns.Contains("SoVeDaHuy") AndAlso
                dt.Columns.Contains("TongDoanhThu")) Then
            Console.WriteLine("Lỗi: Không đủ cột dữ liệu cần thiết!")
            Return
        End If

        ' In ra dữ liệu thống kê từng tháng
        For Each row As DataRow In dt.Rows
            Console.WriteLine("Tháng: {0}, Tổng số vé: {1}, Số vé đã đặt: {2}, Số vé đã hủy: {3}, Tổng doanh thu: {4}",
                              row("Thang"), row("TongSoVe"), row("SoVeDaDat"), row("SoVeDaHuy"), row("TongDoanhThu"))
        Next

        ' Kiểm tra số lượng dòng dữ liệu
        If dt.Rows.Count = 0 Then
            Console.WriteLine("Không có dữ liệu thống kê!")
        Else
            Console.WriteLine("Đã lấy được {0} dòng dữ liệu thống kê.", dt.Rows.Count)
        End If

        ' Kiểm tra kiểu dữ liệu của các cột (nếu có dữ liệu)
        If dt.Rows.Count > 0 Then
            Dim row = dt.Rows(0)
            If Not TypeOf row("Thang") Is String Then
                Console.WriteLine("Lỗi: Thang không phải kiểu String!")
            End If
            If Not IsNumeric(row("TongSoVe")) Then
                Console.WriteLine("Lỗi: TongSoVe không phải kiểu số!")
            End If
            If Not IsNumeric(row("SoVeDaDat")) Then
                Console.WriteLine("Lỗi: SoVeDaDat không phải kiểu số!")
            End If
            If Not IsNumeric(row("SoVeDaHuy")) Then
                Console.WriteLine("Lỗi: SoVeDaHuy không phải kiểu số!")
            End If
            If Not IsNumeric(row("TongDoanhThu")) Then
                Console.WriteLine("Lỗi: TongDoanhThu không phải kiểu số thực!")
            End If
        End If
    End Sub

End Module

Partial Public Class ThongKeDoanhThuDataSet
    Partial Public Class DataTable1DataTable
        Private Sub DataTable1DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ThangColumn.ColumnName) Then
                'Add user code here
            End If
        End Sub

        Private Sub DataTable1DataTable_DataTable1RowChanging(sender As Object, e As DataTable1RowChangeEvent) Handles Me.DataTable1RowChanging

        End Sub

    End Class
End Class