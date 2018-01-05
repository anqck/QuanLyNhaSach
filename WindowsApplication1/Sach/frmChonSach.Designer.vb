<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChonSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChonSach))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaSach1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTenSach1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTacGia1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTheLoai1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongTon1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.clmMaSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTenSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTacGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTheLoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoLuongTon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbTacGia = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTheLoai = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenSach = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaSach = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChon = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDonGiaDuKien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDonGiaDuKien1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterEnabled = False
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaSach1, Me.clmTenSach1, Me.clmTacGia1, Me.clmTheLoai1, Me.clmSoLuongTon1, Me.clmDonGiaDuKien1})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'clmMaSach1
        '
        Me.clmMaSach1.Caption = "Mã Sách"
        Me.clmMaSach1.FieldName = "clmMaSach"
        Me.clmMaSach1.Name = "clmMaSach1"
        Me.clmMaSach1.OptionsColumn.AllowEdit = False
        Me.clmMaSach1.OptionsColumn.ReadOnly = True
        Me.clmMaSach1.Visible = True
        Me.clmMaSach1.VisibleIndex = 0
        '
        'clmTenSach1
        '
        Me.clmTenSach1.Caption = "Tên Sách"
        Me.clmTenSach1.FieldName = "clmTenSach"
        Me.clmTenSach1.Name = "clmTenSach1"
        Me.clmTenSach1.OptionsColumn.AllowEdit = False
        Me.clmTenSach1.OptionsColumn.ReadOnly = True
        Me.clmTenSach1.Visible = True
        Me.clmTenSach1.VisibleIndex = 1
        '
        'clmTacGia1
        '
        Me.clmTacGia1.Caption = "Tác Giả"
        Me.clmTacGia1.FieldName = "clmTacGia"
        Me.clmTacGia1.Name = "clmTacGia1"
        Me.clmTacGia1.OptionsColumn.AllowEdit = False
        Me.clmTacGia1.OptionsColumn.ReadOnly = True
        Me.clmTacGia1.Visible = True
        Me.clmTacGia1.VisibleIndex = 2
        '
        'clmTheLoai1
        '
        Me.clmTheLoai1.Caption = "Thể Loại"
        Me.clmTheLoai1.FieldName = "clmTheLoai"
        Me.clmTheLoai1.Name = "clmTheLoai1"
        Me.clmTheLoai1.OptionsColumn.AllowEdit = False
        Me.clmTheLoai1.OptionsColumn.ReadOnly = True
        Me.clmTheLoai1.Visible = True
        Me.clmTheLoai1.VisibleIndex = 3
        '
        'clmSoLuongTon1
        '
        Me.clmSoLuongTon1.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoLuongTon1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoLuongTon1.Caption = "Số Lượng Tồn"
        Me.clmSoLuongTon1.FieldName = "clmSoLuongTon"
        Me.clmSoLuongTon1.Name = "clmSoLuongTon1"
        Me.clmSoLuongTon1.OptionsColumn.AllowEdit = False
        Me.clmSoLuongTon1.OptionsColumn.ReadOnly = True
        Me.clmSoLuongTon1.Visible = True
        Me.clmSoLuongTon1.VisibleIndex = 4
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView1
        GridLevelNode1.RelationName = "DisableMultiSelect"
        Me.Grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid.Location = New System.Drawing.Point(2, 23)
        Me.Grid.MainView = Me.GridView
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemCheckEdit1})
        Me.Grid.Size = New System.Drawing.Size(781, 270)
        Me.Grid.TabIndex = 27
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView, Me.GridView1})
        '
        'GridView
        '
        Me.GridView.ActiveFilterEnabled = False
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSelect, Me.clmMaSach, Me.clmTenSach, Me.clmTacGia, Me.clmTheLoai, Me.clmSoLuongTon, Me.clmDonGiaDuKien})
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GridView.OptionsCustomization.AllowFilter = False
        Me.GridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView.OptionsMenu.EnableColumnMenu = False
        Me.GridView.OptionsMenu.EnableFooterMenu = False
        Me.GridView.OptionsMenu.ShowAutoFilterRowItem = False
        Me.GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView.OptionsSelection.CheckBoxSelectorColumnWidth = 40
        Me.GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'clmSelect
        '
        Me.clmSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.clmSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmSelect.Caption = "Chọn"
        Me.clmSelect.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.clmSelect.FieldName = "clmSelect"
        Me.clmSelect.Name = "clmSelect"
        Me.clmSelect.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmSelect.Visible = True
        Me.clmSelect.VisibleIndex = 0
        Me.clmSelect.Width = 39
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
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
        Me.clmMaSach.Width = 90
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
        Me.clmTenSach.Width = 200
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
        Me.clmTacGia.Width = 117
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
        Me.clmSoLuongTon.Caption = "Số Lượng Tồn"
        Me.clmSoLuongTon.FieldName = "clmSoLuongTon"
        Me.clmSoLuongTon.Name = "clmSoLuongTon"
        Me.clmSoLuongTon.OptionsColumn.AllowEdit = False
        Me.clmSoLuongTon.OptionsColumn.ReadOnly = True
        Me.clmSoLuongTon.Visible = True
        Me.clmSoLuongTon.VisibleIndex = 5
        Me.clmSoLuongTon.Width = 85
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.cbTacGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cbTheLoai)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtTenSach)
        Me.GroupControl1.Controls.Add(Me.txtMaSach)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 43)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(785, 87)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Tìm kiếm sách:"
        '
        'cbTacGia
        '
        Me.cbTacGia.Location = New System.Drawing.Point(586, 58)
        Me.cbTacGia.Name = "cbTacGia"
        Me.cbTacGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTacGia.Size = New System.Drawing.Size(159, 20)
        Me.cbTacGia.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(525, 61)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Tác giả:"
        '
        'cbTheLoai
        '
        Me.cbTheLoai.Location = New System.Drawing.Point(358, 58)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTheLoai.Size = New System.Drawing.Size(136, 20)
        Me.cbTheLoai.TabIndex = 21
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(308, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Thể Loại:"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(75, 58)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.Size = New System.Drawing.Size(180, 20)
        Me.txtTenSach.TabIndex = 3
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(75, 32)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(180, 20)
        Me.txtMaSach.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên sách:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã sách:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnHuy)
        Me.Panel1.Controls.Add(Me.btnChon)
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Controls.Add(Me.GroupControl2)
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 475)
        Me.Panel1.TabIndex = 28
        '
        'btnHuy
        '
        Me.btnHuy.Image = CType(resources.GetObject("btnHuy.Image"), System.Drawing.Image)
        Me.btnHuy.Location = New System.Drawing.Point(618, 440)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(75, 23)
        Me.btnHuy.TabIndex = 41
        Me.btnHuy.Text = "Hủy"
        '
        'btnChon
        '
        Me.btnChon.Image = CType(resources.GetObject("btnChon.Image"), System.Drawing.Image)
        Me.btnChon.Location = New System.Drawing.Point(701, 440)
        Me.btnChon.Name = "btnChon"
        Me.btnChon.Size = New System.Drawing.Size(75, 23)
        Me.btnChon.TabIndex = 40
        Me.btnChon.Text = "Chọn"
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(314, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(178, 31)
        Me.lblMain.TabIndex = 39
        Me.lblMain.Text = "CHỌN SÁCH"
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImage = CType(resources.GetObject("GroupControl2.CaptionImage"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.Grid)
        Me.GroupControl2.Location = New System.Drawing.Point(10, 136)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(785, 295)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Danh sách sách:"
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        '
        'clmDonGiaDuKien
        '
        Me.clmDonGiaDuKien.AppearanceCell.Options.UseTextOptions = True
        Me.clmDonGiaDuKien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmDonGiaDuKien.Caption = "Đơn Giá Dự Kiến"
        Me.clmDonGiaDuKien.DisplayFormat.FormatString = "n0"
        Me.clmDonGiaDuKien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmDonGiaDuKien.FieldName = "clmDonGiaDuKien"
        Me.clmDonGiaDuKien.Name = "clmDonGiaDuKien"
        Me.clmDonGiaDuKien.OptionsColumn.AllowEdit = False
        Me.clmDonGiaDuKien.OptionsColumn.ReadOnly = True
        Me.clmDonGiaDuKien.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmDonGiaDuKien.Visible = True
        Me.clmDonGiaDuKien.VisibleIndex = 6
        Me.clmDonGiaDuKien.Width = 92
        '
        'clmDonGiaDuKien1
        '
        Me.clmDonGiaDuKien1.AppearanceCell.Options.UseTextOptions = True
        Me.clmDonGiaDuKien1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmDonGiaDuKien1.Caption = "Đơn Giá Dự Kiến"
        Me.clmDonGiaDuKien1.DisplayFormat.FormatString = "n0"
        Me.clmDonGiaDuKien1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmDonGiaDuKien1.FieldName = "clmDonGiaDuKien"
        Me.clmDonGiaDuKien1.Name = "clmDonGiaDuKien1"
        Me.clmDonGiaDuKien1.OptionsColumn.AllowEdit = False
        Me.clmDonGiaDuKien1.OptionsColumn.ReadOnly = True
        Me.clmDonGiaDuKien1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmDonGiaDuKien1.Visible = True
        Me.clmDonGiaDuKien1.VisibleIndex = 5
        '
        'frmChonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 475)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmChonSach"
        Me.Text = "Chọn Sách"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaSach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTenSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents clmTacGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTheLoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTenSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaSach As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTacGia As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTheLoai As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents clmSoLuongTon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblMain As Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaSach1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTenSach1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTacGia1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTheLoai1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoLuongTon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnChon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clmSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents clmDonGiaDuKien1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDonGiaDuKien As DevExpress.XtraGrid.Columns.GridColumn
End Class
