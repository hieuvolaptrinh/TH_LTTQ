﻿Imports System.Data.SqlClient

Public Class LichSu
    Public currentNguoiDungIdLS As Integer = -1
    Private conn As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"

    ' Hàm trả về SqlConnection
    Public Function ConnectDatabase() As SqlConnection
        Return New SqlConnection(conn)
    End Function

    Private Sub LichSu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If currentNguoiDungIdLS <= 0 Then
            MessageBox.Show("Vui lòng đăng nhập để xem lịch sử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If
        SetupDataGridView()

        ' Thiết lập các giá trị cho ComboBox trạng thái
        cboTrangThai.Items.Clear()
        cboTrangThai.Items.Add("Tất cả")
        cboTrangThai.Items.Add("Đã đặt")
        cboTrangThai.Items.Add("Đã hủy")
        cboTrangThai.SelectedItem = "Tất cả"

        LoadTicketHistory()
        UpdateStatistics()
    End Sub

    Private Sub SetupDataGridView()
        ' Thiết lập style cho DataGridView
        dgvTickets.EnableHeadersVisualStyles = False
        dgvTickets.BackgroundColor = Color.White

        ' Style cho header
        dgvTickets.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        dgvTickets.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243)
        dgvTickets.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvTickets.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTickets.ColumnHeadersHeight = 45
        dgvTickets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        ' Style cho các dòng
        dgvTickets.RowTemplate.Height = 40
        dgvTickets.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgvTickets.DefaultCellStyle.ForeColor = Color.Black
        dgvTickets.DefaultCellStyle.BackColor = Color.White
        dgvTickets.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243)
        dgvTickets.DefaultCellStyle.SelectionForeColor = Color.White
        dgvTickets.DefaultCellStyle.Padding = New Padding(5)

        ' Style cho dòng xen kẽ
        dgvTickets.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 247)
        dgvTickets.AlternatingRowsDefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgvTickets.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

        ' Các thuộc tính khác
        dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTickets.MultiSelect = False
        dgvTickets.AllowUserToAddRows = False
        dgvTickets.AllowUserToDeleteRows = False
        dgvTickets.AllowUserToResizeRows = False
        dgvTickets.ReadOnly = True
        dgvTickets.RowHeadersVisible = False
        dgvTickets.BorderStyle = BorderStyle.None
        dgvTickets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTickets.GridColor = Color.FromArgb(187, 222, 251)
    End Sub

    Private Sub LoadTicketHistory()
        Using conn As SqlConnection = ConnectDatabase()
            conn.Open()
            Dim sql As String = "
                SELECT 
                    VE.id_Ve AS [ID_Ve],
                    FORMAT(VE.ngay_Dat, 'dd/MM/yyyy HH:mm') AS [Thời Gian Đặt],
                    VE.trang_Thai AS [Trạng Thái],
                    X.bien_So AS [Biển Số],
                    X.ten_XeKhach AS [Tên Xe Khách],
                    FORMAT(X.gio_Di, 'dd/MM/yyyy HH:mm') AS [Giờ Khởi Hành],
                    FORMAT(X.gio_Den, 'dd/MM/yyyy HH:mm') AS [Giờ Đến],
                    X.gia_Ve AS [Giá Vé],
                    T.diem_di AS [Điểm Đi],
                    T.diem_den AS [Điểm Đến]
                FROM VE
                INNER JOIN XEKHACH X ON VE.id_XeKhach = X.id_XeKhach
                INNER JOIN TUYENDUONG T ON X.id_TuyenDuong = T.id_TuyenDuong
                WHERE VE.id_NguoiDung = @userId
                AND (@trangThai = N'Tất cả' OR VE.trang_Thai = @trangThai)
                ORDER BY VE.ngay_Dat DESC
            "

            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", currentNguoiDungIdLS)
                cmd.Parameters.AddWithValue("@trangThai", cboTrangThai.Text)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                dgvTickets.DataSource = dt

                ' Căn giữa và định dạng các cột
                For Each col As DataGridViewColumn In dgvTickets.Columns
                    Select Case col.Name
                        Case "Biển Số", "Thời Gian Đặt", "Giờ Khởi Hành", "Giờ Đến", "Giá Vé", "Trạng Thái"
                            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End Select
                Next

                ' Style cho cột trạng thái
                For Each row As DataGridViewRow In dgvTickets.Rows
                    Dim trangThai = row.Cells("Trạng Thái").Value.ToString()
                    If trangThai = "Đã hủy" Then
                        row.Cells("Trạng Thái").Style.ForeColor = Color.Red
                    Else
                        row.Cells("Trạng Thái").Style.ForeColor = Color.Green
                    End If
                Next
            End Using
        End Using
    End Sub

    Private Sub UpdateStatistics()
        Using conn As SqlConnection = ConnectDatabase()
            conn.Open()
            ' Đếm tổng số vé
            Using cmdTotal As New SqlCommand("SELECT COUNT(*) FROM VE WHERE id_NguoiDung = @userId", conn)
                cmdTotal.Parameters.AddWithValue("@userId", currentNguoiDungIdLS)
                lblTongSoVe.Text = cmdTotal.ExecuteScalar().ToString()
            End Using

            ' Đếm số vé đã hủy
            Using cmdCancelled As New SqlCommand("SELECT COUNT(*) FROM VE WHERE id_NguoiDung = @userId AND trang_Thai = N'Đã hủy'", conn)
                cmdCancelled.Parameters.AddWithValue("@userId", currentNguoiDungIdLS)
                lblSoVeHuy.Text = cmdCancelled.ExecuteScalar().ToString()
            End Using
        End Using
    End Sub

    Private Sub btnHuyVe_Click(sender As Object, e As EventArgs) Handles btnHuyVe.Click
        If dgvTickets.SelectedRows.Count = 0 Then
            MessageBox.Show("Vui lòng chọn vé để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row = dgvTickets.SelectedRows(0)
        Dim trangThai = row.Cells("Trạng Thái").Value.ToString()
        Dim idVe As Integer = Convert.ToInt32(row.Cells("ID_Ve").Value)

        If trangThai = "Đã hủy" Then
            MessageBox.Show("Vé này đã được hủy trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Bạn có chắc chắn muốn hủy vé này không?", "Xác nhận hủy",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As SqlConnection = ConnectDatabase()
                conn.Open()
                Using cmd As New SqlCommand("UPDATE VE SET trang_Thai = N'Đã hủy' WHERE id_Ve = @idVe AND id_NguoiDung = @userId", conn)
                    cmd.Parameters.AddWithValue("@idVe", idVe)
                    cmd.Parameters.AddWithValue("@userId", currentNguoiDungIdLS)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Hủy vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadTicketHistory()
                        UpdateStatistics()
                    Else
                        MessageBox.Show("Không thể hủy vé! Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub cboTrangThai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrangThai.SelectedIndexChanged
        LoadTicketHistory()
    End Sub

    Private Sub btnInVe_Click(sender As Object, e As EventArgs) Handles btnInVe.Click
        If dgvTickets.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Tạo DataTable với tên cột không dấu (tuân thủ CLS)
        Dim dt As New DataTable()
        dt.Columns.Add("ThoiGianDat")
        dt.Columns.Add("TrangThai")
        dt.Columns.Add("BienSo")
        dt.Columns.Add("TenXeKhach")
        dt.Columns.Add("GioKhoiHanh")
        dt.Columns.Add("GioDen")
        dt.Columns.Add("GiaVe")
        dt.Columns.Add("DiemDi")
        dt.Columns.Add("DiemDen")

        ' Copy dữ liệu từ DataGridView vào DataTable
        For Each row As DataGridViewRow In dgvTickets.Rows
            If Not row.IsNewRow AndAlso row.Cells("Trạng Thái").Value?.ToString() = "Đã đặt" Then
                Dim newRow As DataRow = dt.NewRow()
                newRow("ThoiGianDat") = row.Cells("Thời Gian Đặt").Value?.ToString()
                newRow("TrangThai") = row.Cells("Trạng Thái").Value?.ToString()
                newRow("BienSo") = row.Cells("Biển Số").Value?.ToString()
                newRow("TenXeKhach") = row.Cells("Tên Xe Khách").Value?.ToString()
                newRow("GioKhoiHanh") = row.Cells("Giờ Khởi Hành").Value?.ToString()
                newRow("GioDen") = row.Cells("Giờ Đến").Value?.ToString()
                newRow("GiaVe") = row.Cells("Giá Vé").Value?.ToString()
                newRow("DiemDi") = row.Cells("Điểm Đi").Value?.ToString()
                newRow("DiemDen") = row.Cells("Điểm Đến").Value?.ToString()
                dt.Rows.Add(newRow)
            End If
        Next

        ' Mở form ReportInVe và truyền dữ liệu vào
        Dim frmReport As New ReportInVe()
        frmReport.SetReportData(dt)
        frmReport.Show()
    End Sub
End Class