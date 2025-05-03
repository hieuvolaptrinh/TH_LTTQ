Imports System.Data.SqlClient

Public Class ThemTuyenDuongDAO
    ' Chỉnh lại connection string để dùng user=sa
    Private connectionString As String =
        "Data Source=DESKTOP-QI5KS6I\NGYENNUKHANHNGOC;Initial Catalog=QuanLyVeKhach;User ID=sa;Password=123456"

    Public Function ThemTuyenDuong(khoangCach As Decimal, diemDi As String, diemDen As String) As Boolean
        Dim query As String =
            "INSERT INTO TUYENDUONG (khoang_Cach_Km, diem_di, diem_den) " &
            "VALUES (@khoangCach, @diemDi, @diemDen)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@khoangCach", khoangCach)
                cmd.Parameters.AddWithValue("@diemDi", diemDi)
                cmd.Parameters.AddWithValue("@diemDen", diemDen)

                Try
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                Catch ex As Exception
                    MessageBox.Show("Lỗi SQL: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function
End Class
