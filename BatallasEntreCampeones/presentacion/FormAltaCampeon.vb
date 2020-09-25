Imports Datos
Imports Logica

Public Class FormAltaCampeon

    Private Sub FormAltaCampeon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim campeon As New Campeon()
            campeon.nombre = txtNombre.Text
            campeon.destreza = nudDestreza.Value
            campeon.fuerza = nudFuerza.Value
            campeon.resistencia = nudResistencia.Value
            campeon.inteligencia = nudInteligencia.Value
            ControladorCampeones.instance.agregarCampeon(campeon)
            setearForm()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al agregar un campeon al sistema")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Public Sub setearForm()
        txtNombre.Text = ""
        nudDestreza.Value = 0
        nudFuerza.Value = 0
        nudInteligencia.Value = 0
        nudResistencia.Value = 0
    End Sub

End Class