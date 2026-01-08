Imports System.IO

Public Class VerAlumnos
    Private Sub VerAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim alumno As New ClasesExamenDiciembre2025.Alumno()
        alumno.CargarListaAlumnos(LstAlumnos)
    End Sub
End Class
