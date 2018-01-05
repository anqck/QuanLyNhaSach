Imports DTO

Public Class KhachHangDAL
    Public Shared Function PhatSinhKhachHang() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM KHACHHANG")
        Return dt.Rows(0).Item(0)

    End Function

    Public Shared Sub ThemKhachHangVaoDB(khachhangDTO As KhachHangDTO)
        Dim strCommand As String
        strCommand = "INSERT INTO KHACHHANG VALUES ( '$1', '$2' , '$3', '$4' , '$5', $6)"
        strCommand = strCommand.Replace("$1", khachhangDTO.StrMaKhachHang)
        strCommand = strCommand.Replace("$2", khachhangDTO.StrHoTenKhachHang)
        strCommand = strCommand.Replace("$3", khachhangDTO.StrEmail)
        strCommand = strCommand.Replace("$4", khachhangDTO.StrDienThoai)
        strCommand = strCommand.Replace("$5", khachhangDTO.StrDienThoai)
        strCommand = strCommand.Replace("$6", khachhangDTO.ISoTienNo)
        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function isContainTenSach(v As String) As Boolean
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM KHACHHANG WHERE MaKhachHang = '$1'"
        strCommand = strCommand.Replace("$1", v)

        dt = DataProvider.ExecuteQuery(strCommand)

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function getSoTienNo(strMaKhachHang As String) As Integer
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT SoTienNo FROM KHACHHANG WHERE MaKhachHang = '$0'"
        strCommand = strCommand.Replace("$0", strMaKhachHang)
        dt = DataProvider.ExecuteQuery(strCommand)
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function TraCuuTatCaKhachHangTheoMaKhachHangVaTen(strMaKhachHang As String, strHoTenKhachHang As String) As List(Of KhachHangDTO)
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM KHACHHANG WHERE MaKhachHang LIKE '%$0%'AND HoTenKhachHang LIKE '%$1%'"
        strCommand = strCommand.Replace("$0", strMaKhachHang)
        strCommand = strCommand.Replace("$1", strHoTenKhachHang)
        dt = DataProvider.ExecuteQuery(strCommand)

        Dim res As New List(Of KhachHangDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim KhachHangINFO As New KhachHangDTO()

            KhachHangINFO.StrMaKhachHang = dt.Rows(i)("MaKhachHang")
            KhachHangINFO.StrHoTenKhachHang = dt.Rows(i)("HoTenKhachHang")
            KhachHangINFO.StrDiaChi = dt.Rows(i)("DiaChi")
            KhachHangINFO.StrEmail = dt.Rows(i)("Email")
            KhachHangINFO.StrDienThoai = dt.Rows(i)("DienThoai")
            KhachHangINFO.ISoTienNo = dt.Rows(i)("SoTienNo")

            res.Add(KhachHangINFO)
        Next

        Return res
    End Function

    Public Shared Sub CapNhatKhachHang(khachhangDTO As KhachHangDTO)
        Dim strCommand As String = "UPDATE KHACHHANG SET HoTenKhachHang = '$0', Email = '$1', DienThoai = '$2', DiaChi = '$3' WHERE MaKhachHang = '$4'"

        strCommand = strCommand.Replace("$0", khachhangDTO.StrHoTenKhachHang)
        strCommand = strCommand.Replace("$1", khachhangDTO.StrEmail)
        strCommand = strCommand.Replace("$2", khachhangDTO.StrDienThoai)
        strCommand = strCommand.Replace("$3", khachhangDTO.StrDiaChi)
        strCommand = strCommand.Replace("$4", khachhangDTO.StrMaKhachHang)

        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Sub CapNhatSoTienNo(khachHangDTO As KhachHangDTO)
        Dim strCom As String = "UPDATE KHACHHANG SET SoTienNo = $0 where MaKhachHang = '$1'"
        strCom = strCom.Replace("$0", khachHangDTO.ISoTienNo)
        strCom = strCom.Replace("$1", khachHangDTO.StrMaKhachHang)

        DataProvider.ExecuteNonQuery(strCom)
    End Sub

    Public Shared Function isValidMaKhachHangandHoTenKhachHang(text1 As String, text2 As String) As Boolean
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM KHACHHANG WHERE MaKhachHang = '$1' AND HoTenKhachHang = '$2'"
        strCommand = strCommand.Replace("$1", text1)
        strCommand = strCommand.Replace("$2", text2)

        dt = DataProvider.ExecuteQuery(strCommand)

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function LayTatCaKhachHang() As List(Of KhachHangDTO)
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT * FROM KHACHHANG")

        Dim res As New List(Of KhachHangDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim KhachHangINFO As New KhachHangDTO()

            KhachHangINFO.StrMaKhachHang = dt.Rows(i)("MaKhachHang")
            KhachHangINFO.StrHoTenKhachHang = dt.Rows(i)("HoTenKhachHang")
            KhachHangINFO.StrDiaChi = dt.Rows(i)("DiaChi")
            KhachHangINFO.StrEmail = dt.Rows(i)("Email")
            KhachHangINFO.StrDienThoai = dt.Rows(i)("DienThoai")
            KhachHangINFO.ISoTienNo = dt.Rows(i)("SoTienNo")

            res.Add(KhachHangINFO)
        Next

        Return res
    End Function

    Public Shared Function LayKhachHangDTO(strMaKhachHang As String) As KhachHangDTO
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM KHACHHANG WHERE MaKhachHang = '$0'"
        strCommand = strCommand.Replace("$0", strMaKhachHang)

        dt = DataProvider.ExecuteQuery(strCommand)


        If (dt.Rows.Count <> 0) Then
            Dim KhachHangINFO As New KhachHangDTO()

            KhachHangINFO.StrMaKhachHang = dt.Rows(0)("MaKhachHang")
            KhachHangINFO.StrHoTenKhachHang = dt.Rows(0)("HoTenKhachHang")
            KhachHangINFO.StrDiaChi = dt.Rows(0)("DiaChi")
            KhachHangINFO.StrEmail = dt.Rows(0)("Email")
            KhachHangINFO.StrDienThoai = dt.Rows(0)("DienThoai")
            KhachHangINFO.ISoTienNo = dt.Rows(0)("SoTienNo")

            Return KhachHangINFO
        Else
            Return Nothing

        End If
    End Function

    Public Shared Function isContainTenKhachHang(v As String) As Boolean
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM KHACHHANG WHERE HoTenKhachHang = '$1'"
        strCommand = strCommand.Replace("$1", v)

        dt = DataProvider.ExecuteQuery(strCommand)

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
