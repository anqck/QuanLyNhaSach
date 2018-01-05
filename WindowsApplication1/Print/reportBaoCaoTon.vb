Public Class reportBaoCaoTon
    Public Sub BindData()
        Dim dt As DataTable
        dt = TryCast(Tag.dt, DataTable)

        Me.DataSource = dt


        detailSTT.DataBindings.Add("Text", dt, dt.Columns("clmSTT").Caption)
            detailMaSach.DataBindings.Add("Text", dt, dt.Columns("clmMaSach").Caption)
            detailTenSach.DataBindings.Add("Text", dt, dt.Columns("clmTenSach").Caption)
            detailTacGia.DataBindings.Add("Text", dt, dt.Columns("clmTacGia").Caption)
            detailTheLoai.DataBindings.Add("Text", dt, dt.Columns("clmTheLoai").Caption)
            detailTonDau.DataBindings.Add("Text", dt, dt.Columns("clmTonDau").Caption)
            detailPhatSinh.DataBindings.Add("Text", dt, dt.Columns("clmTonPhatSinh").Caption)
            detailTonCuoi.DataBindings.Add("Text", dt, dt.Columns("clmTonCuoi").Caption)



        lblThangBaoCao.Text = DateTime.Parse(Tag.dateThangBaoCao).ToString("MM.yyyy")


    End Sub
End Class