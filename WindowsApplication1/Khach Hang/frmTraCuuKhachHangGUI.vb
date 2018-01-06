Imports BUSLayer
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTraCuuKhachHangGUI
    Dim dataset As New DataSet
    Dim dtKhachHang As New DataTable()
    Dim dtHoaDon As New DataTable()
    Dim dtPhieuThuTien As New DataTable


    Private Sub frmTraCuuKhachHangGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Khởi tạo mặc định các Control
        cbKieuMaKhachHang.Properties.Items.Add("Chính xác")
        cbKieuMaKhachHang.Properties.Items.Add("Có chứa")
        cbKieuMaKhachHang.SelectedIndex = 0

        cbKieuHoTenKhachHang.Properties.Items.Add("Chính xác")
        cbKieuHoTenKhachHang.Properties.Items.Add("Có chứa")
        cbKieuHoTenKhachHang.SelectedIndex = 0


        txtDiaChi.Enabled = False
        cbKieuDiaChi.Enabled = False
        cbKieuDiaChi.Properties.Items.Add("Chính xác")
        cbKieuDiaChi.Properties.Items.Add("Có chứa")
        cbKieuDiaChi.SelectedIndex = 0

        txtDienThoai.Enabled = False
        cbKieuDienThoai.Enabled = False
        cbKieuDienThoai.Properties.Items.Add("Chính xác")
        cbKieuDienThoai.Properties.Items.Add("Có chứa")
        cbKieuDienThoai.SelectedIndex = 0

        txtEmail.Enabled = False
        cbKieuEmail.Enabled = False
        cbKieuEmail.Properties.Items.Add("Chính xác")
        cbKieuEmail.Properties.Items.Add("Có chứa")
        cbKieuEmail.SelectedIndex = 0

        txtSoTienNofr.Enabled = False
        txtSoTienNoto.Enabled = False
        btnToiDaSoTienNo.Enabled = False
        txtSoTienNofr.Text = "0"
        txtSoTienNoto.Text = "Tối đa"

        dtKhachHang.Columns.Add("clmSTT", GetType(Integer))
        dtKhachHang.Columns.Add("clmMaKhachHang", GetType(String))
        dtKhachHang.Columns.Add("clmHoTenKhachHang", GetType(String))
        dtKhachHang.Columns.Add("clmEmail", GetType(String))
        dtKhachHang.Columns.Add("clmDienThoai", GetType(String))
        dtKhachHang.Columns.Add("clmDiaChi", GetType(String))
        dtKhachHang.Columns.Add("clmSoTienNo", GetType(Integer))
        dtKhachHang.TableName = "KhachHang"

        dtHoaDon.Columns.Add("clmMaHoaDon", GetType(String))
        dtHoaDon.Columns.Add("clmMaKhachHang", GetType(String))
        dtHoaDon.Columns.Add("clmNgayLapHoaDon", GetType(DateTime))
        dtHoaDon.Columns.Add("clmTongThanhTien", GetType(Integer))
        dtHoaDon.TableName = "HoaDon"

        dtPhieuThuTien.Columns.Add("clmMaPhieuThuTien", GetType(String))
        dtPhieuThuTien.Columns.Add("clmMaKhachHang", GetType(String))
        dtPhieuThuTien.Columns.Add("clmNgayThuTien", GetType(DateTime))
        dtPhieuThuTien.Columns.Add("clmSoTienThu", GetType(Integer))
        dtPhieuThuTien.TableName = "PhieuThuTien"

        dataset.Tables.Add(dtKhachHang)
        dataset.Tables.Add(dtHoaDon)
        dataset.Tables.Add(dtPhieuThuTien)
        dataset.Relations.Add("ThongTinHoaDon", dataset.Tables("KhachHang").Columns("clmMaKhachHang"), dataset.Tables("HoaDon").Columns("clmMaKhachHang"))
        dataset.Relations.Add("ThongTinPhieuThuTien", dataset.Tables("KhachHang").Columns("clmMaKhachHang"), dataset.Tables("PhieuThuTien").Columns("clmMaKhachHang"))

        Grid.DataSource = dataset.Tables("KhachHang")
        Grid.LevelTree.Nodes.Add("ThongTinHoaDon", GridViewHoaDon)
        Grid.LevelTree.Nodes.Add("ThongTinPhieuThuTien", GridViewPhieuThuTien)
    End Sub

    Private Sub chkDiaChi_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiaChi.CheckedChanged
        If (chkDiaChi.Checked = False) Then
            txtDiaChi.Enabled = False
            cbKieuDiaChi.Enabled = False
        Else
            txtDiaChi.Enabled = True
            cbKieuDiaChi.Enabled = True
        End If
    End Sub

    Private Sub chkDienThoai_CheckedChanged(sender As Object, e As EventArgs) Handles chkDienThoai.CheckedChanged
        If (chkDienThoai.Checked = False) Then
            txtDienThoai.Enabled = False
            cbKieuDienThoai.Enabled = False
        Else
            txtDienThoai.Enabled = True
            cbKieuDienThoai.Enabled = True
        End If
    End Sub

    Private Sub chkEmail_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmail.CheckedChanged
        If (chkEmail.Checked = False) Then
            txtEmail.Enabled = False
            cbKieuEmail.Enabled = False
        Else
            txtEmail.Enabled = True
            cbKieuEmail.Enabled = True
        End If
    End Sub

    Private Sub chkSoTienNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoTienNo.CheckedChanged
        If (chkSoTienNo.Checked = False) Then
            txtSoTienNofr.Enabled = False
            txtSoTienNoto.Enabled = False
            btnToiDaSoTienNo.Enabled = False
        Else
            txtSoTienNofr.Enabled = True
            txtSoTienNoto.Enabled = True
            btnToiDaSoTienNo.Enabled = True
        End If
    End Sub

    Private Sub frmTraCuuKhachHangGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        dtHoaDon.Rows.Clear()
        dtPhieuThuTien.Rows.Clear()


        dtKhachHang.Rows.Clear()

        'Nạp danh sách khách hàng
        For Each khachhangINFO In KhachHangBUS.LayTatCaKhachHang()
            dtKhachHang.Rows.Add(dtKhachHang.Rows.Count + 1, khachhangINFO.StrMaKhachHang, khachhangINFO.StrHoTenKhachHang, khachhangINFO.StrEmail, khachhangINFO.StrDienThoai, khachhangINFO.StrDiaChi, khachhangINFO.ISoTienNo)
        Next

        'Nạp danh sách hóa đơn
        For Each hoadonINFO In HoaDonBUS.LayTatCaHoaDon()
            dtHoaDon.Rows.Add(hoadonINFO.StrMaHoaDon, hoadonINFO.StrMaKhachHang, hoadonINFO.DateNgayLapHoaDon, hoadonINFO.ITongThanhTien)
        Next

        'Nạp danh sách phiếu thu tiền
        For Each phieuthutienINFO In PhieuThuTienBUS.LayTatCaPhieuThuTien()
            dtPhieuThuTien.Rows.Add(phieuthutienINFO.StrMaPhieuThu, phieuthutienINFO.StrMaKhachHang, phieuthutienINFO.DateNgayThuTien, phieuthutienINFO.ISoTienThu)
        Next
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        GridView.ClearColumnsFilter()
        SplashScreenManager1.ShowWaitForm()

        If (txtMaKhachHang.Text <> "") Then
            GridView.ActiveFilter.Add(GridView.Columns("clmMaKhachHang"), New ColumnFilterInfo(TraCuuKhachHangBUS.ChuanHoaDieuKienTheoMaKhachHang(txtMaKhachHang.Text, cbKieuMaKhachHang.Text)))
        End If

        If (txtHoTenKhachHang.Text <> "") Then
            GridView.ActiveFilter.Add(GridView.Columns("clmHoTenKhachHang"), New ColumnFilterInfo(TraCuuKhachHangBUS.ChuanHoaDieuKienTheoHoTenKhachHang(txtHoTenKhachHang.Text, cbKieuHoTenKhachHang.Text)))
        End If

        If (chkDiaChi.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmDiaChi"), New ColumnFilterInfo(TraCuuKhachHangBUS.ChuanHoaDieuKienTheoDiaChi(txtDiaChi.Text, cbKieuDiaChi.Text)))
        End If

        If (chkDienThoai.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmDienThoai"), New ColumnFilterInfo(TraCuuKhachHangBUS.ChuanHoaDieuKienTheoDienThoai(txtDienThoai.Text, cbKieuDienThoai.Text)))
        End If

        If (chkEmail.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmEmail"), New ColumnFilterInfo(TraCuuKhachHangBUS.ChuanHoaDieuKienTheoEmail(txtEmail.Text, cbKieuEmail.Text)))
        End If

        If (chkSoTienNo.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmSoTienNo"), New ColumnFilterInfo(TraCuuKhachHangBUS.ChuanHoaDieuKienTheoSoTienNo(txtSoTienNofr.Text, txtSoTienNoto.Text)))
        End If


        SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim frmPrint = New frmPreview(New DanhSachKhachHangINFO(dtKhachHang))
        frmPrint.ShowDialog()

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub GridView_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            ' Delete existing menu items, if any.
            e.Menu.Items.Clear()
            ' Add a submenu with a single menu item.
            e.Menu.Items.Add(CreateRowSubMenu(view, rowHandle))
            ' Add a check menu item.

        End If
    End Sub

    Function CreateRowSubMenu(ByVal view As GridView, ByVal rowHandle As Integer) As DXMenuItem

        Dim menuChinhSuaSach As New DXMenuItem("&Chỉnh sửa khách hàng", AddressOf ChinhSuaKhachHang)
        menuChinhSuaSach.Tag = New RowInfo(view, rowHandle)

        Return menuChinhSuaSach
    End Function

    Sub ChinhSuaKhachHang(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)

        Dim frmChinhSuaKhachHang = New frmChinhSuaKhachHangGUI(info.View.GetDataRow(info.RowHandle)("clmMaKhachHang"))
        'frmChinhSuaKhachHang.Size = New Size(1151, 448)
        frmChinhSuaKhachHang.ShowDialog()

        'Cập nhật lại thông tin KH vừa mở menu Sửa thông tin
        Dim khachhangINFO As DTO.KhachHangDTO = KhachHangBUS.LayKhachHangDTO(info.View.GetDataRow(info.RowHandle)("clmMaKhachHang"))

        info.View.GetDataRow(info.RowHandle).Item("clmHoTenKhachHang") = khachhangINFO.StrHoTenKhachHang
        info.View.GetDataRow(info.RowHandle).Item("clmDiaChi") = khachhangINFO.StrDiaChi
        info.View.GetDataRow(info.RowHandle).Item("clmDienThoai") = khachhangINFO.StrDienThoai
        info.View.GetDataRow(info.RowHandle).Item("clmEmail") = khachhangINFO.StrEmail

    End Sub
End Class