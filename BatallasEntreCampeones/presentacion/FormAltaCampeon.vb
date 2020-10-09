Imports Datos
Imports Logica

Public Class FormAltaCampeon

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim campeon As New Campeon()
            campeon.nombre = txtNombre.Text
            campeon.destreza = nudDestreza.Value
            campeon.fuerza = nudFuerza.Value
            campeon.resistencia = nudResistencia.Value
            campeon.inteligencia = nudInteligencia.Value
            ControladorCampeones.instance.agregarCampeon(campeon)
            MsgBox("¡El campeon " & campeon.nombre & " se agrego con exito!", vbInformation, "Mensaje")
            setearForm()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al agregar un campeon al sistema")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        Dim form As New FormCampeones()
        form.ShowDialog()

    End Sub

    Public Sub setearForm()
        txtNombre.Text = ""
        nudDestreza.Value = 0
        nudFuerza.Value = 0
        nudInteligencia.Value = 0
        nudResistencia.Value = 0
    End Sub

End Class