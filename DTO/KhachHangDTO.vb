Public Class KhachHangDTO
    Private _strMaKhachHang As String
    Private _strHoTenKhachHang As String
    Private _strEmail As String
    Private _strDiaChi As String
    Private _strDienThoai As String
    Private _iSoTienNo As Integer

    Public Property StrMaKhachHang As String
        Get
            Return _strMaKhachHang
        End Get
        Set(value As String)
            _strMaKhachHang = value
        End Set
    End Property

    Public Property StrHoTenKhachHang As String
        Get
            Return _strHoTenKhachHang
        End Get
        Set(value As String)
            _strHoTenKhachHang = value
        End Set
    End Property

    Public Property StrEmail As String
        Get
            Return _strEmail
        End Get
        Set(value As String)
            _strEmail = value
        End Set
    End Property

    Public Property StrDiaChi As String
        Get
            Return _strDiaChi
        End Get
        Set(value As String)
            _strDiaChi = value
        End Set
    End Property


    Public Property ISoTienNo As Integer
        Get
            Return _iSoTienNo
        End Get
        Set(value As Integer)
            _iSoTienNo = value
        End Set
    End Property

    Public Property StrDienThoai As String
        Get
            Return _strDienThoai
        End Get
        Set(value As String)
            _strDienThoai = value
        End Set
    End Property
End Class
