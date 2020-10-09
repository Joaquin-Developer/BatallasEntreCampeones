Imports Logica
Imports Datos

Public Class FormSimulacionBatallas

    Private Sub FormSimulacionBatallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' al cargar formulario se debe llenar los comboBox con los campeones
        Try
            Dim listaCampeones As List(Of Campeon) = ControladorCampeones.instance.ObtenerTodosLosCampeones()
            ' se cargan ambos comboBox en simultaneo
            For Each campeon As Campeon In listaCampeones
                cBoxCampeonA.Items.Add(campeon.ToString())
                cBoxCampeonB.Items.Add(campeon.ToString())
            Next
            cBoxCampeonA.SelectedIndex = 0
            cBoxCampeonB.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error")
        End Try

    End Sub

    Private Sub btnSimularRonda_Click(sender As Object, e As EventArgs) Handles btnSimularRonda.Click
        Try
            Dim combatienteA As New Combatiente(ControladorCampeones.instance.buscarPorNombre(cBoxCampeonA.SelectedItem.ToString))
            Dim combatienteB As New Combatiente(ControladorCampeones.instance.buscarPorNombre(cBoxCampeonA.SelectedItem.ToString))

            Dim ronda As Ronda = ControladorBatallas.instance.SimularRondaDeConbate(combatienteA, combatienteB)

            richTxtEventosRonda.Text = ""
            For Each texto As String In ronda.eventos
                richTxtEventosRonda.Text += (texto & vbCrLf)
            Next

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            MsgBox(ex.Message, vbCritical, "Se produjo un error")
        End Try
    End Sub

    Private Sub btnSimularBatalla_Click(sender As Object, e As EventArgs) Handles btnSimularBatalla.Click
        Try
            Dim combatienteA As New Combatiente(ControladorCampeones.instance.buscarPorNombre(cBoxCampeonA.SelectedItem.ToString))
            Dim combatienteB As New Combatiente(ControladorCampeones.instance.buscarPorNombre(cBoxCampeonA.SelectedItem.ToString))

            Dim batalla As Batalla = ControladorBatallas.instance.SimularBatallaCompleta(combatienteA, combatienteB)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            MsgBox(ex.Message, vbCritical, "Se produjo un error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir de la simulación de batallas?", vbQuestion + vbYesNo, "Confirmar salida") = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub

End Class
