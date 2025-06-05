Public Class LoginForm
    Private _IsLoggedIn As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'disable autosize
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        ' Set your login button as the AcceptButton
        Me.AcceptButton = btn_login
    End Sub

    Public Function GetIsLoggedIn() As Boolean
        Return _IsLoggedIn
    End Function

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username$ = txt_username.Text.Trim()
        Dim password$ = txt_password.Text.Trim()

        If username.Length = 0 Or password.Length = 0 Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf username = "admin" And password = "admin" Then
            'MessageBox.Show("You're now logged in as ""admin""", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Set the logged-in status to true
            _IsLoggedIn = True
            ' Close the login form
            Me.Close()
        Else
            MessageBox.Show("Please enter correct username and password.", "Crendintals Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
