Imports DTO

Public Class SachDAL

    'PHÁT SINH KHÓA CHÍNH MỚI
    Public Shared Function PhatSinhMaSach() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM SACH")

        Return dt.Rows(0).Item(0)

    End Function

    Public Shared Function getTatCaTheLoaiSach() As List(Of String)
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT TheLoai FROM SACH GROUP BY TheLoai ")

        Dim res As New List(Of String)

        For i As Integer = 0 To dt.Rows.Count - 1

            res.Add(dt.Rows(i)("TheLoai"))
        Next

        Return res
    End Function

    Public Shared Function getSach() As List(Of SachDTO)
        Dim dt As New DataTable
        Dim res As New List(Of SachDTO)

        Dim strCommand = "SELECT SACH.MaSach, SACH.TenSach, SACH.TacGia,SACH.TheLoai,SACH.SoLuongTon, SACH.DonGiaDuKien, IIf(Sum(CHITIETHOADON.SoLuongBan) Is Null, 0, Sum(CHITIETHOADON.SoLuongBan)) AS TongSoLuongBan,  IIf(Sum(CHITIETHOADON.SoLuongBan*CHITIETHOADON.DonGiaBan ) Is Null, 0, Sum(CHITIETHOADON.SoLuongBan*CHITIETHOADON.DonGiaBan)) AS TongTienBan
FROM SACH LEFT JOIN CHITIETHOADON ON SACH.MaSach = CHITIETHOADON.MaSach
GROUP BY SACH.MaSach, SACH.TenSach, SACH.TacGia,SACH.TheLoai,SACH.SoLuongTon, SACH.DonGiaDuKien
"

        dt = DataProvider.ExecuteQuery(strCommand)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim sachINFO As New SachDTO()

            sachINFO.StrMaSach = dt.Rows(i)("MaSach")
            sachINFO.StrTenSach = dt.Rows(i)("TenSach")
            sachINFO.StrTacGia = dt.Rows(i)("TacGia")
            sachINFO.StrTheLoai = dt.Rows(i)("TheLoai")
            sachINFO.ISoLuongTon = dt.Rows(i)("SoLuongTon")
            sachINFO.ITongSoLuongBan = dt.Rows(i)("TongSoLuongBan")
            sachINFO.ITongTienBan = dt.Rows(i)("TongTienBan")
            sachINFO.IDonGiaDuKien = dt.Rows(i)("DonGiaDuKien")

            res.Add(sachINFO)
        Next
        Return res
    End Function


    Public Shared Function getTatCaTacGiaSach() As List(Of String)
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT TacGia FROM SACH GROUP BY TacGia")

        Dim res As New List(Of String)

        For i As Integer = 0 To dt.Rows.Count - 1

            res.Add(dt.Rows(i)("TacGia"))
        Next

        Return res
    End Function

    Public Shared Function getDonGiaDuKien(strMaSach As String) As Integer
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT DONGIADUKIEN FROM SACH WHERE MaSach = '$0'"
        strCommand = strCommand.Replace("$0", strMaSach)

        dt = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)


    End Function

    Public Shared Sub CapNhatSach(sachDTO As SachDTO)
        Dim strCommand As String = "UPDATE SACH SET TenSach = '$0', TacGia = '$1', TheLoai = '$2', DonGiaDuKien = $4 WHERE MaSach = '$3'"
        strCommand = strCommand.Replace("$0", sachDTO.StrTenSach)
        strCommand = strCommand.Replace("$1", sachDTO.StrTacGia)
        strCommand = strCommand.Replace("$2", sachDTO.StrTheLoai)
        strCommand = strCommand.Replace("$3", sachDTO.StrMaSach)
        strCommand = strCommand.Replace("$4", sachDTO.IDonGiaDuKien)

        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function LayTatCaSachVaoDic() As Dictionary(Of String, SachDTO)

        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("Select * FROM SACH")

        Dim res As New Dictionary(Of String, SachDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim sachINFO As New SachDTO()

            sachINFO.StrMaSach = dt.Rows(i)("MaSach")
            sachINFO.StrTenSach = dt.Rows(i)("TenSach")
            sachINFO.StrTacGia = dt.Rows(i)("TacGia")
            sachINFO.StrTheLoai = dt.Rows(i)("TheLoai")
            sachINFO.ISoLuongTon = dt.Rows(i)("SoLuongTon")

            res.Add(sachINFO.StrMaSach, sachINFO)
        Next

        Return res
    End Function

    'THÊM SÁCH
    Public Shared Sub ThemSachVaoDB(sachDTO As SachDTO)
        Dim strCommand As String

        strCommand = "INSERT INTO SACH VALUES ( '$1', '$2', '$3', '$4', $5, $6)"
        strCommand = strCommand.Replace("$1", sachDTO.StrMaSach.ToString())
        strCommand = strCommand.Replace("$2", sachDTO.StrTenSach)
        strCommand = strCommand.Replace("$3", sachDTO.StrTacGia)
        strCommand = strCommand.Replace("$4", sachDTO.StrTheLoai)
        strCommand = strCommand.Replace("$5", sachDTO.ISoLuongTon)
        strCommand = strCommand.Replace("$6", sachDTO.IDonGiaDuKien)
        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function getSoLuongTon(strMaSach As String) As Integer
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT SoLuongTon FROM SACH WHERE MaSach = '$0'"
        strCommand = strCommand.Replace("$0", strMaSach)
        dt = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function isContainTenSach(v As String) As Boolean
        Dim dt As New DataTable
        '"some text ""hello"" "
        dt = DataProvider.ExecuteQuery(String.Concat("SELECT * FROM SACH WHERE TenSach = """ + v + """"))

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function getTatCaChiTietBanSach() As List(Of ChiTietHoaDonDTO)
        Dim dt As New DataTable
        Dim res As New List(Of ChiTietHoaDonDTO)

        Dim strCommand = "(Select MaSach, NgayLapHoaDon, DonGiaBan, C.MaHoaDon, SoLuongBan, ThanhTien FROM CHITIETHOADON A, HOADON C WHERE A.MaHoaDon = C.MaHoaDon)"

        dt = DataProvider.ExecuteQuery(strCommand)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim sachINFO As New ChiTietHoaDonDTO()

            sachINFO.StrMaSach = dt.Rows(i)("MaSach")
            sachINFO.StrMaHoaDon = dt.Rows(i)("MaHoaDon")
            sachINFO.IDonGiaBan = dt.Rows(i)("DonGiaBan")
            sachINFO.DateNgayLapHoaDon = dt.Rows(i)("NgayLapHoaDon")
            sachINFO.ISoLuongBan = dt.Rows(i)("SoLuongBan")
            sachINFO.IThanhTien = dt.Rows(i)("ThanhTien")

            res.Add(sachINFO)
        Next
        Return res
    End Function

    Public Shared Function getSachVoiDieuKien(v As String) As List(Of SachDTO)
        Dim dt As New DataTable
        Dim res As New List(Of SachDTO)

        Dim strCommand = "SELECT SACH.MaSach, SACH.TenSach, SACH.TacGia,SACH.TheLoai,SACH.SoLuongTon, IIf(Sum(CHITIETHOADON.SoLuongBan) Is Null, 0, Sum(CHITIETHOADON.SoLuongBan)) AS TongSoLuongBan,  IIf(Sum(CHITIETHOADON.SoLuongBan*CHITIETHOADON.DonGiaBan ) Is Null, 0, Sum(CHITIETHOADON.SoLuongBan*CHITIETHOADON.DonGiaBan)) AS TongTienBan
FROM SACH LEFT JOIN CHITIETHOADON ON SACH.MaSach = CHITIETHOADON.MaSach
GROUP BY SACH.MaSach, SACH.TenSach, SACH.TacGia,SACH.TheLoai,SACH.SoLuongTon
HAVING SACH.MaSach in (Select A.MaSach
FROM CHITIETHOADON A, HOADON C
WHERE $0)
"
        strCommand = strCommand.Replace("$0", v)

        dt = DataProvider.ExecuteQuery(strCommand)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim sachINFO As New SachDTO()

            sachINFO.StrMaSach = dt.Rows(i)("MaSach")
            sachINFO.StrTenSach = dt.Rows(i)("TenSach")
            sachINFO.StrTacGia = dt.Rows(i)("TacGia")
            sachINFO.StrTheLoai = dt.Rows(i)("TheLoai")
            sachINFO.ISoLuongTon = dt.Rows(i)("SoLuongTon")
            sachINFO.ITongSoLuongBan = dt.Rows(i)("TongSoLuongBan")
            sachINFO.ITongTienBan = dt.Rows(i)("TongTienBan")

            res.Add(sachINFO)
        Next
        Return res
    End Function

    Public Shared Function getMaSachVoiDonGiaBan(text1 As String, text2 As String) As DataTable
        Dim strCommand = "Select SACH.MaSach From SACH LEFT Join CHITIETHOADON On SACH.MaSach = CHITIETHOADON.MaSach Where DonGiaBan >= " + text1 + " $0 Group By SACH.MaSach"
        If (text2 = "Tối đa") Then
            strCommand = strCommand.Replace("$0", "")
        Else
            strCommand = strCommand.Replace("$0", "And DonGiaBan <= " + text2)
        End If
        Return DataProvider.ExecuteQuery(strCommand)
    End Function

    Public Shared Function getMaSachVoiNgayBan(text1 As Date, text2 As Date) As Object
        Dim strCommand = "Select A.MaSach,  C.NgayLapHoaDon FROM CHITIETHOADON A, HOADON C WHERE C.NgayLapHoaDon >= #" + text1.ToShortDateString + "# AND C.NgayLapHoaDon <= #" + text2.ToShortDateString + "#"

        Return DataProvider.ExecuteQuery(strCommand)
    End Function

    Public Shared Function getTatCaChiTietNhapSach() As List(Of ChiTietPhieuNhapDTO)
        Dim dt As New DataTable
        Dim res As New List(Of ChiTietPhieuNhapDTO)

        Dim strCommand = "SELECT PHIEUNHAP.MaPhieuNhap, PHIEUNHAP.NgayNhap, CHITIETPHIEUNHAP.MaSach, CHITIETPHIEUNHAP.SoLuongNhap
FROM PHIEUNHAP , CHITIETPHIEUNHAP 
WHERE PHIEUNHAP.MaPhieuNhap = CHITIETPHIEUNHAP.MaPhieuNhap"

        dt = DataProvider.ExecuteQuery(strCommand)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim sachINFO As New ChiTietPhieuNhapDTO()

            sachINFO.IMaSach = dt.Rows(i)("MaSach")
            sachINFO.IMaPhieuNhap = dt.Rows(i)("MaPhieuNhap")
            sachINFO.DateNgayNhap = dt.Rows(i)("NgayNhap")
            sachINFO.ISoLuongNhap = dt.Rows(i)("SoLuongNhap")

            res.Add(sachINFO)
        Next
        Return res
    End Function

    Public Shared Function isContainMaSach(v As String) As Boolean
        Dim dt As New DataTable

        dt = DataProvider.ExecuteQuery(String.Concat("SELECT * FROM SACH WHERE MaSach = '" + v + "'"))

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub CapNhatSoLuongTon(sachDTO As SachDTO)
        Dim strCom As String = "UPDATE SACH SET SoLuongTon = " + sachDTO.ISoLuongTon.ToString() + " where MaSach = """ + sachDTO.StrMaSach.ToString + """"
        DataProvider.ExecuteNonQuery(strCom)
    End Sub

    'LẤY TẤT CẢ SÁCH VÀO LIST<SACHDTO>
    Public Shared Function LayTatCaSach() As List(Of SachDTO)
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT * FROM SACH")

        Dim res As New List(Of SachDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim sachINFO As New SachDTO()

            sachINFO.StrMaSach = dt.Rows(i)("MaSach")
            sachINFO.StrTenSach = dt.Rows(i)("TenSach")
            sachINFO.StrTacGia = dt.Rows(i)("TacGia")
            sachINFO.StrTheLoai = dt.Rows(i)("TheLoai")
            sachINFO.ISoLuongTon = dt.Rows(i)("SoLuongTon")
            sachINFO.IDonGiaDuKien = dt.Rows(i)("DonGiaDuKien")

            res.Add(sachINFO)
        Next

        Return res
    End Function


    'LẤY SACHDTO 
    Public Shared Function LaySachDTO(strMaSach As String) As SachDTO
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT * FROM SACH WHERE MaSach = '" + strMaSach + "'")

        If (dt.Rows.Count <> 0) Then
            Dim sachINFO As New SachDTO()

            sachINFO.StrMaSach = dt.Rows(0)("MaSach")
            sachINFO.StrTenSach = dt.Rows(0)("TenSach")
            sachINFO.StrTacGia = dt.Rows(0)("TacGia")
            sachINFO.StrTheLoai = dt.Rows(0)("TheLoai")
            sachINFO.ISoLuongTon = dt.Rows(0)("SoLuongTon")
            sachINFO.IDonGiaDuKien = dt.Rows(0)("DonGiaDuKien")

            Return sachINFO
        Else
            Return Nothing

        End If

    End Function
End Class
