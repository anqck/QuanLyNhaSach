Imports BUSLayer
Imports DTO

Public Class frmLapBaoCaoTonGUI
    Dim dt As New DataTable
    Private Sub frmLapBaoCaoTonGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dt.Columns.Add("clmSTT", GetType(String))
        dt.Columns.Add("clmMaSach", GetType(String))
        dt.Columns.Add("clmTenSach", GetType(Object))
        dt.Columns.Add("clmTheLoai", GetType(String))
        dt.Columns.Add("clmTacGia", GetType(String))
        dt.Columns.Add("clmTonDau", GetType(Integer))
        dt.Columns.Add("clmTonPhatSinh", GetType(Integer))
        dt.Columns.Add("clmTonCuoi", GetType(Integer))
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

        'Nếu chưa có tháng báo cáo đầu tineen
        If (LapBaoCaoTonBUS.countSoThangBaoCao() = 0) Then
            Dim result = MessageBox.Show("Tháng báo cáo đầu tiên chưa được lập." + vbCrLf + "Bạn có muốn lập báo cáo cho tháng " + LapBaoCaoTonBUS.getThangDauTienTrongPhieuNhap().Month.ToString + " năm " + LapBaoCaoTonBUS.getThangDauTienTrongPhieuNhap().Year.ToString + " (tháng đầu tiên nhập sách) không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If (result = DialogResult.OK) Then
                dateThangBaoCao.DateTime = New DateTime(LapBaoCaoTonBUS.getThangDauTienTrongPhieuNhap().Year, LapBaoCaoTonBUS.getThangDauTienTrongPhieuNhap().Month, 1)

                SplashScreenManager1.ShowWaitForm()
                Dim phatsinhnhap1 As Dictionary(Of String, Integer) = LapBaoCaoTonBUS.getPhatSinhNhapTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
                Dim phatsinhxuat1 As Dictionary(Of String, Integer) = LapBaoCaoTonBUS.getPhatSinhXuatTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)

                For Each sachINFO In SachBUS.LayTatCaSach()

                    dt.Rows.Add(dt.Rows.Count, sachINFO.StrMaSach, sachINFO.StrTenSach, sachINFO.StrTheLoai, sachINFO.StrTacGia, 0, If(phatsinhnhap1.ContainsKey(sachINFO.StrMaSach), phatsinhnhap1(sachINFO.StrMaSach), 0) - If(phatsinhxuat1.ContainsKey(sachINFO.StrMaSach), phatsinhxuat1(sachINFO.StrMaSach), 0), If(phatsinhnhap1.ContainsKey(sachINFO.StrMaSach), phatsinhnhap1(sachINFO.StrMaSach), 0) - If(phatsinhxuat1.ContainsKey(sachINFO.StrMaSach), phatsinhxuat1(sachINFO.StrMaSach), 0))

                Next

                'Lưu báo cáo tồn
                Dim tempBaoCaoDTO As New BaoCaoTonDTO
                tempBaoCaoDTO.StrMaBaoCaoTon = LapBaoCaoTonBUS.PhatSinhMaBaoCaoTon()
                tempBaoCaoDTO.DateThangBaoCao = dateThangBaoCao.DateTime

                LapBaoCaoTonBUS.LuuBaoCaoTon(tempBaoCaoDTO)

                'Lưu chi tiết báo cáo tồn
                For Each row In dt.Rows
                    Dim ChiTietBaoCaoDTO = New ChiTietBaoCaoTonDTO
                    ChiTietBaoCaoDTO.StrMaBaoCaoTon = tempBaoCaoDTO.StrMaBaoCaoTon
                    ChiTietBaoCaoDTO.StrMaChiTietBaoCaoTon = LapBaoCaoTonBUS.PhatSinhMaChiTietBaoCaoTon()
                    ChiTietBaoCaoDTO.StrMaSach = row("clmMaSach")
                    ChiTietBaoCaoDTO.ITonDau = row("clmTonDau")
                    ChiTietBaoCaoDTO.ITonPhatSinh = row("clmTonPhatSinh")
                    ChiTietBaoCaoDTO.ITonCuoi = row("clmTonCuoi")

                    LapBaoCaoTonBUS.LuuChiTietBaoCaoTon(ChiTietBaoCaoDTO)
                Next

                SplashScreenManager1.CloseWaitForm()
                MessageBox.Show("Lập báo cáo tháng " + (dateThangBaoCao.DateTime.Month).ToString + " năm " + dateThangBaoCao.DateTime.Year.ToString + " thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                btnLapBaoCaoTon.Enabled = False
                btnXuatBaoCao.Enabled = True
            End If

            Return
        End If

        'Nếu tháng báo cáo nhỏ hơn tháng đầu tiên lập báo cáo
        If (LapBaoCaoTonBUS.getThangBaoCaoDauTien() > dateThangBaoCao.DateTime) Then
            MessageBox.Show("Tháng báo cáo không được nhỏ hơn tháng đầu tiên lập báo cáo    (Tháng " + LapBaoCaoTonBUS.getThangBaoCaoDauTien.Month.ToString + " năm " + LapBaoCaoTonBUS.getThangBaoCaoDauTien.Year.ToString + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'Kiểm tra xem tháng này đã được lập báo cáo chưa
        'If (LapBaoCaoTonBUS.KiemTraThangBaoCaoDaCoChua(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year) = True) Then
        '    Dim result = MessageBox.Show("Báo cáo tháng này đã được lập trước đó." + vbCrLf + " Bấm OK để xem báo cáo" + vbCrLf + " Bấm Cancle để hủy bỏ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        '    If (result = DialogResult.OK) Then
        '        'Nêu người dùng chọn có thì load dữ liệu của tháng đã lập từ Database

        '        SplashScreenManager1.ShowWaitForm()

        '        Dim dt1 As DataTable = LapBaoCaoTonBUS.getBaoCaoThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
        '        Dim dicSachINFO As Dictionary(Of String, SachDTO) = SachBUS.LayTatCaSachVaoDictionary()

        '        For Each row In dt1.Rows
        '            Dim sachINFO As SachDTO = dicSachINFO(row("MaSach"))
        '            'Dim sachINFO As SachDTO = SachBUS.LaySachDTO(row("MaSach"))
        '            dt.Rows.Add(dt.Rows.Count, sachINFO.IMaSach, sachINFO.StrTenSach, sachINFO.StrTheLoai, sachINFO.StrTacGia, row("TonDau"), row("TonPhatSinh"), row("TonCuoi"))
        '        Next

        '        SplashScreenManager1.CloseWaitForm()

        '        btnXuatBaoCao.Enabled = True
        '    End If

        '    Return
        'End If

        'Nếu tháng trước của tháng báo cáo chưa có dữ liệu
        If (dateThangBaoCao.DateTime.Month - 1 <> 0) Then
            If (LapBaoCaoTonBUS.KiemTraThangBaoCaoDaCoChua(dateThangBaoCao.DateTime.Month - 1, dateThangBaoCao.DateTime.Year) = False) Then
                MessageBox.Show("Báo cáo của tháng trước (Tháng " + (dateThangBaoCao.DateTime.Month - 1).ToString + " năm " + dateThangBaoCao.DateTime.Year.ToString + ") chưa được lập." + vbCrLf + " Vui lòng lập báo cáo tháng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dateThangBaoCao.DateTime = New DateTime(dateThangBaoCao.DateTime.Year, dateThangBaoCao.DateTime.Month - 1, 1)
                Return
            End If
        Else
            If (LapBaoCaoTonBUS.KiemTraThangBaoCaoDaCoChua(12, dateThangBaoCao.DateTime.Year - 1) = False) Then
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

        Dim tondau As Dictionary(Of String, Integer)
        If (dateThangBaoCao.DateTime.Month - 1 <> 0) Then
            tondau = LapBaoCaoTonBUS.getTonCuoiCuaThang(dateThangBaoCao.DateTime.Month - 1, dateThangBaoCao.DateTime.Year)
        Else
            tondau = LapBaoCaoTonBUS.getTonCuoiCuaThang(12, dateThangBaoCao.DateTime.Year - 1)
        End If
        Dim phatsinhnhap As Dictionary(Of String, Integer) = LapBaoCaoTonBUS.getPhatSinhNhapTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
        Dim phatsinhxuat As Dictionary(Of String, Integer) = LapBaoCaoTonBUS.getPhatSinhXuatTrongThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)

        For Each sachINFO In SachBUS.LayTatCaSach()

            dt.Rows.Add(dt.Rows.Count, sachINFO.StrMaSach, sachINFO.StrTenSach, sachINFO.StrTheLoai, sachINFO.StrTacGia, If(tondau.ContainsKey(sachINFO.StrMaSach), tondau(sachINFO.StrMaSach), 0), If(phatsinhnhap.ContainsKey(sachINFO.StrMaSach), phatsinhnhap(sachINFO.StrMaSach), 0) - If(phatsinhxuat.ContainsKey(sachINFO.StrMaSach), phatsinhxuat(sachINFO.StrMaSach), 0), If(tondau.ContainsKey(sachINFO.StrMaSach), tondau(sachINFO.StrMaSach), 0) + (If(phatsinhnhap.ContainsKey(sachINFO.StrMaSach), phatsinhnhap(sachINFO.StrMaSach), 0) - If(phatsinhxuat.ContainsKey(sachINFO.StrMaSach), phatsinhxuat(sachINFO.StrMaSach), 0)))

        Next

        'Lưu báo cáo tồn
        Dim BaoCaoDTO As New BaoCaoTonDTO
        BaoCaoDTO.StrMaBaoCaoTon = LapBaoCaoTonBUS.PhatSinhMaBaoCaoTon()
        BaoCaoDTO.DateThangBaoCao = dateThangBaoCao.DateTime

        LapBaoCaoTonBUS.LuuBaoCaoTon(BaoCaoDTO)

        'Lưu chi tiết báo cáo tồn
        For Each row In dt.Rows
            Dim ChiTietBaoCaoDTO = New ChiTietBaoCaoTonDTO
            ChiTietBaoCaoDTO.StrMaBaoCaoTon = BaoCaoDTO.StrMaBaoCaoTon
            ChiTietBaoCaoDTO.StrMaChiTietBaoCaoTon = LapBaoCaoTonBUS.PhatSinhMaChiTietBaoCaoTon()
            ChiTietBaoCaoDTO.StrMaSach = row("clmMaSach")
            ChiTietBaoCaoDTO.ITonDau = row("clmTonDau")
            ChiTietBaoCaoDTO.ITonPhatSinh = row("clmTonPhatSinh")
            ChiTietBaoCaoDTO.ITonCuoi = row("clmTonCuoi")

            LapBaoCaoTonBUS.LuuChiTietBaoCaoTon(ChiTietBaoCaoDTO)
        Next

        SplashScreenManager1.CloseWaitForm()

        MessageBox.Show("Lập báo cáo tháng " + (dateThangBaoCao.DateTime.Month).ToString + " năm " + dateThangBaoCao.DateTime.Year.ToString + " thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnXuatBaoCao.Enabled = True
        btnLapBaoCaoTon.Enabled = False
    End Sub

    Private Sub btnXuatBaoCao_Click(sender As Object, e As EventArgs) Handles btnXuatBaoCao.Click
        Dim frmPrint As New frmPreview(New BaoCaoTonINFO(dt, dateThangBaoCao.DateTime))
        frmPrint.ShowDialog()
    End Sub

    Private Sub dateThangBaoCao_DateTimeChanged(sender As Object, e As EventArgs) Handles dateThangBaoCao.DateTimeChanged
        dt.Clear()


        'Kiểm tra xem tháng này đã được lập báo cáo chưa
        If (LapBaoCaoTonBUS.KiemTraThangBaoCaoDaCoChua(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year) = True) Then
            btnLapBaoCaoTon.Enabled = False

            'Nêu người dùng chọn có thì load dữ liệu của tháng đã lập từ Database

            SplashScreenManager1.ShowWaitForm()

            Dim dt1 As DataTable = LapBaoCaoTonBUS.getBaoCaoThang(dateThangBaoCao.DateTime.Month, dateThangBaoCao.DateTime.Year)
            Dim dicSachINFO As Dictionary(Of String, SachDTO) = SachBUS.LayTatCaSachVaoDictionary()

            For Each row In dt1.Rows
                Dim sachINFO As SachDTO = dicSachINFO(row("MaSach"))
                'Dim sachINFO As SachDTO = SachBUS.LaySachDTO(row("MaSach"))
                dt.Rows.Add(dt.Rows.Count, sachINFO.StrMaSach, sachINFO.StrTenSach, sachINFO.StrTheLoai, sachINFO.StrTacGia, row("TonDau"), row("TonPhatSinh"), row("TonCuoi"))
            Next

            SplashScreenManager1.CloseWaitForm()

            btnXuatBaoCao.Enabled = True

        Else
            btnLapBaoCaoTon.Enabled = True
        End If
    End Sub
End Class