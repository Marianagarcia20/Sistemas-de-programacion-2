Public Class Coordenadas
    Public punto1 As Double
    Public punto2 As Double
    Public punto3 As Double
    Public punto4 As Double

    Public Property Coordenada1() As Double
        Get
            Return punto1
        End Get
        Set(value As Double)
            punto1 = value
        End Set
    End Property

    Public Property Coordenada2() As Double
        Get
            Return punto2
        End Get
        Set(value As Double)
            punto2 = value
        End Set
    End Property

    Public Property Coordenada3() As Double
        Get
            Return punto3
        End Get
        Set(value As Double)
            punto3 = value
        End Set
    End Property

    Public Property Coordenada4() As Double
        Get
            Return punto4
        End Get
        Set(value As Double)
            punto4 = value
        End Set
    End Property

    Public Sub Coordenadas(ByVal Coordenadax1 As Double, ByVal Coordenadax2 As Double, ByVal Coordenaday1 As Double, ByVal Coordenaday2 As Double)
        punto1 = Coordenadax1
        punto2 = Coordenadax2
        punto3 = Coordenaday1
        punto4 = Coordenaday2
    End Sub
End Class
