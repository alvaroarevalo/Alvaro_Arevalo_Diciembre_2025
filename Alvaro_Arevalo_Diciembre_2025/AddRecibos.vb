Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class AddRecibos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IdRecibo As String
        Dim Concepto As String
        Dim Importe As Double

        Try
            IdRecibo = TxtId.Text
            Concepto = TxtConcepto.Text
            Importe = Double.Parse(TxtImporte.Text) ' Aseguramos conversion
        Catch ex As Exception
            MessageBox.Show("Datos incompletos o mal introducidos, se les pondran datos por defecto")
        End Try

        ' Usamos IntroducirDatosRecibo
        Ex_Diciembre.RecibosNew.IntroducirDatosRecibo(IdRecibo, Concepto, Importe)
        MessageBox.Show("Recibo " + IdRecibo + " creado correctamente")
        Ex_Diciembre.RecibosNew.GuardarRecibo()

        Me.Close()
    End Sub


End Class