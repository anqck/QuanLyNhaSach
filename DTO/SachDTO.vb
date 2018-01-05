Public Class SachDTO
    Private _iMaSach As String
    Private _strTenSach As String
    Private _strTheLoai As String
    Private _strTacGia As String
    Private _iSoLuongTon As Integer
    Private _iTongSoLuongBan As Integer
    Private _iTongTienBan As Integer
    Private _iDonGiaDuKien As Integer

    Public Sub New()
        _iMaSach = 0
        _strTenSach = ""
        _strTheLoai = ""
        _strTacGia = ""
        _iSoLuongTon = 0
    End Sub
    Public Property StrMaSach As Integer
        Get
            Return _iMaSach
        End Get
        Set(value As Integer)
            _iMaSach = value
        End Set
    End Property

    Public Property StrTenSach As String
        Get
            Return _strTenSach
        End Get
        Set(value As String)
            _strTenSach = value
        End Set
    End Property

    Public Property StrTheLoai As String
        Get
            Return _strTheLoai
        End Get
        Set(value As String)
            _strTheLoai = value
        End Set
    End Property

    Public Property StrTacGia As String
        Get
            Return _strTacGia
        End Get
        Set(value As String)
            _strTacGia = value
        End Set
    End Property

    Public Property ISoLuongTon As Integer
        Get
            Return _iSoLuongTon
        End Get
        Set(value As Integer)
            _iSoLuongTon = value
        End Set
    End Property

    Public Property ITongSoLuongBan As Integer
        Get
            Return _iTongSoLuongBan
        End Get
        Set(value As Integer)
            _iTongSoLuongBan = value
        End Set
    End Property

    Public Property ITongTienBan As Integer
        Get
            Return _iTongTienBan
        End Get
        Set(value As Integer)
            _iTongTienBan = value
        End Set
    End Property

    Public Property IDonGiaDuKien As Integer
        Get
            Return _iDonGiaDuKien
        End Get
        Set(value As Integer)
            _iDonGiaDuKien = value
        End Set
    End Property
End Class
