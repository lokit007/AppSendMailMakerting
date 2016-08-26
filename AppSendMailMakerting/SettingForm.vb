Public Class SettingForm
    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged
        If tbEmail.Text.Trim = "" Then
            Exit Sub
        End If
        Try
            Dim a As New System.Net.Mail.MailAddress(tbEmail.Text)
            tbEmail.BackColor = Nothing
        Catch ex As Exception
            tbEmail.BackColor = Color.LightCoral
            tbEmail.SelectAll()
            tbEmail.Focus()
        End Try
    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click
        tbPassword.UseSystemPasswordChar = Not tbPassword.UseSystemPasswordChar
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

    End Sub

    Private Sub btnXoaTrong_Click(sender As Object, e As EventArgs) Handles btnXoaTrong.Click
        tbHost.Text = ""
        tbEmail.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class