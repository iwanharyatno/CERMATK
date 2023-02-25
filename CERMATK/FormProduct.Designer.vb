<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduct
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
        Me.FieldName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FieldDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FieldUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FieldStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FieldPurchasePrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FieldSellPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboSupplier = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'FieldName
        '
        Me.FieldName.Location = New System.Drawing.Point(10, 40)
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Size = New System.Drawing.Size(313, 20)
        Me.FieldName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description"
        '
        'FieldDescription
        '
        Me.FieldDescription.Location = New System.Drawing.Point(10, 94)
        Me.FieldDescription.Multiline = True
        Me.FieldDescription.Name = "FieldDescription"
        Me.FieldDescription.Size = New System.Drawing.Size(313, 64)
        Me.FieldDescription.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unit"
        '
        'FieldUnit
        '
        Me.FieldUnit.Location = New System.Drawing.Point(10, 191)
        Me.FieldUnit.Name = "FieldUnit"
        Me.FieldUnit.Size = New System.Drawing.Size(313, 20)
        Me.FieldUnit.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock"
        '
        'FieldStock
        '
        Me.FieldStock.Location = New System.Drawing.Point(10, 248)
        Me.FieldStock.Name = "FieldStock"
        Me.FieldStock.Size = New System.Drawing.Size(313, 20)
        Me.FieldStock.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Purchase Price"
        '
        'FieldPurchasePrice
        '
        Me.FieldPurchasePrice.Location = New System.Drawing.Point(10, 305)
        Me.FieldPurchasePrice.Name = "FieldPurchasePrice"
        Me.FieldPurchasePrice.Size = New System.Drawing.Size(141, 20)
        Me.FieldPurchasePrice.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sell Price"
        '
        'FieldSellPrice
        '
        Me.FieldSellPrice.Location = New System.Drawing.Point(182, 305)
        Me.FieldSellPrice.Name = "FieldSellPrice"
        Me.FieldSellPrice.Size = New System.Drawing.Size(141, 20)
        Me.FieldSellPrice.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Supplier"
        '
        'ComboSupplier
        '
        Me.ComboSupplier.FormattingEnabled = True
        Me.ComboSupplier.Location = New System.Drawing.Point(10, 369)
        Me.ComboSupplier.Name = "ComboSupplier"
        Me.ComboSupplier.Size = New System.Drawing.Size(313, 21)
        Me.ComboSupplier.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(10, 417)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 28)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.Location = New System.Drawing.Point(231, 417)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 28)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FormProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 455)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ComboSupplier)
        Me.Controls.Add(Me.FieldSellPrice)
        Me.Controls.Add(Me.FieldPurchasePrice)
        Me.Controls.Add(Me.FieldStock)
        Me.Controls.Add(Me.FieldUnit)
        Me.Controls.Add(Me.FieldDescription)
        Me.Controls.Add(Me.FieldName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormProduct"
        Me.Text = "FormProduc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FieldName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FieldDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FieldUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FieldStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FieldPurchasePrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FieldSellPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboSupplier As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
