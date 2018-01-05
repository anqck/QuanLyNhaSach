Imports DALLayer
Imports DTO

Public Class LapBaoCaoTonBUS
    Public Shared Function countSoThangBaoCao() As Boolean
        Return LapBaoCaoTonDAL.countSoThangBaoCao()
    End Function

    Public Shared Function getThangDauTienTrongPhieuNhap() As DateTime
        Return LapBaoCaoTonDAL.getThangDauTienTrongPhieuNhap()
    End Function

    Public Shared Function getPhatSinhNhapTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Return LapBaoCaoTonDAL.getPhatSinhNhapTrongThang(month, year)
    End Function

    Public Shared Function getPhatSinhXuatTrongThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Return LapBaoCaoTonDAL.getPhatSinhXuatTrongThang(month, year)
    End Function

    Public Shared Function getThangBaoCaoDauTien() As DateTime
        Return LapBaoCaoTonDAL.getThangBaoCaoDauTien()
    End Function

    Public Shared Function KiemTraThangBaoCaoDaCoChua(month As Integer, year As Integer) As Boolean
        Return LapBaoCaoTonDAL.KiemTraThangBaoCaoDaCoChua(month, year)
    End Function

    Public Shared Function PhatSinhMaBaoCaoTon() As String
        Return LapBaoCaoTonDAL.PhatSinhMaBaoCaoTon()
    End Function

    Public Shared Sub LuuBaoCaoTon(baoCaoDTO As BaoCaoTonDTO)
        LapBaoCaoTonDAL.LuuBaoCaoTon(baoCaoDTO)
    End Sub

    Public Shared Function PhatSinhMaChiTietBaoCaoTon() As String
        Return LapBaoCaoTonDAL.PhatSinhMaChiTietBaoCaoTon()
    End Function

    Public Shared Sub LuuChiTietBaoCaoTon(chiTietBaoCaoDTO As ChiTietBaoCaoTonDTO)
        LapBaoCaoTonDAL.LuuChiTietBaoCaoTon(chiTietBaoCaoDTO)
    End Sub

    Public Shared Function getTonCuoiCuaThang(month As Integer, year As Integer) As Dictionary(Of String, Integer)
        Return LapBaoCaoTonDAL.getTonCuoiCuaThang(month, year)
    End Function

    Public Shared Function getBaoCaoThang(month As Integer, year As Integer) As DataTable
        Return LapBaoCaoTonDAL.getBaoCaoThang(month, year)
    End Function

    Public Shared Function PhatSinhMaBaoCaoCongNo() As String
        Return LapBaoCaoCongNoDAL.PhatSinhMaBaoCaoConNo()
    End Function
End Class
