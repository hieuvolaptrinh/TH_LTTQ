Imports Microsoft.Data.SqlClient
Public Class FrmTrangChu
    Inherits Form
    Private baseForm As New BaseForm()
    Dim connectionString As String = "Server=LAPTOP-SGLHG0M9\MVY_350;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"
    Dim connection As New SqlConnection(connectionString)

    Private Sub FrmTrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Gán sự kiện cho nút Tìm chuyến
        AddHandler btnTimChuyen.Click, AddressOf btnTimChuyen_Click

        ' Tô sáng menu đang chọn
        AddHandler MenuStrip1.ItemClicked, AddressOf MenuStrip_ItemClicked
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        ' Đổi màu nền cho item đang được chọn
        For Each item As ToolStripMenuItem In MenuStrip1.Items
            item.BackColor = Color.Transparent
        Next
        e.ClickedItem.BackColor = Color.LightSkyBlue ' Màu cho item đang chọn
    End Sub
    Private Sub FadeTimer_Tick(sender As Object, e As EventArgs)
        baseForm.HandleFadeTick(sender, e)
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        Me.Controls.Clear()
        InitializeComponent()
        FrmTrangChu_Load(sender, e)
    End Sub

    Private Sub LịchTrìnhVàTuyếnĐườngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Click
        baseForm.LoadFormWithFade(New lichTrinh(), PanelContainer)
    End Sub

    Private Sub DanhSáchXeBuýtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchXeBuýtToolStripMenuItem.Click
        baseForm.LoadFormWithFade(New DanhSachXeBuyt(), PanelContainer)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start(New ProcessStartInfo("https://youtu.be/8HrhegYauZ4?si=5T8yomugB0nIHbSC") With {
             .UseShellExecute = True
         })
        Catch ex As Exception
            MessageBox.Show("Không thể mở liên kết. Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTimChuyen_Click(sender As Object, e As EventArgs) Handles btnTimChuyen.Click
        Dim diemDi As String = textDiemDi.Text.Trim()
        Dim diemDen As String = textDiemDen.Text.Trim()
        Dim hasNgayDi As Boolean = dtpNgayDi.Checked
        Dim hasNgayVe As Boolean = dtpNgayVe.Checked

        Dim queryParts As New List(Of String)
        Dim parameters As New List(Of SqlParameter)

        ' Phần truy vấn lượt đi
        If diemDi <> "" OrElse diemDen <> "" OrElse hasNgayDi Then
            Dim q1 As String = "
        SELECT x.id_XeKhach, td.diem_di, td.diem_den, x.gio_Di AS ngayDi, x.gio_Den, x.ten_XeKhach, x.bien_So
        FROM XEKHACH x
        JOIN TUYENDUONG td ON x.id_TuyenDuong = td.id_TuyenDuong
        WHERE 1=1"

            If diemDi <> "" Then
                q1 &= " AND td.diem_di = @diemDi"
                parameters.Add(New SqlParameter("@diemDi", diemDi))
            End If

            If diemDen <> "" Then
                q1 &= " AND td.diem_den = @diemDen"
                parameters.Add(New SqlParameter("@diemDen", diemDen))
            End If

            If hasNgayDi Then
                q1 &= " AND CAST(x.gio_Di AS DATE) = @ngayDi"
                parameters.Add(New SqlParameter("@ngayDi", dtpNgayDi.Value.Date))
            End If

            queryParts.Add(q1)
        End If

        ' Phần truy vấn lượt về (chuyển điểm đi và đến)
        If hasNgayVe AndAlso diemDi <> "" AndAlso diemDen <> "" Then
            Dim q2 As String = "
        SELECT x.id_XeKhach, td.diem_di, td.diem_den, x.gio_Di AS ngayDi, x.gio_Den, x.ten_XeKhach, x.bien_So
        FROM XEKHACH x
        JOIN TUYENDUONG td ON x.id_TuyenDuong = td.id_TuyenDuong
        WHERE td.diem_di = @diemDen2 AND td.diem_den = @diemDi2 AND CAST(x.gio_Di AS DATE) = @ngayVe"

            parameters.Add(New SqlParameter("@diemDen2", diemDen))
            parameters.Add(New SqlParameter("@diemDi2", diemDi))
            parameters.Add(New SqlParameter("@ngayVe", dtpNgayVe.Value.Date))

            queryParts.Add(q2)
        End If

        ' Nếu không có điều kiện nào thì thoát
        If queryParts.Count = 0 Then
            MessageBox.Show("Vui lòng nhập ít nhất một điều kiện để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Ghép truy vấn
        Dim fullQuery As String = String.Join(" UNION ", queryParts)

        ' Thực thi truy vấn
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(fullQuery, conn)
                cmd.Parameters.AddRange(parameters.ToArray())
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        ' Hiển thị kết quả
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As New kqTimKiem()
            frm.dgvKetQua.DataSource = dt
            frm.ShowDialog()
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
        baseForm.LoadFormWithFade(New lichTrinh(), PanelContainer)
    End Sub
End Class
