<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChonKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChonKhachHang))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaKhachHang1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmHoTenKhachHang1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDiaChi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmEmail1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDienThoai1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoTienNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmMaKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmHoTenKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDienThoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmDiaChi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmSoTienNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChon = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDienThoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTenKhachHang = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaKhachHang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.ActiveFilterEnabled = False
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaKhachHang1, Me.clmHoTenKhachHang1, Me.clmDiaChi1, Me.clmEmail1, Me.clmDienThoai1, Me.clmSoTienNo1})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'clmMaKhachHang1
        '
        Me.clmMaKhachHang1.Caption = "Mã Khách Hàng"
        Me.clmMaKhachHang1.FieldName = "clmMaKhachHang"
        Me.clmMaKhachHang1.Name = "clmMaKhachHang1"
        Me.clmMaKhachHang1.OptionsColumn.AllowEdit = False
        Me.clmMaKhachHang1.OptionsColumn.ReadOnly = True
        Me.clmMaKhachHang1.Visible = True
        Me.clmMaKhachHang1.VisibleIndex = 0
        Me.clmMaKhachHang1.Width = 87
        '
        'clmHoTenKhachHang1
        '
        Me.clmHoTenKhachHang1.Caption = "Họ Tên Khách Hàng"
        Me.clmHoTenKhachHang1.FieldName = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang1.Name = "clmHoTenKhachHang1"
        Me.clmHoTenKhachHang1.OptionsColumn.AllowEdit = False
        Me.clmHoTenKhachHang1.OptionsColumn.ReadOnly = True
        Me.clmHoTenKhachHang1.Visible = True
        Me.clmHoTenKhachHang1.VisibleIndex = 1
        Me.clmHoTenKhachHang1.Width = 133
        '
        'clmDiaChi1
        '
        Me.clmDiaChi1.Caption = "Địa Chỉ"
        Me.clmDiaChi1.FieldName = "clmDiaChi"
        Me.clmDiaChi1.Name = "clmDiaChi1"
        Me.clmDiaChi1.OptionsColumn.AllowEdit = False
        Me.clmDiaChi1.OptionsColumn.ReadOnly = True
        Me.clmDiaChi1.Visible = True
        Me.clmDiaChi1.VisibleIndex = 2
        Me.clmDiaChi1.Width = 143
        '
        'clmEmail1
        '
        Me.clmEmail1.Caption = "Email"
        Me.clmEmail1.FieldName = "clmEmail"
        Me.clmEmail1.Name = "clmEmail1"
        Me.clmEmail1.OptionsColumn.AllowEdit = False
        Me.clmEmail1.OptionsColumn.ReadOnly = True
        Me.clmEmail1.Visible = True
        Me.clmEmail1.VisibleIndex = 3
        Me.clmEmail1.Width = 152
        '
        'clmDienThoai1
        '
        Me.clmDienThoai1.Caption = "Điện Thoại"
        Me.clmDienThoai1.FieldName = "clmDienThoai"
        Me.clmDienThoai1.Name = "clmDienThoai1"
        Me.clmDienThoai1.OptionsColumn.AllowEdit = False
        Me.clmDienThoai1.OptionsColumn.ReadOnly = True
        Me.clmDienThoai1.Visible = True
        Me.clmDienThoai1.VisibleIndex = 4
        Me.clmDienThoai1.Width = 131
        '
        'clmSoTienNo1
        '
        Me.clmSoTienNo1.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoTienNo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoTienNo1.Caption = "Số Tiền Nợ"
        Me.clmSoTienNo1.DisplayFormat.FormatString = "n0"
        Me.clmSoTienNo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoTienNo1.FieldName = "clmSoTienNo"
        Me.clmSoTienNo1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoTienNo1.Name = "clmSoTienNo1"
        Me.clmSoTienNo1.OptionsColumn.AllowEdit = False
        Me.clmSoTienNo1.OptionsColumn.ReadOnly = True
        Me.clmSoTienNo1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoTienNo1.Visible = True
        Me.clmSoTienNo1.VisibleIndex = 5
        Me.clmSoTienNo1.Width = 117
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
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.Grid.Size = New System.Drawing.Size(781, 270)
        Me.Grid.TabIndex = 27
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView, Me.GridView1})
        '
        'GridView
        '
        Me.GridView.ActiveFilterEnabled = False
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmMaKhachHang, Me.clmHoTenKhachHang, Me.clmEmail, Me.clmDienThoai, Me.clmDiaChi, Me.clmSoTienNo})
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsCustomization.AllowFilter = False
        Me.GridView.OptionsCustomization.AllowSort = False
        Me.GridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView.OptionsMenu.EnableColumnMenu = False
        Me.GridView.OptionsMenu.EnableFooterMenu = False
        Me.GridView.OptionsMenu.ShowAutoFilterRowItem = False
        Me.GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView.OptionsSelection.CheckBoxSelectorColumnWidth = 40
        Me.GridView.OptionsSelection.MultiSelect = True
        Me.GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView.OptionsView.ShowGroupPanel = False
        '
        'clmMaKhachHang
        '
        Me.clmMaKhachHang.Caption = "Mã Khách Hàng"
        Me.clmMaKhachHang.FieldName = "clmMaKhachHang"
        Me.clmMaKhachHang.Name = "clmMaKhachHang"
        Me.clmMaKhachHang.OptionsColumn.AllowEdit = False
        Me.clmMaKhachHang.OptionsColumn.ReadOnly = True
        Me.clmMaKhachHang.OptionsEditForm.StartNewRow = True
        Me.clmMaKhachHang.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmMaKhachHang.Visible = True
        Me.clmMaKhachHang.VisibleIndex = 1
        Me.clmMaKhachHang.Width = 84
        '
        'clmHoTenKhachHang
        '
        Me.clmHoTenKhachHang.Caption = "Họ Tên Khách Hàng"
        Me.clmHoTenKhachHang.FieldName = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang.Name = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang.OptionsColumn.AllowEdit = False
        Me.clmHoTenKhachHang.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.clmHoTenKhachHang.OptionsColumn.ReadOnly = True
        Me.clmHoTenKhachHang.OptionsEditForm.StartNewRow = True
        Me.clmHoTenKhachHang.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.clmHoTenKhachHang.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmHoTenKhachHang.Visible = True
        Me.clmHoTenKhachHang.VisibleIndex = 2
        Me.clmHoTenKhachHang.Width = 180
        '
        'clmEmail
        '
        Me.clmEmail.Caption = "Email"
        Me.clmEmail.FieldName = "clmEmail"
        Me.clmEmail.Name = "clmEmail"
        Me.clmEmail.OptionsColumn.AllowEdit = False
        Me.clmEmail.OptionsColumn.ReadOnly = True
        Me.clmEmail.OptionsColumn.TabStop = False
        Me.clmEmail.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmEmail.Visible = True
        Me.clmEmail.VisibleIndex = 4
        Me.clmEmail.Width = 124
        '
        'clmDienThoai
        '
        Me.clmDienThoai.Caption = "Điện Thoại"
        Me.clmDienThoai.FieldName = "clmDienThoai"
        Me.clmDienThoai.Name = "clmDienThoai"
        Me.clmDienThoai.OptionsColumn.AllowEdit = False
        Me.clmDienThoai.OptionsColumn.ReadOnly = True
        Me.clmDienThoai.OptionsColumn.TabStop = False
        Me.clmDienThoai.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmDienThoai.Visible = True
        Me.clmDienThoai.VisibleIndex = 5
        Me.clmDienThoai.Width = 96
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
        Me.clmDiaChi.Width = 118
        '
        'clmSoTienNo
        '
        Me.clmSoTienNo.AppearanceCell.Options.UseTextOptions = True
        Me.clmSoTienNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmSoTienNo.Caption = "Số Tiền Nợ"
        Me.clmSoTienNo.DisplayFormat.FormatString = "n0"
        Me.clmSoTienNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmSoTienNo.FieldName = "clmSoTienNo"
        Me.clmSoTienNo.Name = "clmSoTienNo"
        Me.clmSoTienNo.OptionsColumn.AllowEdit = False
        Me.clmSoTienNo.OptionsColumn.ReadOnly = True
        Me.clmSoTienNo.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmSoTienNo.Visible = True
        Me.clmSoTienNo.VisibleIndex = 6
        Me.clmSoTienNo.Width = 121
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
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
        Me.lblMain.Location = New System.Drawing.Point(243, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(293, 31)
        Me.lblMain.TabIndex = 39
        Me.lblMain.Text = "CHỌN KHÁCH HÀNG"
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
        Me.Panel1.Size = New System.Drawing.Size(807, 500)
        Me.Panel1.TabIndex = 29
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
        'GroupControl1
        '
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.txtDienThoai)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtHoTenKhachHang)
        Me.GroupControl1.Controls.Add(Me.txtMaKhachHang)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 43)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(785, 87)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Tìm kiếm sách:"
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(108, 58)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(214, 20)
        Me.txtDienThoai.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Điện thoại:"
        '
        'txtHoTenKhachHang
        '
        Me.txtHoTenKhachHang.Location = New System.Drawing.Point(467, 32)
        Me.txtHoTenKhachHang.Name = "txtHoTenKhachHang"
        Me.txtHoTenKhachHang.Size = New System.Drawing.Size(214, 20)
        Me.txtHoTenKhachHang.TabIndex = 3
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Location = New System.Drawing.Point(108, 32)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(214, 20)
        Me.txtMaKhachHang.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(381, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên khách hàng:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã khách hàng:"
        '
        'frmChonKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmChonKhachHang"
        Me.Text = "Chọn Khách Hàng"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDienThoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTenKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaKhachHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMain As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaKhachHang1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmHoTenKhachHang1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDiaChi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmEmail1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDienThoai1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtHoTenKhachHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaKhachHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents clmSoTienNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmMaKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmHoTenKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDienThoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDiaChi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmSoTienNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDienThoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
