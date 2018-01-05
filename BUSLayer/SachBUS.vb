Imports DALLayer

Imports DTO

Public Class SachBUS
    Public Shared Function PhatSinhMaSach() As String
        Return SachDAL.PhatSinhMaSach()
    End Function

    Friend Shared Function getTatCaTheLoaiSach() As List(Of String)
        Return SachDAL.getTatCaTheLoaiSach()
    End Function

    Friend Shared Function getSach() As List(Of SachDTO)
        Return SachDAL.getSach()
    End Function

    Public Shared Function isVaild(sachDTO As SachDTO) As Object
        If (sachDTO.StrTacGia = "" Or sachDTO.StrTenSach = "" Or sachDTO.StrTheLoai = "") Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function getSoLuongTon(strMaSach As String) As Integer
        Return SachDAL.getSoLuongTon(strMaSach)
    End Function

    Public Shared Sub ThemSachVaoDB(sachDTO As SachDTO)
        SachDAL.ThemSachVaoDB(sachDTO)
    End Sub

    Friend Shared Function getTatCaTacGiaSach() As List(Of String)
        Return SachDAL.getTatCaTacGiaSach()
    End Function

    Public Shared Function isContainTenSach(v As String) As Boolean
        Return SachDAL.isContainTenSach(v)
    End Function


    Public Shared Function isContainMaSach(v As String) As Boolean
        Return SachDAL.isContainMaSach(v)
    End Function


    Public Shared Function LaySachDTO(strMaSach As String) As SachDTO
        Return SachDAL.LaySachDTO(strMaSach)
    End Function

    Public Shared Function LayTatCaSach() As List(Of SachDTO)
        Return SachDAL.LayTatCaSach()
    End Function

    Public Shared Function LayTatCaSachXapSep() As List(Of SachDTO)
        Return SachDAL.LayTatCaSach()
    End Function

    Public Shared Sub CapNhatSoLuongTon(sachDTO As SachDTO)
        SachDAL.CapNhatSoLuongTon(sachDTO)
    End Sub

    Public Shared Function LayTatCaSachVaoDictionary() As Dictionary(Of String, SachDTO)
        Return SachDAL.LayTatCaSachVaoDic()
    End Function

    Public Shared Sub CapNhatSach(sachDTO As SachDTO)
        SachDAL.CapNhatSach(sachDTO)
    End Sub

    Public Shared Function getDonGiaDuKien(strMaSach As String) As Integer
        Return SachDAL.getDonGiaDuKien(strMaSach)
    End Function
End Class


