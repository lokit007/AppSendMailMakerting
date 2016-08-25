Imports System.IO
Imports System.Net.Mail
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each f In FontFamily.Families
            tcbFontFamily.Items.Add(f.Name)
        Next
    End Sub

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

    Private Sub tbtnLoadDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnLoadDanhSach.Click
        OpenFileDialog1.Filter = "All data|*.xlsx;*.xls"
        Dim btnResult As DialogResult = OpenFileDialog1.ShowDialog
        If btnResult = DialogResult.OK Then
            dgvLstNguoiNhan.Columns.Clear()
            dgvLstNguoiNhan.DataSource = GetListEmail(OpenFileDialog1.FileName, "KhachHang")
            dgvLstNguoiNhan.Columns(0).HeaderText = "Email"
            dgvLstNguoiNhan.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvLstNguoiNhan.Columns(1).HeaderText = "Khách hàng"
            dgvLstNguoiNhan.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Function GetListEmail(ByVal path As String, ByVal sheetName As String) As DataTable
        If File.Exists(path) Then
            Dim myconnection As System.Data.OleDb.OleDbConnection = Nothing
            Dim dtResult As New DataTable
            Try
                Dim Mycommand As System.Data.OleDb.OleDbDataAdapter = Nothing
                Dim strConnectionString As String = GetConnectionString(path)
                myconnection = New System.Data.OleDb.OleDbConnection(strConnectionString)
                Mycommand = New System.Data.OleDb.OleDbDataAdapter("select * from  [" & sheetName & "$]", myconnection)
                Mycommand.Fill(dtResult)
                Return dtResult
                myconnection.Close()
            Catch ex As Exception
                Return Nothing
            End Try
        Else
            Return Nothing
        End If
    End Function

    Private Function GetConnectionString(ByVal excelFileName As String) As String
        Dim strConnectionString As String = ""
        If Path.GetExtension(excelFileName).ToLower() = ".xlsx" Then
            strConnectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"";", excelFileName)
        ElseIf Path.GetExtension(excelFileName).ToLower() = ".xls" Then
            strConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"";", excelFileName)
        End If
        Return (strConnectionString)
    End Function

    Private Sub tbtnLuuDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnLuuDanhSach.Click
        SaveFileDialog1.Filter = "Excel 2007|*.xlsx|Excel 2003|*.xls"
        Dim btnResult As DialogResult = SaveFileDialog1.ShowDialog
        If btnResult = DialogResult.OK Then
            Dim pathMau As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\MauKhachHang.xlsx"
            Try
                If File.Exists(pathMau) Then
                    File.Copy(pathMau, SaveFileDialog1.FileName, True)
                    Dim myconnection As System.Data.OleDb.OleDbConnection = Nothing
                    Dim dtResult As New DataTable
                    Try
                        Dim Mycommand As System.Data.OleDb.OleDbCommand = Nothing
                        Dim strConnectionString As String = GetConnectionString(pathMau)
                        myconnection = New System.Data.OleDb.OleDbConnection(strConnectionString)
                        Mycommand = New System.Data.OleDb.OleDbCommand("insert into [KhachHang$] values ('it007bk@gmail.com', 'Hồ Viết Nhân' )", myconnection)
                        'Mycommand.CommandText = ""
                        'Mycommand.CommandType = CommandType.Text
                        'Mycommand.Connection = myconnection
                        'Mycommand.Parameters.AddWithValue("@email", "it007bk@gmail.com")
                        'Mycommand.Parameters.AddWithValue("@khach", "Hồ Viết Nhân")
                        Mycommand.Connection = myconnection
                        myconnection.Open()
                        Mycommand.ExecuteNonQuery()
                        myconnection.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Lỗi xuất dữ liệu!" & vbCrLf & "Vui lòng thao tác lại sau." & ex.ToString, MsgBoxStyle.OkOnly, "Lỗi xuất dữ liệu Excel !!!")
            End Try
        End If
    End Sub
End Class
