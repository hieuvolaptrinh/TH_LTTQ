Public Class Home




    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click, Guna2GradientButton6.Click
        Me.Close()
        HoSoLienQuan.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Close()
        ThongKe.Show()
    End Sub



    Private Sub Guna2GradientButton3_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Me.Close()
        TichHopGiayTo.Show()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Me.Close()
        DieuKhien.Show()

    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class