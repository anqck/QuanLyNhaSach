Imports DTO
Public Class LoaiNguoiDungDAL


    Public Shared Function LayTatCaLoaiNguoiDung() As List(Of LoaiNguoiDungDTO)
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT * FROM LOAINGUOIDUNG")

        Dim res As New List(Of LoaiNguoiDungDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim LoaiNguoiDungINFO As New LoaiNguoiDungDTO()

            LoaiNguoiDungINFO.StrMaLoaiNguoiDung = dt.Rows(i)("MaLoaiNguoiDung")
            LoaiNguoiDungINFO.StrTenLoaiNguoiDung = dt.Rows(i)("TenLoaiNguoiDung")
            res.Add(LoaiNguoiDungINFO)
        Next

        Return res
    End Function

    Public Shared Function getMaLoaiNguoiDung(strTenLoaiNguoiDung As String) As String
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT MaLoaiNguoiDung FROM LOAINGUOIDUNG WHERE TenLoaiNguoiDung = '$0'"
        strCommand = strCommand.Replace("$0", strTenLoaiNguoiDung)
        dt = DataProvider.ExecuteQuery(strCommand)

        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getTenLoaiNguoiDung(strMaLoaiNguoiDung As String) As String
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT TenLoaiNguoiDung FROM LOAINGUOIDUNG WHERE MaLoaiNguoiDung = '$0'"
        strCommand = strCommand.Replace("$0", strMaLoaiNguoiDung)
        dt = DataProvider.ExecuteQuery(strCommand)
        Return dt.Rows(0).Item(0)
    End Function

End Class
