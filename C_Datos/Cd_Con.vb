Imports Finisar.SQLite
Imports System.Configuration
Public Class Cd_Con
    Dim Conexion As Finisar.SQLite.SQLiteConnection
    Public Function Conectar() As Finisar.SQLite.SQLiteConnection
        Conexion = New Finisar.SQLite.SQLiteConnection(ConfigurationManager.ConnectionStrings("Cn").ConnectionString)
        Return Conexion
    End Function
End Class
