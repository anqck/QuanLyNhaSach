<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoTonGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLapBaoCaoTonGUI))
        Me.lblMain = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnXuatBaoCao = New DevExpress.XtraEditors.SimpleButton()
        Me.grpChiTietHoaDon = New DevExpress.XtraEditors.GroupControl()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTenSach = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.clmTacGia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTheLoai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTonDau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTonPhatSinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTonCuoi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnLapBaoCaoTon = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dateThangBaoCao = New DevExpress.XtraEditors.DateEdit()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.WindowsApplication1.WaitForm1), True, True)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpChiTietHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChiTietHoaDon.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateThangBaoCao.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateThangBaoCao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(423, 11)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(258, 38)
        Me.lblMain.TabIndex = 24
        Me.lblMain.Text = "BÁO CÁO TỒN"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnXuatBaoCao)
        Me.PanelControl1.Controls.Add(Me.grpChiTietHoaDon)
        Me.PanelControl1.Controls.Add(Me.btnLapBaoCaoTon)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.dateThangBaoCao)
        Me.PanelControl1.Controls.Add(Me.lblMain)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1087, 571)
        Me.PanelControl1.TabIndex = 26
        '
        'btnXuatBaoCao
        '
        Me.btnXuatBaoCao.ImageOptions.Image = CType(resources.GetObject("btnXuatBaoCao.ImageOptions.Image"), System.Drawing.Image)
        Me.btnXuatBaoCao.Location = New System.Drawing.Point(819, 96)
        Me.btnXuatBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnXuatBaoCao.Name = "btnXuatBaoCao"
        Me.btnXuatBaoCao.Size = New System.Drawing.Size(143, 28)
        Me.btnXuatBaoCao.TabIndex = 77
        Me.btnXuatBaoCao.Text = "Xuất báo cáo"
        '
        'grpChiTietHoaDon
        '
        Me.grpChiTietHoaDon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChiTietHoaDon.CaptionImageOptions.Image = CType(resources.GetObject("grpChiTietHoaDon.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpChiTietHoaDon.Controls.Add(Me.Grid)
        Me.grpChiTietHoaDon.Location = New System.Drawing.Point(16, 155)
        Me.grpChiTietHoaDon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpChiTietHoaDon.Name = "grpChiTietHoaDon"
        Me.grpChiTietHoaDon.Size = New System.Drawing.Size(1055, 401)
        Me.grpChiTietHoaDon.TabIndex = 76
        Me.grpChiTietHoaDon.Text = "Chi Tiết Báo Cáo Tồn:"
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Grid.Location = New System.Drawing.Point(2, 25)
        Me.Grid.MainView = Me.GridView
        Me.Grid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.Grid.Size = New System.Drawing.Size(1051, 374)
        Me.Grid.TabIndex = 77
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSTT, Me.clmMaSach, Me.clmTenSach, Me.clmTacGia, Me.clmTheLoai, Me.clmTonDau, Me.clmTonPhatSinh, Me.clmTonCuoi})
        Me.GridView.GridControl = Me.Grid
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsCustomization.AllowFilter = False
        Me.GridView.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
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
        Me.clmSTT.Width = 31
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
        Me.clmMaSach.Width = 80
        '
        'clmTenSach
        '
        Me.clmTenSach.Caption = "Tên Sách"
        Me.clmTenSach.ColumnEdit = Me.RepositoryItemComboBox1
        Me.clmTenSach.FieldName = "clmTenSach"
        Me.clmTenSach.Name = "clmTenSach"
        Me.clmTenSach.OptionsColumn.AllowEdit = False
        Me.clmTenSach.OptionsColumn.ReadOnly = True
        Me.clmTenSach.OptionsEditForm.StartNewRow = True
        Me.clmTenSach.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmTenSach.Visible = True
        Me.clmTenSach.VisibleIndex = 2
        Me.clmTenSach.Width = 163
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
        Me.clmTacGia.Width = 113
        '
        'clmTheLoai
        '
        Me.clmTheLoai.Caption = "Thể Loại"
        Me.clmTheLoai.FieldName = "clmTheLoai"
        Me.clmTheLoai.Name = "clmTheLoai"
        Me.clmTheLoai.OptionsColumn.AllowEdit = False
        Me.clmTheLoai.OptionsColumn.ReadOnly = True
        Me.clmTheLoai.OptionsColumn.TabStop = False
        Me.clmTheLoai.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmTheLoai.Visible = True
        Me.clmTheLoai.VisibleIndex = 4
        Me.clmTheLoai.Width = 135
        '
        'clmTonDau
        '
        Me.clmTonDau.AppearanceCell.Options.UseTextOptions = True
        Me.clmTonDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmTonDau.Caption = "Tồn Đầu"
        Me.clmTonDau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmTonDau.FieldName = "clmTonDau"
        Me.clmTonDau.Name = "clmTonDau"
        Me.clmTonDau.OptionsColumn.AllowEdit = False
        Me.clmTonDau.OptionsColumn.ReadOnly = True
        Me.clmTonDau.OptionsColumn.TabStop = False
        Me.clmTonDau.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmTonDau.Visible = True
        Me.clmTonDau.VisibleIndex = 5
        Me.clmTonDau.Width = 78
        '
        'clmTonPhatSinh
        '
        Me.clmTonPhatSinh.AppearanceCell.Options.UseTextOptions = True
        Me.clmTonPhatSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmTonPhatSinh.Caption = "Tồn Phát Sinh"
        Me.clmTonPhatSinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmTonPhatSinh.FieldName = "clmTonPhatSinh"
        Me.clmTonPhatSinh.Name = "clmTonPhatSinh"
        Me.clmTonPhatSinh.OptionsColumn.AllowEdit = False
        Me.clmTonPhatSinh.OptionsColumn.ReadOnly = True
        Me.clmTonPhatSinh.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmTonPhatSinh.Visible = True
        Me.clmTonPhatSinh.VisibleIndex = 6
        Me.clmTonPhatSinh.Width = 61
        '
        'clmTonCuoi
        '
        Me.clmTonCuoi.Caption = "Tồn Cuối"
        Me.clmTonCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmTonCuoi.FieldName = "clmTonCuoi"
        Me.clmTonCuoi.Name = "clmTonCuoi"
        Me.clmTonCuoi.OptionsColumn.AllowEdit = False
        Me.clmTonCuoi.OptionsColumn.ReadOnly = True
        Me.clmTonCuoi.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmTonCuoi.Visible = True
        Me.clmTonCuoi.VisibleIndex = 7
        '
        'btnLapBaoCaoTon
        '
        Me.btnLapBaoCaoTon.ImageOptions.Image = CType(resources.GetObject("btnLapBaoCaoTon.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLapBaoCaoTon.Location = New System.Drawing.Point(668, 96)
        Me.btnLapBaoCaoTon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLapBaoCaoTon.Name = "btnLapBaoCaoTon"
        Me.btnLapBaoCaoTon.Size = New System.Drawing.Size(143, 28)
        Me.btnLapBaoCaoTon.TabIndex = 28
        Me.btnLapBaoCaoTon.Text = "Lập báo cáo tồn"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(261, 96)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(199, 23)
        Me.LabelControl1.TabIndex = 27
        Me.LabelControl1.Text = "Chọn tháng báo cáo:"
        '
        'dateThangBaoCao
        '
        Me.dateThangBaoCao.EditValue = Nothing
        Me.dateThangBaoCao.Location = New System.Drawing.Point(495, 97)
        Me.dateThangBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateThangBaoCao.Name = "dateThangBaoCao"
        Me.dateThangBaoCao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateThangBaoCao.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateThangBaoCao.Properties.DisplayFormat.FormatString = "MM.yyyy"
        Me.dateThangBaoCao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateThangBaoCao.Properties.Mask.EditMask = "MM.yyyy"
        Me.dateThangBaoCao.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        Me.dateThangBaoCao.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.dateThangBaoCao.Size = New System.Drawing.Size(165, 22)
        Me.dateThangBaoCao.TabIndex = 26
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmLapBaoCaoTonGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 571)
        Me.Controls.Add(Me.PanelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLapBaoCaoTonGUI"
        Me.Text = "Lập báo cáo tồn"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.grpChiTietHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChiTietHoaDon.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateThangBaoCao.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateThangBaoCao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dateThangBaoCao As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLapBaoCaoTon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpChiTietHoaDon As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTenSach As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents clmTacGia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTheLoai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTonDau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTonPhatSinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTonCuoi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents btnXuatBaoCao As DevExpress.XtraEditors.SimpleButton
End Class
