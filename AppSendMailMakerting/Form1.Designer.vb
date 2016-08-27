<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnInfomation = New System.Windows.Forms.Button()
        Me.btnThemNguoiNhan = New System.Windows.Forms.Button()
        Me.btnXoaTrong = New System.Windows.Forms.Button()
        Me.btnGuiMail = New System.Windows.Forms.Button()
        Me.txtPassMailNguon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMailNguon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTieuDe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbWaitLoadData = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbtnXoaDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.tbtnDeleteItemDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlblHienTrang = New System.Windows.Forms.ToolStripLabel()
        Me.tbtnLoadDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnLuuDanhSach = New System.Windows.Forms.ToolStripButton()
        Me.dgvLstNguoiNhan = New System.Windows.Forms.DataGridView()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbWaitSendMail = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tbtnNewEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnDan = New System.Windows.Forms.ToolStripButton()
        Me.tbtnCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbtnCut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tcbFontFamily = New System.Windows.Forms.ToolStripComboBox()
        Me.tcbFontWidth = New System.Windows.Forms.ToolStripComboBox()
        Me.tbtnInDam = New System.Windows.Forms.ToolStripButton()
        Me.tbtnInNghien = New System.Windows.Forms.ToolStripButton()
        Me.tbtnGachChan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnCanhTrai = New System.Windows.Forms.ToolStripButton()
        Me.tbtnCanhGiua = New System.Windows.Forms.ToolStripButton()
        Me.tbtnCanhPhai = New System.Windows.Forms.ToolStripButton()
        Me.tbtnCanhDieu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnChenLink = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnDanhSo = New System.Windows.Forms.ToolStripButton()
        Me.tbtnList = New System.Windows.Forms.ToolStripButton()
        Me.tbtnSizeLon = New System.Windows.Forms.ToolStripButton()
        Me.tbtnSizeNho = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbtnMauChu = New System.Windows.Forms.ToolStripButton()
        Me.tbtnMauNen = New System.Windows.Forms.ToolStripButton()
        Me.tbtnFormat = New System.Windows.Forms.ToolStripButton()
        Me.contentMail = New System.Windows.Forms.WebBrowser()
        Me.pbTienTrinh = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rtbTienTrinh = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvLstNguoiNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSetting)
        Me.GroupBox1.Controls.Add(Me.btnInfomation)
        Me.GroupBox1.Controls.Add(Me.btnThemNguoiNhan)
        Me.GroupBox1.Controls.Add(Me.btnXoaTrong)
        Me.GroupBox1.Controls.Add(Me.btnGuiMail)
        Me.GroupBox1.Controls.Add(Me.txtPassMailNguon)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMailNguon)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTieuDe)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin email marketing"
        '
        'btnSetting
        '
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(464, 48)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(92, 23)
        Me.btnSetting.TabIndex = 8
        Me.btnSetting.Text = "Cấu hình"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'btnInfomation
        '
        Me.btnInfomation.Image = CType(resources.GetObject("btnInfomation.Image"), System.Drawing.Image)
        Me.btnInfomation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInfomation.Location = New System.Drawing.Point(562, 48)
        Me.btnInfomation.Name = "btnInfomation"
        Me.btnInfomation.Size = New System.Drawing.Size(92, 23)
        Me.btnInfomation.TabIndex = 9
        Me.btnInfomation.Text = "Thông tin"
        Me.btnInfomation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfomation.UseVisualStyleBackColor = True
        '
        'btnThemNguoiNhan
        '
        Me.btnThemNguoiNhan.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnThemNguoiNhan.Location = New System.Drawing.Point(562, 77)
        Me.btnThemNguoiNhan.Name = "btnThemNguoiNhan"
        Me.btnThemNguoiNhan.Size = New System.Drawing.Size(92, 42)
        Me.btnThemNguoiNhan.TabIndex = 5
        Me.btnThemNguoiNhan.Text = "Import người nhận"
        Me.ToolTip1.SetToolTip(Me.btnThemNguoiNhan, "Import dánh sách người nhận từ máy tính cá nhân")
        Me.btnThemNguoiNhan.UseVisualStyleBackColor = True
        '
        'btnXoaTrong
        '
        Me.btnXoaTrong.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnXoaTrong.Image = CType(resources.GetObject("btnXoaTrong.Image"), System.Drawing.Image)
        Me.btnXoaTrong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnXoaTrong.Location = New System.Drawing.Point(464, 78)
        Me.btnXoaTrong.Name = "btnXoaTrong"
        Me.btnXoaTrong.Size = New System.Drawing.Size(92, 42)
        Me.btnXoaTrong.TabIndex = 6
        Me.btnXoaTrong.Text = "Xóa trống"
        Me.btnXoaTrong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnXoaTrong, "Xóa trống cái trường dữ liệu")
        Me.btnXoaTrong.UseVisualStyleBackColor = True
        '
        'btnGuiMail
        '
        Me.btnGuiMail.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuiMail.Image = CType(resources.GetObject("btnGuiMail.Image"), System.Drawing.Image)
        Me.btnGuiMail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuiMail.Location = New System.Drawing.Point(366, 77)
        Me.btnGuiMail.Name = "btnGuiMail"
        Me.btnGuiMail.Size = New System.Drawing.Size(92, 42)
        Me.btnGuiMail.TabIndex = 7
        Me.btnGuiMail.Text = "Gửi mail"
        Me.btnGuiMail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnGuiMail, "Click để tiến hành gửi mail")
        Me.btnGuiMail.UseVisualStyleBackColor = True
        '
        'txtPassMailNguon
        '
        Me.txtPassMailNguon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPassMailNguon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtPassMailNguon.Location = New System.Drawing.Point(90, 100)
        Me.txtPassMailNguon.Name = "txtPassMailNguon"
        Me.txtPassMailNguon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassMailNguon.Size = New System.Drawing.Size(248, 20)
        Me.txtPassMailNguon.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtPassMailNguon, "Mật khẩu Email nguồn")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mật khẩu :"
        '
        'txtMailNguon
        '
        Me.txtMailNguon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMailNguon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtMailNguon.Location = New System.Drawing.Point(90, 74)
        Me.txtMailNguon.Name = "txtMailNguon"
        Me.txtMailNguon.Size = New System.Drawing.Size(248, 20)
        Me.txtMailNguon.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtMailNguon, "Email nguồn, nơi email bắt đầu phát tán")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email nguồn :"
        '
        'txtHost
        '
        Me.txtHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtHost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtHost.Location = New System.Drawing.Point(90, 48)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(368, 20)
        Me.txtHost.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtHost, "Địa chỉ HOST gửi mail")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gửi từ địa chỉ"
        '
        'txtTieuDe
        '
        Me.txtTieuDe.Location = New System.Drawing.Point(90, 22)
        Me.txtTieuDe.Name = "txtTieuDe"
        Me.txtTieuDe.Size = New System.Drawing.Size(564, 20)
        Me.txtTieuDe.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtTieuDe, "Tiêu đề Email : Cần nhập tiêu đề mang tính gợi nhớ, thu hút người đọc")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tiêu đề Email"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.lbWaitLoadData)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Controls.Add(Me.dgvLstNguoiNhan)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 438)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách nhận mail"
        '
        'lbWaitLoadData
        '
        Me.lbWaitLoadData.BackColor = System.Drawing.Color.Transparent
        Me.lbWaitLoadData.Image = CType(resources.GetObject("lbWaitLoadData.Image"), System.Drawing.Image)
        Me.lbWaitLoadData.Location = New System.Drawing.Point(76, 206)
        Me.lbWaitLoadData.Name = "lbWaitLoadData"
        Me.lbWaitLoadData.Size = New System.Drawing.Size(70, 65)
        Me.lbWaitLoadData.TabIndex = 2
        Me.lbWaitLoadData.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnXoaDanhSach, Me.tbtnDeleteItemDanhSach, Me.ToolStripSeparator1, Me.tlblHienTrang, Me.tbtnLoadDanhSach, Me.ToolStripSeparator6, Me.tbtnLuuDanhSach})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(230, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbtnXoaDanhSach
        '
        Me.tbtnXoaDanhSach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnXoaDanhSach.Image = CType(resources.GetObject("tbtnXoaDanhSach.Image"), System.Drawing.Image)
        Me.tbtnXoaDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnXoaDanhSach.Name = "tbtnXoaDanhSach"
        Me.tbtnXoaDanhSach.Size = New System.Drawing.Size(23, 22)
        Me.tbtnXoaDanhSach.Text = "Xóa toàn bộ danh sách khách hàng"
        Me.tbtnXoaDanhSach.ToolTipText = "Xóa toàn bộ danh sách khách hàng"
        '
        'tbtnDeleteItemDanhSach
        '
        Me.tbtnDeleteItemDanhSach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnDeleteItemDanhSach.Image = CType(resources.GetObject("tbtnDeleteItemDanhSach.Image"), System.Drawing.Image)
        Me.tbtnDeleteItemDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnDeleteItemDanhSach.Name = "tbtnDeleteItemDanhSach"
        Me.tbtnDeleteItemDanhSach.Size = New System.Drawing.Size(23, 22)
        Me.tbtnDeleteItemDanhSach.Text = "Xóa khách hàng khỏi danh sách"
        Me.tbtnDeleteItemDanhSach.ToolTipText = "Xóa khách hàng khỏi danh sách"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlblHienTrang
        '
        Me.tlblHienTrang.Name = "tlblHienTrang"
        Me.tlblHienTrang.Size = New System.Drawing.Size(75, 22)
        Me.tlblHienTrang.Text = "Hiện có 1000"
        Me.tlblHienTrang.ToolTipText = "Số khách hàng hiện tại"
        '
        'tbtnLoadDanhSach
        '
        Me.tbtnLoadDanhSach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnLoadDanhSach.Image = CType(resources.GetObject("tbtnLoadDanhSach.Image"), System.Drawing.Image)
        Me.tbtnLoadDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnLoadDanhSach.Name = "tbtnLoadDanhSach"
        Me.tbtnLoadDanhSach.Size = New System.Drawing.Size(23, 22)
        Me.tbtnLoadDanhSach.Text = "Import danh sách khách hàng nhận mail"
        Me.tbtnLoadDanhSach.ToolTipText = "Import danh sách khách hàng nhận mail"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tbtnLuuDanhSach
        '
        Me.tbtnLuuDanhSach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnLuuDanhSach.Image = CType(resources.GetObject("tbtnLuuDanhSach.Image"), System.Drawing.Image)
        Me.tbtnLuuDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnLuuDanhSach.Name = "tbtnLuuDanhSach"
        Me.tbtnLuuDanhSach.Size = New System.Drawing.Size(23, 22)
        Me.tbtnLuuDanhSach.Text = "Lưu danh sách khách hàng"
        Me.tbtnLuuDanhSach.ToolTipText = "Lưu danh sách khách hàng"
        '
        'dgvLstNguoiNhan
        '
        Me.dgvLstNguoiNhan.AllowUserToResizeRows = False
        Me.dgvLstNguoiNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLstNguoiNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLstNguoiNhan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Email, Me.KhachHang})
        Me.dgvLstNguoiNhan.Location = New System.Drawing.Point(3, 44)
        Me.dgvLstNguoiNhan.MultiSelect = False
        Me.dgvLstNguoiNhan.Name = "dgvLstNguoiNhan"
        Me.dgvLstNguoiNhan.RowHeadersVisible = False
        Me.dgvLstNguoiNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLstNguoiNhan.Size = New System.Drawing.Size(227, 375)
        Me.dgvLstNguoiNhan.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dgvLstNguoiNhan, "Danh sách nhận mail")
        '
        'Email
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Email.DefaultCellStyle = DataGridViewCellStyle1
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'KhachHang
        '
        Me.KhachHang.HeaderText = "Khách Hàng"
        Me.KhachHang.Name = "KhachHang"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.lbWaitSendMail)
        Me.GroupBox3.Controls.Add(Me.ToolStrip2)
        Me.GroupBox3.Controls.Add(Me.contentMail)
        Me.GroupBox3.Location = New System.Drawing.Point(251, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(806, 437)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nội dung gửi mail"
        '
        'lbWaitSendMail
        '
        Me.lbWaitSendMail.BackColor = System.Drawing.Color.Transparent
        Me.lbWaitSendMail.Image = CType(resources.GetObject("lbWaitSendMail.Image"), System.Drawing.Image)
        Me.lbWaitSendMail.Location = New System.Drawing.Point(360, 206)
        Me.lbWaitSendMail.Name = "lbWaitSendMail"
        Me.lbWaitSendMail.Size = New System.Drawing.Size(100, 93)
        Me.lbWaitSendMail.TabIndex = 2
        Me.lbWaitSendMail.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnNewEmail, Me.ToolStripSeparator8, Me.tbtnDan, Me.tbtnCopy, Me.tbtnCut, Me.ToolStripSeparator2, Me.tcbFontFamily, Me.tcbFontWidth, Me.tbtnInDam, Me.tbtnInNghien, Me.tbtnGachChan, Me.ToolStripSeparator3, Me.tbtnCanhTrai, Me.tbtnCanhGiua, Me.tbtnCanhPhai, Me.tbtnCanhDieu, Me.ToolStripSeparator4, Me.tbtnChenLink, Me.ToolStripSeparator5, Me.tbtnDanhSo, Me.tbtnList, Me.tbtnSizeLon, Me.tbtnSizeNho, Me.ToolStripSeparator7, Me.tbtnMauChu, Me.tbtnMauNen, Me.tbtnFormat})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tbtnNewEmail
        '
        Me.tbtnNewEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnNewEmail.Image = CType(resources.GetObject("tbtnNewEmail.Image"), System.Drawing.Image)
        Me.tbtnNewEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnNewEmail.Name = "tbtnNewEmail"
        Me.tbtnNewEmail.Size = New System.Drawing.Size(23, 22)
        Me.tbtnNewEmail.Text = "Tạo mới mail"
        Me.tbtnNewEmail.ToolTipText = "Tạo mới mail"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tbtnDan
        '
        Me.tbtnDan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnDan.Image = CType(resources.GetObject("tbtnDan.Image"), System.Drawing.Image)
        Me.tbtnDan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnDan.Name = "tbtnDan"
        Me.tbtnDan.Size = New System.Drawing.Size(23, 22)
        Me.tbtnDan.Text = "Dán"
        Me.tbtnDan.ToolTipText = "Dán"
        '
        'tbtnCopy
        '
        Me.tbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnCopy.Image = CType(resources.GetObject("tbtnCopy.Image"), System.Drawing.Image)
        Me.tbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnCopy.Name = "tbtnCopy"
        Me.tbtnCopy.Size = New System.Drawing.Size(23, 22)
        Me.tbtnCopy.Text = "Copy"
        Me.tbtnCopy.ToolTipText = "Copy"
        '
        'tbtnCut
        '
        Me.tbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnCut.Image = CType(resources.GetObject("tbtnCut.Image"), System.Drawing.Image)
        Me.tbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnCut.Name = "tbtnCut"
        Me.tbtnCut.Size = New System.Drawing.Size(23, 22)
        Me.tbtnCut.Text = "Cut"
        Me.tbtnCut.ToolTipText = "Cut"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tcbFontFamily
        '
        Me.tcbFontFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tcbFontFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tcbFontFamily.AutoToolTip = True
        Me.tcbFontFamily.Name = "tcbFontFamily"
        Me.tcbFontFamily.Size = New System.Drawing.Size(121, 25)
        Me.tcbFontFamily.Text = "Times New Roman"
        Me.tcbFontFamily.ToolTipText = "Chọn Font Chữ"
        '
        'tcbFontWidth
        '
        Me.tcbFontWidth.Items.AddRange(New Object() {"5", "7", "8", "9", "10", "11", "12", "13", "15", "18", "20", "22", "24", "30", "38", "42", "48"})
        Me.tcbFontWidth.Name = "tcbFontWidth"
        Me.tcbFontWidth.Size = New System.Drawing.Size(75, 25)
        Me.tcbFontWidth.Text = "11"
        Me.tcbFontWidth.ToolTipText = "Chọn cỡ chữ"
        '
        'tbtnInDam
        '
        Me.tbtnInDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnInDam.Image = CType(resources.GetObject("tbtnInDam.Image"), System.Drawing.Image)
        Me.tbtnInDam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnInDam.Name = "tbtnInDam"
        Me.tbtnInDam.Size = New System.Drawing.Size(23, 22)
        Me.tbtnInDam.Text = "Im đậm"
        Me.tbtnInDam.ToolTipText = "Im đậm"
        '
        'tbtnInNghien
        '
        Me.tbtnInNghien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnInNghien.Image = CType(resources.GetObject("tbtnInNghien.Image"), System.Drawing.Image)
        Me.tbtnInNghien.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnInNghien.Name = "tbtnInNghien"
        Me.tbtnInNghien.Size = New System.Drawing.Size(23, 22)
        Me.tbtnInNghien.Text = "In nghiên"
        Me.tbtnInNghien.ToolTipText = "In nghiên"
        '
        'tbtnGachChan
        '
        Me.tbtnGachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnGachChan.Image = CType(resources.GetObject("tbtnGachChan.Image"), System.Drawing.Image)
        Me.tbtnGachChan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnGachChan.Name = "tbtnGachChan"
        Me.tbtnGachChan.Size = New System.Drawing.Size(23, 22)
        Me.tbtnGachChan.Text = "Gạch chân"
        Me.tbtnGachChan.ToolTipText = "Gạch chân"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbtnCanhTrai
        '
        Me.tbtnCanhTrai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnCanhTrai.Image = CType(resources.GetObject("tbtnCanhTrai.Image"), System.Drawing.Image)
        Me.tbtnCanhTrai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnCanhTrai.Name = "tbtnCanhTrai"
        Me.tbtnCanhTrai.Size = New System.Drawing.Size(23, 22)
        Me.tbtnCanhTrai.Text = "Canh trái"
        Me.tbtnCanhTrai.ToolTipText = "Canh trái"
        '
        'tbtnCanhGiua
        '
        Me.tbtnCanhGiua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnCanhGiua.Image = CType(resources.GetObject("tbtnCanhGiua.Image"), System.Drawing.Image)
        Me.tbtnCanhGiua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnCanhGiua.Name = "tbtnCanhGiua"
        Me.tbtnCanhGiua.Size = New System.Drawing.Size(23, 22)
        Me.tbtnCanhGiua.Text = "Canh giữa"
        Me.tbtnCanhGiua.ToolTipText = "Canh giữa"
        '
        'tbtnCanhPhai
        '
        Me.tbtnCanhPhai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnCanhPhai.Image = CType(resources.GetObject("tbtnCanhPhai.Image"), System.Drawing.Image)
        Me.tbtnCanhPhai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnCanhPhai.Name = "tbtnCanhPhai"
        Me.tbtnCanhPhai.Size = New System.Drawing.Size(23, 22)
        Me.tbtnCanhPhai.Text = "Canh phải"
        Me.tbtnCanhPhai.ToolTipText = "Canh phải"
        '
        'tbtnCanhDieu
        '
        Me.tbtnCanhDieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnCanhDieu.Image = CType(resources.GetObject("tbtnCanhDieu.Image"), System.Drawing.Image)
        Me.tbtnCanhDieu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnCanhDieu.Name = "tbtnCanhDieu"
        Me.tbtnCanhDieu.Size = New System.Drawing.Size(23, 22)
        Me.tbtnCanhDieu.Text = "Canh điều"
        Me.tbtnCanhDieu.ToolTipText = "Canh điều"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbtnChenLink
        '
        Me.tbtnChenLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnChenLink.Image = CType(resources.GetObject("tbtnChenLink.Image"), System.Drawing.Image)
        Me.tbtnChenLink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnChenLink.Name = "tbtnChenLink"
        Me.tbtnChenLink.Size = New System.Drawing.Size(23, 22)
        Me.tbtnChenLink.Text = "Chèn liên kết"
        Me.tbtnChenLink.ToolTipText = "Chèn liên kết"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tbtnDanhSo
        '
        Me.tbtnDanhSo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnDanhSo.Image = CType(resources.GetObject("tbtnDanhSo.Image"), System.Drawing.Image)
        Me.tbtnDanhSo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnDanhSo.Name = "tbtnDanhSo"
        Me.tbtnDanhSo.Size = New System.Drawing.Size(23, 22)
        Me.tbtnDanhSo.Text = "Đánh số danh sách"
        Me.tbtnDanhSo.ToolTipText = "Đánh số danh sách"
        '
        'tbtnList
        '
        Me.tbtnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnList.Image = CType(resources.GetObject("tbtnList.Image"), System.Drawing.Image)
        Me.tbtnList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnList.Name = "tbtnList"
        Me.tbtnList.Size = New System.Drawing.Size(23, 22)
        Me.tbtnList.Text = "Đánh dấu danh sách"
        Me.tbtnList.ToolTipText = "Đánh dấu danh sách"
        '
        'tbtnSizeLon
        '
        Me.tbtnSizeLon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnSizeLon.Image = CType(resources.GetObject("tbtnSizeLon.Image"), System.Drawing.Image)
        Me.tbtnSizeLon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnSizeLon.Name = "tbtnSizeLon"
        Me.tbtnSizeLon.Size = New System.Drawing.Size(23, 22)
        Me.tbtnSizeLon.Text = "Chữ lệnh trên"
        Me.tbtnSizeLon.ToolTipText = "Chữ lệnh trên"
        '
        'tbtnSizeNho
        '
        Me.tbtnSizeNho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnSizeNho.Image = CType(resources.GetObject("tbtnSizeNho.Image"), System.Drawing.Image)
        Me.tbtnSizeNho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnSizeNho.Name = "tbtnSizeNho"
        Me.tbtnSizeNho.Size = New System.Drawing.Size(23, 22)
        Me.tbtnSizeNho.Text = "Chữ lệch dưới"
        Me.tbtnSizeNho.ToolTipText = "Chữ lệch dưới"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tbtnMauChu
        '
        Me.tbtnMauChu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnMauChu.Image = CType(resources.GetObject("tbtnMauChu.Image"), System.Drawing.Image)
        Me.tbtnMauChu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnMauChu.Name = "tbtnMauChu"
        Me.tbtnMauChu.Size = New System.Drawing.Size(23, 22)
        Me.tbtnMauChu.Text = "Chọn màu chữ"
        Me.tbtnMauChu.ToolTipText = "Chọn màu chữ"
        '
        'tbtnMauNen
        '
        Me.tbtnMauNen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnMauNen.Image = CType(resources.GetObject("tbtnMauNen.Image"), System.Drawing.Image)
        Me.tbtnMauNen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnMauNen.Name = "tbtnMauNen"
        Me.tbtnMauNen.Size = New System.Drawing.Size(23, 22)
        Me.tbtnMauNen.Text = "Chọn màu nền"
        Me.tbtnMauNen.ToolTipText = "Chọn màu nền"
        '
        'tbtnFormat
        '
        Me.tbtnFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnFormat.Image = CType(resources.GetObject("tbtnFormat.Image"), System.Drawing.Image)
        Me.tbtnFormat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnFormat.Name = "tbtnFormat"
        Me.tbtnFormat.Size = New System.Drawing.Size(23, 22)
        Me.tbtnFormat.Text = "Phục hồi định dạng"
        Me.tbtnFormat.ToolTipText = "Phục hồi định dạng"
        '
        'contentMail
        '
        Me.contentMail.Location = New System.Drawing.Point(3, 44)
        Me.contentMail.MinimumSize = New System.Drawing.Size(20, 20)
        Me.contentMail.Name = "contentMail"
        Me.contentMail.Size = New System.Drawing.Size(797, 374)
        Me.contentMail.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.contentMail, "Nội dung Email")
        Me.contentMail.Url = New System.Uri("", System.UriKind.Relative)
        '
        'pbTienTrinh
        '
        Me.pbTienTrinh.Location = New System.Drawing.Point(675, 120)
        Me.pbTienTrinh.Name = "pbTienTrinh"
        Me.pbTienTrinh.Size = New System.Drawing.Size(376, 23)
        Me.pbTienTrinh.Step = 1
        Me.pbTienTrinh.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rtbTienTrinh)
        Me.GroupBox4.Location = New System.Drawing.Point(677, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(374, 106)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Log tiến trình gửi mail"
        '
        'rtbTienTrinh
        '
        Me.rtbTienTrinh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbTienTrinh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTienTrinh.Location = New System.Drawing.Point(3, 16)
        Me.rtbTienTrinh.Name = "rtbTienTrinh"
        Me.rtbTienTrinh.ReadOnly = True
        Me.rtbTienTrinh.Size = New System.Drawing.Size(368, 87)
        Me.rtbTienTrinh.TabIndex = 0
        Me.rtbTienTrinh.Text = ""
        Me.ToolTip1.SetToolTip(Me.rtbTienTrinh, "Log tiến trình")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "KhachHang.xlsx"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 586)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.pbTienTrinh)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1082, 624)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Mail Marketing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvLstNguoiNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents contentMail As System.Windows.Forms.WebBrowser
    Friend WithEvents dgvLstNguoiNhan As System.Windows.Forms.DataGridView
    Friend WithEvents txtTieuDe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMailNguon As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassMailNguon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnThemNguoiNhan As System.Windows.Forms.Button
    Friend WithEvents btnXoaTrong As System.Windows.Forms.Button
    Friend WithEvents btnGuiMail As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbtnXoaDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnDeleteItemDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtnLoadDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnDan As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tcbFontFamily As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tcbFontWidth As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tbtnInDam As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnInNghien As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnGachChan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtnCanhTrai As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnCanhGiua As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnCanhPhai As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnCanhDieu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtnChenLink As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtnDanhSo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnList As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnSizeLon As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnSizeNho As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlblHienTrang As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbtnMauChu As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnMauNen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pbTienTrinh As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbtnLuuDanhSach As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents btnInfomation As System.Windows.Forms.Button
    Friend WithEvents lbWaitLoadData As Label
    Friend WithEvents lbWaitSendMail As Label
    Friend WithEvents flpDinhKem As FlowLayoutPanel
    Friend WithEvents rtbTienTrinh As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tbtnNewEmail As ToolStripButton
    Friend WithEvents tbtnFormat As ToolStripButton
End Class
