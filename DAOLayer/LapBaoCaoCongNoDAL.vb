Imports DTO

Public Class LapBaoCaoCongNoDAL
    Public Shared Function countSoThangBaoCao() As Integer
        Dim strCommand = "Select COUNT(A.MaBaoCaoCongNo)  From BAOCAOCONGNO A"
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getThangDauTienTrongHoaDon() As Date
        Dim strCommand = "Select TOP 1 A.NgayLapHoaDon From HOADON A Order By A.NgayLapHoaDon ASC"

        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getPhatSinhBanTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Dim res As New Dictionary(Of String, Integer)

        Dim strCommand = "SELECT B.MaKhachHang, Sum(B.TongThanhTien) As PhatSinhBan FROM HOADON B WHERE MONTH( B.NgayLapHoaDon) = '$0' AND YEAR(B.NgayLapHoaDon) = '$1' GROUP BY B.MaKhachHang"
        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        For Each row In dt.Rows
            res.Add(row(0), row(1))
        Next

        Return res
    End Function

    Public Shared Sub LuuChiTietBaoCaoCongNo(chiTietBaoCaoDTO As ChiTietBaoCaoCongNoDTO)
        Dim strCommand As String = "INSERT INTO CHITIETBAOCAOCONGNO VALUES ('$0','$1', '$2', $3, $4, $5)"

        strCommand = strCommand.Replace("$0", chiTietBaoCaoDTO.StrMaChiTietBaoCaoCongNo)
        strCommand = strCommand.Replace("$1", chiTietBaoCaoDTO.StrMaBaoCaoCongNo)
        strCommand = strCommand.Replace("$2", chiTietBaoCaoDTO.StrMaKhachHang)
        strCommand = strCommand.Replace("$3", chiTietBaoCaoDTO.INoDau)
        strCommand = strCommand.Replace("$4", chiTietBaoCaoDTO.INoPhatSinh)
        strCommand = strCommand.Replace("$5", chiTietBaoCaoDTO.INoCuoi)


        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function getBaoCaoThang(month As Integer, year As Integer) As DataTable
        Dim strCommand As String = "Select  B.MaKhachHang, B.NoDau, B.NoPhatSinh, B.NoCuoi From BAOCAOCONGNO A, CHITIETBAOCAOCONGNO B Where A.MaBaoCaoCongNo = B.MaBaoCaoCongNo And month(A.ThangBaoCao) = '$0' AND YEAR(A.ThangBaoCao) = '$1'"

        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)

        Return DataProvider.ExecuteQuery(strCommand)
    End Function

    Public Shared Function getThangBaoCaoDauTien() As Date
        Dim strCommand = "SELECT Top 1 ThangBaoCao FROM BAOCAOCONGNO ORDER BY ThangBaoCao "
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getNoCuoiCuaThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Dim res As New Dictionary(Of String, Integer)
        Dim strCommand As String = "Select  MaSach, NoCuoi From CHITIETBAOCONGNO, BAOCAOCONGNO Where CHITIETBAOCAOCONGNO.MaBaoCaoCongNo = BAOCAOCONGNO.MaBaoCaoCongNo And month(BAOCAOCONGNO.ThangBaoCao) = '$0' AND YEAR(BAOCAOCONGNO.ThangBaoCao) = '$1'"

        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        For Each row In dt.Rows
            res.Add(row(0), row(1))
        Next

        Return res
    End Function

    Public Shared Function PhatSinhMaChiTietBaoCaoCongNo() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM CHITIETBAOCAOCONGNO")
        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Sub LuuBaoCaoCongNo(BaoCaoDTO As BaoCaoCongNoDTO)
        Dim strCommand As String = "INSERT INTO BAOCAOCONGNO VALUES ('$0','$1')"
        strCommand = strCommand.Replace("$0", BaoCaoDTO.StrMaBaoCaoCongNo)
        strCommand = strCommand.Replace("$1", BaoCaoDTO.DateThangBaoCao)


        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function getPhatSinhThuTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Dim res As New Dictionary(Of String, Integer)

        Dim strCommand = "SELECT B.MaKhachHang, Sum(B.SoTienThu) As PhatSinhThu FROM PHIEUTHUTIEN B WHERE MONTH( B.NgayThuTien) = '$0' AND YEAR(B.NgayThuTien) = '$1' GROUP BY B.MaKhachHang"
        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        For Each row In dt.Rows
            res.Add(row(0), row(1))
        Next

        Return res
    End Function

    Public Shared Function PhatSinhMaBaoCaoConNo() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM BAOCAOCONGNO")
        Return dt.Rows(0).Item(0).ToString
    End Function
    Public Shared Function KiemTraThangBaoCaoDaCoChua(month As Integer, year As Integer) As Boolean
        Dim strCommand = "Select * From BAOCAOCONGNO Where month(BAOCAOCONGNO.ThangBaoCao) = '$0' AND YEAR(BAOCAOCONGNO.ThangBaoCao) = '$1'"
        strCommand = strCommand.Replace("$0", month)
        strCommand = strCommand.Replace("$1", year)
        Dim dt As DataTable = DataProvider.ExecuteQuery(strCommand)

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
