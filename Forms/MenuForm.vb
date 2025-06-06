Public Class MenuForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'disable autosize
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' login form and check if user is logged in
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog()
        If loginForm.GetIsLoggedIn() Then
            Me.GroupBox1.Enabled = True
            Me.btn_login.Enabled = False
        End If
        loginForm.Dispose()
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        Dim productForm As New ProductForm()
        productForm.ShowDialog()
        productForm.Dispose()
    End Sub

    Private Sub btn_clients_Click(sender As Object, e As EventArgs) Handles btn_clients.Click
        Dim UserForm As New UserForm()
        UserForm.ShowDialog()
        UserForm.Dispose()
    End Sub
End Class