Public Class Distanciaentredospuntos
    Inherits Coordenadas

    Public Sub Distancia(Coordenadax1 As Double, Coordenadax2 As Double, Coordenaday1 As Double, Coordenaday2 As Double)
        Dim Coordenadas1 As Coordenadas
        Coordenadas1 = New Coordenadas()
        Coordenadas1.Coordenadas(Coordenadax1, Coordenadax2, Coordenaday1, Coordenaday2)
    End Sub

    Public Function ConocerDistancia(Coordenadax1 As Double, Coordenadax2 As Double, Coordenaday1 As Double, Coordenaday2 As Double)
        Dim distancia As Double
        distancia = Math.Sqrt((Coordenadax2 - Coordenadax1) ^ 2 + (Coordenaday2 - Coordenaday1) ^ 2)
        Return distancia
    End Function
End Class
