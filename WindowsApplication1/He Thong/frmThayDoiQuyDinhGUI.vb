Imports BUSLayer
Imports DTO

Public Class frmThayDoiQuyDinhGUI
    Private Sub frmThayDoiQuyDinhGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSoLuongNhapToiThieu.Text = ThamSoBUS.getSoLuongNhapToiThieu().ToString
        txtSoLuongTonToiDa.Text = ThamSoBUS.getSoLuongTonToiDa.ToString()
        txtSoLuongTonToiThieu.Text = ThamSoBUS.getSoLuongTonToiThieu().ToString
        txtSoTienNoToiDa.Text = ThamSoBUS.getSoTienNoToiDa()

        chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked = ThamSoBUS.getApDungQuyDinhTienThuKhongVuotTienNo()

    End Sub

    Private Sub btnSoLuongNhapToiThieuHienTai_Click(sender As Object, e As EventArgs) Handles btnSoLuongNhapToiThieuHienTai.Click
        txtSoLuongNhapToiThieu.Text = ThamSoBUS.getSoLuongNhapToiThieu().ToString
    End Sub

    Private Sub btnSoLuongTonToiDaHienTai_Click(sender As Object, e As EventArgs) Handles btnSoLuongTonToiDaHienTai.Click
        txtSoLuongTonToiDa.Text = ThamSoBUS.getSoLuongTonToiDa.ToString()
    End Sub

    Private Sub btnSoLuongNhapToiThieuMacDinh_Click(sender As Object, e As EventArgs) Handles btnSoLuongNhapToiThieuMacDinh.Click
        txtSoLuongNhapToiThieu.Text = "150"
    End Sub

    Private Sub btnSoLuongTonToiDaMacDinh_Click(sender As Object, e As EventArgs) Handles btnSoLuongTonToiDaMacDinh.Click
        txtSoLuongTonToiDa.Text = "300"
    End Sub

    Private Sub btnSoLuongTonToiThieuHienTai_Click(sender As Object, e As EventArgs) Handles btnSoLuongTonToiThieuHienTai.Click
        txtSoLuongTonToiThieu.Text = ThamSoBUS.getSoLuongTonToiThieu().ToString
    End Sub

    Private Sub btnSoLuongTonToiThieuMacDinh_Click(sender As Object, e As EventArgs) Handles btnSoLuongTonToiThieuMacDinh.Click
        txtSoLuongTonToiThieu.Text = "20"
    End Sub
    Private Sub btnSoTienNoToiDaHienTai_Click(sender As Object, e As EventArgs) Handles btnSoTienNoToiDaHienTai.Click
        txtSoTienNoToiDa.Text = ThamSoBUS.getSoTienNoToiDa()
    End Sub

    Private Sub btnSoTienNoToiDaMacDinh_Click(sender As Object, e As EventArgs) Handles btnSoTienNoToiDaMacDinh.Click
        txtSoTienNoToiDa.Text = "20000"
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        'Kiểm tra số lượng
        If (Integer.Parse(txtSoLuongNhapToiThieu.Text) < 0) Then
            txtSoLuongNhapToiThieu.ErrorText = "Số lượng nhập tối thiểu phải >= 0"
            MessageBox.Show("Số lượng nhập tối thiểu phải >= 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If

        'Lưu tham số xuống DB
        Dim ThamSoINFO As New ThamSoDTO

        ThamSoINFO.ISoLuongNhapToiThieu = Integer.Parse(txtSoLuongNhapToiThieu.Text)
        ThamSoINFO.ISoLuongTonToiDa = Integer.Parse(txtSoLuongTonToiDa.Text)
        ThamSoINFO.ISoLuongTonToiThieu = Integer.Parse(txtSoLuongTonToiThieu.Text)
        ThamSoINFO.ISoTienNoToiDa = Integer.Parse(txtSoTienNoToiDa.Text)
        ThamSoINFO.BoolApDungQuyDinhTienThuKhongVuotTienNo = chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked

        ThamSoBUS.luuThamSo(ThamSoINFO)
        MessageBox.Show("Thay đổi quy định thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub txtSoLuongNhapToiThieu_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSoLuongNhapToiThieu.Validating
        If (Integer.Parse(txtSoLuongNhapToiThieu.EditValue) < 0) Then
            txtSoLuongNhapToiThieu.ErrorText = "Số lượng nhập tối thiểu phải >= 0"
            e.Cancel = True
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txtSoLuongNhapToiThieu.Text = "150"
        txtSoLuongTonToiDa.Text = "300"
        txtSoLuongTonToiThieu.Text = "20"
        txtSoTienNoToiDa.Text = "20000"
        chkApDungQuyDinhSoTienThuKhongVuotTienNo.Checked = True
    End Sub
End Class