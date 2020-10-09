Imports Datos
Imports Persistencia

Public Class ControladorCampeones
    ' <>
    Public Shared Property instance As New ControladorCampeones
    Private controladorBD As New ControladorBD()

    Private Sub New()
    End Sub

    Public Function buscarPorNombre(nombre As String) As Campeon
        ' llamar a la Persistencia y consultar datos de campeón a partir del nombre
        If nombre.Length = 0 Then Throw New Exception("Debe ingresar un nombre")

        Return controladorBD.obtenerCampeonPorNombre(nombre)

    End Function

    Public Sub agregarCampeon(campeon As Campeon)

        If campeon.nombre.Length = 0 Or IsNothing(campeon.fuerza) Or IsNothing(campeon.destreza) Or IsNothing(campeon.inteligencia) Or IsNothing(campeon.resistencia) Then
            Throw New Exception("Datos incompletos")
        End If

        If campeon.fuerza > 10 Or campeon.fuerza < 1 Or campeon.destreza > 10 Or
            campeon.destreza < 1 Or campeon.inteligencia > 10 Or campeon.inteligencia < 1 Or
            campeon.resistencia > 10 Or campeon.resistencia < 1 Then
            Dim errores As String = ""
            If campeon.fuerza > 10 Then errores += ("La fuerza debe tener un valor menor a 10" & vbCrLf)
            If campeon.fuerza < 1 Then errores += ("La fuerza debe tener un valor mayor a 1" & vbCrLf)
            If campeon.destreza > 10 Then errores += ("La destreza debe tener un valor menor a 10" & vbCrLf)
            If campeon.destreza < 1 Then errores += ("La destreza debe tener un valor mayor a 1" & vbCrLf)
            If campeon.inteligencia > 10 Then errores += ("La inteligencia debe tener un valor menor a 10" & vbCrLf)
            If campeon.inteligencia < 1 Then errores += ("La inteligencia debe tener un valor mayor a 1" & vbCrLf)
            If campeon.resistencia > 10 Then errores += ("La resistencia debe tener un valor menor a 10" & vbCrLf)
            If campeon.resistencia < 1 Then errores += ("La resistencia debe tener un valor mayor a 1" & vbCrLf)

            Throw New Exception(errores)

        End If

        controladorBD.agregarCampeon(campeon)

    End Sub

    Public Sub eliminarCampeon(nombreCampeon As String)
        ' busca el campeon en la base de datos
        ' caso de encontrarlo, mandamos el objeto a ControadorBD para darlo de baja.
        Dim campeonBaja As Campeon = controladorBD.obtenerCampeonPorNombre(nombreCampeon)

        If IsNothing(campeonBaja) Then
            Throw New Exception("No se encontró el Campeón en el Sistema")
        Else
            controladorBD.eliminarCampeon(campeonBaja)
        End If

    End Sub

    Public Sub modificarCampeon(campeon As Campeon)

        If campeon.nombre.Length = 0 Or IsNothing(campeon.fuerza) Or IsNothing(campeon.destreza) Or IsNothing(campeon.inteligencia) Or IsNothing(campeon.resistencia) Then
            Throw New Exception("Datos incompletos")
        End If

        controladorBD.modificarCampeon(campeon)
    End Sub

    Public Function ObtenerTodosLosCampeones() As List(Of Campeon)
        Return controladorBD.obtenerTodosLosCampeones()
    End Function

End Class
