Imports BUSLayer
Imports DTO

Public Class frmPhieuThuTienGUI


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

            txtMaKhachHang.ErrorText = ""
        Else

        End If
    End Sub

    Private Sub frmPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub Init()
        grpThongTinKhachHang.Enabled = False
        grpQuyDinh.Enabled = False
        grpChiTietPhieuThu.Enabled = False
        btnLuu.Enabled = False
        btnIn.Enabled = False
        dateNgayThu.Enabled = False
    End Sub

    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        btnLuu.Enabled = True
        dateNgayThu.Enabled = True
        grpThongTinKhachHang.Enabled = True
        grpQuyDinh.Enabled = True
        grpChiTietPhieuThu.Enabled = True

        txtMaKhachHang.Text = ""
        txtHoTenKhachHang.Text = ""
        txtDiaChi.Text = ""
        txtDienThoai.Text = ""
        txtTienNo.Text = ""
        txtSoTienThu.Text = ""


        txtMaPhieuThuTien.Text = PhieuThuTienBUS.PhatSinhMaPhieuThuTien()
        dateNgayThu.DateTime = Today.ToShortDateString

    End Sub

    Private Sub frmPhieuThuTien_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If (txtMaPhieuThuTien.Text <> "") Then
            txtMaPhieuThuTien.Text = PhieuThuTienBUS.PhatSinhMaPhieuThuTien()
        End If

        'Cập nhật lại quy định
        chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked = ThamSoBUS.getApDungQuyDinhTienThuKhongVuotTienNo()

        If (txtSoTienThu.ErrorText <> "" And chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked = False) Then
            txtSoTienThu.ErrorText = ""
        End If

        'Cập nhật lại thông tin khách hàng
        If (txtHoTenKhachHang.Text <> "") Then
            Dim khachhangINFO As New KhachHangDTO
            khachhangINFO = KhachHangBUS.LayKhachHangDTO(txtMaKhachHang.Text)

            txtHoTenKhachHang.Text = khachhangINFO.StrHoTenKhachHang
            txtDienThoai.Text = khachhangINFO.StrDienThoai
            txtDiaChi.Text = khachhangINFO.StrDiaChi
            txtTienNo.Text = khachhangINFO.ISoTienNo.ToString
        End If

    End Sub

    Private Sub btnThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuyDinh.Click
        Dim frmThayDoiQuyDinh = New frmThayDoiQuyDinhGUI
        frmThayDoiQuyDinh.ShowDialog()

        chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked = ThamSoBUS.getApDungQuyDinhTienThuKhongVuotTienNo()

        If (txtSoTienThu.ErrorText <> "" And chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked = False) Then
            txtSoTienThu.ErrorText = ""
        End If

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click

        'Kiểm tra xem nhập khách hàng chưa
        If (txtMaKhachHang.Text = "") Then
            txtMaKhachHang.ErrorText = "Chưa nhập khách hàng"
            MessageBox.Show("Chưa nhập thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Kiểm tra xem nhập số tiền thu
        If (txtSoTienThu.Text = "") Then
            txtSoTienThu.ErrorText = "Chưa nhập số tiền thu"
            MessageBox.Show("Chưa nhập số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return

        ElseIf (Long.Parse(txtSoTienThu.Text.Replace(".", "")) <= 0) Then
            txtSoTienThu.ErrorText = "Số tiền thu không được <= 0"
            MessageBox.Show("Số tiền thu không được <= 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return

        End If

        'Kiểm tra quy định
        If (ThamSoBUS.getApDungQuyDinhTienThuKhongVuotTienNo() = True) Then
            If (Integer.Parse(txtTienNo.Text.Replace(".", "")) < Long.Parse(txtSoTienThu.Text.Replace(".", ""))) Then
                txtSoTienThu.ErrorText = "Số tiền thu không được vượt quá số tiền khách hàng đang nợ"
                MessageBox.Show("Số tiền thu không được vượt quá số tiền khách hàng đang nợ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return

            End If
        End If

        'Lưu xuống DB
        Dim PhieuThuTienINFO As New PhieuThuTienDTO


        PhieuThuTienINFO.StrMaPhieuThu = PhieuThuTienBUS.PhatSinhMaPhieuThuTien()
        PhieuThuTienINFO.StrMaKhachHang = txtMaKhachHang.Text
        PhieuThuTienINFO.DateNgayThuTien = dateNgayThu.DateTime
        PhieuThuTienINFO.ISoTienThu = Integer.Parse(txtSoTienThu.Text.Replace(".", ""))

        PhieuThuTienBUS.luuPhieuThuTien(PhieuThuTienINFO)

        'Cập nhật lại tiền nợ của khách hàng
        PhieuThuTienBUS.CapNhatTienNoMoi(txtMaKhachHang.Text, Integer.Parse(txtTienNo.Text.Replace(".", "")) - Integer.Parse(txtSoTienThu.Text.Replace(".", "")))

        'Thông báo lưu thành công
        MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Khởi tạo lại giá trị cho các Control


        dateNgayThu.Enabled = False
        'txtMaPhieuThuTien.Text = ""
        'dateNgayThu.Text = ""
        'txtMaKhachHang.Text = ""
        'txtDiaChi.Text = ""
        'txtDienThoai.Text = ""
        'txtHoTenKhachHang.Text = ""
        'txtSoTienThu.Text = ""
        'txtTienNo.Text = ""
        grpQuyDinh.Enabled = False
        grpThongTinKhachHang.Enabled = False
        grpChiTietPhieuThu.Enabled = False
        btnLuu.Enabled = False
        btnIn.Enabled = True
    End Sub

    Private Sub txtSoTienThu_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSoTienThu.Validating
        If txtSoTienThu.Text = "" Then

            txtSoTienThu.ErrorText = "Chưa nhập số tiền thu"
            e.Cancel = True
        ElseIf (Long.Parse(txtSoTienThu.Text.Replace(".", "")) <= 0) Then
            txtSoTienThu.ErrorText = "Số tiền thu không được <= 0"
            e.Cancel = True
        Else
            txtSoTienThu.ErrorText = ""
        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim frmPrint As New frmPreview(New PhieuThuTienINFO(txtMaPhieuThuTien.Text, dateNgayThu.DateTime, txtMaKhachHang.Text, Integer.Parse(txtTienNo.Text.Replace(".", "")), Integer.Parse(txtSoTienThu.Text.Replace(".", ""))))

        frmPrint.ShowDialog()


    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class