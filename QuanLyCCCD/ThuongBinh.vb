Public Class ThuongBinh
    Inherits CongDan
    Private mucThuongTat As Integer ' (0-100%)
    Private hangThuongBinh As String '(Hạng 1, 2, 3)
    Private namPhucVu As Integer
    Public Sub New()
        MyBase.New()
        Me.mucThuongTat = 0
        Me.hangThuongBinh = ""
        Me.namPhucVu = 0
    End Sub
    ' Constructor đầy đủ
    Public Sub New(maCCCD As String, hoTen As String, ngaySinh As Date,
                   diaChi As String, soDienThoai As String,
                   email As String, gioTinh As Boolean, mucThuongTat As Integer,
                   hangThuongBinh As String, namPhucVu As Integer)
        MyBase.New(maCCCD, hoTen, ngaySinh, diaChi, soDienThoai, email, gioTinh)
        Me.S_mucThuongTat = mucThuongTat
        Me.S_hangThuongBinh = hangThuongBinh
        Me.S_namPhucVu = namPhucVu
    End Sub

    ' Getters và Setters
    Public Property S_mucThuongTat As Integer
        Get
            Return mucThuongTat
        End Get
        Set(value As Integer)
            If value < 0 OrElse value > 100 Then
                Throw New ArgumentException("Mức thương tật phải từ 0 đến 100%.")
            End If
            mucThuongTat = value
        End Set
    End Property

    Public Property S_hangThuongBinh As String
        Get
            Return hangThuongBinh
        End Get
        Set(value As String)
            If String.IsNullOrEmpty(value) OrElse Not {"Hạng 1", "Hạng 2", "Hạng 3"}.Contains(value) Then
                Throw New ArgumentException("Hạng thương binh phải là Hạng 1, Hạng 2 hoặc Hạng 3.")
            End If
            hangThuongBinh = value
        End Set
    End Property
    Public Property S_namPhucVu As Integer
        Get
            Return namPhucVu
        End Get
        Set(value As Integer)
            namPhucVu = value
        End Set
    End Property


    Public Overrides Function TinhTroCapXaHoi() As String
        Dim baseResult As String = MyBase.TinhTroCapXaHoi()
        Dim troCap As Double = 0
        Dim moTa As String = $"Thương binh {S_hoTen} (CCCD:"

        ' Trích xuất số tiền và mô tả từ kết quả cơ sở
        If baseResult.Contains("Tổng trợ cấp: ") Then
            Dim startIndex As Integer = baseResult.IndexOf("Tổng trợ cấp: ") + "Tổng trợ cấp: ".Length
            Dim endIndex As Integer = baseResult.IndexOf(" VND/năm")
            Dim troCapStr As String = baseResult.Substring(startIndex, endIndex - startIndex).Replace(",", "")
            Double.TryParse(troCapStr, troCap)

            Dim baseMoTa As String = baseResult.Substring(baseResult.IndexOf(": ") + 2, baseResult.IndexOf("Tổng trợ cấp: ") - baseResult.IndexOf(": ") - 2)
            moTa &= baseMoTa.TrimEnd(" ") & vbCrLf
        End If

        ' Thêm trợ cấp thương binh
        Dim thuongTatBonus As Double = S_mucThuongTat * 50000
        troCap += thuongTatBonus
        moTa &= $"Trợ cấp thương tật: {thuongTatBonus:N0} VND.{vbCrLf}"

        Dim hangBonus As Double
        Select Case S_hangThuongBinh.ToLower()
            Case "hạng 1"
                hangBonus = 3000000
            Case "hạng 2"
                hangBonus = 2000000
            Case "hạng 3"
                hangBonus = 1000000
            Case Else
                hangBonus = 0
        End Select
        troCap += hangBonus
        moTa &= $"Trợ cấp hạng thương binh: {hangBonus:N0} VND.{vbCrLf}"


        Dim serviceBonus As Double = S_namPhucVu * 100000
        troCap += serviceBonus
        moTa &= $"Thưởng thâm niên: {serviceBonus:N0} VND.{vbCrLf}"

        moTa &= $"Tổng trợ cấp: {troCap:N0} VND/năm."
        Return moTa
    End Function

    ' Ghi đè phương thức lấy thông tin
    Public Overrides Function GetInfo() As String
        Dim baseInfo As String = MyBase.GetInfo()
        Return $"{baseInfo}, Mức thương tật: {S_mucThuongTat}%, Hạng thương binh: {S_hangThuongBinh}, Năm phục vụ: {S_namPhucVu}"
    End Function
End Class