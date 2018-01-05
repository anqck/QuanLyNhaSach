Imports BUSLayer
Imports DALLayer
Imports DTO
Public Class frmThemNguoiDung
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click

        If (txtHoTenNguoiDung.Text = "") Then
            MessageBox.Show("Chưa nhập họ tên người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtHoTenNguoiDung.ErrorText = "Chưa nhập họ tên người dùng!"
            Return
        End If

        If (txtTenDangNhap.Text = "") Then
            MessageBox.Show("Chưa nhập tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTenDangNhap.ErrorText = "Chưa nhập tên đăng nhập!"
            Return
        End If

        If (txtMatKhau.Text = "") Then
            MessageBox.Show("Chưa nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMatKhau.ErrorText = "Chưa nhập mật khẩu!"
            Return
        End If
        If (CmbLoaiNguoiDung.Text = "Chọn loại người dùng") Then
            MessageBox.Show("Vui lòng chọn loại người dùng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' CmbLoaiNguoiDung.ErrorText = "chọn loại người dùng!"
            Return
        End If

        'If (txtDonGiaDuKien.Text = "") Then
        '    MessageBox.Show("Chưa nhập đơn giá dự kiến!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtDonGiaDuKien.ErrorText = "Chưa nhập đơn giá dự kiến!"
        '    Return
        'End If

        'Thêm Sách Vào DB

        'Dim sachDTO As New SachDTO()
        'sachDTO.StrMaSach = SachBUS.PhatSinhMaSach()
        'sachDTO.StrTenSach = txtTenSach.Text
        'sachDTO.StrTacGia = txtTacGia.Text
        'sachDTO.StrTheLoai = txtTheLoai.Text
        'sachDTO.IDonGiaDuKien = Integer.Parse(txtDonGiaDuKien.Text.Replace(".", ""))
        Dim nguoidungDTO As New NguoiDungDTO()
        nguoidungDTO.StrMaNguoiDung = NguoiDungBUS.PhatSinhMaNguoiDung()
        nguoidungDTO.StrHoTenNguoiDung = txtHoTenNguoiDung.Text
        nguoidungDTO.StrTenDangNhap = txtTenDangNhap.Text
        nguoidungDTO.StrMatKhau = txtMatKhau.Text
        nguoidungDTO.StrMaLoaiNguoiDung = LoaiNguoiDungBUS.getMaLoaiNguoiDung(CmbLoaiNguoiDung.Text)

        NguoiDungBUS.ThemNguoiDung(nguoidungDTO)
        MessageBox.Show("Thêm vào thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'SachBUS.ThemSachVaoDB(sachDTO)
        'MessageBox.Show("Thêm vào thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'txtMaNguoiDung.Text = NguoiDungBUS.PhatSinhMaNguoiDung()
        'txtHoTenNguoiDung.Text = ""
        'txtTenDangNhap.Text = ""
        'txtMatKhau.Text = ""
        'CmbLoaiNguoiDung.Text = "Someone"
        'CmbLoaiNguoiDung.Items.Add("Admin")
        'CmbLoaiNguoiDung.Items.Add("User")
        'CmbLoaiNguoiDung.Items.Add("Someone")
        Me.Close()

    End Sub

    Private Sub frmThemNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaNguoiDung.Text = NguoiDungBUS.PhatSinhMaNguoiDung()
        txtHoTenNguoiDung.Text = ""
        txtTenDangNhap.Text = ""
        txtMatKhau.Text = ""
        CmbLoaiNguoiDung.Text = "Chọn loại người dùng"
        For Each loainguoidungINFO In LoaiNguoiDungBUS.LayTatCaLoaiNguoiDung()
            CmbLoaiNguoiDung.Items.Add(loainguoidungINFO.StrTenLoaiNguoiDung)
        Next

    End Sub
End Class