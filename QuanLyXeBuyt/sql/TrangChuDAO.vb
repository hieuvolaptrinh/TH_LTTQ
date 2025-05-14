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

End Class
