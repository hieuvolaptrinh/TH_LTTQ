Public Class QuanLy


    Private Sub QuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()

        dt.Columns.Add("Họ và Tên")
        dt.Columns.Add("Số CCCD")
        dt.Columns.Add("Địa chỉ")
        dt.Columns.Add("Ngày cấp")
        dt.Columns.Add("Quê Quán")
        dt.Columns.Add("Giới tính")
        dt.Rows.Add("Nguyễn Văn A", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn B", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn C", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn D", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn E", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn F", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn G", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn H", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn I", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")
        dt.Rows.Add("Nguyễn Văn K", "123456789", "Hà Nội", "01/01/2021", "Hà Nội", "Nam")

        DataGridViewCCCD.DataSource = dt
        ' Tùy chỉnh DataGridView
        DataGridViewCCCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCCCD.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
        DieuKhien.Show()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Close()
        HoSoLienQuan.Show()
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