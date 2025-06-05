Imports System.Data.SQLite
Imports inventory.Models


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

    ' Product configuration
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

    ' Repository factory implementation
    Public Class RepositoryFactory
        Implements IRepositoryFactory

        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub

        Public Function CreateRepository(Of T As {Class, New})() As IRepository(Of T) Implements IRepositoryFactory.CreateRepository
            ' You would register configurations here or use dependency injection
            If GetType(T) = GetType(Product) Then
                Dim config = New ProductConfiguration()
                Return DirectCast(New GenericRepository(Of Product)(_connectionString, config), IRepository(Of T))
            End If

            ' Add more model configurations here
            ' ElseIf GetType(T) = GetType(Customer) Then
            '     Dim config = New CustomerConfiguration()
            '     Return DirectCast(New GenericRepository(Of Customer)(_connectionString, config), IRepository(Of T))

            Throw New NotSupportedException($"Repository for type {GetType(T).Name} is not configured")
        End Function
    End Class

End Namespace