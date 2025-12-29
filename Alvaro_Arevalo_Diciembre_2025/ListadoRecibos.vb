Public Class ListadoRecibos
    Dim Pagado As Boolean = False
    Private Sub ListadoRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitulo.Text = "Recibo de " + Ex_Diciembre.AlumnoNew.ObtenerNombreCompleto()
        TxtId.Text = Ex_Diciembre.RecibosNew.IdRecibo
        TxtConcepto.Text = Ex_Diciembre.RecibosNew.Concepto
        TxtImporte.Text = Ex_Diciembre.RecibosNew.Importe
        TxtFechaPago.Text = String.Format(Ex_Diciembre.RecibosNew.FechaPago)
        If Ex_Diciembre.RecibosNew.Pagado Then
            ChPagado.Checked = 1
        Else
            ChPagado.Checked = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Pagado Then
            MessageBox.Show("Este recibo ya esta pagado, NO SE CAMBIARA NADA")
        Else
            MessageBox.Show("Vuelve a abrir para ver el recibo como pagado")
            Ex_Diciembre.RecibosNew.PagarRecibo()
            Ex_Diciembre.RecibosNew.GuardarRecibo()
            Pagado = True
        End If


        LblTitulo.Text = "Recibo de "
        TxtId.Text = ""
        TxtConcepto.Text = ""
        TxtImporte.Text = ""
        TxtFechaPago.Text = ""

        Me.Close()
    End Sub
End Class