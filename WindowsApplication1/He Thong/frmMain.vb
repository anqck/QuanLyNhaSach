Imports DALLayer
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraTabbedMdi
Imports DTO

Public Class frmMain

    Dim nguoidunghientai As NguoiDungDTO
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapPhieuNhapSach.ItemClick
        Dim form = New frmPhieuNhapSachGUI()

        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:\QuanLyNhaSach\Database.mdb;Persist Security Info=False"

        Dim frmWelcome As New frmWelcome
        frmWelcome.MdiParent = Me
        frmWelcome.Show()

        Dim frmLogin As New frmDangnhap
        If (frmLogin.ShowDialog() = DialogResult.OK) Then
            isDangNhap(True)

            nguoidunghientai = frmLogin.NguoiDungKetQua1
            Me.Text = nguoidunghientai.StrHoTenNguoiDung
            KhoiTaoQuyenNguoiDung(nguoidunghientai)
        Else
            Me.Close()
        End If


    End Sub


    Private Sub XtraTabbedMdiManager1_SelectedPageChanged(sender As Object, e As EventArgs) Handles XtraTabbedMdiManager1.SelectedPageChanged



        'For Each page In XtraTabbedMdiManager1.Pages
        '    If (RibbonControl.Pages.Contains(page.MdiChild.Tag)) Then
        '        Dim pagetemp As RibbonPage = TryCast(page.MdiChild.Tag, RibbonPage)
        '        RibbonControl.Pages.Remove(pagetemp)
        '    End If

        'Next

        'If (XtraTabbedMdiManager1.SelectedPage.MdiChild.Tag IsNot Nothing) Then
        '    Dim page1 As RibbonPage = TryCast(XtraTabbedMdiManager1.SelectedPage.MdiChild.Tag, RibbonPage)
        '    RibbonControl.Pages.Add(page1)
        '    RibbonControl.SelectedPage = page1
        'End If


    End Sub

    Private Sub btnThemKhachHang_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnThemKhachHang.ItemClick
        Dim form = New frmThemKhachHangGUI()

        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub Dangnhap(isQuanLy As Boolean)
        'Me.RibbonPageHeThong.Visible = isQuanLy
        'Me.RibbonPageBaoCao.Visible = isQuanLy
        Me.RibbonPageGroupThayDoiQuyDinh.Enabled = isQuanLy
        Me.btnPhanquyen.Enabled = isQuanLy
    End Sub

    Private Sub btnTraCuuSach_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnTraCuuSach.ItemClick
        Dim form = New frmTraCuuSachGUI
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnThemSach_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnThemSach.ItemClick
        Dim form = New frmThemSachGUI
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnLapHoaDonBanSach_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLapHoaDonBanSach.ItemClick
        Dim form = New frmHoaDonBanSachGUI
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnLapPhieuThuTien_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLapPhieuThuTien.ItemClick
        Dim form = New frmPhieuThuTienGUI
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnLapBaoCaoTon_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLapBaoCaoTon.ItemClick
        Dim form = New frmLapBaoCaoTonGUI
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnThayDoiQuyDinh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnThayDoiQuyDinh.ItemClick
        Dim form = New frmThayDoiQuyDinhGUI
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnChinhSuaSach_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnChinhSuaSach.ItemClick
        Dim form = New frmChinhSuaSachGUI()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnTraCuuKhachHang_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnTraCuuKhachHang.ItemClick
        Dim form = New frmTraCuuKhachHangGUI()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnLapBaoCaoCongNo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLapBaoCaoCongNo.ItemClick
        Dim form = New frmLapBaoCaoCongNoGUI()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        If (e.Page.MdiChild.Name = "frmWelcome") Then
            Dim frmWelcome As New frmWelcome
            frmWelcome.MdiParent = Me
            frmWelcome.Show()
        End If

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDangnhap.ItemClick
        Dim frmLogin As New frmDangnhap
        If (frmLogin.ShowDialog() = DialogResult.OK) Then
            isDangNhap(True)

            nguoidunghientai = frmLogin.NguoiDungKetQua1
            Me.Text = nguoidunghientai.StrHoTenNguoiDung
            KhoiTaoQuyenNguoiDung(nguoidunghientai)
        Else
            Me.Close()
        End If

        'MessageBox.Show("Hãy nhập tên đăng nhập!")
        'frmLogin.MdiParent = Me

    End Sub

    Private Sub btnDangxuat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDangxuat.ItemClick
        If (MessageBox.Show("Bạn có chắc muốn Đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = ShowDialog.Yes) Then
            btnDangnhap.Enabled = True

            XtraTabbedMdiManager1.Pages.Clear()

            Dim frmWelcome As New frmWelcome
            frmWelcome.MdiParent = Me
            frmWelcome.Show()
            Me.Text = "(Chưa đăng nhập)"

            Dim frmLogin As New frmDangnhap


            If (frmLogin.ShowDialog() = DialogResult.OK) Then
                isDangNhap(True)

                nguoidunghientai = frmLogin.NguoiDungKetQua1
                Me.Text = nguoidunghientai.StrHoTenNguoiDung
                KhoiTaoQuyenNguoiDung(nguoidunghientai)
            Else
                Me.Close()
            End If

        End If

    End Sub

    Private Sub KhoiTaoQuyenNguoiDung(nguoidunghientai As NguoiDungDTO)
        If (nguoidunghientai.StrMaLoaiNguoiDung = "0") Then
            Me.Dangnhap(True)
        Else
            Me.Dangnhap(False)
        End If
    End Sub

    Private Sub isDangNhap(bool As Boolean)

        btnDangnhap.Enabled = Not bool
        btnDangxuat.Enabled = bool
        btnDoimatkhau.Enabled = bool
        btnPhanquyen.Enabled = bool

    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub btnPhanquyen_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPhanquyen.ItemClick
        Dim formphanquyen = New frmPhanquyen()
        formphanquyen.MdiParent = Me
        formphanquyen.Show()
    End Sub

    Private Sub btnChinhSuaKhachHang_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnChinhSuaKhachHang.ItemClick
        Dim form = New frmChinhSuaKhachHangGUI()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnDoimatkhau_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDoimatkhau.ItemClick
        Dim formdoimatkhau = New frmDoiMatKhau(nguoidunghientai)

        formdoimatkhau.Show()
    End Sub
End Class