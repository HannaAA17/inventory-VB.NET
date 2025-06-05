<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
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
        txtCode = New TextBox()
        txtUOM = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgv = New DataGridView()
        colName = New DataGridViewTextBoxColumn()
        colCode = New DataGridViewTextBoxColumn()
        colUOM = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        lbl_code = New Label()
        lbl_uom = New Label()
        lbl_name = New Label()
        GroupBox2 = New GroupBox()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(110, 26)
        txtName.Name = "txtName"
        txtName.Size = New Size(412, 27)
        txtName.TabIndex = 0
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCode
        ' 
        txtCode.Location = New Point(110, 59)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(412, 27)
        txtCode.TabIndex = 1
        txtCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtUOM
        ' 
        txtUOM.Location = New Point(110, 92)
        txtUOM.Name = "txtUOM"
        txtUOM.Size = New Size(412, 27)
        txtUOM.TabIndex = 2
        txtUOM.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(546, 26)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 27)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(546, 59)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 27)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(546, 92)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 27)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(428, 125)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 27)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeColumns = False
        dgv.AllowUserToResizeRows = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {colName, colCode, colUOM})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgv.DefaultCellStyle = DataGridViewCellStyle1
        dgv.Dock = DockStyle.Fill
        dgv.Location = New Point(5, 25)
        dgv.Margin = New Padding(5)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(642, 195)
        dgv.TabIndex = 7
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colName.DataPropertyName = "Name"
        colName.FillWeight = 60F
        colName.HeaderText = "Name"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colCode
        ' 
        colCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colCode.DataPropertyName = "Code"
        colCode.HeaderText = "Code"
        colCode.MinimumWidth = 6
        colCode.Name = "colCode"
        colCode.ReadOnly = True
        ' 
        ' colUOM
        ' 
        colUOM.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colUOM.DataPropertyName = "UOM"
        colUOM.HeaderText = "UOM"
        colUOM.MinimumWidth = 6
        colUOM.Name = "colUOM"
        colUOM.ReadOnly = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbl_code)
        GroupBox1.Controls.Add(lbl_uom)
        GroupBox1.Controls.Add(lbl_name)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtCode)
        GroupBox1.Controls.Add(txtUOM)
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
        ' lbl_code
        ' 
        lbl_code.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        lbl_code.Location = New Point(24, 59)
        lbl_code.Name = "lbl_code"
        lbl_code.Size = New Size(80, 27)
        lbl_code.TabIndex = 8
        lbl_code.Text = "Code"
        lbl_code.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_uom
        ' 
        lbl_uom.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        lbl_uom.Location = New Point(24, 92)
        lbl_uom.Name = "lbl_uom"
        lbl_uom.Size = New Size(80, 27)
        lbl_uom.TabIndex = 10
        lbl_uom.Text = "UOM"
        lbl_uom.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_name
        ' 
        lbl_name.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        lbl_name.Location = New Point(24, 24)
        lbl_name.Name = "lbl_name"
        lbl_name.Size = New Size(80, 27)
        lbl_name.TabIndex = 9
        lbl_name.Text = "Name"
        lbl_name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgv)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(0, 168)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(5)
        GroupBox2.Size = New Size(652, 225)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        ' 
        ' ProductForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(652, 393)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        MinimumSize = New Size(670, 440)
        Name = "ProductForm"
        Text = "Products"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtUOM As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colCode As DataGridViewTextBoxColumn
    Friend WithEvents colUOM As DataGridViewTextBoxColumn
    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_uom As Label
    Friend WithEvents lbl_name As Label

End Class
