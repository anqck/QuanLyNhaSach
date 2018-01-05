<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemNguoiDung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemNguoiDung))
        Me.grpThongTinNguoiDung = New DevExpress.XtraEditors.GroupControl()
        Me.CmbLoaiNguoiDung = New System.Windows.Forms.ComboBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMatKhau = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblTenSach = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTenNguoiDung = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenDangNhap = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblMaSach = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaNguoiDung = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnTaoMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grpThongTinNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThongTinNguoiDung.SuspendLayout()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTenNguoiDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaNguoiDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpThongTinNguoiDung
        '
        Me.grpThongTinNguoiDung.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThongTinNguoiDung.CaptionImageOptions.Image = CType(resources.GetObject("grpThongTinNguoiDung.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpThongTinNguoiDung.Controls.Add(Me.CmbLoaiNguoiDung)
        Me.grpThongTinNguoiDung.Controls.Add(Me.LabelControl3)
        Me.grpThongTinNguoiDung.Controls.Add(Me.txtMatKhau)
        Me.grpThongTinNguoiDung.Controls.Add(Me.lblTenSach)
        Me.grpThongTinNguoiDung.Controls.Add(Me.txtHoTenNguoiDung)
        Me.grpThongTinNguoiDung.Controls.Add(Me.txtTenDangNhap)
        Me.grpThongTinNguoiDung.Controls.Add(Me.lblMaSach)
        Me.grpThongTinNguoiDung.Controls.Add(Me.LabelControl2)
        Me.grpThongTinNguoiDung.Controls.Add(Me.txtMaNguoiDung)
        Me.grpThongTinNguoiDung.Controls.Add(Me.LabelControl1)
        Me.grpThongTinNguoiDung.Location = New System.Drawing.Point(68, 48)
        Me.grpThongTinNguoiDung.Margin = New System.Windows.Forms.Padding(4)
        Me.grpThongTinNguoiDung.Name = "grpThongTinNguoiDung"
        Me.grpThongTinNguoiDung.Size = New System.Drawing.Size(785, 238)
        Me.grpThongTinNguoiDung.TabIndex = 55
        Me.grpThongTinNguoiDung.Text = "Thông tin chi tiết người dùng:"
        '
        'CmbLoaiNguoiDung
        '
        Me.CmbLoaiNguoiDung.FormattingEnabled = True
        Me.CmbLoaiNguoiDung.Location = New System.Drawing.Point(288, 192)
        Me.CmbLoaiNguoiDung.Name = "CmbLoaiNguoiDung"
        Me.CmbLoaiNguoiDung.Size = New System.Drawing.Size(364, 24)
        Me.CmbLoaiNguoiDung.TabIndex = 58
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(103, 192)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(146, 21)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Loại người dùng:"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMatKhau.Location = New System.Drawing.Point(288, 161)
        Me.txtMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMatKhau.Size = New System.Drawing.Size(364, 22)
        Me.txtMatKhau.TabIndex = 3
        '
        'lblTenSach
        '
        Me.lblTenSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTenSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSach.Appearance.Options.UseFont = True
        Me.lblTenSach.Location = New System.Drawing.Point(103, 101)
        Me.lblTenSach.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(167, 21)
        Me.lblTenSach.TabIndex = 40
        Me.lblTenSach.Text = "Họ tên người dùng:"
        '
        'txtHoTenNguoiDung
        '
        Me.txtHoTenNguoiDung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoTenNguoiDung.Location = New System.Drawing.Point(288, 97)
        Me.txtHoTenNguoiDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTenNguoiDung.Name = "txtHoTenNguoiDung"
        Me.txtHoTenNguoiDung.Size = New System.Drawing.Size(364, 22)
        Me.txtHoTenNguoiDung.TabIndex = 1
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenDangNhap.Location = New System.Drawing.Point(288, 129)
        Me.txtTenDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTenDangNhap.Size = New System.Drawing.Size(364, 22)
        Me.txtTenDangNhap.TabIndex = 2
        '
        'lblMaSach
        '
        Me.lblMaSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSach.Appearance.Options.UseFont = True
        Me.lblMaSach.Location = New System.Drawing.Point(103, 65)
        Me.lblMaSach.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(135, 21)
        Me.lblMaSach.TabIndex = 42
        Me.lblMaSach.Text = "Mã người dùng:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(103, 165)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 21)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Mật khẩu:"
        '
        'txtMaNguoiDung
        '
        Me.txtMaNguoiDung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaNguoiDung.Location = New System.Drawing.Point(288, 65)
        Me.txtMaNguoiDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNguoiDung.Name = "txtMaNguoiDung"
        Me.txtMaNguoiDung.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMaNguoiDung.Properties.Appearance.Options.UseFont = True
        Me.txtMaNguoiDung.Properties.ReadOnly = True
        Me.txtMaNguoiDung.Size = New System.Drawing.Size(364, 24)
        Me.txtMaNguoiDung.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(103, 132)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(133, 21)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Tên đăng nhập:"
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTaoMoi.ImageOptions.Image = CType(resources.GetObject("btnTaoMoi.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTaoMoi.Location = New System.Drawing.Point(619, 455)
        Me.btnTaoMoi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(113, 31)
        Me.btnTaoMoi.TabIndex = 52
        Me.btnTaoMoi.Text = "Thêm"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(757, 455)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(113, 31)
        Me.btnThoat.TabIndex = 54
        Me.btnThoat.Text = "Thoát"
        '
        'frmThemNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 509)
        Me.Controls.Add(Me.grpThongTinNguoiDung)
        Me.Controls.Add(Me.btnTaoMoi)
        Me.Controls.Add(Me.btnThoat)
        Me.Name = "frmThemNguoiDung"
        Me.Text = "ThemNguoiDung"
        CType(Me.grpThongTinNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThongTinNguoiDung.ResumeLayout(False)
        Me.grpThongTinNguoiDung.PerformLayout()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTenNguoiDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaNguoiDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpThongTinNguoiDung As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMatKhau As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblTenSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHoTenNguoiDung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenDangNhap As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblMaSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaNguoiDung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTaoMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbLoaiNguoiDung As ComboBox
End Class
