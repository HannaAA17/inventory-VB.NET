' User configuration
Imports inventory.Models
Imports System.Data.SQLite

Namespace DataClients
    Public Class UserConfiguration
        Implements IModelConfiguration(Of User)

        Public ReadOnly Property TableName As String Implements IModelConfiguration(Of User).TableName
            Get
                Return "Users"
            End Get
        End Property

        Public Function MapFromReader(reader As SQLiteDataReader) As User Implements IModelConfiguration(Of User).MapFromReader
            ' Get ordinals once for better performance
            Dim idOrdinal = reader.GetOrdinal("Id")
            Dim nameOrdinal = reader.GetOrdinal("Name")
            Dim codeOrdinal = reader.GetOrdinal("Email")
            Dim uomOrdinal = reader.GetOrdinal("phone")

            Return New User With {
            .Id = reader.GetInt32(idOrdinal),
            .Name = If(reader.IsDBNull(nameOrdinal), String.Empty, reader.GetString(nameOrdinal)),
            .Email = If(reader.IsDBNull(codeOrdinal), String.Empty, reader.GetString(codeOrdinal)),
            .Phone = If(reader.IsDBNull(uomOrdinal), String.Empty, reader.GetString(uomOrdinal))
        }
        End Function

        Public Function GetInsertSql() As String Implements IModelConfiguration(Of User).GetInsertSql
            Return "INSERT INTO Users (Name, Email, phone) VALUES (@Name, @Email, @phone)"
        End Function

        Public Function GetUpdateSql() As String Implements IModelConfiguration(Of User).GetUpdateSql
            Return "UPDATE Users SET Name=@Name, Email=@Email, phone=@phone WHERE Id=@Id"
        End Function

        Public Function GetSelectSql() As String Implements IModelConfiguration(Of User).GetSelectSql
            Return "SELECT Id, Name, Email, phone FROM Users"
        End Function

        Public Sub SetParameters(cmd As SQLiteCommand, item As User, operation As String) Implements IModelConfiguration(Of User).SetParameters
            cmd.Parameters.AddWithValue("@Name", If(item.Name, DBNull.Value))
            cmd.Parameters.AddWithValue("@Email", If(item.Email, DBNull.Value))
            cmd.Parameters.AddWithValue("@phone", If(item.Phone, DBNull.Value))

            If operation = "UPDATE" Then
                cmd.Parameters.AddWithValue("@Id", item.Id)
            End If
        End Sub
    End Class
End Namespace
