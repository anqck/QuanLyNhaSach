Public Class ChiTietPhieuNhapDTO
    Private _iMaChiTietPhieuNhap As String
    Private _iMaPhieuNhap As String
    Private _iMaSach As String
    Private _iSoLuongNhap As Integer
    Private _dateNgayNhap As Date

    Public Property IMaChiTietPhieuNhap As String
        Get
            Return _iMaChiTietPhieuNhap
        End Get
        Set(value As String)
            _iMaChiTietPhieuNhap = value
        End Set
    End Property

    Public Property IMaPhieuNhap As String
        Get
            Return _iMaPhieuNhap
        End Get
        Set(value As String)
            _iMaPhieuNhap = value
        End Set
    End Property

    Public Property IMaSach As String
        Get
            Return _iMaSach
        End Get
        Set(value As String)
            _iMaSach = value
        End Set
    End Property

    Public Property ISoLuongNhap As Integer
        Get
            Return _iSoLuongNhap
        End Get
        Set(value As Integer)
            _iSoLuongNhap = value
        End Set
    End Property

    Public Property DateNgayNhap As Date
        Get
            Return _dateNgayNhap
        End Get
        Set(value As Date)
            _dateNgayNhap = value
        End Set
    End Property
End Class
