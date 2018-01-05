<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaNguoiDung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuaNguoiDung))
        Me.grpThongTinSach = New DevExpress.XtraEditors.GroupControl()
        Me.cmbLoaiNguoiDung = New System.Windows.Forms.ComboBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMatKhau = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblTenSach = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTenNguoiDung = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenDangNhap = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblMaSach = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaNguoiDung = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMain = New System.Windows.Forms.Label()
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThongTinSach.SuspendLayout()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTenNguoiDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaNguoiDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpThongTinSach
        '
        Me.grpThongTinSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThongTinSach.CaptionImageOptions.Image = CType(resources.GetObject("grpThongTinSach.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpThongTinSach.Controls.Add(Me.cmbLoaiNguoiDung)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl3)
        Me.grpThongTinSach.Controls.Add(Me.txtMatKhau)
        Me.grpThongTinSach.Controls.Add(Me.lblTenSach)
        Me.grpThongTinSach.Controls.Add(Me.txtHoTenNguoiDung)
        Me.grpThongTinSach.Controls.Add(Me.txtTenDangNhap)
        Me.grpThongTinSach.Controls.Add(Me.lblMaSach)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl2)
        Me.grpThongTinSach.Controls.Add(Me.txtMaNguoiDung)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl1)
        Me.grpThongTinSach.Location = New System.Drawing.Point(190, 127)
        Me.grpThongTinSach.Margin = New System.Windows.Forms.Padding(4)
        Me.grpThongTinSach.Name = "grpThongTinSach"
        Me.grpThongTinSach.Size = New System.Drawing.Size(694, 238)
        Me.grpThongTinSach.TabIndex = 55
        Me.grpThongTinSach.Text = "Thông tin chi tiết người dùng"
        '
        'cmbLoaiNguoiDung
        '
        Me.cmbLoaiNguoiDung.FormattingEnabled = True
        Me.cmbLoaiNguoiDung.Location = New System.Drawing.Point(285, 180)
        Me.cmbLoaiNguoiDung.Name = "cmbLoaiNguoiDung"
        Me.cmbLoaiNguoiDung.Size = New System.Drawing.Size(273, 24)
        Me.cmbLoaiNguoiDung.TabIndex = 54
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(103, 180)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(146, 21)
        Me.LabelControl3.TabIndex = 53
        Me.LabelControl3.Text = "Loại người dùng:"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMatKhau.Location = New System.Drawing.Point(285, 145)
        Me.txtMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMatKhau.Size = New System.Drawing.Size(273, 22)
        Me.txtMatKhau.TabIndex = 3
        '
        'lblTenSach
        '
        Me.lblTenSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTenSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSach.Appearance.Options.UseFont = True
        Me.lblTenSach.Location = New System.Drawing.Point(103, 85)
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
        Me.txtHoTenNguoiDung.Location = New System.Drawing.Point(285, 81)
        Me.txtHoTenNguoiDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTenNguoiDung.Name = "txtHoTenNguoiDung"
        Me.txtHoTenNguoiDung.Size = New System.Drawing.Size(273, 22)
        Me.txtHoTenNguoiDung.TabIndex = 1
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenDangNhap.Location = New System.Drawing.Point(285, 113)
        Me.txtTenDangNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTenDangNhap.Size = New System.Drawing.Size(273, 22)
        Me.txtTenDangNhap.TabIndex = 2
        '
        'lblMaSach
        '
        Me.lblMaSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSach.Appearance.Options.UseFont = True
        Me.lblMaSach.Location = New System.Drawing.Point(103, 53)
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
        Me.LabelControl2.Location = New System.Drawing.Point(103, 145)
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
        Me.txtMaNguoiDung.Location = New System.Drawing.Point(285, 49)
        Me.txtMaNguoiDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNguoiDung.Name = "txtMaNguoiDung"
        Me.txtMaNguoiDung.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMaNguoiDung.Properties.Appearance.Options.UseFont = True
        Me.txtMaNguoiDung.Properties.ReadOnly = True
        Me.txtMaNguoiDung.Size = New System.Drawing.Size(273, 24)
        Me.txtMaNguoiDung.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(103, 117)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(133, 21)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Tên đăng nhập:"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(919, 425)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(113, 31)
        Me.btnThoat.TabIndex = 53
        Me.btnThoat.Text = "Thoát"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.ImageOptions.Image = CType(resources.GetObject("btnLuu.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(798, 425)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(113, 31)
        Me.btnLuu.TabIndex = 52
        Me.btnLuu.Text = "Lưu"
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(207, 40)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(648, 38)
        Me.lblMain.TabIndex = 54
        Me.lblMain.Text = "CHỈNH SỬA THÔNG TIN NGƯỜI DÙNG"
        '
        'frmSuaNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 489)
        Me.Controls.Add(Me.grpThongTinSach)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "frmSuaNguoiDung"
        Me.Text = "SuaNguoiDung"
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThongTinSach.ResumeLayout(False)
        Me.grpThongTinSach.PerformLayout()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTenNguoiDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaNguoiDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpThongTinSach As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbLoaiNguoiDung As ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMatKhau As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblTenSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHoTenNguoiDung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenDangNhap As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblMaSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaNguoiDung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMain As Label
End Class
