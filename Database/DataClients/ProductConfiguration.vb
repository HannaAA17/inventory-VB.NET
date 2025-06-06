' Product configuration
Imports inventory.Models
Imports System.Data.SQLite

Namespace DataClients
    Public Class ProductConfiguration
        Implements IModelConfiguration(Of Product)

        Public ReadOnly Property TableName As String Implements IModelConfiguration(Of Product).TableName
            Get
                Return "Products"
            End Get
        End Property

        Public Function MapFromReader(reader As SQLiteDataReader) As Product Implements IModelConfiguration(Of Product).MapFromReader
            ' Get ordinals once for better performance
            Dim idOrdinal = reader.GetOrdinal("Id")
            Dim nameOrdinal = reader.GetOrdinal("Name")
            Dim codeOrdinal = reader.GetOrdinal("Code")
            Dim uomOrdinal = reader.GetOrdinal("UOM")

            Return New Product With {
            .Id = reader.GetInt32(idOrdinal),
            .Name = If(reader.IsDBNull(nameOrdinal), String.Empty, reader.GetString(nameOrdinal)),
            .Code = If(reader.IsDBNull(codeOrdinal), String.Empty, reader.GetString(codeOrdinal)),
            .UOM = If(reader.IsDBNull(uomOrdinal), String.Empty, reader.GetString(uomOrdinal))
        }
        End Function

        Public Function GetInsertSql() As String Implements IModelConfiguration(Of Product).GetInsertSql
            Return "INSERT INTO Products (Name, Code, UOM) VALUES (@Name, @Code, @UOM)"
        End Function

        Public Function GetUpdateSql() As String Implements IModelConfiguration(Of Product).GetUpdateSql
            Return "UPDATE Products SET Name=@Name, Code=@Code, UOM=@UOM WHERE Id=@Id"
        End Function

        Public Function GetSelectSql() As String Implements IModelConfiguration(Of Product).GetSelectSql
            Return "SELECT Id, Name, Code, UOM FROM Products"
        End Function

        Public Sub SetParameters(cmd As SQLiteCommand, item As Product, operation As String) Implements IModelConfiguration(Of Product).SetParameters
            cmd.Parameters.AddWithValue("@Name", If(item.Name, DBNull.Value))
            cmd.Parameters.AddWithValue("@Code", If(item.Code, DBNull.Value))
            cmd.Parameters.AddWithValue("@UOM", If(item.UOM, DBNull.Value))

            If operation = "UPDATE" Then
                cmd.Parameters.AddWithValue("@Id", item.Id)
            End If
        End Sub
    End Class
End Namespace
