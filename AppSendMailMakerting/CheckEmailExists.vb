Imports System.Collections.Specialized
Imports System.Net
Imports System.Text

Public Class CheckEmailExists
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        lblKetQua.Text = ""
        If CheckEmail(txtEmailCheck.Text.Trim) Then
            lblKetQua.Text = "Mail tồn tại"
        Else
            lblKetQua.Text = "Mail không tồn tại"
        End If
    End Sub

    Private Function CheckEmail(ByVal email As String) As Boolean
        Using webClient As New WebClient
            Dim formData As New NameValueCollection
            formData("check") = email

            Dim responseBytes As Byte() = webClient.UploadValues("http://verify-email.org/",
                                                                 "POST", formData)
            Dim response As String = Encoding.ASCII.GetString(responseBytes)
            MsgBox(response)
            If response.Contains("Result: Ok") Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
End Class