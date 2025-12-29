Public Class ListadoNotas
    Private Sub ListadoNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Listado Notas "
        TxtMedia.Text = ""
        TxtNotas.Text = ""

        lblTitulo.Text = lblTitulo.Text + Ex_Diciembre.NotasNew.NombreCurso + " " + Ex_Diciembre.AlumnoNew.ObtenerNombreCompleto()

        Dim Notas As Double() = Ex_Diciembre.NotasNew.NotasParciales
        For Each n In Notas
            TxtNotas.Text = TxtNotas.Text + Str(n) + " | "
        Next

        TxtMedia.Text = Ex_Diciembre.NotasNew.CalcularMediaParciales()
    End Sub
End Class