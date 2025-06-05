<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvUsers = New DataGridView()
        colName = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        colPhone = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(27, 26)
        txtName.Name = "txtName"
        txtName.Size = New Size(373, 27)
        txtName.TabIndex = 0
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(27, 59)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(373, 27)
        txtEmail.TabIndex = 1
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(27, 92)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(373, 27)
        txtPhone.TabIndex = 2
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(424, 26)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 27)
        btnAdd.TabIndex = 3
        btnAdd.Text = "btnAdd"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(424, 59)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 27)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "btnUpdate"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(424, 92)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 27)
        btnDelete.TabIndex = 5
        btnDelete.Text = "btnDelete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(306, 125)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 27)
        btnClear.TabIndex = 6
        btnClear.Text = "btnClear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AllowUserToResizeColumns = False
        dgvUsers.AllowUserToResizeRows = False
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {colName, colEmail, colPhone})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.Location = New Point(5, 25)
        dgvUsers.Margin = New Padding(5)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(642, 195)
        dgvUsers.TabIndex = 7
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colName.DataPropertyName = "Name"
        colName.FillWeight = 60.0F
        colName.HeaderText = "Name"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colEmail.DataPropertyName = "Email"
        colEmail.HeaderText = "Email"
        colEmail.MinimumWidth = 6
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' colPhone
        ' 
        colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colPhone.DataPropertyName = "Phone"
        colPhone.HeaderText = "Phone"
        colPhone.MinimumWidth = 6
        colPhone.Name = "colPhone"
        colPhone.ReadOnly = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtPhone)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(btnUpdate)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(652, 168)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvUsers)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 168)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(5)
        GroupBox2.Size = New Size(652, 225)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(652, 393)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        MinimumSize = New Size(670, 440)
        Name = "MainForm"
        Text = "Form1"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
