Imports DTO

Public Class ChiTietPhieuNhapDAL
    Public Shared Function PhatSinhMaChiTietPhieuNhap() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM CHITIETPHIEUNHAP")
        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Shared Sub ThemChiTietPhieuNhap(chiTietPhieuNhapDTO As ChiTietPhieuNhapDTO)
        Dim strCom As String = "INSERT INTO CHITIETPHIEUNHAP VALUES (""" + chiTietPhieuNhapDTO.IMaChiTietPhieuNhap + """,""" + chiTietPhieuNhapDTO.IMaPhieuNhap + """,""" + chiTietPhieuNhapDTO.IMaSach + """," + chiTietPhieuNhapDTO.ISoLuongNhap.ToString + ")"
        DataProvider.ExecuteNonQuery(strCom)
    End Sub
End Class
