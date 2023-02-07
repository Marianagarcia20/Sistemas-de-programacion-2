Public Class Persona
    Public Nombre As String
    Public ApPat As String
    Public ApMat As String
    Public Dia As String
    Public Mes As String
    Public Año As String

    Public Property NombreP() As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property ApPatP() As String
        Get
            Return ApPat
        End Get
        Set(value As String)
            ApPat = value
        End Set
    End Property

    Public Property ApMatP() As String
        Get
            Return ApMat
        End Get
        Set(value As String)
            ApMat = value
        End Set
    End Property

    Public Property DiaP() As String
        Get
            Return Dia
        End Get
        Set(value As String)
            Dia = value
        End Set
    End Property

    Public Property MesP() As String
        Get
            Return Mes
        End Get
        Set(value As String)
            Mes = value
        End Set
    End Property

    Public Property AñoP() As String
        Get
            Return Año
        End Get
        Set(value As String)
            Año = value
        End Set
    End Property

    Public Sub Persona(ByVal Nombre1 As String, ByVal ApPat1 As String, ByVal ApMat1 As String, ByVal DiaP1 As String, ByVal MesP1 As String, ByVal AñoP1 As String)
        Nombre = Nombre1
        ApPat = ApPat1
        ApMat = ApMat1
        Dia = DiaP1
        Mes = MesP1
        Año = AñoP1
    End Sub

    Public ReadOnly Property CalcularRfc(ByVal Nombre1 As String, ByVal ApPat1 As String, ByVal ApMat1 As String, ByVal DiaP1 As String, ByVal MesP1 As String, ByVal AñoP1 As String) As String
        Get
            Dim codigo As Integer
            Dim RFC As String
            codigo = AñoP1.Length
            ApPat1 = ApPat1.Substring(0, 2)
            ApMat1 = ApMat1.Substring(0, 1)
            Nombre1 = Nombre1.Substring(0, 1)
            AñoP1 = AñoP1.Substring(2, 2)
            MesP1 = MesP1.Substring(0, 2)
            DiaP1 = DiaP1.Substring(0, 2)
            RFC = ApPat1 + ApMat1 + Nombre1 + AñoP1 + MesP1 + DiaP1
            Return RFC
        End Get
    End Property
End Class
