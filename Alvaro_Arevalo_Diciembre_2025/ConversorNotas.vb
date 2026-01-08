Public Class ConversorNotas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConvertir.Click
        Dim Numero As Double
        Dim ErrorTxt As Boolean = False
        Try
            Numero = Double.Parse(TxtNum.Text)
        Catch ex As Exception
            ErrorTxt = True
        End Try

        If ErrorTxt Then
            LblConverter.Text = "Algo salio Mal"
        Else
            If Numero < 0 Or Numero > 10 Then
                LblConverter.Text = "Nota No valida"
            ElseIf Numero < 5 Then
                LblConverter.Text = "Insuficiente"
            ElseIf Numero < 6 Then
                LblConverter.Text = "Suficiente"
            ElseIf Numero < 7 Then
                LblConverter.Text = "Bien"
            ElseIf Numero < 9 Then
                LblConverter.Text = "Notable"
            Else
                LblConverter.Text = "Sobresaliente"
            End If
        End If
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        ' Solo se permiten números, tecla de borrado y una coma (nota decimal)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If

        ' Evitar más de una coma
        If e.KeyChar = ","c AndAlso TxtNum.Text.IndexOf(","c) > -1 Then
            e.Handled = True
        End If
    End Sub

End Class