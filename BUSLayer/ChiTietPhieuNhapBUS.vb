Imports DALLayer
Imports DTO

Public Class ChiTietPhieuNhapBUS
    Public Shared Function PhatSinhMaChiTietPhieuNhap() As String
        Return ChiTietPhieuNhapDAL.PhatSinhMaChiTietPhieuNhap().ToString()
    End Function

    Public Shared Sub ThemChiTietPhieuNhap(chiTietPhieuNhapDTO As ChiTietPhieuNhapDTO)
        ChiTietPhieuNhapDAL.ThemChiTietPhieuNhap(chiTietPhieuNhapDTO)
    End Sub
End Class
