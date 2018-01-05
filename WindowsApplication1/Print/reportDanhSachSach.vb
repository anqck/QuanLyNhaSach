Public Class reportDanhSachSach



    Public Sub BindData()
        Dim dt As DataTable
        dt = TryCast(Tag, DataTable)

        DataSource = dt

        detailSTT.DataBindings.Add("Text", Nothing, dt.Columns("clmSTT").Caption)
        detailMaSach.DataBindings.Add("Text", Nothing, dt.Columns("clmMaSach").Caption)
        detailTenSach.DataBindings.Add("Text", Nothing, dt.Columns("clmTenSach").Caption)
        detailTacGia.DataBindings.Add("Text", Nothing, dt.Columns("clmTacGia").Caption)
        detailTheLoai.DataBindings.Add("Text", Nothing, dt.Columns("clmTheLoai").Caption)
        detailSoLuongTon.DataBindings.Add("Text", Nothing, dt.Columns("clmSoLuongTon").Caption)

        lblNgayXuat.Text = DateTime.Today.ToString("dd/MM/yyyy")


    End Sub
End Class