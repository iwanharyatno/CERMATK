<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.btnVoucher = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelGreeting = New System.Windows.Forms.Label()
        Me.TabProduct = New System.Windows.Forms.TabPage()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnEditProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPurchasePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCustomer = New System.Windows.Forms.TabPage()
        Me.TabSupplier = New System.Windows.Forms.TabPage()
        Me.TabAdmin = New System.Windows.Forms.TabPage()
        Me.TabRole = New System.Windows.Forms.TabPage()
        Me.btnDeleteRole = New System.Windows.Forms.Button()
        Me.btnEditRole = New System.Windows.Forms.Button()
        Me.btnAddRole = New System.Windows.Forms.Button()
        Me.dgvRoles = New System.Windows.Forms.DataGridView()
        Me.RoleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleAccess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabVoucher = New System.Windows.Forms.TabPage()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.btnDeleteSupplier = New System.Windows.Forms.Button()
        Me.btnEditSupplier = New System.Windows.Forms.Button()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tabs.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.TabProduct.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSupplier.SuspendLayout()
        Me.TabRole.SuspendLayout()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CERMATK"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogout.Location = New System.Drawing.Point(608, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 29)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Tabs
        '
        Me.Tabs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.Controls.Add(Me.TabHome)
        Me.Tabs.Controls.Add(Me.TabProduct)
        Me.Tabs.Controls.Add(Me.TabCustomer)
        Me.Tabs.Controls.Add(Me.TabSupplier)
        Me.Tabs.Controls.Add(Me.TabAdmin)
        Me.Tabs.Controls.Add(Me.TabRole)
        Me.Tabs.Controls.Add(Me.TabVoucher)
        Me.Tabs.Location = New System.Drawing.Point(10, 57)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(687, 335)
        Me.Tabs.TabIndex = 2
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.btnVoucher)
        Me.TabHome.Controls.Add(Me.btnAdmin)
        Me.TabHome.Controls.Add(Me.btnRoles)
        Me.TabHome.Controls.Add(Me.btnSuppliers)
        Me.TabHome.Controls.Add(Me.btnCustomers)
        Me.TabHome.Controls.Add(Me.btnProducts)
        Me.TabHome.Controls.Add(Me.Label2)
        Me.TabHome.Controls.Add(Me.labelGreeting)
        Me.TabHome.Location = New System.Drawing.Point(4, 22)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(679, 309)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'btnVoucher
        '
        Me.btnVoucher.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnVoucher.FlatAppearance.BorderSize = 0
        Me.btnVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoucher.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnVoucher.Location = New System.Drawing.Point(156, 195)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Size = New System.Drawing.Size(112, 30)
        Me.btnVoucher.TabIndex = 2
        Me.btnVoucher.Text = "Manage Voucher"
        Me.btnVoucher.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdmin.Location = New System.Drawing.Point(156, 159)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(112, 30)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Manage Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnRoles
        '
        Me.btnRoles.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRoles.FlatAppearance.BorderSize = 0
        Me.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoles.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRoles.Location = New System.Drawing.Point(30, 195)
        Me.btnRoles.Name = "btnRoles"
        Me.btnRoles.Size = New System.Drawing.Size(112, 30)
        Me.btnRoles.TabIndex = 2
        Me.btnRoles.Text = "Manage Roles"
        Me.btnRoles.UseVisualStyleBackColor = False
        '
        'btnSuppliers
        '
        Me.btnSuppliers.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSuppliers.FlatAppearance.BorderSize = 0
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSuppliers.Location = New System.Drawing.Point(30, 159)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(112, 30)
        Me.btnSuppliers.TabIndex = 2
        Me.btnSuppliers.Text = "Manage Supplier"
        Me.btnSuppliers.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomers.Location = New System.Drawing.Point(156, 124)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(112, 30)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Manage Customers"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnProducts
        '
        Me.btnProducts.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnProducts.Location = New System.Drawing.Point(30, 124)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(112, 30)
        Me.btnProducts.TabIndex = 2
        Me.btnProducts.Text = "Manage Products"
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Here's some quick action for you"
        '
        'labelGreeting
        '
        Me.labelGreeting.AutoSize = True
        Me.labelGreeting.Font = New System.Drawing.Font("Segoe UI", 27.75!)
        Me.labelGreeting.ForeColor = System.Drawing.Color.MidnightBlue
        Me.labelGreeting.Location = New System.Drawing.Point(21, 23)
        Me.labelGreeting.Name = "labelGreeting"
        Me.labelGreeting.Size = New System.Drawing.Size(244, 50)
        Me.labelGreeting.TabIndex = 0
        Me.labelGreeting.Text = "Hello, Admin!"
        '
        'TabProduct
        '
        Me.TabProduct.Controls.Add(Me.btnDeleteProduct)
        Me.TabProduct.Controls.Add(Me.btnEditProduct)
        Me.TabProduct.Controls.Add(Me.btnAddProduct)
        Me.TabProduct.Controls.Add(Me.dgvProducts)
        Me.TabProduct.Location = New System.Drawing.Point(4, 22)
        Me.TabProduct.Name = "TabProduct"
        Me.TabProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProduct.Size = New System.Drawing.Size(679, 309)
        Me.TabProduct.TabIndex = 1
        Me.TabProduct.Text = "Products"
        Me.TabProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BackColor = System.Drawing.Color.DarkRed
        Me.btnDeleteProduct.FlatAppearance.BorderSize = 0
        Me.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteProduct.Location = New System.Drawing.Point(421, 276)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(81, 24)
        Me.btnDeleteProduct.TabIndex = 1
        Me.btnDeleteProduct.Text = "DELETE"
        Me.btnDeleteProduct.UseVisualStyleBackColor = False
        '
        'btnEditProduct
        '
        Me.btnEditProduct.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditProduct.FlatAppearance.BorderSize = 0
        Me.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProduct.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditProduct.Location = New System.Drawing.Point(507, 276)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Size = New System.Drawing.Size(81, 24)
        Me.btnEditProduct.TabIndex = 1
        Me.btnEditProduct.Text = "EDIT"
        Me.btnEditProduct.UseVisualStyleBackColor = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddProduct.FlatAppearance.BorderSize = 0
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddProduct.Location = New System.Drawing.Point(594, 276)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(81, 24)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "ADD NEW"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'dgvProducts
        '
        Me.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.ProductName, Me.ProductDescription, Me.ProductUnit, Me.ProductStock, Me.ProductSellPrice, Me.ProductPurchasePrice, Me.ProductSupplierID, Me.ProductSupplier})
        Me.dgvProducts.Location = New System.Drawing.Point(5, 3)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 25
        Me.dgvProducts.Size = New System.Drawing.Size(673, 264)
        Me.dgvProducts.TabIndex = 0
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "ID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Visible = False
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Name"
        Me.ProductName.Name = "ProductName"
        '
        'ProductDescription
        '
        Me.ProductDescription.HeaderText = "Description"
        Me.ProductDescription.Name = "ProductDescription"
        '
        'ProductUnit
        '
        Me.ProductUnit.HeaderText = "Unit"
        Me.ProductUnit.Name = "ProductUnit"
        '
        'ProductStock
        '
        Me.ProductStock.HeaderText = "Stock"
        Me.ProductStock.Name = "ProductStock"
        '
        'ProductSellPrice
        '
        Me.ProductSellPrice.HeaderText = "Sell Price"
        Me.ProductSellPrice.Name = "ProductSellPrice"
        '
        'ProductPurchasePrice
        '
        Me.ProductPurchasePrice.HeaderText = "Purchase Price"
        Me.ProductPurchasePrice.Name = "ProductPurchasePrice"
        '
        'ProductSupplierID
        '
        Me.ProductSupplierID.HeaderText = "Supplier ID"
        Me.ProductSupplierID.Name = "ProductSupplierID"
        Me.ProductSupplierID.Visible = False
        '
        'ProductSupplier
        '
        Me.ProductSupplier.HeaderText = "Supplier"
        Me.ProductSupplier.Name = "ProductSupplier"
        '
        'TabCustomer
        '
        Me.TabCustomer.Location = New System.Drawing.Point(4, 22)
        Me.TabCustomer.Name = "TabCustomer"
        Me.TabCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCustomer.Size = New System.Drawing.Size(679, 309)
        Me.TabCustomer.TabIndex = 2
        Me.TabCustomer.Text = "Customer"
        Me.TabCustomer.UseVisualStyleBackColor = True
        '
        'TabSupplier
        '
        Me.TabSupplier.Controls.Add(Me.btnDeleteSupplier)
        Me.TabSupplier.Controls.Add(Me.btnEditSupplier)
        Me.TabSupplier.Controls.Add(Me.btnAddSupplier)
        Me.TabSupplier.Controls.Add(Me.dgvSuppliers)
        Me.TabSupplier.Location = New System.Drawing.Point(4, 22)
        Me.TabSupplier.Name = "TabSupplier"
        Me.TabSupplier.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSupplier.Size = New System.Drawing.Size(679, 309)
        Me.TabSupplier.TabIndex = 3
        Me.TabSupplier.Text = "Supplier"
        Me.TabSupplier.UseVisualStyleBackColor = True
        '
        'TabAdmin
        '
        Me.TabAdmin.Location = New System.Drawing.Point(4, 22)
        Me.TabAdmin.Name = "TabAdmin"
        Me.TabAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAdmin.Size = New System.Drawing.Size(679, 309)
        Me.TabAdmin.TabIndex = 4
        Me.TabAdmin.Text = "Admin"
        Me.TabAdmin.UseVisualStyleBackColor = True
        '
        'TabRole
        '
        Me.TabRole.Controls.Add(Me.btnDeleteRole)
        Me.TabRole.Controls.Add(Me.btnEditRole)
        Me.TabRole.Controls.Add(Me.btnAddRole)
        Me.TabRole.Controls.Add(Me.dgvRoles)
        Me.TabRole.Location = New System.Drawing.Point(4, 22)
        Me.TabRole.Name = "TabRole"
        Me.TabRole.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRole.Size = New System.Drawing.Size(679, 309)
        Me.TabRole.TabIndex = 5
        Me.TabRole.Text = "Role"
        Me.TabRole.UseVisualStyleBackColor = True
        '
        'btnDeleteRole
        '
        Me.btnDeleteRole.BackColor = System.Drawing.Color.DarkRed
        Me.btnDeleteRole.FlatAppearance.BorderSize = 0
        Me.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRole.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteRole.Location = New System.Drawing.Point(421, 280)
        Me.btnDeleteRole.Name = "btnDeleteRole"
        Me.btnDeleteRole.Size = New System.Drawing.Size(81, 24)
        Me.btnDeleteRole.TabIndex = 2
        Me.btnDeleteRole.Text = "DELETE"
        Me.btnDeleteRole.UseVisualStyleBackColor = False
        '
        'btnEditRole
        '
        Me.btnEditRole.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditRole.FlatAppearance.BorderSize = 0
        Me.btnEditRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRole.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditRole.Location = New System.Drawing.Point(507, 280)
        Me.btnEditRole.Name = "btnEditRole"
        Me.btnEditRole.Size = New System.Drawing.Size(81, 24)
        Me.btnEditRole.TabIndex = 3
        Me.btnEditRole.Text = "EDIT"
        Me.btnEditRole.UseVisualStyleBackColor = False
        '
        'btnAddRole
        '
        Me.btnAddRole.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddRole.FlatAppearance.BorderSize = 0
        Me.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRole.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddRole.Location = New System.Drawing.Point(594, 280)
        Me.btnAddRole.Name = "btnAddRole"
        Me.btnAddRole.Size = New System.Drawing.Size(81, 24)
        Me.btnAddRole.TabIndex = 4
        Me.btnAddRole.Text = "ADD NEW"
        Me.btnAddRole.UseVisualStyleBackColor = False
        '
        'dgvRoles
        '
        Me.dgvRoles.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoleID, Me.RoleName, Me.RoleAccess})
        Me.dgvRoles.Location = New System.Drawing.Point(5, 5)
        Me.dgvRoles.Name = "dgvRoles"
        Me.dgvRoles.RowTemplate.Height = 25
        Me.dgvRoles.Size = New System.Drawing.Size(670, 270)
        Me.dgvRoles.TabIndex = 1
        '
        'RoleID
        '
        Me.RoleID.HeaderText = "ID"
        Me.RoleID.Name = "RoleID"
        Me.RoleID.Visible = False
        '
        'RoleName
        '
        Me.RoleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoleName.HeaderText = "Name"
        Me.RoleName.Name = "RoleName"
        '
        'RoleAccess
        '
        Me.RoleAccess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoleAccess.FillWeight = 200.0!
        Me.RoleAccess.HeaderText = "Access"
        Me.RoleAccess.Name = "RoleAccess"
        '
        'TabVoucher
        '
        Me.TabVoucher.Location = New System.Drawing.Point(4, 22)
        Me.TabVoucher.Name = "TabVoucher"
        Me.TabVoucher.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVoucher.Size = New System.Drawing.Size(679, 309)
        Me.TabVoucher.TabIndex = 6
        Me.TabVoucher.Text = "Voucher"
        Me.TabVoucher.UseVisualStyleBackColor = True
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierID, Me.SupplierName, Me.SupplierPhone, Me.SupplierEmail, Me.SupplierAddress})
        Me.dgvSuppliers.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvSuppliers.Location = New System.Drawing.Point(4, 3)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.Size = New System.Drawing.Size(672, 268)
        Me.dgvSuppliers.TabIndex = 0
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.BackColor = System.Drawing.Color.DarkRed
        Me.btnDeleteSupplier.FlatAppearance.BorderSize = 0
        Me.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSupplier.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(419, 277)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(81, 24)
        Me.btnDeleteSupplier.TabIndex = 5
        Me.btnDeleteSupplier.Text = "DELETE"
        Me.btnDeleteSupplier.UseVisualStyleBackColor = False
        '
        'btnEditSupplier
        '
        Me.btnEditSupplier.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditSupplier.FlatAppearance.BorderSize = 0
        Me.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSupplier.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEditSupplier.Location = New System.Drawing.Point(505, 277)
        Me.btnEditSupplier.Name = "btnEditSupplier"
        Me.btnEditSupplier.Size = New System.Drawing.Size(81, 24)
        Me.btnEditSupplier.TabIndex = 6
        Me.btnEditSupplier.Text = "EDIT"
        Me.btnEditSupplier.UseVisualStyleBackColor = False
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddSupplier.FlatAppearance.BorderSize = 0
        Me.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddSupplier.Location = New System.Drawing.Point(592, 277)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(81, 24)
        Me.btnAddSupplier.TabIndex = 7
        Me.btnAddSupplier.Text = "ADD NEW"
        Me.btnAddSupplier.UseVisualStyleBackColor = False
        '
        'SupplierID
        '
        Me.SupplierID.HeaderText = "ID"
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.Visible = False
        '
        'SupplierName
        '
        Me.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierName.HeaderText = "Name"
        Me.SupplierName.Name = "SupplierName"
        '
        'SupplierPhone
        '
        Me.SupplierPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierPhone.HeaderText = "Phone"
        Me.SupplierPhone.Name = "SupplierPhone"
        '
        'SupplierEmail
        '
        Me.SupplierEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierEmail.HeaderText = "Email"
        Me.SupplierEmail.Name = "SupplierEmail"
        '
        'SupplierAddress
        '
        Me.SupplierAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SupplierAddress.FillWeight = 200.0!
        Me.SupplierAddress.HeaderText = "Address"
        Me.SupplierAddress.Name = "SupplierAddress"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 402)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.Tabs.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TabHome.PerformLayout()
        Me.TabProduct.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSupplier.ResumeLayout(False)
        Me.TabRole.ResumeLayout(False)
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Tabs As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabProduct As TabPage
    Friend WithEvents TabCustomer As TabPage
    Friend WithEvents TabSupplier As TabPage
    Friend WithEvents TabAdmin As TabPage
    Friend WithEvents TabRole As TabPage
    Friend WithEvents TabVoucher As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents labelGreeting As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnVoucher As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnRoles As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescription As DataGridViewTextBoxColumn
    Friend WithEvents ProductUnit As DataGridViewTextBoxColumn
    Friend WithEvents ProductStock As DataGridViewTextBoxColumn
    Friend WithEvents ProductSellPrice As DataGridViewTextBoxColumn
    Friend WithEvents ProductPurchasePrice As DataGridViewTextBoxColumn
    Friend WithEvents ProductSupplierID As DataGridViewTextBoxColumn
    Friend WithEvents ProductSupplier As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnEditProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents dgvRoles As DataGridView
    Friend WithEvents RoleID As DataGridViewTextBoxColumn
    Friend WithEvents RoleName As DataGridViewTextBoxColumn
    Friend WithEvents RoleAccess As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteRole As Button
    Friend WithEvents btnEditRole As Button
    Friend WithEvents btnAddRole As Button
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents btnDeleteSupplier As Button
    Friend WithEvents btnEditSupplier As Button
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents SupplierID As DataGridViewTextBoxColumn
    Friend WithEvents SupplierName As DataGridViewTextBoxColumn
    Friend WithEvents SupplierPhone As DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmail As DataGridViewTextBoxColumn
    Friend WithEvents SupplierAddress As DataGridViewTextBoxColumn
End Class
