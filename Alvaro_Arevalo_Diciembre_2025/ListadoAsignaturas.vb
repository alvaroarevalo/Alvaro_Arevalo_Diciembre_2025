Public Class ListadoAsignaturas
    Private Sub ListadoAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitulo.Text = "Listado de Asignaturas de"
        TxtAsignaturas.Text = ""
        Dim Asignaturas As String() = Ex_Diciembre.AlumnoNew.Asignaturas

        Dim NombreCompleto As String = Ex_Diciembre.AlumnoNew.ObtenerNombreCompleto()
        LblTitulo.Text = LblTitulo.Text + " " + NombreCompleto
        For Each a In Asignaturas
            TxtAsignaturas.Text = TxtAsignaturas.Text + a + " | "
        Next
    End Sub
End Class