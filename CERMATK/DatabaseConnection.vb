Imports System.Data.SqlClient

Public Class DatabaseConnection
    Public ReadOnly Connection As New SqlConnection(My.Settings.DBConnectionString)

    Public Sub Open()
        If ConnectionState.Closed Then
            Connection.Open()
        Else
            Connection.Close()
            Connection.Open()
        End If
    End Sub

    Public Sub Close()
        Connection.Close()
    End Sub
End Class
