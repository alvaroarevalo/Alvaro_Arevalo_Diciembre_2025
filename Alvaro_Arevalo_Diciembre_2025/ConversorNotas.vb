Public Class ConversorNotas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConvertir.Click
        Dim Numero As Integer
        Dim ErrorTxt As Boolean = False
        Try
            Numero = Int(TxtNum.Text)
        Catch ex As Exception
            ErrorTxt = True
        End Try

        If ErrorTxt Then
            LblConverter.Text = "Algo salio Mal"
        Else

            If Numero = 0 Or Numero = 1 Or Numero = 2 Or Numero = 3 Or Numero = 4 Then
                LblConverter.Text = "Insuficiente"
            ElseIf Numero = 5 Then
                LblConverter.Text = "Suficiente"
            ElseIf Numero = 6 Then
                LblConverter.Text = "Bien"
            ElseIf Numero = 7 Or Numero = 8 Then
                LblConverter.Text = "Notable"
            ElseIf Numero = 9 Or Numero = 10 Then
                LblConverter.Text = "Sobresaliente"
            ElseIf Numero > 10 Or Numero < 0 Then
                LblConverter.Text = "Nota No valida"
            End If
        End If
    End Sub

End Class