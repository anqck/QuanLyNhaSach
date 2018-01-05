Public Class frmPreview

    Public PrintType As New PrintType
    Public PrintINFO As PrintINFO


    Public Sub New(INFO As PrintINFO)

        InitializeComponent()

        PrintINFO = INFO




    End Sub

    Private Sub frmTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim report As Object

        If (PrintINFO.GetType Is GetType(DanhSachSachINFO)) Then
            report = New reportDanhSachSach

            Dim tempINFO As DanhSachSachINFO = TryCast(PrintINFO, DanhSachSachINFO)


            report.Tag = tempINFO.dt

        ElseIf (PrintINFO.GetType Is GetType(DanhSachKhachHangINFO)) Then
            report = New reportDanhSachKhachHang

            Dim tempINFO As DanhSachKhachHangINFO = TryCast(PrintINFO, DanhSachKhachHangINFO)


            report.Tag = tempINFO

        ElseIf (PrintINFO.GetType Is GetType(PhieuThuTienINFO)) Then
            report = New reportPhieuThuTien

            Dim tempINFO As PhieuThuTienINFO = TryCast(PrintINFO, PhieuThuTienINFO)


            report.Tag = tempINFO
        ElseIf (PrintINFO.GetType Is GetType(BaoCaoTonINFO)) Then
            report = New reportBaoCaoTon

            Dim tempINFO As BaoCaoTonINFO = TryCast(PrintINFO, BaoCaoTonINFO)

            report.Tag = tempINFO
        ElseIf (PrintINFO.GetType Is GetType(HoaDonBanSachINFO)) Then
            report = New reportHoaDonBanSach

            Dim tempINFO As HoaDonBanSachINFO = TryCast(PrintINFO, HoaDonBanSachINFO)

            report.Tag = tempINFO
        End If



        report.BindData()
        DocumentViewer1.PrintingSystem = report.PrintingSystem
        report.CreateDocument()


    End Sub


End Class
Public Enum PrintType
    DanhSachSach
    PhieuThuTien
End Enum

Public Class PrintINFO

End Class
Public Class PhieuThuTienINFO
    Inherits PrintINFO

    Public strMaPhieuThu As String
    Public dateNgayThu As Date
    Public strMaKhachHang As String
    Public iSoTienNo As Integer
    Public iSoTienThu As Integer

    Public Sub New(strMaPhieuThu As String, dateNgayThu As Date, strMaKhachHang As String, iSoTienNo As Integer, iSoTienThu As Integer)
        Me.strMaPhieuThu = strMaPhieuThu
        Me.dateNgayThu = dateNgayThu
        Me.strMaKhachHang = strMaKhachHang
        Me.iSoTienNo = iSoTienNo
        Me.iSoTienThu = iSoTienThu
    End Sub
End Class

Public Class DanhSachSachINFO
    Inherits PrintINFO

    Public dt As DataTable

    Public Sub New(dt As DataTable)
        Me.dt = dt
    End Sub
End Class

Public Class DanhSachKhachHangINFO
    Inherits PrintINFO

    Public dt As DataTable

    Public Sub New(dt As DataTable)
        Me.dt = dt
    End Sub
End Class

Public Class BaoCaoTonINFO
    Inherits PrintINFO

    Public dt As DataTable
    Public dateThangBaoCao As DateTime

    Public Sub New(dt As DataTable, dateThangNam As DateTime)
        Me.dt = dt
        Me.dateThangBaoCao = dateThangNam
    End Sub

End Class

Public Class HoaDonBanSachINFO
    Inherits PrintINFO

    Public dt As DataTable
    Public HoaDonINFO As DTO.HoaDonDTO
    Public iTienNoTruocKhiLapHoaDon As Integer


    Public Sub New(dt As DataTable, HoaDonINFO As DTO.HoaDonDTO, iTienNoTruocKhiLapHoaDon As Integer)
        Me.dt = dt
        Me.HoaDonINFO = HoaDonINFO
        Me.iTienNoTruocKhiLapHoaDon = iTienNoTruocKhiLapHoaDon
    End Sub

End Class