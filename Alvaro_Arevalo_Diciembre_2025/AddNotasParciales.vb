Public Class AddNotasParciales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nota As Double
        Try
            Nota = TxtNota.Text
            Ex_Diciembre.NotasNew.AgregarNotaParcial(Nota)
            TxtNota.Text = ""
            TxtNota.Focus()
            Ex_Diciembre.NotasNew.GuardarNota()
        Catch ex As Exception
            MessageBox.Show("Nota no válida")
        End Try
    End Sub
End Class