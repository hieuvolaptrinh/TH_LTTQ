<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LichSu
    Inherits System.Windows.Forms.Form

    Public currentNguoiDungId As Integer = -1 ' Thêm trường để nhận ID người dùng

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvTickets = New Guna.UI2.WinForms.Guna2DataGridView()
        btnHuyVe = New Guna.UI2.WinForms.Guna2GradientButton()
        btnPrint = New Guna.UI2.WinForms.Guna2GradientButton()
        Panel1 = New Panel()
        btnTroVeDatVe = New Guna.UI2.WinForms.Guna2GradientButton()
        pnlVeHuy = New Guna.UI2.WinForms.Guna2ShadowPanel()
        lblSoVeHuy = New Label()
        Label9 = New Label()
        pnlTongTuyen = New Guna.UI2.WinForms.Guna2ShadowPanel()
        lblTongSoVe = New Label()
        Label4 = New Label()
        MenuStrip1 = New MenuStrip()
        HỗTrợToolStripMenuItem = New ToolStripMenuItem()
        LiênHệToolStripMenuItem = New ToolStripMenuItem()
        HướngDẫnSửDụngToolStripMenuItem = New ToolStripMenuItem()
        ChínhSáchToolStripMenuItem = New ToolStripMenuItem()
        BáoCáoSựCốToolStripMenuItem = New ToolStripMenuItem()
        TinTứcToolStripMenuItem = New ToolStripMenuItem()
        GiớiThiệuToolStripMenuItem = New ToolStripMenuItem()
        CôngTyAToolStripMenuItem = New ToolStripMenuItem()
        GiấyChứngNhậnHợpQuyToolStripMenuItem = New ToolStripMenuItem()
        TuyểnDụngNhânSựToolStripMenuItem = New ToolStripMenuItem()
        QuảnLýVéĐãĐặtToolStripMenuItem = New ToolStripMenuItem()
        cboTrangThai = New Guna.UI2.WinForms.Guna2ComboBox()
        lblSearch = New Label()
        lblTrangThai = New Label()
        lblFromDate = New Label()
        lblToDate = New Label()
        CType(dgvTickets, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        pnlVeHuy.SuspendLayout()
        pnlTongTuyen.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvTickets
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTickets.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.25F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTickets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTickets.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 8.25F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTickets.DefaultCellStyle = DataGridViewCellStyle3
        dgvTickets.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTickets.Location = New Point(23, 13)
        dgvTickets.Name = "dgvTickets"
        dgvTickets.RowHeadersVisible = False
        dgvTickets.RowHeadersWidth = 51
        dgvTickets.Size = New Size(1296, 459)
        dgvTickets.TabIndex = 1
        dgvTickets.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvTickets.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvTickets.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvTickets.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvTickets.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvTickets.ThemeStyle.BackColor = Color.White
        dgvTickets.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTickets.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        dgvTickets.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvTickets.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 8.25F)
        dgvTickets.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvTickets.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTickets.ThemeStyle.HeaderStyle.Height = 40
        dgvTickets.ThemeStyle.ReadOnly = False
        dgvTickets.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvTickets.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTickets.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 8.25F)
        dgvTickets.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvTickets.ThemeStyle.RowsStyle.Height = 29
        dgvTickets.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTickets.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btnHuyVe
        ' 
        btnHuyVe.BorderRadius = 10
        btnHuyVe.CustomizableEdges = CustomizableEdges1
        btnHuyVe.FillColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        btnHuyVe.FillColor2 = Color.FromArgb(CByte(239), CByte(83), CByte(80))
        btnHuyVe.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnHuyVe.ForeColor = Color.White
        btnHuyVe.Location = New Point(1120, 145)
        btnHuyVe.Name = "btnHuyVe"
        btnHuyVe.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnHuyVe.Size = New Size(180, 40)
        btnHuyVe.TabIndex = 1
        btnHuyVe.Text = "Hủy vé"
        ' 
        ' btnPrint
        ' 
        btnPrint.CustomizableEdges = CustomizableEdges3
        btnPrint.Font = New Font("Segoe UI", 9F)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(-5, 679)
        btnPrint.Name = "btnPrint"
        btnPrint.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPrint.Size = New Size(1336, 30)
        btnPrint.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(dgvTickets)
        Panel1.Location = New Point(0, 209)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1331, 475)
        Panel1.TabIndex = 3
        ' 
        ' btnTroVeDatVe
        ' 
        btnTroVeDatVe.BorderRadius = 10
        btnTroVeDatVe.CustomizableEdges = CustomizableEdges5
        btnTroVeDatVe.FillColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnTroVeDatVe.FillColor2 = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnTroVeDatVe.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnTroVeDatVe.ForeColor = Color.White
        btnTroVeDatVe.Location = New Point(1120, 54)
        btnTroVeDatVe.Name = "btnTroVeDatVe"
        btnTroVeDatVe.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnTroVeDatVe.Size = New Size(180, 40)
        btnTroVeDatVe.TabIndex = 0
        btnTroVeDatVe.Text = "Đặt Vé"
        ' 
        ' pnlVeHuy
        ' 
        pnlVeHuy.BackColor = Color.Transparent
        pnlVeHuy.Controls.Add(lblSoVeHuy)
        pnlVeHuy.Controls.Add(Label9)
        pnlVeHuy.FillColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        pnlVeHuy.Location = New Point(817, 54)
        pnlVeHuy.Name = "pnlVeHuy"
        pnlVeHuy.Radius = 10
        pnlVeHuy.ShadowColor = Color.Black
        pnlVeHuy.ShadowDepth = 10
        pnlVeHuy.ShadowShift = 0
        pnlVeHuy.Size = New Size(209, 149)
        pnlVeHuy.TabIndex = 6
        ' 
        ' lblSoVeHuy
        ' 
        lblSoVeHuy.AutoSize = True
        lblSoVeHuy.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblSoVeHuy.ForeColor = Color.White
        lblSoVeHuy.Location = New Point(20, 56)
        lblSoVeHuy.Name = "lblSoVeHuy"
        lblSoVeHuy.Size = New Size(46, 54)
        lblSoVeHuy.TabIndex = 9
        lblSoVeHuy.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(20, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 28)
        Label9.TabIndex = 9
        Label9.Text = "Vé Đã Hủy"
        ' 
        ' pnlTongTuyen
        ' 
        pnlTongTuyen.BackColor = Color.Transparent
        pnlTongTuyen.Controls.Add(lblTongSoVe)
        pnlTongTuyen.Controls.Add(Label4)
        pnlTongTuyen.FillColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        pnlTongTuyen.Location = New Point(27, 55)
        pnlTongTuyen.Name = "pnlTongTuyen"
        pnlTongTuyen.Radius = 10
        pnlTongTuyen.ShadowColor = Color.Black
        pnlTongTuyen.ShadowDepth = 10
        pnlTongTuyen.ShadowShift = 0
        pnlTongTuyen.Size = New Size(263, 130)
        pnlTongTuyen.TabIndex = 4
        ' 
        ' lblTongSoVe
        ' 
        lblTongSoVe.AutoSize = True
        lblTongSoVe.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblTongSoVe.ForeColor = Color.White
        lblTongSoVe.Location = New Point(20, 55)
        lblTongSoVe.Name = "lblTongSoVe"
        lblTongSoVe.Size = New Size(46, 54)
        lblTongSoVe.TabIndex = 9
        lblTongSoVe.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(20, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(184, 28)
        Label4.TabIndex = 9
        Label4.Text = "Tổng Số Vé Đã Mua"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HỗTrợToolStripMenuItem, TinTứcToolStripMenuItem, GiớiThiệuToolStripMenuItem, QuảnLýVéĐãĐặtToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(1797, 28)
        MenuStrip1.TabIndex = 12
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HỗTrợToolStripMenuItem
        ' 
        HỗTrợToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LiênHệToolStripMenuItem, HướngDẫnSửDụngToolStripMenuItem, ChínhSáchToolStripMenuItem, BáoCáoSựCốToolStripMenuItem})
        HỗTrợToolStripMenuItem.Image = My.Resources.Resources.question
        HỗTrợToolStripMenuItem.Name = "HỗTrợToolStripMenuItem"
        HỗTrợToolStripMenuItem.Size = New Size(88, 24)
        HỗTrợToolStripMenuItem.Text = "Hỗ trợ"
        ' 
        ' LiênHệToolStripMenuItem
        ' 
        LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        LiênHệToolStripMenuItem.Size = New Size(231, 26)
        LiênHệToolStripMenuItem.Text = "Liên hệ"
        ' 
        ' HướngDẫnSửDụngToolStripMenuItem
        ' 
        HướngDẫnSửDụngToolStripMenuItem.Name = "HướngDẫnSửDụngToolStripMenuItem"
        HướngDẫnSửDụngToolStripMenuItem.Size = New Size(231, 26)
        HướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng"
        ' 
        ' ChínhSáchToolStripMenuItem
        ' 
        ChínhSáchToolStripMenuItem.Name = "ChínhSáchToolStripMenuItem"
        ChínhSáchToolStripMenuItem.Size = New Size(231, 26)
        ChínhSáchToolStripMenuItem.Text = "Chính sách "
        ' 
        ' BáoCáoSựCốToolStripMenuItem
        ' 
        BáoCáoSựCốToolStripMenuItem.Name = "BáoCáoSựCốToolStripMenuItem"
        BáoCáoSựCốToolStripMenuItem.Size = New Size(231, 26)
        BáoCáoSựCốToolStripMenuItem.Text = "Báo cáo sự cố"
        ' 
        ' TinTứcToolStripMenuItem
        ' 
        TinTứcToolStripMenuItem.Image = My.Resources.Resources.megaphone
        TinTứcToolStripMenuItem.Name = "TinTứcToolStripMenuItem"
        TinTứcToolStripMenuItem.Size = New Size(92, 24)
        TinTứcToolStripMenuItem.Text = "Tin tức"
        ' 
        ' GiớiThiệuToolStripMenuItem
        ' 
        GiớiThiệuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CôngTyAToolStripMenuItem, GiấyChứngNhậnHợpQuyToolStripMenuItem, TuyểnDụngNhânSựToolStripMenuItem})
        GiớiThiệuToolStripMenuItem.Image = My.Resources.Resources.presentation
        GiớiThiệuToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        GiớiThiệuToolStripMenuItem.Size = New Size(111, 24)
        GiớiThiệuToolStripMenuItem.Text = "Giới thiệu"
        ' 
        ' CôngTyAToolStripMenuItem
        ' 
        CôngTyAToolStripMenuItem.Name = "CôngTyAToolStripMenuItem"
        CôngTyAToolStripMenuItem.Size = New Size(271, 26)
        CôngTyAToolStripMenuItem.Text = "Công ty A"
        ' 
        ' GiấyChứngNhậnHợpQuyToolStripMenuItem
        ' 
        GiấyChứngNhậnHợpQuyToolStripMenuItem.Name = "GiấyChứngNhậnHợpQuyToolStripMenuItem"
        GiấyChứngNhậnHợpQuyToolStripMenuItem.Size = New Size(271, 26)
        GiấyChứngNhậnHợpQuyToolStripMenuItem.Text = "Giấy chứng nhận hợp quy"
        ' 
        ' TuyểnDụngNhânSựToolStripMenuItem
        ' 
        TuyểnDụngNhânSựToolStripMenuItem.Name = "TuyểnDụngNhânSựToolStripMenuItem"
        TuyểnDụngNhânSựToolStripMenuItem.Size = New Size(271, 26)
        TuyểnDụngNhânSựToolStripMenuItem.Text = "Tuyển dụng nhân sự"
        ' 
        ' QuảnLýVéĐãĐặtToolStripMenuItem
        ' 
        QuảnLýVéĐãĐặtToolStripMenuItem.Name = "QuảnLýVéĐãĐặtToolStripMenuItem"
        QuảnLýVéĐãĐặtToolStripMenuItem.Size = New Size(144, 24)
        QuảnLýVéĐãĐặtToolStripMenuItem.Text = "Quản lý vé đã đặt"
        ' 
        ' cboTrangThai
        ' 
        cboTrangThai.BackColor = Color.Transparent
        cboTrangThai.BorderRadius = 10
        cboTrangThai.CustomizableEdges = CustomizableEdges7
        cboTrangThai.DrawMode = DrawMode.OwnerDrawFixed
        cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList
        cboTrangThai.FocusedColor = Color.Empty
        cboTrangThai.Font = New Font("Segoe UI", 10F)
        cboTrangThai.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cboTrangThai.ItemHeight = 30
        cboTrangThai.Items.AddRange(New Object() {"Tất cả", "Đã đặt", "Đã hủy"})
        cboTrangThai.Location = New Point(393, 94)
        cboTrangThai.Name = "cboTrangThai"
        cboTrangThai.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cboTrangThai.Size = New Size(353, 36)
        cboTrangThai.TabIndex = 14
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(27, 10)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(64, 19)
        lblSearch.TabIndex = 17
        lblSearch.Text = "Tìm kiếm"
        ' 
        ' lblTrangThai
        ' 
        lblTrangThai.AutoSize = True
        lblTrangThai.Location = New Point(250, 10)
        lblTrangThai.Name = "lblTrangThai"
        lblTrangThai.Size = New Size(70, 19)
        lblTrangThai.TabIndex = 18
        lblTrangThai.Text = "Trạng thái"
        ' 
        ' lblFromDate
        ' 
        lblFromDate.AutoSize = True
        lblFromDate.Location = New Point(420, 10)
        lblFromDate.Name = "lblFromDate"
        lblFromDate.Size = New Size(58, 19)
        lblFromDate.TabIndex = 19
        lblFromDate.Text = "Từ ngày"
        ' 
        ' lblToDate
        ' 
        lblToDate.AutoSize = True
        lblToDate.Location = New Point(590, 10)
        lblToDate.Name = "lblToDate"
        lblToDate.Size = New Size(68, 19)
        lblToDate.TabIndex = 20
        lblToDate.Text = "Đến ngày"
        ' 
        ' LichSu
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1797, 709)
        Controls.Add(MenuStrip1)
        Controls.Add(pnlVeHuy)
        Controls.Add(pnlTongTuyen)
        Controls.Add(Panel1)
        Controls.Add(btnHuyVe)
        Controls.Add(btnTroVeDatVe)
        Controls.Add(btnPrint)
        Controls.Add(cboTrangThai)
        Controls.Add(lblSearch)
        Controls.Add(lblTrangThai)
        Controls.Add(lblFromDate)
        Controls.Add(lblToDate)
        Font = New Font("Segoe UI", 8.25F)
        Name = "LichSu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lịch sử đặt vé"
        CType(dgvTickets, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        pnlVeHuy.ResumeLayout(False)
        pnlVeHuy.PerformLayout()
        pnlTongTuyen.ResumeLayout(False)
        pnlTongTuyen.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvTickets As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnHuyVe As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTroVeDatVe As Guna.UI2.WinForms.Guna2GradientButton
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
End Class
