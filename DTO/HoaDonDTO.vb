Public Class HoaDonDTO
    Private _strMaHoaDon As String
    Private _strMaKhachHang As String
    Private _dateNgayLapHoaDon As Date
    Private _iTongThanhTien As Integer

    Public Property StrMaHoaDon As String
        Get
            Return _strMaHoaDon
        End Get
        Set(value As String)
            _strMaHoaDon = value
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

    Public Property DateNgayLapHoaDon As Date
        Get
            Return _dateNgayLapHoaDon
        End Get
        Set(value As Date)
            _dateNgayLapHoaDon = value
        End Set
    End Property

    Public Property ITongThanhTien As Integer
        Get
            Return _iTongThanhTien
        End Get
        Set(value As Integer)
            _iTongThanhTien = value
        End Set
    End Property
End Class
