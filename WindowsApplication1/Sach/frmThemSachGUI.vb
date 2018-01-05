Imports BUSLayer
Imports DALLayer
Imports DTO

Public Class frmThemSachGUI

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        'Kiểm tra đã nhập đầy đủ thông tin chưa
        If (txtTenSach.Text = "") Then
            MessageBox.Show("Chưa nhập tên sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTenSach.ErrorText = "Chưa nhập tên sách!"
            Return
        End If

        If (txtTacGia.Text = "") Then
            MessageBox.Show("Chưa nhập tác giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTacGia.ErrorText = "Chưa nhập tác giả!"
            Return
        End If

        If (txtTheLoai.Text = "") Then
            MessageBox.Show("Chưa nhập thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTheLoai.ErrorText = "Chưa nhập thể loại!"
            Return
        End If

        If (txtDonGiaDuKien.Text = "") Then
            MessageBox.Show("Chưa nhập đơn giá dự kiến!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDonGiaDuKien.ErrorText = "Chưa nhập đơn giá dự kiến!"
            Return
        End If

        'Thêm Sách Vào DB

        Dim sachDTO As New SachDTO()
        sachDTO.StrMaSach = SachBUS.PhatSinhMaSach()
        sachDTO.StrTenSach = txtTenSach.Text
        sachDTO.StrTacGia = txtTacGia.Text
        sachDTO.StrTheLoai = txtTheLoai.Text
        sachDTO.IDonGiaDuKien = Integer.Parse(txtDonGiaDuKien.Text.Replace(".", ""))

        SachBUS.ThemSachVaoDB(sachDTO)
        MessageBox.Show("Thêm vào thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'Khởi tạo Form
        grpThongTinSach.Enabled = False
        btnLuu.Enabled = False
    End Sub

    Private Sub frmThemSachGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If (txtMaSach.Text <> "") Then
            txtMaSach.Text = SachBUS.PhatSinhMaSach()
        End If

        'Nạp tất cả thể loại
        Dim listTheLoai As New List(Of String)
        listTheLoai = TraCuuSachBUS.getTatCaTheLoaiSach()
        For Each strTheLoai In listTheLoai
            If (txtTheLoai.Properties.Items.Contains(strTheLoai) = False) Then
                txtTheLoai.Properties.Items.Add(strTheLoai)
            End If

        Next

        'Nạp tất cả các tác giả
        Dim listTacGia As New List(Of String)
        listTacGia = TraCuuSachBUS.getTatCaTacGiaSach()
        For Each strTacGia In listTacGia
            If (txtTacGia.Properties.Items.Contains(strTacGia) = False) Then
                txtTacGia.Properties.Items.Add(strTacGia)
            End If

        Next
    End Sub

    Private Sub txtTenSach_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTenSach.Validating
        If (txtTenSach.Text = "") Then
            txtTenSach.ErrorText = "Chưa nhập tên sách!"
            e.Cancel = True
        Else
            txtTenSach.ErrorText = ""
        End If
    End Sub

    Private Sub txtTacGia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTacGia.Validating
        If (txtTacGia.Text = "") Then
            txtTacGia.ErrorText = "Chưa nhập tác giả!"
            e.Cancel = True
        Else
            txtTacGia.ErrorText = ""
        End If
    End Sub

    Private Sub txtTheLoai_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTheLoai.Validating
        If (txtTheLoai.Text = "") Then
            txtTheLoai.ErrorText = "Chưa nhập thể loại!"
            e.Cancel = True
        Else
            txtTheLoai.ErrorText = ""
        End If
    End Sub

    Private Sub frmThemSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpThongTinSach.Enabled = False
        btnLuu.Enabled = False
    End Sub

    Private Sub btnTaoMoi_Click(sender As Object, e As EventArgs) Handles btnTaoMoi.Click
        grpThongTinSach.Enabled = True
        btnLuu.Enabled = True

        txtMaSach.Text = SachBUS.PhatSinhMaSach().ToString
        txtTacGia.Text = ""
        txtTenSach.Text = ""
        txtTheLoai.Text = ""


    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class