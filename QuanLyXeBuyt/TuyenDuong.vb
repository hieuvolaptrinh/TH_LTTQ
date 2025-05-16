Imports System.Data.SqlClient

Public Class TuyenDuong

    Dim connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"

    Private Sub TuyenDuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtMaTuyen.Text = "Tự động sinh mã"
        txtMaTuyen.ReadOnly = True
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT * FROM TUYENDUONG"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)
            txtMaTuyen.Text = row.Cells("id_TuyenDuong").Value.ToString
            txtDiemDi.Text = row.Cells("diem_di").Value.ToString
            txtDiemDen.Text = row.Cells("diem_den").Value.ToString
            txtKhoangCach.Text = row.Cells("khoang_Cach_Km").Value.ToString
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs)
        If txtMaTuyen.Text = "" Or txtMaTuyen.Text = "Tự động sinh mã" Then
            MessageBox.Show("Vui lòng chọn tuyến cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Bạn có chắc chắn muốn xóa tuyến này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query = "DELETE FROM TUYENDUONG WHERE id_TuyenDuong = @id"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(txtMaTuyen.Text))
                    connection.Open()
                    Dim rowsAffected = command.ExecuteNonQuery
                    connection.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData()
                        txtMaTuyen.Text = "Tự động sinh mã"
                        txtDiemDi.Text = ""
                        txtDiemDen.Text = ""
                        txtKhoangCach.Text = ""
                    Else
                        MessageBox.Show("Không tìm thấy tuyến để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs)
        If txtMaTuyen.Text = "" Or txtMaTuyen.Text = "Tự động sinh mã" Or txtDiemDi.Text = "" Or txtDiemDen.Text = "" Or txtKhoangCach.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsNumeric(txtKhoangCach.Text) Then
            MessageBox.Show("Khoảng cách phải là một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query = "UPDATE TUYENDUONG SET diem_di = @diemDi, diem_den = @diemDen, khoang_Cach_Km = @khoangCach WHERE id_TuyenDuong = @id"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@diemDi", txtDiemDi.Text)
                command.Parameters.AddWithValue("@diemDen", txtDiemDen.Text)
                command.Parameters.AddWithValue("@khoangCach", Convert.ToDouble(txtKhoangCach.Text))
                command.Parameters.AddWithValue("@id", Convert.ToInt32(txtMaTuyen.Text))

                Try
                    connection.Open()
                    Dim rowsAffected = command.ExecuteNonQuery
                    connection.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData()
                    Else
                        MessageBox.Show("Không tìm thấy tuyến để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi cập nhật: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs)
        If txtDiemDi.Text = "" Or txtDiemDen.Text = "" Or txtKhoangCach.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsNumeric(txtKhoangCach.Text) Then
            MessageBox.Show("Khoảng cách phải là một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query = "INSERT INTO TUYENDUONG (diem_di, diem_den, khoang_Cach_Km) VALUES (@diemDi, @diemDen, @khoangCach)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@diemDi", txtDiemDi.Text)
                command.Parameters.AddWithValue("@diemDen", txtDiemDen.Text)
                command.Parameters.AddWithValue("@khoangCach", Convert.ToDouble(txtKhoangCach.Text))

                Try
                    connection.Open()
                    Dim rowsAffected = command.ExecuteNonQuery
                    connection.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Thêm tuyến đường thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData()
                        txtMaTuyen.Text = "Tự động sinh mã"
                        txtDiemDi.Clear()
                        txtDiemDen.Clear()
                        txtKhoangCach.Clear()
                    Else
                        MessageBox.Show("Thêm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs)
        txtMaTuyen.Text = "Tự động sinh mã"
        txtMaTuyen.ReadOnly = True
        txtDiemDi.Clear()
        txtDiemDen.Clear()
        txtKhoangCach.Clear()
        txtDiemDi.Focus()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click

    End Sub

    Private Sub btnSua_Click_1(sender As Object, e As EventArgs) Handles btnSua.Click

    End Sub
End Class
