Imports System.Windows.Forms

Public Class Form1
    Dim db As New DatabaseHelper

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        ' Lấy dữ liệu từ form
        Dim tenDangNhap As String = txtTenDangNhap.Text.Trim()
        Dim hoTen As String = txtHoVaTen.Text.Trim()
        Dim sdt_Email As String = txtSDT_Email.Text.Trim()
        Dim matKhau As String = txtMatKhau.Text.Trim()
        Dim nhapLaiMatKhau As String = txtNhapLaiMatKhau.Text.Trim()

        ' Kiểm tra nhập đầy đủ
        If tenDangNhap = "" Or hoTen = "" Or sdt_Email = "" Or matKhau = "" Or nhapLaiMatKhau = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kiểm tra mật khẩu khớp nhau
        If matKhau <> nhapLaiMatKhau Then
            MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Phân tích SDT hoặc Email
        Dim isEmail As Boolean = sdt_Email.Contains("@")
        Dim email As String = If(isEmail, sdt_Email, "")
        Dim soDienThoai As String = If(isEmail, "", sdt_Email)

        ' Kiểm tra trùng tên tài khoản hoặc email
        If db.KiemTraTonTai(tenDangNhap, email) Then
            MessageBox.Show("Tên tài khoản hoặc Email đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tạo đối tượng người dùng mới
        Dim user As New NguoiDung With {
            .TenTaiKhoan = tenDangNhap,
            .HoTen = hoTen,
            .Email = email,
            .SoDienThoai = soDienThoai,
            .MatKhau = matKhau
        }

        ' Thêm vào CSDL
        If db.ThemNguoiDung(user) Then
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
