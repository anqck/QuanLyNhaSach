<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoiMatKhau))
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.grpThongTinSach = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txbXacnhanmatkhau = New System.Windows.Forms.TextBox()
        Me.txbMatkhaumoi = New System.Windows.Forms.TextBox()
        Me.txbMatkhaucu = New System.Windows.Forms.TextBox()
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThongTinSach.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(395, 312)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(119, 34)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnCapnhat.Location = New System.Drawing.Point(250, 312)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(119, 34)
        Me.btnCapnhat.TabIndex = 5
        Me.btnCapnhat.Text = "Cập nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'grpThongTinSach
        '
        Me.grpThongTinSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpThongTinSach.CaptionImageOptions.Image = CType(resources.GetObject("grpThongTinSach.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.grpThongTinSach.Controls.Add(Me.txbMatkhaucu)
        Me.grpThongTinSach.Controls.Add(Me.txbMatkhaumoi)
        Me.grpThongTinSach.Controls.Add(Me.txbXacnhanmatkhau)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl3)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl1)
        Me.grpThongTinSach.Controls.Add(Me.LabelControl2)
        Me.grpThongTinSach.Location = New System.Drawing.Point(56, 38)
        Me.grpThongTinSach.Margin = New System.Windows.Forms.Padding(4)
        Me.grpThongTinSach.Name = "grpThongTinSach"
        Me.grpThongTinSach.Size = New System.Drawing.Size(645, 238)
        Me.grpThongTinSach.TabIndex = 56
        Me.grpThongTinSach.Text = "Cập nhật mật khẩu"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(74, 64)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(154, 21)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Mật khẩu hiện tại:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(74, 120)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(122, 21)
        Me.LabelControl1.TabIndex = 55
        Me.LabelControl1.Text = "Mật khẩu mới:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(74, 172)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(207, 21)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Xác nhận mật khẩu mới:"
        '
        'txbXacnhanmatkhau
        '
        Me.txbXacnhanmatkhau.Location = New System.Drawing.Point(318, 172)
        Me.txbXacnhanmatkhau.Name = "txbXacnhanmatkhau"
        Me.txbXacnhanmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbXacnhanmatkhau.Size = New System.Drawing.Size(259, 23)
        Me.txbXacnhanmatkhau.TabIndex = 58
        '
        'txbMatkhaumoi
        '
        Me.txbMatkhaumoi.Location = New System.Drawing.Point(318, 120)
        Me.txbMatkhaumoi.Name = "txbMatkhaumoi"
        Me.txbMatkhaumoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbMatkhaumoi.Size = New System.Drawing.Size(259, 23)
        Me.txbMatkhaumoi.TabIndex = 59
        '
        'txbMatkhaucu
        '
        Me.txbMatkhaucu.Location = New System.Drawing.Point(318, 64)
        Me.txbMatkhaucu.Name = "txbMatkhaucu"
        Me.txbMatkhaucu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbMatkhaucu.Size = New System.Drawing.Size(259, 23)
        Me.txbMatkhaucu.TabIndex = 60
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 380)
        Me.Controls.Add(Me.grpThongTinSach)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Name = "frmDoiMatKhau"
        Me.Text = "Cập nhật mật khẩu mới"
        CType(Me.grpThongTinSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThongTinSach.ResumeLayout(False)
        Me.grpThongTinSach.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHuy As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents grpThongTinSach As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txbMatkhaucu As TextBox
    Friend WithEvents txbMatkhaumoi As TextBox
    Friend WithEvents txbXacnhanmatkhau As TextBox
End Class
