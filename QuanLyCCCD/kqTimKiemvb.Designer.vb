<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kqTimKiem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvKetQua = New DataGridView()
        CType(dgvKetQua, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvKetQua
        ' 
        dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKetQua.Location = New Point(-5, 1)
        dgvKetQua.Name = "dgvKetQua"
        dgvKetQua.RowHeadersWidth = 51
        dgvKetQua.Size = New Size(806, 449)
        dgvKetQua.TabIndex = 0
        ' 
        ' kqTimKiem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvKetQua)
        Name = "kqTimKiem"
        Text = "kqTimKiem"
        CType(dgvKetQua, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvKetQua As DataGridView
End Class
