Imports System.Data.SQLite

Namespace DataClients
    ' Generic repository interface
    Public Interface IRepository(Of T As {Class, New})
        Function GetAll() As List(Of T)
        Function GetById(id As Integer) As T
        Sub Create(item As T)
        Sub Update(item As T)
        Sub Delete(id As Integer)
    End Interface

    ' Repository factory interface
    Public Interface IRepositoryFactory
        Function CreateRepository(Of T As {Class, New})() As IRepository(Of T)
    End Interface

    ' Configuration interface for models
    Public Interface IModelConfiguration(Of T As {Class, New})
        ReadOnly Property TableName As String
        Function MapFromReader(reader As SQLiteDataReader) As T
        Function GetInsertSql() As String
        Function GetUpdateSql() As String
        Function GetSelectSql() As String
        Sub SetParameters(cmd As SQLiteCommand, item As T, operation As String)
    End Interface

    ' Generic repository implementation
    Public Class GenericRepository(Of T As {Class, New})
        Implements IRepository(Of T)

        Private ReadOnly _connectionString As String
        Private ReadOnly _config As IModelConfiguration(Of T)

        Public Sub New(connectionString As String, config As IModelConfiguration(Of T))
            _connectionString = connectionString
            _config = config
        End Sub

        Public Function GetAll() As List(Of T) Implements IRepository(Of T).GetAll
            Dim items As New List(Of T)()

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(_config.GetSelectSql(), conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            items.Add(_config.MapFromReader(reader))
                        End While
                    End Using
                End Using
            End Using

            Return items
        End Function

        Public Function GetById(id As Integer) As T Implements IRepository(Of T).GetById
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = _config.GetSelectSql() & " WHERE Id = @Id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return _config.MapFromReader(reader)
                        End If
                    End Using
                End Using
            End Using
            Return Nothing
        End Function

        Public Sub Create(item As T) Implements IRepository(Of T).Create
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(_config.GetInsertSql(), conn)
                    _config.SetParameters(cmd, item, "INSERT")
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Update(item As T) Implements IRepository(Of T).Update
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(_config.GetUpdateSql(), conn)
                    _config.SetParameters(cmd, item, "UPDATE")
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Delete(id As Integer) Implements IRepository(Of T).Delete
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql = $"DELETE FROM {_config.TableName} WHERE Id = @Id"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub
    End Class


End Namespace