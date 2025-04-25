Public Class HoSoLienQuan
    Private Sub HoSoLienQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()

        dt.Columns.Add("Loại Giấy Tờ")
        dt.Columns.Add("Mã Số")
        dt.Columns.Add("Thông Tin Chi Tiết")
        dt.Rows.Add("Giấy phép lái xe", "123456789", "GPLX A1")

        dt.Rows.Add("Giấy phép lái xe", "123456789", "GPLX A1 - Xe Mô Tô")
        dt.Rows.Add("Giấy phép lái xe", "987654321", "GPLX B2 - Ô Tô Con")
        dt.Rows.Add("Chứng Minh Nhân Dân", "024599112", "CMND cũ - Còn Hiệu Lực")
        dt.Rows.Add("Hộ Chiếu", "P1234567", "Hộ Chiếu Việt Nam")
        dt.Rows.Add("Bằng Tốt Nghiệp", "DH2023001", "Đại Học Bách Khoa")
        dt.Rows.Add("Bảo Hiểm Y Tế", "BH9876543", "Mã Thẻ BHYT Quốc Gia")
        dt.Rows.Add("Chứng Nhận Đăng Ký Xe", "XM123456", "Xe Máy Honda")



        DataGridView1.DataSource = dt
        ' Tùy chỉnh DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
        DieuKhien.Show()
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Me.Close()
        QuanLy.Show()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.Close()
        TichHopGiayTo.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Close()
        ThongKe.Show()
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class