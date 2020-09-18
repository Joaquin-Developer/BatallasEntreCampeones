Imports Logica
Imports Datos

Public Class FormCampeones

    Private Sub FormCampeones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCboxNombres()
    End Sub

    Private Sub btnVerDatosCampeon_Click(sender As Object, e As EventArgs) Handles btnVerDatosCampeon.Click
        Try
            ' obtener de la lógica un objeto de campeón a partir de un nombre
            ControladorCampeones.instance.prueba()


        Catch ex As Exception
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

        ControladorCampeones.instance.prueba()

        Dim listaNombres As New List(Of String)
        cBoxNombresCampeones.Items.Clear()

        For Each nombre As String In listaNombres
            cBoxNombresCampeones.Items.Add(nombre)
        Next

    End Sub

    Private Sub tsMenuItemAltaCampeon_Click(sender As Object, e As EventArgs) Handles tsMenuItemAltaCampeon.Click


    End Sub

    Private Sub tsMenuItemModificarCampeon_Click(sender As Object, e As EventArgs) Handles tsMenuItemModificarCampeon.Click


    End Sub
End Class