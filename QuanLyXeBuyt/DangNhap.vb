' DangNhap.vb

Imports System.Data.SqlClient

Public Class DangNhap
    Private connStr As String = "Data Source=localhost;Initial Catalog=QuanLyVeKhach;Integrated Security=True;TrustServerCertificate=True"
    Private Function GetNguoiDungId(username As String) As Integer
        Try
            Dim query As String = "SELECT id_NguoiDung FROM NGUOIDUNG WHERE ten_TaiKhoan = @TenTaiKhoan"
            Using conn As New SqlConnection(connStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", username)
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Lỗi lấy id người dùng: {ex.Message}")
        End Try
        Return -1
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = Guna2TextBox1.Text.Trim()
        Dim password As String = Guna2TextBox2.Text.Trim()

        Dim accountType As String = GetAccountType(username, password)
        If accountType = "admin" Then
            MessageBox.Show("Đăng nhập thành công với quyền ADMIN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim frm As New AdminTrangChu() ' TrangChu-Admin.vb
            frm.Show()
        ElseIf accountType = "user" Then
            MessageBox.Show("Đăng nhập thành công với quyền USER!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim userId As Integer = GetNguoiDungId(username)
            Dim frm As New UserTrangChu()
            frm.currentNguoiDungId = userId
            frm.Show()

        Else
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Returns "admin", "user", or "" if login fails
    Private Function GetAccountType(username As String, password As String) As String
        Try
            Dim query As String = "
                SELECT loai_TaiKhoan 
                FROM NGUOIDUNG 
                WHERE ten_TaiKhoan = @TenTaiKhoan AND mat_Khau = @MatKhau"
            Using conn As New SqlConnection(connStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", username)
                    cmd.Parameters.AddWithValue("@MatKhau", password)
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Return result.ToString().Trim().ToLower()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi kiểm tra đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ""
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
