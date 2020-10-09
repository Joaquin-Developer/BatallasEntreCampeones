Public Class Ronda

    Public Property eventos As List(Of String)

    Public Sub New()
    End Sub

    Public Sub AgregarEvento(evento As String)
        eventos.Add(evento)
    End Sub

    Public Overrides Function ToString() As String
        Dim cadenaEventos As String = ""
        For Each evento As String In Me.eventos
            cadenaEventos += (evento & vbCrLf)
        Next
        Return cadenaEventos
    End Function

End Class
