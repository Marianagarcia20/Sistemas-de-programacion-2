Public Class Contacto
    Inherits Persona
    Public NumTelef As Integer
    Public CorreoE As String

    Public Property NumTelefC() As Integer
        Get
            Return NumTelef
        End Get
        Set(value As Integer)
            NumTelef = value
        End Set
    End Property

    Public Property CorreoEC() As String
        Get
            Return CorreoE
        End Get
        Set(value As String)
            CorreoE = value
        End Set
    End Property

    Public Sub Contacto(ByVal Nombre1 As String, ByVal ApPat1 As String, ByVal ApMat1 As String, ByVal DiaP1 As String,
                        ByVal MesP1 As String, ByVal AñoP1 As String, ByVal NumTelef1 As Integer, ByVal CorreoE1 As String)
        Nombre = Nombre1
        ApPat = ApPat1
        ApMat = ApMat1
        Dia = DiaP1
        Mes = MesP1
        Año = AñoP1
        NumTelef = NumTelef1
        CorreoE = CorreoE1
    End Sub
End Class
