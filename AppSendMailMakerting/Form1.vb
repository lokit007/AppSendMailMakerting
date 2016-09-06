Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Threading

Public Class Form1
    Private lstEmail As New Dictionary(Of String, String)
    Private lstEmailError As New Dictionary(Of String, String)
    Private pathData As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\ThongTin.txt"

    'Định nghĩa lại hàm settext
    Delegate Sub SetTextCallback([text] As String)
    Private Sub SetText(ByVal [text] As String)
        If Me.rtbTienTrinh.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.rtbTienTrinh.Font = New Font("Times New Roman", 9)
            Me.rtbTienTrinh.Text = [text] & Me.rtbTienTrinh.Text
        End If
    End Sub

    'Định nghĩa lại hàm SetValue
    Delegate Sub SetValueCallback()
    Private Sub SetValue()
        If Me.pbTienTrinh.InvokeRequired Then
            Dim d As New SetValueCallback(AddressOf SetValue)
            Me.Invoke(d, New Object() {})
        Else
            Me.pbTienTrinh.PerformStep()
        End If
    End Sub
    'Kiểm tra tiến trình gửi mail
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pbTienTrinh.Value >= pbTienTrinh.Maximum Then
            btnGuiMail.Enabled = True
            lbWaitSendMail.Visible = False
            Timer1.Stop()
            rtbTienTrinh.Text = "********** Hoàn thành tiến trình gửi mail **********" & vbCrLf & rtbTienTrinh.Text
            If Not IsNothing(lstEmailError) AndAlso lstEmailError.Count > 0 Then
                rtbTienTrinh.Text = "********** Có " & lstEmailError.Count & " không thể gửi được(Nguyên nhân email ảo, hoặc đã chặn email của bạn) **********" & vbCrLf & rtbTienTrinh.Text
                RemoteEmail()
            End If
        End If
    End Sub
    'Xóa email không gửi được hoặc không hợp lệ
    Private Sub RemoteEmail()
        If Not IsNothing(lstEmailError) AndAlso lstEmailError.Count > 0 _
            AndAlso dgvLstNguoiNhan.Rows.Count > 1 Then
            Dim btnResult As DialogResult = MsgBox("Có " & lstEmailError.Count & " lỗi, hoặc không hợp lệ!!!!" &
            vbCrLf & "Bạn có muốn xóa chúng khỏi danh sách không???", MsgBoxStyle.YesNo, "Format Email lỗi !!!")
            If btnResult = DialogResult.Yes Then
                For Each mailError In lstEmailError
                    For Each row As DataGridViewRow In dgvLstNguoiNhan.Rows
                        If mailError.Key.Equals(row.Cells(0).Value) Then
                            dgvLstNguoiNhan.Rows.Remove(row)
                            Exit For
                        End If
                    Next
                Next
            End If
        End If
    End Sub
    'Load dữ liệu hệ thống
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set max, min Threadpool
        Dim nthread As Integer = 0
        Dim nComPost As Integer = 0
        ThreadPool.GetMaxThreads(nthread, nComPost)
        ThreadPool.SetMaxThreads(20, nComPost)
        ThreadPool.GetMaxThreads(nthread, nComPost)

        For Each f In FontFamily.Families
            tcbFontFamily.Items.Add(f.Name)
        Next

        Try
            Dim lstString As String() = File.ReadAllLines(pathData)
            Dim nics() As Net.NetworkInformation.NetworkInterface = Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            If Not nics(1).GetPhysicalAddress.ToString.Equals(lstString(5)) Then
                btnInfomation_Click(sender, e)
            End If
            Try
                txtHost.Text = lstString(2)
                txtMailNguon.Text = lstString(3)
                txtPassMailNguon.Text = lstString(4)
            Catch ex1 As Exception
                btnSetting_Click(sender, e)
            End Try
        Catch ex As Exception
            btnSetting_Click(sender, e)
        End Try
    End Sub
    'Set HTML
    Private Sub contentMail_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles contentMail.DocumentCompleted
        contentMail.Document.ExecCommand("EditMode", False, Nothing)
    End Sub
    'Resize Form
    Private Sub Form1_MaximumSizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        pbTienTrinh.Size = New Size(Me.Width - 700, 23)
        dgvLstNguoiNhan.Size = New Size(227, Me.Height - 245)
        contentMail.Size = New Size(Me.Width - 290, Me.Height - 250)
        GroupBox4.Size = New Size(Me.Width - 700, 106)
    End Sub
    'Tiến trình gửi mail
    Private Sub SendSingeMail(ByVal nguoiGui As String, ByVal emailNhan As String,
                              ByVal tieuDe As String, ByVal noiDung As String,
                              ByVal lstDinhKem As List(Of String))
        Dim rd As New Random
        Thread.Sleep(rd.Next(30000, 300000))
        Try
            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress(txtMailNguon.Text, nguoiGui, Encoding.UTF8)
            'danh sach nguoi nhận
            MyMailMessage.To.Add(emailNhan)
            MyMailMessage.Subject = tieuDe
            MyMailMessage.Body = noiDung
            MyMailMessage.IsBodyHtml = True
            MyMailMessage.BodyEncoding = Encoding.UTF8
            'danh sách tập tin đính kèm
            If Not lstDinhKem Is Nothing Then
                For i = 0 To lstDinhKem.Count - 1
                    MyMailMessage.Attachments.Add(New Attachment(lstDinhKem.Item(i).ToString))
                Next
            End If
            'Khai bao thong tin mail
            Dim SMTPServer As New SmtpClient(txtHost.Text, 25) '587 '25
            SMTPServer.EnableSsl = True ' tắt đi do có phần mềm diệt virus không cho (avasst)
            SMTPServer.Timeout = 40 * 60000
            SMTPServer.UseDefaultCredentials = False
            SMTPServer.Credentials = New System.Net.NetworkCredential(txtMailNguon.Text, txtPassMailNguon.Text)
            Try
                SyncLock rtbTienTrinh
                    SetText(Date.Now.ToString("HH:mm:ss") & " : Đang gửi mail đến " & emailNhan & vbCrLf)
                End SyncLock
                SMTPServer.Send(MyMailMessage)
                SyncLock rtbTienTrinh
                    SetText(Date.Now.ToString("HH:mm:ss") & " : Đã gửi đến mail " & emailNhan & vbCrLf)
                End SyncLock
                Application.DoEvents()
            Catch ex As SmtpException
                Try
                    lstEmailError.Add(emailNhan, ex.Message)
                Catch ex1 As Exception
                End Try
                Dim textInsert As String = Date.Now.ToString("HH:mm:ss") & " : Lỗi gửi email đến " & emailNhan & vbCrLf & ex.Message
                SyncLock rtbTienTrinh
                    SetText(textInsert & vbCrLf)
                End SyncLock
            End Try
        Catch ex As Exception
            Try
                lstEmailError.Add(emailNhan, ex.Message)
            Catch ex1 As Exception
            End Try
            Dim textInsert As String = Date.Now.ToString("HH:mm:ss") & " : Lỗi " & emailNhan & " email không tồn tại" & vbCrLf & ex.Message
            SyncLock rtbTienTrinh
                SetText(textInsert & vbCrLf)
            End SyncLock
        End Try
        SyncLock pbTienTrinh
            SetValue()
        End SyncLock
    End Sub
    'Threadpool gửi mail đồng bộ
    Private Sub ThreadSendMail(ByVal nguoiGui As String, ByVal emailNhan As String,
                              ByVal tieuDe As String, ByVal noiDung As String,
                              ByVal lstDinhKem As List(Of String))
        Dim tienTrinh As New WaitCallback(Sub() SendSingeMail(nguoiGui, emailNhan, tieuDe, noiDung, lstDinhKem))
        ThreadPool.UnsafeQueueUserWorkItem(tienTrinh, "Send Email")
    End Sub
    'Btn gửi mail được kích hoạt
    Private Sub btnGuiMail_Click(sender As Object, e As EventArgs) Handles btnGuiMail.Click
        If String.IsNullOrEmpty(txtHost.Text) Then
            MsgBox("Bạn chưa cấu hình Host Mail(SMTP Host)!!!", MsgBoxStyle.OkOnly, "Lỗi cấu hình email")
            txtHost.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtMailNguon.Text) Then
            MsgBox("Bạn chưa cấu hình Email nguồn(Email quảng bá)!!!", MsgBoxStyle.OkOnly, "Lỗi cấu hình email")
            txtMailNguon.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtTieuDe.Text) Then
            MsgBox("Bạn chưa nhập tiêu đề mail!!!", MsgBoxStyle.OkOnly, "Lỗi cấu hình email")
            txtTieuDe.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(contentMail.Document.Body.InnerText) Then
            MsgBox("Bạn chưa nhập nội dung email quảng bá!!!", MsgBoxStyle.OkOnly, "Lỗi cấu hình email")
            contentMail.Focus()
            Exit Sub
        End If
        Dim listnhan As New List(Of String)
        If dgvLstNguoiNhan.Rows.Count > 1 Then
            lstEmailError.Clear()
            Dim email As String = ""
            Dim a As MailAddress
            For Each info As DataGridViewRow In dgvLstNguoiNhan.Rows
                Try
                    email = info.Cells(0).Value.ToString
                    Try
                        a = New MailAddress(email)
                        listnhan.Add(email)
                    Catch ex As Exception
                        rtbTienTrinh.Text = Date.Now.ToString("HH:mm:ss") & " : Lỗi gửi email không đúng(Không phải định dạng email) " &
                            email & vbCrLf & ex.Message & vbCrLf & rtbTienTrinh.Text
                        lstEmailError.Add(email, ex.Message)
                    End Try
                Catch ex As Exception
                End Try
            Next
            If Not IsNothing(listnhan) AndAlso listnhan.Count > 0 Then
                rtbTienTrinh.Text = ""
                btnGuiMail.Enabled = False
                lbWaitSendMail.Visible = True
                Timer1.Start()
                pbTienTrinh.Maximum = listnhan.Count
                pbTienTrinh.Value = 0
                For Each emailnhan In listnhan
                    ThreadSendMail("Bookingdanang.com", emailnhan, txtTieuDe.Text, contentMail.Document.Body.InnerHtml, Nothing)
                    Application.DoEvents()
                Next
            End If
        Else
            MsgBox("bạn chưa nhập dánh sách người nhận mail!!!" & vbCrLf & "vui lòng chèn dữ liệu vào danh sách khách hàng trước.", MsgBoxStyle.OkOnly, "dữ liệu rỗng !!!")
        End If
        Exit Sub
    End Sub
    'Bnt xóa trống được kích hoạt
    Private Sub btnXoaTrong_Click(sender As Object, e As EventArgs) Handles btnXoaTrong.Click
        txtTieuDe.Text = Nothing
        contentMail.Document.Body.InnerHtml = Nothing
    End Sub
    'Load danh sách từ file excel
    Private Sub tbtnLoadDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnLoadDanhSach.Click, btnThemNguoiNhan.Click
        OpenFileDialog1.Filter = "All data|*.xlsx;*.xls"
        Dim btnResult As DialogResult = OpenFileDialog1.ShowDialog
        If btnResult = DialogResult.OK Then
            lbWaitLoadData.Visible = True
            Dim dtResult As DataTable = GetListEmail(OpenFileDialog1.FileName, "KhachHang")
            If Not IsNothing(dtResult) AndAlso dtResult.Rows.Count > 0 Then
                Dim index As Integer = 0
                Dim emailKhach, nameKhach As String
                lstEmail.Clear()
                For Each row As DataRow In dtResult.Rows
                    Try
                        nameKhach = row.Item(1)
                    Catch ex As Exception
                        nameKhach = "Not value"
                    End Try
                    Try
                        emailKhach = row.Item(0)
                        lstEmail.Add(emailKhach, nameKhach)
                        index = dgvLstNguoiNhan.Rows.Add()
                        dgvLstNguoiNhan(0, index).Value = emailKhach
                        dgvLstNguoiNhan(1, index).Value = nameKhach
                    Catch ex As Exception
                    End Try
                Next
            End If
            tlblHienTrang.Text = String.Format("Hiện có {0}", dgvLstNguoiNhan.Rows.Count - 1)
            lbWaitLoadData.Visible = False
        End If
    End Sub
    'Seting hệ thống
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Dim obj As New SettingForm()
        obj.StartPosition = FormStartPosition.CenterScreen
        obj.ShowDialog()
        Me.OnLoad(e)
    End Sub
    'Thông tin app
    Private Sub btnInfomation_Click(sender As Object, e As EventArgs) Handles btnInfomation.Click
        Dim obj As New InfomationForm()
        obj.StartPosition = FormStartPosition.CenterScreen
        obj.ShowDialog()
        End
    End Sub
    'Get danh sách email từ excel
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
    'Get kết nối
    Private Function GetConnectionString(ByVal excelFileName As String) As String
        Dim strConnectionString As String = ""
        If Path.GetExtension(excelFileName).ToLower() = ".xlsx" Then
            strConnectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=1"";", excelFileName)
        ElseIf Path.GetExtension(excelFileName).ToLower() = ".xls" Then
            strConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"";", excelFileName)
        End If
        Return (strConnectionString)
    End Function
    'Save danh sách email
    Private Sub tbtnLuuDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnLuuDanhSach.Click
        If dgvLstNguoiNhan.Rows.Count > 1 Then
            SaveFileDialog1.Filter = "Excel 2007|*.xlsx|Excel 2003|*.xls"
            Dim btnResult As DialogResult = SaveFileDialog1.ShowDialog
            If btnResult = DialogResult.OK Then
                Dim pathMau As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "")
                If SaveFileDialog1.FileName.Substring(SaveFileDialog1.FileName.LastIndexOf(".") + 1).Equals("xls") Then
                    pathMau &= "\Resources\MauKhachHang.xls"
                Else
                    pathMau &= "\Resources\MauKhachHang.xlsx"
                End If
                Try
                    If File.Exists(pathMau) Then
                        File.Copy(pathMau, SaveFileDialog1.FileName, True)
                        saveExcel(SaveFileDialog1.FileName)
                    End If
                Catch ex As Exception
                    MsgBox("Lỗi xuất dữ liệu!" & vbCrLf & "Vui lòng thao tác lại sau." & ex.ToString, MsgBoxStyle.OkOnly, "Lỗi xuất dữ liệu Excel !!!")
                End Try
            End If
        Else
            MsgBox("Không có dữ liệu để xuất !!!" & vbCrLf & "Vui lòng chèn dữ liệu vào danh sách khách hàng trước.", MsgBoxStyle.OkOnly, "Dữ liệu rỗng !!!")
        End If
    End Sub

    Private Sub saveExcel(ByVal path As String)
        Dim oldCI As System.Globalization.CultureInfo =
            System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture =
            New System.Globalization.CultureInfo("en-US")

        Try
            Dim xlApp As Object
            xlApp = CreateObject("Excel.Application")
            Dim xlBook As Object = xlApp.Workbooks.Open(path)
            Dim xlSheet As Object = xlBook.Worksheets(1)
            Dim index As Integer = 2

            For Each info As DataGridViewRow In dgvLstNguoiNhan.Rows
                xlSheet.Range("A" & index).Value = info.Cells(0).Value
                xlSheet.Range("B" & index).Value = info.Cells(1).Value
                index += 1
            Next

            xlBook.Save()
            xlBook.Close()
            xlApp.Quit()

        Catch ex As Exception
            MsgBox("Không xuất được dữ liệu ra file Excel!!!" & vbCrLf & "Vui lòng Reset lại Office và thử lại sau.")
        End Try

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub

    Private Sub dgvLstNguoiNhan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLstNguoiNhan.CellEndEdit
        If e.ColumnIndex = 0 Then
            Try
                Dim a As New System.Net.Mail.MailAddress(dgvLstNguoiNhan(e.ColumnIndex, e.RowIndex).Value)
                Me.dgvLstNguoiNhan(e.ColumnIndex, e.RowIndex).ErrorText = Nothing
            Catch ex As Exception
                Me.dgvLstNguoiNhan(e.ColumnIndex, e.RowIndex).ErrorText = "Không phải địa chỉ Email"
            End Try
        End If
    End Sub

    Private Sub tbtnDeleteItemDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnDeleteItemDanhSach.Click
        Try
            dgvLstNguoiNhan.Rows.RemoveAt(dgvLstNguoiNhan.CurrentRow.Index)
        Catch ex As Exception
            MsgBox("Bạn chưa chọn hàng để xóa !!!", MsgBoxStyle.OkOnly, "Lỗi !!!")
        End Try
    End Sub

    Private Sub tbtnXoaDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnXoaDanhSach.Click
        Try
            dgvLstNguoiNhan.Rows.Clear()
            tlblHienTrang.Text = String.Format("Hiện có {0}", dgvLstNguoiNhan.Rows.Count - 1)
        Catch ex As Exception
            tlblHienTrang.Text = String.Format("Hiện có 0")
        End Try
    End Sub

    Private Sub dgvLstNguoiNhan_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvLstNguoiNhan.RowsAdded
        Try
            tlblHienTrang.Text = String.Format("Hiện có {0}", dgvLstNguoiNhan.Rows.Count - 1)
        Catch ex As Exception
            tlblHienTrang.Text = String.Format("Hiện có 0")
        End Try
    End Sub

    Private Sub dgvLstNguoiNhan_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvLstNguoiNhan.RowsRemoved
        Try
            tlblHienTrang.Text = String.Format("Hiện có {0}", dgvLstNguoiNhan.Rows.Count - 1)
        Catch ex As Exception
            MsgBox("Bạn chưa chọn khách hàng để xóa!!!", MsgBoxStyle.OkOnly, "Lỗi xóa khách hành nhận email")
        End Try
    End Sub

    Private Sub txtMailNguon_Validated(sender As Object, e As EventArgs) Handles txtMailNguon.Validated
        Try
            Dim a As New System.Net.Mail.MailAddress(txtMailNguon.Text)
            txtMailNguon.BackColor = Nothing
        Catch ex As Exception
            txtMailNguon.BackColor = Color.LightCoral
            txtMailNguon.SelectAll()
            txtMailNguon.Focus()
        End Try
    End Sub

    Private Sub tbtnDan_Click(sender As Object, e As EventArgs) Handles tbtnDan.Click
        contentMail.Document.ExecCommand("Paste", False, Nothing)
    End Sub

    Private Sub tbtnCopy_Click(sender As Object, e As EventArgs) Handles tbtnCopy.Click
        contentMail.Document.ExecCommand("Copy", False, Nothing)
    End Sub

    Private Sub tbtnCut_Click(sender As Object, e As EventArgs) Handles tbtnCut.Click
        contentMail.Document.ExecCommand("Cut", False, Nothing)
    End Sub

    Private Sub tcbFontFamily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcbFontFamily.SelectedIndexChanged
        Try
            contentMail.Document.ExecCommand("FontName", False, tcbFontFamily.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tcbFontWidth_TextChanged(sender As Object, e As EventArgs) Handles tcbFontWidth.TextChanged
        If Not IsNumeric(tcbFontWidth.Text) Then
            tcbFontWidth.Text = 11
        End If

        Try
            contentMail.Document.ExecCommand("FontSize", True, CInt(tcbFontWidth.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbtnInDam_Click(sender As Object, e As EventArgs) Handles tbtnInDam.Click
        contentMail.Document.ExecCommand("Bold", False, Nothing)
    End Sub

    Private Sub tbtnInNghien_Click(sender As Object, e As EventArgs) Handles tbtnInNghien.Click
        contentMail.Document.ExecCommand("Italic", False, Nothing)
    End Sub

    Private Sub tbtnGachChan_Click(sender As Object, e As EventArgs) Handles tbtnGachChan.Click
        contentMail.Document.ExecCommand("Underline", False, Nothing)
    End Sub

    Private Sub tbtnCanhTrai_Click(sender As Object, e As EventArgs) Handles tbtnCanhTrai.Click
        contentMail.Document.ExecCommand("justifyLeft", False, Nothing)
    End Sub

    Private Sub tbtnCanhGiua_Click(sender As Object, e As EventArgs) Handles tbtnCanhGiua.Click
        contentMail.Document.ExecCommand("justifyCenter", False, Nothing)
    End Sub

    Private Sub tbtnCanhPhai_Click(sender As Object, e As EventArgs) Handles tbtnCanhPhai.Click
        contentMail.Document.ExecCommand("justifyRight", False, Nothing)
    End Sub

    Private Sub tbtnCanhDieu_Click(sender As Object, e As EventArgs) Handles tbtnCanhDieu.Click
        contentMail.Document.ExecCommand("justifyFull", False, Nothing)
    End Sub

    Private Sub tbtnChenAnh_Click(sender As Object, e As EventArgs)
        contentMail.Document.ExecCommand("insertImage", True, Nothing)
    End Sub

    Private Sub tbtnChenLink_Click(sender As Object, e As EventArgs) Handles tbtnChenLink.Click
        contentMail.Document.ExecCommand("createLink", True, Nothing)
    End Sub

    Private Sub tbtnDanhSo_Click(sender As Object, e As EventArgs) Handles tbtnDanhSo.Click
        contentMail.Document.ExecCommand("InsertOrderedList", True, Nothing)
    End Sub

    Private Sub tbtnList_Click(sender As Object, e As EventArgs) Handles tbtnList.Click
        contentMail.Document.ExecCommand("insertUnorderedList", False, Nothing)
    End Sub

    Private Sub tbtnSizeLon_Click(sender As Object, e As EventArgs) Handles tbtnSizeLon.Click
        contentMail.Document.ExecCommand("superscript", False, Nothing)
    End Sub

    Private Sub tbtnSizeNho_Click(sender As Object, e As EventArgs) Handles tbtnSizeNho.Click
        contentMail.Document.ExecCommand("subscript", False, Nothing)
    End Sub

    Private Sub tbtnMauChu_Click(sender As Object, e As EventArgs) Handles tbtnMauChu.Click
        Dim btnResult As DialogResult = ColorDialog1.ShowDialog
        If btnResult = DialogResult.OK Then
            contentMail.Document.ExecCommand("foreColor", False, ColorTranslator.ToHtml(ColorDialog1.Color))
        End If
    End Sub

    Private Sub tbtnMauNen_Click(sender As Object, e As EventArgs) Handles tbtnMauNen.Click
        Dim btnResult As DialogResult = ColorDialog1.ShowDialog
        If btnResult = DialogResult.OK Then
            contentMail.Document.ExecCommand("backColor", False, ColorTranslator.ToHtml(ColorDialog1.Color))
        End If
    End Sub

    Private Sub tbtnNewEmail_Click(sender As Object, e As EventArgs) Handles tbtnNewEmail.Click
        contentMail.Document.Body.InnerHtml = Nothing
    End Sub

    Private Sub tbtnFormat_Click(sender As Object, e As EventArgs) Handles tbtnFormat.Click
        contentMail.Document.ExecCommand("removeFormat", False, ColorTranslator.ToHtml(ColorDialog1.Color))
    End Sub

End Class
