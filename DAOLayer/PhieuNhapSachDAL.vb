Imports DTO

Public Class PhieuNhapSachDAL
    Public Shared Function PhatSinhMaPhieuNhap() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM PHIEUNHAP")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Sub ThemPhieuNhap(phieuNhapDTO As PhieuNhapSachDTO)
        Dim strCom As String = "INSERT INTO PHIEUNHAP VALUES (""" + phieuNhapDTO.IMaPhieuNhap.ToString + """,""" + phieuNhapDTO.DateNgayNhap.ToString + """)"
        DataProvider.ExecuteNonQuery(strCom)
    End Sub
End Class
