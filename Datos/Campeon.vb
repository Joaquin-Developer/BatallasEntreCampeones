Public Class Campeon

    Public Property id As Integer
    Public Property nombre As String
    Public Property fuerza As Integer
    Public Property destreza As Integer
    Public Property inteligencia As Integer
    Public Property resistencia As Integer

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, fuerza As Integer, destreza As Integer,
                   inteligencia As Integer, resistencia As Integer)
        Me.id = id
        Me.nombre = nombre
        Me.fuerza = fuerza
        Me.destreza = destreza
        Me.inteligencia = inteligencia
        Me.resistencia = resistencia
    End Sub





End Class
