<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKiVip
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBack = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 65)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 10
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(62, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Tên tài khoản"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(400, 36)
        Me.txtUsername.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.BorderRadius = 10
        Me.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullName.DefaultText = ""
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtFullName.Location = New System.Drawing.Point(62, 138)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PlaceholderText = "Họ và tên"
        Me.txtFullName.SelectedText = ""
        Me.txtFullName.Size = New System.Drawing.Size(400, 36)
        Me.txtFullName.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.BorderRadius = 10
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPhone.Location = New System.Drawing.Point(62, 193)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PlaceholderText = "Số điện thoại"
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.Size = New System.Drawing.Size(400, 36)
        Me.txtPhone.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 10
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(62, 254)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Mật khẩu"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(400, 36)
        Me.txtPassword.TabIndex = 4
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderRadius = 10
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(62, 314)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.PlaceholderText = "Xác nhận mật khẩu"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(400, 36)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'btnRegister
        '
        Me.btnRegister.BorderRadius = 10
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegister.FillColor2 = System.Drawing.Color.Fuchsia
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(62, 372)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(400, 36)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Đăng Ký"
        '
        'btnBack
        '
        Me.btnBack.BorderRadius = 10
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnBack.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(62, 435)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(400, 36)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Quay Lại"
        '
        'DangKiVip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(524, 509)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DangKiVip"
        Me.Text = "DangKiVip"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2GradientButton
End Class
