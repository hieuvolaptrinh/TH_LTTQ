Imports Microsoft.Data.SqlClient

Public Class DatVeNe
    Private ReadOnly connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"
    Public currentNguoiDungId As Integer = -1
    Private Const GIA_VE_MAC_DINH As Decimal = 100000D
    Private isViewingTrips As Boolean = True

    Private Sub DatVeNe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If currentNguoiDungId <= 0 Then
            MessageBox.Show("Bạn cần đăng nhập trước khi đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If
        SetupDataGridView()
        ShowAllTrips()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
        AddHandler numSoLuongVe.ValueChanged, AddressOf numSoLuongVe_ValueChanged
    End Sub

    Private Sub SetupDataGridView()
        ' Thiết lập style cho DataGridView
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.BackgroundColor = Color.White

        ' Style cho header
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersHeight = 45
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        ' Style cho các dòng
        DataGridView1.RowTemplate.Height = 40
        DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243)
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.DefaultCellStyle.Padding = New Padding(5)

        ' Style cho dòng xen kẽ
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 247)
        DataGridView1.AlternatingRowsDefaultCellStyle.Font = New Font("Segoe UI", 10)
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

        ' Các thuộc tính khác
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.GridColor = Color.FromArgb(187, 222, 251) ' Màu đường kẻ giữa các dòng
    End Sub

    Private Sub ShowAllTrips(Optional diemDi As String = "", Optional diemDen As String = "")
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "
                SELECT 
                    X.id_XeKhach AS [Mã Xe],
                    X.ten_XeKhach AS [Tên Xe Khách], 
                    X.bien_So AS [Biển Số], 
                    FORMAT(X.gio_Di, 'dd/MM/yyyy HH:mm') AS [Giờ Khởi Hành],
                    FORMAT(X.gio_Den, 'dd/MM/yyyy HH:mm') AS [Giờ Đến], 
                    T.diem_di AS [Điểm Đi],
                    T.diem_den AS [Điểm Đến],
                    T.khoang_Cach_Km AS [Khoảng Cách (km)],
                    @giaVe AS [Giá Vé]
                FROM XEKHACH X
                INNER JOIN TUYENDUONG T ON X.id_TuyenDuong = T.id_TuyenDuong
                WHERE (T.diem_di LIKE @diemDi OR @diemDi = '')
                  AND (T.diem_den LIKE @diemDen OR @diemDen = '')
            "
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@giaVe", GIA_VE_MAC_DINH)
                cmd.Parameters.AddWithValue("@diemDi", "%" & diemDi & "%")
                cmd.Parameters.AddWithValue("@diemDen", "%" & diemDen & "%")

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                DataGridView1.DataSource = dt

                ' Ẩn cột Mã Xe (sẽ dùng để đặt vé)
                If DataGridView1.Columns.Contains("Mã Xe") Then
                    DataGridView1.Columns("Mã Xe").Visible = False
                End If

                ' Căn giữa một số cột
                For Each col As DataGridViewColumn In DataGridView1.Columns
                    Select Case col.Name
                        Case "Biển Số", "Giờ Khởi Hành", "Giờ Đến", "Khoảng Cách (km)", "Giá Vé"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End Select
                Next
            End Using
        End Using
        isViewingTrips = True
        numSoLuongVe.Value = 1
        TinhTongTien()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If isViewingTrips AndAlso DataGridView1.SelectedRows.Count > 0 Then
            TinhTongTien()
        End If
    End Sub

    Private Sub numSoLuongVe_ValueChanged(sender As Object, e As EventArgs) Handles numSoLuongVe.ValueChanged
        If isViewingTrips AndAlso DataGridView1.SelectedRows.Count > 0 Then
            TinhTongTien()
        End If
    End Sub

    Private Sub TinhTongTien()
        If Not isViewingTrips OrElse DataGridView1.SelectedRows.Count = 0 Then
            lblTongTienValue.Text = "0 VNĐ"
            Return
        End If

        Try
            Dim giaVe As Decimal = GIA_VE_MAC_DINH
            If DataGridView1.SelectedRows(0).Cells("Giá Vé").Value IsNot Nothing Then
                giaVe = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells("Giá Vé").Value)
            End If

            Dim tongTien As Decimal = giaVe * numSoLuongVe.Value
            lblTongTienValue.Text = String.Format("{0:N0} VNĐ", tongTien)
            lblTongTienValue.ForeColor = Color.FromArgb(244, 67, 54) ' Màu đỏ cho tổng tiền
        Catch ex As Exception
            lblTongTienValue.Text = "0 VNĐ"
        End Try
    End Sub

    Private Sub InsertVe(idNguoiDung As Integer, idXeKhach As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Using cmd As New SqlCommand("INSERT INTO VE (id_NguoiDung, id_XeKhach, trang_Thai) VALUES (@nd, @xk, N'Đã đặt')", conn)
                cmd.Parameters.AddWithValue("@nd", idNguoiDung)
                cmd.Parameters.AddWithValue("@xk", idXeKhach)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ShowUserTickets()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("
            SELECT 
                VE.id_Ve AS [Mã vé], 
                XEKHACH.ten_XeKhach AS [Tên xe khách], 
                XEKHACH.bien_So AS [Biển số], 
                VE.ngay_Dat AS [Thời gian đặt], 
                VE.trang_Thai AS [Trạng thái],
                TD.diem_di AS [Điểm đi],
                TD.diem_den AS [Điểm đến],
                TD.khoang_Cach_Km AS [Khoảng cách (km)],
                XEKHACH.gio_Di AS [Giờ đi],
                XEKHACH.gio_Den AS [Giờ đến]
            FROM VE
            INNER JOIN XEKHACH ON VE.id_XeKhach = XEKHACH.id_XeKhach
            INNER JOIN TUYENDUONG TD ON XEKHACH.id_TuyenDuong = TD.id_TuyenDuong
            WHERE VE.id_NguoiDung = @id", conn)
            cmd.Parameters.AddWithValue("@id", currentNguoiDungId)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            DataGridView1.DataSource = dt
        End Using
        isViewingTrips = False
        lblTongTienValue.Text = "0 VNĐ"
        ' Nếu muốn hiển thị số điện thoại:
        ' lblSoDienThoai.Text = currentSoDienThoai
    End Sub



    Private Sub btnTImKiem_Click(sender As Object, e As EventArgs) Handles btnTImKiem.Click
        Dim diemDi As String = txtDiemDi.Text.Trim()
        Dim diemDen As String = txtDiemDen.Text.Trim()

        If String.IsNullOrEmpty(diemDi) AndAlso String.IsNullOrEmpty(diemDen) Then
            MessageBox.Show("Vui lòng nhập ít nhất một điểm đi hoặc điểm đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ShowAllTrips(diemDi, diemDen)
    End Sub
    Private Sub AllVe_Click(sender As Object, e As EventArgs) Handles AllVe.Click
        ShowAllTrips("", "")
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim frmLichSu As New LichSu
        frmLichSu.currentNguoiDungIdLS = currentNguoiDungId ' Truyền ID người dùng
        frmLichSu.Show()
    End Sub

    Private Sub btnDatVe_Click(sender As Object, e As EventArgs) Handles btnDatVe.Click
        If Not isViewingTrips Then
            MessageBox.Show("Vui lòng chọn chuyến xe để đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn một chuyến xe để đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row = DataGridView1.SelectedRows(0)
        Dim idXeKhach = Convert.ToInt32(row.Cells("Mã Xe").Value)
        Dim tenXe = row.Cells("Tên Xe Khách").Value.ToString()
        Dim gioDi = row.Cells("Giờ Khởi Hành").Value.ToString()

        If MessageBox.Show($"Xác nhận đặt vé xe {tenXe}{vbCrLf}Khởi hành: {gioDi}{vbCrLf}Số lượng: {numSoLuongVe.Value}",
                          "Xác nhận đặt vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try
                For i = 1 To numSoLuongVe.Value
                    InsertVe(currentNguoiDungId, idXeKhach)
                Next

                MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ShowAllTrips() ' Refresh lại danh sách
            Catch ex As Exception
                MessageBox.Show("Có lỗi xảy ra khi đặt vé: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
