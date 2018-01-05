Imports System.ComponentModel
Imports BUSLayer
Imports DALLayer
Imports DevExpress.Data
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DTO

Public Class frmTraCuuSachGUI

    Dim dataset As New DataSet
    Dim dtSach As New DataTable()
    Dim dtChiTietBanSach As New DataTable()
    Dim dtChiTietNhapSach As New DataTable()

    Dim dtMaSachThoaDonGia As New DataTable()
    Dim dtMaSachThoaNgayBan As New DataTable()
    Private Sub Init()


        'Khởi tạo mặc định các Control
        txtDonGiaBanfr.Text = "0"
        txtDonGiaBanto.Text = "Tối đa"
        txtDonGiaBanfr.Enabled = False
        txtDonGiaBanto.Enabled = False
        txtNgayBanfr.DateTime = Date.MinValue
        txtNgayBanto.DateTime = Date.Today
        txtNgayBanfr.Enabled = False
        txtNgayBanto.Enabled = False
        btnToiDaSoLuongBan.Enabled = False
        txtSoLuongBanfr.Text = "0"
        txtSoLuongBanto.Text = "Tối đa"
        txtSoLuongBanfr.Enabled = False
        txtSoLuongBanto.Enabled = False
        btnToiDaSoLuongTon.Enabled = False
        txtSoLuongTonfr.Text = "0"
        txtSoLuongTonto.Text = "Tối đa"
        txtSoLuongTonfr.Enabled = False
        txtSoLuongTonto.Enabled = False
        btnToiDaTienBan.Enabled = False
        txtTongTienBanfr.Text = "0"
        txtTongTienBanto.Text = "Tối đa"
        txtTongTienBanfr.Enabled = False
        txtTongTienBanto.Enabled = False
        txtDonGiaDuKienfr.Text = "0"
        txtDonGiaDuKiento.Text = "Tối đa"
        txtDonGiaDuKienfr.Enabled = False
        txtDonGiaDuKiento.Enabled = False

        cbKieuMaSach.Properties.Items.Add("Chính xác")
        cbKieuMaSach.Properties.Items.Add("Có chứa")
        cbKieuMaSach.SelectedIndex = 0

        cbKieuTenSach.Properties.Items.Add("Chính xác")
        cbKieuTenSach.Properties.Items.Add("Có chứa")
        cbKieuTenSach.SelectedIndex = 0

        dtSach.Columns.Add("clmSTT", GetType(Integer))
        dtSach.Columns.Add("clmMaSach", GetType(String))
        dtSach.Columns.Add("clmTenSach", GetType(Object))
        dtSach.Columns.Add("clmTheLoai", GetType(String))
        dtSach.Columns.Add("clmTacGia", GetType(String))
        dtSach.Columns.Add("clmSoLuongTon", GetType(Integer))
        dtSach.Columns.Add("clmTongSoLuongBan", GetType(Integer))
        dtSach.Columns.Add("clmTongTienBan", GetType(Integer))
        dtSach.Columns.Add("clmDonGiaDuKien", GetType(Integer))
        dtSach.TableName = "Sach"

        dtChiTietBanSach.Columns.Add("clmMaSach", GetType(String))
        dtChiTietBanSach.Columns.Add("clmMaHoaDon", GetType(String))
        dtChiTietBanSach.Columns.Add("clmNgayLapHoaDon", GetType(Date))
        dtChiTietBanSach.Columns.Add("clmDonGiaBan", GetType(Object))
        dtChiTietBanSach.Columns.Add("clmSoLuongBan", GetType(Object))
        dtChiTietBanSach.Columns.Add("clmThanhTien", GetType(Object))
        dtChiTietBanSach.TableName = "ChiTietBanSach"

        dtChiTietNhapSach.Columns.Add("clmMaSach", GetType(String))
        dtChiTietNhapSach.Columns.Add("clmMaPhieuNhap", GetType(String))
        dtChiTietNhapSach.Columns.Add("clmNgayNhap", GetType(Date))
        dtChiTietNhapSach.Columns.Add("clmSoLuongNhap", GetType(Object))
        dtChiTietNhapSach.TableName = "ChiTietNhapSach"

        dataset.Tables.Add(dtSach)
        dataset.Tables.Add(dtChiTietBanSach)
        dataset.Tables.Add(dtChiTietNhapSach)
        dataset.Relations.Add("ThongTinChiTietNhapSach", dataset.Tables("Sach").Columns("clmMaSach"), dataset.Tables("ChiTietNhapSach").Columns("clmMaSach"))
        dataset.Relations.Add("ThongTinChiTietBanSach", dataset.Tables("Sach").Columns("clmMaSach"), dataset.Tables("ChiTietBanSach").Columns("clmMaSach"))


        Grid.DataSource = dataset.Tables("Sach")

        Grid.LevelTree.Nodes.Add("ThongTinChiTietBanSach", gridChiTietBanSach)
        Grid.LevelTree.Nodes.Add("ThongTinChiTietNhapSach", gridChiTietNhapSach)




    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click


        GridView.ClearColumnsFilter()
        gridChiTietBanSach.ClearColumnsFilter()


        SplashScreenManager1.ShowWaitForm()
        If (txtMaSach.Text <> "") Then
            GridView.ActiveFilter.Add(GridView.Columns("clmMaSach"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoMaSach(txtMaSach.Text, cbKieuMaSach.Text)))
        End If

        If (txtTenSach.Text <> "") Then
            GridView.ActiveFilter.Add(GridView.Columns("clmTenSach"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoTenSach(txtTenSach.Text, cbKieuTenSach.Text)))
        End If

        GridView.ActiveFilter.Add(GridView.Columns("clmTheLoai"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoTheLoai(cbTheLoai.Text)))

        GridView.ActiveFilter.Add(GridView.Columns("clmTacGia"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoTacGia(cbTacGia.Text)))

        If (chkSoLuongTon.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmSoLuongTon"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoSoLuongTon(txtSoLuongTonfr.Text, txtSoLuongTonto.Text)))
        End If

        If (chkSoLuongBan.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmTongSoLuongBan"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoSoLuongBan(txtSoLuongBanfr.Text, txtSoLuongBanto.Text)))
        End If

        If (chkSoLuongBan.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmTongSoLuongBan"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoSoLuongBan(txtSoLuongBanfr.Text, txtSoLuongBanto.Text)))
        End If

        If (chkTongTienBan.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmTongTienBan"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoTongTienBan(txtTongTienBanfr.Text.Replace(".", ""), txtTongTienBanto.Text.Replace(".", ""))))
        End If

        If (chkDonGiaBan.Checked = True) Then
            gridChiTietBanSach.ActiveFilter.Add(gridChiTietBanSach.Columns("clmDonGiaBan"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoDonGiaBan(txtDonGiaBanfr.Text.Replace(".", ""), txtDonGiaBanto.Text.Replace(".", ""))))
            dtMaSachThoaDonGia = TraCuuSachBUS.getMaSachVoiDonGiaBan(txtDonGiaBanfr.Text.Replace(".", ""), txtDonGiaBanto.Text.Replace(".", ""))
        End If

        If (chkNgayBan.Checked = True) Then
            gridChiTietBanSach.ActiveFilter.Add(gridChiTietBanSach.Columns("clmNgayLapHoaDon"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoNgayBan(txtNgayBanfr.DateTime, txtNgayBanto.DateTime)))
            dtMaSachThoaNgayBan = TraCuuSachBUS.getMaSachVoiNgayBan(txtNgayBanfr.DateTime, txtNgayBanto.DateTime)
        End If

        If (chkDonGiaDuKien.Checked = True) Then
            GridView.ActiveFilter.Add(GridView.Columns("clmDonGiaDuKien"), New ColumnFilterInfo(TraCuuSachBUS.ChuanHoaDieuKienTheoDonGiaBanDuKien(txtDonGiaDuKienfr.Text.Replace(".", ""), txtDonGiaDuKiento.Text.Replace(".", ""))))
        End If

        GridView.RefreshData()
        dtSach.Select()

        SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub frmTraCuuSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub chkSoLuongTon_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoLuongTon.CheckedChanged
        If (chkSoLuongTon.Checked = True) Then
            txtSoLuongTonfr.Enabled = True
            txtSoLuongTonto.Enabled = True
            btnToiDaSoLuongTon.Enabled = True
        Else
            txtSoLuongTonfr.Enabled = False
            txtSoLuongTonto.Enabled = False
            btnToiDaSoLuongTon.Enabled = False
        End If
    End Sub

    Private Sub chkSoLuongBan_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoLuongBan.CheckedChanged
        If (chkSoLuongBan.Checked = True) Then
            txtSoLuongBanfr.Enabled = True
            txtSoLuongBanto.Enabled = True
            btnToiDaSoLuongBan.Enabled = True
        Else
            txtSoLuongBanfr.Enabled = False
            txtSoLuongBanto.Enabled = False
            btnToiDaSoLuongBan.Enabled = False
        End If
    End Sub

    Private Sub chkTongSoLuongBan_CheckedChanged(sender As Object, e As EventArgs) Handles chkTongTienBan.CheckedChanged
        If (chkTongTienBan.Checked = True) Then
            txtTongTienBanfr.Enabled = True
            txtTongTienBanto.Enabled = True
            btnToiDaTienBan.Enabled = True

        Else
            txtTongTienBanfr.Enabled = False
            txtTongTienBanto.Enabled = False
            btnToiDaTienBan.Enabled = False
        End If
    End Sub

    Private Sub chkNgayBan_CheckedChanged(sender As Object, e As EventArgs) Handles chkNgayBan.CheckedChanged
        If (chkNgayBan.Checked = True) Then
            txtNgayBanfr.Enabled = True
            txtNgayBanto.Enabled = True
        Else
            txtNgayBanfr.Enabled = False
            txtNgayBanto.Enabled = False
        End If
    End Sub

    Private Sub chkDonGiaBan_CheckedChanged(sender As Object, e As EventArgs) Handles chkDonGiaBan.CheckedChanged
        If (chkDonGiaBan.Checked = True) Then
            txtDonGiaBanfr.Enabled = True
            txtDonGiaBanto.Enabled = True

        Else
            txtDonGiaBanfr.Enabled = False
            txtDonGiaBanto.Enabled = False
        End If
    End Sub

    Private Sub chkDonGiaBanDuKien_CheckedChanged(sender As Object, e As EventArgs) Handles chkDonGiaDuKien.CheckedChanged
        If (chkDonGiaDuKien.Checked = True) Then
            txtDonGiaDuKienfr.Enabled = True
            txtDonGiaDuKiento.Enabled = True

        Else
            txtDonGiaDuKienfr.Enabled = False
            txtDonGiaDuKiento.Enabled = False
        End If
    End Sub


    Private Sub btnToiDaSoLuongTon_Click(sender As Object, e As EventArgs) Handles btnToiDaSoLuongTon.Click
        txtSoLuongTonto.Text = "Tối đa"
    End Sub

    Private Sub btnToiDaTienBan_Click(sender As Object, e As EventArgs) Handles btnToiDaTienBan.Click
        txtTongTienBanto.Text = "Tối đa"
    End Sub

    Private Sub btnToiDaSoLuongBan_Click(sender As Object, e As EventArgs) Handles btnToiDaSoLuongBan.Click
        txtSoLuongBanto.Text = "Tối đa"
    End Sub

    Private Sub btnToiDaDonGiaBanDuKien_Click(sender As Object, e As EventArgs) Handles btnToiDaDonGiaBanDuKien.Click
        txtDonGiaDuKiento.Text = "Tối đa"
    End Sub

    'Nạp lại danh sách sách khi form được Active
    Private Sub frmTraCuuSachGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


        dtChiTietBanSach.Rows.Clear()
        dtChiTietNhapSach.Rows.Clear()
        dtSach.Rows.Clear()

        'Nạp danh sách sách
        Dim sach As New List(Of SachDTO)

        sach = TraCuuSachBUS.getSach()

        For i As Integer = 0 To sach.Count - 1
            dtSach.Rows.Add(i + 1, sach(i).StrMaSach, sach(i).StrTenSach, sach(i).StrTheLoai, sach(i).StrTacGia, sach(i).ISoLuongTon, sach(i).ITongSoLuongBan, sach(i).ITongTienBan, sach(i).IDonGiaDuKien)
        Next


        'Nạp tất cả chi tiết bán sách

        Dim ChiTietBanSach As New List(Of ChiTietHoaDonDTO)

        ChiTietBanSach = TraCuuSachBUS.getTatCaChiTietBanSach()

        For i As Integer = 0 To ChiTietBanSach.Count - 1
            dtChiTietBanSach.Rows.Add(ChiTietBanSach(i).StrMaSach, ChiTietBanSach(i).StrMaHoaDon, ChiTietBanSach(i).DateNgayLapHoaDon, ChiTietBanSach(i).IDonGiaBan, ChiTietBanSach(i).ISoLuongBan, ChiTietBanSach(i).IThanhTien)
        Next

        'Nạp tất cả chi tiết nhập sách
        Dim ChiTietNhapSach As New List(Of ChiTietPhieuNhapDTO)

        ChiTietNhapSach = TraCuuSachBUS.getTatCaChiTietNhapSach()

        For i As Integer = 0 To ChiTietNhapSach.Count - 1
            dtChiTietNhapSach.Rows.Add(ChiTietNhapSach(i).IMaSach, ChiTietNhapSach(i).IMaPhieuNhap, ChiTietNhapSach(i).DateNgayNhap, ChiTietNhapSach(i).ISoLuongNhap)
        Next

        'Nạp tất cả thể loại
        Dim listTheLoai As New List(Of String)
        listTheLoai = TraCuuSachBUS.getTatCaTheLoaiSach()
        For Each strTheLoai In listTheLoai
            If (cbTheLoai.Properties.Items.Contains(strTheLoai) = False) Then
                cbTheLoai.Properties.Items.Add(strTheLoai, True)
            End If

        Next

        'Nạp tất cả các tác giả
        Dim listTacGia As New List(Of String)
        listTacGia = TraCuuSachBUS.getTatCaTacGiaSach()
        For Each strTacGia In listTacGia
            If (cbTacGia.Properties.Items.Contains(strTacGia) = False) Then
                cbTacGia.Properties.Items.Add(strTacGia, True)
            End If

        Next
    End Sub

    Private Sub gridChiTietBanSach_CustomRowFilter(sender As Object, e As RowFilterEventArgs) Handles gridChiTietBanSach.CustomRowFilter

    End Sub

    Private Sub GridView_CustomRowFilter(sender As Object, e As RowFilterEventArgs) Handles GridView.CustomRowFilter
        If (chkDonGiaBan.Checked = True) Then
            Dim author As [String] = GridView.GetRowCellValue(e.ListSourceRow, "clmMaSach")

            Dim contains As Boolean = dtMaSachThoaDonGia.AsEnumerable().Any(Function(row) author = row.Field(Of [String])(0))
            If (contains <> True) Then
                e.Visible = False
            End If

        End If

        If (chkNgayBan.Checked = True) Then
            Dim author As [String] = GridView.GetRowCellValue(e.ListSourceRow, "clmMaSach")

            Dim contains As Boolean = dtMaSachThoaNgayBan.AsEnumerable().Any(Function(row) author = row.Field(Of [String])(0))
            If (contains <> True) Then
                e.Visible = False
            End If

        End If
        e.Handled = True
    End Sub

    Private Sub btnXuat_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim frmPreview As New frmPreview(New DanhSachSachINFO(dtSach))
        frmPreview.Show()


    End Sub

#Region "Menu Chuột Phải"
    Private Sub GridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles GridView.PopupMenuShowing
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

        Dim menuChinhSuaSach As New DXMenuItem("&Chỉnh sửa sách", AddressOf ChinhSuaSach)
        menuChinhSuaSach.Tag = New RowInfo(view, rowHandle)

        Return menuChinhSuaSach
    End Function
    Sub ChinhSuaSach(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)

        Dim frmChinhSuaSach = New frmChinhSuaSachGUI(info.View.GetDataRow(info.RowHandle)("clmMaSach"))
        frmChinhSuaSach.Size = New Size(750, 380)
        frmChinhSuaSach.ShowDialog()

        'Cập nhật lại thông tin sách vừa mở menu Sửa thông tin
        Dim sachINFO As SachDTO = SachBUS.LaySachDTO(info.View.GetDataRow(info.RowHandle)("clmMaSach"))

        info.View.GetDataRow(info.RowHandle).Item("clmTenSach") = sachINFO.StrTenSach
        info.View.GetDataRow(info.RowHandle).Item("clmTacGia") = sachINFO.StrTacGia
        info.View.GetDataRow(info.RowHandle).Item("clmTheLoai") = sachINFO.StrTheLoai
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub





#End Region
End Class