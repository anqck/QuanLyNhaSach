Public Class BaoCaoTonDTO
    Private _strMaBaoCaoTon As String
    Private _dateThangBaoCao As Date

    Public Property StrMaBaoCaoTon As String
        Get
            Return _strMaBaoCaoTon
        End Get
        Set(value As String)
            _strMaBaoCaoTon = value
        End Set
    End Property

    Public Property DateThangBaoCao As Date
        Get
            Return _dateThangBaoCao
        End Get
        Set(value As Date)
            _dateThangBaoCao = value
        End Set
    End Property
End Class
