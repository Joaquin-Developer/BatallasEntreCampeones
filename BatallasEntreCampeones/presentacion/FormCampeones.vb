Imports Logica
Imports Datos

Public Class FormCampeones

    Private Sub FormCampeones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupBoxDatos.Visible = False
        llenarCboxNombres()
    End Sub

    Private Sub btnVerDatosCampeon_Click(sender As Object, e As EventArgs) Handles btnVerDatosCampeon.Click
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

    Private Sub llenarCboxNombres()
        ' consultar a la logica todos los nombres de los campeónes
        ' que hay en la base de datos
        ' se deberán llenar en el comboBox con los nombres
        Try
            Dim listaCampeones As New List(Of Campeon)
            listaCampeones = ControladorCampeones.instance.getListaCampeones()
            cBoxNombresCampeones.Items.Clear()

            For Each campeon As Campeon In listaCampeones
                cBoxNombresCampeones.Items.Add(campeon.nombre)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Se reiniciara la App.", vbCritical, "Error")
            Application.Restart()
        End Try

    End Sub

    Private Sub tsMenuItemAltaCampeon_Click(sender As Object, e As EventArgs) Handles tsMenuItemAltaCampeon.Click
        Dim form As FormAltaCampeon = New FormAltaCampeon()
        form.ShowDialog()
    End Sub

    Private Sub tsMenuItemModificarCampeon_Click(sender As Object, e As EventArgs) Handles tsMenuItemModificarCampeon.Click
        Dim form As FormModificarCampeon = New FormModificarCampeon()
        form.ShowDialog()
    End Sub

    Public Sub setearGroupBox()
        groupBoxDatos.Visible = True
        lblDestreza.Text = "Destreza: ***"
        lblFuerza.Text = "Fuerza: ***"
        lblInteligencia.Text = "Inteligencia: ***"
        lblResistencia.Text = "Resistencia: ***"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' baja de campeon

    End Sub

    Private Sub btnModificarCampeon_Click(sender As Object, e As EventArgs) Handles btnModificarCampeon.Click
        ' abro un nuevo form de modificar
        ' envio objeto del campeon que quiero modificar
        Try
            Dim form As FormModificarCampeon = New FormModificarCampeon()
            form.campeonModificar = ControladorCampeones.instance.buscarPorNombre(cBoxNombresCampeones.SelectedItem.ToString)
            form.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class