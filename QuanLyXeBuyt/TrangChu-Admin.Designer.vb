<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTrangChu
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
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminTrangChu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClock = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlBottom = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnInThongKe = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnChiTietVe = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.timKiem = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBienSo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DateTimePickerNgayDen = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DateTimePickerNgayDi = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ComboBoxMaTuyenDuong = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTenXeKhach = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBienSo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlQuickActions = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnXoaVe = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnThemXe = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlNavigation = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnThongKe = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlVeHuy = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblVeHuyValue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDangXuat = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlTongTuyen = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTongTuyenValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlVeDat = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblVeDatValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HỗTrợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HướngDẫnSửDụngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChínhSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoSựCốToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TinTứcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýXeBuýtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LịchTrìnhVàTuyếnĐườngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchXeBuýtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BổSungTuyếnĐườngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrangChủToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuickActions.SuspendLayout()
        Me.pnlNavigation.SuspendLayout()
        Me.pnlVeHuy.SuspendLayout()
        Me.pnlTongTuyen.SuspendLayout()
        Me.pnlVeDat.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.Label2)
        Me.PanelContainer.Controls.Add(Me.lblClock)
        Me.PanelContainer.Controls.Add(Me.pnlBottom)
        Me.PanelContainer.Controls.Add(Me.pnlNavigation)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContainer.Location = New System.Drawing.Point(0, 25)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1400, 615)
        Me.PanelContainer.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(478, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(725, 59)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG"
        '
        'lblClock
        '
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblClock.Location = New System.Drawing.Point(1303, 42)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(77, 30)
        Me.lblClock.TabIndex = 5
        Me.lblClock.Text = "00:00:00"
        '
        'pnlBottom
        '
        Me.pnlBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBottom.AutoSize = True
        Me.pnlBottom.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottom.Controls.Add(Me.btnInThongKe)
        Me.pnlBottom.Controls.Add(Me.Panel1)
        Me.pnlBottom.Controls.Add(Me.btnChiTietVe)
        Me.pnlBottom.Controls.Add(Me.Label10)
        Me.pnlBottom.Controls.Add(Me.timKiem)
        Me.pnlBottom.Controls.Add(Me.txtBienSo)
        Me.pnlBottom.Controls.Add(Me.DateTimePickerNgayDen)
        Me.pnlBottom.Controls.Add(Me.DateTimePickerNgayDi)
        Me.pnlBottom.Controls.Add(Me.ComboBoxMaTuyenDuong)
        Me.pnlBottom.Controls.Add(Me.Label8)
        Me.pnlBottom.Controls.Add(Me.Label7)
        Me.pnlBottom.Controls.Add(Me.Label6)
        Me.pnlBottom.Controls.Add(Me.Label5)
        Me.pnlBottom.Controls.Add(Me.TextBoxTenXeKhach)
        Me.pnlBottom.Controls.Add(Me.Label1)
        Me.pnlBottom.Controls.Add(Me.TextBoxBienSo)
        Me.pnlBottom.Controls.Add(Me.pnlQuickActions)
        Me.pnlBottom.Location = New System.Drawing.Point(232, 79)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1171, 536)
        Me.pnlBottom.TabIndex = 6
        '
        'btnInThongKe
        '
        Me.btnInThongKe.BorderRadius = 15
        Me.btnInThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInThongKe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInThongKe.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInThongKe.FillColor2 = System.Drawing.Color.Red
        Me.btnInThongKe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnInThongKe.ForeColor = System.Drawing.Color.White
        Me.btnInThongKe.Location = New System.Drawing.Point(547, 188)
        Me.btnInThongKe.Name = "btnInThongKe"
        Me.btnInThongKe.Size = New System.Drawing.Size(217, 47)
        Me.btnInThongKe.TabIndex = 5
        Me.btnInThongKe.Text = "In thống kê"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(7, 315)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1161, 211)
        Me.Panel1.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(14, 10)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1135, 194)
        Me.DataGridView1.TabIndex = 2
        '
        'btnChiTietVe
        '
        Me.btnChiTietVe.BorderRadius = 15
        Me.btnChiTietVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChiTietVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChiTietVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChiTietVe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChiTietVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChiTietVe.FillColor = System.Drawing.Color.LimeGreen
        Me.btnChiTietVe.FillColor2 = System.Drawing.Color.ForestGreen
        Me.btnChiTietVe.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnChiTietVe.ForeColor = System.Drawing.Color.White
        Me.btnChiTietVe.Location = New System.Drawing.Point(547, 116)
        Me.btnChiTietVe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChiTietVe.Name = "btnChiTietVe"
        Me.btnChiTietVe.Size = New System.Drawing.Size(217, 48)
        Me.btnChiTietVe.TabIndex = 4
        Me.btnChiTietVe.Text = "Tất cả vé"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(7, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 54)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Danh Sách Xe "
        '
        'timKiem
        '
        Me.timKiem.BackColor = System.Drawing.Color.Transparent
        Me.timKiem.BorderRadius = 20
        Me.timKiem.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.timKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.timKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.timKiem.DisabledState.ForeColor = System.Drawing.Color.Black
        Me.timKiem.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.timKiem.FocusedColor = System.Drawing.Color.Green
        Me.timKiem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timKiem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.timKiem.Image = Global.QuanLyXeBuyt.My.Resources.Resources.find
        Me.timKiem.Location = New System.Drawing.Point(885, 262)
        Me.timKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.timKiem.Name = "timKiem"
        Me.timKiem.Size = New System.Drawing.Size(172, 36)
        Me.timKiem.TabIndex = 24
        Me.timKiem.Text = "Tìm Kiếm"
        '
        'txtBienSo
        '
        Me.txtBienSo.BackColor = System.Drawing.Color.Transparent
        Me.txtBienSo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBienSo.BorderRadius = 20
        Me.txtBienSo.BorderThickness = 2
        Me.txtBienSo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBienSo.DefaultText = ""
        Me.txtBienSo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBienSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBienSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBienSo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBienSo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBienSo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBienSo.ForeColor = System.Drawing.Color.Black
        Me.txtBienSo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBienSo.Location = New System.Drawing.Point(315, 262)
        Me.txtBienSo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtBienSo.PlaceholderText = "Biển số xe"
        Me.txtBienSo.SelectedText = ""
        Me.txtBienSo.Size = New System.Drawing.Size(385, 36)
        Me.txtBienSo.TabIndex = 23
        '
        'DateTimePickerNgayDen
        '
        Me.DateTimePickerNgayDen.Checked = True
        Me.DateTimePickerNgayDen.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DateTimePickerNgayDen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePickerNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePickerNgayDen.Location = New System.Drawing.Point(220, 164)
        Me.DateTimePickerNgayDen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerNgayDen.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerNgayDen.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerNgayDen.Name = "DateTimePickerNgayDen"
        Me.DateTimePickerNgayDen.Size = New System.Drawing.Size(276, 46)
        Me.DateTimePickerNgayDen.TabIndex = 19
        Me.DateTimePickerNgayDen.Value = New Date(2025, 3, 21, 17, 2, 4, 677)
        '
        'DateTimePickerNgayDi
        '
        Me.DateTimePickerNgayDi.Checked = True
        Me.DateTimePickerNgayDi.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DateTimePickerNgayDi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePickerNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePickerNgayDi.Location = New System.Drawing.Point(220, 104)
        Me.DateTimePickerNgayDi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerNgayDi.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerNgayDi.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerNgayDi.Name = "DateTimePickerNgayDi"
        Me.DateTimePickerNgayDi.Size = New System.Drawing.Size(276, 45)
        Me.DateTimePickerNgayDi.TabIndex = 20
        Me.DateTimePickerNgayDi.Value = New Date(2025, 3, 21, 17, 2, 4, 677)
        '
        'ComboBoxMaTuyenDuong
        '
        Me.ComboBoxMaTuyenDuong.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxMaTuyenDuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxMaTuyenDuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMaTuyenDuong.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxMaTuyenDuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxMaTuyenDuong.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMaTuyenDuong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboBoxMaTuyenDuong.ItemHeight = 30
        Me.ComboBoxMaTuyenDuong.Location = New System.Drawing.Point(547, 60)
        Me.ComboBoxMaTuyenDuong.Name = "ComboBoxMaTuyenDuong"
        Me.ComboBoxMaTuyenDuong.Size = New System.Drawing.Size(227, 36)
        Me.ComboBoxMaTuyenDuong.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(547, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 31)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Mã tuyến đường"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(30, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 31)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ngày đi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(30, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 31)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ngày đến"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(30, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tên xe khách"
        '
        'TextBoxTenXeKhach
        '
        Me.TextBoxTenXeKhach.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.TextBoxTenXeKhach.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxTenXeKhach.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxTenXeKhach.BorderRadius = 15
        Me.TextBoxTenXeKhach.BorderThickness = 2
        Me.TextBoxTenXeKhach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxTenXeKhach.DefaultText = ""
        Me.TextBoxTenXeKhach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxTenXeKhach.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxTenXeKhach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxTenXeKhach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxTenXeKhach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxTenXeKhach.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTenXeKhach.ForeColor = System.Drawing.Color.Black
        Me.TextBoxTenXeKhach.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxTenXeKhach.Location = New System.Drawing.Point(220, 60)
        Me.TextBoxTenXeKhach.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTenXeKhach.Name = "TextBoxTenXeKhach"
        Me.TextBoxTenXeKhach.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TextBoxTenXeKhach.PlaceholderText = ""
        Me.TextBoxTenXeKhach.SelectedText = ""
        Me.TextBoxTenXeKhach.Size = New System.Drawing.Size(276, 34)
        Me.TextBoxTenXeKhach.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(30, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Biển số xe"
        '
        'TextBoxBienSo
        '
        Me.TextBoxBienSo.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.TextBoxBienSo.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxBienSo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxBienSo.BorderRadius = 15
        Me.TextBoxBienSo.BorderThickness = 2
        Me.TextBoxBienSo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxBienSo.DefaultText = ""
        Me.TextBoxBienSo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxBienSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxBienSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxBienSo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxBienSo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxBienSo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBienSo.ForeColor = System.Drawing.Color.Black
        Me.TextBoxBienSo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxBienSo.Location = New System.Drawing.Point(220, 18)
        Me.TextBoxBienSo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBienSo.Name = "TextBoxBienSo"
        Me.TextBoxBienSo.PlaceholderForeColor = System.Drawing.Color.Black
        Me.TextBoxBienSo.PlaceholderText = ""
        Me.TextBoxBienSo.SelectedText = ""
        Me.TextBoxBienSo.Size = New System.Drawing.Size(151, 34)
        Me.TextBoxBienSo.TabIndex = 12
        '
        'pnlQuickActions
        '
        Me.pnlQuickActions.BackColor = System.Drawing.Color.Transparent
        Me.pnlQuickActions.Controls.Add(Me.Guna2GradientButton1)
        Me.pnlQuickActions.Controls.Add(Me.btnXoaVe)
        Me.pnlQuickActions.Controls.Add(Me.btnThemXe)
        Me.pnlQuickActions.FillColor = System.Drawing.Color.White
        Me.pnlQuickActions.Location = New System.Drawing.Point(851, 18)
        Me.pnlQuickActions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlQuickActions.Name = "pnlQuickActions"
        Me.pnlQuickActions.Radius = 10
        Me.pnlQuickActions.ShadowColor = System.Drawing.Color.Black
        Me.pnlQuickActions.ShadowDepth = 10
        Me.pnlQuickActions.ShadowShift = 0
        Me.pnlQuickActions.Size = New System.Drawing.Size(279, 236)
        Me.pnlQuickActions.TabIndex = 1
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderRadius = 15
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(34, 98)
        Me.Guna2GradientButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(217, 48)
        Me.Guna2GradientButton1.TabIndex = 4
        Me.Guna2GradientButton1.Text = "Sửa Thông Tin Xe"
        '
        'btnXoaVe
        '
        Me.btnXoaVe.BorderRadius = 15
        Me.btnXoaVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnXoaVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnXoaVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnXoaVe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnXoaVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnXoaVe.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnXoaVe.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnXoaVe.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnXoaVe.ForeColor = System.Drawing.Color.White
        Me.btnXoaVe.Location = New System.Drawing.Point(34, 170)
        Me.btnXoaVe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnXoaVe.Name = "btnXoaVe"
        Me.btnXoaVe.Size = New System.Drawing.Size(217, 48)
        Me.btnXoaVe.TabIndex = 3
        Me.btnXoaVe.Text = "Xóa vé xe"
        '
        'btnThemXe
        '
        Me.btnThemXe.BorderRadius = 15
        Me.btnThemXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnThemXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnThemXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnThemXe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnThemXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnThemXe.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnThemXe.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnThemXe.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnThemXe.ForeColor = System.Drawing.Color.White
        Me.btnThemXe.Location = New System.Drawing.Point(34, 16)
        Me.btnThemXe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnThemXe.Name = "btnThemXe"
        Me.btnThemXe.Size = New System.Drawing.Size(217, 50)
        Me.btnThemXe.TabIndex = 1
        Me.btnThemXe.Text = "Thêm Xe Mới"
        '
        'pnlNavigation
        '
        Me.pnlNavigation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnlNavigation.Controls.Add(Me.btnThongKe)
        Me.pnlNavigation.Controls.Add(Me.pnlVeHuy)
        Me.pnlNavigation.Controls.Add(Me.btnDangXuat)
        Me.pnlNavigation.Controls.Add(Me.pnlTongTuyen)
        Me.pnlNavigation.Controls.Add(Me.pnlVeDat)
        Me.pnlNavigation.Location = New System.Drawing.Point(0, 2)
        Me.pnlNavigation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(233, 613)
        Me.pnlNavigation.TabIndex = 4
        '
        'btnThongKe
        '
        Me.btnThongKe.BorderRadius = 15
        Me.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnThongKe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnThongKe.FillColor = System.Drawing.Color.Pink
        Me.btnThongKe.FillColor2 = System.Drawing.Color.HotPink
        Me.btnThongKe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThongKe.ForeColor = System.Drawing.Color.White
        Me.btnThongKe.Location = New System.Drawing.Point(7, 402)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(219, 80)
        Me.btnThongKe.TabIndex = 5
        Me.btnThongKe.Text = "Thống kê"
        '
        'pnlVeHuy
        '
        Me.pnlVeHuy.BackColor = System.Drawing.Color.Transparent
        Me.pnlVeHuy.Controls.Add(Me.lblVeHuyValue)
        Me.pnlVeHuy.Controls.Add(Me.Label9)
        Me.pnlVeHuy.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlVeHuy.Location = New System.Drawing.Point(3, 286)
        Me.pnlVeHuy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlVeHuy.Name = "pnlVeHuy"
        Me.pnlVeHuy.Radius = 10
        Me.pnlVeHuy.ShadowColor = System.Drawing.Color.Black
        Me.pnlVeHuy.ShadowDepth = 10
        Me.pnlVeHuy.ShadowShift = 0
        Me.pnlVeHuy.Size = New System.Drawing.Size(223, 90)
        Me.pnlVeHuy.TabIndex = 3
        '
        'lblVeHuyValue
        '
        Me.lblVeHuyValue.AutoSize = True
        Me.lblVeHuyValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblVeHuyValue.ForeColor = System.Drawing.Color.White
        Me.lblVeHuyValue.Location = New System.Drawing.Point(20, 38)
        Me.lblVeHuyValue.Name = "lblVeHuyValue"
        Me.lblVeHuyValue.Size = New System.Drawing.Size(46, 54)
        Me.lblVeHuyValue.TabIndex = 9
        Me.lblVeHuyValue.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Vé bị hủy hôm nay"
        '
        'btnDangXuat
        '
        Me.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDangXuat.BorderRadius = 10
        Me.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDangXuat.FillColor = System.Drawing.Color.Transparent
        Me.btnDangXuat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDangXuat.ForeColor = System.Drawing.Color.Black
        Me.btnDangXuat.Location = New System.Drawing.Point(3, 556)
        Me.btnDangXuat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDangXuat.Name = "btnDangXuat"
        Me.btnDangXuat.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDangXuat.Size = New System.Drawing.Size(233, 40)
        Me.btnDangXuat.TabIndex = 4
        Me.btnDangXuat.Text = "Đăng xuất"
        Me.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlTongTuyen
        '
        Me.pnlTongTuyen.BackColor = System.Drawing.Color.Transparent
        Me.pnlTongTuyen.Controls.Add(Me.lblTongTuyenValue)
        Me.pnlTongTuyen.Controls.Add(Me.Label4)
        Me.pnlTongTuyen.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTongTuyen.Location = New System.Drawing.Point(3, 168)
        Me.pnlTongTuyen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTongTuyen.Name = "pnlTongTuyen"
        Me.pnlTongTuyen.Radius = 10
        Me.pnlTongTuyen.ShadowColor = System.Drawing.Color.Black
        Me.pnlTongTuyen.ShadowDepth = 10
        Me.pnlTongTuyen.ShadowShift = 0
        Me.pnlTongTuyen.Size = New System.Drawing.Size(223, 88)
        Me.pnlTongTuyen.TabIndex = 1
        '
        'lblTongTuyenValue
        '
        Me.lblTongTuyenValue.AutoSize = True
        Me.lblTongTuyenValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTongTuyenValue.ForeColor = System.Drawing.Color.White
        Me.lblTongTuyenValue.Location = New System.Drawing.Point(20, 37)
        Me.lblTongTuyenValue.Name = "lblTongTuyenValue"
        Me.lblTongTuyenValue.Size = New System.Drawing.Size(46, 54)
        Me.lblTongTuyenValue.TabIndex = 9
        Me.lblTongTuyenValue.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tổng số tuyến đường"
        '
        'pnlVeDat
        '
        Me.pnlVeDat.BackColor = System.Drawing.Color.Transparent
        Me.pnlVeDat.Controls.Add(Me.lblVeDatValue)
        Me.pnlVeDat.Controls.Add(Me.Label3)
        Me.pnlVeDat.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlVeDat.Location = New System.Drawing.Point(3, 42)
        Me.pnlVeDat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlVeDat.Name = "pnlVeDat"
        Me.pnlVeDat.Radius = 10
        Me.pnlVeDat.ShadowColor = System.Drawing.Color.Black
        Me.pnlVeDat.ShadowDepth = 10
        Me.pnlVeDat.ShadowShift = 0
        Me.pnlVeDat.Size = New System.Drawing.Size(220, 97)
        Me.pnlVeDat.TabIndex = 2
        '
        'lblVeDatValue
        '
        Me.lblVeDatValue.AutoSize = True
        Me.lblVeDatValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblVeDatValue.ForeColor = System.Drawing.Color.White
        Me.lblVeDatValue.Location = New System.Drawing.Point(20, 35)
        Me.lblVeDatValue.Name = "lblVeDatValue"
        Me.lblVeDatValue.Size = New System.Drawing.Size(46, 54)
        Me.lblVeDatValue.TabIndex = 9
        Me.lblVeDatValue.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Vé đã đặt hôm nay"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HỗTrợToolStripMenuItem, Me.TinTứcToolStripMenuItem, Me.QuảnLýXeBuýtToolStripMenuItem, Me.TrangChủToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1400, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HỗTrợToolStripMenuItem
        '
        Me.HỗTrợToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiênHệToolStripMenuItem, Me.HướngDẫnSửDụngToolStripMenuItem, Me.ChínhSáchToolStripMenuItem, Me.BáoCáoSựCốToolStripMenuItem})
        Me.HỗTrợToolStripMenuItem.Image = Global.QuanLyXeBuyt.My.Resources.Resources.question
        Me.HỗTrợToolStripMenuItem.Name = "HỗTrợToolStripMenuItem"
        Me.HỗTrợToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.HỗTrợToolStripMenuItem.Text = "Hỗ trợ"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.LiênHệToolStripMenuItem.Text = "Liên hệ"
        '
        'HướngDẫnSửDụngToolStripMenuItem
        '
        Me.HướngDẫnSửDụngToolStripMenuItem.Name = "HướngDẫnSửDụngToolStripMenuItem"
        Me.HướngDẫnSửDụngToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.HướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng"
        '
        'ChínhSáchToolStripMenuItem
        '
        Me.ChínhSáchToolStripMenuItem.Name = "ChínhSáchToolStripMenuItem"
        Me.ChínhSáchToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ChínhSáchToolStripMenuItem.Text = "Chính sách "
        '
        'BáoCáoSựCốToolStripMenuItem
        '
        Me.BáoCáoSựCốToolStripMenuItem.Name = "BáoCáoSựCốToolStripMenuItem"
        Me.BáoCáoSựCốToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.BáoCáoSựCốToolStripMenuItem.Text = "Báo cáo sự cố"
        '
        'TinTứcToolStripMenuItem
        '
        Me.TinTứcToolStripMenuItem.Image = Global.QuanLyXeBuyt.My.Resources.Resources.megaphone
        Me.TinTứcToolStripMenuItem.Name = "TinTứcToolStripMenuItem"
        Me.TinTứcToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.TinTứcToolStripMenuItem.Text = "Tin tức"
        '
        'QuảnLýXeBuýtToolStripMenuItem
        '
        Me.QuảnLýXeBuýtToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LịchTrìnhVàTuyếnĐườngToolStripMenuItem, Me.DanhSáchXeBuýtToolStripMenuItem, Me.BổSungTuyếnĐườngToolStripMenuItem})
        Me.QuảnLýXeBuýtToolStripMenuItem.Image = Global.QuanLyXeBuyt.My.Resources.Resources.project_management
        Me.QuảnLýXeBuýtToolStripMenuItem.Name = "QuảnLýXeBuýtToolStripMenuItem"
        Me.QuảnLýXeBuýtToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.QuảnLýXeBuýtToolStripMenuItem.Text = "Quản lý xe buýt"
        '
        'LịchTrìnhVàTuyếnĐườngToolStripMenuItem
        '
        Me.LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Name = "LịchTrìnhVàTuyếnĐườngToolStripMenuItem"
        Me.LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Text = "Lịch trình và tuyến đường"
        '
        'DanhSáchXeBuýtToolStripMenuItem
        '
        Me.DanhSáchXeBuýtToolStripMenuItem.Name = "DanhSáchXeBuýtToolStripMenuItem"
        Me.DanhSáchXeBuýtToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.DanhSáchXeBuýtToolStripMenuItem.Text = "Danh sách xe buýt"
        '
        'BổSungTuyếnĐườngToolStripMenuItem
        '
        Me.BổSungTuyếnĐườngToolStripMenuItem.Name = "BổSungTuyếnĐườngToolStripMenuItem"
        Me.BổSungTuyếnĐườngToolStripMenuItem.Size = New System.Drawing.Size(272, 26)
        Me.BổSungTuyếnĐườngToolStripMenuItem.Text = "Bổ sung tuyến đường"
        '
        'TrangChủToolStripMenuItem
        '
        Me.TrangChủToolStripMenuItem.Image = CType(resources.GetObject("TrangChủToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrangChủToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TrangChủToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TrangChủToolStripMenuItem.Name = "TrangChủToolStripMenuItem"
        Me.TrangChủToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.TrangChủToolStripMenuItem.Text = "Trang Chủ"
        Me.TrangChủToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminTrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 640)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelContainer)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminTrangChu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Vé Xe Khách"
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuickActions.ResumeLayout(False)
        Me.pnlNavigation.ResumeLayout(False)
        Me.pnlVeHuy.ResumeLayout(False)
        Me.pnlVeHuy.PerformLayout()
        Me.pnlTongTuyen.ResumeLayout(False)
        Me.pnlTongTuyen.PerformLayout()
        Me.pnlVeDat.ResumeLayout(False)
        Me.pnlVeDat.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelContainer As Panel
    Private WithEvents lblClock As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents pnlBottom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents timKiem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBienSo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DateTimePickerNgayDen As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DateTimePickerNgayDi As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents ComboBoxMaTuyenDuong As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTenXeKhach As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBienSo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents pnlQuickActions As Guna.UI2.WinForms.Guna2ShadowPanel
    Private WithEvents btnXoaVe As Guna.UI2.WinForms.Guna2GradientButton
    Private WithEvents btnThemXe As Guna.UI2.WinForms.Guna2GradientButton
    Private WithEvents pnlNavigation As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlVeHuy As Guna.UI2.WinForms.Guna2ShadowPanel
    Private WithEvents btnDangXuat As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlTongTuyen As Guna.UI2.WinForms.Guna2ShadowPanel
    Private WithEvents pnlVeDat As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HỗTrợToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HướngDẫnSửDụngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChínhSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoSựCốToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TinTứcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýXeBuýtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LịchTrìnhVàTuyếnĐườngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchXeBuýtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BổSungTuyếnĐườngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrangChủToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblVeDatValue As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblVeHuyValue As Label
    Friend WithEvents lblTongTuyenValue As Label
    Private WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Private WithEvents btnChiTietVe As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThongKe As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnInThongKe As Guna.UI2.WinForms.Guna2GradientButton
    '// [END] Control Declarations
End Class
