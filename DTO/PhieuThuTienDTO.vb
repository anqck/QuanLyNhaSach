Public Class PhieuThuTienDTO
    Private _strMaPhieuThu As String
    Private _strMaKhachHang As String
    Private _dateNgayThuTien As DateTime
    Private _iSoTienThu As Integer

    Public Property StrMaPhieuThu As String
        Get
            Return _strMaPhieuThu
        End Get
        Set(value As String)
            _strMaPhieuThu = value
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

    Public Property ISoTienThu As Integer
        Get
            Return _iSoTienThu
        End Get
        Set(value As Integer)
            _iSoTienThu = value
        End Set
    End Property

    Public Property DateNgayThuTien As Date
        Get
            Return _dateNgayThuTien
        End Get
        Set(value As Date)
            _dateNgayThuTien = value
        End Set
    End Property
End Class
