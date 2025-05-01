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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrangChủToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TinTứcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HỗTrợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtDiemDi = New System.Windows.Forms.TextBox()
        Me.txtDiemDen = New System.Windows.Forms.TextBox()
        Me.btnDiemDi = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDiemDen = New System.Windows.Forms.Button()
        Me.dgvTuyenXe = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvTuyenXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightCyan
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrangChủToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.TinTứcToolStripMenuItem, Me.HỗTrợToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(997, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrangChủToolStripMenuItem
        '
        Me.TrangChủToolStripMenuItem.Name = "TrangChủToolStripMenuItem"
        Me.TrangChủToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.TrangChủToolStripMenuItem.Text = "Trang chủ"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới thiệu"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'TinTứcToolStripMenuItem
        '
        Me.TinTứcToolStripMenuItem.Name = "TinTứcToolStripMenuItem"
        Me.TinTứcToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.TinTứcToolStripMenuItem.Text = "Tin tức"
        '
        'HỗTrợToolStripMenuItem
        '
        Me.HỗTrợToolStripMenuItem.Name = "HỗTrợToolStripMenuItem"
        Me.HỗTrợToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.HỗTrợToolStripMenuItem.Text = "Hỗ trợ"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtDiemDi
        '
        Me.txtDiemDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiemDi.Location = New System.Drawing.Point(38, 80)
        Me.txtDiemDi.Name = "txtDiemDi"
        Me.txtDiemDi.Size = New System.Drawing.Size(295, 28)
        Me.txtDiemDi.TabIndex = 2
        '
        'txtDiemDen
        '
        Me.txtDiemDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDiemDen.Location = New System.Drawing.Point(593, 80)
        Me.txtDiemDen.Name = "txtDiemDen"
        Me.txtDiemDen.Size = New System.Drawing.Size(295, 28)
        Me.txtDiemDen.TabIndex = 2
        '
        'btnDiemDi
        '
        Me.btnDiemDi.ImageIndex = 0
        Me.btnDiemDi.ImageList = Me.ImageList1
        Me.btnDiemDi.Location = New System.Drawing.Point(350, 76)
        Me.btnDiemDi.Name = "btnDiemDi"
        Me.btnDiemDi.Size = New System.Drawing.Size(33, 32)
        Me.btnDiemDi.TabIndex = 3
        Me.btnDiemDi.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Search-button.png")
        '
        'btnDiemDen
        '
        Me.btnDiemDen.ImageIndex = 0
        Me.btnDiemDen.ImageList = Me.ImageList1
        Me.btnDiemDen.Location = New System.Drawing.Point(910, 76)
        Me.btnDiemDen.Name = "btnDiemDen"
        Me.btnDiemDen.Size = New System.Drawing.Size(33, 32)
        Me.btnDiemDen.TabIndex = 3
        Me.btnDiemDen.UseVisualStyleBackColor = True
        '
        'dgvTuyenXe
        '
        Me.dgvTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTuyenXe.Location = New System.Drawing.Point(38, 163)
        Me.dgvTuyenXe.Name = "dgvTuyenXe"
        Me.dgvTuyenXe.RowHeadersWidth = 51
        Me.dgvTuyenXe.RowTemplate.Height = 24
        Me.dgvTuyenXe.Size = New System.Drawing.Size(904, 336)
        Me.dgvTuyenXe.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 542)
        Me.Controls.Add(Me.dgvTuyenXe)
        Me.Controls.Add(Me.btnDiemDen)
        Me.Controls.Add(Me.btnDiemDi)
        Me.Controls.Add(Me.txtDiemDen)
        Me.Controls.Add(Me.txtDiemDi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Tuyến đường"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvTuyenXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TrangChủToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TinTứcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HỗTrợToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtDiemDi As TextBox
    Friend WithEvents txtDiemDen As TextBox
    Friend WithEvents btnDiemDi As Button
    Friend WithEvents btnDiemDen As Button
    Friend WithEvents dgvTuyenXe As DataGridView
    Friend WithEvents ImageList1 As ImageList
End Class
