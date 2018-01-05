<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChinhSuaKhachHangGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChinhSuaKhachHangGUI))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.grpThongTinSach = New DevExpress.XtraEditors.GroupControl()
        Me.txtDienThoai = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTenKH = New DevExpress.XtraEditors.TextEdit()
        Me.btnChonSach = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTenSach = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lblMaSach = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaKH = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMain = New System.Windows.Forms.Label()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThongTinSach.SuspendLayout()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTenKH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaKH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel1.Controls.Add(Me.grpThongTinSach)
        Me.Panel1.Controls.Add(Me.btnThoat)
        Me.Panel1.Controls.Add(Me.btnLuu)
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 448)
        Me.Panel1.TabIndex = 1
        '
        'grpThongTinSach
        '
        Me.grpThongTinSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThongTinSach.CaptionImageOptions.Image = CType(resources.GetObject("grpThongTinSach.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpThongTinSach.Controls.Add(Me.txtDienThoai)
        Me.grpThongTinSach.Controls.Add(Me.txtDiaChi)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl3)
        Me.grpThongTinSach.Controls.Add(Me.txtHoTenKH)
        Me.grpThongTinSach.Controls.Add(Me.btnChonSach)
        Me.grpThongTinSach.Controls.Add(Me.lblTenSach)
        Me.grpThongTinSach.Controls.Add(Me.txtEmail)
        Me.grpThongTinSach.Controls.Add(Me.lblMaSach)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl2)
        Me.grpThongTinSach.Controls.Add(Me.txtMaKH)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl1)
        Me.grpThongTinSach.Location = New System.Drawing.Point(93, 95)
        Me.grpThongTinSach.Margin = New System.Windows.Forms.Padding(4)
        Me.grpThongTinSach.Name = "grpThongTinSach"
        Me.grpThongTinSach.Size = New System.Drawing.Size(993, 222)
        Me.grpThongTinSach.TabIndex = 51
        Me.grpThongTinSach.Text = "Thông tin chi tiết sách:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDienThoai.Location = New System.Drawing.Point(272, 144)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(551, 22)
        Me.txtDienThoai.TabIndex = 56
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiaChi.Location = New System.Drawing.Point(272, 173)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(551, 22)
        Me.txtDiaChi.TabIndex = 55
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(76, 51)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(128, 19)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Mã khách hàng:"
        '
        'txtHoTenKH
        '
        Me.txtHoTenKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoTenKH.Location = New System.Drawing.Point(272, 80)
        Me.txtHoTenKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTenKH.Name = "txtHoTenKH"
        Me.txtHoTenKH.Size = New System.Drawing.Size(551, 22)
        Me.txtHoTenKH.TabIndex = 53
        '
        'btnChonSach
        '
        Me.btnChonSach.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChonSach.ImageOptions.Image = CType(resources.GetObject("btnChonSach.ImageOptions.Image"), System.Drawing.Image)
        Me.btnChonSach.Location = New System.Drawing.Point(831, 47)
        Me.btnChonSach.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChonSach.Name = "btnChonSach"
        Me.btnChonSach.Size = New System.Drawing.Size(156, 26)
        Me.btnChonSach.TabIndex = 52
        Me.btnChonSach.Text = "Chọn khách hàng"
        '
        'lblTenSach
        '
        Me.lblTenSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTenSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSach.Appearance.Options.UseFont = True
        Me.lblTenSach.Location = New System.Drawing.Point(76, 112)
        Me.lblTenSach.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(51, 19)
        Me.lblTenSach.TabIndex = 40
        Me.lblTenSach.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(272, 109)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(551, 22)
        Me.txtEmail.TabIndex = 1
        '
        'lblMaSach
        '
        Me.lblMaSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSach.Appearance.Options.UseFont = True
        Me.lblMaSach.Location = New System.Drawing.Point(76, 80)
        Me.lblMaSach.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(167, 21)
        Me.lblMaSach.TabIndex = 42
        Me.lblMaSach.Text = "Họ tên khách hàng:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(76, 174)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 21)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Địa chỉ:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaKH.Location = New System.Drawing.Point(272, 48)
        Me.txtMaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMaKH.Properties.Appearance.Options.UseFont = True
        Me.txtMaKH.Properties.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(551, 24)
        Me.txtMaKH.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(76, 144)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Điện thoại:"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(1023, 405)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(113, 31)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.ImageOptions.Image = CType(resources.GetObject("btnLuu.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(902, 405)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(113, 31)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(313, 9)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(660, 38)
        Me.lblMain.TabIndex = 39
        Me.lblMain.Text = "CHỈNH SỬA THÔNG TIN KHÁCH HÀNG"
        '
        'frmChinhSuaKhachHangGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 448)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmChinhSuaKhachHangGUI"
        Me.Text = "Chỉnh Sửa Thông Tin Sách"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThongTinSach.ResumeLayout(False)
        Me.grpThongTinSach.PerformLayout()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTenKH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaKH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpThongTinSach As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnChonSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTenSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMaSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaKH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMain As Label
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHoTenKH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.TextEdit
End Class
