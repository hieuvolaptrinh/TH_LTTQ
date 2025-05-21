'Imports Microsoft.Data.SqlClient'
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class DangKiVip
    Private ReadOnly connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate input
        If Not ValidateInput() Then
            Return
        End If

        ' Check if username exists
        If UsernameExists(txtUsername.Text.Trim()) Then
            MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Register new user
        If RegisterUser() Then
            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Chuyển về form đăng nhập
            Dim frmDangNhap As New DangNhap()
            frmDangNhap.Show()
            Me.Close()
        Else
            MessageBox.Show("Đăng ký thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Check empty fields
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate username (only letters, numbers, and underscores)
        If Not Regex.IsMatch(txtUsername.Text.Trim(), "^[a-zA-Z0-9_]+$") Then
            MessageBox.Show("Tên tài khoản chỉ được chứa chữ cái, số và dấu gạch dưới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate phone number (10 digits)
        If Not Regex.IsMatch(txtPhone.Text.Trim(), "^[0-9]{10}$") Then
            MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate password length
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check password match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function UsernameExists(username As String) As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT COUNT(*) FROM NGUOIDUNG WHERE ten_TaiKhoan = @username", conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi kiểm tra tên tài khoản: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Return true to prevent registration in case of error
        End Try
    End Function

    Private Function RegisterUser() As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand("INSERT INTO NGUOIDUNG (ten_TaiKhoan, ho_Ten, so_Dien_Thoai, mat_Khau, loai_TaiKhoan) VALUES (@username, @fullName, @phone, @password, @userType)", conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@userType", "user") ' Mặc định là tài khoản user
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi đăng ký: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Chuyển về form đăng nhập
        Dim frmDangNhap As New DangNhap()
        frmDangNhap.Show()
        Me.Close()
    End Sub

    Private Sub DangKiVip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set focus to username textbox
        txtUsername.Focus()
    End Sub

    ' Thêm các hiệu ứng hover cho nút
    Private Sub btnRegister_MouseHover(sender As Object, e As EventArgs) Handles btnRegister.MouseHover
        btnRegister.FillColor = Color.FromArgb(76, 175, 80)
        btnRegister.FillColor2 = Color.FromArgb(33, 150, 243)
    End Sub

    Private Sub btnRegister_MouseLeave(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.FillColor = Color.FromArgb(255, 192, 255)
        btnRegister.FillColor2 = Color.Fuchsia
    End Sub

    Private Sub btnBack_MouseHover(sender As Object, e As EventArgs) Handles btnBack.MouseHover
        btnBack.FillColor = Color.FromArgb(97, 97, 97)
        btnBack.FillColor2 = Color.FromArgb(158, 158, 158)
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.FillColor = Color.FromArgb(158, 158, 158)
        btnBack.FillColor2 = Color.FromArgb(97, 97, 97)
    End Sub
End Class