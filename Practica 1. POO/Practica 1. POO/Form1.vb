Public Class Form1
    Private Sub PbxCalculaDistancia_Click(sender As Object, e As EventArgs) Handles PbxCalculaDistancia.Click
        Dim distancia1 As Distanciaentredospuntos
        distancia1 = New Distanciaentredospuntos()
        TxtDistancia.Text = distancia1.ConocerDistancia(Txtx1.Text, Txtx2.Text, Txty1.Text, Txty2.Text)
    End Sub
End Class
