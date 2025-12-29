Public Class AgregarAsignaturas
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim NewAsignatura As String = TxtAsignatura.Text
        Ex_Diciembre.AlumnoNew.IntroducirAsignaturas(NewAsignatura)
        TxtAsignatura.Text = ""
        TxtAsignatura.Focus()
    End Sub
End Class