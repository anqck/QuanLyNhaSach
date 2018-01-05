Imports BUSLayer
Imports DevExpress.XtraGrid.Columns
Imports DTO

Public Class frmChonKhachHang
    Dim dt As New DataTable
    Public selectedMaKhachHang As New List(Of String)
    Public isMultiSelect As Boolean


    Private Sub frmChonKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If (isMultiSelect = False) Then
            Grid.MainView = Grid.ViewCollection(0)
        End If


        dt.Columns.Add("clmMaKhachHang", GetType(String))
        dt.Columns.Add("clmHoTenKhachHang", GetType(Object))
        dt.Columns.Add("clmEmail", GetType(String))
        dt.Columns.Add("clmDienThoai", GetType(String))
        dt.Columns.Add("clmDiaChi", GetType(String))
        dt.Columns.Add("clmSoTienNo", GetType(Integer))
        Grid.DataSource = dt

        Dim khachhangINFO As New List(Of KhachHangDTO)
        khachhangINFO = KhachHangBUS.LayTatCaKhachHang()

        For i As Integer = 0 To khachhangINFO.Count - 1
            dt.Rows.Add(khachhangINFO(i).StrMaKhachHang, khachhangINFO(i).StrHoTenKhachHang, khachhangINFO(i).StrEmail, khachhangINFO(i).StrDienThoai, khachhangINFO(i).StrDiaChi, khachhangINFO(i).ISoTienNo)
        Next



    End Sub



    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click

        selectedMaKhachHang.Clear()
        If (Grid.MainView Is Grid.ViewCollection(0)) Then
            If (GridView1.GetFocusedRowCellValue("clmMaKhachHang").ToString <> "") Then
                selectedMaKhachHang.Add(GridView1.GetFocusedRowCellValue("clmMaKhachHang"))
            Else
                MessageBox.Show("Không có khách hàng nào được chọn! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If


        Else
            For Each row In GridView.GetSelectedRows()
                selectedMaKhachHang.Add(GridView.GetDataRow(row)("clmMaKhachHang"))
            Next

            If selectedMaKhachHang.Count = 0 Then
                MessageBox.Show("Không có khách hàng nào được chọn! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

        End If

        Me.Close()

    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub txtMaKhachHang_EditValueChanged(sender As Object, e As EventArgs) Handles txtMaKhachHang.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonKhachHangBUS.ChuanHoaDieuKienTheoMaKhachHang(txtMaKhachHang.Text))

        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmMaKhachHang"), columnfilter)
        'GridView.ActiveFilter.NonColumnFilter = ChonSachBUS.ChuanHoaDieuKienTheoMaSach(txtMaSach.Text)
    End Sub


    Private Sub txtTenKhachHang_EditValueChanged(sender As Object, e As EventArgs) Handles txtHoTenKhachHang.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonKhachHangBUS.ChuanHoaDieuKienTheoHoTenKhachHang(txtHoTenKhachHang.Text))
        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmHoTenKhachHang"), columnfilter)
    End Sub

    Private Sub txtDienThoai_EditValueChanged(sender As Object, e As EventArgs) Handles txtDienThoai.EditValueChanged
        Dim columnfilter As New ColumnFilterInfo(ChonKhachHangBUS.ChuanHoaDieuKienTheoDienThoai(txtDienThoai.Text))
        TryCast(Grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView).ActiveFilter.Add(GridView.Columns("clmDienThoai"), columnfilter)
    End Sub
End Class


