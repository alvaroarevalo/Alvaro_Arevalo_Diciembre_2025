Public Class AddNotas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NombreCurso As String = TxtCurso.Text
        Ex_Diciembre.NotasNew.IntroducirDatos(NombreCurso)
        Me.Close()
        AddNotasParciales.ShowDialog()
    End Sub
End Class