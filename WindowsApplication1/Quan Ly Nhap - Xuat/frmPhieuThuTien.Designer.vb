<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhieuThuTienGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuThuTienGUI))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.grpChiTietPhieuThu = New DevExpress.XtraEditors.GroupControl()
        Me.txtSoTienThu = New DevExpress.XtraEditors.TextEdit()
        Me.lblSoTienThu = New DevExpress.XtraEditors.LabelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTaoMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.grpQuyDinh = New DevExpress.XtraEditors.GroupControl()
        Me.btnThayDoiQuyDinh = New DevExpress.XtraEditors.SimpleButton()
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo = New DevExpress.XtraEditors.CheckEdit()
        Me.grpThongTinKhachHang = New DevExpress.XtraEditors.GroupControl()
        Me.txtTienNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnChonKhachHang = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDiaChi = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDienThoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTenKhachHang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblMaKhachHang = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaKhachHang = New DevExpress.XtraEditors.TextEdit()
        Me.dateNgayThu = New DevExpress.XtraEditors.DateEdit()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaPhieuThuTien = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpChiTietPhieuThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChiTietPhieuThu.SuspendLayout()
        CType(Me.txtSoTienThu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpQuyDinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuyDinh.SuspendLayout()
        CType(Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpThongTinKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThongTinKhachHang.SuspendLayout()
        CType(Me.txtTienNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNgayThu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNgayThu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaPhieuThuTien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnThoat)
        Me.PanelControl1.Controls.Add(Me.btnIn)
        Me.PanelControl1.Controls.Add(Me.grpChiTietPhieuThu)
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnTaoMoi)
        Me.PanelControl1.Controls.Add(Me.grpQuyDinh)
        Me.PanelControl1.Controls.Add(Me.grpThongTinKhachHang)
        Me.PanelControl1.Controls.Add(Me.dateNgayThu)
        Me.PanelControl1.Controls.Add(Me.lblMain)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txtMaPhieuThuTien)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1185, 690)
        Me.PanelControl1.TabIndex = 0
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(1056, 656)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(113, 28)
        Me.btnThoat.TabIndex = 92
        Me.btnThoat.Text = "Thoát"
        '
        'btnIn
        '
        Me.btnIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn.ImageOptions.Image = CType(resources.GetObject("btnIn.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIn.Location = New System.Drawing.Point(932, 656)
        Me.btnIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(113, 28)
        Me.btnIn.TabIndex = 89
        Me.btnIn.Text = "Xuất"
        '
        'grpChiTietPhieuThu
        '
        Me.grpChiTietPhieuThu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChiTietPhieuThu.CaptionImageOptions.Image = CType(resources.GetObject("grpChiTietPhieuThu.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpChiTietPhieuThu.Controls.Add(Me.txtSoTienThu)
        Me.grpChiTietPhieuThu.Controls.Add(Me.lblSoTienThu)
        Me.grpChiTietPhieuThu.Location = New System.Drawing.Point(16, 425)
        Me.grpChiTietPhieuThu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpChiTietPhieuThu.Name = "grpChiTietPhieuThu"
        Me.grpChiTietPhieuThu.Size = New System.Drawing.Size(1153, 81)
        Me.grpChiTietPhieuThu.TabIndex = 88
        Me.grpChiTietPhieuThu.Text = "Chi tiết phiếu thu tiền:"
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSoTienThu.EnterMoveNextControl = True
        Me.txtSoTienThu.Location = New System.Drawing.Point(401, 43)
        Me.txtSoTienThu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoTienThu.Properties.Appearance.Options.UseFont = True
        Me.txtSoTienThu.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoTienThu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoTienThu.Properties.Mask.EditMask = "n0"
        Me.txtSoTienThu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoTienThu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSoTienThu.Size = New System.Drawing.Size(383, 24)
        Me.txtSoTienThu.TabIndex = 88
        '
        'lblSoTienThu
        '
        Me.lblSoTienThu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSoTienThu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSoTienThu.Appearance.Options.UseFont = True
        Me.lblSoTienThu.Location = New System.Drawing.Point(297, 47)
        Me.lblSoTienThu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSoTienThu.Name = "lblSoTienThu"
        Me.lblSoTienThu.Size = New System.Drawing.Size(420, 18)
        Me.lblSoTienThu.TabIndex = 88
        Me.lblSoTienThu.Text = "Số tiền thu:                                                                     " &
    "     Đồng"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.ImageOptions.Image = CType(resources.GetObject("btnLuu.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(811, 656)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(113, 28)
        Me.btnLuu.TabIndex = 85
        Me.btnLuu.Text = "Lưu"
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTaoMoi.ImageOptions.Image = CType(resources.GetObject("btnTaoMoi.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTaoMoi.Location = New System.Drawing.Point(689, 656)
        Me.btnTaoMoi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(113, 28)
        Me.btnTaoMoi.TabIndex = 84
        Me.btnTaoMoi.Text = "Tạo mới"
        '
        'grpQuyDinh
        '
        Me.grpQuyDinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpQuyDinh.CaptionImageOptions.Image = CType(resources.GetObject("grpQuyDinh.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpQuyDinh.Controls.Add(Me.btnThayDoiQuyDinh)
        Me.grpQuyDinh.Controls.Add(Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo)
        Me.grpQuyDinh.Location = New System.Drawing.Point(16, 336)
        Me.grpQuyDinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpQuyDinh.Name = "grpQuyDinh"
        Me.grpQuyDinh.Size = New System.Drawing.Size(1153, 81)
        Me.grpQuyDinh.TabIndex = 83
        Me.grpQuyDinh.Text = "Quy Định:"
        '
        'btnThayDoiQuyDinh
        '
        Me.btnThayDoiQuyDinh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnThayDoiQuyDinh.ImageOptions.Image = CType(resources.GetObject("btnThayDoiQuyDinh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThayDoiQuyDinh.Location = New System.Drawing.Point(816, 37)
        Me.btnThayDoiQuyDinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh"
        Me.btnThayDoiQuyDinh.Size = New System.Drawing.Size(159, 28)
        Me.btnThayDoiQuyDinh.TabIndex = 87
        Me.btnThayDoiQuyDinh.Text = "Thay đổi quy định"
        '
        'chkApDungQuyDinhSoTienThuKhongVuotTienNo
        '
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Location = New System.Drawing.Point(257, 41)
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Name = "chkApDungQuyDinhSoTienThuKhongVuotTienNo"
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Bold)
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Properties.Appearance.Options.UseFont = True
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Properties.Caption = "Áp dụng quy định số tiền thu không vượt quá số tiền nợ"
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Properties.ReadOnly = True
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Size = New System.Drawing.Size(660, 23)
        Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.TabIndex = 0
        '
        'grpThongTinKhachHang
        '
        Me.grpThongTinKhachHang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThongTinKhachHang.CaptionImageOptions.Image = CType(resources.GetObject("grpThongTinKhachHang.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpThongTinKhachHang.Controls.Add(Me.txtTienNo)
        Me.grpThongTinKhachHang.Controls.Add(Me.LabelControl4)
        Me.grpThongTinKhachHang.Controls.Add(Me.btnChonKhachHang)
        Me.grpThongTinKhachHang.Controls.Add(Me.txtDiaChi)
        Me.grpThongTinKhachHang.Controls.Add(Me.LabelControl3)
        Me.grpThongTinKhachHang.Controls.Add(Me.txtDienThoai)
        Me.grpThongTinKhachHang.Controls.Add(Me.LabelControl2)
        Me.grpThongTinKhachHang.Controls.Add(Me.txtHoTenKhachHang)
        Me.grpThongTinKhachHang.Controls.Add(Me.LabelControl1)
        Me.grpThongTinKhachHang.Controls.Add(Me.lblMaKhachHang)
        Me.grpThongTinKhachHang.Controls.Add(Me.txtMaKhachHang)
        Me.grpThongTinKhachHang.Location = New System.Drawing.Point(16, 126)
        Me.grpThongTinKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpThongTinKhachHang.Name = "grpThongTinKhachHang"
        Me.grpThongTinKhachHang.Size = New System.Drawing.Size(1153, 203)
        Me.grpThongTinKhachHang.TabIndex = 79
        Me.grpThongTinKhachHang.Text = "Thông tin khách hàng:"
        '
        'txtTienNo
        '
        Me.txtTienNo.EnterMoveNextControl = True
        Me.txtTienNo.Location = New System.Drawing.Point(720, 159)
        Me.txtTienNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.Properties.Appearance.BackColor = System.Drawing.Color.MistyRose
        Me.txtTienNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTienNo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTienNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTienNo.Properties.Appearance.Options.UseFont = True
        Me.txtTienNo.Properties.Appearance.Options.UseForeColor = True
        Me.txtTienNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTienNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTienNo.Properties.Mask.EditMask = "n0"
        Me.txtTienNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTienNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTienNo.Properties.ReadOnly = True
        Me.txtTienNo.Size = New System.Drawing.Size(255, 24)
        Me.txtTienNo.TabIndex = 88
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(592, 162)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(390, 18)
        Me.LabelControl4.TabIndex = 87
        Me.LabelControl4.Text = "Số tiền nợ:                                                                    Đồ" &
    "ng"
        '
        'btnChonKhachHang
        '
        Me.btnChonKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnChonKhachHang.ImageOptions.Image = CType(resources.GetObject("btnChonKhachHang.ImageOptions.Image"), System.Drawing.Image)
        Me.btnChonKhachHang.Location = New System.Drawing.Point(409, 33)
        Me.btnChonKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnChonKhachHang.Name = "btnChonKhachHang"
        Me.btnChonKhachHang.Size = New System.Drawing.Size(159, 28)
        Me.btnChonKhachHang.TabIndex = 86
        Me.btnChonKhachHang.Text = "Chọn khách hàng"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.Location = New System.Drawing.Point(175, 101)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Properties.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(933, 48)
        Me.txtDiaChi.TabIndex = 80
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(115, 102)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 18)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "Địa chỉ:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDienThoai.EnterMoveNextControl = True
        Me.txtDienThoai.Location = New System.Drawing.Point(767, 69)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Properties.ReadOnly = True
        Me.txtDienThoai.Size = New System.Drawing.Size(341, 22)
        Me.txtDienThoai.TabIndex = 78
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(663, 71)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 18)
        Me.LabelControl2.TabIndex = 77
        Me.LabelControl2.Text = "Điện thoại:"
        '
        'txtHoTenKhachHang
        '
        Me.txtHoTenKhachHang.EnterMoveNextControl = True
        Me.txtHoTenKhachHang.Location = New System.Drawing.Point(175, 69)
        Me.txtHoTenKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoTenKhachHang.Name = "txtHoTenKhachHang"
        Me.txtHoTenKhachHang.Properties.ReadOnly = True
        Me.txtHoTenKhachHang.Size = New System.Drawing.Size(419, 22)
        Me.txtHoTenKhachHang.TabIndex = 76
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(21, 70)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(129, 18)
        Me.LabelControl1.TabIndex = 64
        Me.LabelControl1.Text = "Họ tên khách hàng:"
        '
        'lblMaKhachHang
        '
        Me.lblMaKhachHang.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblMaKhachHang.Appearance.Options.UseFont = True
        Me.lblMaKhachHang.Location = New System.Drawing.Point(52, 37)
        Me.lblMaKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblMaKhachHang.Name = "lblMaKhachHang"
        Me.lblMaKhachHang.Size = New System.Drawing.Size(105, 18)
        Me.lblMaKhachHang.TabIndex = 63
        Me.lblMaKhachHang.Text = "Mã khách hàng:"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.EnterMoveNextControl = True
        Me.txtMaKhachHang.Location = New System.Drawing.Point(175, 34)
        Me.txtMaKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Properties.ReadOnly = True
        Me.txtMaKhachHang.Size = New System.Drawing.Size(227, 22)
        Me.txtMaKhachHang.TabIndex = 61
        '
        'dateNgayThu
        '
        Me.dateNgayThu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dateNgayThu.EditValue = Nothing
        Me.dateNgayThu.Location = New System.Drawing.Point(752, 73)
        Me.dateNgayThu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateNgayThu.Name = "dateNgayThu"
        Me.dateNgayThu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNgayThu.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNgayThu.Properties.Mask.EditMask = " dd.MM.yyyy"
        Me.dateNgayThu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dateNgayThu.Size = New System.Drawing.Size(280, 22)
        Me.dateNgayThu.TabIndex = 78
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(417, 11)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(374, 38)
        Me.lblMain.TabIndex = 77
        Me.lblMain.Text = "LẬP PHIẾU THU TIỀN"
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(629, 74)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(81, 21)
        Me.LabelControl9.TabIndex = 82
        Me.LabelControl9.Text = "Ngày lập:"
        '
        'txtMaPhieuThuTien
        '
        Me.txtMaPhieuThuTien.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMaPhieuThuTien.Enabled = False
        Me.txtMaPhieuThuTien.Location = New System.Drawing.Point(294, 71)
        Me.txtMaPhieuThuTien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaPhieuThuTien.Name = "txtMaPhieuThuTien"
        Me.txtMaPhieuThuTien.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMaPhieuThuTien.Properties.Appearance.Options.UseBackColor = True
        Me.txtMaPhieuThuTien.Size = New System.Drawing.Size(268, 22)
        Me.txtMaPhieuThuTien.TabIndex = 80
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(95, 73)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(156, 21)
        Me.LabelControl8.TabIndex = 81
        Me.LabelControl8.Text = "Mã phiếu thu tiền:"
        '
        'frmPhieuThuTienGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 690)
        Me.Controls.Add(Me.PanelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPhieuThuTienGUI"
        Me.Text = "Lập Phiếu Thu Tiền"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.grpChiTietPhieuThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChiTietPhieuThu.ResumeLayout(False)
        Me.grpChiTietPhieuThu.PerformLayout()
        CType(Me.txtSoTienThu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpQuyDinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuyDinh.ResumeLayout(False)
        CType(Me.chkApDungQuyDinhSoTienThuKhongVuotTienNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpThongTinKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThongTinKhachHang.ResumeLayout(False)
        Me.grpThongTinKhachHang.PerformLayout()
        CType(Me.txtTienNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNgayThu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNgayThu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaPhieuThuTien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblMain As Label
    Friend WithEvents dateNgayThu As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grpThongTinKhachHang As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtHoTenKhachHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMaKhachHang As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaKhachHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaPhieuThuTien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpQuyDinh As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkApDungQuyDinhSoTienThuKhongVuotTienNo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grpChiTietPhieuThu As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTaoMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThayDoiQuyDinh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnChonKhachHang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSoTienThu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSoTienThu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTienNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
