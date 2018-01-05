Imports DTO

Public Class PhieuThuTienDAL
    Public Shared Function PhatSinhMaPhieuThuTien() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM PHIEUTHUTIEN")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Sub luuPhieuThuTien(phieuThuTienINFO As PhieuThuTienDTO)
        Dim strCommand As String

        strCommand = "INSERT INTO PHIEUTHUTIEN VALUES ( '$1', '$2','$3', $4)"
        strCommand = strCommand.Replace("$1", phieuThuTienINFO.StrMaPhieuThu)
        strCommand = strCommand.Replace("$2", phieuThuTienINFO.StrMaKhachHang)
        strCommand = strCommand.Replace("$3", phieuThuTienINFO.DateNgayThuTien)
        strCommand = strCommand.Replace("$4", phieuThuTienINFO.ISoTienThu)

        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function LayTatCaPhieuThuTien() As List(Of PhieuThuTienDTO)
        Dim dt As New DataTable
        Dim res As New List(Of PhieuThuTienDTO)

        Dim strCommand = "(Select * FROM PHIEUTHUTIEN )"

        dt = DataProvider.ExecuteQuery(strCommand)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim phieuthutienINFO As New PhieuThuTienDTO()

            phieuthutienINFO.StrMaPhieuThu = dt.Rows(i)("MaPhieuThuTien")
            phieuthutienINFO.StrMaKhachHang = dt.Rows(i)("MaKhachHang")
            phieuthutienINFO.DateNgayThuTien = dt.Rows(i)("NgayThuTien")
            phieuthutienINFO.ISoTienThu = dt.Rows(i)("SoTienThu")

            res.Add(phieuthutienINFO)
        Next
        Return res
    End Function
End Class
