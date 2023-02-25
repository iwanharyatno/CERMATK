Imports System.Data.SqlClient

Public Class FormLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide()
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            DBConnection.Open()

            Dim username As String = FieldUsername.Text
            Dim password As String = FieldPassword.Text

            SqlQuery = "SELECT ID, Name, Password, RoleID FROM Admin WHERE Username = '" & username & "'"
            Command = New SqlCommand(SqlQuery, DBConnection.Connection)

            DataReader = Command.ExecuteReader()

            If DataReader.HasRows Then
                If DataReader.Read() Then
                    If password = DataReader.Item("Password") Then
                        MsgBox("Login Succeed! Hello " & DataReader.Item("Name"), vbInformation, "Info")

                        AdminID = DataReader.Item("ID").ToString()
                        FormMain.ShowWithRoleID(DataReader.Item("RoleID").ToString())
                        Hide()
                    Else
                        MsgBox("Password doesn't match!", vbOKOnly, "Error")
                    End If
                End If
            Else
                MsgBox("Admin with username '" & username & "' not found")
            End If
        Catch ex As Exception
            MsgBox("Could not perform the login operation: " & ex.Message, vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub CBShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CBShowPassword.CheckedChanged
        If CBShowPassword.Checked Then
            FieldPassword.PasswordChar = ""
        Else
            FieldPassword.PasswordChar = "•"
        End If
    End Sub
End Class
