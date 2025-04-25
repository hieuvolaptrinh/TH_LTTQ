Imports System.Windows.Forms.DataVisualization.Charting

Public Class ThongKe

    Private Sub ThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        'TabControl1.ItemSize = New Size(100, 40)
        'TabControl1.SizeMode = TabSizeMode.Fixed

        Chart2.Series("GioiTinh").Points.Clear()
        ' Tạo dữ liệu tự động
        Dim dsGioiTinh As New Dictionary(Of String, Integer) From {
            {"Nam", 60},
            {"Nữ", 40}
        }
        For Each item In dsGioiTinh
            Chart2.Series("GioiTinh").Points.AddXY(item.Key, item.Value)
        Next
        Chart2.Series("GioiTinh").IsValueShownAsLabel = True
        Chart1.Series.Clear()
        Chart1.Titles.Clear()
        Chart1.Legends.Clear()

        If Chart1.Legends.Count = 0 Then
            Dim legend As New Legend("Legend1")
            legend.Title = "Dân số"
            Chart1.Legends.Add(legend)
        End If

        Dim series As New Series("Dân số")
        series.ChartType = SeriesChartType.Column
        series.BorderColor = Color.Yellow
        series.Color = Color.Black

        Dim dsDanSo As New Dictionary(Of String, Integer) From {
            {"24/03/2025", 100},
            {"25/03/2025", 30},
            {"26/03/2025", 30},
            {"27/03/2025", 10},
            {"28/03/2025", 90}
        }
        For Each item In dsDanSo
            series.Points.AddXY(item.Key, item.Value)
        Next

        Chart1.Series.Add(series)
        Dim title As New Title("Thống kê số lượng dân số theo thời gian", Docking.Top, New Font("Arial", 14, FontStyle.Bold), Color.Black)
        Chart1.Titles.Add(title)

        Chart1.ChartAreas(0).AxisX.Title = "Thời gian"
        Chart1.ChartAreas(0).AxisY.Title = "Số lượng"

        Chart1.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Days
        Chart1.ChartAreas(0).AxisX.Interval = 1
    End Sub
    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) 
        Dim g As Graphics = e.Graphics
        'Dim tabText As String = TabControl1.TabPages(e.Index).Text
        'Dim tabBounds As Rectangle = TabControl1.GetTabRect(e.Index)

        ' Màu nền cho tab
        Dim backBrush As Brush = If(e.State = DrawItemState.Selected, Brushes.DodgerBlue, Brushes.LightSteelBlue)

        ' Màu chữ
        Dim textBrush As Brush = Brushes.White

        ' Vẽ nền và chữ
        'g.FillRectangle(backBrush, tabBounds)
        'Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        'g.DrawString(tabText, New Font("Segoe UI", 12, FontStyle.Bold), textBrush, tabBounds, sf)
    End Sub



    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Close()
        DieuKhien.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Close()
        QuanLy.Show()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Close()
        HoSoLienQuan.Show()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.Close()
        TichHopGiayTo.Show()
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class