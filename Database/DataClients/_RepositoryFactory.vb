' Repository factory implementation
Imports inventory.Models

Namespace DataClients
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

            ElseIf GetType(T) = GetType(User) Then
                Dim config = New UserConfiguration()
                Return DirectCast(New GenericRepository(Of User)(_connectionString, config), IRepository(Of T))

            End If

            ' Add more model configurations here
            ' ElseIf GetType(T) = GetType(Customer) Then
            '     Dim config = New CustomerConfiguration()
            '     Return DirectCast(New GenericRepository(Of Customer)(_connectionString, config), IRepository(Of T))

            Throw New NotSupportedException($"Repository for type {GetType(T).Name} is not configured")
        End Function
    End Class
End Namespace