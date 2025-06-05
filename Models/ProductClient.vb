Imports System.Data.SQLite
Imports inventory.Models

Namespace DataClients
    Public Class ProductClient
        Private ReadOnly _connectionString As String = InitializeDatabase()

        Public Sub Create(product As Product)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "INSERT INTO Products (Name, Code, UOM) VALUES (@Name, @Code, @UOM)"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", product.Name)
                    cmd.Parameters.AddWithValue("@Code", product.Code)
                    cmd.Parameters.AddWithValue("@UOM", product.UOM)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Function GetAll() As List(Of Product)
            Dim products As New List(Of Product)()
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "SELECT Id, Name, Code, UOM FROM Products"
                Using cmd As New SQLiteCommand(sql, conn)
                    Using reader = cmd.ExecuteReader()

                        Dim idOrdinal = reader.GetOrdinal("Id")
                        Dim nameOrdinal = reader.GetOrdinal("Name")
                        Dim codeOrdinal = reader.GetOrdinal("Code")
                        Dim uomOrdinal = reader.GetOrdinal("UOM")

                        While reader.Read()
                            products.Add(New Product With {
                                .Id = reader.GetInt32(idOrdinal),
                                .Name = reader.GetString(nameOrdinal),
                                .Code = reader.GetString(codeOrdinal),
                                .UOM = reader.GetString(uomOrdinal)
                            })
                        End While
                    End Using
                End Using
            End Using
            Return products
        End Function

        Public Sub Update(product As Product)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "UPDATE Products SET Name=@Name, Code=@Code, UOM=@UOM WHERE Id=@Id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", product.Name)
                    cmd.Parameters.AddWithValue("@Code", product.Code)
                    cmd.Parameters.AddWithValue("@UOM", product.UOM)
                    cmd.Parameters.AddWithValue("@Id", product.Id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(id As Integer)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "DELETE FROM Products WHERE Id=@Id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Function getBy(col As String, val As String) As Product
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "SELECT Id, Name, Code, UOM FROM Products WHERE @col=@val"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@col", col)
                    cmd.Parameters.AddWithValue("@val", val)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New Product With {
                                .Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                .Name = reader.GetString(reader.GetOrdinal("Name")),
                                .Code = reader.GetString(reader.GetOrdinal("Code")),
                                .UOM = reader.GetString(reader.GetOrdinal("UOM"))
                            }
                        End If
                    End Using
                End Using
            End Using
            Return Nothing
        End Function

    End Class
End Namespace
