Imports inventory.Models
Imports inventory.DataClients

Public Class ProductForm
    'Private ReadOnly productClient As New ProductClient()
    Private ReadOnly factory As IRepositoryFactory = New DataClients.RepositoryFactory(InitializeDatabase())
    Private ReadOnly productClient As IRepository(Of Product) = factory.CreateRepository(Of Product)()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        dgv.AutoGenerateColumns = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        dgv.DataSource = Nothing
        dgv.DataSource = productClient.GetAll()

        dgv.ClearSelection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInputs() Then
            Dim user As New Product With {
                .Name = txtName.Text.Trim(),
                .Code = txtCode.Text.Trim(),
                .UOM = txtUOM.Text.Trim()
            }
            productClient.Create(user)

            LoadProducts()
            ClearForm()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgv.SelectedRows.Count > 0 AndAlso ValidateInputs() Then
            Dim selectedProduct As Product = CType(dgv.SelectedRows(0).DataBoundItem, Product)
            selectedProduct.Name = txtName.Text.Trim()
            selectedProduct.Code = txtCode.Text.Trim()
            selectedProduct.UOM = txtUOM.Text.Trim()
            productClient.Update(selectedProduct)
            LoadProducts()
            ClearForm()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedProduct As Product = CType(dgv.SelectedRows(0).DataBoundItem, Product)
            productClient.Delete(selectedProduct.Id)
            LoadProducts()
            ClearForm()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        If dgv.SelectedRows.Count > 0 Then
            Dim selectedProduct As Product = CType(dgv.SelectedRows(0).DataBoundItem, Product)
            txtName.Text = selectedProduct.Name
            txtCode.Text = selectedProduct.Code
            txtUOM.Text = selectedProduct.UOM
        End If
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtCode.Clear()
        txtUOM.Clear()
        dgv.ClearSelection()
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtCode.Text) OrElse
           String.IsNullOrWhiteSpace(txtUOM.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

End Class
