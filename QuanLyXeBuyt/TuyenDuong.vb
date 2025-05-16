Public Class TuyenDuong

    Dim connectionString As String = "Server=localhost;Database=QuanLyVeKhach;Trusted_Connection=True;TrustServerCertificate=True;"

    Private Sub TuyenDuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtMaTuyen.Text = "Tự động sinh mã"
        txtMaTuyen.ReadOnly = True
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT id_TuyenDuong as N'Mã Tuyến', diem_di as N'Điểm Đi', diem_den as N'Điểm Đến', khoang_Cach_Km as N'Khoảng Cách (Km)' FROM TUYENDUONG"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            ' Tùy chỉnh hiển thị của DataGridView
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)
            txtMaTuyen.Text = row.Cells("Mã Tuyến").Value.ToString()
            txtDiemDi.Text = row.Cells("Điểm Đi").Value.ToString()
            txtDiemDen.Text = row.Cells("Điểm Đến").Value.ToString()
            txtKhoangCach.Text = row.Cells("Khoảng Cách (Km)").Value.ToString()
        End If
    End Sub
    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaTuyen.Text = "" Or txtMaTuyen.Text = "Tự động sinh mã" Then
            MessageBox.Show("Vui lòng chọn tuyến cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kiểm tra xem có xe và vé liên quan không
        Dim hasRelatedData As Boolean = False
        Dim relatedBuses As Integer = 0
        Dim relatedTickets As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Đếm số xe buýt trên tuyến này
            Dim queryBuses = "SELECT COUNT(*) FROM XEKHACH WHERE id_TuyenDuong = @id"
            Using cmdBuses As New SqlCommand(queryBuses, connection)
                cmdBuses.Parameters.AddWithValue("@id", Convert.ToInt32(txtMaTuyen.Text))
                relatedBuses = Convert.ToInt32(cmdBuses.ExecuteScalar())
            End Using

            ' Đếm số vé đã bán cho các xe trên tuyến này
            Dim queryTickets = "SELECT COUNT(*) FROM VE v INNER JOIN XEKHACH x ON v.id_XeKhach = x.id_XeKhach WHERE x.id_TuyenDuong = @id"
            Using cmdTickets As New SqlCommand(queryTickets, connection)
                cmdTickets.Parameters.AddWithValue("@id", Convert.ToInt32(txtMaTuyen.Text))
                relatedTickets = Convert.ToInt32(cmdTickets.ExecuteScalar())
            End Using

            hasRelatedData = (relatedBuses > 0 Or relatedTickets > 0)
        End Using

        Dim warningMessage As String = "Bạn có chắc chắn muốn xóa tuyến này?"
        If hasRelatedData Then
            warningMessage = $"CẢNH BÁO: Xóa tuyến đường này sẽ ảnh hưởng đến:{vbCrLf}"
            If relatedBuses > 0 Then
                warningMessage &= $"- {relatedBuses} xe đang chạy trên tuyến này{vbCrLf}"
            End If
            If relatedTickets > 0 Then
                warningMessage &= $"- {relatedTickets} vé đã được bán{vbCrLf}"
            End If
            warningMessage &= vbCrLf & "Tất cả dữ liệu liên quan sẽ bị xóa. Bạn có chắc chắn muốn tiếp tục?"
        End If

        Dim result = MessageBox.Show(warningMessage, "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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


    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click
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

    Private Sub btnSua_Click_1(sender As Object, e As EventArgs) Handles btnSua.Click
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

End Class