Imports DALLayer
Imports DTO

Public Class ThamSoBUS
    Public Shared Function getSoLuongNhapToiThieu() As Integer
        Return ThamSoDAL.getSoLuongNhapToiThieu()
    End Function

    Private Shared Function checkApDungThayDoiQuyDinh() As Boolean
        Throw New NotImplementedException()
    End Function

    Public Shared Function getSoLuongTonToiDa() As Integer
        Return ThamSoDAL.getSoLuongTonToiDa()
    End Function

    Public Shared Function getSoLuongTonToiThieu() As Integer
        Return ThamSoDAL.getSoLuongTonToiThieu()
    End Function

    Public Shared Function getSoTienNoToiDa() As Integer
        Return ThamSoDAL.getSoTienNoToiDa()
    End Function

    Public Shared Function getApDungQuyDinhTienThuKhongVuotTienNo() As Boolean
        Return ThamSoDAL.getApDungQuyDinhTienThuKhongVuotTienNo()
    End Function

    Public Shared Sub luuThamSo(thamSoINFO As ThamSoDTO)
        ThamSoDAL.luuThamSo(thamSoINFO)
    End Sub
End Class
