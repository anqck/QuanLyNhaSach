Imports BUSLayer
Imports DevExpress.XtraGrid.Columns
Public Class frmPhanquyen
    Dim dataset As New DataSet
    Dim dtNguoiDung As New DataTable()
    '  Dim dtHoaDon As New DataTable()
    '  Dim dtPhieuThuTien As New DataTable

    Private Sub frmPhanquyen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtNguoiDung.Columns.Add("clmSTT", GetType(Integer))
        dtNguoiDung.Columns.Add("clmMaNguoiDung", GetType(String))
        dtNguoiDung.Columns.Add("clmHoTenNguoiDung", GetType(String))
        dtNguoiDung.Columns.Add("clmTenDangNhap", GetType(String))
        dtNguoiDung.Columns.Add("clmMatKhau", GetType(String))
        dtNguoiDung.Columns.Add("clmMaLoaiNguoiDung", GetType(String))
        dtNguoiDung.TableName = "NguoiDung"


        dataset.Tables.Add(dtNguoiDung)
        ' dataset.Relations.Add("ThongTinHoaDon", dataset.Tables("NguoiDung").Columns("clmMaNguoiDung"), dataset.Tables("HoaDon").Columns("clmMaNguoiDung"))
        ' dataset.Relations.Add("ThongTinPhieuThuTien", dataset.Tables("NguoiDung").Columns("clmMaNguoiDung"), dataset.Tables("PhieuThuTien").Columns("clmMaNguoiDung"))

        mainGrid.DataSource = dataset.Tables("NguoiDung")
        ' mainGrid.LevelTree.Nodes.Add("ThongTinPhieuThuTien", mainGrid)
        'btnSua.Enabled = False
    End Sub

    Private Sub frmPhanquyen_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        dtNguoiDung.Rows.Clear()

        'Nạp danh sách khách hàng
        For Each nguoidungINFO In NguoiDungBUS.LayTatCaNguoiDung()
            dtNguoiDung.Rows.Add(dtNguoiDung.Rows.Count + 1, nguoidungINFO.StrMaNguoiDung, nguoidungINFO.StrHoTenNguoiDung, nguoidungINFO.StrTenDangNhap, nguoidungINFO.StrMatKhau, LoaiNguoiDungBUS.getTenLoaiNguoiDung(nguoidungINFO.StrMaLoaiNguoiDung))
            ' Console.WriteLine(nguoidungINFO.StrMaLoaiNguoiDung)
        Next

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim themNguoiDung As New frmThemNguoiDung
        themNguoiDung.ShowDialog()
        Me.OnActivated(e)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim suaNguoiDung As New frmSuaNguoiDung(Me.GridView.GetRowCellValue(Me.GridView.FocusedRowHandle, "clmMaNguoiDung"))

        ' lay ma nguoi dung tu grid view dc chon
        ' Me.GridView.GetRowCellValue(Me.GridView.FocusedRowHandle, "clmMaNguoiDung")

        suaNguoiDung.ShowDialog()
        Me.OnActivated(e)
    End Sub

    Private Sub mainGrid_Click(sender As Object, e As EventArgs) Handles mainGrid.Click

    End Sub
End Class