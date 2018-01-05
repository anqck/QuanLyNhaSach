<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapBaoCaoCongNoGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLapBaoCaoCongNoGUI))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grpChiTietHoaDon = New DevExpress.XtraEditors.GroupControl()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmHoTenKhachHang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.clmDiaChi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNoDau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNoPhatSinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmNoCuoi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnXuatBaoCao = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLapBaoCaoTon = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dateThangBaoCao = New DevExpress.XtraEditors.DateEdit()
        Me.lblMain = New System.Windows.Forms.Label()
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grpChiTietHoaDon)
        Me.PanelControl1.Controls.Add(Me.btnXuatBaoCao)
        Me.PanelControl1.Controls.Add(Me.btnLapBaoCaoTon)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.dateThangBaoCao)
        Me.PanelControl1.Controls.Add(Me.lblMain)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1085, 567)
        Me.PanelControl1.TabIndex = 0
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
        Me.grpChiTietHoaDon.Size = New System.Drawing.Size(1053, 398)
        Me.grpChiTietHoaDon.TabIndex = 83
        Me.grpChiTietHoaDon.Text = "Chi Tiết Báo Công Nợ:"
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
        Me.Grid.Size = New System.Drawing.Size(1049, 371)
        Me.Grid.TabIndex = 77
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSTT, Me.clmMaKhachHang, Me.clmHoTenKhachHang, Me.clmDiaChi, Me.clmNoDau, Me.clmNoPhatSinh, Me.clmNoCuoi})
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
        Me.clmSTT.Width = 41
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
        Me.clmMaKhachHang.Width = 82
        '
        'clmHoTenKhachHang
        '
        Me.clmHoTenKhachHang.Caption = "Họ Tên Khách Hàng"
        Me.clmHoTenKhachHang.ColumnEdit = Me.RepositoryItemComboBox1
        Me.clmHoTenKhachHang.FieldName = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang.Name = "clmHoTenKhachHang"
        Me.clmHoTenKhachHang.OptionsColumn.AllowEdit = False
        Me.clmHoTenKhachHang.OptionsColumn.ReadOnly = True
        Me.clmHoTenKhachHang.OptionsEditForm.StartNewRow = True
        Me.clmHoTenKhachHang.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.clmHoTenKhachHang.Visible = True
        Me.clmHoTenKhachHang.VisibleIndex = 2
        Me.clmHoTenKhachHang.Width = 185
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'clmDiaChi
        '
        Me.clmDiaChi.Caption = "Địa Chỉ"
        Me.clmDiaChi.FieldName = "clmDiaChi"
        Me.clmDiaChi.Name = "clmDiaChi"
        Me.clmDiaChi.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.clmDiaChi.Visible = True
        Me.clmDiaChi.VisibleIndex = 3
        Me.clmDiaChi.Width = 114
        '
        'clmNoDau
        '
        Me.clmNoDau.AppearanceCell.Options.UseTextOptions = True
        Me.clmNoDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmNoDau.Caption = "Nợ Đầu (Đồng)"
        Me.clmNoDau.DisplayFormat.FormatString = "n0"
        Me.clmNoDau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmNoDau.FieldName = "clmNoDau"
        Me.clmNoDau.Name = "clmNoDau"
        Me.clmNoDau.OptionsColumn.AllowEdit = False
        Me.clmNoDau.OptionsColumn.ReadOnly = True
        Me.clmNoDau.OptionsColumn.TabStop = False
        Me.clmNoDau.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmNoDau.Visible = True
        Me.clmNoDau.VisibleIndex = 4
        Me.clmNoDau.Width = 97
        '
        'clmNoPhatSinh
        '
        Me.clmNoPhatSinh.AppearanceCell.Options.UseTextOptions = True
        Me.clmNoPhatSinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.clmNoPhatSinh.Caption = "Nợ Phát Sinh (Đồng)"
        Me.clmNoPhatSinh.DisplayFormat.FormatString = "n0"
        Me.clmNoPhatSinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmNoPhatSinh.FieldName = "clmNoPhatSinh"
        Me.clmNoPhatSinh.Name = "clmNoPhatSinh"
        Me.clmNoPhatSinh.OptionsColumn.AllowEdit = False
        Me.clmNoPhatSinh.OptionsColumn.ReadOnly = True
        Me.clmNoPhatSinh.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmNoPhatSinh.Visible = True
        Me.clmNoPhatSinh.VisibleIndex = 5
        Me.clmNoPhatSinh.Width = 127
        '
        'clmNoCuoi
        '
        Me.clmNoCuoi.Caption = "Nợ Cuối (Đồng)"
        Me.clmNoCuoi.DisplayFormat.FormatString = "n0"
        Me.clmNoCuoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmNoCuoi.FieldName = "clmNoCuoi"
        Me.clmNoCuoi.Name = "clmNoCuoi"
        Me.clmNoCuoi.OptionsColumn.AllowEdit = False
        Me.clmNoCuoi.OptionsColumn.ReadOnly = True
        Me.clmNoCuoi.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.clmNoCuoi.Visible = True
        Me.clmNoCuoi.VisibleIndex = 6
        Me.clmNoCuoi.Width = 122
        '
        'btnXuatBaoCao
        '
        Me.btnXuatBaoCao.ImageOptions.Image = CType(resources.GetObject("btnXuatBaoCao.ImageOptions.Image"), System.Drawing.Image)
        Me.btnXuatBaoCao.Location = New System.Drawing.Point(765, 84)
        Me.btnXuatBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnXuatBaoCao.Name = "btnXuatBaoCao"
        Me.btnXuatBaoCao.Size = New System.Drawing.Size(143, 28)
        Me.btnXuatBaoCao.TabIndex = 82
        Me.btnXuatBaoCao.Text = "Xuất báo cáo"
        '
        'btnLapBaoCaoTon
        '
        Me.btnLapBaoCaoTon.ImageOptions.Image = CType(resources.GetObject("btnLapBaoCaoTon.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLapBaoCaoTon.Location = New System.Drawing.Point(583, 84)
        Me.btnLapBaoCaoTon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLapBaoCaoTon.Name = "btnLapBaoCaoTon"
        Me.btnLapBaoCaoTon.Size = New System.Drawing.Size(175, 28)
        Me.btnLapBaoCaoTon.TabIndex = 81
        Me.btnLapBaoCaoTon.Text = "Lập báo cáo công nợ"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(164, 84)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(199, 23)
        Me.LabelControl1.TabIndex = 80
        Me.LabelControl1.Text = "Chọn tháng báo cáo:"
        '
        'dateThangBaoCao
        '
        Me.dateThangBaoCao.EditValue = Nothing
        Me.dateThangBaoCao.Location = New System.Drawing.Point(385, 85)
        Me.dateThangBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateThangBaoCao.Name = "dateThangBaoCao"
        Me.dateThangBaoCao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateThangBaoCao.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateThangBaoCao.Properties.DisplayFormat.FormatString = "MM.yyyy"
        Me.dateThangBaoCao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateThangBaoCao.Properties.Mask.EditMask = "MM.yyyy"
        Me.dateThangBaoCao.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        Me.dateThangBaoCao.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.dateThangBaoCao.Size = New System.Drawing.Size(185, 22)
        Me.dateThangBaoCao.TabIndex = 79
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(377, 12)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(347, 38)
        Me.lblMain.TabIndex = 78
        Me.lblMain.Text = "BÁO CÁO CÔNG NỢ"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmLapBaoCaoCongNoGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 567)
        Me.Controls.Add(Me.PanelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLapBaoCaoCongNoGUI"
        Me.Text = "Lập Báo Cáo Công Nợ"
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

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnXuatBaoCao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLapBaoCaoTon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dateThangBaoCao As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMain As Label
    Friend WithEvents grpChiTietHoaDon As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmHoTenKhachHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents clmNoDau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmNoPhatSinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmNoCuoi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmDiaChi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
