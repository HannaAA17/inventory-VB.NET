<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        btn_products = New Button()
        btn_vendors = New Button()
        btn_clients = New Button()
        btn_stock = New Button()
        btn_order = New Button()
        btn_sale = New Button()
        btn_login = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_products
        ' 
        btn_products.Cursor = Cursors.Hand
        btn_products.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_products.Location = New Point(6, 26)
        btn_products.Name = "btn_products"
        btn_products.Size = New Size(232, 118)
        btn_products.TabIndex = 0
        btn_products.Text = "Products"
        btn_products.UseVisualStyleBackColor = True
        ' 
        ' btn_vendors
        ' 
        btn_vendors.Cursor = Cursors.Hand
        btn_vendors.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_vendors.Location = New Point(6, 150)
        btn_vendors.Name = "btn_vendors"
        btn_vendors.Size = New Size(232, 118)
        btn_vendors.TabIndex = 1
        btn_vendors.Text = "Vendors"
        btn_vendors.UseVisualStyleBackColor = True
        ' 
        ' btn_clients
        ' 
        btn_clients.Cursor = Cursors.Hand
        btn_clients.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_clients.Location = New Point(6, 274)
        btn_clients.Name = "btn_clients"
        btn_clients.Size = New Size(232, 118)
        btn_clients.TabIndex = 2
        btn_clients.Text = "Clients"
        btn_clients.UseVisualStyleBackColor = True
        ' 
        ' btn_stock
        ' 
        btn_stock.Cursor = Cursors.Hand
        btn_stock.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_stock.Location = New Point(244, 26)
        btn_stock.Name = "btn_stock"
        btn_stock.Size = New Size(232, 118)
        btn_stock.TabIndex = 3
        btn_stock.Text = "Stock"
        btn_stock.UseVisualStyleBackColor = True
        ' 
        ' btn_order
        ' 
        btn_order.Cursor = Cursors.Hand
        btn_order.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_order.Location = New Point(244, 274)
        btn_order.Name = "btn_order"
        btn_order.Size = New Size(232, 118)
        btn_order.TabIndex = 5
        btn_order.Text = "Order"
        btn_order.UseVisualStyleBackColor = True
        ' 
        ' btn_sale
        ' 
        btn_sale.Cursor = Cursors.Hand
        btn_sale.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_sale.Location = New Point(244, 150)
        btn_sale.Name = "btn_sale"
        btn_sale.Size = New Size(232, 118)
        btn_sale.TabIndex = 4
        btn_sale.Text = "Sale"
        btn_sale.UseVisualStyleBackColor = True
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold)
        btn_login.Location = New Point(133, 427)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(232, 40)
        btn_login.TabIndex = 0
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_products)
        GroupBox1.Controls.Add(btn_order)
        GroupBox1.Controls.Add(btn_sale)
        GroupBox1.Controls.Add(btn_vendors)
        GroupBox1.Controls.Add(btn_stock)
        GroupBox1.Controls.Add(btn_clients)
        GroupBox1.Enabled = False
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(491, 409)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 482)
        Controls.Add(btn_login)
        Controls.Add(GroupBox1)
        Name = "MenuForm"
        Text = "Menu"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_products As Button
    Friend WithEvents btn_vendors As Button
    Friend WithEvents btn_clients As Button
    Friend WithEvents btn_stock As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_sale As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
