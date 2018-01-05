Public Class reportBaoCaoCongNO
    Public Sub BindData()
        Dim dt As DataTable
        dt = TryCast(Tag.dt, DataTable)

        Me.DataSource = dt


        detailSTT.DataBindings.Add("Text", dt, dt.Columns("clmSTT").Caption)

        detailDiaChi.DataBindings.Add("Text", dt, dt.Columns("clmDiaChi").Caption)
        detailHoTen.DataBindings.Add("Text", dt, dt.Columns("clmMaKhachHang").Caption)
        detailHoTen.DataBindings.Add("Text", dt, dt.Columns("clmTenKhachHang").Caption)
        detailDiaChi.DataBindings.Add("Text", dt, dt.Columns("clmDiaChi").Caption)
        detailNoDau.DataBindings.Add("Text", dt, dt.Columns("clmNoDau").Caption)
        detailNoPhatSinh.DataBindings.Add("Text", dt, dt.Columns("clmNoPhatSinh").Caption)
        detailNoCuoi.DataBindings.Add("Text", dt, dt.Columns("clmNoCuoi").Caption)



        lblThangBaoCao.Text = DateTime.Parse(Tag.dateThangBaoCao).ToString("MM.yyyy")


    End Sub
End Class