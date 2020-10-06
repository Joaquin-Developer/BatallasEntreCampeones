Public Class FormPrincipal

    Private Sub btnCampeones_Click(sender As Object, e As EventArgs) Handles btnCampeones.Click
        Dim form As FormCampeones = New FormCampeones()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnBatallas_Click(sender As Object, e As EventArgs) Handles btnBatallas.Click
        Dim form As FormBatallas = New FormBatallas()
        form.Show()
        Me.Hide()
    End Sub

End Class
