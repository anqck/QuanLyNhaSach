Public Class ChiTietHoaDonDTO
    Private _strMaChiTietHoaDon As String
    Private _strMaHoaDon As String
    Private _strMaSach As String
    Private _iDonGiaBan As Integer
    Private _iSoLuongBan As Integer
    Private _iThanhTien As Integer
    Private _dateNgayLapHoaDon As Date

    Public Property StrMaChiTietHoaDon As String
        Get
            Return _strMaChiTietHoaDon
        End Get
        Set(value As String)
            _strMaChiTietHoaDon = value
        End Set
    End Property

    Public Property StrMaHoaDon As String
        Get
            Return _strMaHoaDon
        End Get
        Set(value As String)
            _strMaHoaDon = value
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

    Public Property IDonGiaBan As Integer
        Get
            Return _iDonGiaBan
        End Get
        Set(value As Integer)
            _iDonGiaBan = value
        End Set
    End Property

    Public Property ISoLuongBan As Integer
        Get
            Return _iSoLuongBan
        End Get
        Set(value As Integer)
            _iSoLuongBan = value
        End Set
    End Property

    Public Property IThanhTien As Integer
        Get
            Return _iThanhTien
        End Get
        Set(value As Integer)
            _iThanhTien = value
        End Set
    End Property

    Public Property DateNgayLapHoaDon As Date
        Get
            Return _dateNgayLapHoaDon
        End Get
        Set(value As Date)
            _dateNgayLapHoaDon = value
        End Set
    End Property
End Class
