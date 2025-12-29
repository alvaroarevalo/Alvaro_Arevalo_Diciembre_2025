Public Class ListarAlumno
    Private Sub ListarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Id As String = Ex_Diciembre.AlumnoNew.IdAlumno
        Dim Nombre As String = Ex_Diciembre.AlumnoNew.Nombre
        Dim Apellidos As String = Ex_Diciembre.AlumnoNew.Apellidos
        Dim Nacimineto As String = String.Format(Ex_Diciembre.AlumnoNew.FechaNacimiento)
        Dim NumMatricula As Integer = Ex_Diciembre.AlumnoNew.NMat
        Dim Edad As Integer = Ex_Diciembre.AlumnoNew.CalcularEdad()

        TxtId.Text = Id
        TxtNombre.Text = Nombre
        TxtApellidos.Text = Apellidos
        TxtNacimineto.Text = Nacimineto
        TxtMatricula.Text = NumMatricula
        TxtEdad.Text = Edad
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class