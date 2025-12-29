Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

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

    Private Sub TxtNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If
    End Sub


End Class