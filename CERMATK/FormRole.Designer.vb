<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRole
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
        Me.CBAccessMaster = New System.Windows.Forms.CheckBox()
        Me.CBAccessTransaction = New System.Windows.Forms.CheckBox()
        Me.CBAccessPurchase = New System.Windows.Forms.CheckBox()
        Me.CBAccessReport = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'FieldName
        '
        Me.FieldName.Location = New System.Drawing.Point(12, 43)
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Size = New System.Drawing.Size(281, 23)
        Me.FieldName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Access"
        '
        'CBAccessMaster
        '
        Me.CBAccessMaster.AutoSize = True
        Me.CBAccessMaster.Location = New System.Drawing.Point(12, 111)
        Me.CBAccessMaster.Name = "CBAccessMaster"
        Me.CBAccessMaster.Size = New System.Drawing.Size(89, 19)
        Me.CBAccessMaster.TabIndex = 2
        Me.CBAccessMaster.Text = "Master Data"
        Me.CBAccessMaster.UseVisualStyleBackColor = True
        '
        'CBAccessTransaction
        '
        Me.CBAccessTransaction.AutoSize = True
        Me.CBAccessTransaction.Location = New System.Drawing.Point(12, 136)
        Me.CBAccessTransaction.Name = "CBAccessTransaction"
        Me.CBAccessTransaction.Size = New System.Drawing.Size(141, 19)
        Me.CBAccessTransaction.TabIndex = 2
        Me.CBAccessTransaction.Text = "Customer Transaction"
        Me.CBAccessTransaction.UseVisualStyleBackColor = True
        '
        'CBAccessPurchase
        '
        Me.CBAccessPurchase.AutoSize = True
        Me.CBAccessPurchase.Location = New System.Drawing.Point(12, 161)
        Me.CBAccessPurchase.Name = "CBAccessPurchase"
        Me.CBAccessPurchase.Size = New System.Drawing.Size(119, 19)
        Me.CBAccessPurchase.TabIndex = 2
        Me.CBAccessPurchase.Text = "Product Purchase"
        Me.CBAccessPurchase.UseVisualStyleBackColor = True
        '
        'CBAccessReport
        '
        Me.CBAccessReport.AutoSize = True
        Me.CBAccessReport.Location = New System.Drawing.Point(12, 186)
        Me.CBAccessReport.Name = "CBAccessReport"
        Me.CBAccessReport.Size = New System.Drawing.Size(105, 19)
        Me.CBAccessReport.TabIndex = 2
        Me.CBAccessReport.Text = "Finance Report"
        Me.CBAccessReport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(12, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 31)
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
        Me.btnSave.Location = New System.Drawing.Point(188, 238)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FormRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 281)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.CBAccessReport)
        Me.Controls.Add(Me.CBAccessPurchase)
        Me.Controls.Add(Me.CBAccessTransaction)
        Me.Controls.Add(Me.CBAccessMaster)
        Me.Controls.Add(Me.FieldName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormRole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FieldName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBAccessMaster As CheckBox
    Friend WithEvents CBAccessTransaction As CheckBox
    Friend WithEvents CBAccessPurchase As CheckBox
    Friend WithEvents CBAccessReport As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
