Imports System.IO

Public Class VerAlumnos
    Private Sub VerAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaAlumnos()
    End Sub

    Private Sub CargarListaAlumnos()
        LstAlumnos.Items.Clear()
        Dim rutaFichero As String = "Ficheros\alumnos.txt"

        If File.Exists(rutaFichero) Then
            Try
                Dim lineas As String() = File.ReadAllLines(rutaFichero)
                For Each linea As String In lineas
                    If Not String.IsNullOrWhiteSpace(linea) Then
                        Dim campos As String() = linea.Split("|"c)
                        ' Formato esperado: DNI|NMat|Nombre|Apellido1...
                        ' Mostramos: DNI - Nombre Apellido1
                        If campos.Length >= 4 Then
                            Dim info As String = $"{campos(0)} - {campos(2)} {campos(3)} {campos(4)}"
                            LstAlumnos.Items.Add(info)
                        End If
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error al leer el archivo de alumnos: " & ex.Message)
            End Try
        Else
            LstAlumnos.Items.Add("No hay alumnos registrados.")
        End If
    End Sub
End Class
