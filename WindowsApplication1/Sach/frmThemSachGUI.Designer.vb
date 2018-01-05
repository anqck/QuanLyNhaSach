<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemSachGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemSachGUI))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.grpThongTinSach = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDonGiaDuKien = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTheLoai = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblTenSach = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenSach = New DevExpress.XtraEditors.TextEdit()
        Me.txtTacGia = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblMaSach = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaSach = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnTaoMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMain = New System.Windows.Forms.Label()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThongTinSach.SuspendLayout()
        CType(Me.txtDonGiaDuKien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpThongTinSach)
        Me.Panel1.Controls.Add(Me.btnTaoMoi)
        Me.Panel1.Controls.Add(Me.btnThoat)
        Me.Panel1.Controls.Add(Me.btnLuu)
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 472)
        Me.Panel1.TabIndex = 0
        '
        'grpThongTinSach
        '
        Me.grpThongTinSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThongTinSach.CaptionImage = CType(resources.GetObject("grpThongTinSach.CaptionImage"), System.Drawing.Image)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl4)
        Me.grpThongTinSach.Controls.Add(Me.txtDonGiaDuKien)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl3)
        Me.grpThongTinSach.Controls.Add(Me.txtTheLoai)
        Me.grpThongTinSach.Controls.Add(Me.lblTenSach)
        Me.grpThongTinSach.Controls.Add(Me.txtTenSach)
        Me.grpThongTinSach.Controls.Add(Me.txtTacGia)
        Me.grpThongTinSach.Controls.Add(Me.lblMaSach)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl2)
        Me.grpThongTinSach.Controls.Add(Me.txtMaSach)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl1)
        Me.grpThongTinSach.Location = New System.Drawing.Point(121, 79)
        Me.grpThongTinSach.Name = "grpThongTinSach"
        Me.grpThongTinSach.Size = New System.Drawing.Size(589, 193)
        Me.grpThongTinSach.TabIndex = 51
        Me.grpThongTinSach.Text = "Thông tin chi tiết sách:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(467, 156)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "đồng"
        '
        'txtDonGiaDuKien
        '
        Me.txtDonGiaDuKien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDonGiaDuKien.EditValue = "0"
        Me.txtDonGiaDuKien.Location = New System.Drawing.Point(188, 155)
        Me.txtDonGiaDuKien.Name = "txtDonGiaDuKien"
        Me.txtDonGiaDuKien.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDonGiaDuKien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDonGiaDuKien.Properties.DisplayFormat.FormatString = "n0"
        Me.txtDonGiaDuKien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaDuKien.Properties.EditFormat.FormatString = "n0"
        Me.txtDonGiaDuKien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaDuKien.Properties.Mask.EditMask = "n0"
        Me.txtDonGiaDuKien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDonGiaDuKien.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDonGiaDuKien.Size = New System.Drawing.Size(273, 20)
        Me.txtDonGiaDuKien.TabIndex = 57
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(77, 156)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(105, 16)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Đơn giá dự kiến:"
        '
        'txtTheLoai
        '
        Me.txtTheLoai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTheLoai.Location = New System.Drawing.Point(188, 129)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTheLoai.Size = New System.Drawing.Size(273, 20)
        Me.txtTheLoai.TabIndex = 3
        '
        'lblTenSach
        '
        Me.lblTenSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTenSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSach.Location = New System.Drawing.Point(77, 82)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(62, 16)
        Me.lblTenSach.TabIndex = 40
        Me.lblTenSach.Text = "Tên sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenSach.Location = New System.Drawing.Point(188, 77)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(273, 20)
        Me.txtTenSach.TabIndex = 1
        '
        'txtTacGia
        '
        Me.txtTacGia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTacGia.Location = New System.Drawing.Point(188, 103)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTacGia.Size = New System.Drawing.Size(273, 20)
        Me.txtTacGia.TabIndex = 2
        '
        'lblMaSach
        '
        Me.lblMaSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaSach.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSach.Location = New System.Drawing.Point(77, 53)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(58, 16)
        Me.lblMaSach.TabIndex = 42
        Me.lblMaSach.Text = "Mã sách:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(77, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Thể loại:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaSach.Location = New System.Drawing.Point(188, 51)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMaSach.Properties.Appearance.Options.UseFont = True
        Me.txtMaSach.Properties.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(273, 20)
        Me.txtMaSach.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(77, 107)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Tác giả:"
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTaoMoi.Image = CType(resources.GetObject("btnTaoMoi.Image"), System.Drawing.Image)
        Me.btnTaoMoi.Location = New System.Drawing.Point(545, 435)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(85, 25)
        Me.btnTaoMoi.TabIndex = 4
        Me.btnTaoMoi.Text = "Tạo mới"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(727, 435)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(85, 25)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(636, 435)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(85, 25)
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
        Me.lblMain.Location = New System.Drawing.Point(323, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(178, 31)
        Me.lblMain.TabIndex = 39
        Me.lblMain.Text = "THÊM SÁCH"
        '
        'frmThemSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 472)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmThemSachGUI"
        Me.Text = "Thêm Sách"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThongTinSach.ResumeLayout(False)
        Me.grpThongTinSach.PerformLayout()
        CType(Me.txtDonGiaDuKien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblMain As Label
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMaSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTenSach As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTheLoai As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTacGia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnTaoMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpThongTinSach As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDonGiaDuKien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
