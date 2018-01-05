Public Class BaoCaoCongNoDTO
    Private _strMaBaoCaoCongNo As String
    Private _dateThangBaoCao As Date

    Public Property StrMaBaoCaoCongNo As String
        Get
            Return _strMaBaoCaoCongNo
        End Get
        Set(value As String)
            _strMaBaoCaoCongNo = value
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
