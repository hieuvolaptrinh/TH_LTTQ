<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTrangChu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrangChu))
        MenuStrip1 = New MenuStrip()
        HỗTrợToolStripMenuItem = New ToolStripMenuItem()
        LiênHệToolStripMenuItem = New ToolStripMenuItem()
        HướngDẫnSửDụngToolStripMenuItem = New ToolStripMenuItem()
        ChínhSáchToolStripMenuItem = New ToolStripMenuItem()
        BáoCáoSựCốToolStripMenuItem = New ToolStripMenuItem()
        TinTứcToolStripMenuItem = New ToolStripMenuItem()
        QuảnLýXeBuýtToolStripMenuItem = New ToolStripMenuItem()
        LịchTrìnhVàTuyếnĐườngToolStripMenuItem = New ToolStripMenuItem()
        DanhSáchXeBuýtToolStripMenuItem = New ToolStripMenuItem()
        GiớiThiệuToolStripMenuItem = New ToolStripMenuItem()
        CôngTyAToolStripMenuItem = New ToolStripMenuItem()
        GiấyChứngNhậnHợpQuyToolStripMenuItem = New ToolStripMenuItem()
        TuyểnDụngNhânSựToolStripMenuItem = New ToolStripMenuItem()
        TrangChủToolStripMenuItem = New ToolStripMenuItem()
        PanelContainer = New Panel()
        Button3 = New Button()
        Label9 = New Label()
        Panel2 = New Panel()
        btnDatVe = New Button()
        GroupBox1 = New GroupBox()
        chkKhuHoi = New CheckBox()
        btnTimChuyen = New Button()
        Panel9 = New Panel()
        textDiemDen = New TextBox()
        Label3 = New Label()
        Panel6 = New Panel()
        dtpNgayVe = New DateTimePicker()
        Label5 = New Label()
        Panel5 = New Panel()
        dtpNgayDi = New DateTimePicker()
        Label4 = New Label()
        Panel4 = New Panel()
        textDiemDi = New TextBox()
        Label6 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        PanelContainer.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HỗTrợToolStripMenuItem, TinTứcToolStripMenuItem, QuảnLýXeBuýtToolStripMenuItem, GiớiThiệuToolStripMenuItem, TrangChủToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.RightToLeft = RightToLeft.Yes
        MenuStrip1.Size = New Size(1502, 28)
        MenuStrip1.TabIndex = 0
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
        ' QuảnLýXeBuýtToolStripMenuItem
        ' 
        QuảnLýXeBuýtToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LịchTrìnhVàTuyếnĐườngToolStripMenuItem, DanhSáchXeBuýtToolStripMenuItem})
        QuảnLýXeBuýtToolStripMenuItem.Image = My.Resources.Resources.project_management
        QuảnLýXeBuýtToolStripMenuItem.Name = "QuảnLýXeBuýtToolStripMenuItem"
        QuảnLýXeBuýtToolStripMenuItem.Size = New Size(152, 24)
        QuảnLýXeBuýtToolStripMenuItem.Text = "Quản lý xe buýt"
        ' 
        ' LịchTrìnhVàTuyếnĐườngToolStripMenuItem
        ' 
        LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Name = "LịchTrìnhVàTuyếnĐườngToolStripMenuItem"
        LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Size = New Size(272, 26)
        LịchTrìnhVàTuyếnĐườngToolStripMenuItem.Text = "Lịch trình và tuyến đường"
        ' 
        ' DanhSáchXeBuýtToolStripMenuItem
        ' 
        DanhSáchXeBuýtToolStripMenuItem.Name = "DanhSáchXeBuýtToolStripMenuItem"
        DanhSáchXeBuýtToolStripMenuItem.Size = New Size(272, 26)
        DanhSáchXeBuýtToolStripMenuItem.Text = "Danh sách xe buýt"
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
        ' TrangChủToolStripMenuItem
        ' 
        TrangChủToolStripMenuItem.Image = CType(resources.GetObject("TrangChủToolStripMenuItem.Image"), Image)
        TrangChủToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        TrangChủToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        TrangChủToolStripMenuItem.Name = "TrangChủToolStripMenuItem"
        TrangChủToolStripMenuItem.Size = New Size(110, 24)
        TrangChủToolStripMenuItem.Text = "Trang Chủ"
        TrangChủToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = Color.White
        PanelContainer.BackgroundImageLayout = ImageLayout.None
        PanelContainer.Controls.Add(Button3)
        PanelContainer.Controls.Add(Label9)
        PanelContainer.Controls.Add(Panel2)
        PanelContainer.Controls.Add(Button1)
        PanelContainer.Controls.Add(Label2)
        PanelContainer.Controls.Add(PictureBox2)
        PanelContainer.Controls.Add(Label1)
        PanelContainer.Controls.Add(PictureBox1)
        PanelContainer.Dock = DockStyle.Fill
        PanelContainer.Location = New Point(0, 28)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(1502, 789)
        PanelContainer.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DeepSkyBlue
        Button3.ForeColor = Color.DeepSkyBlue
        Button3.Image = My.Resources.Resources.next_button
        Button3.Location = New Point(1366, 431)
        Button3.Name = "Button3"
        Button3.Size = New Size(124, 43)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.LightSkyBlue
        Label9.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkRed
        Label9.Location = New Point(658, 51)
        Label9.Name = "Label9"
        Label9.Size = New Size(241, 69)
        Label9.TabIndex = 2
        Label9.Text = "Trang chủ"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnDatVe)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 494)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1502, 295)
        Panel2.TabIndex = 5
        ' 
        ' btnDatVe
        ' 
        btnDatVe.BackColor = Color.Firebrick
        btnDatVe.Dock = DockStyle.Bottom
        btnDatVe.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDatVe.ForeColor = Color.Transparent
        btnDatVe.Location = New Point(0, 242)
        btnDatVe.Name = "btnDatVe"
        btnDatVe.Size = New Size(1498, 49)
        btnDatVe.TabIndex = 7
        btnDatVe.Text = "Đặt vé ngay"
        btnDatVe.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGray
        GroupBox1.Controls.Add(chkKhuHoi)
        GroupBox1.Controls.Add(btnTimChuyen)
        GroupBox1.Controls.Add(Panel9)
        GroupBox1.Controls.Add(Panel6)
        GroupBox1.Controls.Add(Panel5)
        GroupBox1.Controls.Add(Panel4)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1498, 291)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Chọn địa điểm"
        ' 
        ' chkKhuHoi
        ' 
        chkKhuHoi.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkKhuHoi.Location = New Point(68, 179)
        chkKhuHoi.Name = "chkKhuHoi"
        chkKhuHoi.Size = New Size(112, 44)
        chkKhuHoi.TabIndex = 9
        chkKhuHoi.Text = "Khứ hồi"
        chkKhuHoi.UseVisualStyleBackColor = True
        ' 
        ' btnTimChuyen
        ' 
        btnTimChuyen.BackColor = Color.RoyalBlue
        btnTimChuyen.FlatStyle = FlatStyle.Flat
        btnTimChuyen.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnTimChuyen.Image = My.Resources.Resources.magnifying_glass
        btnTimChuyen.ImageAlign = ContentAlignment.MiddleLeft
        btnTimChuyen.Location = New Point(1190, 179)
        btnTimChuyen.Name = "btnTimChuyen"
        btnTimChuyen.Size = New Size(138, 44)
        btnTimChuyen.TabIndex = 8
        btnTimChuyen.Text = "Tìm chuyến xe"
        btnTimChuyen.TextAlign = ContentAlignment.MiddleRight
        btnTimChuyen.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.Fixed3D
        Panel9.Controls.Add(textDiemDen)
        Panel9.Controls.Add(Label3)
        Panel9.Location = New Point(410, 47)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(232, 113)
        Panel9.TabIndex = 7
        ' 
        ' textDiemDen
        ' 
        textDiemDen.Location = New Point(1, 54)
        textDiemDen.Name = "textDiemDen"
        textDiemDen.Size = New Size(206, 34)
        textDiemDen.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label3.Location = New Point(39, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 28)
        Label3.TabIndex = 2
        Label3.Text = "Điểm đến"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(dtpNgayVe)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(1085, 47)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(232, 113)
        Panel6.TabIndex = 3
        ' 
        ' dtpNgayVe
        ' 
        dtpNgayVe.Checked = False
        dtpNgayVe.CustomFormat = " "
        dtpNgayVe.Enabled = False
        dtpNgayVe.Font = New Font("Microsoft Sans Serif", 7.8F)
        dtpNgayVe.Format = DateTimePickerFormat.Custom
        dtpNgayVe.Location = New Point(0, 54)
        dtpNgayVe.Name = "dtpNgayVe"
        dtpNgayVe.Size = New Size(214, 22)
        dtpNgayVe.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label5.Location = New Point(41, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 28)
        Label5.TabIndex = 2
        Label5.Text = "Ngày về"
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(dtpNgayDi)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(754, 47)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(232, 113)
        Panel5.TabIndex = 4
        ' 
        ' dtpNgayDi
        ' 
        dtpNgayDi.Checked = False
        dtpNgayDi.CustomFormat = " "
        dtpNgayDi.Font = New Font("Microsoft Sans Serif", 7.8F)
        dtpNgayDi.Format = DateTimePickerFormat.Custom
        dtpNgayDi.Location = New Point(3, 54)
        dtpNgayDi.Name = "dtpNgayDi"
        dtpNgayDi.Size = New Size(206, 22)
        dtpNgayDi.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label4.Location = New Point(27, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 28)
        Label4.TabIndex = 2
        Label4.Text = "Ngày đi "
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(textDiemDi)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(68, 47)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(232, 113)
        Panel4.TabIndex = 6
        ' 
        ' textDiemDi
        ' 
        textDiemDi.Location = New Point(3, 54)
        textDiemDi.Name = "textDiemDi"
        textDiemDi.Size = New Size(206, 34)
        textDiemDi.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        Label6.Location = New Point(27, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 28)
        Label6.TabIndex = 2
        Label6.Text = "Điểm đi"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(274, 404)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 29)
        Button1.TabIndex = 4
        Button1.Text = "Watch Video"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.LightSkyBlue
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(274, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(485, 34)
        Label2.TabIndex = 3
        Label2.Text = "Đi để khám phá bản thân , đi để tìm thấy câu trả lời hạnh phúc thật sự"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(162, 158)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightSkyBlue
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(274, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 57)
        Label1.TabIndex = 2
        Label1.Text = "Welcome to My Bus"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Enabled = False
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1502, 494)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FrmTrangChu
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1502, 817)
        Controls.Add(PanelContainer)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FrmTrangChu"
        Text = "frmTrangChu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PanelContainer.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TrangChủToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CôngTyAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiấyChứngNhậnHợpQuyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuyểnDụngNhânSựToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýXeBuýtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LịchTrìnhVàTuyếnĐườngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchXeBuýtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TinTứcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HỗTrợToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HướngDẫnSửDụngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChínhSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoSựCốToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Protected Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTimChuyen As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents chkKhuHoi As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpNgayVe As DateTimePicker
    Friend WithEvents dtpNgayDi As DateTimePicker
    Friend WithEvents textDiemDen As TextBox
    Friend WithEvents textDiemDi As TextBox
    Friend WithEvents btnDatVe As Button

End Class
