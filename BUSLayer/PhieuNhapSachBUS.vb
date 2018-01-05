Imports DALLayer
Imports DTO

Public Class PhieuNhapSachBUS

    Public Shared Function PhatSinhMaPhieuNhap() As String
        Return PhieuNhapSachDAL.PhatSinhMaPhieuNhap()
    End Function

    Public Shared Sub ThemPhieuNhap(phieuNhapDTO As PhieuNhapSachDTO)
        PhieuNhapSachDAL.ThemPhieuNhap(phieuNhapDTO)
    End Sub

    Public Shared Function isValidSoLuongNhapToiThieu(editingValue As String) As Boolean


        If (editingValue.ToString Is "") Then
            Return False
        End If


        If (Integer.Parse(editingValue) >= ThamSoBUS.getSoLuongNhapToiThieu()) Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function isValidSoLuongTonToiDa(v As Integer) As Boolean
        If (v <= ThamSoBUS.getSoLuongTonToiDa()) Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function isValidSoLuong(toString As String) As Boolean
        Return toString <> ""
    End Function
End Class
