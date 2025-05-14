Imports Microsoft.Data.SqlClient

Public Class DatVeNe
    Dim connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"
    Dim currentNguoiDungId As Integer = -1
    Private Const GIA_VE_MAC_DINH As Decimal = 100000D ' 100,000 VNĐ/vé

    Private Sub DatVeNe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTuyenDuong()
    End Sub

    Private Sub LoadTuyenDuong()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT id_TuyenDuong, diem_di + N' - ' + diem_den AS Tuyen FROM TUYENDUONG", conn)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            cboTuyenDuong.DataSource = dt
            cboTuyenDuong.DisplayMember = "Tuyen"
            cboTuyenDuong.ValueMember = "id_TuyenDuong"
        End Using
    End Sub

    Private Sub cboTuyenDuong_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboTuyenDuong.SelectedValue Is Nothing OrElse TypeOf cboTuyenDuong.SelectedValue Is DataRowView Then
            cboXeKhach.DataSource = Nothing
            Return
        End If
        LoadXeKhach(cboTuyenDuong.SelectedValue)
    End Sub

    Private Sub LoadXeKhach(idTuyenDuong As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT id_XeKhach, ten_XeKhach FROM XEKHACH WHERE id_TuyenDuong = @id", conn)
            cmd.Parameters.AddWithValue("@id", idTuyenDuong)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            cboXeKhach.DataSource = dt
            cboXeKhach.DisplayMember = "ten_XeKhach"
            cboXeKhach.ValueMember = "id_XeKhach"
        End Using
        TinhTongTien()
    End Sub

    Private Sub cboXeKhach_SelectedIndexChanged(sender As Object, e As EventArgs)
        TinhTongTien()
    End Sub

    Private Sub numSoLuongVe_ValueChanged(sender As Object, e As EventArgs)
        TinhTongTien()
    End Sub

    Private Sub TinhTongTien()
        If cboXeKhach.SelectedValue Is Nothing OrElse TypeOf cboXeKhach.SelectedValue Is DataRowView Then
            lblTongTienValue.Text = "0 VNĐ"
            Return
        End If
        Dim tongTien As Decimal = GIA_VE_MAC_DINH * numSoLuongVe.Value
        lblTongTienValue.Text = tongTien.ToString("N0") & " VNĐ"
    End Sub

    Private Sub btnDatVe_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtSoDienThoai.Text) OrElse cboXeKhach.SelectedValue Is Nothing Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
            Return
        End If

        currentNguoiDungId = GetOrCreateNguoiDung(txtSoDienThoai.Text)
        For i = 1 To numSoLuongVe.Value
            InsertVe(currentNguoiDungId, cboXeKhach.SelectedValue)
        Next
        MessageBox.Show("Đặt vé thành công!" & vbCrLf &
                        "Giá vé: " & GIA_VE_MAC_DINH.ToString("N0") & " VNĐ/vé" & vbCrLf &
                        "Tổng tiền: " & (GIA_VE_MAC_DINH * numSoLuongVe.Value).ToString("N0") & " VNĐ")
        LoadVeDaDat(currentNguoiDungId)
    End Sub

    Private Function GetOrCreateNguoiDung(soDienThoai As String) As Integer
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT id_NguoiDung FROM NGUOIDUNG WHERE so_Dien_Thoai = @sdt", conn)
            cmd.Parameters.AddWithValue("@sdt", soDienThoai)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return CInt(result)
            End If
            cmd = New SqlCommand("INSERT INTO NGUOIDUNG (ten_TaiKhoan, ho_Ten, so_Dien_Thoai, mat_Khau) VALUES (@tk, @ht, @sdt, @mk); SELECT SCOPE_IDENTITY();", conn)
            cmd.Parameters.AddWithValue("@tk", soDienThoai)
            cmd.Parameters.AddWithValue("@ht", "Khách lẻ")
            cmd.Parameters.AddWithValue("@mk", "123456")
            cmd.Parameters.AddWithValue("@sdt", soDienThoai)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub InsertVe(idNguoiDung As Integer, idXeKhach As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO VE (id_NguoiDung, id_XeKhach, trang_Thai) VALUES (@nd, @xk, N'Đã đặt')", conn)
            cmd.Parameters.AddWithValue("@nd", idNguoiDung)
            cmd.Parameters.AddWithValue("@xk", idXeKhach)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub LoadVeDaDat(idNguoiDung As Integer)
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
            cmd.Parameters.AddWithValue("@id", idNguoiDung)
            Dim dtOriginal As New DataTable()
            dtOriginal.Load(cmd.ExecuteReader())

            ' Clone schema and add "Giá vé", "Số lượng", "Thành tiền"
            Dim dt As DataTable = dtOriginal.Clone()
            dt.Columns.Add("Giá vé", GetType(Decimal))
            dt.Columns.Add("Số lượng", GetType(Integer))
            dt.Columns.Add("Thành tiền", GetType(Decimal))

            ' Import rows and set "Giá vé", "Số lượng", "Thành tiền"
            For Each row As DataRow In dtOriginal.Rows
                Dim newRow As DataRow = dt.NewRow()
                For i = 0 To dtOriginal.Columns.Count - 1
                    newRow(i) = row(i)
                Next
                newRow("Giá vé") = GIA_VE_MAC_DINH
                newRow("Số lượng") = 1
                newRow("Thành tiền") = GIA_VE_MAC_DINH
                dt.Rows.Add(newRow)
            Next

            DataGridView1.DataSource = dt

            ' Tính tổng tiền của tất cả vé đã đặt (chỉ tính vé "Đã đặt")
            Dim tongTien As Decimal = 0
            For Each row As DataRow In dt.Rows
                If row("Trạng thái").ToString() = "Đã đặt" AndAlso Not DBNull.Value.Equals(row("Thành tiền")) Then
                    tongTien += Convert.ToDecimal(row("Thành tiền"))
                End If
            Next
            lblTongTienValue.Text = tongTien.ToString("N0") & " VNĐ"
        End Using
        FormatDataGridView()
    End Sub

    Private Sub FormatDataGridView()
        If DataGridView1.DataSource Is Nothing Then Return
        If DataGridView1.Columns.Contains("Giá vé") Then
            DataGridView1.Columns("Giá vé").DefaultCellStyle.Format = "N0"
            DataGridView1.Columns("Giá vé").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If DataGridView1.Columns.Contains("Thành tiền") Then
            DataGridView1.Columns("Thành tiền").DefaultCellStyle.Format = "N0"
            DataGridView1.Columns("Thành tiền").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If DataGridView1.Columns.Contains("Thời gian đặt") Then
            DataGridView1.Columns("Thời gian đặt").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If
        If DataGridView1.Columns.Contains("Giờ đi") Then
            DataGridView1.Columns("Giờ đi").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If
        If DataGridView1.Columns.Contains("Giờ đến") Then
            DataGridView1.Columns("Giờ đến").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If
    End Sub

    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs)
        txtSoDienThoai.Text = ""
        numSoLuongVe.Value = 1
        lblTongTienValue.Text = "0 VNĐ"
        ' Do not clear DataGridView1, keep data for user
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs)
        If DataGridView1.SelectedRows.Count = 0 OrElse Not DataGridView1.Columns.Contains("Mã vé") Then
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
                If currentNguoiDungId > 0 Then LoadVeDaDat(currentNguoiDungId)
            End If
            Return
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
