Imports ADODB
Imports Datos

Public Class ControladorBD

    Public Sub New()
    End Sub

    Public Function conectar() As Connection
        Dim connection As New Connection()
        connection.ConnectionString = "driver={MySql ODBC 8.0 Unicode Driver};" &
            "server=127.0.0.1;" &
            "port=3306;" &
            "database=[colocar nombre de BD];" &
            "uid=root;" &
            "pwd=;"  ' null
        connection.Open()
        Return connection
    End Function

    Public Function obtenerCampeon(nombre) As Campeon
        Return Nothing
    End Function

    Public Sub agregarCampeon(campeonAlta As Campeon)

    End Sub

    Public Sub modificarCampeon(campeon As Campeon)

    End Sub

    Public Sub eliminarCampeon(campeonBaja As Campeon)

    End Sub


End Class
