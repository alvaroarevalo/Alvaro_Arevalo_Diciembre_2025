Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class AgregarAsignaturas
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim NewAsignatura As String = TxtAsignatura.Text
        ' Usamos AgregarAsignatura de la clase Academico
        Ex_Diciembre.AlumnoNew.AgregarAsignatura(NewAsignatura)
        TxtAsignatura.Text = ""
        TxtAsignatura.Focus()
    End Sub


End Class