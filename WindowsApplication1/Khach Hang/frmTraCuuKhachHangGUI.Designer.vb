<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuKhachHangGUI
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraCuuKhachHangGUI))
        Me.GridViewHoaDon = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaHoaDon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNgayLapHoaDon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTongThanhTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPhieuThuTien = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaPhieuThuTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoTienThu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNgayThuTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmHoTenKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDiaChi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDienThoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoTienNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTenKhachHang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaKhachHang = New DevExpress.XtraEditors.TextEdit()
        Me.btnTimKiem = New DevExpress.XtraEditors.SimpleButton()
        Me.cbKieuMaKhachHang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbKieuHoTenKhachHang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnToiDaSoTienNo = New System.Windows.Forms.Button()
        Me.txtSoTienNofr = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoTienNoto = New DevExpress.XtraEditors.TextEdit()
        Me.chkSoTienNo = New DevExpress.XtraEditors.CheckEdit()
        Me.cbKieuEmail = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.chkEmail = New DevExpress.XtraEditors.CheckEdit()
        Me.cbKieuDienThoai = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDienThoai = New DevExpress.XtraEditors.TextEdit()
        Me.chkDienThoai = New DevExpress.XtraEditors.CheckEdit()
        Me.cbKieuDiaChi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.chkDiaChi = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.WindowsApplication1.WaitForm1), True, True)
        CType(Me.GridViewHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtSoTienNofr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoTienNoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoTienNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridViewHoaDon
        '
        Me.GridViewHoaDon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaHoaDon, Me.clmNgayLapHoaDon, Me.clmTongThanhTien})
        Me.GridViewHoaDon.GridControl = Me.Grid
        Me.GridViewHoaDon.Name = "GridViewHoaDon"
        Me.GridViewHoaDon.OptionsCustomization.AllowFilter = False
        Me.GridViewHoaDon.OptionsCustomization.AllowGroup = False
        Me.GridViewHoaDon.OptionsView.ShowGroupPanel = False
        Me.GridViewHoaDon.ViewCaption = "Thông Tin Hóa Đơn"
        '
        'clmMaHoaDon
        '
        Me.clmMaHoaDon.Caption = "Mã Hóa Đơn"
        Me.clmMaHoaDon.FieldName = "clmMaHoaDon"
        Me.clmMaHoaDon.Name = "clmMaHoaDon"
        Me.clmMaHoaDon.OptionsColumn.AllowEdit = False
        Me.clmMaHoaDon.OptionsColumn.ReadOnly = True
        Me.clmMaHoaDon.Visible = True
        Me.clmMaHoaDon.VisibleIndex = 0
        '
        'clmNgayLapHoaDon
        '
        Me.clmNgayLapHoaDon.Caption = "Ngày Lập Hóa Đơn"
        Me.clmNgayLapHoaDon.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.clmNgayLapHoaDon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.clmNgayLapHoaDon.FieldName = "clmNgayLapHoaDon"
        Me.clmNgayLapHoaDon.Name = "clmNgayLapHoaDon"
        Me.clmNgayLapHoaDon.OptionsColumn.AllowEdit = False
        Me.clmNgayLapHoaDon.OptionsColumn.ReadOnly = True
        Me.clmNgayLapHoaDon.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.clmNgayLapHoaDon.Visible = True
        Me.clmNgayLapHoaDon.VisibleIndex = 1
        '
        'clmTongThanhTien
        '
        Me.clmTongThanhTien.AppearanceCell.Options.UseTextOptions = True
        Me.clmTongThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmTongThanhTien.Caption = "Tổng Thành Tiền (Đồng)"
        Me.clmTongThanhTien.DisplayFormat.FormatString = "n0"
        Me.clmTongThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmTongThanhTien.FieldName = "clmTongThanhTien"
        Me.clmTongThanhTien.Name = "clmTongThanhTien"
        Me.clmTongThanhTien.OptionsColumn.AllowEdit = False
        Me.clmTongThanhTien.OptionsColumn.ReadOnly = True
        Me.clmTongThanhTien.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmTongThanhTien.Visible = True
        Me.clmTongThanhTien.VisibleIndex = 2
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        GridLevelNode1.LevelTemplate = Me.GridViewHoaDon
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GridViewPhieuThuTien
        GridLevelNode2.RelationName = "Level2"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.Grid.Location = New System.Drawing.Point(2, 25)
        Me.Grid.MainView = Me.GridView
        Me.Grid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1149, 414)
        Me.Grid.TabIndex = 41
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPhieuThuTien, Me.GridView, Me.GridViewHoaDon})
        '
        'GridViewPhieuThuTien
        '
        Me.GridViewPhieuThuTien.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaPhieuThuTien, Me.clmSoTienThu, Me.clmNgayThuTien})
        Me.GridViewPhieuThuTien.GridControl = Me.Grid
        Me.GridViewPhieuThuTien.Name = "GridViewPhieuThuTien"
        Me.GridViewPhieuThuTien.OptionsCustomization.AllowFilter = False
        Me.GridViewPhieuThuTien.OptionsCustomization.AllowGroup = False
        Me.GridViewPhieuThuTien.OptionsView.ShowGroupPanel = False
        Me.GridViewPhieuThuTien.ViewCaption = "Thông Tin Phiếu Thu Tiền"
        '
        'clmMaPhieuThuTien
        '
        Me.clmMaPhieuThuTien.Caption = "Mã Phiếu Thu Tiền"
        Me.clmMaPhieuThuTien.FieldName = "clmMaPhieuThuTien"
        Me.clmMaPhieuThuTien.Name = "clmMaPhieuThuTien"
        Me.clmMaPhieuThuTien.OptionsColumn.AllowEdit = False
        Me.clmMaPhieuThuTien.OptionsColumn.ReadOnly = True
        Me.clmMaPhieuThuTien.Visible = True
        Me.clmMaPhieuThuTien.VisibleIndex = 0
        '
        'clmSoTienThu
        '
        Me.clmSoTienThu.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoTienThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoTienThu.Caption = "Số Tiền Thu (Đồng)"
        Me.clmSoTienThu.DisplayFormat.FormatString = "n0"
        Me.clmSoTienThu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoTienThu.FieldName = "clmSoTienThu"
        Me.clmSoTienThu.Name = "clmSoTienThu"
        Me.clmSoTienThu.OptionsColumn.AllowEdit = False
        Me.clmSoTienThu.OptionsColumn.ReadOnly = True
        Me.clmSoTienThu.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoTienThu.Visible = True
        Me.clmSoTienThu.VisibleIndex = 2
        '
        'clmNgayThuTien
        '
        Me.clmNgayThuTien.Caption = "Ngày Thu Tiền"
        Me.clmNgayThuTien.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.clmNgayThuTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.clmNgayThuTien.FieldName = "clmNgayThuTien"
        Me.clmNgayThuTien.Name = "clmNgayThuTien"
        Me.clmNgayThuTien.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.clmNgayThuTien.Visible = True
        Me.clmNgayThuTien.VisibleIndex = 1
        '
        'GridView
        '
        Me.GridView.ActiveFilterEnabled = False
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSTT, Me.clmMaKhachHang, Me.clmHoTenKhachHang, Me.clmDiaChi, Me.clmEmail, Me.clmDienThoai, Me.clmSoTienNo})
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsCustomization.AllowFilter = False
        Me.GridView.OptionsCustomization.AllowGroup = False
        Me.GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'clmSTT
        '
        Me.clmSTT.Caption = "STT"
        Me.clmSTT.FieldName = "clmSTT"
        Me.clmSTT.Name = "clmSTT"
        Me.clmSTT.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSTT.Visible = True
        Me.clmSTT.VisibleIndex = 0
        Me.clmSTT.Width = 45
        '
        'clmMaKhachHang
        '
        Me.clmMaKhachHang.Caption = "Mã Khách Hàng"
        Me.clmMaKhachHang.FieldName = "clmMaKhachHang"
        Me.clmMaKhachHang.Name = "clmMaKhachHang"
        Me.clmMaKhachHang.OptionsColumn.AllowEdit = False
        Me.clmMaKhachHang.OptionsColumn.ReadOnly = True
        Me.clmMaKhachHang.Visible = True
        Me.clmMaKhachHang.VisibleIndex = 1
        Me.clmMaKhachHang.Width = 89
        '
        'clmHoTenKhachHang
        '
        Me.clmHoTenKhachHang.Caption = "Họ Tên Khách Hàng"
        Me.clmHoTenKhachHang.FieldName = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang.Name = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang.OptionsColumn.AllowEdit = False
        Me.clmHoTenKhachHang.OptionsColumn.ReadOnly = True
        Me.clmHoTenKhachHang.Visible = True
        Me.clmHoTenKhachHang.VisibleIndex = 2
        Me.clmHoTenKhachHang.Width = 164
        '
        'clmDiaChi
        '
        Me.clmDiaChi.Caption = "Địa Chỉ"
        Me.clmDiaChi.FieldName = "clmDiaChi"
        Me.clmDiaChi.Name = "clmDiaChi"
        Me.clmDiaChi.OptionsColumn.AllowEdit = False
        Me.clmDiaChi.OptionsColumn.ReadOnly = True
        Me.clmDiaChi.Visible = True
        Me.clmDiaChi.VisibleIndex = 3
        Me.clmDiaChi.Width = 178
        '
        'clmEmail
        '
        Me.clmEmail.Caption = "Email"
        Me.clmEmail.FieldName = "clmEmail"
        Me.clmEmail.Name = "clmEmail"
        Me.clmEmail.OptionsColumn.AllowEdit = False
        Me.clmEmail.OptionsColumn.ReadOnly = True
        Me.clmEmail.Visible = True
        Me.clmEmail.VisibleIndex = 4
        Me.clmEmail.Width = 141
        '
        'clmDienThoai
        '
        Me.clmDienThoai.Caption = "Điện Thoại"
        Me.clmDienThoai.FieldName = "clmDienThoai"
        Me.clmDienThoai.Name = "clmDienThoai"
        Me.clmDienThoai.OptionsColumn.AllowEdit = False
        Me.clmDienThoai.OptionsColumn.ReadOnly = True
        Me.clmDienThoai.Visible = True
        Me.clmDienThoai.VisibleIndex = 5
        Me.clmDienThoai.Width = 115
        '
        'clmSoTienNo
        '
        Me.clmSoTienNo.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoTienNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoTienNo.Caption = "Số Tiền Nợ (Đồng)"
        Me.clmSoTienNo.DisplayFormat.FormatString = "n0"
        Me.clmSoTienNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoTienNo.FieldName = "clmSoTienNo"
        Me.clmSoTienNo.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoTienNo.Name = "clmSoTienNo"
        Me.clmSoTienNo.OptionsColumn.AllowEdit = False
        Me.clmSoTienNo.OptionsColumn.ReadOnly = True
        Me.clmSoTienNo.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoTienNo.Visible = True
        Me.clmSoTienNo.VisibleIndex = 6
        Me.clmSoTienNo.Width = 111
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(380, 11)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(421, 38)
        Me.lblMain.TabIndex = 39
        Me.lblMain.Text = "TRA CỨU KHÁCH HÀNG"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 42)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Mã Khách Hàng:"
        '
        'txtHoTenKhachHang
        '
        Me.txtHoTenKhachHang.Location = New System.Drawing.Point(712, 38)
        Me.txtHoTenKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoTenKhachHang.Name = "txtHoTenKhachHang"
        Me.txtHoTenKhachHang.Size = New System.Drawing.Size(297, 22)
        Me.txtHoTenKhachHang.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(576, 42)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(124, 17)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Họ tên Khách Hàng:"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Location = New System.Drawing.Point(136, 38)
        Me.txtMaKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(297, 22)
        Me.txtMaKhachHang.TabIndex = 0
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.ImageOptions.Image = CType(resources.GetObject("btnTimKiem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTimKiem.Location = New System.Drawing.Point(893, 140)
        Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(113, 28)
        Me.btnTimKiem.TabIndex = 17
        Me.btnTimKiem.Text = "Tìm Kiếm"
        '
        'cbKieuMaKhachHang
        '
        Me.cbKieuMaKhachHang.Location = New System.Drawing.Point(441, 38)
        Me.cbKieuMaKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbKieuMaKhachHang.Name = "cbKieuMaKhachHang"
        Me.cbKieuMaKhachHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuMaKhachHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuMaKhachHang.Size = New System.Drawing.Size(107, 22)
        Me.cbKieuMaKhachHang.TabIndex = 1
        '
        'cbKieuHoTenKhachHang
        '
        Me.cbKieuHoTenKhachHang.Location = New System.Drawing.Point(1017, 38)
        Me.cbKieuHoTenKhachHang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbKieuHoTenKhachHang.Name = "cbKieuHoTenKhachHang"
        Me.cbKieuHoTenKhachHang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuHoTenKhachHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuHoTenKhachHang.Size = New System.Drawing.Size(107, 22)
        Me.cbKieuHoTenKhachHang.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupControl2.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl2.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.btnThoat)
        Me.GroupControl2.Controls.Add(Me.btnToiDaSoTienNo)
        Me.GroupControl2.Controls.Add(Me.txtSoTienNofr)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtSoTienNoto)
        Me.GroupControl2.Controls.Add(Me.chkSoTienNo)
        Me.GroupControl2.Controls.Add(Me.cbKieuEmail)
        Me.GroupControl2.Controls.Add(Me.txtEmail)
        Me.GroupControl2.Controls.Add(Me.chkEmail)
        Me.GroupControl2.Controls.Add(Me.cbKieuDienThoai)
        Me.GroupControl2.Controls.Add(Me.txtDienThoai)
        Me.GroupControl2.Controls.Add(Me.chkDienThoai)
        Me.GroupControl2.Controls.Add(Me.cbKieuDiaChi)
        Me.GroupControl2.Controls.Add(Me.txtDiaChi)
        Me.GroupControl2.Controls.Add(Me.chkDiaChi)
        Me.GroupControl2.Controls.Add(Me.cbKieuHoTenKhachHang)
        Me.GroupControl2.Controls.Add(Me.cbKieuMaKhachHang)
        Me.GroupControl2.Controls.Add(Me.btnTimKiem)
        Me.GroupControl2.Controls.Add(Me.txtMaKhachHang)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtHoTenKhachHang)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 80)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1153, 175)
        Me.GroupControl2.TabIndex = 40
        Me.GroupControl2.Text = "Tra cứu:"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(1015, 140)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(113, 28)
        Me.btnThoat.TabIndex = 93
        Me.btnThoat.Text = "Thoát"
        '
        'btnToiDaSoTienNo
        '
        Me.btnToiDaSoTienNo.Location = New System.Drawing.Point(1059, 100)
        Me.btnToiDaSoTienNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnToiDaSoTienNo.Name = "btnToiDaSoTienNo"
        Me.btnToiDaSoTienNo.Size = New System.Drawing.Size(69, 27)
        Me.btnToiDaSoTienNo.TabIndex = 51
        Me.btnToiDaSoTienNo.Text = "Tối đa"
        Me.btnToiDaSoTienNo.UseVisualStyleBackColor = True
        '
        'txtSoTienNofr
        '
        Me.txtSoTienNofr.Location = New System.Drawing.Point(733, 101)
        Me.txtSoTienNofr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSoTienNofr.Name = "txtSoTienNofr"
        Me.txtSoTienNofr.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoTienNofr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoTienNofr.Properties.DisplayFormat.FormatString = "n0"
        Me.txtSoTienNofr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoTienNofr.Properties.EditFormat.FormatString = "n0"
        Me.txtSoTienNofr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoTienNofr.Properties.Mask.EditMask = "n0"
        Me.txtSoTienNofr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoTienNofr.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSoTienNofr.Size = New System.Drawing.Size(143, 22)
        Me.txtSoTienNofr.TabIndex = 31
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(711, 106)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(198, 17)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Từ                                       Đến"
        '
        'txtSoTienNoto
        '
        Me.txtSoTienNoto.Location = New System.Drawing.Point(919, 101)
        Me.txtSoTienNoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSoTienNoto.Name = "txtSoTienNoto"
        Me.txtSoTienNoto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoTienNoto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoTienNoto.Properties.DisplayFormat.FormatString = "n0"
        Me.txtSoTienNoto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoTienNoto.Properties.EditFormat.FormatString = "n0"
        Me.txtSoTienNoto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoTienNoto.Properties.Mask.EditMask = "n0"
        Me.txtSoTienNoto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoTienNoto.Size = New System.Drawing.Size(132, 22)
        Me.txtSoTienNoto.TabIndex = 32
        '
        'chkSoTienNo
        '
        Me.chkSoTienNo.Location = New System.Drawing.Point(593, 100)
        Me.chkSoTienNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSoTienNo.Name = "chkSoTienNo"
        Me.chkSoTienNo.Properties.Caption = "Số tiền nợ:"
        Me.chkSoTienNo.Size = New System.Drawing.Size(116, 21)
        Me.chkSoTienNo.TabIndex = 30
        '
        'cbKieuEmail
        '
        Me.cbKieuEmail.Location = New System.Drawing.Point(1017, 69)
        Me.cbKieuEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbKieuEmail.Name = "cbKieuEmail"
        Me.cbKieuEmail.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuEmail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuEmail.Size = New System.Drawing.Size(107, 22)
        Me.cbKieuEmail.TabIndex = 29
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(712, 70)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(297, 22)
        Me.txtEmail.TabIndex = 28
        '
        'chkEmail
        '
        Me.chkEmail.Location = New System.Drawing.Point(593, 69)
        Me.chkEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Properties.Caption = "Email:"
        Me.chkEmail.Size = New System.Drawing.Size(116, 20)
        Me.chkEmail.TabIndex = 27
        '
        'cbKieuDienThoai
        '
        Me.cbKieuDienThoai.Location = New System.Drawing.Point(443, 100)
        Me.cbKieuDienThoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbKieuDienThoai.Name = "cbKieuDienThoai"
        Me.cbKieuDienThoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuDienThoai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuDienThoai.Size = New System.Drawing.Size(107, 22)
        Me.cbKieuDienThoai.TabIndex = 26
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(137, 100)
        Me.txtDienThoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(297, 22)
        Me.txtDienThoai.TabIndex = 25
        '
        'chkDienThoai
        '
        Me.chkDienThoai.Location = New System.Drawing.Point(11, 101)
        Me.chkDienThoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDienThoai.Name = "chkDienThoai"
        Me.chkDienThoai.Properties.Caption = "Điện thoại:"
        Me.chkDienThoai.Size = New System.Drawing.Size(116, 21)
        Me.chkDienThoai.TabIndex = 24
        '
        'cbKieuDiaChi
        '
        Me.cbKieuDiaChi.Location = New System.Drawing.Point(443, 69)
        Me.cbKieuDiaChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbKieuDiaChi.Name = "cbKieuDiaChi"
        Me.cbKieuDiaChi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuDiaChi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuDiaChi.Size = New System.Drawing.Size(107, 22)
        Me.cbKieuDiaChi.TabIndex = 23
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(137, 69)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(297, 22)
        Me.txtDiaChi.TabIndex = 22
        '
        'chkDiaChi
        '
        Me.chkDiaChi.Location = New System.Drawing.Point(11, 70)
        Me.chkDiaChi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDiaChi.Name = "chkDiaChi"
        Me.chkDiaChi.Properties.Caption = "Địa chỉ:"
        Me.chkDiaChi.Size = New System.Drawing.Size(116, 21)
        Me.chkDiaChi.TabIndex = 21
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnIn)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lblMain)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1185, 709)
        Me.PanelControl1.TabIndex = 41
        '
        'btnIn
        '
        Me.btnIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn.ImageOptions.Image = CType(resources.GetObject("btnIn.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIn.Location = New System.Drawing.Point(935, 6)
        Me.btnIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(232, 28)
        Me.btnIn.TabIndex = 47
        Me.btnIn.Text = "Xuất danh sách khách hàng"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.Grid)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 262)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1153, 441)
        Me.GroupControl1.TabIndex = 42
        Me.GroupControl1.Text = "Danh sách chi tiết các khách hàng tra cứu"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmTraCuuKhachHangGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 709)
        Me.Controls.Add(Me.PanelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTraCuuKhachHangGUI"
        Me.Text = "Tra Cứu Khách Hàng"
        CType(Me.GridViewHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtSoTienNofr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoTienNoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoTienNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHoTenKhachHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaKhachHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTimKiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbKieuMaKhachHang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbKieuHoTenKhachHang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbKieuEmail As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkEmail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbKieuDienThoai As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkDienThoai As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbKieuDiaChi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkDiaChi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSoTienNo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSoTienNofr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoTienNoto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnToiDaSoTienNo As Button
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmHoTenKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDiaChi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDienThoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoTienNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents clmSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewHoaDon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaHoaDon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmNgayLapHoaDon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTongThanhTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewPhieuThuTien As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaPhieuThuTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoTienThu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clmNgayThuTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
