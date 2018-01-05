Imports System.ComponentModel
Imports BUSLayer
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DTO

Public Class frmHoaDonBanSachGUI

    Dim dt As DataTable


    Private Sub Init()

        grpQuyDinh.Enabled = False

        Grid.Enabled = False
        btnChonSach.Enabled = False
        grpThongTinKhachHang.Enabled = False
        grpChiTietHoaDon.Enabled = False
        dateNgayNhap.Enabled = False
        btnXoaDong.Enabled = False
        btnLuu.Enabled = False
        btnIn.Enabled = False
    End Sub

    Private Sub frmHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Public Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        dt = New DataTable()
        txtMaHoaDon.Text = PhieuNhapSachBUS.PhatSinhMaPhieuNhap()

        dt.Columns.Add("clmSTT", GetType(String))
        dt.Columns.Add("clmMaSach", GetType(String))
        dt.Columns.Add("clmTenSach", GetType(Object))
        dt.Columns.Add("clmTheLoai", GetType(String))
        dt.Columns.Add("clmTacGia", GetType(String))
        dt.Columns.Add("clmSoLuongTon", GetType(Integer))
        dt.Columns.Add("clmSoLuong", GetType(Integer))
        dt.Columns.Add("clmDonGia", GetType(Integer))
        dt.Columns.Add("clmThanhTien", GetType(Integer))
        Grid.DataSource = dt

        grpQuyDinh.Enabled = True
        grpChiTietHoaDon.Enabled = True
        grpThongTinKhachHang.Enabled = True
        Grid.Enabled = True
        btnChonSach.Enabled = True
        btnLuu.Enabled = True
        dateNgayNhap.Enabled = True
        btnXoaDong.Enabled = True
        txtMaHoaDon.Text = HoaDonBUS.PhatSinhMaHoaDon()
        dateNgayNhap.DateTime = Date.Now.ToString("MM/dd/yyyy")
        txtMaKhachHang.Text = ""
        txtHoTenKhachHang.Text = ""
        txtDiaChi.Text = ""
        txtDienThoai.Text = ""
        txtTienNo.Text = ""
        btnIn.Enabled = False

        Dim listSach As New List(Of SachDTO)
        listSach = SachBUS.LayTatCaSachXapSep()
        RepositoryItemComboBox1.Items.Clear()
        For i As Integer = 0 To listSach.Count - 1
            RepositoryItemComboBox1.Items.Add(New MyComboBoxItem(listSach(i).StrTenSach, listSach(i).StrMaSach))
        Next

    End Sub

    Public Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        GridView.UpdateCurrentRow()

#Region "Kiểm Tra Khách Hàng"

        If (txtMaKhachHang.Text = "") Then
            MessageBox.Show("Chưa chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

#End Region

#Region "Kiểm tra sách bán"
        'Kiểm tra sô lượng đầu sách >0
        If (dt.Rows.Count = 0) Then
            MessageBox.Show("Đầu sách bán chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

        Dim validBit1 As Boolean = True

        'Kiểm tra số lượng tồn của các đầu sách >0
        For i As Integer = 0 To GridView.DataRowCount - 1
            If (GridView.GetRowCellValue(i, "clmSoLuongTon") = 0) Then
                GridView.GetDataRow(GridView.GetRowHandle(i)).RowError = "Số lượng tồn của sách = 0"
                validBit1 = False
            End If
        Next i


        If (validBit1 = False) Then
            MessageBox.Show("Số lượng tồn của sách = 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If



        'Kiểm tra các số lượng đã được nhập hết hay không
        For i As Integer = 0 To GridView.DataRowCount - 1
            If (PhieuNhapSachBUS.isValidSoLuong(GridView.GetRowCellValue(i, "clmSoLuong").ToString) = False) Then
                GridView.GetDataRow(GridView.GetRowHandle(i)).RowError = "Số lượng chưa được nhập"
                validBit1 = False
            End If
        Next i

        If (validBit1 = False) Then
            MessageBox.Show("Số lượng chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

        For i As Integer = 0 To GridView.DataRowCount - 1
            If (PhieuNhapSachBUS.isValidSoLuong(GridView.GetRowCellValue(i, "clmDonGia").ToString) = False) Then
                GridView.GetDataRow(GridView.GetRowHandle(i)).RowError = "Đơn giá chưa được nhập"
                validBit1 = False
            End If
        Next i

        If (validBit1 = False) Then
            MessageBox.Show("Đơn giá chưa được nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

#End Region

#Region "Kiểm tra quy đinh"

        If (HoaDonBUS.isValidSoTienNoToiDa(txtMaKhachHang.Text) = False) Then
            MessageBox.Show("Số tiền nợ tối đa của khách hàng không thỏa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If


        For i As Integer = 0 To GridView.DataRowCount - 1
            If (HoaDonBUS.isValidSoLuongToiThieuSauKhiBan(GridView.GetRowCellValue(i, "clmMaSach"), GridView.GetRowCellValue(i, "clmSoLuong")) = False) Then
                GridView.GetDataRow(GridView.GetRowHandle(i)).RowError = "Số lượng tối thiểu sau khi bán không thỏa"
                validBit1 = False
            End If
        Next i

        If (validBit1 = False) Then
            MessageBox.Show("Số lượng tối thiểu sau khi bán không thỏa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

#End Region

        'Thêm vào database
        If (dt.Rows.Count > 0) Then
            'Thêm hóa đơn

            Dim HoaDonDTO As New HoaDonDTO
            HoaDonDTO.StrMaHoaDon = HoaDonBUS.PhatSinhMaHoaDon()
            HoaDonDTO.StrMaKhachHang = txtMaKhachHang.Text
            HoaDonDTO.ITongThanhTien = Integer.Parse(txtTongThanhTien.Text.Replace(".", ""))
            HoaDonDTO.DateNgayLapHoaDon = dateNgayNhap.DateTime
            HoaDonBUS.ThemHoaDon(HoaDonDTO)

            'Cập nhật tiền nợ mới của khách hàng
            Dim khachHangDTO As New KhachHangDTO
            khachHangDTO.StrMaKhachHang = txtMaKhachHang.Text
            khachHangDTO.ISoTienNo = KhachHangBUS.getSoTienNo(txtMaKhachHang.Text) + Integer.Parse(txtTongThanhTien.Text.Replace(".", ""))
            KhachHangBUS.CapNhatSoTienNo(khachHangDTO)

            'Thêm chi tiết hóa đơn và cập nhật lượng tồn mới trong sách
            Dim chiTietHoaDonDTO As New ChiTietHoaDonDTO
            For Each row In dt.Rows
                chiTietHoaDonDTO.StrMaChiTietHoaDon = ChiTietHoaDonBUS.PhatSinhMaChiTietHoaDon()
                chiTietHoaDonDTO.StrMaHoaDon = txtMaHoaDon.Text
                chiTietHoaDonDTO.StrMaSach = row("clmMaSach")
                chiTietHoaDonDTO.IDonGiaBan = row("clmDonGia")
                chiTietHoaDonDTO.ISoLuongBan = row("clmSoLuong")
                chiTietHoaDonDTO.IThanhTien = row("clmThanhTien")


                ChiTietHoaDonBUS.ThemChiTietHoaDon(chiTietHoaDonDTO)

                'Cập nhật số lượng tồn mới của sách
                Dim sachDTO As New SachDTO
                sachDTO.StrMaSach = row("clmMaSach")
                sachDTO.ISoLuongTon = SachBUS.getSoLuongTon(sachDTO.StrMaSach) - row("clmSoLuong")
                SachBUS.CapNhatSoLuongTon(sachDTO)


            Next

            MessageBox.Show("Thêm hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnXoaDong.Enabled = False
            btnChonSach.Enabled = False
            btnLuu.Enabled = False
            Grid.Enabled = False
            grpQuyDinh.Enabled = False
            dateNgayNhap.Enabled = False
            grpThongTinKhachHang.Enabled = False
            grpChiTietHoaDon.Enabled = False
            btnIn.Enabled = True

        Else
            MessageBox.Show("Không có đầu sách nào được nhập")
        End If

        'Nếu thêm vào thành công 
    End Sub
    Private Sub btnChonKhachHang_Click(sender As Object, e As EventArgs) Handles btnChonKhachHang.Click
        Dim frmChonKhachHang = New frmChonKhachHang
        frmChonKhachHang.isMultiSelect = False
        frmChonKhachHang.ShowDialog()

        If (frmChonKhachHang.selectedMaKhachHang.Count <> 0) Then

            Dim khachhangINFO As New KhachHangDTO
            khachhangINFO = KhachHangBUS.LayKhachHangDTO(frmChonKhachHang.selectedMaKhachHang(0))

            txtMaKhachHang.Text = khachhangINFO.StrMaKhachHang
            txtHoTenKhachHang.Text = khachhangINFO.StrHoTenKhachHang
            txtDienThoai.Text = khachhangINFO.StrDienThoai
            txtDiaChi.Text = khachhangINFO.StrDiaChi
            txtTienNo.Text = khachhangINFO.ISoTienNo.ToString


        Else

        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click

        Dim HoaDonDTO As New HoaDonDTO
        HoaDonDTO.StrMaHoaDon = txtMaHoaDon.Text
        HoaDonDTO.StrMaKhachHang = txtMaKhachHang.Text
        HoaDonDTO.ITongThanhTien = txtTongThanhTien.Text
        HoaDonDTO.DateNgayLapHoaDon = dateNgayNhap.DateTime

        Dim frmPrint As New frmPreview(New HoaDonBanSachINFO(dt, HoaDonDTO, Integer.Parse(txtTienNo.Text.Replace(",", ""))))
        frmPrint.ShowDialog()

    End Sub
    Private Sub frmHoaDonBanSachGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Cập nhật lại tham số
        txtSoTienNoToiDa.Text = ThamSoBUS.getSoTienNoToiDa()
        txtSoLuongTonToiThieu.Text = ThamSoBUS.getSoLuongTonToiThieu()

        If (txtMaHoaDon.Text <> "") Then
            txtMaHoaDon.Text = HoaDonBUS.PhatSinhMaHoaDon()
        End If


        'Cập nhật lại thông tin các đầu sách
        For i As Integer = 0 To GridView.DataRowCount - 1
            Dim SachINFO As New SachDTO()
            SachINFO = SachBUS.LaySachDTO(GridView.GetRowCellValue(i, "clmMaSach"))

            GridView.SetRowCellValue(i, "clmTenSach", SachINFO.StrTenSach)
            GridView.SetRowCellValue(i, "clmTheLoai", SachINFO.StrTheLoai)
            GridView.SetRowCellValue(i, "clmTacGia", SachINFO.StrTacGia)
            GridView.SetRowCellValue(i, "clmSoLuongTon", SachINFO.ISoLuongTon)
        Next i
    End Sub

    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click
        Dim frmChonSach As New frmChonSach
        frmChonSach.isMultiSelect = True
        frmChonSach.ShowDialog()
        If (frmChonSach.selectedMaSach.Count <> 0) Then
            For Each strMaSach As String In frmChonSach.selectedMaSach
                If (isContainMaSachInList(strMaSach) = False) Then
                    Dim SachINFO As New SachDTO()
                    SachINFO = SachBUS.LaySachDTO(strMaSach)
                    dt.Rows.Add(dt.Rows.Count + 1, SachINFO.StrMaSach, SachINFO.StrTenSach, SachINFO.StrTheLoai, SachINFO.StrTacGia, SachINFO.ISoLuongTon, 0, SachINFO.IDonGiaDuKien, 0)

                    If (SachINFO.ISoLuongTon = 0) Then
                        GridView.GetDataRow(GridView.GetRowHandle(dt.Rows.Count - 1)).RowError = "Số lượng tồn của sách = 0"

                    End If

                Else
                    MessageBox.Show("Mã sách '" + strMaSach + "' đã có trong danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        Else

        End If
    End Sub
#Region "List Sách"
    'Kiểm tra xem ROW có được nhập dữ liệu chưa. Nếu chưa thì không cho nhập số lượng
    Private Sub GridView_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView.ShowingEditor
        Dim view As GridView = sender
        If (view.FocusedColumn.Caption = "Số Lượng" And view.GetDataRow(view.FocusedRowHandle) Is Nothing) Then
            e.Cancel = True

        End If
        If (view.FocusedColumn.Caption = "Đơn Giá (Đồng)" And view.GetDataRow(view.FocusedRowHandle) Is Nothing) Then
            e.Cancel = True

        End If
    End Sub


    'Lấy dữ liệu về các đầu sách vào TextBox
    Private Sub GridView_CustomRowCellEditForEditing(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView.CustomRowCellEditForEditing
        'Dim listSach As New List(Of SachDTO)
        'listSach = SachBUS.LayTatCaSachXapSep()
        'RepositoryItemComboBox1.Items.Clear()
        'For i As Integer = 0 To listSach.Count - 1
        '    RepositoryItemComboBox1.Items.Add(New MyComboBoxItem(listSach(i).StrTenSach, listSach(i).IMaSach))
        'Next
    End Sub


    'Cập nhật thông tin sách khi cell Mã Sách đã có
    Private Sub GridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView.CellValueChanged
        Dim view As GridView = sender

        If (Not IsDBNull(e.Value)) Then
            Dim PhieuNhapSachBUS As New PhieuNhapSachBUS
            Dim SachBUS As New SachBUS
            If (e.Column.Caption = "Mã Sách") Then 'Nhập vào mã sách

                If (SachBUS.isContainMaSach(e.Value) = True) Then 'Kiểm tra xem Mã Sách có tồn tại
                    Dim SachINFO As New SachDTO()
                    SachINFO = SachBUS.LaySachDTO(e.Value)
                    GridView.SetFocusedRowCellValue("clmTenSach", SachINFO.StrTenSach)
                    GridView.SetFocusedRowCellValue("clmTacGia", SachINFO.StrTacGia)
                    GridView.SetFocusedRowCellValue("clmTheLoai", SachINFO.StrTheLoai)
                    GridView.SetFocusedRowCellValue("clmSoLuongTon", SachINFO.ISoLuongTon)
                    GridView.SetFocusedRowCellValue("clmSoLuong", 0)
                    GridView.SetFocusedRowCellValue("clmDonGia", SachINFO.IDonGiaDuKien)
                    If (SachINFO.ISoLuongTon = 0) Then
                        GridView.GetFocusedDataRow().RowError = "Số lượng tồn của sách = 0"
                        MessageBox.Show("Số lượng tồn của sách = 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                    'ĐÁNH SỐ THỨ TỰ 
                    For i As Integer = 0 To view.RowCount - 1
                        If (view.GetDataRow(view.GetRowHandle(i)) Is Nothing) Then
                            Exit For
                        End If
                        view.GetDataRow(view.GetRowHandle(i)).SetField("clmSTT", i + 1)
                    Next

                Else
                    MessageBox.Show("Mã sách không tồn tại!")
                End If
            ElseIf (e.Column.Caption = "Số Lượng" Or e.Column.Caption = "Đơn Giá (Đồng)") Then
                If (view.GetFocusedRowCellValue("clmDonGia").ToString <> "" And view.GetFocusedRowCellValue("clmSoLuong").ToString <> "") Then
                    view.GetFocusedDataRow.SetField("clmThanhTien", view.GetFocusedRowCellValue("clmDonGia") * view.GetFocusedRowCellValue("clmSoLuong"))

                End If
            End If

            'TÍNH TỔNG THÀNH TIỀN
            Dim iThanhTien As Integer

            For i As Integer = 0 To view.RowCount - 1
                If (view.GetDataRow(view.GetRowHandle(i)) Is Nothing) Then
                    Exit For
                End If
                If (view.GetDataRow(view.GetRowHandle(i))("clmThanhTien").ToString() <> "") Then
                    iThanhTien += view.GetDataRow(view.GetRowHandle(i))("clmThanhTien")
                End If
            Next
            txtTongThanhTien.Text = iThanhTien.ToString




        End If


    End Sub


    'Kiểm tra lỗi khi Edit xong Cell
    Private Sub GridView1_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView.ValidatingEditor
        Dim view As GridView = sender
        If (view.FocusedColumn.Name = "clmMaSach") Then
            If (SachBUS.isContainMaSach(GridView.EditingValue.ToString) = False) Then
                e.ErrorText = "Sách không tồn tại"
                e.Valid = False
            ElseIf (isContainMaSachInList(GridView.EditingValue.ToString)) Then
                e.ErrorText = "Sách đã có trong bảng"
                e.Valid = False
            End If
        ElseIf (view.FocusedColumn.Name = "clmSoLuong") Then
            If (view.GetFocusedDataRow("clmMaSach").ToString = "") Then
                Return
            End If
            If (HoaDonBUS.isValidSoLuongBan(view.GetFocusedDataRow("clmMaSach"), Integer.Parse(GridView.EditingValue)) = False) Then
                e.ErrorText = "Số lượng bán không được nhỏ hơn số lượng sách tồn"
                e.Valid = False
            ElseIf (Integer.Parse(GridView.EditingValue) = 0) Then
                e.ErrorText = "Số lượng bán phải lớn hơn 0"
                e.Valid = False
            End If
        ElseIf (view.FocusedColumn.Name = "clmTenSach" And view.GetFocusedDataRow.RowError <> "") Then


            If (view.GetFocusedDataRow.RowError = "-1") Then
                e.ErrorText = "Sách không tồn tại"
                e.Valid = False
            Else
                If (view.GetFocusedDataRow("clmMaSach").ToString <> view.GetFocusedDataRow.RowError) Then

                    If (isContainMaSachInList(view.GetFocusedDataRow.RowError)) Then

                        e.ErrorText = "Sách đã có trong bảng"
                        e.Valid = False
                    Else
                        view.SetFocusedRowCellValue("clmMaSach", view.GetFocusedDataRow.RowError)

                    End If
                Else
                    e.ErrorText = ""
                End If
            End If

        End If
    End Sub


    'Kiểm tra xem sách nhập đã có trong danh sách chưa
    Private Function isContainMaSachInList(value As String) As Boolean


        For i As Integer = 0 To GridView.DataRowCount - 1
            If (GridView.GetRowCellValue(i, "clmMaSach").ToString = "") Then
                Return False
            End If

            If (GridView.GetRowCellValue(i, "clmMaSach") = value) Then
                Return True
            End If
        Next i
        Return False
    End Function

    Private Sub GridView_HiddenEditor(sender As Object, e As EventArgs) Handles GridView.HiddenEditor
        Dim view As GridView = sender
        If (view.GetDataRow(view.FocusedRowHandle) IsNot Nothing) Then
            If (view.GetFocusedDataRow.RowError = "-1") Then

                view.CancelUpdateCurrentRow()

                'ElseIf (view.GetDataRow(view.FocusedRowHandle).Item("clmMaSach").ToString = "") Then
                '    view.CancelUpdateCurrentRow()
            ElseIf (view.GetFocusedDataRow("clmMaSach").ToString = "") Then
                view.CancelUpdateCurrentRow()
            End If

            If (view.GetDataRow(view.FocusedRowHandle) IsNot Nothing) Then
                view.GetFocusedDataRow.RowError = ""
            End If
        End If




    End Sub

    Private Sub RepositoryItemComboBox1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemComboBox1.EditValueChanged
        Dim item As MyComboBoxItem = TryCast(TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit).EditValue, MyComboBoxItem)
        Dim cb As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)

        If (cb.SelectedIndex <> -1) Then
            GridView.GetFocusedDataRow().RowError = item.Tag
        Else
            GridView.GetFocusedDataRow().RowError = "-1"
        End If
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

        Dim menuItemDeleteRow As New DXMenuItem("&Xóa dòng", AddressOf OnDeleteRowClick)
        menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
        'Items.Add(menuItemDeleteRow)
        Return menuItemDeleteRow
    End Function
    Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)
        info.View.DeleteRow(info.RowHandle)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If (GridView.GetFocusedDataRow() IsNot Nothing) Then
            GridView.GetFocusedDataRow().Delete()
        Else
            MessageBox.Show("Không có dòng nào được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub



    Private Sub DefaultToolTipController1_DefaultController_GetActiveObjectInfo(sender As Object, e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles DefaultToolTipController1.DefaultController.GetActiveObjectInfo

        'Dim view As GridView = TryCast(Grid.FocusedView, GridView)
        '    Dim info As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)


        'If info.InRowCell Then
        '            If (view.GetDataRow(info.RowHandle) IsNot Nothing) Then
        '                If (view.GetDataRow(info.RowHandle)("clmMaSach").ToString() <> "") Then
        '                    If (info.Column() Is view.Columns("clmDonGia")) Then
        '                        Dim text As String = "Đơn giá dự kiến : " + SachBUS.getDonGiaDuKien(view.GetDataRow(info.RowHandle)("clmMaSach")).ToString
        '                        Dim cellKey As String = info.RowHandle.ToString() & " - " & info.Column.ToString()
        '                        e.Info = New DevExpress.Utils.ToolTipControlInfo(cellKey, text)
        '                    End If


        '                End If
        '            End If

        '        End If



    End Sub

    Private Sub btnThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuyDinh.Click
        'Mở form thay đổi quy địn
        Dim frmThayDoiQuyDinh = New frmThayDoiQuyDinhGUI
        frmThayDoiQuyDinh.ShowDialog()

        'Cập nhật lại thông số mới
        txtSoLuongTonToiThieu.Text = ThamSoBUS.getSoLuongTonToiThieu().ToString
        txtSoTienNoToiDa.Text = ThamSoBUS.getSoTienNoToiDa().ToString("n0")
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
#End Region






#End Region

End Class