' ===== Bảng NGUOIDUNG =====
Public Class NguoiDung
    Public Property Id_NguoiDung As Integer
    Public Property Ten_TaiKhoan As String
    Public Property Ho_Ten As String
    Public Property Email As String
    Public Property So_Dien_Thoai As String
    Public Property Mat_Khau As String
End Class

' ===== Bảng TUYENDUONG =====
Public Class TuyenDuong
    Public Property Id_TuyenDuong As Integer
    Public Property Khoang_Cach_Km As Decimal
    Public Property Diem_Di As String
    Public Property Diem_Den As String
End Class

' ===== Bảng XEKHACH =====
Public Class XeKhach
    Public Property Id_XeKhach As Integer
    Public Property Bien_So As String
    Public Property Ten_XeKhach As String
    Public Property Gio_Di As DateTime
    Public Property Gio_Den As DateTime
    Public Property Id_TuyenDuong As Integer
End Class

' ===== Bảng VE =====
Public Class Ve
    Public Property Id_Ve As Integer
    Public Property Id_NguoiDung As Integer
    Public Property Id_XeKhach As Integer
    Public Property Ngay_Dat As DateTime
    Public Property Trang_Thai As String
End Class

' ===== ViewModel dùng cho hiển thị trên DataGridView =====
Public Class TuyenDuongViewModel
    Public Property TuyenXe As String
    Public Property QuangDuong As String
    Public Property ThoiGian As String

    ' Store the ID for referencing in database queries
    Public Property Id_TuyenDuong As Integer

    ' Store the departure and arrival times
    Public Property GioDi As DateTime
    Public Property GioDen As DateTime
End Class