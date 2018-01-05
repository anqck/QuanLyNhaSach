Imports DALLayer
Imports DTO

Public Class ChiTietHoaDonBUS
    Public Shared Function PhatSinhMaChiTietHoaDon() As String
        Return ChiTietHoaDonDAL.PhatSinhMaChiTietHoaDon()
    End Function

    Public Shared Sub ThemChiTietHoaDon(chiTietHoaDonDTO As ChiTietHoaDonDTO)
        ChiTietHoaDonDAL.ThemChiTietHoaDon(chiTietHoaDonDTO)
    End Sub
End Class
