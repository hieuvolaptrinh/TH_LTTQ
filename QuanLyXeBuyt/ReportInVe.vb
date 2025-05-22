Imports Microsoft.Reporting.WinForms
Imports System.Data

Public Class ReportInVe
    Private reportData As DataTable

    Private Sub ReportInVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If reportData IsNot Nothing Then
            DisplayReport()
        End If
    End Sub

    Public Sub SetReportData(dt As DataTable)
        reportData = dt
        If Me.Visible Then
            DisplayReport()
        End If
    End Sub

    Private Sub DisplayReport()
        Try
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim rds As New ReportDataSource("DataSet1", reportData)
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\InVe.rdlc"
            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi in vé: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class