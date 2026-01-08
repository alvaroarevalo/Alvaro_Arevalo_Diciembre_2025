Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class ListadoNotas
    Private Sub ListadoNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Listado Notas "
        TxtMedia.Text = ""
        TxtNotas.Text = ""

        lblTitulo.Text = lblTitulo.Text + Ex_Diciembre.NotasNew.NombreCurso + " " + Ex_Diciembre.AlumnoNew.ObtenerNombreCompleto()

        Dim Notas As Double() = Ex_Diciembre.NotasNew.NotasParciales
        If Notas IsNot Nothing Then
            For Each n In Notas
                 If n > 0 OrElse Notas.Length = 1 Then 
                     TxtNotas.Text = TxtNotas.Text + Str(n) + " | "
                 End If
            Next
        End If

        TxtMedia.Text = Ex_Diciembre.NotasNew.CalcularMediaParciales()
    End Sub


End Class