Imports Datos

Public Class ControladorBatallas

    Public Shared Property instance As New ControladorBatallas

    Public Function SimularBatallaCompleta(combatienteA As Combatiente, combatienteB As Combatiente) As Batalla
        Return New Batalla(combatienteA, combatienteB)
    End Function

    Public Function SimularRondaDeConbate(combatienteA As Combatiente, combatienteB As Combatiente) As Ronda
        Dim ronda As New Ronda()
        Atacar(combatienteA, combatienteB, ronda)
        Atacar(combatienteB, combatienteA, ronda)

        Return ronda
    End Function

    Private Sub Atacar(atacante As Combatiente, defensor As Combatiente, ronda As Ronda)

        ' verificamos probabilidad de golpesCriticos.
        Dim probabilidadCritico As Double = (atacante.campeon.destreza * Constantes.PROBABILIDAD_CRITICO_POR_DESTREZA)

        Dim daño As Double = 0 ' de donde sale el atributo daño de la fórmula wtf ??

        Dim dañoGolpeCritico As Double = atacante.campeon.fuerza + (daño * atacante.campeon.inteligencia * Constantes.BONUS_CRITICO_POR_INTELIGENCIA)


        ' restamos al defensor el daño que recibe (equivalente a la fuerza del atacante):
        defensor.vida -= atacante.campeon.fuerza

        If defensor.vida < 0 Then defensor.vida = 0

        ronda.eventos.Add("El Combatiente " & atacante.campeon.ToString & " atacó a " & defensor.campeon.ToString & vbCrLf &
                          "El daño fué de " & atacante.campeon.fuerza.ToString & " puntos de vida" & vbCrLf &
                          "Ahora, el Combatiente " & defensor.campeon.ToString & " tiene vida = " & defensor.vida & vbCrLf)

        ' NOTA: Esto también podría ir en la SimulacionBatallaCompleta para el final de la batalla.
        If defensor.vida = 0 Then
            ronda.eventos.Add("¡FINAL DE LA RONDA! Gana el combatiente " & atacante.campeon.ToString & vbCrLf)
        End If

    End Sub


End Class
