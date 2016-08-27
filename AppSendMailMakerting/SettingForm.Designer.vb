<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Me.btnXoaTrong = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnShowPass = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbHost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHostFormat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmailFormat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassFormat = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXoaTrong
        '
        Me.btnXoaTrong.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnXoaTrong.Image = CType(resources.GetObject("btnXoaTrong.Image"), System.Drawing.Image)
        Me.btnXoaTrong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnXoaTrong.Location = New System.Drawing.Point(369, 73)
        Me.btnXoaTrong.Name = "btnXoaTrong"
        Me.btnXoaTrong.Size = New System.Drawing.Size(92, 42)
        Me.btnXoaTrong.TabIndex = 6
        Me.btnXoaTrong.Text = "Xóa trống"
        Me.btnXoaTrong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnXoaTrong.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Image = CType(resources.GetObject("btnCapNhat.Image"), System.Drawing.Image)
        Me.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCapNhat.Location = New System.Drawing.Point(369, 28)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(92, 41)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnShowPass)
        Me.GroupBox3.Controls.Add(Me.tbPassword)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.tbEmail)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tbHost)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 110)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cập nhật thông tin email marketing"
        '
        'btnShowPass
        '
        Me.btnShowPass.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPass.Image = CType(resources.GetObject("btnShowPass.Image"), System.Drawing.Image)
        Me.btnShowPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowPass.Location = New System.Drawing.Point(344, 76)
        Me.btnShowPass.Name = "btnShowPass"
        Me.btnShowPass.Size = New System.Drawing.Size(93, 23)
        Me.btnShowPass.TabIndex = 4
        Me.btnShowPass.Text = "Password"
        Me.btnShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowPass.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tbPassword.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(111, 76)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(227, 23)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mật khẩu :"
        '
        'tbEmail
        '
        Me.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tbEmail.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(111, 50)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(327, 23)
        Me.tbEmail.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Email nguồn :"
        '
        'tbHost
        '
        Me.tbHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbHost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.tbHost.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHost.Location = New System.Drawing.Point(110, 24)
        Me.tbHost.Name = "tbHost"
        Me.tbHost.Size = New System.Drawing.Size(327, 23)
        Me.tbHost.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Gửi từ địa chỉ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gửi từ địa chỉ"
        '
        'txtHostFormat
        '
        Me.txtHostFormat.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostFormat.Location = New System.Drawing.Point(90, 24)
        Me.txtHostFormat.Name = "txtHostFormat"
        Me.txtHostFormat.ReadOnly = True
        Me.txtHostFormat.Size = New System.Drawing.Size(248, 23)
        Me.txtHostFormat.TabIndex = 1
        Me.txtHostFormat.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email nguồn :"
        '
        'txtEmailFormat
        '
        Me.txtEmailFormat.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailFormat.Location = New System.Drawing.Point(90, 50)
        Me.txtEmailFormat.Name = "txtEmailFormat"
        Me.txtEmailFormat.ReadOnly = True
        Me.txtEmailFormat.Size = New System.Drawing.Size(248, 23)
        Me.txtEmailFormat.TabIndex = 2
        Me.txtEmailFormat.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mật khẩu :"
        '
        'txtPassFormat
        '
        Me.txtPassFormat.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassFormat.Location = New System.Drawing.Point(90, 76)
        Me.txtPassFormat.Name = "txtPassFormat"
        Me.txtPassFormat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassFormat.ReadOnly = True
        Me.txtPassFormat.Size = New System.Drawing.Size(248, 23)
        Me.txtPassFormat.TabIndex = 3
        Me.txtPassFormat.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPassFormat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmailFormat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHostFormat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 109)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ví dụ về thông tin email marketing"
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 249)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnXoaTrong)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingForm"
        Me.Text = "Cấu hình ứng dụng"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnXoaTrong As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbHost As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnShowPass As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHostFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmailFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassFormat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
