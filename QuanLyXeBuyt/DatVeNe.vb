Imports Microsoft.Data.SqlClient

Public Class DatVeNe
    Dim connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"
    ' This should be set after user login
    Public currentNguoiDungId As Integer = -1
    Private Const GIA_VE_MAC_DINH As Decimal = 100000D
    Private isViewingTrips As Boolean = True

    Private Sub DatVeNe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If currentNguoiDungId <= 0 Then
            MessageBox.Show("Bạn cần đăng nhập trước khi đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If
        ShowAllTrips()
        AddHandler btnDiemDi.Click, AddressOf btnDiemDi_Click
        AddHandler btnDiemDen.Click, AddressOf btnDiemDen_Click
        AddHandler btnDatVe.Click, AddressOf btnDatVe_Click
        AddHandler btnNhapLai.Click, AddressOf btnNhapLai_Click
        AddHandler btnHuy.Click, AddressOf btnHuy_Click
        AddHandler numSoLuongVe.ValueChanged, AddressOf numSoLuongVe_ValueChanged
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
    End Sub

    Private Sub ShowAllTrips(Optional diemDi As String = "", Optional diemDen As String = "")
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim sql As String = "
                SELECT X.id_XeKhach, X.ten_XeKhach, X.bien_So, X.gio_Di, X.gio_Den, 
                       T.diem_di, T.diem_den, T.khoang_Cach_Km, @giaVe AS [Giá vé]
                FROM XEKHACH X
                INNER JOIN TUYENDUONG T ON X.id_TuyenDuong = T.id_TuyenDuong
                WHERE (T.diem_di LIKE @diemDi OR @diemDi = '')
                  AND (T.diem_den LIKE @diemDen OR @diemDen = '')
            "
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@giaVe", GIA_VE_MAC_DINH)
            cmd.Parameters.AddWithValue("@diemDi", "%" & diemDi & "%")
            cmd.Parameters.AddWithValue("@diemDen", "%" & diemDen & "%")
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            DataGridView1.DataSource = dt
        End Using
        isViewingTrips = True
        numSoLuongVe.Value = 1
        lblTongTienValue.Text = "0 VNĐ"
    End Sub

    Private Sub btnDiemDi_Click(sender As Object, e As EventArgs)
        ShowAllTrips(txtDiemDi.Text.Trim(), txtDiemDen.Text.Trim())
    End Sub

    Private Sub btnDiemDen_Click(sender As Object, e As EventArgs)
        ShowAllTrips(txtDiemDi.Text.Trim(), txtDiemDen.Text.Trim())
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
        If isViewingTrips AndAlso DataGridView1.SelectedRows.Count > 0 Then
            TinhTongTien()
        End If
    End Sub

    Private Sub numSoLuongVe_ValueChanged(sender As Object, e As EventArgs)
        If isViewingTrips AndAlso DataGridView1.SelectedRows.Count > 0 Then
            TinhTongTien()
        End If
    End Sub

    Private Sub TinhTongTien()
        If Not isViewingTrips OrElse DataGridView1.SelectedRows.Count = 0 Then
            lblTongTienValue.Text = "0 VNĐ"
            Return
        End If
        Dim giaVe As Decimal = GIA_VE_MAC_DINH
        If DataGridView1.SelectedRows(0).Cells("Giá vé") IsNot Nothing Then
            Decimal.TryParse(DataGridView1.SelectedRows(0).Cells("Giá vé").Value.ToString(), giaVe)
        End If
        Dim tongTien As Decimal = giaVe * numSoLuongVe.Value
        lblTongTienValue.Text = tongTien.ToString("N0") & " VNĐ"
    End Sub

    Private Sub InsertVe(idNguoiDung As Integer, idXeKhach As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO VE (id_NguoiDung, id_XeKhach, trang_Thai) VALUES (@nd, @xk, N'Đã đặt')", conn)
            cmd.Parameters.AddWithValue("@nd", idNguoiDung)
            cmd.Parameters.AddWithValue("@xk", idXeKhach)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub btnDatVe_Click(sender As Object, e As EventArgs)
        If Not isViewingTrips Then
            MessageBox.Show("Vui lòng chuyển về chế độ xem chuyến đi để đặt vé mới!")
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn chuyến đi để đặt vé!")
            Return
        End If
        If currentNguoiDungId <= 0 Then
            MessageBox.Show("Bạn cần đăng nhập trước khi đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If
        Dim idXeKhach As Integer = CInt(DataGridView1.SelectedRows(0).Cells("id_XeKhach").Value)
        For i = 1 To numSoLuongVe.Value
            InsertVe(currentNguoiDungId, idXeKhach)
        Next
        MessageBox.Show("Đặt vé thành công!")
        ShowUserTickets()
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

    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs)
        numSoLuongVe.Value = 1
        lblTongTienValue.Text = "0 VNĐ"
        txtDiemDi.Text = ""
        txtDiemDen.Text = ""
        ShowAllTrips()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs)
        If isViewingTrips OrElse DataGridView1.SelectedRows.Count = 0 OrElse Not DataGridView1.Columns.Contains("Mã vé") Then
            MessageBox.Show("Vui lòng chọn vé để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim row = DataGridView1.SelectedRows(0)
        Dim maVe = row.Cells("Mã vé").Value
        Dim trangThai = row.Cells("Trạng thái").Value.ToString
        If trangThai = "Đã hủy" Then
            MessageBox.Show("Vé này đã bị hủy rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If trangThai = "Đã đặt" Then
            Dim result = MessageBox.Show("Bạn có chắc chắn muốn hủy vé này?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                HuyVe(maVe)
                MessageBox.Show("Đã hủy vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If currentNguoiDungId > 0 Then ShowUserTickets()
            End If
        End If
    End Sub

    Private Sub HuyVe(maVe As Object)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE VE SET trang_Thai = N'Đã hủy' WHERE id_Ve = @id", conn)
            cmd.Parameters.AddWithValue("@id", maVe)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
