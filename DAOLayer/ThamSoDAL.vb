Imports DTO

Public Class ThamSoDAL
    Public Shared Function getSoLuongNhapToiThieu() As Integer
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT SOLUONGNHAPTOITHIEU FROM THAMSO")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getSoLuongTonToiDa() As Integer
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT SoLuongTonToiDa FROM THAMSO")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getSoLuongTonToiThieu() As Integer
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT SoLuongTonToiThieu FROM THAMSO")
        Return dt.Rows(0).Item(0)

    End Function

    Public Shared Function getSoTienNoToiDa() As Integer
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT SoTienNoToiDa FROM THAMSO")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function getApDungQuyDinhTienThuKhongVuotTienNo() As Boolean
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT ApDungQuyDinhTienThuKhongVuotTienNo FROM THAMSO")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Sub luuThamSo(thamSoINFO As ThamSoDTO)
        Dim strCommand As String = "UPDATE THAMSO SET THAMSO.SoLuongNhapToiThieu = $0, THAMSO.SoLuongTonToiDa = $1, THAMSO.SoLuongTonToiThieu = $2, THAMSO.SoTienNoToiDa = $3, THAMSO.ApDungQuyDinhTienThuKhongVuotTienNo = $4;"
        strCommand = strCommand.Replace("$0", thamSoINFO.ISoLuongNhapToiThieu)
        strCommand = strCommand.Replace("$1", thamSoINFO.ISoLuongTonToiDa)
        strCommand = strCommand.Replace("$2", thamSoINFO.ISoLuongTonToiThieu)
        strCommand = strCommand.Replace("$3", thamSoINFO.ISoTienNoToiDa)
        strCommand = strCommand.Replace("$4", thamSoINFO.BoolApDungQuyDinhTienThuKhongVuotTienNo)


        DataProvider.ExecuteNonQuery(strCommand)
    End Sub
End Class
