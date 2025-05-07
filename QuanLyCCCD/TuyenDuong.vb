Imports System.Data.SqlClient

Public Class Form1
    Private db As New DatabaseHelper()  ' Use default constructor
    Private listTuyenDuong As New List(Of TuyenDuongViewModel)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDataGridView()
        LoadTuyenDuong()
    End Sub

    Private Sub InitDataGridView()
        dgvTuyenXe.AutoGenerateColumns = False
        dgvTuyenXe.Columns.Clear()

        dgvTuyenXe.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "TuyenXe",
            .HeaderText = "Tuyến xe",
            .DataPropertyName = "TuyenXe",
            .Width = 200
        })

        dgvTuyenXe.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "QuangDuong",
            .HeaderText = "Quãng đường",
            .DataPropertyName = "QuangDuong",
            .Width = 120
        })

        dgvTuyenXe.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "ThoiGian",
            .HeaderText = "Thời gian đi",
            .DataPropertyName = "ThoiGian",
            .Width = 120
        })

        ' Nút Chi tiết
        Dim btnChiTiet As New DataGridViewButtonColumn()
        btnChiTiet.Name = "btnChiTiet"
        btnChiTiet.HeaderText = "Giờ chạy"
        btnChiTiet.Text = "Chi tiết ❗"
        btnChiTiet.UseColumnTextForButtonValue = True
        btnChiTiet.Width = 100
        dgvTuyenXe.Columns.Add(btnChiTiet)

        ' Nút Đặt vé
        Dim btnDatVe As New DataGridViewButtonColumn()
        btnDatVe.Name = "btnDatVe"
        btnDatVe.HeaderText = "Đặt vé xe"
        btnDatVe.Text = "Đặt vé 🎫"
        btnDatVe.UseColumnTextForButtonValue = True
        btnDatVe.Width = 100
        dgvTuyenXe.Columns.Add(btnDatVe)
    End Sub

    Private Sub LoadTuyenDuong(Optional diemDi As String = "", Optional diemDen As String = "")
        ' Query tuyến đường and xe khách
        Dim query As String = "
            SELECT t.Id_TuyenDuong, t.diem_di, t.diem_den, 
                   t.khoang_Cach_Km, x.gio_Di, x.gio_Den,
                   x.id_XeKhach, x.bien_So, x.ten_XeKhach
            FROM TUYENDUONG t
            LEFT JOIN XEKHACH x ON t.Id_TuyenDuong = x.id_TuyenDuong
            WHERE 1=1"

        Dim parameters As New List(Of SqlParameter)

        If Not String.IsNullOrWhiteSpace(diemDi) Then
            query &= " AND t.diem_di LIKE @DiemDi"
            parameters.Add(New SqlParameter("@DiemDi", "%" & diemDi & "%"))
        End If
        If Not String.IsNullOrWhiteSpace(diemDen) Then
            query &= " AND t.diem_den LIKE @DiemDen"
            parameters.Add(New SqlParameter("@DiemDen", "%" & diemDen & "%"))
        End If

        Dim dt As DataTable = db.ExecuteDataTable(query, parameters.ToArray())
        listTuyenDuong.Clear()

        For Each row As DataRow In dt.Rows
            Dim gioDi As Date? = If(IsDBNull(row("gio_Di")), CType(Nothing, Date?), CType(row("gio_Di"), Date?))
            Dim gioDen As Date? = If(IsDBNull(row("gio_Den")), CType(Nothing, Date?), CType(row("gio_Den"), Date?))

            Dim thoiGian As String = ""
            If gioDi.HasValue AndAlso gioDen.HasValue Then
                Dim tg As TimeSpan = gioDen.Value - gioDi.Value
                thoiGian = $"{tg.Hours} giờ {tg.Minutes} phút"
            End If

            listTuyenDuong.Add(New TuyenDuongViewModel With {
                .Id_TuyenDuong = Convert.ToInt32(row("Id_TuyenDuong")),
                .TuyenXe = $"{row("diem_di")} - {row("diem_den")}",
                .QuangDuong = $"{row("khoang_Cach_Km")} Km",
                .ThoiGian = thoiGian,
                .GioDi = If(gioDi.HasValue, gioDi.Value, DateTime.MinValue),
                .GioDen = If(gioDen.HasValue, gioDen.Value, DateTime.MinValue)
            })
        Next

        dgvTuyenXe.DataSource = Nothing
        dgvTuyenXe.DataSource = listTuyenDuong
    End Sub

    Private Sub btnDiemDi_Click(sender As Object, e As EventArgs) Handles btnDiemDi.Click
        LoadTuyenDuong(diemDi:=txtDiemDi.Text.Trim())
    End Sub

    Private Sub btnDiemDen_Click(sender As Object, e As EventArgs) Handles btnDiemDen.Click
        LoadTuyenDuong(diemDen:=txtDiemDen.Text.Trim())
    End Sub

    Private Sub dgvTuyenXe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTuyenXe.CellContentClick
        If e.RowIndex >= 0 Then
            Dim tuyen = listTuyenDuong(e.RowIndex)

            If dgvTuyenXe.Columns(e.ColumnIndex).Name = "btnChiTiet" Then
                ' Get the departure times for this route
                Dim tuyenId = tuyen.Id_TuyenDuong
                ShowDepartureTimes(tuyenId, tuyen.TuyenXe)
            ElseIf dgvTuyenXe.Columns(e.ColumnIndex).Name = "btnDatVe" Then
                ' Add code to handle booking tickets
                MessageBox.Show($"Đặt vé cho tuyến: {tuyen.TuyenXe}", "Đặt vé")
                ' You could open a new form for booking here
                ' Dim frmDatVe As New FormDatVe(tuyen.Id_TuyenDuong, tuyen.TuyenXe)
                ' frmDatVe.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ShowDepartureTimes(tuyenId As Integer, tuyenName As String)
        ' Query to get all departure times for this route
        Dim query As String = "
            SELECT x.gio_Di, x.gio_Den, x.ten_XeKhach, x.bien_So, x.id_XeKhach
            FROM XEKHACH x
            WHERE x.id_TuyenDuong = @TuyenId
            ORDER BY x.gio_Di"

        Dim param As New SqlParameter("@TuyenId", tuyenId)
        Dim dt As DataTable = db.ExecuteDataTable(query, param)

        ' Build message with all departure times
        Dim message As New System.Text.StringBuilder()
        message.AppendLine($"Giờ chạy cho tuyến: {tuyenName}")
        message.AppendLine("-------------------------------------------")

        If dt.Rows.Count = 0 Then
            message.AppendLine("Không có chuyến nào cho tuyến này.")
        Else
            For Each row As DataRow In dt.Rows
                Dim gioDi As DateTime = CType(row("gio_Di"), DateTime)
                Dim gioDen As DateTime = CType(row("gio_Den"), DateTime)
                Dim tenXe As String = CType(row("ten_XeKhach"), String)
                Dim bienSo As String = CType(row("bien_So"), String)

                message.AppendLine($"- Giờ đi: {gioDi.ToString("HH:mm dd/MM/yyyy")}")
                message.AppendLine($"  Giờ đến: {gioDen.ToString("HH:mm dd/MM/yyyy")}")
                message.AppendLine($"  Xe: {tenXe} ({bienSo})")
                message.AppendLine("-------------------------------------------")
            Next
        End If

        MessageBox.Show(message.ToString(), "Thông tin giờ chạy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class