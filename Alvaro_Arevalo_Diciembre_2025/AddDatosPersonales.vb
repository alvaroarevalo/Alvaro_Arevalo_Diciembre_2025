Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class AddDatosPersonales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nombre As String
        Dim Apellido1 As String
        Dim Apellido2 As String
        Dim Domicilio As String
        Dim Telefono As String
        Dim FechaNacimiento As Date
        Dim DNI As String
        Dim NMat As Integer

        Try
            Nombre = TxtNombre.Text
            Apellido1 = TxtApellidos.Text
            Apellido2 = TxtApellido2.Text
            Domicilio = TxtDomicilio.Text
            Telefono = TxtTelefono.Text

            FechaNacimiento = DateNacimineto.Text
            DNI = TxtId.Text
            NMat = Integer.Parse(If(String.IsNullOrWhiteSpace(TxtNumeroMatricula.Text), "0", TxtNumeroMatricula.Text))

        Catch ex As Exception
            MessageBox.Show("Datos incompletos o mal introducidos, se les pondran datos por defecto")
        End Try

        Ex_Diciembre.AlumnoNew.IntroducirDatos(DNI, NMat, Nombre, Apellido1, Apellido2, Domicilio, Telefono, FechaNacimiento)
        MessageBox.Show("Alumno " + Nombre + " " + Apellido1 + " creado correctamente")
        Ex_Diciembre.AlumnoNew.GuardarAlumno()
        Me.Close()
    End Sub

    ' Validación para que solo admita números en el campo del teléfono
    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class