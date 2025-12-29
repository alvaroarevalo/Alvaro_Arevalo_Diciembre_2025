Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class ListadoRecibos
    Dim Pagado As Boolean = False
    Private Sub ListadoRecibos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitulo.Text = "Recibo de " + Ex_Diciembre.AlumnoNew.ObtenerNombreCompleto()
        TxtId.Text = Ex_Diciembre.RecibosNew.IdRecibo
        TxtConcepto.Text = Ex_Diciembre.RecibosNew.Concepto
        TxtImporte.Text = Ex_Diciembre.RecibosNew.Importe.ToString("C2") ' Formato moneda
        TxtFechaPago.Text = If(Ex_Diciembre.RecibosNew.Pagado, Ex_Diciembre.RecibosNew.FechaPago.ToShortDateString(), "PENDIENTE")
        If Ex_Diciembre.RecibosNew.Pagado Then
            ChPagado.Checked = True
            Pagado = True
        Else
            ChPagado.Checked = False
            Pagado = False
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