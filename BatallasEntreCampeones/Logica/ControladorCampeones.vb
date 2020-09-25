Imports Datos
Imports Persistencia

Public Class ControladorCampeones

    Public Shared Property instance As New ControladorCampeones
    Private Property listaCampeones As New List(Of Campeon)

    Private Sub New()
    End Sub

    Public Function buscarPorNombre(nombre As String) As Campeon
        ' llamar a la Persistencia y consultar datos de campeón a partir del nombre
        If nombre.Length = 0 Then Throw New Exception("Debe ingresar un nombre")
        obtenerTodosLosCampeones()
        Dim campeon As New Campeon()

        For Each camp As Campeon In listaCampeones
            If camp.nombre = nombre Then
                campeon = camp
                Exit For  ' "break"
            End If
        Next

        Return campeon

    End Function

    Public Sub obtenerTodosLosCampeones()
        ' procedimiento que actualiza la lista local de Campeones
        Try
            Dim controladorBD As New ControladorBD()
            listaCampeones.Clear()
            listaCampeones = controladorBD.obtenerTodosLosCampeones()
            If listaCampeones.Count = 0 Then Throw New Exception("No se encontraron Campeones en la base de datos.")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Function getListaCampeones() As List(Of Campeon)
        Try
            obtenerTodosLosCampeones()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return listaCampeones
    End Function

    Public Sub agregarCampeon(campeon As Campeon)
        Try
            Dim controladorBD As New ControladorBD()
            If campeon.nombre.Length = 0 Or IsNothing(campeon.fuerza) Or IsNothing(campeon.destreza) Or IsNothing(campeon.inteligencia) Or IsNothing(campeon.resistencia) Then
                Throw New Exception("Datos incompletos")

            End If

            controladorBD.agregarCampeon(campeon)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Public Sub eliminarCampeon(nombreCampeon As String)

        For Each campeon As Campeon In listaCampeones
            If campeon.nombre = nombreCampeon Then
                Dim controladorBD As New ControladorBD()
                controladorBD.eliminarCampeon(campeon)
                Exit For
            End If
        Next
    End Sub

    Public Sub modificarCampeon(campeon As Campeon)
        Try
            Dim controladorBD As New ControladorBD()
            controladorBD.modificarCampeon(campeon)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

End Class
