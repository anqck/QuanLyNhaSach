Imports DTO
Public Class NguoiDungDAL
    Public Shared Function PhatSinhNguoiDung() As String
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT COUNT (*) FROM NguoiDung")
        Return dt.Rows(0).Item(0)

    End Function

    Public Shared Sub ThemNguoiDungVaoDB(NguoiDungDTO As NguoiDungDTO)
        Dim strCommand As String
        strCommand = "INSERT INTO NGUOIDUNG VALUES ( '$1', '$2' , '$3', '$4' , '$5')"
        strCommand = strCommand.Replace("$1", NguoiDungDTO.StrMaNguoiDung)
        strCommand = strCommand.Replace("$2", NguoiDungDTO.StrHoTenNguoiDung)
        strCommand = strCommand.Replace("$3", NguoiDungDTO.StrTenDangNhap)
        strCommand = strCommand.Replace("$4", NguoiDungDTO.StrMatKhau)
        strCommand = strCommand.Replace("$5", NguoiDungDTO.StrMaLoaiNguoiDung)
        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function TraCuuTatCaNguoiDungTheoMaNguoiDungVaTen(strMaNguoiDung As String, strHoTenNguoiDung As String) As List(Of NguoiDungDTO)
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM NGUOIDUNG WHERE MaNguoiDung LIKE '%$0%'AND HoTenNguoiDung LIKE '%$1%'"
        strCommand = strCommand.Replace("$0", strMaNguoiDung)
        strCommand = strCommand.Replace("$1", strHoTenNguoiDung)
        dt = DataProvider.ExecuteQuery(strCommand)

        Dim res As New List(Of NguoiDungDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim NguoiDungINFO As New NguoiDungDTO()

            NguoiDungINFO.StrMaNguoiDung = dt.Rows(i)("MaNguoiDung")
            NguoiDungINFO.StrHoTenNguoiDung = dt.Rows(i)("HoTenNguoiDung")
            NguoiDungINFO.StrTenDangNhap = dt.Rows(i)("TenDangNhap")
            NguoiDungINFO.StrMatKhau = dt.Rows(i)("MatKhau")
            NguoiDungINFO.StrMaLoaiNguoiDung = dt.Rows(i)("MaLoaiNguoiDung")
            res.Add(NguoiDungINFO)
        Next

        Return res
    End Function

    Public Shared Sub CapNhatNguoiDung(nguoidungDTO As NguoiDungDTO)
        Dim strCommand As String = "UPDATE NGUOIDUNG SET MaLoaiNguoiDung = '$4', HoTenNguoiDung = '$1', TenDangNhap = '$2', MatKhau = $3 WHERE MaNguoiDung = '$0'"
        strCommand = strCommand.Replace("$0", nguoidungDTO.StrMaNguoiDung)
        strCommand = strCommand.Replace("$1", nguoidungDTO.StrHoTenNguoiDung)
        strCommand = strCommand.Replace("$2", nguoidungDTO.StrTenDangNhap)
        strCommand = strCommand.Replace("$3", nguoidungDTO.StrMatKhau)
        strCommand = strCommand.Replace("$4", nguoidungDTO.StrMaLoaiNguoiDung)
        DataProvider.ExecuteNonQuery(strCommand)
    End Sub

    Public Shared Function isValidMaNguoiDungandHoTenNguoiDung(text1 As String, text2 As String) As Boolean
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM NGUOIDUNG WHERE MaNguoiDung = '$1' AND HoTenNguoiDung = '$2'"
        strCommand = strCommand.Replace("$1", text1)
        strCommand = strCommand.Replace("$2", text2)

        dt = DataProvider.ExecuteQuery(strCommand)

        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function LayTatCaNguoiDung() As List(Of NguoiDungDTO)
        Dim dt As New DataTable
        dt = DataProvider.ExecuteQuery("SELECT * FROM NGUOIDUNG")

        Dim res As New List(Of NguoiDungDTO)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim NguoiDungINFO As New NguoiDungDTO()

            NguoiDungINFO.StrMaNguoiDung = dt.Rows(i)("MaNguoiDung")
            NguoiDungINFO.StrHoTenNguoiDung = dt.Rows(i)("HoTenNguoiDung")
            NguoiDungINFO.StrTenDangNhap = dt.Rows(i)("TenDangNhap")
            NguoiDungINFO.StrMatKhau = dt.Rows(i)("MatKhau")
            NguoiDungINFO.StrMaLoaiNguoiDung = dt.Rows(i)("MaLoaiNguoiDung")

            res.Add(NguoiDungINFO)
        Next

        Return res
    End Function

    Public Shared Function LayNguoiDungDTObyTendangnhap(strTenDangNhap As String) As NguoiDungDTO
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '$0'"
        strCommand = strCommand.Replace("$0", strTenDangNhap)

        dt = DataProvider.ExecuteQuery(strCommand)


        If (dt.Rows.Count <> 0) Then
            Dim NguoiDungINFO As New NguoiDungDTO()

            NguoiDungINFO.StrMaNguoiDung = dt.Rows(0)("MaNguoiDung")
            NguoiDungINFO.StrHoTenNguoiDung = dt.Rows(0)("HoTenNguoiDung")
            NguoiDungINFO.StrTenDangNhap = dt.Rows(0)("TenDangNhap")
            NguoiDungINFO.StrMatKhau = dt.Rows(0)("MatKhau")
            NguoiDungINFO.StrMaLoaiNguoiDung = dt.Rows(0)("MaLoaiNguoiDung")

            Return NguoiDungINFO
        Else
            Return Nothing

        End If
    End Function
    Public Shared Function LayNguoiDungDTO(strMaNguoiDung As String) As NguoiDungDTO
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT * FROM NGUOIDUNG WHERE MaNguoiDung = '$0'"
        strCommand = strCommand.Replace("$0", strMaNguoiDung)

        dt = DataProvider.ExecuteQuery(strCommand)


        If (dt.Rows.Count <> 0) Then
            Dim NguoiDungINFO As New NguoiDungDTO()

            NguoiDungINFO.StrMaNguoiDung = dt.Rows(0)("MaNguoiDung")
            NguoiDungINFO.StrHoTenNguoiDung = dt.Rows(0)("HoTenNguoiDung")
            NguoiDungINFO.StrTenDangNhap = dt.Rows(0)("TenDangNhap")
            NguoiDungINFO.StrMatKhau = dt.Rows(0)("MatKhau")
            NguoiDungINFO.StrMaLoaiNguoiDung = dt.Rows(0)("MaLoaiNguoiDung")

            Return NguoiDungINFO
        Else
            Return Nothing

        End If
    End Function

    Public Shared Function isContainNguoiDung(tendangnhap As String, matkhau As String) As Boolean
        Dim dt As New DataTable
        Dim strCommand As String = "SELECT Matkhau FROM NGUOIDUNG WHERE TenDangNhap = '$1'"
        strCommand = strCommand.Replace("$1", tendangnhap)

        dt = DataProvider.ExecuteQuery(strCommand)

        'If (dt.Rows.Count < 0) Then
        '    Return False
        'Else
        '    If ((dt.Rows(0).Item(0) = matkhau)) Then
        '        Return True
        '    End If
        '    Return False
        'End If


        If (dt.Rows.Count = 0) Then
            Return False
            'ElseIf ((dt.Rows(0).Item(0) = matkhau)) Then
            '    Return True
            'Else
            '    Return True
        ElseIf (dt.Rows(0).Item(0) = matkhau) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
