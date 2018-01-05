Imports DTO

Public Class LapBaoCaoTonDAL
    Public Shared Function getThangDauTienTrongPhieuNhap() As Date
        Dim strCommand = "Select TOP 1 A.NgayNhap From PHIEUNHAP A Order By A.NgayNhap ASC"

        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function countSoThangBaoCao() As Boolean
        Dim strCommand = "Select COUNT(A.MaBaoCaoTon)  From BAOCAOTON A"
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)

    End Function

    Public Shared Function getPhatSinhNhapTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Dim res As New Dictionary(Of String, Integer)

        Dim strCommand = "SELECT B.MaSach, Sum(B.SoLuongNhap) As PhatSinhNhap FROM PHIEUNHAP A, CHITIETPHIEUNHAP B WHERE A.MaPhieuNhap = B.MaPhieuNhap AND MONTH( A.NgayNhap) = '$0' AND YEAR(A.NgayNhap) = '$1' GROUP BY B.MaSach"
        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        For Each row In dt.Rows
            res.Add(row(0), row(1))
        Next

        Return res
    End Function

    Public Shared Function getThangBaoCaoDauTien() As DateTime
        Dim strCommand = "SELECT Top 1 ThangBaoCao FROM BAOCAOTON ORDER BY ThangBaoCao "
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function PhatSinhMaBaoCaoTon() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM BAOCAOTON")
        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Sub LuuBaoCaoTon(baoCaoDTO As BaoCaoTonDTO)
        Dim strCommand As String = "INSERT INTO BAOCAOTON VALUES ('$0','$1')"
        strCommand = strCommand.Replace("$0", baoCaoDTO.StrMaBaoCaoTon)
        strCommand = strCommand.Replace("$1", baoCaoDTO.DateThangBaoCao)


        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function getBaoCaoThang(month As Integer, year As Integer) As DataTable
        Dim strCommand As String = "Select  B.MaSach, B.TonDau, B.TonPhatSinh, B.TonCuoi From BAOCAOTON A, CHITIETBAOCAOTON B Where A.MaBaoCaoTon = B.MaBaoCaoTon And month(A.ThangBaoCao) = '$0' AND YEAR(A.ThangBaoCao) = '$1'"

        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)

        Return DataProvider.ExecuteQuery(strCommand)
    End Function

    Public Shared Function getTonCuoiCuaThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Dim res As New Dictionary(Of String, Integer)
        Dim strCommand As String = "Select  MaSach, TonCuoi From CHITIETBAOCAOTON, BAOCAOTON Where CHITIETBAOCAOTON.MaBaoCaoTon = BAOCAOTON.MaBaoCaoTon And month(BAOCAOTON.ThangBaoCao) = '$0' AND YEAR(BAOCAOTON.ThangBaoCao) = '$1'"

        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        For Each row In dt.Rows
            res.Add(row(0), row(1))
        Next

        Return res
    End Function

    Public Shared Sub LuuChiTietBaoCaoTon(chiTietBaoCaoDTO As ChiTietBaoCaoTonDTO)
        Dim strCommand As String = "INSERT INTO CHITIETBAOCAOTON VALUES ('$0','$1', '$2', $3, $4, $5)"
        strCommand = strCommand.Replace("$0", chiTietBaoCaoDTO.StrMaChiTietBaoCaoTon)
        strCommand = strCommand.Replace("$1", chiTietBaoCaoDTO.StrMaBaoCaoTon)
        strCommand = strCommand.Replace("$2", chiTietBaoCaoDTO.StrMaSach)
        strCommand = strCommand.Replace("$3", chiTietBaoCaoDTO.ITonDau)
        strCommand = strCommand.Replace("$4", chiTietBaoCaoDTO.ITonPhatSinh)
        strCommand = strCommand.Replace("$5", chiTietBaoCaoDTO.ITonCuoi)

        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function PhatSinhMaChiTietBaoCaoTon() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM CHITIETBAOCAOTON")
        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Function KiemTraThangBaoCaoDaCoChua(month As Integer, year As Integer) As Boolean
        Dim strCommand = "Select * From BAOCAOTON Where month(BAOCAOTON.ThangBaoCao) = '$0' AND YEAR(BAOCAOTON.ThangBaoCao) = '$1'"
        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function getPhatSinhXuatTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Dim res As New Dictionary(Of String, Integer)

        Dim strCommand = "Select B.MaSach, Sum(B.SoLuongBan) As PhatSinhXuat FROM HOADON A, CHITIETHOADON B WHERE A.MaHoaDon = B.MaHoaDon  And MONTH( A.NgayLapHoaDon) = '$0' AND YEAR(A.NgayLapHoaDon) = '$1' GROUP BY B.MaSach "
        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        For Each row In dt.Rows
            res.Add(row(0), row(1))
        Next

        Return res
    End Function
End Class
