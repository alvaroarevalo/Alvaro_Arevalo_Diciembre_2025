Imports Alvaro_Arevalo_Diciembre_2025.ClasesExamenDiciembre2025
Imports Alvaro_Arevalo_Diciembre_2025.Ex_Diciembre

Public Class AddNotas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NombreCurso As String = TxtCurso.Text
        Ex_Diciembre.NotasNew.IntroducirDatosCurso(NombreCurso)
        Me.Close()
        AddNotasParciales.ShowDialog()
    End Sub


End Class