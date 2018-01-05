Imports DALLayer
Imports DTO
Public Class NguoiDungBUS
    Public Shared Function PhatSinhMaNguoiDung() As String
        Return NguoiDungDAL.PhatSinhNguoiDung()
    End Function

    Public Function isVaild(NguoiDungDTO As NguoiDungDTO) As Boolean
        If (NguoiDungDTO.StrTenDangNhap = "" Or NguoiDungDTO.StrHoTenNguoiDung = "" Or NguoiDungDTO.StrMatKhau = "" Or NguoiDungDTO.StrMaLoaiNguoiDung = "") Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Sub ThemNguoiDung(NguoiDungDTO As NguoiDungDTO)
        NguoiDungDAL.ThemNguoiDungVaoDB(NguoiDungDTO)
    End Sub

    Public Shared Function isContainNguoiDung(tendangnhap As String, matkhau As String) As Boolean
        Return NguoiDungDAL.isContainNguoiDung(tendangnhap, matkhau)
    End Function

    Public Shared Function TraCuuTatCaNguoiDungTheoMaNguoiDungVaTen(strMaNguoiDung As String, strHoTenNguoiDung As String) As List(Of NguoiDungDTO)
        Return NguoiDungDAL.TraCuuTatCaNguoiDungTheoMaNguoiDungVaTen(strMaNguoiDung, strHoTenNguoiDung)
    End Function

    Public Shared Function LayNguoiDungDTO(strMaNguoiDung As String) As NguoiDungDTO
        Return NguoiDungDAL.LayNguoiDungDTO(strMaNguoiDung)
    End Function

    Public Shared Function LayTatCaNguoiDung() As List(Of NguoiDungDTO)
        Return NguoiDungDAL.LayTatCaNguoiDung()
    End Function

    Public Shared Function isValidMaNguoiDungandHoTenNguoiDung(text1 As String, text2 As String) As Boolean
        Return NguoiDungDAL.isValidMaNguoiDungandHoTenNguoiDung(text1, text2)
    End Function
    Public Shared Sub CapNhatNguoiDung(nguoidungDTO As NguoiDungDTO)
        NguoiDungDAL.CapNhatNguoiDung(nguoidungDTO)
    End Sub
End Class
