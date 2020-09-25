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
            "database=BatallasEntreCampeones;" &
            "uid=root;" &
            "pwd=;"  ' null
        connection.Open()
        Return connection
    End Function

    Public Function obtenerTodosLosCampeones() As List(Of Campeon)
        Dim conexion As Connection = conectar()
        Dim listaCampeones As New List(Of Campeon)
        Try
            Dim rs As Recordset = conexion.Execute("select * from Campeones where nombre='" & nombre & "'")

            While (Not rs.EOF)
                Dim campeon As New Campeon()
                campeon.id = DirectCast(rs.Fields("id").Value, Integer)
                campeon.nombre = TryCast(rs.Fields("nombre").Value, String)
                campeon.fuerza = DirectCast(rs.Fields("fuerza").Value, Integer)
                campeon.destreza = DirectCast(rs.Fields("destreza").Value, Integer)
                campeon.inteligencia = DirectCast(rs.Fields("inteligencia").Value, Integer)
                campeon.resistencia = DirectCast(rs.Fields("resistencia").Value, Integer)
                listaCampeones.Add(campeon)
                rs.MoveNext()
            End While

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try

        Return listaCampeones
    End Function

    Public Function obtenerCampeonPorNombre(nombre) As Campeon
        Dim conexion As Connection = conectar()
        Dim campeon As New Campeon()
        Try
            Dim rs As Recordset = conexion.Execute("select * from Campeones where nombre='" & nombre & "'")
            campeon.id = DirectCast(rs.Fields("id").Value, Integer)
            campeon.nombre = TryCast(rs.Fields("nombre").Value, String)
            campeon.fuerza = DirectCast(rs.Fields("fuerza").Value, Integer)
            campeon.destreza = DirectCast(rs.Fields("destreza").Value, Integer)
            campeon.inteligencia = DirectCast(rs.Fields("inteligencia").Value, Integer)
            campeon.resistencia = DirectCast(rs.Fields("resistencia").Value, Integer)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try

        Return campeon

    End Function

    Public Sub agregarCampeon(campeonAlta As Campeon)

    End Sub

    Public Sub modificarCampeon(campeon As Campeon)

    End Sub

    Public Sub eliminarCampeon(campeonBaja As Campeon)

    End Sub


End Class
