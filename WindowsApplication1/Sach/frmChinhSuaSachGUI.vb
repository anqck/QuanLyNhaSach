Imports BUSLayer
Imports DTO

Public Class frmChinhSuaSachGUI
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtTacGia.Enabled = False
        txtTenSach.Enabled = False
        txtTheLoai.Enabled = False
        txtDonGiaDuKien.Enabled = False

        btnLuu.Enabled = False
    End Sub

    Public Sub New(strMaSach As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtMaSach.Text = strMaSach
        Dim sachINFO As SachDTO = SachBUS.LaySachDTO(strMaSach)

        txtTacGia.Text = sachINFO.StrTacGia
        txtTenSach.Text = sachINFO.StrTenSach
        txtTheLoai.Text = sachINFO.StrTheLoai
        txtDonGiaDuKien.Text = sachINFO.IDonGiaDuKien.ToString("n0")


        btnChonSach.Visible = False

    End Sub

    Private Sub btnChonSach_Click(sender As Object, e As EventArgs) Handles btnChonSach.Click
        Dim frmChonSach As New frmChonSach()
        frmChonSach.isMultiSelect = False
        frmChonSach.ShowDialog()

        If (frmChonSach.selectedMaSach.Count <> 0) Then
            txtTacGia.Enabled = True
            txtTenSach.Enabled = True
            txtTheLoai.Enabled = True
            txtDonGiaDuKien.Enabled = True
            btnLuu.Enabled = True

            Dim sachINFO As SachDTO = SachBUS.LaySachDTO(frmChonSach.selectedMaSach(0))

            txtMaSach.Text = sachINFO.StrMaSach
            txtTacGia.Text = sachINFO.StrTacGia
            txtTenSach.Text = sachINFO.StrTenSach
            txtTheLoai.Text = sachINFO.StrTheLoai
            txtDonGiaDuKien.Text = sachINFO.IDonGiaDuKien


        End If



    End Sub

    'Khi Active form kiểm tra xem thông tin có thay đổi từ Form khác
    Private Sub frmChinhSuaSachGUI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


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


    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        'Thêm Sách Vào DB

        Dim sachDTO As New SachDTO()
        sachDTO.StrMaSach = txtMaSach.Text
        sachDTO.StrTenSach = txtTenSach.Text
        sachDTO.StrTacGia = txtTacGia.Text
        sachDTO.StrTheLoai = txtTheLoai.Text
        sachDTO.IDonGiaDuKien = Integer.Parse(txtDonGiaDuKien.Text.Replace(",", ""))


        SachBUS.CapNhatSach(sachDTO)
        MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)




    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmChinhSuaSachGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class