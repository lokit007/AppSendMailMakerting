Imports System.IO
Imports System.Net.Mail
Imports System.Text
Imports System.Threading

Public Class Form1
    Private lstEmail As List(Of String)
    Private pathData As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\ThongTin.txt"

    'Định nghĩa lại hàm settext
    Delegate Sub SetTextCallback([text] As String)
    Private Sub SetText(ByVal [text] As String)
        If Me.rtbTienTrinh.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pbTienTrinh.Value >= pbTienTrinh.Maximum Then
            btnGuiMail.Enabled = True
            lbWaitSendMail.Visible = False
            rtbTienTrinh.Text = "********** Hoàn thành tiến trình gửi mail **********" & vbCrLf & rtbTienTrinh.Text
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each f In FontFamily.Families
            tcbFontFamily.Items.Add(f.Name)
        Next
        Dim lstString As String() = File.ReadAllLines(pathData)
        Dim isChange As Boolean = CBool(lstString(0))
        Try
            txtHost.Text = lstString(6)
            txtMailNguon.Text = lstString(7)
            txtPassMailNguon.Text = lstString(8)
        Catch ex As Exception
            Try
                txtHost.Text = lstString(2)
                txtMailNguon.Text = lstString(3)
                txtPassMailNguon.Text = lstString(4)
            Catch ex1 As Exception
                btnSetting_Click(sender, e)
            End Try
        End Try
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

    Private Sub SendSingeMail(ByVal nguoiGui As String, ByVal emailNhan As String,
                              ByVal tieuDe As String, ByVal noiDung As String,
                              ByVal lstDinhKem As List(Of String))
        Dim MyMailMessage As New MailMessage()
        MyMailMessage.From = New MailAddress(nguoiGui)
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
        Dim SMTPServer As New SmtpClient(txtHost.Text)
        SMTPServer.Port = 587 '25
        SMTPServer.Credentials = New System.Net.NetworkCredential(txtMailNguon.Text, txtPassMailNguon.Text)
        SMTPServer.EnableSsl = True ' tắt đi do có phần mềm diệt virus không cho (avasst)
        Try
            SMTPServer.Send(MyMailMessage)
            SetText("Đã gửi đến mail " & emailNhan & vbCrLf)
        Catch ex As SmtpException
            Dim textInsert As String = "Lỗi gửi email đến " & emailNhan & vbCrLf & ex.Message
            SetText(textInsert & vbCrLf)
        End Try
        SetValue()
    End Sub

    Private Sub ThreadSendMail(ByVal nguoiGui As String, ByVal emailNhan As String,
                              ByVal tieuDe As String, ByVal noiDung As String,
                              ByVal lstDinhKem As List(Of String))
        Dim tienTrinh As New Thread(New ThreadStart(Sub() SendSingeMail(nguoiGui, emailNhan, tieuDe, noiDung, lstDinhKem)))
        tienTrinh.Start()
    End Sub

    Private Sub btnGuiMail_Click(sender As Object, e As EventArgs) Handles btnGuiMail.Click
        Dim listnhan As New List(Of String)
        If dgvLstNguoiNhan.Rows.Count > 1 Then
            For Each info As DataGridViewRow In dgvLstNguoiNhan.Rows
                Try
                    listnhan.Add(info.Cells(0).Value.ToString)
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
                    ThreadSendMail("it007bk@gmail.com", emailnhan, txtTieuDe.Text, contentMail.Document.Body.InnerHtml, Nothing)
                    Application.DoEvents()
                Next
            End If
        Else
            MsgBox("bạn chưa nhập dánh sách người nhận mail!!!" & vbCrLf & "vui lòng chèn dữ liệu vào danh sách khách hàng trước.", MsgBoxStyle.OkOnly, "dữ liệu rỗng !!!")
        End If
        Exit Sub
    End Sub

    Private Sub btnXoaTrong_Click(sender As Object, e As EventArgs) Handles btnXoaTrong.Click
        txtTieuDe.Text = Nothing
        contentMail.Document.Body.InnerHtml = Nothing
    End Sub

    Private Sub tbtnLoadDanhSach_Click(sender As Object, e As EventArgs) Handles tbtnLoadDanhSach.Click, btnThemNguoiNhan.Click
        OpenFileDialog1.Filter = "All data|*.xlsx;*.xls"
        Dim btnResult As DialogResult = OpenFileDialog1.ShowDialog
        If btnResult = DialogResult.OK Then
            lbWaitLoadData.Visible = True
            Dim dtResult As DataTable = GetListEmail(OpenFileDialog1.FileName, "KhachHang")
            If Not IsNothing(dtResult) AndAlso dtResult.Rows.Count > 0 Then
                Dim index As Integer = 0
                For Each row As DataRow In dtResult.Rows
                    index = dgvLstNguoiNhan.Rows.Add()
                    dgvLstNguoiNhan(0, index).Value = row.Item(0)
                    dgvLstNguoiNhan(1, index).Value = row.Item(1)
                Next
            End If
            tlblHienTrang.Text = String.Format("Hiện có {0}", dgvLstNguoiNhan.Rows.Count - 1)
            lbWaitLoadData.Visible = False
        End If
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Dim obj As New SettingForm()
        obj.StartPosition = FormStartPosition.CenterScreen
        obj.ShowDialog()
        Me.OnLoad(e)
    End Sub

    Private Sub btnInfomation_Click(sender As Object, e As EventArgs) Handles btnInfomation.Click
        Dim obj As New InfomationForm()
        obj.StartPosition = FormStartPosition.CenterScreen
        obj.ShowDialog()
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
        If dgvLstNguoiNhan.Rows.Count > 1 Then
            SaveFileDialog1.Filter = "Excel 2007|*.xlsx|Excel 2003|*.xls"
            Dim btnResult As DialogResult = SaveFileDialog1.ShowDialog
            If btnResult = DialogResult.OK Then
                Dim pathMau As String = Application.StartupPath.Replace("\bin\Debug", "").Replace("\bin\Release", "") & "\Resources\MauKhachHang.xlsx"
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
