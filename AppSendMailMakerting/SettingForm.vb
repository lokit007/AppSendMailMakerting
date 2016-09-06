Imports System.IO

Public Class SettingForm
    Private path As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\ThongTin.txt"
    Private lstSmtpHost As New Dictionary(Of String, String)

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        tbPassword.UseSystemPasswordChar = Not tbPassword.UseSystemPasswordChar
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If String.IsNullOrEmpty(tbHost.Text) Then
            MsgBox("Bạn chưa nhập địa chỉ host(SMTP Host)", MsgBoxStyle.OkOnly, "Lỗi chưa nhập dữ liệu!!!")
            tbHost.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(tbEmail.Text) Then
            MsgBox("Bạn chưa nhập email nguồn(Email phát tán thư)", MsgBoxStyle.OkOnly, "Lỗi chưa nhập dữ liệu!!!")
            tbEmail.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(tbPassword.Text) Then
            MsgBox("Bạn chưa nhập mật khẩu Email(Mật khẩu đăng nhập Email)", MsgBoxStyle.OkOnly, "Lỗi chưa nhập dữ liệu!!!")
            tbPassword.Focus()
            Exit Sub
        End If
        If File.Exists(path) Then
            Try
                Dim a As New System.Net.Mail.MailAddress(tbEmail.Text)
                Dim lstString As String() = File.ReadAllLines(path)
                lstString(0) = "True"
                lstString(1) = "1"
                lstString(2) = tbHost.Text
                lstString(3) = tbEmail.Text
                lstString(4) = tbPassword.Text
                File.WriteAllLines(path, lstString)
                Dim btnResult As DialogResult = MsgBox("Đã cập nhật cấu hình thành công" & vbCrLf & "Bạn thoát khỏi màn hình này không ???", MsgBoxStyle.YesNo, "Cập nhật thành công")
                If btnResult = DialogResult.Yes Then
                    Close()
                End If
            Catch ex As Exception
                MsgBox("Cập nhật cấu hình thất bại!!!", MsgBoxStyle.OkOnly, "Cập nhật thất bại!!!")
            End Try
        Else

            Dim nics() As Net.NetworkInformation.NetworkInterface = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            Dim lstString As String() = {"True", "1", tbHost.Text, tbEmail.Text, tbPassword.Text, nics(1).GetPhysicalAddress.ToString}
            File.WriteAllLines(path, lstString)
            Dim btnResult As DialogResult = MsgBox("Đã cập nhật cấu hình thành công" & vbCrLf & "Bạn thoát khỏi màn hình này không ???", MsgBoxStyle.YesNo, "Cập nhật thành công")
            If btnResult = DialogResult.Yes Then
                Close()
            End If
        End If
    End Sub

    Private Sub btnXoaTrong_Click(sender As Object, e As EventArgs) Handles btnXoaTrong.Click
        tbHost.Text = ""
        tbEmail.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSmtpHost.Add("Host Gmail", "smtp.gmail.com")
        lstSmtpHost.Add("Host Yahoo", "smtp.mail.yahoo.com")
        lstSmtpHost.Add("Host Hotmail", "smtp.live.com")
        lstSmtpHost.Add("Host Riêng", "vietnhat.jpvn.net")

        cbSmtpHost.DataSource = lstSmtpHost.ToList
        cbSmtpHost.DisplayMember = "key"
        cbSmtpHost.ValueMember = "value"

        FillData("smtp.gmail.com", "emailtoi@gmail.com")

        If File.Exists(path) Then
            Dim lstString As String() = File.ReadAllLines(path)
            Try
                Dim isChange As Boolean = CBool(lstString(0))
                If isChange Then
                    tbHost.Text = lstString(2)
                    tbEmail.Text = lstString(3)
                    tbPassword.Text = lstString(4)
                End If
            Catch ex As Exception
                Close()
            End Try
        End If
    End Sub

    Private Sub FillData(host, mail)
        txtHostFormat.Text = host
        txtEmailFormat.Text = mail
        txtPassFormat.Text = "password"
    End Sub

    Private Sub tbEmail_Leave(sender As Object, e As EventArgs) Handles tbEmail.Leave
        Try
            Dim a As New System.Net.Mail.MailAddress(tbEmail.Text)
            tbEmail.BackColor = Nothing
        Catch ex As Exception
            tbEmail.BackColor = Color.LightCoral
            tbEmail.Focus()
        End Try
    End Sub

    Private Sub cbSmtpHost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSmtpHost.SelectedIndexChanged
        Select Case cbSmtpHost.SelectedIndex
            Case 0
                FillData("smtp.gmail.com", "emailtoi@gmail.com")
            Case 1
                FillData("smtp.mail.yahoo.com", "emailtoi@yahoo.com")
            Case 2
                FillData("smtp.live.com", "emailtoi@hotmail.com")
            Case Else
                FillData("vietnhat.jpvn.net", "admin@gmail.com")
        End Select
    End Sub

End Class