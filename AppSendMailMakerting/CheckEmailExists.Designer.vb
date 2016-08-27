<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckEmailExists
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
        Me.txtEmailCheck = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblKetQua = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmailCheck
        '
        Me.txtEmailCheck.Location = New System.Drawing.Point(28, 23)
        Me.txtEmailCheck.Name = "txtEmailCheck"
        Me.txtEmailCheck.Size = New System.Drawing.Size(502, 20)
        Me.txtEmailCheck.TabIndex = 0
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(536, 21)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblKetQua
        '
        Me.lblKetQua.AutoSize = True
        Me.lblKetQua.Location = New System.Drawing.Point(35, 58)
        Me.lblKetQua.Name = "lblKetQua"
        Me.lblKetQua.Size = New System.Drawing.Size(53, 13)
        Me.lblKetQua.TabIndex = 2
        Me.lblKetQua.Text = "Kết quả : "
        '
        'CheckEmailExists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 123)
        Me.Controls.Add(Me.lblKetQua)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtEmailCheck)
        Me.Name = "CheckEmailExists"
        Me.Text = "CheckEmailExists"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailCheck As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblKetQua As Label
End Class
