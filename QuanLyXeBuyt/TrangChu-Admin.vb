Imports System.Data.SqlClient

Public Class AdminTrangChu
    Private baseForm As New BaseForm()
    Private dao As New TrangChuDAO()
    Private connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"
    Private isViewingTickets As Boolean = False
    Private Sub AdminTrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowBusList()
        LoadDanhSachTuyenDuong()
        CapNhatThongKe()
        Timer1.Interval = 1000
        Timer1.Start()
        AddHandler btnThemXe.Click, AddressOf btnThemXeMoi_Click
        AddHandler btnChiTietVe.Click, AddressOf btnChiTietVe_Click
        AddHandler btnXoaVe.Click, AddressOf btnXoaVe_Click
        AddHandler btnXemLichTrinh.Click, AddressOf btnXemLichTrinh_Click
        AddHandler timKiem.Click, AddressOf timKiem_Click
    End Sub

    Private Sub ShowBusList()
        DataGridView1.DataSource = dao.LayDanhSachXeKhachCoTuyen()
        isViewingTickets = False
    End Sub

    Private Sub LoadDanhSachTuyenDuong()
        Dim dt As DataTable = dao.LayDanhSachTuyenDuong()
        ComboBoxMaTuyenDuong.DataSource = dt
        ComboBoxMaTuyenDuong.DisplayMember = "TuyenDuong"
        ComboBoxMaTuyenDuong.ValueMember = "id_TuyenDuong"
        If dt.Rows.Count > 0 Then ComboBoxMaTuyenDuong.SelectedIndex = 0
    End Sub

    Private Sub timKiem_Click(sender As Object, e As EventArgs)
        Dim tuKhoa = txtBienSo.Text.Trim
        DataGridView1.DataSource = dao.TimKiemTheoBienSoCoTuyen(tuKhoa)
    End Sub

    Private Sub btnThemXeMoi_Click(sender As Object, e As EventArgs)
        If TextBoxBienSo.Text = "" OrElse TextBoxTenXeKhach.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bienSo As String = TextBoxBienSo.Text.Trim()
        Dim tenXe As String = TextBoxTenXeKhach.Text.Trim()
        Dim gioDi As DateTime = DateTimePickerNgayDi.Value
        Dim gioDen As DateTime = DateTimePickerNgayDen.Value
        Dim maTuyen As Integer = Convert.ToInt32(ComboBoxMaTuyenDuong.SelectedValue)

        dao.ThemXeKhach(bienSo, tenXe, gioDi, gioDen, maTuyen)
        ShowBusList()
        CapNhatThongKe()
    End Sub
    Private Sub btnChiTietVe_Click(sender As Object, e As EventArgs)
        LoadAllTickets()
    End Sub
    Private Sub LoadAllTickets()
        Dim query As String = "
            SELECT VE.id_Ve AS [Mã vé],
                   NGUOIDUNG.ho_Ten AS [Khách hàng],
                   NGUOIDUNG.so_Dien_Thoai AS [SĐT],
                   XEKHACH.ten_XeKhach AS [Tên xe khách],
                   XEKHACH.bien_So AS [Biển số],
                   VE.ngay_Dat AS [Thời gian đặt],
                   VE.trang_Thai AS [Trạng thái]
            FROM VE
            INNER JOIN NGUOIDUNG ON VE.id_NguoiDung = NGUOIDUNG.id_NguoiDung
            INNER JOIN XEKHACH ON VE.id_XeKhach = XEKHACH.id_XeKhach
            ORDER BY VE.ngay_Dat DESC"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                DataGridView1.DataSource = dt
            End Using
        End Using
        isViewingTickets = True
    End Sub
    Private Sub btnXoaVe_Click(sender As Object, e As EventArgs)
        If Not isViewingTickets Then
            MessageBox.Show("Chức năng xóa vé chỉ dùng khi đang xem danh sách vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn vé cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim maVe As Object = row.Cells("Mã vé").Value

        Dim result = MessageBox.Show($"Bạn có chắc chắn muốn xóa vé có mã {maVe}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            DeleteTicket(maVe)
            MessageBox.Show("Đã xóa vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllTickets()
            CapNhatThongKe()
        End If
    End Sub

    Private Sub DeleteTicket(maVe As Object)
        Dim query As String = "DELETE FROM VE WHERE id_Ve = @id"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", maVe)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub btnXemLichTrinh_Click(sender As Object, e As EventArgs) Handles btnXemLichTrinh.Click
        Try
            baseForm.LoadFormWithFade(New TuyenDuong, PanelContainer)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi chuyển sang form Lịch Trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LịchTrìnhVàTuyếnĐườngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Click
        Try
            baseForm.LoadFormWithFade(New TuyenDuong(), PanelContainer)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi chuyển sang form Lịch Trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DanhSáchXeBuýtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchXeBuýtToolStripMenuItem.Click
        Try
            baseForm.LoadFormWithFade(New DanhSachXeBuyt(), PanelContainer)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi chuyển sang form Danh Sách Xe Buýt: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        Try
            Me.Controls.Clear()
            InitializeComponent()
            AdminTrangChu_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi tải lại form Trang Chủ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Me.Hide()
        Dim frmLogin As New DangNhap()
        frmLogin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub CapNhatThongKe()
        lblVeDatValue.Text = DemVeTheoNgay("Đã đặt").ToString()
        lblVeHuyValue.Text = DemVeTheoNgay("Đã hủy").ToString()
        lblTongTuyenValue.Text = DemTongTuyen().ToString()
    End Sub

    Private Function DemVeTheoNgay(trangThai As String) As Integer
        Dim sql = "SELECT COUNT(*) FROM VE WHERE trang_Thai = @trangThai AND CONVERT(date, ngay_Dat) = CONVERT(date, GETDATE())"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@trangThai", trangThai)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Function DemTongTuyen() As Integer
        Dim sql = "SELECT COUNT(*) FROM TUYENDUONG"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label9.Click
        ' No action needed
    End Sub
End Class
