Imports Datos
Imports Persistencia

Public Class ControladorCampeones

    Public Shared Property instance As New ControladorCampeones

    Private Sub New()
    End Sub

    Public Function prueba() As String
        Return "hola"
    End Function

    Public Function buscarPorNombre(nombre As String) As Campeon

        'Dim campeon As New Campeon()
        ' llamar a la Persistencia y consultar datos de campeón a partir del nombre
        Dim conexion As New ControladorBD()     ' cambiar por: Dim con as ControladorBD = conectar()
        Dim campeon As Campeon = conexion.obtenerCampeon(nombre)

        If IsNothing(campeon) Then
            Throw New Exception("No se encontró el Campeón solicitado.")
        End If
        Return campeon

    End Function

    Public Sub modificarCampeon(campeon As Campeon)

        'Dim conexion As ControladorBD = ControladorBD.




    End Sub

End Class
