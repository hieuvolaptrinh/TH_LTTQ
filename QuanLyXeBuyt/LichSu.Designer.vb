<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LichSu
    Inherits System.Windows.Forms.Form

    Public currentNguoiDungId As Integer = -1 ' Thêm trường để nhận ID người dùng

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTickets = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnHuyVe = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlVeHuy = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblSoVeHuy = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlTongTuyen = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTongSoVe = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HỗTrợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HướngDẫnSửDụngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChínhSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoSựCốToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TinTứcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CôngTyAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiấyChứngNhậnHợpQuyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuyểnDụngNhânSựToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýVéĐãĐặtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboTrangThai = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblTrangThai = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnInVe = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlVeHuy.SuspendLayout()
        Me.pnlTongTuyen.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTickets
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvTickets.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTickets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTickets.ColumnHeadersHeight = 40
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTickets.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTickets.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTickets.Location = New System.Drawing.Point(3, 13)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.RowHeadersVisible = False
        Me.dgvTickets.RowHeadersWidth = 51
        Me.dgvTickets.RowTemplate.Height = 29
        Me.dgvTickets.Size = New System.Drawing.Size(912, 459)
        Me.dgvTickets.TabIndex = 1
        Me.dgvTickets.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTickets.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTickets.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTickets.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTickets.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTickets.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvTickets.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTickets.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvTickets.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTickets.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dgvTickets.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTickets.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTickets.ThemeStyle.HeaderStyle.Height = 40
        Me.dgvTickets.ThemeStyle.ReadOnly = False
        Me.dgvTickets.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTickets.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTickets.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dgvTickets.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTickets.ThemeStyle.RowsStyle.Height = 29
        Me.dgvTickets.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTickets.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnHuyVe
        '
        Me.btnHuyVe.BorderRadius = 10
        Me.btnHuyVe.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnHuyVe.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnHuyVe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnHuyVe.ForeColor = System.Drawing.Color.White
        Me.btnHuyVe.Location = New System.Drawing.Point(950, 145)
        Me.btnHuyVe.Name = "btnHuyVe"
        Me.btnHuyVe.Size = New System.Drawing.Size(180, 40)
        Me.btnHuyVe.TabIndex = 1
        Me.btnHuyVe.Text = "Hủy vé"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(-5, 679)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(933, 30)
        Me.btnPrint.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.dgvTickets)
        Me.Panel1.Location = New System.Drawing.Point(0, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 475)
        Me.Panel1.TabIndex = 3
        '
        'pnlVeHuy
        '
        Me.pnlVeHuy.BackColor = System.Drawing.Color.Transparent
        Me.pnlVeHuy.Controls.Add(Me.lblSoVeHuy)
        Me.pnlVeHuy.Controls.Add(Me.Label9)
        Me.pnlVeHuy.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlVeHuy.Location = New System.Drawing.Point(706, 54)
        Me.pnlVeHuy.Name = "pnlVeHuy"
        Me.pnlVeHuy.Radius = 10
        Me.pnlVeHuy.ShadowColor = System.Drawing.Color.Black
        Me.pnlVeHuy.ShadowDepth = 10
        Me.pnlVeHuy.ShadowShift = 0
        Me.pnlVeHuy.Size = New System.Drawing.Size(209, 149)
        Me.pnlVeHuy.TabIndex = 6
        '
        'lblSoVeHuy
        '
        Me.lblSoVeHuy.AutoSize = True
        Me.lblSoVeHuy.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblSoVeHuy.ForeColor = System.Drawing.Color.White
        Me.lblSoVeHuy.Location = New System.Drawing.Point(20, 56)
        Me.lblSoVeHuy.Name = "lblSoVeHuy"
        Me.lblSoVeHuy.Size = New System.Drawing.Size(46, 54)
        Me.lblSoVeHuy.TabIndex = 9
        Me.lblSoVeHuy.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Vé Đã Hủy"
        '
        'pnlTongTuyen
        '
        Me.pnlTongTuyen.BackColor = System.Drawing.Color.Transparent
        Me.pnlTongTuyen.Controls.Add(Me.lblTongSoVe)
        Me.pnlTongTuyen.Controls.Add(Me.Label4)
        Me.pnlTongTuyen.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlTongTuyen.Location = New System.Drawing.Point(27, 55)
        Me.pnlTongTuyen.Name = "pnlTongTuyen"
        Me.pnlTongTuyen.Radius = 10
        Me.pnlTongTuyen.ShadowColor = System.Drawing.Color.Black
        Me.pnlTongTuyen.ShadowDepth = 10
        Me.pnlTongTuyen.ShadowShift = 0
        Me.pnlTongTuyen.Size = New System.Drawing.Size(263, 130)
        Me.pnlTongTuyen.TabIndex = 4
        '
        'lblTongSoVe
        '
        Me.lblTongSoVe.AutoSize = True
        Me.lblTongSoVe.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTongSoVe.ForeColor = System.Drawing.Color.White
        Me.lblTongSoVe.Location = New System.Drawing.Point(20, 55)
        Me.lblTongSoVe.Name = "lblTongSoVe"
        Me.lblTongSoVe.Size = New System.Drawing.Size(46, 54)
        Me.lblTongSoVe.TabIndex = 9
        Me.lblTongSoVe.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tổng Số Vé Đã Mua"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HỗTrợToolStripMenuItem, Me.TinTứcToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem, Me.QuảnLýVéĐãĐặtToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1905, 28)
        Me.MenuStrip1.TabIndex = 12
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
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CôngTyAToolStripMenuItem, Me.GiấyChứngNhậnHợpQuyToolStripMenuItem, Me.TuyểnDụngNhânSựToolStripMenuItem})
        Me.GiớiThiệuToolStripMenuItem.Image = Global.QuanLyXeBuyt.My.Resources.Resources.presentation
        Me.GiớiThiệuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới thiệu"
        '
        'CôngTyAToolStripMenuItem
        '
        Me.CôngTyAToolStripMenuItem.Name = "CôngTyAToolStripMenuItem"
        Me.CôngTyAToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.CôngTyAToolStripMenuItem.Text = "Công ty A"
        '
        'GiấyChứngNhậnHợpQuyToolStripMenuItem
        '
        Me.GiấyChứngNhậnHợpQuyToolStripMenuItem.Name = "GiấyChứngNhậnHợpQuyToolStripMenuItem"
        Me.GiấyChứngNhậnHợpQuyToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.GiấyChứngNhậnHợpQuyToolStripMenuItem.Text = "Giấy chứng nhận hợp quy"
        '
        'TuyểnDụngNhânSựToolStripMenuItem
        '
        Me.TuyểnDụngNhânSựToolStripMenuItem.Name = "TuyểnDụngNhânSựToolStripMenuItem"
        Me.TuyểnDụngNhânSựToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.TuyểnDụngNhânSựToolStripMenuItem.Text = "Tuyển dụng nhân sự"
        '
        'QuảnLýVéĐãĐặtToolStripMenuItem
        '
        Me.QuảnLýVéĐãĐặtToolStripMenuItem.Name = "QuảnLýVéĐãĐặtToolStripMenuItem"
        Me.QuảnLýVéĐãĐặtToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.QuảnLýVéĐãĐặtToolStripMenuItem.Text = "Quản lý vé đã đặt"
        '
        'cboTrangThai
        '
        Me.cboTrangThai.BackColor = System.Drawing.Color.Transparent
        Me.cboTrangThai.BorderRadius = 10
        Me.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrangThai.FocusedColor = System.Drawing.Color.Empty
        Me.cboTrangThai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboTrangThai.ItemHeight = 30
        Me.cboTrangThai.Items.AddRange(New Object() {"Tất cả", "Đã đặt", "Đã hủy"})
        Me.cboTrangThai.Location = New System.Drawing.Point(318, 96)
        Me.cboTrangThai.Name = "cboTrangThai"
        Me.cboTrangThai.Size = New System.Drawing.Size(353, 36)
        Me.cboTrangThai.TabIndex = 14
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(27, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(64, 19)
        Me.lblSearch.TabIndex = 17
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'lblTrangThai
        '
        Me.lblTrangThai.AutoSize = True
        Me.lblTrangThai.Location = New System.Drawing.Point(250, 10)
        Me.lblTrangThai.Name = "lblTrangThai"
        Me.lblTrangThai.Size = New System.Drawing.Size(70, 19)
        Me.lblTrangThai.TabIndex = 18
        Me.lblTrangThai.Text = "Trạng thái"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(420, 10)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(58, 19)
        Me.lblFromDate.TabIndex = 19
        Me.lblFromDate.Text = "Từ ngày"
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(590, 10)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(68, 19)
        Me.lblToDate.TabIndex = 20
        Me.lblToDate.Text = "Đến ngày"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyXeBuyt.InVe.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(950, 209)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(943, 475)
        Me.ReportViewer1.TabIndex = 21
        '
        'btnInVe
        '
        Me.btnInVe.BorderRadius = 10
        Me.btnInVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInVe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInVe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnInVe.ForeColor = System.Drawing.Color.White
        Me.btnInVe.Location = New System.Drawing.Point(950, 68)
        Me.btnInVe.Name = "btnInVe"
        Me.btnInVe.Size = New System.Drawing.Size(184, 42)
        Me.btnInVe.TabIndex = 22
        Me.btnInVe.Text = "In Vé"
        '
        'LichSu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1905, 709)
        Me.Controls.Add(Me.btnInVe)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlVeHuy)
        Me.Controls.Add(Me.pnlTongTuyen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHuyVe)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cboTrangThai)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblTrangThai)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.lblToDate)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Name = "LichSu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lịch sử đặt vé"
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlVeHuy.ResumeLayout(False)
        Me.pnlVeHuy.PerformLayout()
        Me.pnlTongTuyen.ResumeLayout(False)
        Me.pnlTongTuyen.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTickets As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnHuyVe As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Private WithEvents pnlVeHuy As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblSoVeHuy As Label
    Friend WithEvents Label9 As Label
    Private WithEvents pnlTongTuyen As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblTongSoVe As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HỗTrợToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HướngDẫnSửDụngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChínhSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoSựCốToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TinTứcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CôngTyAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiấyChứngNhậnHợpQuyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuyểnDụngNhânSựToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýVéĐãĐặtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboTrangThai As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpFromDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpToDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblTrangThai As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents lblToDate As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnInVe As Guna.UI2.WinForms.Guna2GradientButton
End Class
