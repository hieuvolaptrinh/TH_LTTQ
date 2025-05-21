<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TuyenDuong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSua = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnXoa = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaTuyen = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnThem = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLamMoi = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtDiemDen = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtKhoangCach = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDiemDi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlMenu.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Depth = 5
        Me.pnlMenu.ShadowDecoration.Enabled = True
        Me.pnlMenu.Size = New System.Drawing.Size(1262, 85)
        Me.pnlMenu.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(222, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 60)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Quản Lý Tuyến Đường Cho Xe Khách"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(550, 425)
        Me.DataGridView1.TabIndex = 13
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSua)
        Me.Guna2GroupBox1.Controls.Add(Me.btnXoa)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMaTuyen)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.btnThem)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.btnLamMoi)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDiemDen)
        Me.Guna2GroupBox1.Controls.Add(Me.txtKhoangCach)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDiemDi)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(626, 98)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(636, 458)
        Me.Guna2GroupBox1.TabIndex = 14
        Me.Guna2GroupBox1.Text = "Thông Tin Tuyến"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(55, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 38)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mã Tuyến"
        '
        'btnSua
        '
        Me.btnSua.BorderRadius = 15
        Me.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSua.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSua.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSua.ForeColor = System.Drawing.Color.White
        Me.btnSua.Location = New System.Drawing.Point(174, 384)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(130, 42)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Sửa"
        '
        'btnXoa
        '
        Me.btnXoa.BorderRadius = 15
        Me.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnXoa.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnXoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnXoa.ForeColor = System.Drawing.Color.White
        Me.btnXoa.Location = New System.Drawing.Point(480, 384)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(130, 42)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "Xóa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(55, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 38)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Khoảng Cách (km):"
        '
        'txtMaTuyen
        '
        Me.txtMaTuyen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtMaTuyen.BorderRadius = 10
        Me.txtMaTuyen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaTuyen.DefaultText = ""
        Me.txtMaTuyen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMaTuyen.Location = New System.Drawing.Point(376, 75)
        Me.txtMaTuyen.Name = "txtMaTuyen"
        Me.txtMaTuyen.PlaceholderText = ""
        Me.txtMaTuyen.SelectedText = ""
        Me.txtMaTuyen.Size = New System.Drawing.Size(200, 30)
        Me.txtMaTuyen.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(55, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 38)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Điểm Đến:"
        '
        'btnThem
        '
        Me.btnThem.BorderRadius = 15
        Me.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnThem.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnThem.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnThem.ForeColor = System.Drawing.Color.White
        Me.btnThem.Location = New System.Drawing.Point(21, 385)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(130, 42)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "Thêm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(55, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 38)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Điểm Đi:"
        '
        'btnLamMoi
        '
        Me.btnLamMoi.BorderRadius = 15
        Me.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLamMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLamMoi.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLamMoi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLamMoi.ForeColor = System.Drawing.Color.White
        Me.btnLamMoi.Location = New System.Drawing.Point(326, 385)
        Me.btnLamMoi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(130, 42)
        Me.btnLamMoi.TabIndex = 6
        Me.btnLamMoi.Text = "Làm mới"
        '
        'txtDiemDen
        '
        Me.txtDiemDen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtDiemDen.BorderRadius = 10
        Me.txtDiemDen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiemDen.DefaultText = ""
        Me.txtDiemDen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDiemDen.Location = New System.Drawing.Point(376, 139)
        Me.txtDiemDen.Name = "txtDiemDen"
        Me.txtDiemDen.PlaceholderText = ""
        Me.txtDiemDen.SelectedText = ""
        Me.txtDiemDen.Size = New System.Drawing.Size(200, 30)
        Me.txtDiemDen.TabIndex = 3
        '
        'txtKhoangCach
        '
        Me.txtKhoangCach.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtKhoangCach.BorderRadius = 10
        Me.txtKhoangCach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKhoangCach.DefaultText = ""
        Me.txtKhoangCach.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKhoangCach.Location = New System.Drawing.Point(376, 265)
        Me.txtKhoangCach.Name = "txtKhoangCach"
        Me.txtKhoangCach.PlaceholderText = ""
        Me.txtKhoangCach.SelectedText = ""
        Me.txtKhoangCach.Size = New System.Drawing.Size(200, 30)
        Me.txtKhoangCach.TabIndex = 8
        '
        'txtDiemDi
        '
        Me.txtDiemDi.BorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtDiemDi.BorderRadius = 10
        Me.txtDiemDi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiemDi.DefaultText = ""
        Me.txtDiemDi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDiemDi.Location = New System.Drawing.Point(376, 202)
        Me.txtDiemDi.Name = "txtDiemDi"
        Me.txtDiemDi.PlaceholderText = ""
        Me.txtDiemDi.SelectedText = ""
        Me.txtDiemDi.Size = New System.Drawing.Size(200, 30)
        Me.txtDiemDi.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(342, 38)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Danh Sách Tuyến Đường"
        '
        'TuyenDuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 565)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pnlMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TuyenDuong"
        Me.Text = "TuyenDuong"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label2 As Label
    Private WithEvents btnSua As Guna.UI2.WinForms.Guna2GradientButton
    Private WithEvents btnXoa As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label5 As Label
    Public WithEvents txtMaTuyen As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Private WithEvents btnThem As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label3 As Label
    Private WithEvents btnLamMoi As Guna.UI2.WinForms.Guna2GradientButton
    Public WithEvents txtDiemDen As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtKhoangCach As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents txtDiemDi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
End Class
