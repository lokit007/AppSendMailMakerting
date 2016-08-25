Imports System.Net.Mail
Imports System.Text

Public Class Form1

    Private Sub contentMail_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles contentMail.DocumentCompleted
        contentMail.Document.ExecCommand("EditMode", False, Nothing)

    End Sub

    Private Sub Form1_MaximumSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        pbTienTrinh.Size = New Size(Me.Width - 700, 23)
        dgvLstNguoiNhan.Size = New Size(227, Me.Height - 245)
        contentMail.Size = New Size(Me.Width - 290, Me.Height - 250)
        GroupBox4.Size = New Size(Me.Width - 700, 106)
    End Sub

    Public Sub subSendMail(ByVal strNguoiGoi As String, ByVal lstNguoiNhan As List(Of String),
                           ByVal strTieuDe As String, ByVal strNoiDung As String,
                           ByVal lstTapTinDinhKem As List(Of String))

        Dim MyMailMessage As New MailMessage()
        MyMailMessage.From = New MailAddress(strNguoiGoi)
        'danh sach nguoi nhận
        Dim i As Integer
        For i = 0 To lstNguoiNhan.Count - 1
            MyMailMessage.To.Add(lstNguoiNhan.Item(i).ToString)
        Next
        MyMailMessage.Subject = strTieuDe
        MyMailMessage.Body = strNoiDung
        MyMailMessage.IsBodyHtml = True
        MyMailMessage.BodyEncoding = Encoding.UTF8
        'danh sách tập tin đính kèm
        If Not lstTapTinDinhKem Is Nothing Then
            For i = 0 To lstTapTinDinhKem.Count - 1
                MyMailMessage.Attachments.Add(New Attachment(lstTapTinDinhKem.Item(i).ToString))
            Next
        End If
        'Khai bao thong tin mail
        Dim SMTPServer As New SmtpClient(txtHost.Text)
        SMTPServer.Port = 587 '25
        SMTPServer.Credentials = New System.Net.NetworkCredential(txtMailNguon.Text, txtPassMailNguon.Text)
        SMTPServer.EnableSsl = True ' tắt đi do có phần mềm diệt virus không cho (avasst)
        Try
            SMTPServer.Send(MyMailMessage)
            Application.DoEvents()
            MsgBox("Đã gởi E-Mail xong")
        Catch ex As SmtpException
            MessageBox.Show(" Không gởi được, kiểm tra lại : " & ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub btnGuiMail_Click(sender As Object, e As EventArgs) Handles btnGuiMail.Click
        Dim listNhan As New List(Of String)
        listNhan.Add("doihamhieu@gmail.com")
        subSendMail("it007bk@gmail.com", listNhan, txtTieuDe.Text, contentMail.Document.Body.InnerHtml, Nothing)
    End Sub

End Class
