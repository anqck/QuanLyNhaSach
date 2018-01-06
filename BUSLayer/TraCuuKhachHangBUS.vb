Public Class TraCuuKhachHangBUS
    Public Shared Function ChuanHoaDieuKienTheoMaKhachHang(strMaKhachHang As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmMaKhachHang] = '" + strMaKhachHang + "'"
        Else
            Return " [clmMaKhachHang] LIKE '%" + strMaKhachHang + "%'"
        End If


    End Function

    Public Shared Function ChuanHoaDieuKienTheoHoTenKhachHang(strHoTenKhachHang As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmHoTenKhachHang] = '" + strHoTenKhachHang + "'"
        Else
            Return " [clmHoTenKhachHang] LIKE '%" + strHoTenKhachHang + "%'"
        End If
    End Function

    Public Shared Function ChuanHoaDieuKienTheoDiaChi(strDiaChi As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmDiaChi] = '" + strDiaChi + "'"
        Else
            Return " [clmDiaChi] LIKE '%" + strDiaChi + "%'"
        End If
    End Function

    Public Shared Function ChuanHoaDieuKienTheoDienThoai(strDienThoai As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmDienThoai] = '" + strDienThoai + "'"
        Else
            Return " [clmDienThoai] LIKE '%" + strDienThoai + "%'"
        End If
    End Function

    Public Shared Function ChuanHoaDieuKienTheoEmail(strEmail As String, strKieuTimKiem As String) As String
        If (strKieuTimKiem = "Chính xác") Then
            Return " [clmEmail] = '" + strEmail + "'"
        Else
            Return " [clmEmail] LIKE '%" + strEmail + "%'"
        End If
    End Function

    Public Shared Function ChuanHoaDieuKienTheoSoTienNo(strSoTienNofr As String, strSoTienNoto As String) As String

        Dim strCommand As String = " [clmSoTienNo] >= " + (strSoTienNofr.Replace(".", ""))
        If (strSoTienNoto <> "Tối đa") Then
            strCommand += "AND [clmSoTienNo] <= " + (strSoTienNoto)
        End If
        Return strCommand
    End Function
End Class
