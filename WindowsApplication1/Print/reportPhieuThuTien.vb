Imports BUSLayer
Imports DTO

Public Class reportPhieuThuTien
    Public Sub BindData()
        Dim INFO As PhieuThuTienINFO
        INFO = TryCast(Tag, PhieuThuTienINFO)

        lblMaPhieuThu.Text = INFO.strMaPhieuThu
        lblNgayThu.Text = INFO.dateNgayThu.ToString("dd/MM/yyyy")


        lblMaKhachHang.Text = INFO.strMaKhachHang

        Dim khachhangINFO As New KhachHangDTO
        khachhangINFO = KhachHangBUS.LayKhachHangDTO(INFO.strMaKhachHang)

        lblDiaChi.Text = khachhangINFO.StrDiaChi
        lblTenKhachHang.Text = khachhangINFO.StrHoTenKhachHang
        lblDienThoai.Text = khachhangINFO.StrDienThoai


        lblSoTienNo.Text = INFO.iSoTienNo.ToString("n0") + " Đồng"

        lblSoTienThu.Text = INFO.iSoTienThu.ToString("n0") + " Đồng"

        lblTienNoConLai.Text = (INFO.iSoTienNo - INFO.iSoTienThu).ToString("n0") + " Đồng"

        lblNgayThangNam.Text = "Tp. Hồ Chí Minh, ngày " + DateTime.Today.Day.ToString + " tháng " + DateTime.Today.Month.ToString + " năm " + DateTime.Today.Year.ToString

    End Sub
End Class