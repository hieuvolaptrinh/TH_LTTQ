Imports System.Data.SqlClient

Public Class themTuyenDuong

    Private ReadOnly connectionString As String =
        "Data Source=DESKTOP-QI5KS6I\NGYENNUKHANHNGOC;Initial Catalog=QuanLyVeKhach;User ID=sa;Password=123456"

    Private Sub themTuyenDuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Thêm tuyến đường"
    End Sub

    ' DropDown của tên bến xe đi
    Private Sub cmbTenBenXeDi_DropDown(sender As Object, e As EventArgs) Handles cmbTenBenXeDi.DropDown
        cmbTenBenXeDi.Items.Clear()
        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "SELECT DISTINCT diem_di FROM TUYENDUONG"
            Using cmd As New SqlCommand(sql, conn)
                Try
                    conn.Open()
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        While rdr.Read()
                            cmbTenBenXeDi.Items.Add(rdr("diem_di").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi nạp danh sách bến đi: " & ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' DropDown của tên bến xe đến
    Private Sub cmbTenBenXeDen_DropDown(sender As Object, e As EventArgs) Handles cmbTenBenXeDen.DropDown
        cmbTenBenXeDen.Items.Clear()
        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "SELECT DISTINCT diem_den FROM TUYENDUONG"
            Using cmd As New SqlCommand(sql, conn)
                Try
                    conn.Open()
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        While rdr.Read()
                            cmbTenBenXeDen.Items.Add(rdr("diem_den").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi nạp danh sách bến đến: " & ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Nút Thêm chuyến xe
    Private Sub btnThuyenChuyenXe_Click(sender As Object, e As EventArgs) Handles btnThuyenChuyenXe.Click
        ' Kiểm tra nhập liệu
        If cmbTenBenXeDi.Text = "" OrElse cmbTenBenXeDen.Text = "" OrElse
           IsNothing(cmbTenBenXeDi.SelectedItem) OrElse IsNothing(cmbTenBenXeDen.SelectedItem) Then

            MessageBox.Show("Vui lòng chọn cả tên bến đi và tên bến đến.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtQuangDuong.Text) OrElse Not Double.TryParse(txtQuangDuong.Text, New Double) Then
            MessageBox.Show("Vui lòng nhập quãng đường hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Thêm vào CSDL
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim sql As String =
                    "INSERT INTO TUYENDUONG (diem_di, diem_den, khoang_Cach_Km) " &
                    "VALUES (@diemDi, @diemDen, @kc)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@diemDi", cmbTenBenXeDi.SelectedItem)
                    cmd.Parameters.AddWithValue("@diemDen", cmbTenBenXeDen.SelectedItem)
                    cmd.Parameters.AddWithValue("@kc", Double.Parse(txtQuangDuong.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Thêm tuyến đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset toàn bộ dữ liệu
            cmbTenBenXeDi.SelectedIndex = -1
            cmbTenBenXeDen.SelectedIndex = -1
            cmbTenBenXeDi.Text = ""
            cmbTenBenXeDen.Text = ""
            txtMaTuyenXe.Clear()
            txtTenTuyen.Clear()
            txtSoChuyen.Clear()
            txtSoNgay.Clear()
            txtGiaHienHanh.Clear()
            txtQuangDuong.Clear()
            txtThoiGian.Clear()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Không dùng
    End Sub

End Class
