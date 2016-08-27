Imports System.IO

Public Class SettingForm
    Private path As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\ThongTin.txt"

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged
        If tbEmail.Text.Trim = "" Then
            Exit Sub
        End If
        Try
            Dim a As New System.Net.Mail.MailAddress(tbEmail.Text)
            tbEmail.BackColor = Nothing
        Catch ex As Exception
            tbEmail.BackColor = Color.LightCoral
            tbEmail.Focus()
        End Try
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        tbPassword.UseSystemPasswordChar = Not tbPassword.UseSystemPasswordChar
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If String.IsNullOrEmpty(tbHost.Text) Then
            MsgBox("Bạn chưa nhập địa chỉ host(Gửi từ địa chỉ)", MsgBoxStyle.OkOnly, "Lỗi chưa nhập dữ liệu!!!")
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
                lstString(5) = "active"
                Try
                    lstString(6) = tbHost.Text
                    lstString(7) = tbEmail.Text
                    lstString(8) = tbPassword.Text
                Catch ex As Exception
                    ReDim Preserve lstString(10)
                    lstString(6) = tbHost.Text
                    lstString(7) = tbEmail.Text
                    lstString(8) = tbPassword.Text
                End Try
                File.WriteAllLines(path, lstString)
                MsgBox("Đã cập nhật cấu hình thành công", MsgBoxStyle.OkOnly, "Cập nhật thành công")
            Catch ex As Exception
                MsgBox("Đã cập nhật cấu hình thất bại!!!", MsgBoxStyle.OkOnly, "Cập nhật thất bại!!!")
            End Try
        End If
    End Sub

    Private Sub btnXoaTrong_Click(sender As Object, e As EventArgs) Handles btnXoaTrong.Click
        tbHost.Text = ""
        tbEmail.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(path) Then
            Dim lstString As String() = File.ReadAllLines(path)
            Try
                Dim isChange As Boolean = CBool(lstString(0))
                If "not active".Equals(lstString(5)) OrElse "active".Equals(lstString(5)) Then
                    txtHostFormat.Text = lstString(2)
                    txtEmailFormat.Text = lstString(3)
                    txtPassFormat.Text = lstString(4)
                End If
                If isChange Then
                    If "active".Equals(lstString(5)) Then
                        tbHost.Text = lstString(6)
                        tbEmail.Text = lstString(7)
                        tbPassword.Text = lstString(8)
                    End If
                End If
            Catch ex As Exception
                Close()
            End Try
        End If
    End Sub

End Class