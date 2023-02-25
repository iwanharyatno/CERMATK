Imports System.Data.SqlClient

Module GlobalVariable
    Public DBConnection As New DatabaseConnection()
    Public SqlQuery As String
    Public Command As SqlCommand
    Public DataReader As SqlDataReader
    Public AdminID As String
End Module
