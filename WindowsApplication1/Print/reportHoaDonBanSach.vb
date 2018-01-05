Imports BUSLayer
Imports DTO

Public Class reportHoaDonBanSach
    Public Sub BindData()
        Dim dt As DataTable
        dt = TryCast(Tag.dt, DataTable)

        Me.DataSource = dt

        detailSTT.DataBindings.Add("Text", dt, dt.Columns("clmSTT").Caption)
        detailMaSach.DataBindings.Add("Text", dt, dt.Columns("clmMaSach").Caption)
        detailTenSach.DataBindings.Add("Text", dt, dt.Columns("clmTenSach").Caption)
        detailTacGia.DataBindings.Add("Text", dt, dt.Columns("clmTacGia").Caption)
        detailTheLoai.DataBindings.Add("Text", dt, dt.Columns("clmTheLoai").Caption)
        detailSoLuong.DataBindings.Add("Text", dt, dt.Columns("clmSoLuong").Caption)
        detailDonGia.DataBindings.Add("Text", dt, dt.Columns("clmDonGia").Caption)
        detailThanhTien.DataBindings.Add("Text", dt, dt.Columns("clmThanhTien").Caption)


        Dim hoadonINFO = TryCast(Tag.HoaDonINFO, HoaDonDTO)

        lblMaHoaDon.Text = hoadonINFO.StrMaHoaDon
        lblMaKhachHang.Text = hoadonINFO.StrMaKhachHang
        lblSoTienNo.Text = Integer.Parse(Tag.iTienNoTruocKhiLapHoaDon).ToString("n0")

        Dim khachhangINFO As KhachHangDTO = KhachHangBUS.LayKhachHangDTO(hoadonINFO.StrMaKhachHang)

        lblDienThoai.Text = khachhangINFO.StrDienThoai
        lblDiaChi.Text = khachhangINFO.StrDiaChi
        lblTenKhachHang.Text = khachhangINFO.StrHoTenKhachHang

        lblTongThanhTien.Text = Integer.Parse(hoadonINFO.ITongThanhTien).ToString("n0")

        lblNgayLap.Text = hoadonINFO.DateNgayLapHoaDon.ToString("dd/MM/yyyy")

        lblNgayThangNam.Text = "Tp. Hồ Chí Minh, ngày " + hoadonINFO.DateNgayLapHoaDon.Day.ToString + " tháng " + hoadonINFO.DateNgayLapHoaDon.Month.ToString + " năm " + hoadonINFO.DateNgayLapHoaDon.Year.ToString




    End Sub
End Class