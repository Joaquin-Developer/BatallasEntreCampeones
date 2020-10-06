Imports Datos
Imports Persistencia

Public Class ControladorCampeones
    ' <>
    Public Shared Property instance As New ControladorCampeones
    Private Property listaCampeones As New List(Of Campeon)

    Private Sub New()
    End Sub

    Public Function buscarPorNombre(nombre As String) As Campeon
        ' llamar a la Persistencia y consultar datos de campeón a partir del nombre
        If nombre.Length = 0 Then Throw New Exception("Debe ingresar un nombre")
        actualizarListaCampeones()
        Dim campeon As New Campeon()

        For Each camp As Campeon In listaCampeones
            If camp.nombre = nombre Then
                campeon = camp
                Exit For
            End If
        Next
        Return campeon
    End Function

    Public Sub actualizarListaCampeones()
        ' procedimiento que actualiza la lista local de Campeones
        Try
            Dim controladorBD As New ControladorBD()
            listaCampeones.Clear()
            listaCampeones = controladorBD.obtenerTodosLosCampeones()
            'If listaCampeones.Count = 0 Then Throw New Exception("No se encontraron Campeones en la base de datos.")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw ex
        End Try
    End Sub

    Public Function getListaCampeones() As List(Of Campeon)
        Try
            actualizarListaCampeones() ' actualizo lista antes de retornarla
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw ex
        End Try
        Return listaCampeones
    End Function

    Public Sub agregarCampeon(campeon As Campeon)
        Try
            Dim controladorBD As New ControladorBD()
            If campeon.nombre.Length = 0 Or IsNothing(campeon.fuerza) Or IsNothing(campeon.destreza) Or IsNothing(campeon.inteligencia) Or IsNothing(campeon.resistencia) Then
                Throw New Exception("Datos incompletos")
            End If

            If campeon.fuerza > 10 Or campeon.fuerza < 1 Or campeon.destreza > 10 Or
                campeon.destreza < 1 Or campeon.inteligencia > 10 Or campeon.inteligencia < 1 Or
                campeon.resistencia > 10 Or campeon.resistencia < 1 Then

                Throw New Exception("Los Datos no son válidos.")

            End If

            controladorBD.agregarCampeon(campeon)
            actualizarListaCampeones()

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Sub eliminarCampeon(nombreCampeon As String)
        ' busca el campeon en la listaCampeones por su nombre
        ' caso de encontrarlo, mandamos el objeto a ControadorBD para darlo de baja.
        Dim campeonBaja As New Campeon()

        Try
            For Each campeon As Campeon In listaCampeones
                If campeon.nombre = nombreCampeon Then
                    campeonBaja = campeon
                    Exit For
                End If
            Next

            If IsNothing(campeonBaja) Then
                Throw New Exception("No se encontró el Campeón en el Sistema")
            Else
                Dim controladorBD As New ControladorBD()
                controladorBD.eliminarCampeon(campeonBaja)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub modificarCampeon(campeon As Campeon)
        Try

            If campeon.nombre.Length = 0 Or IsNothing(campeon.fuerza) Or IsNothing(campeon.destreza) Or IsNothing(campeon.inteligencia) Or IsNothing(campeon.resistencia) Then
                Throw New Exception("Datos incompletos")
            End If

            Dim controladorBD As New ControladorBD()
            controladorBD.modificarCampeon(campeon)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw ex
        End Try
    End Sub

End Class
