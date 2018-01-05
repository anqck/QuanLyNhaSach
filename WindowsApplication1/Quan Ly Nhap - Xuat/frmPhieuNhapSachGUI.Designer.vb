<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhieuNhapSachGUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuNhapSachGUI))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTenSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.clmTacGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTheLoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongTon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMaPhieuNhap = New DevExpress.XtraEditors.TextEdit()
        Me.lblMaPhieuNhap = New System.Windows.Forms.Label()
        Me.lblNgayNhap = New System.Windows.Forms.Label()
        Me.grpQuyDinh = New DevExpress.XtraEditors.GroupControl()
        Me.btnThayDoiQuyDinh = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSoLuongTonToiDa = New DevExpress.XtraEditors.TextEdit()
        Me.txtSoLuongNhapToiThieu = New DevExpress.XtraEditors.TextEdit()
        Me.lblSoLuongNhapToiThieu = New System.Windows.Forms.Label()
        Me.lblSoLuongNhapToiDa = New System.Windows.Forms.Label()
        Me.dateNgayNhap = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnChonSach = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnTaoMoi = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtMaPhieuNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpQuyDinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuyDinh.SuspendLayout()
        CType(Me.txtSoLuongTonToiDa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoLuongNhapToiThieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNgayNhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNgayNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 241)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(605, 163)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(467, 241)
        Me.PanelControl2.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(2, 23)
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.Grid.Size = New System.Drawing.Size(797, 255)
        Me.Grid.TabIndex = 26
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSTT, Me.clmMaSach, Me.clmTenSach, Me.clmTacGia, Me.clmTheLoai, Me.clmSoLuongTon, Me.clmSoLuongNhap})
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsCustomization.AllowFilter = False
        Me.GridView.OptionsCustomization.AllowSort = False
        Me.GridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'clmSTT
        '
        Me.clmSTT.AppearanceCell.BackColor = System.Drawing.SystemColors.Menu
        Me.clmSTT.AppearanceCell.Options.UseBackColor = True
        Me.clmSTT.Caption = "STT"
        Me.clmSTT.FieldName = "clmSTT"
        Me.clmSTT.Name = "clmSTT"
        Me.clmSTT.OptionsColumn.AllowEdit = False
        Me.clmSTT.OptionsColumn.ReadOnly = True
        Me.clmSTT.OptionsColumn.TabStop = False
        Me.clmSTT.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSTT.Visible = True
        Me.clmSTT.VisibleIndex = 0
        Me.clmSTT.Width = 43
        '
        'clmMaSach
        '
        Me.clmMaSach.Caption = "Mã Sách"
        Me.clmMaSach.FieldName = "clmMaSach"
        Me.clmMaSach.Name = "clmMaSach"
        Me.clmMaSach.OptionsEditForm.StartNewRow = True
        Me.clmMaSach.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmMaSach.Visible = True
        Me.clmMaSach.VisibleIndex = 1
        Me.clmMaSach.Width = 84
        '
        'clmTenSach
        '
        Me.clmTenSach.Caption = "Tên Sách"
        Me.clmTenSach.ColumnEdit = Me.RepositoryItemComboBox1
        Me.clmTenSach.FieldName = "clmTenSach"
        Me.clmTenSach.Name = "clmTenSach"
        Me.clmTenSach.OptionsEditForm.StartNewRow = True
        Me.clmTenSach.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmTenSach.Visible = True
        Me.clmTenSach.VisibleIndex = 2
        Me.clmTenSach.Width = 181
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        Me.clmTacGia.Width = 110
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
        Me.clmTheLoai.Width = 140
        '
        'clmSoLuongTon
        '
        Me.clmSoLuongTon.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoLuongTon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoLuongTon.Caption = "Số lượng tồn"
        Me.clmSoLuongTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoLuongTon.FieldName = "clmSoLuongTon"
        Me.clmSoLuongTon.Name = "clmSoLuongTon"
        Me.clmSoLuongTon.OptionsColumn.AllowEdit = False
        Me.clmSoLuongTon.OptionsColumn.ReadOnly = True
        Me.clmSoLuongTon.OptionsColumn.TabStop = False
        Me.clmSoLuongTon.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoLuongTon.Visible = True
        Me.clmSoLuongTon.VisibleIndex = 5
        Me.clmSoLuongTon.Width = 107
        '
        'clmSoLuongNhap
        '
        Me.clmSoLuongNhap.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoLuongNhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoLuongNhap.Caption = "Số lượng nhập"
        Me.clmSoLuongNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoLuongNhap.FieldName = "clmSoLuongNhap"
        Me.clmSoLuongNhap.Name = "clmSoLuongNhap"
        Me.clmSoLuongNhap.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoLuongNhap.Visible = True
        Me.clmSoLuongNhap.VisibleIndex = 6
        Me.clmSoLuongNhap.Width = 93
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnIn)
        Me.PanelControl3.Controls.Add(Me.txtMaPhieuNhap)
        Me.PanelControl3.Controls.Add(Me.lblMaPhieuNhap)
        Me.PanelControl3.Controls.Add(Me.lblNgayNhap)
        Me.PanelControl3.Controls.Add(Me.grpQuyDinh)
        Me.PanelControl3.Controls.Add(Me.dateNgayNhap)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.btnChonSach)
        Me.PanelControl3.Controls.Add(Me.btnDelete)
        Me.PanelControl3.Controls.Add(Me.btnThoat)
        Me.PanelControl3.Controls.Add(Me.lblMain)
        Me.PanelControl3.Controls.Add(Me.btnTaoMoi)
        Me.PanelControl3.Controls.Add(Me.btnLuu)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(825, 512)
        Me.PanelControl3.TabIndex = 27
        '
        'btnIn
        '
        Me.btnIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIn.Image = CType(resources.GetObject("btnIn.Image"), System.Drawing.Image)
        Me.btnIn.Location = New System.Drawing.Point(630, 482)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(85, 23)
        Me.btnIn.TabIndex = 90
        Me.btnIn.Text = "Xuất"
        '
        'txtMaPhieuNhap
        '
        Me.txtMaPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMaPhieuNhap.Location = New System.Drawing.Point(161, 51)
        Me.txtMaPhieuNhap.Name = "txtMaPhieuNhap"
        Me.txtMaPhieuNhap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMaPhieuNhap.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtMaPhieuNhap.Properties.Appearance.Options.UseFont = True
        Me.txtMaPhieuNhap.Properties.Appearance.Options.UseForeColor = True
        Me.txtMaPhieuNhap.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMaPhieuNhap.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMaPhieuNhap.Properties.ReadOnly = True
        Me.txtMaPhieuNhap.Size = New System.Drawing.Size(264, 20)
        Me.txtMaPhieuNhap.TabIndex = 89
        '
        'lblMaPhieuNhap
        '
        Me.lblMaPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMaPhieuNhap.AutoSize = True
        Me.lblMaPhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaPhieuNhap.Location = New System.Drawing.Point(46, 54)
        Me.lblMaPhieuNhap.Name = "lblMaPhieuNhap"
        Me.lblMaPhieuNhap.Size = New System.Drawing.Size(113, 16)
        Me.lblMaPhieuNhap.TabIndex = 82
        Me.lblMaPhieuNhap.Text = "Mã phiếu nhập:"
        '
        'lblNgayNhap
        '
        Me.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNgayNhap.AutoSize = True
        Me.lblNgayNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgayNhap.Location = New System.Drawing.Point(458, 54)
        Me.lblNgayNhap.Name = "lblNgayNhap"
        Me.lblNgayNhap.Size = New System.Drawing.Size(87, 16)
        Me.lblNgayNhap.TabIndex = 84
        Me.lblNgayNhap.Text = "Ngày nhập:"
        '
        'grpQuyDinh
        '
        Me.grpQuyDinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpQuyDinh.CaptionImage = CType(resources.GetObject("grpQuyDinh.CaptionImage"), System.Drawing.Image)
        Me.grpQuyDinh.Controls.Add(Me.btnThayDoiQuyDinh)
        Me.grpQuyDinh.Controls.Add(Me.txtSoLuongTonToiDa)
        Me.grpQuyDinh.Controls.Add(Me.txtSoLuongNhapToiThieu)
        Me.grpQuyDinh.Controls.Add(Me.lblSoLuongNhapToiThieu)
        Me.grpQuyDinh.Controls.Add(Me.lblSoLuongNhapToiDa)
        Me.grpQuyDinh.Location = New System.Drawing.Point(12, 92)
        Me.grpQuyDinh.Name = "grpQuyDinh"
        Me.grpQuyDinh.Size = New System.Drawing.Size(794, 100)
        Me.grpQuyDinh.TabIndex = 73
        Me.grpQuyDinh.Text = "Quy định:"
        '
        'btnThayDoiQuyDinh
        '
        Me.btnThayDoiQuyDinh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnThayDoiQuyDinh.Image = CType(resources.GetObject("btnThayDoiQuyDinh.Image"), System.Drawing.Image)
        Me.btnThayDoiQuyDinh.Location = New System.Drawing.Point(626, 58)
        Me.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh"
        Me.btnThayDoiQuyDinh.Size = New System.Drawing.Size(119, 23)
        Me.btnThayDoiQuyDinh.TabIndex = 88
        Me.btnThayDoiQuyDinh.Text = "Thay đổi quy định"
        '
        'txtSoLuongTonToiDa
        '
        Me.txtSoLuongTonToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSoLuongTonToiDa.Location = New System.Drawing.Point(324, 60)
        Me.txtSoLuongTonToiDa.Name = "txtSoLuongTonToiDa"
        Me.txtSoLuongTonToiDa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSoLuongTonToiDa.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSoLuongTonToiDa.Properties.Appearance.Options.UseFont = True
        Me.txtSoLuongTonToiDa.Properties.Appearance.Options.UseForeColor = True
        Me.txtSoLuongTonToiDa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongTonToiDa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongTonToiDa.Properties.ReadOnly = True
        Me.txtSoLuongTonToiDa.Size = New System.Drawing.Size(279, 20)
        Me.txtSoLuongTonToiDa.TabIndex = 82
        '
        'txtSoLuongNhapToiThieu
        '
        Me.txtSoLuongNhapToiThieu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSoLuongNhapToiThieu.Location = New System.Drawing.Point(324, 34)
        Me.txtSoLuongNhapToiThieu.Name = "txtSoLuongNhapToiThieu"
        Me.txtSoLuongNhapToiThieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSoLuongNhapToiThieu.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtSoLuongNhapToiThieu.Properties.Appearance.Options.UseFont = True
        Me.txtSoLuongNhapToiThieu.Properties.Appearance.Options.UseForeColor = True
        Me.txtSoLuongNhapToiThieu.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSoLuongNhapToiThieu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSoLuongNhapToiThieu.Properties.ReadOnly = True
        Me.txtSoLuongNhapToiThieu.Size = New System.Drawing.Size(279, 20)
        Me.txtSoLuongNhapToiThieu.TabIndex = 81
        '
        'lblSoLuongNhapToiThieu
        '
        Me.lblSoLuongNhapToiThieu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSoLuongNhapToiThieu.AutoSize = True
        Me.lblSoLuongNhapToiThieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuongNhapToiThieu.Location = New System.Drawing.Point(130, 38)
        Me.lblSoLuongNhapToiThieu.Name = "lblSoLuongNhapToiThieu"
        Me.lblSoLuongNhapToiThieu.Size = New System.Drawing.Size(169, 16)
        Me.lblSoLuongNhapToiThieu.TabIndex = 79
        Me.lblSoLuongNhapToiThieu.Text = "Số lượng nhập tối thiểu:"
        '
        'lblSoLuongNhapToiDa
        '
        Me.lblSoLuongNhapToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSoLuongNhapToiDa.AutoSize = True
        Me.lblSoLuongNhapToiDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoLuongNhapToiDa.Location = New System.Drawing.Point(158, 64)
        Me.lblSoLuongNhapToiDa.Name = "lblSoLuongNhapToiDa"
        Me.lblSoLuongNhapToiDa.Size = New System.Drawing.Size(141, 16)
        Me.lblSoLuongNhapToiDa.TabIndex = 80
        Me.lblSoLuongNhapToiDa.Text = "Số lượng tồn tối đa:"
        '
        'dateNgayNhap
        '
        Me.dateNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dateNgayNhap.EditValue = Nothing
        Me.dateNgayNhap.Location = New System.Drawing.Point(551, 53)
        Me.dateNgayNhap.Name = "dateNgayNhap"
        Me.dateNgayNhap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNgayNhap.Properties.Mask.EditMask = " dd.MM.yyyy"
        Me.dateNgayNhap.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dateNgayNhap.Size = New System.Drawing.Size(255, 20)
        Me.dateNgayNhap.TabIndex = 85
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.CaptionImage = CType(resources.GetObject("GroupControl2.CaptionImage"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.Grid)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 198)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(801, 280)
        Me.GroupControl2.TabIndex = 72
        Me.GroupControl2.Text = "Chi tiết phiếu nhập sách:"
        '
        'btnChonSach
        '
        Me.btnChonSach.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChonSach.Image = CType(resources.GetObject("btnChonSach.Image"), System.Drawing.Image)
        Me.btnChonSach.Location = New System.Drawing.Point(14, 484)
        Me.btnChonSach.Name = "btnChonSach"
        Me.btnChonSach.Size = New System.Drawing.Size(128, 23)
        Me.btnChonSach.TabIndex = 70
        Me.btnChonSach.Text = "Chọn sách"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(148, 484)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 23)
        Me.btnDelete.TabIndex = 69
        Me.btnDelete.Text = "Xóa dòng đã chọn"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(721, 482)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(85, 23)
        Me.btnThoat.TabIndex = 68
        Me.btnThoat.Text = "Thoát"
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(259, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(325, 31)
        Me.lblMain.TabIndex = 57
        Me.lblMain.Text = "LẬP PHIẾU NHẬP SÁCH"
        '
        'btnTaoMoi
        '
        Me.btnTaoMoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTaoMoi.Image = CType(resources.GetObject("btnTaoMoi.Image"), System.Drawing.Image)
        Me.btnTaoMoi.Location = New System.Drawing.Point(448, 482)
        Me.btnTaoMoi.Name = "btnTaoMoi"
        Me.btnTaoMoi.Size = New System.Drawing.Size(85, 23)
        Me.btnTaoMoi.TabIndex = 67
        Me.btnTaoMoi.Text = "Tạo mới"
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(539, 482)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(85, 23)
        Me.btnLuu.TabIndex = 66
        Me.btnLuu.Text = "Lưu"
        '
        'frmPhieuNhapSachGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 512)
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "frmPhieuNhapSachGUI"
        Me.Text = "Phiếu Nhập Sách"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtMaPhieuNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpQuyDinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuyDinh.ResumeLayout(False)
        Me.grpQuyDinh.PerformLayout()
        CType(Me.txtSoLuongTonToiDa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoLuongNhapToiThieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNgayNhap.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNgayNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTenSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTacGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTheLoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongTon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMain As Label
    Friend WithEvents btnTaoMoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChonSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSoLuongNhapToiThieu As Label
    Friend WithEvents lblSoLuongNhapToiDa As Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblMaPhieuNhap As Label
    Friend WithEvents lblNgayNhap As Label
    Friend WithEvents grpQuyDinh As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dateNgayNhap As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSoLuongNhapToiThieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoLuongTonToiDa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnThayDoiQuyDinh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaPhieuNhap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
End Class
