Imports Alvaro_Arevalo_Diciembre_2025.Colegio
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class AddDatosPersonales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nombre As String
        Dim Apellidos As String
        Dim FechaNacimiento As Date
        Dim Id As String
        Dim NMat As Integer

        Try
            Nombre = TxtNombre.Text
            Apellidos = TxtApellidos.Text
            FechaNacimiento = DateNacimineto.Text
            Id = TxtId.Text
            NMat = TxtNumeroMatricula.Text
        Catch ex As Exception
            MessageBox.Show("Datos incompletos o mal introducidos, se les pondran datos por defecto")
        End Try

        Ex_Diciembre.AlumnoNew.IntroducirDatos(Id, NMat, Nombre, Apellidos, FechaNacimiento)
        MessageBox.Show("Alumno " + Nombre + " " + Apellidos + " creado correctamente")
        Ex_Diciembre.AlumnoNew.GuardarAlumno()
        Me.Close()
    End Sub
End Class