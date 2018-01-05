Imports DTO

Public Class HoaDonDAL
    Public Shared Function PhatSinhMaHoaDon() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM HOADON")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Sub ThemHoaDon(hoaDonDTO As HoaDonDTO)
        Dim strCommand As String = "INSERT INTO HOADON VALUES ('$0','$1','$2',$3)"
        strCommand = strCommand.Replace("$0", hoaDonDTO.StrMaHoaDon)
        strCommand = strCommand.Replace("$1", hoaDonDTO.StrMaKhachHang)
        strCommand = strCommand.Replace("$2", hoaDonDTO.DateNgayLapHoaDon)
        strCommand = strCommand.Replace("$3", hoaDonDTO.ITongThanhTien)


        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function LayTatCaHoaDon() As List(Of HoaDonDTO)
        Dim dt As New DataTable
        Dim res As New List(Of HoaDonDTO)

        Dim strCommand = "(Select * FROM HOADON )"

        dt = DataProvider.ExecuteQuery(strCommand)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim hoadonINFO As New HoaDonDTO()

            hoadonINFO.StrMaHoaDon = dt.Rows(i)("MaHoaDon")
            hoadonINFO.StrMaKhachHang = dt.Rows(i)("MaKhachHang")
            hoadonINFO.DateNgayLapHoaDon = dt.Rows(i)("NgayLapHoaDon")
            hoadonINFO.ITongThanhTien = dt.Rows(i)("TongThanhTien")

            res.Add(hoadonINFO)
        Next
        Return res


    End Function
End Class
