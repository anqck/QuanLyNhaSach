Public Class reportDanhSachKhachHang



    Public Sub BindData()
        Dim dt As DataTable
        dt = TryCast(Tag.dt, DataTable)

        DataSource = dt

        detailSTT.DataBindings.Add("Text", Nothing, dt.Columns("clmSTT").Caption)
        detailMaKhachHang.DataBindings.Add("Text", Nothing, dt.Columns("clmMaKhachHang").Caption)
        detailTenKhachHang.DataBindings.Add("Text", Nothing, dt.Columns("clmHoTenKhachHang").Caption)
        detailDiaChi.DataBindings.Add("Text", Nothing, dt.Columns("clmDiaChi").Caption)
        detailDienThoai.DataBindings.Add("Text", Nothing, dt.Columns("clmDienThoai").Caption)
        detailEmail.DataBindings.Add("Text", Nothing, dt.Columns("clmEmail").Caption)
        detailSoTienNo.DataBindings.Add("Text", Nothing, dt.Columns("clmSoTienNo").Caption)

        lblNgayXuat.Text = DateTime.Today.ToString("dd/MM/yyyy")


    End Sub

End Class
