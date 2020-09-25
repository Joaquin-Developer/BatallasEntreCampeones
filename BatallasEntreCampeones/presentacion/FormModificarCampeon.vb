Imports Datos
Imports Logica

Public Class FormModificarCampeon

    Public Property campeonModificar As New Campeon()

    Private Sub FormModificarCampeon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cargar datos del objeto en el formulario:
        lblIdCampeon.Text = campeonModificar.id.ToString
        txtNombre.Text = campeonModificar.nombre
        nudFuerza.Value = campeonModificar.fuerza
        nudDestreza.Value = campeonModificar.destreza
        nudInteligencia.Value = campeonModificar.inteligencia
        nudResistencia.Value = campeonModificar.resistencia

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim campeon As New Campeon()
            campeon.nombre = txtNombre.Text
            campeon.destreza = nudDestreza.Value
            campeon.fuerza = nudFuerza.Value
            campeon.resistencia = nudResistencia.Value
            campeon.inteligencia = nudInteligencia.Value
            ControladorCampeones.instance.modificarCampeon(campeon)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

End Class