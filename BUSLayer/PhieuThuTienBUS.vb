Imports DALLayer
Imports DTO

Public Class PhieuThuTienBUS
    Public Shared Function PhatSinhMaPhieuThuTien() As String
        Return PhieuThuTienDAL.PhatSinhMaPhieuThuTien()
    End Function

    Public Shared Sub luuPhieuThuTien(phieuThuTienINFO As PhieuThuTienDTO)
        PhieuThuTienDAL.luuPhieuThuTien(phieuThuTienINFO)
    End Sub

    Public Shared Sub CapNhatTienNoMoi(strMaKhachHang As String, iTienNoMoi As Integer)
        Dim KhachHangINFO As New KhachHangDTO

        KhachHangINFO.StrMaKhachHang = strMaKhachHang
        KhachHangINFO.ISoTienNo = iTienNoMoi

        KhachHangDAL.CapNhatSoTienNo(KhachHangINFO)
    End Sub

    Public Shared Function LayTatCaPhieuThuTien() As List(Of PhieuThuTienDTO)
        Return PhieuThuTienDAL.LayTatCaPhieuThuTien()
    End Function
End Class
