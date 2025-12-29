Public Class AddRecibos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IdRecibo As String
        Dim Concepto As String
        Dim Importe As Double

        Try
            IdRecibo = TxtId.Text
            Concepto = TxtConcepto.Text
            Importe = TxtImporte.Text
        Catch ex As Exception
            MessageBox.Show("Datos incompletos o mal introducidos, se les pondran datos por defecto")
        End Try

        Ex_Diciembre.RecibosNew.IntroducirDatos(IdRecibo, Concepto, Importe)
        MessageBox.Show("Recibo " + IdRecibo + " creado correctamente")
        Ex_Diciembre.RecibosNew.GuardarRecibo()

        Me.Close()
    End Sub
End Class