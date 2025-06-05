Imports System.Data.SQLite
Imports inventory.Models

Namespace DataClients
    Public Class UserClient
        Private ReadOnly _connectionString As String = InitializeDatabase()

        Public Sub Create(user As User)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "INSERT INTO Users (Name, Email, Phone) VALUES (@Name, @Email, @Phone)"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", user.Name)
                    cmd.Parameters.AddWithValue("@Email", user.Email)
                    cmd.Parameters.AddWithValue("@Phone", user.Phone)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Function ReadAll() As List(Of User)
            Dim users As New List(Of User)()
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "SELECT * FROM Users"
                Using cmd As New SQLiteCommand(sql, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            users.Add(New User With {
                                .Id = reader.GetInt32(0),
                                .Name = reader.GetString(1),
                                .Email = reader.GetString(2),
                                .Phone = reader.GetString(3)
                            })
                        End While
                    End Using
                End Using
            End Using
            Return users
        End Function

        Public Sub Update(user As User)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "UPDATE Users SET Name=@Name, Email=@Email, Phone=@Phone WHERE Id=@Id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", user.Name)
                    cmd.Parameters.AddWithValue("@Email", user.Email)
                    cmd.Parameters.AddWithValue("@Phone", user.Phone)
                    cmd.Parameters.AddWithValue("@Id", user.Id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(id As Integer)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = "DELETE FROM Users WHERE Id=@Id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub
    End Class
End Namespace
