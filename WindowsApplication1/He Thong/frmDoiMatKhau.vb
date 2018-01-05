Imports BUSLayer
Imports DTO
Public Class frmDoiMatKhau

    Dim _nguoidung As NguoiDungDTO
    Public Sub New(nguoidung As NguoiDungDTO)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._nguoidung = nguoidung

    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        If (txbMatkhaucu.Text <> Me._nguoidung.StrMatKhau) Then
            MessageBox.Show("Sai mật khẩu hiện tại")
            Return
        End If
        If (txbMatkhaucu.Text = "") Then
            MessageBox.Show("Chưa nhập mật khẩu hiện tại")
            Return
        End If
        If (txbMatkhaumoi.Text = "") Then
            MessageBox.Show("Chưa nhập mật khẩu mới")
            Return
        End If
        If (txbXacnhanmatkhau.Text = "") Then
            MessageBox.Show("Chưa xác nhận mật khẩu mới")
            Return
        End If
        If (txbXacnhanmatkhau.Text <> txbMatkhaumoi.Text) Then
            MessageBox.Show("Xác nhận mật khẩu mới chưa khớp")
            Return
        Else
            _nguoidung.StrMatKhau = txbMatkhaumoi.Text

            NguoiDungBUS.CapNhatNguoiDung(_nguoidung)

            MessageBox.Show("Cập nhật mật khẩu mới thành công")
            Me.Close()
        End If



    End Sub

    Private Sub frmDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpThongTinSach_Paint(sender As Object, e As PaintEventArgs) Handles grpThongTinSach.Paint

    End Sub
End Class