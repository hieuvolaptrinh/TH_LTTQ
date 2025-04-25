Public Class DieuKhien
    ' Dữ liệu ảo: Dictionary(Tỉnh -> Dictionary(Huyện -> Danh sách người))
    Private demoData As New Dictionary(Of String, Dictionary(Of String, List(Of String)))

    Private Sub DieuKhien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo dữ liệu ảo
        demoData = New Dictionary(Of String, Dictionary(Of String, List(Of String))) From {
            {"Hà Nội", New Dictionary(Of String, List(Of String)) From {
                {"Ba Đình", New List(Of String) From {"Nguyễn Văn A", "Trần Thị B"}},
                {"Cầu Giấy", New List(Of String) From {"Lê Văn C", "Phạm Thị D"}}
            }},
            {"Hồ Chí Minh", New Dictionary(Of String, List(Of String)) From {
                {"Quận 1", New List(Of String) From {"Ngô Văn E", "Hoàng Thị F"}},
                {"Thủ Đức", New List(Of String) From {"Đặng Văn G", "Nguyễn Thị H"}}
            }},
            {"Đà Nẵng", New Dictionary(Of String, List(Of String)) From {
                {"Hải Châu", New List(Of String) From {"Võ Văn I", "Lý Thị K"}},
                {"Thanh Khê", New List(Of String) From {"Trịnh Văn M", "Bùi Thị N"}}
            }}
        }

        ' Load vào TreeView
        For Each tinh As String In demoData.Keys
            Dim tinhNode As TreeNode = TreeView1.Nodes.Add(tinh)
            For Each huyen As String In demoData(tinh).Keys
                tinhNode.Nodes.Add(huyen)
            Next
        Next

        ' Cấu hình ListView hiển thị dạng danh sách
        ListView1.View = View.List
    End Sub

    ' Xử lý khi click vào node huyện
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        ListView1.Items.Clear()

        Dim selectedNode As TreeNode = e.Node
        If selectedNode.Parent IsNot Nothing Then ' Nếu là node cấp 2 (huyện)
            Dim tinh As String = selectedNode.Parent.Text
            Dim huyen As String = selectedNode.Text

            If demoData.ContainsKey(tinh) AndAlso demoData(tinh).ContainsKey(huyen) Then
                Dim danhSachNguoi As List(Of String) = demoData(tinh)(huyen)
                For Each tenNguoi In danhSachNguoi
                    ListView1.Items.Add(tenNguoi)
                Next
            End If
        End If
    End Sub





    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        QuanLy.Show()
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

        Me.Close()
        HoSoLienQuan.Show()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

        Me.Close()
        TichHopGiayTo.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click

        Me.Close()
        ThongKe.Show()
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class