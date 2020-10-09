Imports Logica
Imports Datos

Public Class FormCampeones

    Private Sub FormCampeones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupBoxDatos.Visible = False
        llenarCboxNombres()
    End Sub

    Private Sub llenarCboxNombres()
        Try
            Dim listaCampeones As List(Of Campeon) = ControladorCampeones.instance.ObtenerTodosLosCampeones()

            cBoxNombresCampeones.Items.Clear()  'antes de llenar comboBox elimino sus items en caso de haberlos

            For Each campeon As Campeon In listaCampeones
                cBoxNombresCampeones.Items.Add(campeon.nombre)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Se reiniciara la App.", vbCritical, "Error")
            Application.Restart()
        End Try

    End Sub

    Public Sub setearGroupBox()
        groupBoxDatos.Visible = True
        lblDestreza.Text = "Destreza: ***"
        lblFuerza.Text = "Fuerza: ***"
        lblInteligencia.Text = "Inteligencia: ***"
        lblResistencia.Text = "Resistencia: ***"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ControladorCampeones.instance.eliminarCampeon(cBoxNombresCampeones.SelectedItem.ToString)
            MsgBox("El campeon " & cBoxNombresCampeones.SelectedItem.ToString & " se eliminó.", vbInformation, "Mensaje.")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            llenarCboxNombres()
        End Try
    End Sub

    Private Sub btnModificarCampeon_Click(sender As Object, e As EventArgs) Handles btnModificarCampeon.Click
        ' abro un nuevo form de modificar
        ' envio objeto del campeon que quiero modificar
        Try
            Dim form As FormModificarCampeon = New FormModificarCampeon()
            form.campeonModificar = ControladorCampeones.instance.buscarPorNombre(cBoxNombresCampeones.SelectedItem.ToString)
            form.ShowDialog()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnAltaCampeon_Click(sender As Object, e As EventArgs) Handles btnAltaCampeon.Click
        Dim form As FormAltaCampeon = New FormAltaCampeon()
        form.ShowDialog()
        'form.Show()
    End Sub

    Private Sub cBoxNombresCampeones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxNombresCampeones.SelectedIndexChanged
        Try
            ' obtener de la lógica un objeto de campeón a partir de un nombre
            Dim campeon As New Campeon
            campeon = ControladorCampeones.instance.buscarPorNombre(cBoxNombresCampeones.SelectedItem.ToString)
            groupBoxDatos.Visible = True
            lblDestreza.Text = "Destreza: " & campeon.destreza.ToString
            lblFuerza.Text = "Fuerza: " & campeon.fuerza.ToString
            lblInteligencia.Text = "Inteligencia: " & campeon.inteligencia.ToString
            lblResistencia.Text = "Resistencia: " & campeon.resistencia.ToString

        Catch ex As Exception
            setearGroupBox()
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

End Class

