Public Class FormPrincipal

    Private Sub btnCampeones_Click(sender As Object, e As EventArgs) Handles btnCampeones.Click
        Dim form As FormCampeones = New FormCampeones()
        form.ShowDialog()
        'Me.Hide()
    End Sub

    Private Sub btnBatallas_Click(sender As Object, e As EventArgs) Handles btnBatallas.Click
        Dim form As FormBatallas = New FormBatallas()
        form.ShowDialog()
        'Me.Hide()
    End Sub

    Private Sub btnNuevaBatalla_Click(sender As Object, e As EventArgs) Handles btnNuevaBatalla.Click
        Dim form As FormSimulacionBatallas = New FormSimulacionBatallas()
        form.ShowDialog()
    End Sub

End Class
