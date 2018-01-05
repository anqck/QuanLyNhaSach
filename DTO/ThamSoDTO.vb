Public Class ThamSoDTO
    Private _iSoLuongNhapToiThieu As Integer
    Private _iSoLuongTonToiDa As Integer
    Private _iSoLuongTonToiThieu As Integer
    Private _iSoTienNoToiDa As Integer
    Private _iApDungQuyDinhTienThuKhongVuotTienNo As Boolean

    Public Property ISoLuongNhapToiThieu As Integer
        Get
            Return _iSoLuongNhapToiThieu
        End Get
        Set(value As Integer)
            _iSoLuongNhapToiThieu = value
        End Set
    End Property

    Public Property ISoLuongTonToiDa As Integer
        Get
            Return _iSoLuongTonToiDa
        End Get
        Set(value As Integer)
            _iSoLuongTonToiDa = value
        End Set
    End Property

    Public Property ISoLuongTonToiThieu As Integer
        Get
            Return _iSoLuongTonToiThieu
        End Get
        Set(value As Integer)
            _iSoLuongTonToiThieu = value
        End Set
    End Property

    Public Property ISoTienNoToiDa As Integer
        Get
            Return _iSoTienNoToiDa
        End Get
        Set(value As Integer)
            _iSoTienNoToiDa = value
        End Set
    End Property

    Public Property BoolApDungQuyDinhTienThuKhongVuotTienNo As Boolean
        Get
            Return _iApDungQuyDinhTienThuKhongVuotTienNo
        End Get
        Set(value As Boolean)
            _iApDungQuyDinhTienThuKhongVuotTienNo = value
        End Set
    End Property
End Class
