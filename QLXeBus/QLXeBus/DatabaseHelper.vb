Imports System.Data.SqlClient

Public Class DatabaseHelper
    ' Default connection string for SQL Server Authentication
    Private connectionString As String = "Server=POTATO\SQLEXPRESS;Database=QuanLyVeKhach;User Id=sa;Password=12345;"

    ' Constructor with optional parameter - keeping both options for flexibility
    Public Sub New(Optional connString As String = "")
        If Not String.IsNullOrEmpty(connString) Then
            connectionString = connString
        End If
    End Sub

    Public Function ExecuteQuery(query As String, ParamArray parameters() As SqlParameter) As SqlDataReader
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(query, conn)
        If parameters IsNot Nothing Then
            cmd.Parameters.AddRange(parameters)
        End If
        conn.Open()
        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    Public Function ExecuteDataTable(query As String, ParamArray parameters() As SqlParameter) As DataTable
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function ExecuteNonQuery(query As String, ParamArray parameters() As SqlParameter) As Integer
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(query As String, ParamArray parameters() As SqlParameter) As Object
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    ' Added utility function to check database connection
    Public Function TestConnection() As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class