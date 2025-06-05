Imports inventory.Models
Imports inventory.DataClients

Public Class UserForm
    Private ReadOnly userClient As New UserClient()
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        dgvUsers.AutoGenerateColumns = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDatabase()
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        dgvUsers.DataSource = Nothing
        dgvUsers.DataSource = userClient.ReadAll()
        dgvUsers.ClearSelection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInputs() Then
            Dim user As New User With {
                .Name = txtName.Text.Trim(),
                .Email = txtEmail.Text.Trim(),
                .Phone = txtPhone.Text.Trim()
            }
            userClient.Create(user)
            LoadUsers()
            ClearForm()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvUsers.SelectedRows.Count > 0 AndAlso ValidateInputs() Then
            Dim selectedUser As User = CType(dgvUsers.SelectedRows(0).DataBoundItem, User)
            selectedUser.Name = txtName.Text.Trim()
            selectedUser.Email = txtEmail.Text.Trim()
            selectedUser.Phone = txtPhone.Text.Trim()
            userClient.Update(selectedUser)
            LoadUsers()
            ClearForm()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim selectedUser As User = CType(dgvUsers.SelectedRows(0).DataBoundItem, User)
            userClient.Delete(selectedUser.Id)
            LoadUsers()
            ClearForm()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim selectedUser As User = CType(dgvUsers.SelectedRows(0).DataBoundItem, User)
            txtName.Text = selectedUser.Name
            txtEmail.Text = selectedUser.Email
            txtPhone.Text = selectedUser.Phone
        End If
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        dgvUsers.ClearSelection()
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

End Class
