Imports System.Data.SqlClient

Public Class FormSupplier
    Private editMode As Boolean = False
    Private editId As String = ""

    Public Sub Add()
        editMode = False
        editId = ""

        Show()
    End Sub

    Public Sub Edit(id As String)
        editMode = True
        editId = id

        Try
            DBConnection.Open()

            SqlQuery = "SELECT Name, Email, Address, Phone FROM Supplier WHERE ID='" + id + "'"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()
            If DataReader.HasRows Then
                DataReader.Read()
                FieldName.Text = DataReader.Item("Name").ToString()
                FieldPhone.Text = DataReader.Item("Phone").ToString()
                FIeldEmail.Text = DataReader.Item("Email").ToString()
                FieldAddress.Text = DataReader.Item("Address").ToString()
            End If
        Catch ex As Exception
            MsgBox("Couldn't load the supplier detail: " + ex.Message)
        Finally
            DBConnection.Close()
        End Try
    End Sub

    Private Function IsInputValid()
        If FieldName.Text.Equals("") Then
            MsgBox("The field 'name' is required")
            Return False
        End If

        If FieldPhone.Text.Equals("") Then
            MsgBox("The field 'phone' is required")
            Return False
        End If

        If FIeldEmail.Text.Equals("") Then
            MsgBox("The field 'email' is required")
            Return False
        End If

        If FieldAddress.Text.Equals("") Then
            MsgBox("The field 'address' is required")
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsInputValid() Then
            Try
                DBConnection.Open()

                If Not editMode Then
                    SqlQuery = "INSERT INTO Supplier (ID, Name, Email, Address, Phone, CreatedAt, UpdatedAt) VALUES (NEWID(), '" + FieldName.Text + "', '" + FIeldEmail.Text + "', '" + FieldAddress.Text + "', '" + FieldPhone.Text + "', GETDATE(), GETDATE())"
                Else
                    SqlQuery = "UPDATE Supplier SET Name='" + FieldName.Text + "', Email='" + FIeldEmail.Text + "', Phone='" + FieldPhone.Text + "', Address='" + FieldAddress.Text + "' WHERE ID='" + editId + "'"
                End If
                Command = New SqlCommand(SqlQuery, DBConnection.Connection)

                Command.ExecuteNonQuery()
                Hide()
                FormMain.ReloadSuppliersTable()
            Catch ex As Exception
                MsgBox("Failed to execute INSERT/UPDATE operation")
            Finally
                DBConnection.Close()
            End Try
        End If
    End Sub
End Class