Imports System.Runtime.InteropServices

Public Class FormPrincipal

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None  ' quito borde y barra de titulo del Form
        btnSalir_BarraTitulo.BackColor = Color.FromArgb(175, 5, 23)
    End Sub

    Private Sub btnCampeones_Click(sender As Object, e As EventArgs) Handles btnCampeones.Click

        'FormCampeones.instance.ShowDialog()


        Dim form As FormCampeones = New FormCampeones()
        form.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnNuevaBatalla_Click(sender As Object, e As EventArgs) Handles btnNuevaBatalla.Click
        Dim form As FormSimulacionBatallas = New FormSimulacionBatallas()
        form.ShowDialog()
    End Sub

    Private Sub btnSalir_BarraTitulo_Click(sender As Object, e As EventArgs) Handles btnSalir_BarraTitulo.Click
        Application.Exit()
    End Sub

    Private Sub btnSalir_BarraTitulo_MouseEnter(sender As Object, e As EventArgs) Handles btnSalir_BarraTitulo.MouseEnter
        btnSalir_BarraTitulo.BackColor = Color.FromArgb(249, 3, 49)

    End Sub

    Private Sub btnSalir_BarraTitulo_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir_BarraTitulo.MouseLeave
        btnSalir_BarraTitulo.BackColor = Color.FromArgb(175, 5, 23)
    End Sub

    Private Sub pnlBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class
