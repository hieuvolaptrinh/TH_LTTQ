Imports Microsoft.Data.SqlClient

Public Class UserTrangChu
    Inherits Form

    ' Thêm thuộc tính để nhận id người dùng từ form đăng nhập
    Public currentNguoiDungId As Integer = -1

    Private baseForm As New BaseForm()
    Private trangChuDAO As New TrangChuDAO() ' Instance of TrangChuDAO

    Private Sub FrmTrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MenuStrip1.ItemClicked, AddressOf MenuStrip_ItemClicked
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        For Each item As ToolStripMenuItem In MenuStrip1.Items
            item.BackColor = Color.Transparent
        Next
        e.ClickedItem.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        Try
            Me.Controls.Clear()
            InitializeComponent()
            FrmTrangChu_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi tải lại form Trang Chủ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTimChuyen_Click(sender As Object, e As EventArgs) Handles btnTimChuyen.Click
        Dim diemDi As String = textDiemDi.Text.Trim()
        Dim diemDen As String = textDiemDen.Text.Trim()
        Dim ngayDi As Date? = If(dtpNgayDi.Checked, dtpNgayDi.Value.Date, Nothing)
        Dim ngayVe As Date? = If(dtpNgayVe.Checked, dtpNgayVe.Value.Date, Nothing)
        Dim isKhuHoi As Boolean = chkKhuHoi.Checked

        Dim dt As DataTable = trangChuDAO.TimChuyen(diemDi, diemDen, ngayDi, ngayVe, isKhuHoi)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim message As New System.Text.StringBuilder()
            message.AppendLine("Kết quả tìm kiếm:")
            message.AppendLine(New String("-"c, 50))

            For Each row As DataRow In dt.Rows
                message.AppendLine($"- Xe: {row("ten_XeKhach")} ({row("bien_So")})")
                message.AppendLine($"  Điểm đi: {row("diem_di")}")
                message.AppendLine($"  Điểm đến: {row("diem_den")}")
                message.AppendLine($"  Giờ đi: {CDate(row("ngayDi")).ToString("HH:mm dd/MM/yyyy")}")
                message.AppendLine($"  Giờ đến: {CDate(row("gio_Den")).ToString("HH:mm dd/MM/yyyy")}")
                message.AppendLine(New String("-"c, 50))
            Next

            MessageBox.Show(message.ToString(), "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dtpNgayDi_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayDi.ValueChanged
        dtpNgayDi.CustomFormat = "dd/MM/yyyy"
        dtpNgayDi.Checked = True
    End Sub

    Private Sub dtpNgayVe_ValueChanged(sender As Object, e As EventArgs) Handles dtpNgayVe.ValueChanged
        dtpNgayVe.CustomFormat = "dd/MM/yyyy"
        dtpNgayVe.Checked = True
    End Sub

    Private Sub chkKhuHoi_CheckedChanged(sender As Object, e As EventArgs) Handles chkKhuHoi.CheckedChanged
        dtpNgayVe.Enabled = chkKhuHoi.Checked
    End Sub

    Private Sub btnDatVe_Click(sender As Object, e As EventArgs) Handles btnDatVe.Click
        Try
            ' Tạo form đặt vé và truyền id người dùng
            Dim datVeForm As New DatVeNe()
            datVeForm.currentNguoiDungId = Me.currentNguoiDungId
            baseForm.LoadFormWithFade(datVeForm, PanelContainer)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi chuyển sang form Lịch Trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            baseForm.LoadFormWithFade(New home2(), PanelContainer)
        Catch ex As Exception
            MessageBox.Show($"Đã xảy ra lỗi khi chuyển sang form Lịch Trình: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Hide()
        Dim frmLogin As New DangNhap()
        frmLogin.Show()
    End Sub
End Class
