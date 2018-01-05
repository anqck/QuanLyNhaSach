Imports DTO

Public Class ChiTietHoaDonDAL
    Public Shared Function PhatSinhMaChiTietHoaDon() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM CHITIETHOADON")
        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Sub ThemChiTietHoaDon(chiTietHoaDonDTO As ChiTietHoaDonDTO)
        Dim strCommand As String = "INSERT INTO CHITIETHOADON VALUES ('$0','$1','$2',$3,$4,$5)"
        strCommand = strCommand.Replace("$0", chiTietHoaDonDTO.StrMaChiTietHoaDon)
        strCommand = strCommand.Replace("$1", chiTietHoaDonDTO.StrMaHoaDon)
        strCommand = strCommand.Replace("$2", chiTietHoaDonDTO.StrMaSach)
        strCommand = strCommand.Replace("$3", chiTietHoaDonDTO.IDonGiaBan)
        strCommand = strCommand.Replace("$4", chiTietHoaDonDTO.ISoLuongBan)
        strCommand = strCommand.Replace("$5", chiTietHoaDonDTO.IThanhTien)

        DataProvider.ExecuteNonQuery(strCommand)
    End Sub
End Class
