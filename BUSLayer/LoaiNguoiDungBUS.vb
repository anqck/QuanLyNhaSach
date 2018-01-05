Imports DALLayer
Imports DTO
Public Class LoaiNguoiDungBUS


    Public Shared Function getTenLoaiNguoiDung(strMaLoaiNguoiDung As String) As String
        Return LoaiNguoiDungDAL.getTenLoaiNguoiDung(strMaLoaiNguoiDung)
    End Function
    Public Shared Function getMaLoaiNguoiDung(strTenLoaiNguoiDung As String) As String
        Return LoaiNguoiDungDAL.getMaLoaiNguoiDung(strTenLoaiNguoiDung)
    End Function

    Public Shared Function LayTatCaLoaiNguoiDung() As List(Of LoaiNguoiDungDTO)
        Return LoaiNguoiDungDAL.LayTatCaLoaiNguoiDung()
    End Function





End Class
