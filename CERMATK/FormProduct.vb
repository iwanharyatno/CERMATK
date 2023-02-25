Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FormProduct
    Private editMode As Boolean = False
    Private editId As String

    Private Sub LoadComboData()
        Try
            DBConnection.Open()

            SqlQuery = "SELECT ID, Name FROM Supplier"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()
            Dim dataTable As New DataTable

            dataTable.Load(DataReader)

            ComboSupplier.DataSource = dataTable
            ComboSupplier.DisplayMember = "Name"
            ComboSupplier.ValueMember = "ID"
        Catch ex As Exception
            MsgBox("Failed to get supplier list: " + ex.Message)
        Finally
            DBConnection.Close()
        End Try
    End Sub

    Private Function IsInputValid()
        If FieldName.Text.Equals("") Then
            MsgBox("The field 'name' is required")
            Return False
        End If

        If FieldDescription.Text.Equals("") Then
            MsgBox("The field 'description' is required")
            Return False
        End If

        If FieldUnit.Text.Equals("") Then
            MsgBox("The field 'unit' is required")
            Return False
        End If

        If FieldStock.Text.Equals("") Then
            MsgBox("The field 'stock' is required")
            Return False
        End If

        If FieldPurchasePrice.Text.Equals("") Then
            MsgBox("The field 'purchase price' is required")
            Return False
        End If

        If FieldSellPrice.Text.Equals("") Then
            MsgBox("The field 'sell price' is required")
            Return False
        End If

        If Not Regex.IsMatch(FieldStock.Text, "^\d+$") Then
            MsgBox("The stock must be a number")
        End If

        If Not Regex.IsMatch(FieldSellPrice.Text, "^\d+$") Then
            MsgBox("The sell price must be a number")
        End If

        If Not Regex.IsMatch(FieldPurchasePrice.Text, "^\d+$") Then
            MsgBox("The purchase price must be a number")
        End If

        Return True
    End Function

    Public Sub Add()
        editMode = False
        editId = ""

        Show()
        LoadComboData()
        ComboSupplier.SelectedIndex = 0
    End Sub

    Public Sub Edit(id As String)
        editMode = True
        editId = id

        Try
            DBConnection.Open()

            SqlQuery = "SELECT Name, Description, Unit, Stock, PurchasePrice, SellPrice, SupplierID FROM Product WHERE ID='" + id + "'"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                DataReader.Read()
                FieldName.Text = DataReader.Item("Name").ToString()
                FieldDescription.Text = DataReader.Item("Description").ToString()
                FieldUnit.Text = DataReader.Item("Unit").ToString()
                FieldStock.Text = DataReader.Item("Stock").ToString()
                FieldPurchasePrice.Text = DataReader.Item("PurchasePrice").ToString()
                FieldSellPrice.Text = DataReader.Item("SellPrice").ToString()
                ComboSupplier.SelectedValue = DataReader.Item("SupplierID").ToString()
            End If
        Catch ex As Exception
            MsgBox("Couldn't load the supplier detail: " + ex.Message)
        Finally
            DBConnection.Close()
        End Try

        Show()
        LoadComboData()
        ComboSupplier.SelectedIndex = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsInputValid() Then
            Try
                DBConnection.Open()

                If Not editMode Then
                    SqlQuery = "INSERT INTO Product (ID, Name, Description, Stock, Unit, PurchasePrice, SalePrice, SupplierID, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + FieldName.Text + "', '" + FieldDescription.Text + "', '" + FieldStock.Text + "', '" + FieldUnit.Text + "', '" + FieldPurchasePrice.Text + "', '" + FieldSellPrice.Text + "', '" + ComboSupplier.SelectedValue.ToString() + "', GETDATE(), GETDATE())"
                Else
                    SqlQuery = "UPDATE Product SET Name='" + FieldName.Text + "', Description='" + FieldDescription.Text + "', Stock='" + FieldStock.Text + "', Unit'" + FieldUnit.Text + "', PurchasePrice='" + FieldPurchasePrice.Text + "', SellPrice='" + FieldSellPrice.Text + "', SupplierID='" + ComboSupplier.SelectedValue.ToString() + "', UpdatedAt=GETDATE() WHERE ID='" + editId + "'"
                End If

                Command = New SqlCommand(SqlQuery, DBConnection.Connection)
                Command.ExecuteNonQuery()

                Hide()
                FormMain.ReloadProductsTable()
            Catch ex As Exception
                MsgBox("Failed to execute INSERT/UPDATE operation: " + ex.Message)
            Finally
                DBConnection.Close()
            End Try
        End If
    End Sub
End Class