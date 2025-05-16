Imports System.Data.SqlClient

Public Class TrangChuDAO

    Private connStr As String = "Data Source=localhost;Initial Catalog=QuanLyVeKhach;Integrated Security=True;TrustServerCertificate=True"
    Private conn As SqlConnection

    Public Sub New()
        conn = New SqlConnection(connStr)
    End Sub

    ' Thêm xe khách mới
    Public Sub ThemXeKhach(bienSo As String, tenXeKhach As String, gioDi As DateTime, gioDen As DateTime, idTuyenDuong As Integer)
        Try
            conn.Open()
            Dim query As String = "INSERT INTO XEKHACH (bien_So, ten_XeKhach, gio_Di, gio_Den, id_TuyenDuong) VALUES (@BienSo, @TenXeKhach, @GioDi, @GioDen, @IdTuyenDuong)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BienSo", bienSo)
            cmd.Parameters.AddWithValue("@TenXeKhach", tenXeKhach)
            cmd.Parameters.AddWithValue("@GioDi", gioDi)
            cmd.Parameters.AddWithValue("@GioDen", gioDen)
            cmd.Parameters.AddWithValue("@IdTuyenDuong", idTuyenDuong)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm xe khách: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Sửa thông tin xe khách
    Public Sub SuaXeKhach(bienSo As String, tenXeKhach As String, gioDi As DateTime, gioDen As DateTime, idTuyenDuong As Integer)
        Try
            conn.Open()
            Dim query As String = "UPDATE XEKHACH SET ten_XeKhach = @TenXeKhach, gio_Di = @GioDi, gio_Den = @GioDen, id_TuyenDuong = @IdTuyenDuong WHERE bien_So = @BienSo"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BienSo", bienSo)
            cmd.Parameters.AddWithValue("@TenXeKhach", tenXeKhach)
            cmd.Parameters.AddWithValue("@GioDi", gioDi)
            cmd.Parameters.AddWithValue("@GioDen", gioDen)
            cmd.Parameters.AddWithValue("@IdTuyenDuong", idTuyenDuong)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa xe khách: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Xóa xe khách
    Public Sub XoaXeKhach(bienSo As String)
        Try
            conn.Open()
            Dim query As String = "DELETE FROM XEKHACH WHERE bien_So = @BienSo"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BienSo", bienSo)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa xe khách: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Lấy danh sách xe khách cùng tuyến đường (để hiển thị đẹp)
    Public Function LayDanhSachXeKhachCoTuyen() As DataTable
        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT X.bien_So, X.ten_XeKhach, X.gio_Di, X.gio_Den, X.id_TuyenDuong, T.diem_di, T.diem_den " &
                                  "FROM XEKHACH X JOIN TUYENDUONG T ON X.id_TuyenDuong = T.id_TuyenDuong"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy danh sách xe khách: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function

    ' Lấy danh sách xe khách (đơn giản - dùng nội bộ)
    Public Function LayTatCaXeKhach() As DataTable
        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM XEKHACH"
            Dim adapter As New SqlDataAdapter(query, conn)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy dữ liệu xe khách: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function

    ' Tìm kiếm xe khách theo biển số (chi tiết)
    Public Function TimKiemTheoBienSoCoTuyen(bienSo As String) As DataTable
        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT X.bien_So, X.ten_XeKhach, X.gio_Di, X.gio_Den, X.id_TuyenDuong, T.diem_di, T.diem_den " &
                                  "FROM XEKHACH X JOIN TUYENDUONG T ON X.id_TuyenDuong = T.id_TuyenDuong " &
                                  "WHERE X.bien_So LIKE '%' + @BienSo + '%'"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@BienSo", bienSo)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm xe khách: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function

    ' Tìm kiếm xe khách đơn giản (không cần join tuyến)
    Public Function TimKiemXeKhachDonGian(bienSo As String) As DataTable
        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM XEKHACH WHERE bien_So LIKE @bienSo"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@bienSo", "%" & bienSo & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm xe: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function

    ' Lấy danh sách tuyến đường
    Public Function LayDanhSachTuyenDuong() As DataTable
        Dim dt As New DataTable()
        Try
            conn.Open()
            Dim query As String = "SELECT id_TuyenDuong, diem_di + ' - ' + diem_den AS TuyenDuong FROM TUYENDUONG"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy danh sách tuyến đường: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function
    Public Function TimChuyen(diemDi As String, diemDen As String, ngayDi As Date?, ngayVe As Date?, isKhuHoi As Boolean) As DataTable
        Dim queryParts As New List(Of String)
        Dim parameters As New List(Of SqlParameter)

        ' Query for the outbound trip
        If Not String.IsNullOrWhiteSpace(diemDi) OrElse Not String.IsNullOrWhiteSpace(diemDen) OrElse ngayDi.HasValue Then
            Dim q1 As String = "
            SELECT x.id_XeKhach, td.diem_di, td.diem_den, x.gio_Di AS ngayDi, x.gio_Den, x.ten_XeKhach, x.bien_So
            FROM XEKHACH x
            JOIN TUYENDUONG td ON x.id_TuyenDuong = td.id_TuyenDuong
            WHERE 1=1"

            If Not String.IsNullOrWhiteSpace(diemDi) Then
                q1 &= " AND td.diem_di = @diemDi"
                parameters.Add(New SqlParameter("@diemDi", diemDi))
            End If

            If Not String.IsNullOrWhiteSpace(diemDen) Then
                q1 &= " AND td.diem_den = @diemDen"
                parameters.Add(New SqlParameter("@diemDen", diemDen))
            End If

            If ngayDi.HasValue AndAlso ngayDi.Value >= New Date(1753, 1, 1) Then
                q1 &= " AND CAST(x.gio_Di AS DATE) = @ngayDi"
                parameters.Add(New SqlParameter("@ngayDi", ngayDi.Value.Date))
            End If

            queryParts.Add(q1)
        End If

        ' Query for the return trip (if round-trip is selected)
        If isKhuHoi AndAlso Not String.IsNullOrWhiteSpace(diemDi) AndAlso Not String.IsNullOrWhiteSpace(diemDen) AndAlso ngayVe.HasValue Then
            If ngayVe.Value >= New Date(1753, 1, 1) Then
                Dim q2 As String = "
                SELECT x.id_XeKhach, td.diem_di, td.diem_den, x.gio_Di AS ngayDi, x.gio_Den, x.ten_XeKhach, x.bien_So
                FROM XEKHACH x
                JOIN TUYENDUONG td ON x.id_TuyenDuong = td.id_TuyenDuong
                WHERE td.diem_di = @diemDen2 AND td.diem_den = @diemDi2 AND CAST(x.gio_Di AS DATE) = @ngayVe"

                parameters.Add(New SqlParameter("@diemDen2", diemDen))
                parameters.Add(New SqlParameter("@diemDi2", diemDi))
                parameters.Add(New SqlParameter("@ngayVe", ngayVe.Value.Date))

                queryParts.Add(q2)
            End If
        End If

        ' If no conditions are provided, return an empty DataTable
        If queryParts.Count = 0 Then
            Return New DataTable()
        End If

        ' Combine the queries
        Dim fullQuery As String = String.Join(" UNION ", queryParts)

        ' Execute the query and return the results
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(fullQuery, conn)
                cmd.Parameters.AddRange(parameters.ToArray())
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
End Class
