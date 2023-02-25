Imports System.Data.SqlClient

Public Class FormRole
    Public ReadOnly ACCESS_DATA_MASTER As String = "Data Master"
    Public ReadOnly ACCESS_PURCHASE As String = "Purchase"
    Public ReadOnly ACCESS_REPORT As String = "Report"
    Public ReadOnly ACCESS_TRANSACTION As String = "Transaction"

    Private editMode As Boolean = False
    Private editId As String = ""

    Private Function IsInputValid()
        If FieldName.Text.Equals("") Then
            MsgBox("The 'name' field is Required", vbOKOnly, "Error")
            Return False
        End If

        If Not (CBAccessMaster.Checked Or CBAccessPurchase.Checked Or CBAccessReport.Checked Or CBAccessTransaction.Checked) Then
            MsgBox("Please select at least one access", vbOKOnly, "Error")
            Return False
        End If

        Return True
    End Function

    Friend Sub Add()
        editMode = False
        editId = ""

        Clear()
        Show()
    End Sub

    Friend Sub Edit(id As String)
        editMode = True
        editId = id

        Clear()

        Try
            DBConnection.Open()

            SqlQuery = "SELECT Name, Access FROM Role WHERE ID='" + editId + "'"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()

            If DataReader.HasRows Then
                DataReader.Read()
                FieldName.Text = DataReader.Item("Name")
                CheckBoxesBasedOnAccess(DataReader.Item("Access"))
            End If
        Catch ex As Exception
            MsgBox("Failed to get role information: " & ex.Message)
        Finally
            DBConnection.Close()
        End Try

        Show()
    End Sub

    Private Sub Clear()
        CBAccessMaster.Checked = False
        CBAccessPurchase.Checked = False
        CBAccessReport.Checked = False
        CBAccessTransaction.Checked = False

        FieldName.Clear()
    End Sub

    Private Sub CheckBoxesBasedOnAccess(access As String)
        Dim separatedAccess As String() = access.Split(",")

        If separatedAccess.Contains(ACCESS_DATA_MASTER) Then
            CBAccessMaster.Checked = True
        End If

        If separatedAccess.Contains(ACCESS_PURCHASE) Then
            CBAccessPurchase.Checked = True
        End If

        If separatedAccess.Contains(ACCESS_REPORT) Then
            CBAccessReport.Checked = True
        End If

        If separatedAccess.Contains(ACCESS_TRANSACTION) Then
            CBAccessTransaction.Checked = True
        End If
    End Sub

    Private Function ComposeAccess()
        Dim access As New List(Of String)

        If CBAccessMaster.Checked Then
            access.Add(ACCESS_DATA_MASTER)
        End If

        If CBAccessPurchase.Checked Then
            access.Add(ACCESS_PURCHASE)
        End If

        If CBAccessReport.Checked Then
            access.Add(ACCESS_REPORT)
        End If

        If CBAccessTransaction.Checked Then
            access.Add(ACCESS_TRANSACTION)
        End If

        Return Strings.Join(access.ToArray(), ",")
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsInputValid() Then
            Dim name As String = FieldName.Text
            Dim access As String = ComposeAccess()
            Try
                DBConnection.Open()

                If Not editMode Then
                    SqlQuery = "INSERT INTO Role (ID, Name, Access, CreatedAt, UpdatedAt) VALUES (NEWID(), '" & name & "', '" & access & "', GETDATE(), GETDATE())"
                Else
                    SqlQuery = "UPDATE Role SET Name='" & name & "', Access='" & access & "', UpdatedAt=GETDATE() WHERE ID='" & editId & "'"
                End If
                Command = New SqlCommand(SqlQuery, DBConnection.Connection)

                Command.ExecuteNonQuery()

                FormMain.ReloadRolesTable()
                Hide()
            Catch ex As Exception
                MsgBox("Failed to perform INSERT Operation: " & ex.Message)
            Finally
                DBConnection.Close()
            End Try
        End If
    End Sub
End Class