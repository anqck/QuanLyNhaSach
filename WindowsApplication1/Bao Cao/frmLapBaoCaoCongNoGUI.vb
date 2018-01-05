Imports BUSLayer
Imports DTO

Public Class frmLapBaoCaoCongNoGUI
    Dim dt As New DataTable

    Private Sub frmLapBaoCaoCongNoGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("clmSTT", GetType(String))
        dt.Columns.Add("clmMaKhachHang", GetType(String))
        dt.Columns.Add("clmTenKhachHang", GetType(String))
        dt.Columns.Add("clmDiaChi", GetType(String))
        dt.Columns.Add("clmNoDau", GetType(Integer))
        dt.Columns.Add("clmNoPhatSinh", GetType(Integer))
        dt.Columns.Add("clmNoCuoi", GetType(Integer))
        Grid.DataSource = dt

        btnXuatBaoCao.Enabled = False
    End Sub

    Private Sub btnLapBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btnLapBaoCaoTon.Click
        btnXuatBaoCao.Enabled = False
        dt.Clear()

        'Kiểm tra xem đã chọn tháng chưa
        If (dateThangBaoCao.Text = "") Then
            MessageBox.Show("Chưa chọn tháng lập báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Nếu chưa có tháng báo cáo đầu tiên
        If (LapBaoCaoCongNoBUS.countSoThangBaoCao() = 0) Then
            Dim result = MessageBox.Show("Tháng báo cáo đầu tiên chưa được lập." + vbCrLf + "Bạn có muốn lập báo cáo cho tháng " + LapBaoCaoCongNoBUS.getThangDauTienTrongHoaDon().Month.ToString + " năm " + LapBaoCaoCongNoBUS.getThangDauTienTrongHoaDon().Year.ToString + " (tháng đầu tiên lập hóa đơn) không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If (result = DialogResult.OK) Then
                dateThangBaoCao.DateTime = New DateTime(LapBaoCaoCongNoBUS.getThangDauTienTrongHoaDon().Year, LapBaoCaoCongNoBUS.getThangDauTienTrongHoaDon().Month, 1)

                SplashScreenManager1.ShowWaitForm()

                Dim phatsinhban1 As Dictionary(Of String, Integer) = LapBaoCaoCongNoBUS.getPhatSinhBanTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
                Dim phatsinhthu1 As Dictionary(Of String, Integer) = LapBaoCaoCongNoBUS.getPhatSinhThuTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)

                For Each khachhangINFO In KhachHangBUS.LayTatCaKhachHang()

                    dt.Rows.Add(dt.Rows.Count, khachhangINFO.StrMaKhachHang, khachhangINFO.StrHoTenKhachHang, khachhangINFO.StrDiaChi, 0, If(phatsinhthu1.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhthu1(khachhangINFO.StrMaKhachHang), 0) - If(phatsinhban1.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhban1(khachhangINFO.StrMaKhachHang), 0), If(phatsinhthu1.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhthu1(khachhangINFO.StrMaKhachHang), 0) - If(phatsinhban1.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhban1(khachhangINFO.StrMaKhachHang), 0))

                Next

                'Lưu báo cáo công nợ
                Dim tempBaoCaoDTO As New BaoCaoCongNoDTO
                tempBaoCaoDTO.StrMaBaoCaoCongNo = LapBaoCaoTonBUS.PhatSinhMaBaoCaoCongNo()
                tempBaoCaoDTO.DateThangBaoCao = dateThangBaoCao.DateTime

                LapBaoCaoCongNoBUS.LuuBaoCaoCongNo(tempBaoCaoDTO)

                'Lưu chi tiết báo cáo tồn
                For Each row In dt.Rows
                    Dim ChiTietBaoCaoDTO = New ChiTietBaoCaoCongNoDTO
                    ChiTietBaoCaoDTO.StrMaChiTietBaoCaoCongNo = LapBaoCaoCongNoBUS.PhatSinhMaChiTietBaoCaoCongNo()
                    ChiTietBaoCaoDTO.StrMaBaoCaoCongNo = tempBaoCaoDTO.StrMaBaoCaoCongNo
                    ChiTietBaoCaoDTO.StrMaKhachHang = row("clmMaKhachHang")
                    ChiTietBaoCaoDTO.INoDau = row("clmNoDau")
                    ChiTietBaoCaoDTO.INoPhatSinh = row("clmNoPhatSinh")
                    ChiTietBaoCaoDTO.INoCuoi = row("clmNoCuoi")


                    LapBaoCaoCongNoBUS.LuuChiTietBaoCaoCongNo(ChiTietBaoCaoDTO)
                Next

                SplashScreenManager1.CloseWaitForm()
                MessageBox.Show("Lập báo cáo tháng " + (dateThangBaoCao.DateTime.Month).ToString + " năm " + dateThangBaoCao.DateTime.Year.ToString + " thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                btnLapBaoCaoTon.Enabled = False
                btnXuatBaoCao.Enabled = True
            End If
            Return
        End If

        'Nếu tháng báo cáo nhỏ hơn tháng đầu tiên lập báo cáo
        If (LapBaoCaoCongNoBUS.getThangBaoCaoDauTien() > dateThangBaoCao.DateTime) Then
            MessageBox.Show("Tháng báo cáo không được nhỏ hơn tháng đầu tiên lập báo cáo    (Tháng " + LapBaoCaoCongNoBUS.getThangBaoCaoDauTien.Month.ToString + " năm " + LapBaoCaoTonBUS.getThangBaoCaoDauTien.Year.ToString + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'Nếu tháng trước của tháng báo cáo chưa có dữ liệu
        If (dateThangBaoCao.DateTime.Month - 1 <> 0) Then
            If (LapBaoCaoCongNoBUS.KiemTraThangBaoCaoDaCoChua(dateThangBaoCao.DateTime.Month - 1, dateThangBaoCao.DateTime.Year) = False) Then
                MessageBox.Show("Báo cáo của tháng trước (Tháng " + (dateThangBaoCao.DateTime.Month - 1).ToString + " năm " + dateThangBaoCao.DateTime.Year.ToString + ") chưa được lập." + vbCrLf + " Vui lòng lập báo cáo tháng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dateThangBaoCao.DateTime = New DateTime(dateThangBaoCao.DateTime.Year, dateThangBaoCao.DateTime.Month - 1, 1)
                Return
            End If
        Else
            If (LapBaoCaoCongNoBUS.KiemTraThangBaoCaoDaCoChua(12, dateThangBaoCao.DateTime.Year - 1) = False) Then
                MessageBox.Show("Báo cáo của tháng trước (Tháng " + (12).ToString + " năm " + (dateThangBaoCao.DateTime.Year - 1).ToString + ") chưa được lập." + vbCrLf + " Vui lòng lập báo cáo tháng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dateThangBaoCao.DateTime = New DateTime(dateThangBaoCao.DateTime.Year - 1, 12, 1)
                Return
            End If
        End If




        'Kiểm tra xem hiện tại  đã hết tháng lập báo cáo chưa
        If (DateTime.Today.Month <= dateThangBaoCao.DateTime.Month And DateTime.Today.Year = dateThangBaoCao.DateTime.Year) Then
            Dim result = MessageBox.Show("Hiện tại vẫn chưa hết tháng bạn muốn lập báo cáo. Bạn có chắc chắn muốn lập báo cáo tháng này không ?" + vbCrLf + " Bấm OK để lập báo cáo" + vbCrLf + " Bấm Cancel để hủy bỏ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If (result = DialogResult.Cancel) Then
                Return
            End If
        End If

        'Lập báo cáo tháng
        SplashScreenManager1.ShowWaitForm()

        Dim nodau As Dictionary(Of String, Integer)
        If (dateThangBaoCao.DateTime.Month - 1 <> 0) Then
            nodau = LapBaoCaoCongNoBUS.getNoCuoiCuaThang(dateThangBaoCao.DateTime.Month - 1, dateThangBaoCao.DateTime.Year)
        Else
            nodau = LapBaoCaoCongNoBUS.getNoCuoiCuaThang(12, dateThangBaoCao.DateTime.Year - 1)
        End If

        Dim phatsinhban As Dictionary(Of String, Integer) = LapBaoCaoCongNoBUS.getPhatSinhBanTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
        Dim phatsinhthu As Dictionary(Of String, Integer) = LapBaoCaoCongNoBUS.getPhatSinhThuTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)

        For Each khachhangINFO In KhachHangBUS.LayTatCaKhachHang()
            dt.Rows.Add(dt.Rows.Count, khachhangINFO.StrMaKhachHang, khachhangINFO.StrHoTenKhachHang, khachhangINFO.StrDiaChi, If(nodau.ContainsKey(khachhangINFO.StrMaKhachHang), nodau(khachhangINFO.StrMaKhachHang), 0), If(phatsinhthu.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhthu(khachhangINFO.StrMaKhachHang), 0) - If(phatsinhban.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhban(khachhangINFO.StrMaKhachHang), 0), If(nodau.ContainsKey(khachhangINFO.StrMaKhachHang), nodau(khachhangINFO.StrMaKhachHang), 0) + If(phatsinhthu.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhthu(khachhangINFO.StrMaKhachHang), 0) - If(phatsinhban.ContainsKey(khachhangINFO.StrMaKhachHang), phatsinhban(khachhangINFO.StrMaKhachHang), 0))
        Next

        'Lưu báo cáo công nợ
        Dim tempBaoCaoDTO1 As New BaoCaoCongNoDTO
        tempBaoCaoDTO1.StrMaBaoCaoCongNo = LapBaoCaoTonBUS.PhatSinhMaBaoCaoCongNo()
        tempBaoCaoDTO1.DateThangBaoCao = dateThangBaoCao.DateTime

        LapBaoCaoCongNoBUS.LuuBaoCaoCongNo(tempBaoCaoDTO1)

        'Lưu chi tiết báo cáo tồn
        For Each row In dt.Rows
            Dim ChiTietBaoCaoDTO1 = New ChiTietBaoCaoCongNoDTO
            ChiTietBaoCaoDTO1.StrMaChiTietBaoCaoCongNo = LapBaoCaoCongNoBUS.PhatSinhMaChiTietBaoCaoCongNo()
            ChiTietBaoCaoDTO1.StrMaBaoCaoCongNo = tempBaoCaoDTO1.StrMaBaoCaoCongNo
            ChiTietBaoCaoDTO1.StrMaKhachHang = row("clmMaKhachHang")
            ChiTietBaoCaoDTO1.INoDau = row("clmNoDau")
            ChiTietBaoCaoDTO1.INoPhatSinh = row("clmNoPhatSinh")
            ChiTietBaoCaoDTO1.INoCuoi = row("clmNoCuoi")


            LapBaoCaoCongNoBUS.LuuChiTietBaoCaoCongNo(ChiTietBaoCaoDTO1)
        Next

        SplashScreenManager1.CloseWaitForm()

        MessageBox.Show("Lập báo cáo tháng " + (dateThangBaoCao.DateTime.Month).ToString + " năm " + dateThangBaoCao.DateTime.Year.ToString + " thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnXuatBaoCao.Enabled = True
        btnLapBaoCaoTon.Enabled = False
    End Sub

    Private Sub dateThangBaoCao_DateTimeChanged(sender As Object, e As EventArgs) Handles dateThangBaoCao.DateTimeChanged
        dt.Clear()


        'Kiểm tra xem tháng này đã được lập báo cáo chưa
        If (LapBaoCaoCongNoBUS.KiemTraThangBaoCaoDaCoChua(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year) = True) Then
            btnLapBaoCaoTon.Enabled = False

            'Nêu người dùng chọn có thì load dữ liệu của tháng đã lập từ Database

            SplashScreenManager1.ShowWaitForm()


            Dim dt1 As DataTable = LapBaoCaoCongNoBUS.getBaoCaoThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
            Dim dicSachINFO As Dictionary(Of String, KhachHangDTO) = KhachHangBUS.LayTatCaKhachHangVaoDictionary()


            For Each row In dt1.Rows
                Dim khachhangINFO As KhachHangDTO = dicSachINFO(row("MaKhachHang"))
                'Dim sachINFO As SachDTO = SachBUS.LaySachDTO(row("MaSach"))
                dt.Rows.Add(dt.Rows.Count, khachhangINFO.StrMaKhachHang, khachhangINFO.StrHoTenKhachHang, khachhangINFO.StrDiaChi, row("NoDau"), row("NoPhatSinh"), row("NoCuoi"))
            Next

            SplashScreenManager1.CloseWaitForm()

            btnXuatBaoCao.Enabled = True

        Else
            btnLapBaoCaoTon.Enabled = True
        End If
    End Sub

    Private Sub btnXuatBaoCao_Click(sender As Object, e As EventArgs) Handles btnXuatBaoCao.Click
        Dim frmPrint As New frmPreview(New BaoCaoCongNoINFO(dt, dateThangBaoCao.DateTime))
        frmPrint.ShowDialog()
    End Sub
End Class