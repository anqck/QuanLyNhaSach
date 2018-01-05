Public Class ChiTietBaoCaoTonDTO
    Private _strMaChiTietBaoCaoTon As String
    Private _strMaBaoCaoTon As String
    Private _strMaSach As String
    Private _iTonDau As Integer
    Private _iTonPhatSinh As Integer
    Private _iTonCuoi As Integer

    Public Property StrMaChiTietBaoCaoTon As String
        Get
            Return _strMaChiTietBaoCaoTon
        End Get
        Set(value As String)
            _strMaChiTietBaoCaoTon = value
        End Set
    End Property

    Public Property StrMaBaoCaoTon As String
        Get
            Return _strMaBaoCaoTon
        End Get
        Set(value As String)
            _strMaBaoCaoTon = value
        End Set
    End Property

    Public Property StrMaSach As String
        Get
            Return _strMaSach
        End Get
        Set(value As String)
            _strMaSach = value
        End Set
    End Property

    Public Property ITonDau As Integer
        Get
            Return _iTonDau
        End Get
        Set(value As Integer)
            _iTonDau = value
        End Set
    End Property

    Public Property ITonPhatSinh As Integer
        Get
            Return _iTonPhatSinh
        End Get
        Set(value As Integer)
            _iTonPhatSinh = value
        End Set
    End Property

    Public Property ITonCuoi As Integer
        Get
            Return _iTonCuoi
        End Get
        Set(value As Integer)
            _iTonCuoi = value
        End Set
    End Property
End Class
