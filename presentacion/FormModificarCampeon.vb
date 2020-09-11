Imports Datos
Imports Logica

Public Class FormModificarCampeon

    Public Property campeonModificar As New Campeon()

    Private Sub FormModificarCampeon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' cargar datos del objeto en el formulario:
            lblIdCampeon.Text = campeonModificar.id.ToString
            txtNombre.Text = campeonModificar.nombre
            nudFuerza.Value = campeonModificar.fuerza
            nudDestreza.Value = campeonModificar.destreza
            nudInteligencia.Value = campeonModificar.inteligencia
            nudResistencia.Value = campeonModificar.resistencia

        Catch ex As Exception
            Console.WriteLine("Error en evento FormModificarCampeon_Load() : " & ex.Message)
            MsgBox("No se pudieron obtener los datos del campeón." & vbCrLf & "Se volverá al menú.", vbCritical, "Se produjo un error.")
            Me.Hide()
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'ControladorCampeones.instance.prueba()
        Try

        Catch ex As Exception
            Console.WriteLine("Error en evento btnmodificar_Click() : " & ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

End Class