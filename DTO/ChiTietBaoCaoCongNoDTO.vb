Public Class ChiTietBaoCaoCongNoDTO
    Private _strMaChiTietBaoCaoCongNo As String
    Private _strMaBaoCaoCongNo As String
    Private _strMaKhachHang As String
    Private _iNoDau As Integer
    Private _iNoPhatSinh As Integer
    Private _iNoCuoi As Integer

    Public Property StrMaChiTietBaoCaoCongNo As String
        Get
            Return _strMaChiTietBaoCaoCongNo
        End Get
        Set(value As String)
            _strMaChiTietBaoCaoCongNo = value
        End Set
    End Property

    Public Property StrMaBaoCaoCongNo As String
        Get
            Return _strMaBaoCaoCongNo
        End Get
        Set(value As String)
            _strMaBaoCaoCongNo = value
        End Set
    End Property

    Public Property StrMaKhachHang As String
        Get
            Return _strMaKhachHang
        End Get
        Set(value As String)
            _strMaKhachHang = value
        End Set
    End Property

    Public Property INoDau As Integer
        Get
            Return _iNoDau
        End Get
        Set(value As Integer)
            _iNoDau = value
        End Set
    End Property

    Public Property INoPhatSinh As Integer
        Get
            Return _iNoPhatSinh
        End Get
        Set(value As Integer)
            _iNoPhatSinh = value
        End Set
    End Property

    Public Property INoCuoi As Integer
        Get
            Return _iNoCuoi
        End Get
        Set(value As Integer)
            _iNoCuoi = value
        End Set
    End Property
End Class
