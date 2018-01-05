Public Class ChonKhachHangBUS
    Public Shared Function ChuanHoaDieuKienTheoMaKhachHang(text As String) As String
        Return " [clmMaKhachHang] LIKE '%" + text + "%'"
    End Function

    Public Shared Function ChuanHoaDieuKienTheoHoTenKhachHang(text As String) As String
        Return " [clmHoTenKhachHang] LIKE '%" + text + "%'"
    End Function

    Public Shared Function ChuanHoaDieuKienTheoDienThoai(text As String) As String
        Return " [clmDienThoai] LIKE '%" + text + "%'"
    End Function
End Class
