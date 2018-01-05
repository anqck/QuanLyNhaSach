Imports BUSLayer
Imports DevExpress.XtraGrid.Columns
Imports DTO

Public Class frmChonSach

    Dim dt As New DataTable
    Public selectedMaSach As New List(Of String)
    Public isMultiSelect As Boolean


    Private Sub frmChonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid.AllowRestoreSelectionAndFocusedRow = True

        If (isMultiSelect = False) Then
            Grid.MainView = Grid.ViewCollection(0)
        End If

        'Nạp tất cả thể loại
        Dim listTheLoai As New List(Of String)
        listTheLoai = TraCuuSachBUS.getTatCaTheLoaiSach()
        For Each strTheLoai In listTheLoai
            cbTheLoai.Properties.Items.Add(strTheLoai)
        Next
        cbTheLoai.CheckAll()

        'Nạp tất cả các tác giả
        Dim listTacGia As New List(Of String)
        listTacGia = TraCuuSachBUS.getTatCaTacGiaSach()
        For Each strTacGia In listTacGia
            cbTacGia.Properties.Items.Add(strTacGia)
        Next
        cbTacGia.CheckAll()

        dt.Columns.Add("clmSelect", GetType(Boolean))
        dt.Columns.Add("clmMaSach", GetType(String))
        dt.Columns.Add("clmTenSach", GetType(Object))
        dt.Columns.Add("clmTheLoai", GetType(String))
        dt.Columns.Add("clmTacGia", GetType(String))
        dt.Columns.Add("clmSoLuongTon", GetType(Integer))
        dt.Columns.Add("clmDonGiaDuKien", GetType(Integer))
        Grid.DataSource = dt

        Dim sach As New List(Of SachDTO)
        sach = SachBUS.LayTatCaSach()

        For i As Integer = 0 To sach.Count - 1
            dt.Rows.Add(False, sach(i).StrMaSach, sach(i).StrTenSach, sach(i).StrTheLoai, sach(i).StrTacGia, sach(i).ISoLuongTon, sach(i).IDonGiaDuKien)
        Next



    End Sub

    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click

        selectedMaSach.Clear()

        If (Grid.MainView Is Grid.ViewCollection(0)) Then 'MultiSelect = False

            If (GridView1.GetFocusedRowCellValue("clmMaSach").ToString <> "") Then
                selectedMaSach.Add(GridView1.GetFocusedRowCellValue("clmMaSach"))
            Else
                MessageBox.Show("Không có sách nào được chọn! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If


        Else
            For Each row In dt.Rows
                If (row("clmSelect") = True) Then
                    selectedMaSach.Add(row("clmMaSach"))
                End If

            Next

            If selectedMaSach.Count = 0 Then
                MessageBox.Show("Không có sách nào được chọn! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

        End If

        Me.Close()

    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub txtMaSach_EditValueChanged(sender As Object, e As EventArgs) Handles txtMaSach.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonSachBUS.ChuanHoaDieuKienTheoMaSach(txtMaSach.Text))

        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmMaSach"), columnfilter)
        'GridView.ActiveFilter.NonColumnFilter = ChonSachBUS.ChuanHoaDieuKienTheoMaSach(txtMaSach.Text)
    End Sub

    Private Sub cbTheLoai_EditValueChanged(sender As Object, e As EventArgs) Handles cbTheLoai.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonSachBUS.ChuanHoaDieuKienTheoTheLoai(cbTheLoai.Text))
        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmTheLoai"), columnfilter)
        'GridView.ActiveFilter.NonColumnFilter = ChonSachBUS.ChuanHoaDieuKienTheoTheLoai(cbTheLoai.Text)

    End Sub

    Private Sub cbTacGia_EditValueChanged(sender As Object, e As EventArgs) Handles cbTacGia.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonSachBUS.ChuanHoaDieuKienTheoTacGia(cbTacGia.Text))
        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmTacGia"), columnfilter)
        ' GridView.ActiveFilter.NonColumnFilter = ChonSachBUS.ChuanHoaDieuKienTheoTacGia(cbTacGia.Text)
    End Sub

    Private Sub txtTenSach_EditValueChanged(sender As Object, e As EventArgs) Handles txtTenSach.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonSachBUS.ChuanHoaDieuKienTheoTenSach(txtTenSach.Text))
        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmTenSach"), columnfilter)
    End Sub


End Class