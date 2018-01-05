Imports DALLayer
Imports DTO

Public Class KhachHangBUS
    Public Shared Function PhatSinhMaKhachHang() As String
        Return KhachHangDAL.PhatSinhKhachHang()
    End Function

    Public Function isVaild(khachhangDTO As KhachHangDTO) As Boolean
        If (khachhangDTO.StrDiaChi = "" Or khachhangDTO.StrHoTenKhachHang = "" Or khachhangDTO.StrEmail = "" Or khachhangDTO.StrDienThoai = "") Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Sub ThemKhachHang(khachhangDTO As KhachHangDTO)
        KhachHangDAL.ThemKhachHangVaoDB(khachhangDTO)
    End Sub

    Public Shared Function isContainMaKhachHang(v As String) As Boolean
        Return KhachHangDAL.isContainTenSach(v)
    End Function


    Public Shared Function isContainTenKhachHang(v As String) As Boolean
        Return KhachHangDAL.isContainTenKhachHang(v)
    End Function

    Public Shared Function getSoTienNo(strMaKhachHang As String) As Integer
        Return KhachHangDAL.getSoTienNo(strMaKhachHang)
    End Function

    Public Shared Function TraCuuTatCaKhachHangTheoMaKhachHangVaTen(strMaKhachHang As String, strHoTenKhachHang As String) As List(Of KhachHangDTO)
        Return KhachHangDAL.TraCuuTatCaKhachHangTheoMaKhachHangVaTen(strMaKhachHang, strHoTenKhachHang)
    End Function

    Public Shared Function LayKhachHangDTO(strMaKhachHang As String) As KhachHangDTO
        Return KhachHangDAL.LayKhachHangDTO(strMaKhachHang)
    End Function

    Public Shared Function LayTatCaKhachHang() As List(Of KhachHangDTO)
        Return KhachHangDAL.LayTatCaKhachHang()
    End Function

    Public Shared Function isValidMaKhachHangandHoTenKhachHang(text1 As String, text2 As String) As Boolean
        Return KhachHangDAL.isValidMaKhachHangandHoTenKhachHang(text1, text2)
    End Function

    Public Shared Sub CapNhatSoTienNo(khachHangDTO As KhachHangDTO)
        KhachHangDAL.CapNhatSoTienNo(khachHangDTO)
    End Sub

    Public Shared Sub CapNhatKhachHang(khachhangDTO As KhachHangDTO)
        KhachHangDAL.CapNhatKhachHang(khachhangDTO)
    End Sub

    Public Shared Function LayTatCaKhachHangVaoDictionary() As Dictionary(Of String, KhachHangDTO)
        Return KhachHangDAL.LayTatCaKhachHangVaoDictionary()

    End Function
End Class
