Imports DALLayer
Imports DTO

Public Class HoaDonBUS
    Public Shared Function PhatSinhMaHoaDon() As String
        Return HoaDonDAL.PhatSinhMaHoaDon()
    End Function

    Public Shared Function isValidSoLuongBan(strMaSach As String, iSoLuongBan As Integer) As Boolean
        If (iSoLuongBan > SachBUS.getSoLuongTon(strMaSach)) Then
            Return False
        End If
        Return True
    End Function

    Public Shared Function isValidSoLuongToiThieuSauKhiBan(strMaSach As String, iSoLuongBan As Integer) As Boolean
        If (SachBUS.getSoLuongTon(strMaSach) - iSoLuongBan < ThamSoBUS.getSoLuongTonToiThieu()) Then
            Return False
        End If
        Return True
    End Function

    Public Shared Function isValidSoTienNoToiDa(strMaKhachHang As String) As Boolean
        If (KhachHangBUS.getSoTienNo(strMaKhachHang) > ThamSoBUS.getSoTienNoToiDa()) Then
            Return False
        End If
        Return True
    End Function

    Public Shared Sub ThemHoaDon(hoaDonDTO As HoaDonDTO)
        HoaDonDAL.ThemHoaDon(hoaDonDTO)
    End Sub

    Public Shared Function LayTatCaHoaDon() As List(Of HoaDonDTO)
        Return HoaDonDAL.LayTatCaHoaDon()
    End Function
End Class
