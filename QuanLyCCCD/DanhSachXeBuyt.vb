Public Class DanhSachXeBuyt
    Private xeBuytDAO As New DanhSachXeBuytDAO()

    ' Hàm thiết lập tiêu đề cho các cột của DataGridView
    Private Sub SetDataGridViewHeaders()
        Try
            With DataGridViewXeKhach
                If .Columns.Count > 0 Then
                    .Columns("bien_So").HeaderText = "Biển Số Xe"
                    .Columns("ten_XeKhach").HeaderText = "Tên Xe Khách"
                    .Columns("gio_Di").HeaderText = "Giờ Đi"
                    .Columns("gio_Den").HeaderText = "Giờ Đến"
                    .Columns("id_TuyenDuong").HeaderText = "Mã Tuyến Đường"
                    .Columns("diem_di").HeaderText = "Điểm Đi"
                    .Columns("diem_den").HeaderText = "Điểm Đến"
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thiết lập tiêu đề cột: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tải dữ liệu khi form được mở
    Private Sub DanhSachXeBuyt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Đảm bảo tiêu đề cột được hiển thị
        DataGridViewXeKhach.ColumnHeadersVisible = True

        ' Tải danh sách xe khách vào DataGridView
        Dim dt As DataTable = xeBuytDAO.LayDanhSachXeKhach()
        If dt.Rows.Count > 0 Then
            DataGridViewXeKhach.DataSource = dt
            SetDataGridViewHeaders() ' Gọi hàm thiết lập tiêu đề
        Else
            MessageBox.Show("Không có dữ liệu xe khách để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Tải danh sách mã tuyến đường vào ComboBox
        Dim dtTuyenDuong As DataTable = xeBuytDAO.LayDanhSachTuyenDuong()
        ComboBoxMaTuyenDuong.DataSource = dtTuyenDuong
        ComboBoxMaTuyenDuong.DisplayMember = "TuyenDuong"
        ComboBoxMaTuyenDuong.ValueMember = "id_TuyenDuong"
    End Sub

    ' Xử lý sự kiện click vào hàng trong DataGridView
    Private Sub DataGridViewXeKhach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewXeKhach.CellClick
        ' Kiểm tra xem có hàng nào được chọn không
        If e.RowIndex >= 0 Then
            Try
                Dim selectedRow As DataGridViewRow = DataGridViewXeKhach.Rows(e.RowIndex)

                ' Kiểm tra giá trị null trước khi gán vào các điều khiển
                TextBoxBienSo.Text = If(selectedRow.Cells("bien_So").Value IsNot Nothing, selectedRow.Cells("bien_So").Value.ToString(), "")
                TextBoxTenXeKhach.Text = If(selectedRow.Cells("ten_XeKhach").Value IsNot Nothing, selectedRow.Cells("ten_XeKhach").Value.ToString(), "")

                ' Kiểm tra và chuyển đổi giá trị DateTime
                If selectedRow.Cells("gio_Di").Value IsNot Nothing AndAlso IsDate(selectedRow.Cells("gio_Di").Value) Then
                    DateTimePickerNgayDi.Value = Convert.ToDateTime(selectedRow.Cells("gio_Di").Value)
                Else
                    DateTimePickerNgayDi.Value = DateTime.Now
                End If

                If selectedRow.Cells("gio_Den").Value IsNot Nothing AndAlso IsDate(selectedRow.Cells("gio_Den").Value) Then
                    DateTimePickerNgayDen.Value = Convert.ToDateTime(selectedRow.Cells("gio_Den").Value)
                Else
                    DateTimePickerNgayDen.Value = DateTime.Now
                End If

                ' Gán giá trị cho ComboBox
                If selectedRow.Cells("id_TuyenDuong").Value IsNot Nothing Then
                    ComboBoxMaTuyenDuong.SelectedValue = Convert.ToInt32(selectedRow.Cells("id_TuyenDuong").Value)
                Else
                    ComboBoxMaTuyenDuong.SelectedIndex = -1
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi khi hiển thị dữ liệu lên điều khiển: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Xóa xe khách
    Private Sub xoaXe_Click(sender As Object, e As EventArgs) Handles xoaXe.Click
        If TextBoxBienSo.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập biển số xe để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bienSo As String = TextBoxBienSo.Text.Trim()
        xeBuytDAO.XoaXeKhach(bienSo)

        ' Cập nhật lại DataGridView sau khi xóa
        Dim dt As DataTable = xeBuytDAO.LayDanhSachXeKhach()
        DataGridViewXeKhach.DataSource = dt
        If dt.Rows.Count > 0 Then
            SetDataGridViewHeaders() ' Gọi lại hàm thiết lập tiêu đề
        End If
        MessageBox.Show("Xóa xe khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Xóa trắng các ô nhập liệu
        TextBoxBienSo.Clear()
        TextBoxTenXeKhach.Clear()
        DateTimePickerNgayDi.Value = DateTime.Now
        DateTimePickerNgayDen.Value = DateTime.Now
        ComboBoxMaTuyenDuong.SelectedIndex = -1
    End Sub

    ' Thêm xe khách
    Private Sub themXe_Click(sender As Object, e As EventArgs) Handles themXe.Click
        ' Kiểm tra dữ liệu đầu vào
        If TextBoxBienSo.Text.Trim() = "" OrElse TextBoxTenXeKhach.Text.Trim() = "" OrElse ComboBoxMaTuyenDuong.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin xe khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bienSo As String = TextBoxBienSo.Text.Trim()
        Dim tenXeKhach As String = TextBoxTenXeKhach.Text.Trim()
        Dim gioDi As DateTime = DateTimePickerNgayDi.Value
        Dim gioDen As DateTime = DateTimePickerNgayDen.Value
        Dim idTuyenDuong As Integer = Convert.ToInt32(ComboBoxMaTuyenDuong.SelectedValue)

        ' Kiểm tra giờ đến phải sau giờ đi
        If gioDen <= gioDi Then
            MessageBox.Show("Giờ đến phải sau giờ đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        xeBuytDAO.ThemXeKhach(bienSo, tenXeKhach, gioDi, gioDen, idTuyenDuong)

        ' Cập nhật lại DataGridView sau khi thêm
        Dim dt As DataTable = xeBuytDAO.LayDanhSachXeKhach()
        DataGridViewXeKhach.DataSource = dt
        If dt.Rows.Count > 0 Then
            SetDataGridViewHeaders() ' Gọi lại hàm thiết lập tiêu đề
        End If
        MessageBox.Show("Thêm xe khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Xóa trắng các ô nhập liệu
        TextBoxBienSo.Clear()
        TextBoxTenXeKhach.Clear()
        DateTimePickerNgayDi.Value = DateTime.Now
        DateTimePickerNgayDen.Value = DateTime.Now
        ComboBoxMaTuyenDuong.SelectedIndex = -1
    End Sub

    ' Chỉnh sửa xe khách
    Private Sub chinhSua_Click(sender As Object, e As EventArgs) Handles chinhSua.Click
        ' Kiểm tra dữ liệu đầu vào
        If TextBoxBienSo.Text.Trim() = "" OrElse TextBoxTenXeKhach.Text.Trim() = "" OrElse ComboBoxMaTuyenDuong.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin xe khách để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bienSo As String = TextBoxBienSo.Text.Trim()
        Dim tenXeKhach As String = TextBoxTenXeKhach.Text.Trim()
        Dim gioDi As DateTime = DateTimePickerNgayDi.Value
        Dim gioDen As DateTime = DateTimePickerNgayDen.Value
        Dim idTuyenDuong As Integer = Convert.ToInt32(ComboBoxMaTuyenDuong.SelectedValue)

        ' Kiểm tra giờ đến phải sau giờ đi
        If gioDen <= gioDi Then
            MessageBox.Show("Giờ đến phải sau giờ đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        xeBuytDAO.SuaXeKhach(bienSo, tenXeKhach, gioDi, gioDen, idTuyenDuong)

        ' Cập nhật lại DataGridView sau khi chỉnh sửa
        Dim dt As DataTable = xeBuytDAO.LayDanhSachXeKhach()
        DataGridViewXeKhach.DataSource = dt
        If dt.Rows.Count > 0 Then
            SetDataGridViewHeaders() ' Gọi lại hàm thiết lập tiêu đề
        End If
        MessageBox.Show("Chỉnh sửa xe khách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Xóa trắng các ô nhập liệu
        TextBoxBienSo.Clear()
        TextBoxTenXeKhach.Clear()
        DateTimePickerNgayDi.Value = DateTime.Now
        DateTimePickerNgayDen.Value = DateTime.Now
        ComboBoxMaTuyenDuong.SelectedIndex = -1
    End Sub

    ' Tìm kiếm xe khách theo biển số
    Private Sub timKiem_Click(sender As Object, e As EventArgs) Handles timKiem.Click
        If txtBienSo.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập biển số xe để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bienSo As String = txtBienSo.Text.Trim()
        Dim dt As DataTable = xeBuytDAO.TimKiemTheoBienSo(bienSo)
        DataGridViewXeKhach.DataSource = dt
        If dt.Rows.Count > 0 Then
            SetDataGridViewHeaders() ' Gọi lại hàm thiết lập tiêu đề
        End If

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Không tìm thấy xe khách với biển số này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class