Imports System.Data.SqlClient

Public Class DatabaseHelper
    Private connectionString As String = "Server=POTATO\SQLEXPRESS;Database=QuanLyVeKhach;User Id=sa;Password=12345;"

    ' Hàm kiểm tra tồn tại tài khoản hoặc email
    Public Function KiemTraTonTai(tenTaiKhoan As String, email As String) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT COUNT(*) FROM NGUOIDUNG WHERE ten_TaiKhoan = @ten OR email = @em"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ten", tenTaiKhoan)
                cmd.Parameters.AddWithValue("@em", email)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Hàm thêm người dùng
    Public Function ThemNguoiDung(user As NguoiDung) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO NGUOIDUNG (ten_TaiKhoan, ho_Ten, email, so_Dien_Thoai, mat_Khau) VALUES (@tk, @ht, @em, @sdt, @mk)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@tk", user.TenTaiKhoan)
                cmd.Parameters.AddWithValue("@ht", user.HoTen)
                cmd.Parameters.AddWithValue("@em", user.Email)
                cmd.Parameters.AddWithValue("@sdt", user.SoDienThoai)
                cmd.Parameters.AddWithValue("@mk", user.MatKhau)
                Dim rows As Integer = cmd.ExecuteNonQuery()
                Return rows > 0
            End Using
        End Using
    End Function
End Class
