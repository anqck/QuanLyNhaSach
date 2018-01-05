Imports BUSLayer
Imports DTO

Public Class frmThemKhachHangGUI
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        'Kiểm tra xem nhập đủ thông tin chưa
        If (txtHoTenKhachHang.Text = "") Then
            MessageBox.Show("Chưa nhập họ tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtHoTenKhachHang.ErrorText = "Chưa nhập họ tên khách hàng!"
            Return
        End If

        If (txtDiaChi.Text = "") Then
            MessageBox.Show("Chưa nhập địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDiaChi.ErrorText = "Chưa nhập địa chỉ!"
            Return
        End If

        'Thêm khách hàng vào DB
        Dim khachhangDTO As New KhachHangDTO()

        khachhangDTO.StrMaKhachHang = txtMaKhachHang.Text
        khachhangDTO.StrHoTenKhachHang = txtHoTenKhachHang.Text
        khachhangDTO.StrDiaChi = txtDiaChi.Text
        khachhangDTO.StrEmail = txtEmail.Text
        khachhangDTO.ISoTienNo = 0
        khachhangDTO.StrDienThoai = txtSoDienThoai.Text


        KhachHangBUS.ThemKhachHang(khachhangDTO)

        MessageBox.Show("Thêm vào thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


        grpThongTinSach.Enabled = False
    End Sub

    Private Sub frmThemkhachhangGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDiaChi.Enabled = False
        txtEmail.Enabled = False
        txtSoDienThoai.Enabled = False
        txtHoTenKhachHang.Enabled = False
        btnLuu.Enabled = False
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        grpThongTinSach.Enabled = True

        txtSoDienThoai.Text = ""
        txtEmail.Text = ""
        txtDiaChi.Text = ""
        txtHoTenKhachHang.Text = ""

        txtMaKhachHang.Text = KhachHangBUS.PhatSinhMaKhachHang()
        txtDiaChi.Enabled = True
        txtEmail.Enabled = True
        txtSoDienThoai.Enabled = True
        txtHoTenKhachHang.Enabled = True
        btnLuu.Enabled = True
    End Sub

    Private Sub txtHoTenKhachHang_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoTenKhachHang.Validating
        If (txtHoTenKhachHang.Text = "") Then

            txtHoTenKhachHang.ErrorText = "Chưa nhập họ tên khách hàng!"
            e.Cancel = True

        Else
            txtHoTenKhachHang.ErrorText = ""
        End If
    End Sub

    Private Sub txtDiaChi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDiaChi.Validating
        If (txtDiaChi.Text = "") Then

            txtDiaChi.ErrorText = "Chưa nhập địa chỉ!"
            e.Cancel = True
        Else
            txtDiaChi.ErrorText = ""

        End If
    End Sub

    Private Sub frmThemKhachHangGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If (txtMaKhachHang.Text <> "") Then
            txtMaKhachHang.Text = KhachHangBUS.PhatSinhMaKhachHang()
        End If
    End Sub
End Class