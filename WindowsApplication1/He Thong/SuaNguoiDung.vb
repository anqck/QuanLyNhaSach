Imports BUSLayer
Imports DTO
Public Class frmSuaNguoiDung
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtHoTenNguoiDung.Enabled = False
        txtTenDangNhap.Enabled = False
        txtMatKhau.Enabled = False
        cmbLoaiNguoiDung.Enabled = False

        btnLuu.Enabled = False
    End Sub

    Public Sub New(strMaNguoiDung As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtMaNguoiDung.Text = strMaNguoiDung
        Dim nguoidungINFO As NguoiDungDTO = NguoiDungBUS.LayNguoiDungDTO(strMaNguoiDung)

        txtHoTenNguoiDung.Text = nguoidungINFO.StrHoTenNguoiDung
        txtTenDangNhap.Text = nguoidungINFO.StrTenDangNhap
        txtMatKhau.Text = nguoidungINFO.StrMatKhau
        cmbLoaiNguoiDung.Text = LoaiNguoiDungBUS.getTenLoaiNguoiDung(nguoidungINFO.StrMaLoaiNguoiDung)
    End Sub

    Private Sub btnChonNguoiDung_Click(sender As Object, e As EventArgs)

        'Dim frmChonSach As New frmChonSach()
        'frmChonSach.isMultiSelect = False
        'frmChonSach.ShowDialog()

        'If (frmChonSach.selectedMaSach.Count <> 0) Then
        '    txtTacGia.Enabled = True
        '    txtTenSach.Enabled = True
        '    txtTheLoai.Enabled = True
        '    txtDonGiaDuKien.Enabled = True
        '    btnLuu.Enabled = True

        '    Dim sachINFO As SachDTO = SachBUS.LaySachDTO(frmChonSach.selectedMaSach(0))

        '    txtMaSach.Text = sachINFO.StrMaSach
        '    txtTacGia.Text = sachINFO.StrTacGia
        '    txtTenSach.Text = sachINFO.StrTenSach
        '    txtTheLoai.Text = sachINFO.StrTheLoai
        '    txtDonGiaDuKien.Text = sachINFO.IDonGiaDuKien


        'End If
    End Sub

    Private Sub frmSuaNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each loainguoidungINFO In LoaiNguoiDungBUS.LayTatCaLoaiNguoiDung()
            cmbLoaiNguoiDung.Items.Add(loainguoidungINFO.StrTenLoaiNguoiDung)
        Next

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click

        Dim nguoidungDTO As New NguoiDungDTO()
        nguoidungDTO.StrMaNguoiDung = Me.txtMaNguoiDung.Text
        nguoidungDTO.StrHoTenNguoiDung = Me.txtHoTenNguoiDung.Text
        nguoidungDTO.StrTenDangNhap = Me.txtTenDangNhap.Text
        nguoidungDTO.StrMatKhau = Me.txtMatKhau.Text
        nguoidungDTO.StrMaLoaiNguoiDung = LoaiNguoiDungBUS.getMaLoaiNguoiDung(cmbLoaiNguoiDung.Text)


        NguoiDungBUS.CapNhatNguoiDung(nguoidungDTO)
        MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub



    'Khi Active form kiểm tra xem thông tin có thay đổi từ Form khác
    'Private Sub frmSuaNguoiDung_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


    '    'Nạp tất cả thể loại
    '    Dim listTheLoai As New List(Of String)
    '    listTheLoai = TraCuuSachBUS.getTatCaTheLoaiSach()
    '    For Each strTheLoai In listTheLoai
    '        If (txtTheLoai.Properties.Items.Contains(strTheLoai) = False) Then
    '            txtTheLoai.Properties.Items.Add(strTheLoai)
    '        End If

    '    Next

    '    'Nạp tất cả các tác giả
    '    Dim listTacGia As New List(Of String)
    '    listTacGia = TraCuuSachBUS.getTatCaTacGiaSach()
    '    For Each strTacGia In listTacGia
    '        If (txtTacGia.Properties.Items.Contains(strTacGia) = False) Then
    '            txtTacGia.Properties.Items.Add(strTacGia)
    '        End If

    '    Next
    'End Sub
End Class