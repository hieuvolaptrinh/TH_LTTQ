Public Class TrangChu
    Dim dao As New TrangChuDAO()

    Private Sub TrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiDanhSachXeKhach()
        LoadDanhSachTuyenDuong()
        AddHandler btnThemXe.Click, AddressOf btnThemXeMoi_Click
        AddHandler btnThoat.Click, AddressOf btnThoat_Click
        Timer1.Interval = 1000 ' Cập nhật mỗi 1 giây
        Timer1.Start()
    End Sub

    Private Sub HienThiDanhSachXeKhach()
        DataGridView1.DataSource = dao.LayDanhSachXeKhachCoTuyen()
    End Sub

    Private Sub LoadDanhSachTuyenDuong()
        Dim dt As DataTable = dao.LayDanhSachTuyenDuong()
        ComboBoxMaTuyenDuong.DataSource = dt
        ComboBoxMaTuyenDuong.DisplayMember = "TuyenDuong"
        ComboBoxMaTuyenDuong.ValueMember = "id_TuyenDuong"
        ComboBoxMaTuyenDuong.SelectedIndex = 0
    End Sub

    Private Sub timKiem_Click(sender As Object, e As EventArgs) Handles timKiem.Click
        Dim tuKhoa As String = txtBienSo.Text.Trim()
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
        HienThiDanhSachXeKhach()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss") ' Định dạng 24h
    End Sub
End Class
