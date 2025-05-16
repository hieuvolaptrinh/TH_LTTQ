Public Class home2
    Private Sub home2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnBackToHome_Click(sender As Object, e As EventArgs) Handles btnBackToHome.Click
        ' Close all other forms except FrmTrangChu
        For Each openForm As Form In Application.OpenForms.Cast(Of Form).ToList()
            If Not TypeOf openForm Is UserTrangChu Then
                openForm.Close()
            End If
        Next

        ' Navigate back to the main form (FrmTrangChu)
        Dim homeForm As New UserTrangChu() ' Replace 'FrmTrangChu' with the actual name of your home form
        homeForm.Show() ' Show the main form
        Me.Close() ' Close the current form completely
    End Sub
End Class