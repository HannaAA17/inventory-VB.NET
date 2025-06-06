Imports System.Data.SQLite
Imports System.IO

Module DatabaseHelper

    Public Function InitializeDatabase() As String

        ' Initialize database path
        Dim DbPath = Path.Combine(
            Application.StartupPath,
            "inventory",
            "appdata.db"
        )

        Dim _connectionString = $"Data Source={DbPath};Cache=Shared"

        Directory.CreateDirectory(Path.GetDirectoryName(DbPath))

        If Not File.Exists(DbPath) Then
            SQLiteConnection.CreateFile(DbPath)
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Dim sql As String = "
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        Phone TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Products (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Code TEXT NOT NULL,
                        UOM TEXT NOT NULL
                    );"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If

        Return _connectionString
    End Function
End Module
