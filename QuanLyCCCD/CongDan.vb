Imports System.Text.RegularExpressions

Public Structure TroCapKetQua
    Public TongTroCap As Double
    Public MoTa As String
End Structure

Public Class CongDan
    Private maCCCD As String
    Private hoTen As String
    Private ngaySinh As Date
    Private diaChi As String
    Private soDienThoai As String
    Private email As String
    Private gioTinh As Boolean 'nam = True, nữ = False
    Public Sub New()
        Me.maCCCD = ""
        Me.hoTen = ""
        Me.ngaySinh = Date.Now
        Me.diaChi = ""
        Me.soDienThoai = ""

    End Sub
    Public Sub New(maCCCD As String, hoTen As String,
                    ngaySinh As Date, diaChi As String,
                    soDienThoai As String,
                    email As String, gioTinh As Boolean)
        Me.maCCCD = maCCCD
        Me.hoTen = hoTen

        Me.ngaySinh = ngaySinh
        Me.diaChi = diaChi

        Me.soDienThoai = soDienThoai
        Me.email = email
        Me.gioTinh = gioTinh
    End Sub

    Protected Overridable Function TinhTroCapTheoTuoi(tuoi As Integer) As TroCapKetQua
        Dim ketQua As New TroCapKetQua
        If tuoi >= 60 Then
            ketQua.TongTroCap = 2000000
            ketQua.MoTa = "Trợ cấp người cao tuổi: 2,000,000 VND. "
        ElseIf tuoi >= 18 Then
            ketQua.TongTroCap = 1000000
            ketQua.MoTa = "Trợ cấp người trưởng thành: 1,000,000 VND. "
        Else
            ketQua.TongTroCap = 500000
            ketQua.MoTa = "Trợ cấp trẻ em: 500,000 VND. "
        End If
        Return ketQua
    End Function

    Protected Overridable Function TinhTroCapTheoGioiTinh(tuoi As Integer) As TroCapKetQua
        Dim ketQua As New TroCapKetQua
        If Not gioTinh AndAlso tuoi >= 60 Then
            ketQua.TongTroCap = 500000
            ketQua.MoTa = "Thưởng phụ nữ cao tuổi: 500,000 VND. "
        End If
        Return ketQua
    End Function
    Public Overridable Function TinhTroCapXaHoi() As String
        Dim troCap As Double = 0
        Dim moTa As String = $"Công dân {hoTen} (CCCD: {maCCCD}):{vbCrLf}"

        Dim tuoi As Integer = Date.Now.Year - ngaySinh.Year
        If ngaySinh.Date > Date.Now.AddYears(-tuoi) Then
            tuoi -= 1
        End If

        If tuoi >= 60 Then
            troCap += 2000000
            moTa &= $"Trợ cấp người cao tuổi: {2_000_000:N0} VND.{vbCrLf}"
        ElseIf tuoi >= 18 Then
            troCap += 1000000
            moTa &= $"Trợ cấp người trưởng thành: {1_000_000:N0} VND.{vbCrLf}"
        Else
            troCap += 500000
            moTa &= $"Trợ cấp trẻ em: {500_000:N0} VND.{vbCrLf}"
        End If
        If Not gioTinh Then
            If tuoi >= 60 Then
                troCap += 500000
                moTa &= $"Thưởng phụ nữ cao tuổi: {500_000:N0} VND.{vbCrLf}"
            End If
        End If

        moTa &= $"Tổng trợ cấp: {troCap:N0} VND/năm."
        Return moTa
    End Function

    Public Property S_maCCCD As String
            Get
                Return maCCCD
            End Get
            Set(value As String)
                If String.IsNullOrEmpty(value) OrElse Not Regex.IsMatch(value, "^\d{12}$") Then
                    Throw New ArgumentException("Mã CCCD phải là chuỗi 12 chữ số.")
                End If
                maCCCD = value
            End Set
        End Property


    Public Property S_hoTen As String
        Get
            Return hoTen
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentException("Tên không được rỗng.")
            End If
            hoTen = value
        End Set
    End Property

    Public Property S_ngaySinh As Date
            Get
                Return ngaySinh
            End Get
            Set(value As Date)
                If value > Date.Now Then
                    Throw New ArgumentException("Ngày sinh không được trong tương lai.")
                End If
                ngaySinh = value
            End Set
        End Property

        Public Property S_diaChi As String
            Get
                Return diaChi
            End Get
            Set(value As String)
                If String.IsNullOrEmpty(value) Then
                    Throw New ArgumentException("Địa chỉ không được rỗng.")
                End If
                diaChi = value
            End Set
        End Property


    Public Property S_soDienThoai As String
            Get
                Return soDienThoai
            End Get
            Set(value As String)
                If String.IsNullOrEmpty(value) OrElse Not Regex.IsMatch(value, "^0\d{9}$") Then
                MsgBox("Số điện thoại phải là chuỗi 10 chữ số, bắt đầu bằng 0.")
            End If
                soDienThoai = value
            End Set
        End Property

        Public Property S_email As String
            Get
                Return email
            End Get
            Set(value As String)
                If String.IsNullOrEmpty(value) OrElse Not Regex.IsMatch(value, "^\w+@\w+\.\w+$") Then
                    Throw New ArgumentException("Email không hợp lệ.")
                End If
                email = value
            End Set
        End Property

    Public Property S_gioTinh As Boolean
        Get
            Return gioTinh
        End Get
        Set(value As Boolean)
            gioTinh = value
        End Set
    End Property

    Public Overridable Function GetInfo() As String
        Dim gioiTinhStr As String = If(gioTinh, "Nam", "Nữ")

        Return $"CCCD: {maCCCD}, Họ tên: {hoTen}, Ngày sinh: {ngaySinh.ToShortDateString()}, " &
               $"Địa chỉ: {diaChi}, SĐT: {soDienThoai}, Email: {email}, Giới tính: {gioiTinhStr}"
    End Function
End Class
