<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTraCuuSachGUI
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraCuuSachGUI))
        Me.gridChiTietBanSach = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaHoaDon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNgayLapHoaDon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongBan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDonGiaBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmThanhTien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.gridChiTietNhapSach = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaPhieuNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNgayNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTenSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTacGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTheLoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongTon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDonGiaBanDuKien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTongTienBan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnToiDaDonGiaBanDuKien = New System.Windows.Forms.Button()
        Me.txtDonGiaDuKienfr = New DevExpress.XtraEditors.TextEdit()
        Me.txtDonGiaDuKiento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.chkDonGiaDuKien = New DevExpress.XtraEditors.CheckEdit()
        Me.btnToiDaTienBan = New System.Windows.Forms.Button()
        Me.btnToiDaSoLuongBan = New System.Windows.Forms.Button()
        Me.btnToiDaSoLuongTon = New System.Windows.Forms.Button()
        Me.cbKieuTenSach = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbKieuMaSach = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTongTienBanfr = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTongTienBanto = New DevExpress.XtraEditors.TextEdit()
        Me.txtNgayBanto = New DevExpress.XtraEditors.DateEdit()
        Me.txtNgayBanfr = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.chkNgayBan = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTongTienBan = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDonGiaBanfr = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDonGiaBanto = New DevExpress.XtraEditors.TextEdit()
        Me.txtSoLuongBanfr = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoLuongBanto = New DevExpress.XtraEditors.TextEdit()
        Me.txtSoLuongTonfr = New DevExpress.XtraEditors.TextEdit()
        Me.cbTacGia = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnTimKiem = New DevExpress.XtraEditors.SimpleButton()
        Me.cbTheLoai = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.chkDonGiaBan = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSoLuongBan = New DevExpress.XtraEditors.CheckEdit()
        Me.txtSoLuongTonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaSach = New DevExpress.XtraEditors.TextEdit()
        Me.chkSoLuongTon = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenSach = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.WindowsApplication1.WaitForm1), True, True)
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridChiTietBanSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridChiTietNhapSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDonGiaDuKienfr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDonGiaDuKiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDonGiaDuKien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKieuMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTienBanfr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTongTienBanto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayBanto.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayBanto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayBanfr.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayBanfr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNgayBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTongTienBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDonGiaBanfr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDonGiaBanto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLuongBanfr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLuongBanto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLuongTonfr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDonGiaBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoLuongBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLuongTonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoLuongTon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridChiTietBanSach
        '
        Me.gridChiTietBanSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaHoaDon, Me.clmNgayLapHoaDon, Me.clmSoLuongBan1, Me.clmDonGiaBan, Me.clmThanhTien})
        Me.gridChiTietBanSach.GridControl = Me.Grid
        Me.gridChiTietBanSach.Name = "gridChiTietBanSach"
        Me.gridChiTietBanSach.OptionsCustomization.AllowFilter = False
        Me.gridChiTietBanSach.OptionsCustomization.AllowGroup = False
        Me.gridChiTietBanSach.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.gridChiTietBanSach.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridChiTietBanSach.OptionsView.ShowGroupPanel = False
        Me.gridChiTietBanSach.ViewCaption = "Thông tin chi tiết bán sách"
        '
        'clmMaHoaDon
        '
        Me.clmMaHoaDon.Caption = "Mã Hóa Đơn"
        Me.clmMaHoaDon.FieldName = "clmMaHoaDon"
        Me.clmMaHoaDon.Name = "clmMaHoaDon"
        Me.clmMaHoaDon.OptionsColumn.AllowEdit = False
        Me.clmMaHoaDon.OptionsColumn.ReadOnly = True
        Me.clmMaHoaDon.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmMaHoaDon.Visible = True
        Me.clmMaHoaDon.VisibleIndex = 0
        '
        'clmNgayLapHoaDon
        '
        Me.clmNgayLapHoaDon.Caption = "Ngày Bán"
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
        'clmSoLuongBan1
        '
        Me.clmSoLuongBan1.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoLuongBan1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoLuongBan1.Caption = "Số Lượng Bán"
        Me.clmSoLuongBan1.FieldName = "clmSoLuongBan"
        Me.clmSoLuongBan1.Name = "clmSoLuongBan1"
        Me.clmSoLuongBan1.OptionsColumn.AllowEdit = False
        Me.clmSoLuongBan1.OptionsColumn.ReadOnly = True
        Me.clmSoLuongBan1.Visible = True
        Me.clmSoLuongBan1.VisibleIndex = 3
        '
        'clmDonGiaBan
        '
        Me.clmDonGiaBan.AppearanceCell.Options.UseTextOptions = True
        Me.clmDonGiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmDonGiaBan.Caption = "Đơn Giá Bán (Đồng)"
        Me.clmDonGiaBan.DisplayFormat.FormatString = "n0"
        Me.clmDonGiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmDonGiaBan.FieldName = "clmDonGiaBan"
        Me.clmDonGiaBan.Name = "clmDonGiaBan"
        Me.clmDonGiaBan.OptionsColumn.AllowEdit = False
        Me.clmDonGiaBan.OptionsColumn.ReadOnly = True
        Me.clmDonGiaBan.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmDonGiaBan.Visible = True
        Me.clmDonGiaBan.VisibleIndex = 2
        '
        'clmThanhTien
        '
        Me.clmThanhTien.AppearanceCell.Options.UseTextOptions = True
        Me.clmThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmThanhTien.Caption = "Thành Tiền (Đồng)"
        Me.clmThanhTien.DisplayFormat.FormatString = "n0"
        Me.clmThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmThanhTien.FieldName = "clmThanhTien"
        Me.clmThanhTien.Name = "clmThanhTien"
        Me.clmThanhTien.OptionsColumn.AllowEdit = False
        Me.clmThanhTien.OptionsColumn.ReadOnly = True
        Me.clmThanhTien.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmThanhTien.Visible = True
        Me.clmThanhTien.VisibleIndex = 4
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gridChiTietBanSach
        GridLevelNode1.RelationName = "ChiTietBanSach"
        GridLevelNode2.LevelTemplate = Me.gridChiTietNhapSach
        GridLevelNode2.RelationName = "ChiTietNhapSach"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.Grid.Location = New System.Drawing.Point(2, 23)
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.Grid.Size = New System.Drawing.Size(861, 289)
        Me.Grid.TabIndex = 4
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridChiTietNhapSach, Me.GridView, Me.gridChiTietBanSach})
        '
        'gridChiTietNhapSach
        '
        Me.gridChiTietNhapSach.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaPhieuNhap, Me.clmNgayNhap, Me.clmSoLuongNhap})
        Me.gridChiTietNhapSach.GridControl = Me.Grid
        Me.gridChiTietNhapSach.Name = "gridChiTietNhapSach"
        Me.gridChiTietNhapSach.OptionsCustomization.AllowFilter = False
        Me.gridChiTietNhapSach.OptionsCustomization.AllowGroup = False
        Me.gridChiTietNhapSach.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.gridChiTietNhapSach.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gridChiTietNhapSach.OptionsView.ShowGroupPanel = False
        Me.gridChiTietNhapSach.ViewCaption = "Thông tin chi tiết nhập sách"
        '
        'clmMaPhieuNhap
        '
        Me.clmMaPhieuNhap.Caption = "Mã Phiếu Nhập"
        Me.clmMaPhieuNhap.FieldName = "clmMaPhieuNhap"
        Me.clmMaPhieuNhap.Name = "clmMaPhieuNhap"
        Me.clmMaPhieuNhap.OptionsColumn.AllowEdit = False
        Me.clmMaPhieuNhap.OptionsColumn.ReadOnly = True
        Me.clmMaPhieuNhap.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmMaPhieuNhap.Visible = True
        Me.clmMaPhieuNhap.VisibleIndex = 0
        '
        'clmNgayNhap
        '
        Me.clmNgayNhap.Caption = "Ngày Nhập"
        Me.clmNgayNhap.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.clmNgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.clmNgayNhap.FieldName = "clmNgayNhap"
        Me.clmNgayNhap.Name = "clmNgayNhap"
        Me.clmNgayNhap.OptionsColumn.AllowEdit = False
        Me.clmNgayNhap.OptionsColumn.ReadOnly = True
        Me.clmNgayNhap.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
        Me.clmNgayNhap.Visible = True
        Me.clmNgayNhap.VisibleIndex = 1
        '
        'clmSoLuongNhap
        '
        Me.clmSoLuongNhap.Caption = "Số Lượng Nhập"
        Me.clmSoLuongNhap.FieldName = "clmSoLuongNhap"
        Me.clmSoLuongNhap.Name = "clmSoLuongNhap"
        Me.clmSoLuongNhap.OptionsColumn.AllowEdit = False
        Me.clmSoLuongNhap.OptionsColumn.ReadOnly = True
        Me.clmSoLuongNhap.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoLuongNhap.Visible = True
        Me.clmSoLuongNhap.VisibleIndex = 2
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSTT, Me.clmMaSach, Me.clmTenSach, Me.clmTacGia, Me.clmTheLoai, Me.clmSoLuongTon, Me.clmDonGiaBanDuKien, Me.clmSoLuongBan, Me.clmTongTienBan})
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsCustomization.AllowFilter = False
        Me.GridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
        Me.GridView.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView.OptionsFilter.AllowFilterEditor = False
        Me.GridView.OptionsMenu.ShowAutoFilterRowItem = False
        Me.GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'clmSTT
        '
        Me.clmSTT.Caption = "STT"
        Me.clmSTT.FieldName = "clmSTT"
        Me.clmSTT.Name = "clmSTT"
        Me.clmSTT.OptionsColumn.AllowEdit = False
        Me.clmSTT.OptionsColumn.ReadOnly = True
        Me.clmSTT.Visible = True
        Me.clmSTT.VisibleIndex = 0
        Me.clmSTT.Width = 58
        '
        'clmMaSach
        '
        Me.clmMaSach.Caption = "Mã Sách"
        Me.clmMaSach.FieldName = "clmMaSach"
        Me.clmMaSach.Name = "clmMaSach"
        Me.clmMaSach.OptionsColumn.AllowEdit = False
        Me.clmMaSach.OptionsColumn.ReadOnly = True
        Me.clmMaSach.OptionsEditForm.StartNewRow = True
        Me.clmMaSach.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmMaSach.Visible = True
        Me.clmMaSach.VisibleIndex = 1
        Me.clmMaSach.Width = 86
        '
        'clmTenSach
        '
        Me.clmTenSach.Caption = "Tên Sách"
        Me.clmTenSach.FieldName = "clmTenSach"
        Me.clmTenSach.Name = "clmTenSach"
        Me.clmTenSach.OptionsColumn.AllowEdit = False
        Me.clmTenSach.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.clmTenSach.OptionsColumn.ReadOnly = True
        Me.clmTenSach.OptionsEditForm.StartNewRow = True
        Me.clmTenSach.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.clmTenSach.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmTenSach.Visible = True
        Me.clmTenSach.VisibleIndex = 2
        Me.clmTenSach.Width = 163
        '
        'clmTacGia
        '
        Me.clmTacGia.Caption = "Tác Giả"
        Me.clmTacGia.FieldName = "clmTacGia"
        Me.clmTacGia.Name = "clmTacGia"
        Me.clmTacGia.OptionsColumn.AllowEdit = False
        Me.clmTacGia.OptionsColumn.ReadOnly = True
        Me.clmTacGia.OptionsColumn.TabStop = False
        Me.clmTacGia.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmTacGia.Visible = True
        Me.clmTacGia.VisibleIndex = 3
        Me.clmTacGia.Width = 122
        '
        'clmTheLoai
        '
        Me.clmTheLoai.Caption = "Thể loại"
        Me.clmTheLoai.FieldName = "clmTheLoai"
        Me.clmTheLoai.Name = "clmTheLoai"
        Me.clmTheLoai.OptionsColumn.AllowEdit = False
        Me.clmTheLoai.OptionsColumn.ReadOnly = True
        Me.clmTheLoai.OptionsColumn.TabStop = False
        Me.clmTheLoai.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmTheLoai.Visible = True
        Me.clmTheLoai.VisibleIndex = 4
        Me.clmTheLoai.Width = 91
        '
        'clmSoLuongTon
        '
        Me.clmSoLuongTon.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoLuongTon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoLuongTon.Caption = "Số Lượng Tồn"
        Me.clmSoLuongTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoLuongTon.FieldName = "clmSoLuongTon"
        Me.clmSoLuongTon.Name = "clmSoLuongTon"
        Me.clmSoLuongTon.OptionsColumn.AllowEdit = False
        Me.clmSoLuongTon.OptionsColumn.ReadOnly = True
        Me.clmSoLuongTon.OptionsColumn.TabStop = False
        Me.clmSoLuongTon.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoLuongTon.Visible = True
        Me.clmSoLuongTon.VisibleIndex = 5
        Me.clmSoLuongTon.Width = 90
        '
        'clmDonGiaBanDuKien
        '
        Me.clmDonGiaBanDuKien.Caption = "Đơn Giá Bán Dự Kiến (Đồng)"
        Me.clmDonGiaBanDuKien.DisplayFormat.FormatString = "n0"
        Me.clmDonGiaBanDuKien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmDonGiaBanDuKien.FieldName = "clmDonGiaDuKien"
        Me.clmDonGiaBanDuKien.Name = "clmDonGiaBanDuKien"
        Me.clmDonGiaBanDuKien.OptionsColumn.AllowEdit = False
        Me.clmDonGiaBanDuKien.OptionsColumn.ReadOnly = True
        Me.clmDonGiaBanDuKien.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmDonGiaBanDuKien.Visible = True
        Me.clmDonGiaBanDuKien.VisibleIndex = 6
        '
        'clmSoLuongBan
        '
        Me.clmSoLuongBan.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoLuongBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoLuongBan.Caption = "Tổng Số Lượng Bán"
        Me.clmSoLuongBan.FieldName = "clmTongSoLuongBan"
        Me.clmSoLuongBan.Name = "clmSoLuongBan"
        Me.clmSoLuongBan.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoLuongBan.Visible = True
        Me.clmSoLuongBan.VisibleIndex = 7
        Me.clmSoLuongBan.Width = 108
        '
        'clmTongTienBan
        '
        Me.clmTongTienBan.AppearanceCell.Options.UseTextOptions = True
        Me.clmTongTienBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmTongTienBan.Caption = "Tổng Tiền Bán (Đồng)"
        Me.clmTongTienBan.DisplayFormat.FormatString = "n0"
        Me.clmTongTienBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmTongTienBan.FieldName = "clmTongTienBan"
        Me.clmTongTienBan.Name = "clmTongTienBan"
        Me.clmTongTienBan.OptionsColumn.AllowEdit = False
        Me.clmTongTienBan.OptionsColumn.ReadOnly = True
        Me.clmTongTienBan.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmTongTienBan.Visible = True
        Me.clmTongTienBan.VisibleIndex = 8
        Me.clmTongTienBan.Width = 125
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.Options.UseTextOptions = True
        Me.GroupControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.Grid)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 247)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(865, 314)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Danh sách các đầu sách tra cứu"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupControl2.CaptionImage = CType(resources.GetObject("GroupControl2.CaptionImage"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.btnThoat)
        Me.GroupControl2.Controls.Add(Me.btnToiDaDonGiaBanDuKien)
        Me.GroupControl2.Controls.Add(Me.txtDonGiaDuKienfr)
        Me.GroupControl2.Controls.Add(Me.txtDonGiaDuKiento)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.chkDonGiaDuKien)
        Me.GroupControl2.Controls.Add(Me.btnToiDaTienBan)
        Me.GroupControl2.Controls.Add(Me.btnToiDaSoLuongBan)
        Me.GroupControl2.Controls.Add(Me.btnToiDaSoLuongTon)
        Me.GroupControl2.Controls.Add(Me.cbKieuTenSach)
        Me.GroupControl2.Controls.Add(Me.cbKieuMaSach)
        Me.GroupControl2.Controls.Add(Me.txtTongTienBanfr)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.txtTongTienBanto)
        Me.GroupControl2.Controls.Add(Me.txtNgayBanto)
        Me.GroupControl2.Controls.Add(Me.txtNgayBanfr)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.chkNgayBan)
        Me.GroupControl2.Controls.Add(Me.chkTongTienBan)
        Me.GroupControl2.Controls.Add(Me.txtDonGiaBanfr)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtDonGiaBanto)
        Me.GroupControl2.Controls.Add(Me.txtSoLuongBanfr)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtSoLuongBanto)
        Me.GroupControl2.Controls.Add(Me.txtSoLuongTonfr)
        Me.GroupControl2.Controls.Add(Me.cbTacGia)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.btnTimKiem)
        Me.GroupControl2.Controls.Add(Me.cbTheLoai)
        Me.GroupControl2.Controls.Add(Me.chkDonGiaBan)
        Me.GroupControl2.Controls.Add(Me.chkSoLuongBan)
        Me.GroupControl2.Controls.Add(Me.txtSoLuongTonto)
        Me.GroupControl2.Controls.Add(Me.txtMaSach)
        Me.GroupControl2.Controls.Add(Me.chkSoLuongTon)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtTenSach)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(14, 43)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(865, 198)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Tra cứu:"
        '
        'btnToiDaDonGiaBanDuKien
        '
        Me.btnToiDaDonGiaBanDuKien.Location = New System.Drawing.Point(392, 167)
        Me.btnToiDaDonGiaBanDuKien.Name = "btnToiDaDonGiaBanDuKien"
        Me.btnToiDaDonGiaBanDuKien.Size = New System.Drawing.Size(52, 22)
        Me.btnToiDaDonGiaBanDuKien.TabIndex = 50
        Me.btnToiDaDonGiaBanDuKien.Text = "Tối đa"
        Me.btnToiDaDonGiaBanDuKien.UseVisualStyleBackColor = True
        '
        'txtDonGiaDuKienfr
        '
        Me.txtDonGiaDuKienfr.Location = New System.Drawing.Point(144, 168)
        Me.txtDonGiaDuKienfr.Name = "txtDonGiaDuKienfr"
        Me.txtDonGiaDuKienfr.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDonGiaDuKienfr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDonGiaDuKienfr.Properties.DisplayFormat.FormatString = "n0"
        Me.txtDonGiaDuKienfr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaDuKienfr.Properties.EditFormat.FormatString = "n0"
        Me.txtDonGiaDuKienfr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaDuKienfr.Properties.Mask.EditMask = "n0"
        Me.txtDonGiaDuKienfr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDonGiaDuKienfr.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDonGiaDuKienfr.Size = New System.Drawing.Size(107, 20)
        Me.txtDonGiaDuKienfr.TabIndex = 47
        '
        'txtDonGiaDuKiento
        '
        Me.txtDonGiaDuKiento.Location = New System.Drawing.Point(283, 167)
        Me.txtDonGiaDuKiento.Name = "txtDonGiaDuKiento"
        Me.txtDonGiaDuKiento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDonGiaDuKiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDonGiaDuKiento.Properties.DisplayFormat.FormatString = "n0"
        Me.txtDonGiaDuKiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaDuKiento.Properties.EditFormat.FormatString = "n0"
        Me.txtDonGiaDuKiento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaDuKiento.Properties.Mask.EditMask = "n0"
        Me.txtDonGiaDuKiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDonGiaDuKiento.Size = New System.Drawing.Size(103, 20)
        Me.txtDonGiaDuKiento.TabIndex = 48
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(127, 172)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl10.TabIndex = 49
        Me.LabelControl10.Text = "Từ                                       Đến"
        '
        'chkDonGiaDuKien
        '
        Me.chkDonGiaDuKien.Location = New System.Drawing.Point(6, 168)
        Me.chkDonGiaDuKien.Name = "chkDonGiaDuKien"
        Me.chkDonGiaDuKien.Properties.Caption = "Đơn giá bán dự kiến:"
        Me.chkDonGiaDuKien.Size = New System.Drawing.Size(125, 19)
        Me.chkDonGiaDuKien.TabIndex = 46
        '
        'btnToiDaTienBan
        '
        Me.btnToiDaTienBan.Location = New System.Drawing.Point(392, 143)
        Me.btnToiDaTienBan.Name = "btnToiDaTienBan"
        Me.btnToiDaTienBan.Size = New System.Drawing.Size(52, 22)
        Me.btnToiDaTienBan.TabIndex = 45
        Me.btnToiDaTienBan.Text = "Tối đa"
        Me.btnToiDaTienBan.UseVisualStyleBackColor = True
        '
        'btnToiDaSoLuongBan
        '
        Me.btnToiDaSoLuongBan.Location = New System.Drawing.Point(392, 118)
        Me.btnToiDaSoLuongBan.Name = "btnToiDaSoLuongBan"
        Me.btnToiDaSoLuongBan.Size = New System.Drawing.Size(52, 22)
        Me.btnToiDaSoLuongBan.TabIndex = 44
        Me.btnToiDaSoLuongBan.Text = "Tối đa"
        Me.btnToiDaSoLuongBan.UseVisualStyleBackColor = True
        '
        'btnToiDaSoLuongTon
        '
        Me.btnToiDaSoLuongTon.Location = New System.Drawing.Point(392, 92)
        Me.btnToiDaSoLuongTon.Name = "btnToiDaSoLuongTon"
        Me.btnToiDaSoLuongTon.Size = New System.Drawing.Size(52, 22)
        Me.btnToiDaSoLuongTon.TabIndex = 43
        Me.btnToiDaSoLuongTon.Text = "Tối đa"
        Me.btnToiDaSoLuongTon.UseVisualStyleBackColor = True
        '
        'cbKieuTenSach
        '
        Me.cbKieuTenSach.Location = New System.Drawing.Point(318, 57)
        Me.cbKieuTenSach.Name = "cbKieuTenSach"
        Me.cbKieuTenSach.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuTenSach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuTenSach.Size = New System.Drawing.Size(80, 20)
        Me.cbKieuTenSach.TabIndex = 3
        '
        'cbKieuMaSach
        '
        Me.cbKieuMaSach.Location = New System.Drawing.Point(318, 31)
        Me.cbKieuMaSach.Name = "cbKieuMaSach"
        Me.cbKieuMaSach.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKieuMaSach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbKieuMaSach.Size = New System.Drawing.Size(80, 20)
        Me.cbKieuMaSach.TabIndex = 1
        '
        'txtTongTienBanfr
        '
        Me.txtTongTienBanfr.Location = New System.Drawing.Point(144, 143)
        Me.txtTongTienBanfr.Name = "txtTongTienBanfr"
        Me.txtTongTienBanfr.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongTienBanfr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongTienBanfr.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTongTienBanfr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTongTienBanfr.Properties.EditFormat.FormatString = "n0"
        Me.txtTongTienBanfr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTongTienBanfr.Properties.Mask.EditMask = "n0"
        Me.txtTongTienBanfr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTienBanfr.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTongTienBanfr.Size = New System.Drawing.Size(107, 20)
        Me.txtTongTienBanfr.TabIndex = 13
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(127, 147)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl8.TabIndex = 40
        Me.LabelControl8.Text = "Từ                                       Đến"
        '
        'txtTongTienBanto
        '
        Me.txtTongTienBanto.Location = New System.Drawing.Point(283, 143)
        Me.txtTongTienBanto.Name = "txtTongTienBanto"
        Me.txtTongTienBanto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTongTienBanto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTongTienBanto.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTongTienBanto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTongTienBanto.Properties.EditFormat.FormatString = "n0"
        Me.txtTongTienBanto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTongTienBanto.Properties.Mask.EditMask = "n0"
        Me.txtTongTienBanto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTongTienBanto.Size = New System.Drawing.Size(103, 20)
        Me.txtTongTienBanto.TabIndex = 14
        '
        'txtNgayBanto
        '
        Me.txtNgayBanto.EditValue = Nothing
        Me.txtNgayBanto.Location = New System.Drawing.Point(730, 89)
        Me.txtNgayBanto.Name = "txtNgayBanto"
        Me.txtNgayBanto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayBanto.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayBanto.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayBanto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayBanto.Properties.EditFormat.FormatString = ""
        Me.txtNgayBanto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayBanto.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtNgayBanto.Size = New System.Drawing.Size(107, 20)
        Me.txtNgayBanto.TabIndex = 17
        '
        'txtNgayBanfr
        '
        Me.txtNgayBanfr.EditValue = Nothing
        Me.txtNgayBanfr.Location = New System.Drawing.Point(591, 91)
        Me.txtNgayBanfr.Name = "txtNgayBanfr"
        Me.txtNgayBanfr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayBanfr.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayBanfr.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayBanfr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayBanfr.Properties.EditFormat.FormatString = ""
        Me.txtNgayBanfr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayBanfr.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtNgayBanfr.Size = New System.Drawing.Size(107, 20)
        Me.txtNgayBanfr.TabIndex = 16
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(574, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl9.TabIndex = 35
        Me.LabelControl9.Text = "Từ                                       Đến"
        '
        'chkNgayBan
        '
        Me.chkNgayBan.Location = New System.Drawing.Point(483, 92)
        Me.chkNgayBan.Name = "chkNgayBan"
        Me.chkNgayBan.Properties.Caption = "Ngày bán:"
        Me.chkNgayBan.Size = New System.Drawing.Size(87, 19)
        Me.chkNgayBan.TabIndex = 15
        '
        'chkTongTienBan
        '
        Me.chkTongTienBan.Location = New System.Drawing.Point(6, 143)
        Me.chkTongTienBan.Name = "chkTongTienBan"
        Me.chkTongTienBan.Properties.Caption = "Tổng tiền bán:"
        Me.chkTongTienBan.Size = New System.Drawing.Size(122, 19)
        Me.chkTongTienBan.TabIndex = 12
        '
        'txtDonGiaBanfr
        '
        Me.txtDonGiaBanfr.Location = New System.Drawing.Point(591, 117)
        Me.txtDonGiaBanfr.Name = "txtDonGiaBanfr"
        Me.txtDonGiaBanfr.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDonGiaBanfr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDonGiaBanfr.Properties.DisplayFormat.FormatString = "n0"
        Me.txtDonGiaBanfr.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaBanfr.Properties.EditFormat.FormatString = "n0"
        Me.txtDonGiaBanfr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaBanfr.Properties.Mask.EditMask = "n0"
        Me.txtDonGiaBanfr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDonGiaBanfr.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDonGiaBanfr.Size = New System.Drawing.Size(107, 20)
        Me.txtDonGiaBanfr.TabIndex = 19
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(574, 121)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl7.TabIndex = 27
        Me.LabelControl7.Text = "Từ                                       Đến"
        '
        'txtDonGiaBanto
        '
        Me.txtDonGiaBanto.Location = New System.Drawing.Point(730, 117)
        Me.txtDonGiaBanto.Name = "txtDonGiaBanto"
        Me.txtDonGiaBanto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDonGiaBanto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDonGiaBanto.Properties.DisplayFormat.FormatString = "n0"
        Me.txtDonGiaBanto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaBanto.Properties.EditFormat.FormatString = "n0"
        Me.txtDonGiaBanto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDonGiaBanto.Properties.Mask.EditMask = "n0"
        Me.txtDonGiaBanto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDonGiaBanto.Size = New System.Drawing.Size(107, 20)
        Me.txtDonGiaBanto.TabIndex = 20
        '
        'txtSoLuongBanfr
        '
        Me.txtSoLuongBanfr.Location = New System.Drawing.Point(144, 118)
        Me.txtSoLuongBanfr.Name = "txtSoLuongBanfr"
        Me.txtSoLuongBanfr.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongBanfr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongBanfr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoLuongBanfr.Properties.Mask.EditMask = "d"
        Me.txtSoLuongBanfr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoLuongBanfr.Size = New System.Drawing.Size(107, 20)
        Me.txtSoLuongBanfr.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(127, 121)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Từ                                       Đến"
        '
        'txtSoLuongBanto
        '
        Me.txtSoLuongBanto.Location = New System.Drawing.Point(283, 118)
        Me.txtSoLuongBanto.Name = "txtSoLuongBanto"
        Me.txtSoLuongBanto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongBanto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongBanto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoLuongBanto.Properties.Mask.EditMask = "d"
        Me.txtSoLuongBanto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoLuongBanto.Size = New System.Drawing.Size(103, 20)
        Me.txtSoLuongBanto.TabIndex = 11
        '
        'txtSoLuongTonfr
        '
        Me.txtSoLuongTonfr.Location = New System.Drawing.Point(144, 93)
        Me.txtSoLuongTonfr.Name = "txtSoLuongTonfr"
        Me.txtSoLuongTonfr.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongTonfr.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongTonfr.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoLuongTonfr.Properties.Mask.EditMask = "d"
        Me.txtSoLuongTonfr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoLuongTonfr.Size = New System.Drawing.Size(107, 20)
        Me.txtSoLuongTonfr.TabIndex = 7
        '
        'cbTacGia
        '
        Me.cbTacGia.Location = New System.Drawing.Point(698, 57)
        Me.cbTacGia.Name = "cbTacGia"
        Me.cbTacGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTacGia.Size = New System.Drawing.Size(139, 20)
        Me.cbTacGia.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(127, 97)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Từ                                       Đến"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(654, 60)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Tác giả:"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimKiem.Image = CType(resources.GetObject("btnTimKiem.Image"), System.Drawing.Image)
        Me.btnTimKiem.Location = New System.Drawing.Point(661, 163)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(85, 23)
        Me.btnTimKiem.TabIndex = 17
        Me.btnTimKiem.Text = "Tìm Kiếm"
        '
        'cbTheLoai
        '
        Me.cbTheLoai.Location = New System.Drawing.Point(471, 57)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTheLoai.Size = New System.Drawing.Size(147, 20)
        Me.cbTheLoai.TabIndex = 4
        '
        'chkDonGiaBan
        '
        Me.chkDonGiaBan.Location = New System.Drawing.Point(483, 115)
        Me.chkDonGiaBan.Name = "chkDonGiaBan"
        Me.chkDonGiaBan.Properties.Caption = "Đơn giá bán:"
        Me.chkDonGiaBan.Size = New System.Drawing.Size(87, 19)
        Me.chkDonGiaBan.TabIndex = 18
        '
        'chkSoLuongBan
        '
        Me.chkSoLuongBan.Location = New System.Drawing.Point(6, 118)
        Me.chkSoLuongBan.Name = "chkSoLuongBan"
        Me.chkSoLuongBan.Properties.Caption = "Tổng số lượng bán:"
        Me.chkSoLuongBan.Size = New System.Drawing.Size(115, 19)
        Me.chkSoLuongBan.TabIndex = 9
        '
        'txtSoLuongTonto
        '
        Me.txtSoLuongTonto.Location = New System.Drawing.Point(283, 93)
        Me.txtSoLuongTonto.Name = "txtSoLuongTonto"
        Me.txtSoLuongTonto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongTonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongTonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSoLuongTonto.Properties.Mask.EditMask = "d"
        Me.txtSoLuongTonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSoLuongTonto.Size = New System.Drawing.Size(103, 20)
        Me.txtSoLuongTonto.TabIndex = 8
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(89, 31)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(223, 20)
        Me.txtMaSach.TabIndex = 0
        '
        'chkSoLuongTon
        '
        Me.chkSoLuongTon.Location = New System.Drawing.Point(6, 94)
        Me.chkSoLuongTon.Name = "chkSoLuongTon"
        Me.chkSoLuongTon.Properties.Caption = "Số lượng tồn: "
        Me.chkSoLuongTon.Size = New System.Drawing.Size(87, 19)
        Me.chkSoLuongTon.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(421, 60)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Thể Loại:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(35, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Tên Sách:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(89, 57)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(223, 20)
        Me.txtTenSach.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(35, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Mã Sách:"
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(334, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(220, 31)
        Me.lblMain.TabIndex = 38
        Me.lblMain.Text = "TRA CỨU SÁCH"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnIn)
        Me.PanelControl1.Controls.Add(Me.lblMain)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(889, 576)
        Me.PanelControl1.TabIndex = 1
        '
        'btnIn
        '
        Me.btnIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn.Image = CType(resources.GetObject("btnIn.Image"), System.Drawing.Image)
        Me.btnIn.Location = New System.Drawing.Point(727, 5)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(150, 23)
        Me.btnIn.TabIndex = 46
        Me.btnIn.Text = "Xuất danh sách sách"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(752, 164)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(85, 23)
        Me.btnThoat.TabIndex = 93
        Me.btnThoat.Text = "Thoát"
        '
        'frmTraCuuSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 576)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmTraCuuSachGUI"
        Me.Text = "Tra Cứu Sách"
        CType(Me.gridChiTietBanSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridChiTietNhapSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtDonGiaDuKienfr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDonGiaDuKiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDonGiaDuKien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKieuMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTienBanfr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTongTienBanto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayBanto.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayBanto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayBanfr.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayBanfr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNgayBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTongTienBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDonGiaBanfr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDonGiaBanto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLuongBanfr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLuongBanto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLuongTonfr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDonGiaBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoLuongBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLuongTonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoLuongTon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTenSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTacGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTheLoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongTon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongBan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTongTienBan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents gridChiTietBanSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnToiDaTienBan As Button
    Friend WithEvents btnToiDaSoLuongBan As Button
    Friend WithEvents btnToiDaSoLuongTon As Button
    Friend WithEvents cbKieuTenSach As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbKieuMaSach As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTongTienBanfr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTongTienBanto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNgayBanto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNgayBanfr As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkNgayBan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTongTienBan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDonGiaBanfr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDonGiaBanto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoLuongBanfr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoLuongBanto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoLuongTonfr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbTacGia As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTimKiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTheLoai As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents chkDonGiaBan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSoLuongBan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtSoLuongTonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkSoLuongTon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMain As Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents clmMaHoaDon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmNgayLapHoaDon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDonGiaBan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongBan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmThanhTien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridChiTietNhapSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaPhieuNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmNgayNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents clmDonGiaBanDuKien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkDonGiaDuKien As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDonGiaDuKienfr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDonGiaDuKiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnToiDaDonGiaBanDuKien As Button
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
End Class
