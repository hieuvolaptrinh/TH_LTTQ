<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHoVaTen = New System.Windows.Forms.TextBox()
        Me.txtSDT_Email = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoNu = New System.Windows.Forms.RadioButton()
        Me.rdoNam = New System.Windows.Forms.RadioButton()
        Me.txtNhapLaiMatKhau = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.lnkDaCoTaiKhoan = New System.Windows.Forms.LinkLabel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTenDangNhap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(615, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ĐĂNG KÍ"
        '
        'txtHoVaTen
        '
        Me.txtHoVaTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtHoVaTen.Location = New System.Drawing.Point(413, 212)
        Me.txtHoVaTen.Name = "txtHoVaTen"
        Me.txtHoVaTen.Size = New System.Drawing.Size(243, 27)
        Me.txtHoVaTen.TabIndex = 2
        '
        'txtSDT_Email
        '
        Me.txtSDT_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtSDT_Email.Location = New System.Drawing.Point(413, 295)
        Me.txtSDT_Email.Name = "txtSDT_Email"
        Me.txtSDT_Email.Size = New System.Drawing.Size(243, 27)
        Me.txtSDT_Email.TabIndex = 2
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(413, 380)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(243, 27)
        Me.txtMatKhau.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Họ và tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Số điện thoại/ Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mật khẩu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoNu)
        Me.GroupBox1.Controls.Add(Me.rdoNam)
        Me.GroupBox1.Location = New System.Drawing.Point(742, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 129)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Giới tính"
        '
        'rdoNu
        '
        Me.rdoNu.AutoSize = True
        Me.rdoNu.Location = New System.Drawing.Point(6, 84)
        Me.rdoNu.Name = "rdoNu"
        Me.rdoNu.Size = New System.Drawing.Size(45, 20)
        Me.rdoNu.TabIndex = 0
        Me.rdoNu.TabStop = True
        Me.rdoNu.Text = "Nữ"
        Me.rdoNu.UseVisualStyleBackColor = True
        '
        'rdoNam
        '
        Me.rdoNam.AutoSize = True
        Me.rdoNam.Location = New System.Drawing.Point(6, 37)
        Me.rdoNam.Name = "rdoNam"
        Me.rdoNam.Size = New System.Drawing.Size(57, 20)
        Me.rdoNam.TabIndex = 0
        Me.rdoNam.TabStop = True
        Me.rdoNam.Text = "Nam"
        Me.rdoNam.UseVisualStyleBackColor = True
        '
        'txtNhapLaiMatKhau
        '
        Me.txtNhapLaiMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtNhapLaiMatKhau.Location = New System.Drawing.Point(742, 295)
        Me.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau"
        Me.txtNhapLaiMatKhau.Size = New System.Drawing.Size(240, 27)
        Me.txtNhapLaiMatKhau.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(742, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nhập lại mật khẩu"
        '
        'btnDangKy
        '
        Me.btnDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnDangKy.Location = New System.Drawing.Point(742, 365)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(111, 42)
        Me.btnDangKy.TabIndex = 6
        Me.btnDangKy.Text = "Đăng kí"
        Me.btnDangKy.UseVisualStyleBackColor = True
        '
        'lnkDaCoTaiKhoan
        '
        Me.lnkDaCoTaiKhoan.AutoSize = True
        Me.lnkDaCoTaiKhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lnkDaCoTaiKhoan.Location = New System.Drawing.Point(881, 387)
        Me.lnkDaCoTaiKhoan.Name = "lnkDaCoTaiKhoan"
        Me.lnkDaCoTaiKhoan.Size = New System.Drawing.Size(134, 20)
        Me.lnkDaCoTaiKhoan.TabIndex = 7
        Me.lnkDaCoTaiKhoan.TabStop = True
        Me.lnkDaCoTaiKhoan.Text = "Đã có tài khoản?"
        '
        'btnBack
        '
        Me.btnBack.ImageIndex = 0
        Me.btnBack.ImageList = Me.ImageList1
        Me.btnBack.Location = New System.Drawing.Point(-1, -1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 43)
        Me.btnBack.TabIndex = 8
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "anhmuiten.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLXB_Signup.My.Resources.Resources.Signup
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 554)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenDangNhap.Location = New System.Drawing.Point(413, 140)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(243, 27)
        Me.txtTenDangNhap.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tên đăng nhập"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 553)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lnkDaCoTaiKhoan)
        Me.Controls.Add(Me.btnDangKy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNhapLaiMatKhau)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtSDT_Email)
        Me.Controls.Add(Me.txtTenDangNhap)
        Me.Controls.Add(Me.txtHoVaTen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHoVaTen As TextBox
    Friend WithEvents txtSDT_Email As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoNu As RadioButton
    Friend WithEvents rdoNam As RadioButton
    Friend WithEvents txtNhapLaiMatKhau As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDangKy As Button
    Friend WithEvents lnkDaCoTaiKhoan As LinkLabel
    Friend WithEvents btnBack As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtTenDangNhap As TextBox
    Friend WithEvents Label5 As Label
End Class
