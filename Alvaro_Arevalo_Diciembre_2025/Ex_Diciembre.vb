Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025

Public Class Ex_Diciembre
    Public AlumnoNew As Academico
    Public NotasNew As Notas
    Public RecibosNew As Recibos
    Dim AlumnoCreado As Boolean = False

    Private Sub Ex_Diciembre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        FrmCalculadora.ShowDialog()
    End Sub

    Private Sub ConversorNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversorNotasToolStripMenuItem.Click
        ConversorNotas.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CrearAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearAlumnoToolStripMenuItem.Click
        AlumnoNew = New Academico
        NotasNew = New Notas
        RecibosNew = New Recibos

        MessageBox.Show("Alumno (Académico) Creado")
        AlumnoCreado = True
    End Sub

    Private Sub BtnVerAlumnos_Click(sender As Object, e As EventArgs) Handles BtnVerAlumnos.Click
        VerAlumnos.ShowDialog()
    End Sub

    Private Sub IntroducirDatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirDatosPersonalesToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            AddDatosPersonales.Show()
        End If

    End Sub

    Private Sub ListarDatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDatosPersonalesToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            ListarAlumno.ShowDialog()
        End If
    End Sub

    Private Sub IntroducirAsignaturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirAsignaturasToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            AgregarAsignaturas.ShowDialog()
        End If
    End Sub

    Private Sub ListarAsignaturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarAsignaturasToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            ListadoAsignaturas.ShowDialog()
        End If
    End Sub

    Private Sub IntroducirDatosBancariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirDatosBancariosToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            AddRecibos.ShowDialog()
        End If
    End Sub

    Private Sub ListarDatosBancariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDatosBancariosToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            ListadoRecibos.ShowDialog()
        End If
    End Sub

    Private Sub IntroducirNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirNotasToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            AddNotas.ShowDialog()
        End If
    End Sub

    Private Sub ListarNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarNotasToolStripMenuItem.Click
        If Not AlumnoCreado Then
            MessageBox.Show("Has de Crear un Alumno")
        Else
            ListadoNotas.ShowDialog()
        End If
    End Sub
End Class
