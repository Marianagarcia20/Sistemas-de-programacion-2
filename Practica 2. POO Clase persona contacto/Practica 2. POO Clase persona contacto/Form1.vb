Public Class Form1
    Private Sub PbxRFC_Click(sender As Object, e As EventArgs) Handles PbxRFC.Click
        Dim rfc1 As Contacto
        rfc1 = New Contacto()
        TxtRfc.Text = rfc1.CalcularRfc(TxtNombre.Text, TxtApPat.Text, TxtApMat.Text, CbDia.Text, CbMes.Text, CbAño.Text)
    End Sub
End Class
