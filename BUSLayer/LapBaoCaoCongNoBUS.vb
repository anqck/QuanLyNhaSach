Imports DALLayer
Imports DTO

Public Class LapBaoCaoCongNoBUS
    Public Shared Function countSoThangBaoCao() As Integer
        Return LapBaoCaoCongNoDAL.countSoThangBaoCao()
    End Function

    Public Shared Function getThangDauTienTrongHoaDon() As DateTime
        Return LapBaoCaoCongNoDAL.getThangDauTienTrongHoaDon()
    End Function

    Public Shared Function getPhatSinhBanTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Return LapBaoCaoCongNoDAL.getPhatSinhBanTrongThang(month, year)
    End Function

    Public Shared Function getPhatSinhThuTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Return LapBaoCaoCongNoDAL.getPhatSinhThuTrongThang(month, year)
    End Function

    Public Shared Sub LuuBaoCaoCongNo(tempBaoCaoDTO As BaoCaoCongNoDTO)
        LapBaoCaoCongNoDAL.LuuBaoCaoCongNo(tempBaoCaoDTO)
    End Sub

    Public Shared Function PhatSinhMaChiTietBaoCaoCongNo() As String
        Return LapBaoCaoCongNoDAL.PhatSinhMaChiTietBaoCaoCongNo()
    End Function

    Public Shared Sub LuuChiTietBaoCaoCongNo(chiTietBaoCaoDTO As ChiTietBaoCaoCongNoDTO)
        LapBaoCaoCongNoDAL.LuuChiTietBaoCaoCongNo(chiTietBaoCaoDTO)
    End Sub

    Public Shared Function KiemTraThangBaoCaoDaCoChua(month As Integer, year As Integer) As Boolean
        Return LapBaoCaoCongNoDAL.KiemTraThangBaoCaoDaCoChua(month, year)
    End Function



    Public Shared Function getNoCuoiCuaThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Return LapBaoCaoCongNoDAL.getNoCuoiCuaThang(month, year)
    End Function

    Public Shared Function getThangBaoCaoDauTien() As Date
        Return LapBaoCaoCongNoDAL.getThangBaoCaoDauTien()
    End Function

    Public Shared Function getBaoCaoThang(month As Integer, year As Integer) As DataTable
        Throw New NotImplementedException()
    End Function
End Class
