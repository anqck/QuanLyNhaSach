Imports DALLayer
Imports DTO

Public Class frmDangnhap
    Dim NguoiDungKetQua As NguoiDungDTO

    Public Property NguoiDungKetQua1 As NguoiDungDTO
        Get
            Return NguoiDungKetQua
        End Get
        Set(value As NguoiDungDTO)
            NguoiDungKetQua = value
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If (txbTendangnhap.Text Is "") Then

            MessageBox.Show("Hãy nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        End If

        If (txbMatkhau.Text Is "") Then

            MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If (DALLayer.NguoiDungDAL.isContainNguoiDung(txbTendangnhap.Text, txbMatkhau.Text)) Then

            NguoiDungKetQua = NguoiDungDAL.LayNguoiDungDTObyTendangnhap(txbTendangnhap.Text)


        Else
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        DialogResult = DialogResult.OK
        Close()


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class