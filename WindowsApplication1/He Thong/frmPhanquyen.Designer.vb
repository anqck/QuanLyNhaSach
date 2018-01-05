<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhanquyen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhanquyen))
        Me.lblMain = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.mainGrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clmSTT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaNguoiDung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmHoTenNguoiDung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmTenDangNhap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMatKhau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clmMaLoaiNguoiDung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.mainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Blue
        Me.lblMain.Location = New System.Drawing.Point(275, 35)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(483, 38)
        Me.lblMain.TabIndex = 79
        Me.lblMain.Text = "PHÂN QUYỀN NGƯỜI DÙNG"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.mainGrid)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 120)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1064, 382)
        Me.GroupControl1.TabIndex = 80
        Me.GroupControl1.Text = "Danh sách người dùng"
        '
        'mainGrid
        '
        Me.mainGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.mainGrid.Location = New System.Drawing.Point(2, 25)
        Me.mainGrid.MainView = Me.GridView
        Me.mainGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.mainGrid.Name = "mainGrid"
        Me.mainGrid.Size = New System.Drawing.Size(1060, 355)
        Me.mainGrid.TabIndex = 41
        Me.mainGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.ActiveFilterEnabled = False
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmSTT, Me.clmMaNguoiDung, Me.clmHoTenNguoiDung, Me.clmTenDangNhap, Me.clmMatKhau, Me.clmMaLoaiNguoiDung})
        Me.GridView.GridControl = Me.mainGrid
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
        'clmMaNguoiDung
        '
        Me.clmMaNguoiDung.Caption = "Mã Người Dùng"
        Me.clmMaNguoiDung.FieldName = "clmMaNguoiDung"
        Me.clmMaNguoiDung.Name = "clmMaNguoiDung"
        Me.clmMaNguoiDung.OptionsColumn.AllowEdit = False
        Me.clmMaNguoiDung.OptionsColumn.ReadOnly = True
        Me.clmMaNguoiDung.Visible = True
        Me.clmMaNguoiDung.VisibleIndex = 1
        Me.clmMaNguoiDung.Width = 89
        '
        'clmHoTenNguoiDung
        '
        Me.clmHoTenNguoiDung.Caption = "Họ Tên Người Dùng"
        Me.clmHoTenNguoiDung.FieldName = "clmHoTenNguoiDung"
        Me.clmHoTenNguoiDung.Name = "clmHoTenNguoiDung"
        Me.clmHoTenNguoiDung.OptionsColumn.AllowEdit = False
        Me.clmHoTenNguoiDung.OptionsColumn.ReadOnly = True
        Me.clmHoTenNguoiDung.Visible = True
        Me.clmHoTenNguoiDung.VisibleIndex = 2
        Me.clmHoTenNguoiDung.Width = 164
        '
        'clmTenDangNhap
        '
        Me.clmTenDangNhap.Caption = "Tên Đăng Nhập"
        Me.clmTenDangNhap.FieldName = "clmTenDangNhap"
        Me.clmTenDangNhap.Name = "clmTenDangNhap"
        Me.clmTenDangNhap.OptionsColumn.AllowEdit = False
        Me.clmTenDangNhap.OptionsColumn.ReadOnly = True
        Me.clmTenDangNhap.Visible = True
        Me.clmTenDangNhap.VisibleIndex = 3
        Me.clmTenDangNhap.Width = 178
        '
        'clmMatKhau
        '
        Me.clmMatKhau.Caption = "Mật Khẩu"
        Me.clmMatKhau.FieldName = "clmMatKhau"
        Me.clmMatKhau.Name = "clmMatKhau"
        Me.clmMatKhau.OptionsColumn.AllowEdit = False
        Me.clmMatKhau.OptionsColumn.ReadOnly = True
        Me.clmMatKhau.Visible = True
        Me.clmMatKhau.VisibleIndex = 4
        Me.clmMatKhau.Width = 141
        '
        'clmMaLoaiNguoiDung
        '
        Me.clmMaLoaiNguoiDung.Caption = "Loại Người Dùng"
        Me.clmMaLoaiNguoiDung.FieldName = "clmMaLoaiNguoiDung"
        Me.clmMaLoaiNguoiDung.Name = "clmMaLoaiNguoiDung"
        Me.clmMaLoaiNguoiDung.OptionsColumn.AllowEdit = False
        Me.clmMaLoaiNguoiDung.OptionsColumn.ReadOnly = True
        Me.clmMaLoaiNguoiDung.Visible = True
        Me.clmMaLoaiNguoiDung.VisibleIndex = 5
        Me.clmMaLoaiNguoiDung.Width = 115
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThem.ImageOptions.Image = CType(resources.GetObject("btnThem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(674, 530)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(113, 31)
        Me.btnThem.TabIndex = 86
        Me.btnThem.Text = "Thêm"
        '
        'btnThoat
        '
        Me.btnThoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThoat.ImageOptions.Image = CType(resources.GetObject("btnThoat.ImageOptions.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(941, 530)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(113, 31)
        Me.btnThoat.TabIndex = 87
        Me.btnThoat.Text = "Thoát"
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSua.ImageOptions.Image = CType(resources.GetObject("btnSua.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSua.Location = New System.Drawing.Point(811, 530)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(113, 31)
        Me.btnSua.TabIndex = 88
        Me.btnSua.Text = "Sửa"
        '
        'frmPhanquyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 574)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "frmPhanquyen"
        Me.Text = "Phân quyền"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.mainGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents mainGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmSTT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaNguoiDung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmHoTenNguoiDung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmTenDangNhap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMatKhau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmMaLoaiNguoiDung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
End Class
