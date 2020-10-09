Public Class Combatiente

    Public Property campeon As Campeon
    Public Property vida As Integer

    Public Sub New(campeon As Campeon)
        Me.vida = Constantes.VIDA_BASE + (campeon.resistencia * Constantes.VIDA_POR_RESISTENCIA)
        Me.campeon = campeon
    End Sub

End Class
