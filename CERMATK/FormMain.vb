Imports System.Data.SqlClient

Public Class FormMain
    Public Sub ShowWithRoleID(id As String)
        Try
            DBConnection.Open()

            SqlQuery = "SELECT Access FROM Role WHERE ID = '" & id & "'"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()

            If DataReader.HasRows Then
                DataReader.Read()
                Dim access = DataReader.Item("Access").ToString()

                ShowUIByAccess(access)
            End If
        Catch ex As Exception
            MsgBox("Couldn't get role information: " & ex.Message)
        Finally
            DBConnection.Close()
        End Try

        Show()
    End Sub

    Private Sub ShowUIByAccess(access As String)

    End Sub

    Friend Sub ReloadRolesTable()
        Try
            DBConnection.Open()

            SqlQuery = "SELECT ID, Name, Access FROM Role WHERE DeletedAt IS NULL ORDER BY CreatedAt DESC"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()

            dgvRoles.Rows.Clear()
            If DataReader.HasRows Then
                While DataReader.Read()
                    dgvRoles.Rows.Add(New String() {
                        DataReader.Item("ID").ToString(),
                        DataReader.Item("Name").ToString(),
                        DataReader.Item("Access").ToString()
                    })
                End While
            End If
        Catch ex As Exception
            MsgBox("Failed to fetch data into table: " & ex.Message)
        Finally
            DBConnection.Close()
        End Try
    End Sub

    Private Sub DeleteRoles(ids As String())
        Try
            DBConnection.Open()

            For Each id As String In ids
                SqlQuery = "UPDATE Role SET DeletedAt = GETDATE() WHERE ID='" + id + "'"
                Command = New SqlCommand(SqlQuery, DBConnection.Connection)

                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Failed to perform DELETE Operation: " & ex.Message)
        Finally
            DBConnection.Close()
        End Try
    End Sub

    Private Sub Tabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabs.SelectedIndexChanged
        Select Case Tabs.SelectedIndex
            Case Tabs.TabPages.IndexOf(TabRole)
                ReloadRolesTable()
                Exit Select
        End Select
    End Sub

    Private Sub btnAddRole_Click(sender As Object, e As EventArgs) Handles btnAddRole.Click
        FormRole.Add()
    End Sub

    Private Sub btnEditRole_Click(sender As Object, e As EventArgs) Handles btnEditRole.Click
        If dgvRoles.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow = dgvRoles.SelectedRows.Item(0)

            FormRole.Edit(selectedRow.Cells.Item("RoleID").Value)
        Else
            MsgBox("Please select exactly one row", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub btnDeleteRole_Click(sender As Object, e As EventArgs) Handles btnDeleteRole.Click
        If dgvRoles.SelectedRows.Count > 0 Then
            Dim ids(dgvRoles.SelectedRows.Count - 1) As String

            For index As Integer = 0 To dgvRoles.SelectedRows.Count - 1
                ids(index) = dgvRoles.SelectedRows.Item(index).Cells.Item("RoleID").Value
            Next

            Dim answer As Integer = MsgBox("Are you sure to delete these rows?", vbQuestion & vbYesNoCancel)
            If answer = vbYes Then
                DeleteRoles(ids)
                ReloadRolesTable()
            End If
        End If
    End Sub
End Class