Public Class ChonSachBUS
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

    Public Shared Function ChuanHoaDieuKienTheoMaSach(text As String) As String
        Return " [clmMaSach] LIKE '%" + text + "%'"
    End Function

    Public Shared Function ChuanHoaDieuKienTheoTenSach(text As String) As String
        Return " [clmTenSach] LIKE '%" + text + "%'"
    End Function
End Class
