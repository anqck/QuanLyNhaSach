Imports System.ComponentModel
Imports BUSLayer
Imports DALLayer
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DTO

Public Class frmPhieuNhapSachGUI


    Dim dt As DataTable

    'Khởi tạo giá trị mặc định cho Form
    Private Sub Init()
        grpQuyDinh.Enabled = False

        GroupControl2.Enabled = False

        btnChonSach.Enabled = False
        btnDelete.Enabled = False
        btnLuu.Enabled = False
        dateNgayNhap.Enabled = False

    End Sub

    Private Sub frmPhieuNhapSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    'Khởi tạo giá trị mặc định cho Row mới
    Private Sub GridView_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView.InitNewRow
        GridView.GetFocusedDataRow("clmSoLuongNhap") = 0

    End Sub

#Region "Button"
    Private Sub btnThoat_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        dt = New DataTable()
        txtMaPhieuNhap.Text = PhieuNhapSachBUS.PhatSinhMaPhieuNhap()

        dt.Columns.Add("clmSTT", GetType(String))
        dt.Columns.Add("clmMaSach", GetType(String))
        dt.Columns.Add("clmTenSach", GetType(Object))
        dt.Columns.Add("clmTheLoai", GetType(String))
        dt.Columns.Add("clmTacGia", GetType(String))
        dt.Columns.Add("clmSoLuongTon", GetType(Integer))
        dt.Columns.Add("clmSoLuongNhap", GetType(Integer))
        Grid.DataSource = dt

        'Cập nhật đầu sách cho CB
        Dim listSach As New List(Of SachDTO)
        listSach = SachBUS.LayTatCaSachXapSep()
        RepositoryItemComboBox1.Items.Clear()
        For i As Integer = 0 To listSach.Count - 1
            RepositoryItemComboBox1.Items.Add(New MyComboBoxItem(listSach(i).StrTenSach, listSach(i).StrMaSach))
        Next

        btnChonSach.Enabled = True
        btnLuu.Enabled = True
        GroupControl2.Enabled = True
        btnDelete.Enabled = True
        grpQuyDinh.Enabled = True

        dateNgayNhap.DateTime = Date.Now.ToString("MM/dd/yyyy")
        dateNgayNhap.Enabled = True
    End Sub

    'Button Lưu
    Public Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        GridView.UpdateCurrentRow()

        Dim bitCheck As Boolean = True

        'Kiểm tra các số lượng có thỏa yêu cầu
        For i As Integer = 0 To GridView.DataRowCount - 1
            If (PhieuNhapSachBUS.isValidSoLuongNhapToiThieu(GridView.GetRowCellValue(i, "clmSoLuongNhap").ToString) = False) Then
                GridView.GetDataRow(GridView.GetRowHandle(i)).RowError = "Số lượng nhập không thỏa quy định"
                bitCheck = False
            End If
        Next i

        If (bitCheck = False) Then
            MessageBox.Show("Số lượng nhập không thỏa quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

        For i As Integer = 0 To GridView.DataRowCount - 1
            If (PhieuNhapSachBUS.isValidSoLuongTonToiDa(GridView.GetRowCellValue(i, "clmSoLuongTon")) = False) Then
                GridView.GetDataRow(GridView.GetRowHandle(i)).RowError = "Số lượng nhập không thỏa quy định"
                bitCheck = False
            End If
        Next i

        If (bitCheck = False) Then
            MessageBox.Show("Số lượng tồn không thỏa quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If


        'Thêm vào database
        If (dt.Rows.Count > 0) Then
            'Thêm phiếu nhập
            Dim phieuNhapDTO As New PhieuNhapSachDTO
            phieuNhapDTO.DateNgayNhap = dateNgayNhap.DateTime
            phieuNhapDTO.IMaPhieuNhap = PhieuNhapSachBUS.PhatSinhMaPhieuNhap()
            PhieuNhapSachBUS.ThemPhieuNhap(phieuNhapDTO)

            'Thêm chi tiết phiếu nhập và cập nhật lượng tồn mới trong sách
            Dim chiTietPhieuNhapDTO As New ChiTietPhieuNhapDTO
            For Each row In dt.Rows
                chiTietPhieuNhapDTO.IMaChiTietPhieuNhap = ChiTietPhieuNhapBUS.PhatSinhMaChiTietPhieuNhap()
                chiTietPhieuNhapDTO.IMaPhieuNhap = PhieuNhapSachBUS.PhatSinhMaPhieuNhap()
                chiTietPhieuNhapDTO.IMaSach = row("clmMaSach")
                chiTietPhieuNhapDTO.ISoLuongNhap = row("clmSoLuongNhap")
                ChiTietPhieuNhapBUS.ThemChiTietPhieuNhap(chiTietPhieuNhapDTO)

                'Cập nhật số lượng tồn mới của đầu sách
                Dim sachDTO As New SachDTO
                sachDTO.StrMaSach = row("clmMaSach")
                sachDTO.ISoLuongTon = row("clmSoLuongNhap") + row("clmSoLuongTon")
                SachBUS.CapNhatSoLuongTon(sachDTO)

            Next

            MessageBox.Show("Thêm phiếu nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnChonSach.Enabled = False
            btnDelete.Enabled = False
            btnLuu.Enabled = False
            GroupControl2.Enabled = False
            grpQuyDinh.Enabled = False
            txtMaPhieuNhap.Text = ""
            dateNgayNhap.Enabled = False
            dateNgayNhap.Text = ""
            dt.Clear()

        Else
            MessageBox.Show("Không có đầu sách nào được nhập")
        End If

        'Nếu thêm vào thành công 
    End Sub

    'Button chọn sách
    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click
        Dim frmChonSach As New frmChonSach
        frmChonSach.isMultiSelect = True
        frmChonSach.ShowDialog()
        If (frmChonSach.selectedMaSach.Count <> 0) Then
            For Each strMaSach As String In frmChonSach.selectedMaSach
                If (isContainMaSachInList(strMaSach) = False) Then
                    Dim SachINFO As New SachDTO()
                    SachINFO = SachBUS.LaySachDTO(strMaSach)
                    dt.Rows.Add(dt.Rows.Count + 1, SachINFO.StrMaSach, SachINFO.StrTenSach, SachINFO.StrTheLoai, SachINFO.StrTacGia, SachINFO.ISoLuongTon, 0)
                Else
                    MessageBox.Show("Mã sách '" + strMaSach + "' đã có trong danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        Else

        End If
    End Sub

    'Button xóa dòng đang chọn
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (GridView.GetFocusedDataRow() IsNot Nothing) Then
            GridView.GetFocusedDataRow().Delete()
        Else
            MessageBox.Show("Không có dòng nào được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    'Button thoát
    Private Sub btnThoat_Click_1(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    'Button thay đổi quy định
    Private Sub btnThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuyDinh.Click
        'Mở form thay đổi quy địn
        Dim frmThayDoiQuyDinh = New frmThayDoiQuyDinhGUI
        frmThayDoiQuyDinh.ShowDialog()

        'Cập nhật lại thông số mới
        txtSoLuongNhapToiThieu.Text = ThamSoBUS.getSoLuongNhapToiThieu()
        txtSoLuongTonToiDa.Text = ThamSoBUS.getSoLuongTonToiDa()
    End Sub
#End Region

#Region "List Sách"
    'Kiểm tra xem ROW có được nhập dữ liệu chưa. Nếu chưa thì không cho nhập số lượng
    Private Sub GridView_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView.ShowingEditor
        Dim view As GridView = sender
        If (view.FocusedColumn.Caption = "Số lượng nhập" And view.GetDataRow(view.FocusedRowHandle) Is Nothing) Then
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
            End If

            
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
        ElseIf (view.FocusedColumn.Name = "clmSoLuongNhap") Then
            If (PhieuNhapSachBUS.isValidSoLuongNhapToiThieu(GridView.EditingValue) = False) Then
                e.ErrorText = "Số lượng nhập không thỏa quy định"
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

        Dim menuItemDeleteRow As New DXMenuItem("&Delete Row", AddressOf OnDeleteRowClick)
        menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
        'Items.Add(menuItemDeleteRow)
        Return menuItemDeleteRow
    End Function
    Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)
        info.View.DeleteRow(info.RowHandle)
    End Sub


#End Region
#End Region


    'Cập nhật lại thông tin trên Form khi được Active
    Private Sub frmPhieuNhapSachGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtSoLuongNhapToiThieu.Text = ThamSoBUS.getSoLuongNhapToiThieu()
        txtSoLuongTonToiDa.Text = ThamSoBUS.getSoLuongTonToiDa()

        If (txtMaPhieuNhap.Text <> "") Then
            txtMaPhieuNhap.Text = PhieuNhapSachBUS.PhatSinhMaPhieuNhap()
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


End Class
Class RowInfo
    Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
        Me.RowHandle = rowHandle
        Me.View = view
    End Sub 'New
    Public View As GridView
    Public RowHandle As Integer
End Class

Public Class MyComboBoxItem

    Public Sub New(text As String, tag As Object)
        _Text = text
        _Tag = tag
    End Sub
    Private _Text As String
    Public Property Text() As String
        Get
            Return _Text
        End Get
        Set
            _Text = Value
        End Set
    End Property

    Private _Tag As Object
    Public Property Tag() As Object
        Get
            Return _Tag
        End Get
        Set
            _Tag = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class