<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl_username = New Label()
        lbl_password = New Label()
        txt_username = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        SuspendLayout()
        ' 
        ' lbl_username
        ' 
        lbl_username.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        lbl_username.Location = New Point(12, 20)
        lbl_username.Name = "lbl_username"
        lbl_username.Size = New Size(119, 34)
        lbl_username.TabIndex = 0
        lbl_username.Text = "Username"
        lbl_username.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_password
        ' 
        lbl_password.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        lbl_password.Location = New Point(12, 68)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(119, 36)
        lbl_password.TabIndex = 1
        lbl_password.Text = "Password"
        lbl_password.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Times New Roman", 15F, FontStyle.Bold)
        txt_username.Location = New Point(147, 20)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(308, 36)
        txt_username.TabIndex = 2
        txt_username.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Times New Roman", 15F, FontStyle.Bold)
        txt_password.Location = New Point(147, 68)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(308, 36)
        txt_password.TabIndex = 3
        txt_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_login.Location = New Point(361, 119)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(94, 50)
        btn_login.TabIndex = 4
        btn_login.Text = "Log in"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 185)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(lbl_password)
        Controls.Add(lbl_username)
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button

End Class
