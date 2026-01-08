Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class ListadoAsignaturas
    Private Sub ListadoAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitulo.Text = "Listado de Asignaturas de"
        TxtAsignaturas.Text = ""

        Dim Asignaturas As System.Collections.ArrayList = Ex_Diciembre.AlumnoNew.ListaAsignaturas

        Dim NombreCompleto As String = Ex_Diciembre.AlumnoNew.ObtenerNombreCompleto()
        LblTitulo.Text = LblTitulo.Text + " " + NombreCompleto
        For Each a In Asignaturas
            TxtAsignaturas.Text = TxtAsignaturas.Text + a.ToString() + " | "
        Next
    End Sub


End Class