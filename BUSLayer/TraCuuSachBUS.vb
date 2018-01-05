Imports DALLayer
Imports DTO

Public Class TraCuuSachBUS
    Public Shared Function getTatCaTheLoaiSach() As List(Of String)
        Return SachBUS.getTatCaTheLoaiSach()
    End Function

    Public Shared Function getSach() As List(Of SachDTO)
        Return SachBUS.getSach()
    End Function

    Public Shared Function ChuanHoaTheLoai(text As String) As String

        Dim strTimKiemTheoTheLoai As String = " (TheLoai = '"
        strTimKiemTheoTheLoai += text
        strTimKiemTheoTheLoai = strTimKiemTheoTheLoai.Replace(", ", "' Or TheLoai = '")
        strTimKiemTheoTheLoai = " " + strTimKiemTheoTheLoai
        strTimKiemTheoTheLoai += "')"
        Return strTimKiemTheoTheLoai
    End Function

    Public Shared Function getTatCaTacGiaSach() As List(Of String)
        Return SachBUS.getTatCaTacGiaSach()
    End Function

    Public Shared Function GhepCacCauDieuKien(listStrCommand As List(Of String)) As String
        Dim strRes As String = ""

        For i As Integer = 0 To listStrCommand.Count - 1
            If (i = 0) Then
                strRes = listStrCommand(0)
            Else
                strRes += " AND " + listStrCommand(i)
            End If

        Next


        Return strRes
    End Function

    Public Shared Function ChuanHoaTacGia(text As String) As String
        text = text.Replace("'", "''")
        Dim strTimKiemTheoTheLoai As String = " (TacGia = '"
        strTimKiemTheoTheLoai += text
        strTimKiemTheoTheLoai = strTimKiemTheoTheLoai.Replace(", ", "' Or TacGia = '")
        strTimKiemTheoTheLoai = " " + strTimKiemTheoTheLoai
        strTimKiemTheoTheLoai += "')"
        Return strTimKiemTheoTheLoai
    End Function

    Public Shared Function getDieuKienDonGia(strDonGiafr As String, strDonGiato As String) As String
        Return " MaSach IN (Select A.MaSach FROM CHITIETHOADON A, HOADON C WHERE  A.MaHoaDon = C.MaHoaDon AND C.NgayLapHoaDon BETWEEN " + strDonGiafr + " AND " + strDonGiafr + ")"
    End Function

    Public Shared Function ChuanHoaDieuKienTheoMaSach(strMaSach As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmMaSach] = '" + strMaSach + "'"
        Else
            Return " [clmMaSach] LIKE '%" + strMaSach + "%'"
        End If

    End Function

    Public Shared Function ChuanHoaDieuKienTheoTenSach(strTenSach As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmTenSach] = '" + strTenSach + "'"
        Else
            Return " [clmTenSach] LIKE '%" + strTenSach + "%'"
        End If
    End Function

    Public Shared Function ChuanHoaDieuKienTheoTheLoai(text As String) As String
        Dim strTimKiemTheoTheLoai As String = " [clmTheLoai] = '"
        strTimKiemTheoTheLoai += text
        strTimKiemTheoTheLoai = strTimKiemTheoTheLoai.Replace(", ", "' OR [clmTheLoai] = '")
        strTimKiemTheoTheLoai = " " + strTimKiemTheoTheLoai
        strTimKiemTheoTheLoai += "'"
        Return strTimKiemTheoTheLoai
    End Function

    Public Shared Function ChuanHoaDieuKienTheoTacGia(text As String) As String
        Dim strTimKiemTheoTacGia As String = " [clmTacGia] = '"
        strTimKiemTheoTacGia += text
        strTimKiemTheoTacGia = strTimKiemTheoTacGia.Replace(", ", "' OR [clmTacGia] = '")
        strTimKiemTheoTacGia = " " + strTimKiemTheoTacGia
        strTimKiemTheoTacGia += "'"
        Return strTimKiemTheoTacGia
    End Function

    Public Shared Function getTatCaChiTietBanSach() As List(Of ChiTietHoaDonDTO)
        Return SachDAL.getTatCaChiTietBanSach()
    End Function

    Public Shared Function getSachVoiDieuKien(v As String) As List(Of SachDTO)
        Return SachDAL.getSachVoiDieuKien(v)
    End Function

    Public Shared Function ChuanHoaDieuKienTheoSoLuongTon(strSoLuongTonfr As String, strSoLuongTonto As String) As String
        Dim strCommand As String = " [clmSoLuongTon] >= " + (strSoLuongTonfr)
        If (strSoLuongTonto <> "Tối đa") Then
            strCommand += "AND [clmSoLuongTon] <= " + (strSoLuongTonto)
        End If
        Return strCommand

    End Function

    Public Shared Function ChuanHoaDieuKienTheoSoLuongBan(strSoLuongBanfr As String, strSoLuongBanto As String) As String
        Dim strCommand As String = " [clmTongSoLuongBan] >= " + (strSoLuongBanfr)
        If (strSoLuongBanto <> "Tối đa") Then
            strCommand += "AND [clmTongSoLuongBan] <= " + (strSoLuongBanto)
        End If
        Return strCommand
    End Function

    Public Shared Function ChuanHoaDieuKienTheoTongTienBan(strTongTienBanfr As String, strTongTienBanto As String) As String
        Dim strCommand As String = " [clmTongTienBan] >= " + (strTongTienBanfr)
        If (strTongTienBanto <> "Tối đa") Then
            strCommand += "AND [clmTongTienBan] <= " + (strTongTienBanto)
        End If
        Return strCommand
    End Function

    Public Shared Function getTatCaChiTietNhapSach() As List(Of ChiTietPhieuNhapDTO)
        Return SachDAL.getTatCaChiTietNhapSach()
    End Function

    Public Shared Function ChuanHoaDieuKienTheoDonGiaBan(strDonGiaBanfr As String, strDonGiaBanto As String) As String
        Dim strCommand As String = " [clmDonGiaBan] >= " + (strDonGiaBanfr)
        If (strDonGiaBanto <> "Tối đa") Then
            strCommand += "AND [clmDonGiaBan] <= " + (strDonGiaBanto)
        End If
        Return strCommand
    End Function

    Public Shared Function getMaSachVoiDonGiaBan(text1 As String, text2 As String) As DataTable
        Return SachDAL.getMaSachVoiDonGiaBan(text1, text2)
    End Function

    Public Shared Function ChuanHoaDieuKienTheoNgayBan(dateNgayBanfr As Date, dateNgayBanto As Date) As String
        Dim strCommand As String = " [clmNgayLapHoaDon] >= #" + (dateNgayBanfr.ToShortDateString) + "# "

        strCommand += "AND [clmNgayLapHoaDon] <= #" + (dateNgayBanto.ToShortDateString) + "#"

        Return strCommand
    End Function

    Public Shared Function getMaSachVoiNgayBan(dateTime1 As Date, dateTime2 As Date) As DataTable
        Return SachDAL.getMaSachVoiNgayBan(dateTime1, dateTime2)
    End Function

    Public Shared Function ChuanHoaDieuKienTheoDonGiaBanDuKien(strDonGiaBanDuKienfr As String, strDonGiaBanDuKiento As String) As String
        Dim strCommand As String = " [clmDonGiaDuKien] >= " + (strDonGiaBanDuKienfr)
        If (strDonGiaBanDuKiento <> "Tối đa") Then
            strCommand += "AND [clmDonGiaDuKien] <= " + (strDonGiaBanDuKiento)
        End If
        Return strCommand
    End Function
End Class
