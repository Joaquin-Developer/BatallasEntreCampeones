Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub btnCampeones_Click(sender As Object, e As EventArgs) Handles btnCampeones.Click
        Dim form As FormCampeones = New FormCampeones()
        form.ShowDialog()
        'Me.Hide()
    End Sub

    Private Sub btnNuevaBatalla_Click(sender As Object, e As EventArgs) Handles btnNuevaBatalla.Click
        Dim form As FormSimulacionBatallas = New FormSimulacionBatallas()
        form.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Estas seguro que deseas salir?", vbQuestion + vbYesNo, "Confirmar salida") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
