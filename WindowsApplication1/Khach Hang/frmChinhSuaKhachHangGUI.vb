Imports BUSLayer
Imports DTO

Public Class frmChinhSuaKhachHangGUI
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtDienThoai.Enabled = False
        txtEmail.Enabled = False
        txtDiaChi.Enabled = False
        txtHoTenKH.Enabled = False

        btnLuu.Enabled = False
    End Sub

    Public Sub New(strMaKhachHang As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtMaKH.Text = strMaKhachHang
        Dim khachhangINFO As KhachHangDTO = KhachHangBUS.LayKhachHangDTO(strMaKhachHang)

        txtDienThoai.Text = khachhangINFO.StrDienThoai
        txtEmail.Text = khachhangINFO.StrEmail
        txtDiaChi.Text = khachhangINFO.StrDiaChi
        txtHoTenKH.Text = khachhangINFO.StrHoTenKhachHang



        btnChonSach.Visible = False

    End Sub

    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click
        Dim frmchonkhachhang As New frmChonKhachHang()
        frmchonkhachhang.isMultiSelect = False
        frmchonkhachhang.ShowDialog()

        If (frmchonkhachhang.selectedMaKhachHang.Count <> 0) Then
            txtDienThoai.Enabled = True
            txtEmail.Enabled = True
            txtDiaChi.Enabled = True
            txtHoTenKH.Enabled = True

            btnLuu.Enabled = True

            Dim khachhangINFO As KhachHangDTO = KhachHangBUS.LayKhachHangDTO(frmchonkhachhang.selectedMaKhachHang(0))

            txtMaKH.Text = khachhangINFO.StrMaKhachHang
            txtDienThoai.Text = khachhangINFO.StrDienThoai
            txtEmail.Text = khachhangINFO.StrEmail
            txtDiaChi.Text = khachhangINFO.StrDiaChi
            txtHoTenKH.Text = khachhangINFO.StrHoTenKhachHang



        End If



    End Sub

    'Khi Active form kiểm tra xem thông tin có thay đổi từ Form khác
    Private Sub frmChinhSuaSachGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


    End Sub


    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        'Thêm Sách Vào DB

        Dim khachhangDTO As New KhachHangDTO()
        khachhangDTO.StrMaKhachHang = txtMaKH.Text
        khachhangDTO.StrDienThoai = txtDienThoai.Text
        khachhangDTO.StrEmail = txtEmail.Text
        khachhangDTO.StrDiaChi = txtDiaChi.Text
        khachhangDTO.StrHoTenKhachHang = txtHoTenKH.Text



        KhachHangBUS.CapNhatKhachHang(khachhangDTO)
        MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)




    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmChinhSuaSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class