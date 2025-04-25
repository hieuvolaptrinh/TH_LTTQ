Public Class BT3
    'Private Sub BT3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Guna2GroupBox1.Visible = False
    '    cmbHangThuongBinh.SelectedIndex = 0
    'End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    '    Guna2GroupBox1.Visible = CheckBox1.Checked
    'End Sub


    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    '    Try
    '        ' Lấy dữ liệu từ form
    '        Dim maCCCD As String = txtMaCCCD.Text
    '        Dim hoVaTen As String = txtHoVaTen.Text
    '        Dim ngaySinh As Date = dtpNgaySinh.Value
    '        Dim diaChi As String = txtDiaChi.Text
    '        Dim soDienThoai As String = txtSoDienThoai.Text
    '        Dim email As String = txtEmail.Text
    '        Dim gioTinh As Boolean = rbNam.Checked ' Nam = True, Nữ = False
    '        Dim isThuongBinh As Boolean = CheckBox1.Checked

    '        Dim hoTen As String = txtHoVaTen.Text


    '        ' Tính trợ cấp
    '        Dim ketQua As String
    '        If isThuongBinh Then
    '            ' Lấy thông tin thương binh
    '            Dim mucThuongTat As Integer = Integer.Parse(txtMucDoThuongTat.Text)
    '            Dim hangThuongBinh As String = cmbHangThuongBinh.SelectedItem.ToString()
    '            Dim namPhucVu As Integer = Integer.Parse(txtSoNamCongHien.Text)


    '            Dim thuongBinh As New ThuongBinh(maCCCD, hoTen, ngaySinh, diaChi, soDienThoai, email, gioTinh, mucThuongTat, hangThuongBinh, namPhucVu)
    '            ketQua = thuongBinh.TinhTroCapXaHoi()
    '        Else
    '            Dim congDan As New CongDan(maCCCD, hoTen, ngaySinh, diaChi, soDienThoai, email, gioTinh)
    '            ketQua = congDan.TinhTroCapXaHoi()
    '        End If

    '        lblKetQua.Text = ketQua
    '    Catch ex As Exception
    '        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        lblKetQua.Text = "Lỗi khi tính trợ cấp."
    '    End Try
    'End Sub
End Class