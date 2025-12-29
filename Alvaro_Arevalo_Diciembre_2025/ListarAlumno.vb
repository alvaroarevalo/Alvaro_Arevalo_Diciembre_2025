Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class ListarAlumno
    Private Sub ListarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtId.Text = Ex_Diciembre.AlumnoNew.DNI
        TxtNombre.Text = Ex_Diciembre.AlumnoNew.Nombre
        TxtApellidos.Text = Ex_Diciembre.AlumnoNew.Apellido1
        TxtApellido2.Text = Ex_Diciembre.AlumnoNew.Apellido2
        TxtMatricula.Text = Ex_Diciembre.AlumnoNew.NMat.ToString()
        TxtNacimineto.Text = Ex_Diciembre.AlumnoNew.FechaNacimiento.ToShortDateString()
        TxtEdad.Text = Ex_Diciembre.AlumnoNew.CalcularEdad().ToString()
        TxtDomicilio.Text = Ex_Diciembre.AlumnoNew.Domicilio
        TxtTelefono.Text = Ex_Diciembre.AlumnoNew.Telefono
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class