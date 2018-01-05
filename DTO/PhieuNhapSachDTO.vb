Public Class PhieuNhapSachDTO
    Private _iMaPhieuNhap As String
    Private _dateNgayNhap As Date



    Public Property DateNgayNhap As Date
        Get
            Return _dateNgayNhap
        End Get
        Set(value As Date)
            _dateNgayNhap = value
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
End Class
